using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Net.Http;
using Tufan.Common.Abstraction;
using Tufan.Common.Authentication;
using Tufan.Common.Configuration;
using Tufan.Common.Http;
using Tufan.Common.Localization;
using Tufan.TicketApi.Client;
using Tufan.Web.UI.Adapters;
using Tufan.Web.UI.Middlewares;
using Tufan.Web.UI.Providers;

namespace Tufan.Web.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            AddConfigurationAndAuthentication(services);
            AddMapper(services);
            AddLocalization(services);
            AddDomainServices(services);
            AddExternalServices(services);
        }

        private void AddExternalServices(IServiceCollection services)
        {
            services.AddTransient<HttpMethodCreator>();
            services.AddScoped<ITokenProvider, TokenProvider>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<HttpClient>();

            services.AddTransient<AuthorityApi.Client.AuthorityApi>();
            services.AddTransient<TicketApi.Client.TicketApi>();
            services.AddTransient<AuthorityAdapter>();
            services.AddTransient<TicketAdapter>();
        }

        private void AddConfigurationAndAuthentication(IServiceCollection services)
        {
            IConfigResolver configResolver = new ConfigResolver(Configuration);
            var urlConfig = configResolver.Resolve<UrlConfig>();

            services.AddSingleton(urlConfig);
            services.AddSingleton(configResolver);
            services.AddSecurity(configResolver);

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(Configuration.GetValue<int>("Session:Idle"));
            });
        }

        private void AddMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup).Assembly);
        }

        private void AddLocalization(IServiceCollection services)
        {
            services.AddJsonLocalization(options =>
            {
                options.ResourcesPath = "Resources";
            });
        }

        private void AddDomainServices(IServiceCollection services)
        {
            var domainServices = typeof(Startup).Assembly.GetTypes().Where(x =>
                typeof(IDomainService).IsAssignableFrom(x) &&
                !x.IsInterface &&
                !x.IsAbstract);

            foreach (var domainService in domainServices)
                services.AddScoped(domainService);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseMiddleware<AuthenticationMiddleware>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
