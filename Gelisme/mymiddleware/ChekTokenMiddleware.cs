namespace Gelisme.mymiddleware
{
    public class ChekTokenMiddleware
    {
        private readonly RequestDelegate _next;
        public ChekTokenMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            string token = context.Request.Headers["token"];
            if (token != null)
            {
                await _next(context);
            }
            else
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("sen kimsin.....");
            }
        }
    }
}
