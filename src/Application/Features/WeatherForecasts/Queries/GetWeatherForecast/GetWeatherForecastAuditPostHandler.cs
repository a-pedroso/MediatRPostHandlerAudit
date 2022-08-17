namespace Application.Features.WeatherForecasts.Queries.GetWeatherForecast;

using Application.Common;
using Domain;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

internal class GetWeatherForecastAuditPostHandler : BaseAuditPostHandler<GetWeatherForecastQuery, IEnumerable<GetWeatherForecastDTO>>
{
    public GetWeatherForecastAuditPostHandler(
        ILogger<GetWeatherForecastQuery> logger)
            : base(logger)
    {
    }

    public override Audit GetAudit(GetWeatherForecastQuery request, IEnumerable<GetWeatherForecastDTO> response)
    {
        return new Audit(
            Audit.AuditAction.GetWeatherForecast,
            "getting weather forecast",
            nameof(WeatherForecast),
            string.Empty);
    }
}