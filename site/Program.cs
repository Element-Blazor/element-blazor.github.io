using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Element;
using Element.Lang;
using Element.Markdown;
using Element.X;
using System.Net.Http;

namespace Element.ClientRender
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddElementServices();
            builder.Services.AddMarkdown();
            builder.Services.AddElementX();
            await builder.Build().RunAsync();
        }
    }
}
