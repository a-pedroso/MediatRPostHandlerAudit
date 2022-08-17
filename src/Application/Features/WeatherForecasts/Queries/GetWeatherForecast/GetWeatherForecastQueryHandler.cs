namespace Application.Features.WeatherForecasts.Queries.GetWeatherForecast;

using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQuery, IEnumerable<GetWeatherForecastDTO>>
{
    private readonly IGetWeatherForecastRepository _getWeatherForecastRepository;

    public GetWeatherForecastQueryHandler(IGetWeatherForecastRepository getWeatherForecastRepository)
    {
        _getWeatherForecastRepository = getWeatherForecastRepository;
    }

    public Task<IEnumerable<GetWeatherForecastDTO>> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
    {
        var forecast = _getWeatherForecastRepository.GenerateWeatherForecast();

        var dto = forecast
                    .Select(s =>
                        new GetWeatherForecastDTO(
                            s.Date,
                            s.TemperatureC,
                            s.TemperatureF,
                            s.Summary))
                    .ToArray()
                    .AsEnumerable();

        return Task.FromResult(dto);
    }
}
