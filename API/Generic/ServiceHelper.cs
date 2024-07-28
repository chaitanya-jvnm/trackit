namespace API.Generic;

public static class ServiceHelper
{
    public static IServiceCollection InjectDependencies(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(IRepository<>));
        return services;
    }
}