﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Route256.MerchandiseService.Presentation.Infrastructure.Middleware;

namespace Route256.MerchandiseService.Presentation.Infrastructure.StartupFilters
{
    public class LiveStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return app =>
            {
                app.Map("/live", builder => builder.UseMiddleware<LiveMiddleware>());
                next(app);
            };
        }
    }
}