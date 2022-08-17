using Application.Features.WeatherForecasts.Queries.GetWeatherForecast;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IGetWeatherForecastRepository, GetWeatherForecastRepository>();

        return services;
    }
}
