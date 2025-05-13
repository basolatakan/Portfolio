namespace Portfolio.Middlewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)  //mimari otomatik olarak HelloMiddleware kullanıktan sonra gelen middlewareı next e verecektir.
        {   
            _next = next;            
        }

        public async Task Invoke(HttpContext context) 
        { 
            
        }
    }
}
