using Microsoft.Extensions.DependencyInjection;

namespace OrchardCore.Nancy
{
    public static class OrchardCoreBuilderExtensions
    {
        /// <summary>
        /// Adds tenant level Nancy services and configuration.
        /// </summary>
        /// <param name="services"></param>
        public static OrchardCoreBuilder AddNancy(this OrchardCoreBuilder builder)
        {
            return builder.Startup.ConfigureServices(tenant =>
            {
                tenant.Services.AddRouting();
            })
            .Configure((tenant, routes) =>
            {
                tenant.UseNancy();
            })
            .Builder.UseStaticFiles();
        }
    }
}