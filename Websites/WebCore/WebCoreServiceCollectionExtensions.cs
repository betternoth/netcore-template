using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebCore
{
    public static class WebCoreServiceCollectionExtensions
    {
        public static void AddWebCore(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(WebCoreConfigureOptions));
        }
    }
}
