using Tufan.Authority.Application;
using Tufan.Authority.Domain;
using Tufan.Authority.Domain.Persistance;
using Tufan.Authority.Infrastructure;
using Tufan.Authority.Infrastructure.Repository;
using Tufan.Authority.Middlewares;
using Tufan.Common.Abstraction;
using Tufan.Common.Configuration;
using Tufan.Common.Extension;
using Tufan.Common.Localization;
using Tufan.Common.Logging;
using Tufan.Common.Validation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NLog.Extensions.Logging;
using System.Linq;
using Tufan.ExternalServices.ObiletApi;
using Tufan.Common.Http;
using Tufan.Authority.Providers;
using System.Net.Http;

namespace Tufan.Authority
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            AddValidation(services);
            AddLogging(services);
            AddConfiguration(services);
            AddCustom(services);
            AddMediatr(services);
            AddMapper(services);
            AddSwagger(services);
            //AddCache(services);
            AddLocalization(services);
            AddDomainServices(services);
            AddExternalServices(services);
        }

        private void AddExternalServices(IServiceCollection services)
        {
            services.AddSingleton<HttpMethodCreator>();
            services.AddSingleton<ITokenProvider, TokenProvider>();
            services.AddScoped<ObiletApi>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<HttpClient>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            UseLocalization(app);
            app.UseInternalExceptionHandler();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tufan.Authority API V1");
            });
            
            app.UseStaticFiles();
            app.Use(async (ctx, next) =>
            {
                if (ctx.Request.Path.StartsWithSegments("/"))
                {
                    ctx.Response.Redirect("/swagger/index.html");
                }
                else
                {
                    await next.Invoke();
                }
            });
        }

        private void AddLocalization(IServiceCollection services)
        {
            services.AddJsonLocalization(options =>
            {
                options.ResourcesPath = "Resources";
            });
        }

        private void UseLocalization(IApplicationBuilder app)
        {
            var localizationOptions = new RequestLocalizationOptions();
            localizationOptions.SetDefaultCulture("tr-TR");
            localizationOptions.AddSupportedCultures(new string[] { "tr-TR", "en-US" });
            localizationOptions.AddSupportedUICultures(new string[] { "tr-TR", "en-US" });
            app.UseRequestLocalization(localizationOptions);
        }

        private void AddCache(IServiceCollection services)
        {
            services.AddCacheManagerService(Configuration);
        }

        private void AddLogging(IServiceCollection services)
        {
            var nlogConfigPath = Configuration.GetValue<string>("Logging:LogConfigFile");
            services.AddLogging(c => c.AddConsole().AddDebug().AddConfiguration(Configuration).AddNLog(nlogConfigPath));

            services.AddSingleton<ILogService, NLogService>();
        }

        private void AddValidation(IServiceCollection services)
        {
            services.AddControllers()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ApplicationInitializer>());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }

        private void AddConfiguration(IServiceCollection services)
        {
            IConfigResolver configResolver = new ConfigResolver(Configuration);
            var urlConfig = configResolver.Resolve<UrlConfig>();

            services.AddSingleton(urlConfig);
            services.AddSingleton(configResolver);
        }
        private void AddCustom(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
        private void AddMediatr(IServiceCollection services)
        {
            services.AddMediatR(typeof(ApplicationInitializer).Assembly);
        }
        private void AddDomainServices(IServiceCollection services)
        {
            var domainServices = typeof(DomainInitializer).Assembly.GetTypes().Where(x =>
                typeof(IDomainService).IsAssignableFrom(x) &&
                !x.IsInterface &&
                !x.IsAbstract);

            foreach (var domainService in domainServices)
                services.AddScoped(domainService);

            services.AddScoped<ISessionRepository, SessionRepository>();
        }
        private void AddMapper(IServiceCollection services)
        {
            services.AddAutoMapper(
               typeof(ApplicationInitializer).Assembly,
               typeof(InfrastructureInitializer).Assembly,
               typeof(Startup).Assembly,
               typeof(DomainInitializer).Assembly);
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tufan.Authority API", Version = "v1" });
            });
        }
    }
}
