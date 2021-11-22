using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaWorkshop.WebUI
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddWebUIServices(this IServiceCollection services)
        {
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddOpenApiDocument(configure =>
            {
                configure.Title = "CaWorkshop API";
            });

            return services;
        }
    }
}
