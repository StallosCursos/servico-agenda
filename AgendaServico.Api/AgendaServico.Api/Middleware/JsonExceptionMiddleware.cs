using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace AgendaServico.Api.Middleware
{
    public class JsonExceptionMiddleware
    {
        private readonly IWebHostEnvironment _env;

        public JsonExceptionMiddleware(IWebHostEnvironment env)
        {
            this._env = env;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var ex = context.Features.Get<IExceptionHandlerFeature>()?.Error;
            if (ex == null) return;

            var error = new
            {
                message = ex.Message,
                innerException = ex.InnerException?.Message
            };

            context.Response.ContentType = "application/json";

            if (this._env.IsDevelopment())
                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");

            using var writer = new StreamWriter(context.Response.Body);
            new JsonSerializer().Serialize(writer, error);
            await writer.FlushAsync().ConfigureAwait(false);
        }
    }
}
