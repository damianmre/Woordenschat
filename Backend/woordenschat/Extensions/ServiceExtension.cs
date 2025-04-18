using woordenschat.Services;
using woordenschat.Services.IServices;

namespace woordenschat.Extensions;

public static class ServiceExtension
{
    public static void AddServices(this IServiceCollection services) 
    {
        services.AddScoped<IWoordenService, WoordenService>();
    }
}
