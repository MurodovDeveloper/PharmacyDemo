namespace Pharmacy.Middlewares
{
    public class GlobalExeptionHendler
    {
        private readonly RequestDelegate _next;

        public GlobalExeptionHendler(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {

                context.Response.StatusCode = 200;
                await context.Response.WriteAsync(e!.ToString()!);
            }
        }
    }
}

