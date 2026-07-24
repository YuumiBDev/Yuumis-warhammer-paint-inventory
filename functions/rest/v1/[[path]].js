// Proxy for Supabase REST calls. The browser app calls /rest/v1/* on its own
// origin; this function forwards to your Supabase project using the anon key.
//
// Configure these as environment variables on your Cloudflare Pages project
// (Dashboard -> your project -> Settings -> Environment variables):
//   SUPABASE_URL         e.g. https://your-project-ref.supabase.co
//   SUPABASE_ANON_KEY    Supabase -> Project Settings -> API -> anon/public key
//
// The anon key stays server-side (only this function ever sees it) — but data
// is only as safe as your Supabase Row Level Security policies, since this
// proxy doesn't add its own authentication. See SETUP.md for adding a login
// wall if you want one.

export async function onRequest(ctx) {
  const { request, params, env } = ctx

  if (!env.SUPABASE_URL || !env.SUPABASE_ANON_KEY) {
    return new Response(JSON.stringify({ error: 'SUPABASE_URL / SUPABASE_ANON_KEY not configured' }), {
      status: 500,
      headers: { 'Content-Type': 'application/json' },
    })
  }

  const url = new URL(request.url)
  const sub = Array.isArray(params.path) ? params.path.join('/') : (params.path || '')
  const target = `${env.SUPABASE_URL}/rest/v1/${sub}${url.search}`

  const headers = new Headers()
  headers.set('apikey', env.SUPABASE_ANON_KEY)
  headers.set('Authorization', `Bearer ${env.SUPABASE_ANON_KEY}`)
  for (const h of ['Content-Type', 'Prefer', 'Accept']) {
    const v = request.headers.get(h)
    if (v) headers.set(h, v)
  }

  const init = { method: request.method, headers }
  if (request.method !== 'GET' && request.method !== 'HEAD') {
    init.body = await request.text()
  }

  const resp = await fetch(target, init)
  const outHeaders = new Headers()
  for (const h of ['Content-Type', 'Content-Range', 'Content-Profile']) {
    const v = resp.headers.get(h)
    if (v) outHeaders.set(h, v)
  }
  return new Response(resp.body, { status: resp.status, headers: outHeaders })
}
