using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using System;
using AutofacSerilogIntegration;
using Microsoft.Extensions.Logging;
using Autofac.Extensions.DependencyInjection;
using FundaApiTest.WrappingApi;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FundaApiTest
{
    public class Startup
    {
        // Setting up Autofac for Dependency Injection / IOC, along with configuring Logging.

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}", restrictedToMinimumLevel: LogEventLevel.Information)
                .CreateLogger();

            services.AddLogging(option =>
            {
                option.ClearProviders();
                option.AddSerilog(Log.Logger, true);
            });

            var builder = new ContainerBuilder();
            builder.RegisterLogger();
            builder.Populate(services);

            builder.RegisterType<FundaApiWrapper>().As<IWrapFundaApi>()
                .WithParameter("apiKey", "ac1b0b1572524640a0ecc54de453ea9f")
                .WithParameter("httpClient", new HttpClient { DefaultRequestHeaders = { Accept = { MediaTypeWithQualityHeaderValue.Parse("application/xml") } }, BaseAddress = new Uri("http://partnerapi.funda.nl/feeds/Aanbod.svc/") });

            return new AutofacServiceProvider(builder.Build());
        }
    }
}
