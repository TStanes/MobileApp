namespace Sobas_Mob_Web
{
    public class MobileAppMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _config;

        public MobileAppMiddleware(RequestDelegate next, IConfiguration config)
        {
            _next = next;
            _config = config;
        }

        public async Task Invoke(HttpContext context)
        {
            // Allow token generation endpoint
            if (context.Request.Path.StartsWithSegments("/api/token/GenerateToken"))
            {
                await _next(context);
                return;
            }

            var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();

            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer"))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized - Mobile App Only");
                return;
            }

            var token = authHeader.Substring("Bearer ".Length).Trim();

            if (string.IsNullOrEmpty(token))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Invalid Token");
                return;
            }

            await _next(context);
        }
    }
}
