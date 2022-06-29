namespace Gelisme.mymiddleware
{
    public static class CustomExtension
    {
        public static IApplicationBuilder UseChekToken(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ChekTokenMiddleware>();
        }
    }
}