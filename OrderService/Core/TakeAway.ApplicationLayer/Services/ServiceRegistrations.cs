using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAway.ApplicationLayer.Services;

public static class ServiceRegistrations
{
    public static void AddApplicationService(this IServiceCollection services)
    {
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(typeof(ServiceRegistrations).Assembly));
    }
}
