using Application.Features.WeatherForecasts.Queries.GetWeatherForecast;
using MediatR;
using WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.SetupServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.SetupRequestPipeline();

// endpoints
app.MapGet("/weatherforecast", async (IMediator _mediator) =>
{
    return await _mediator.Send(new GetWeatherForecastQuery());
})
.WithName("GetWeatherForecast");

app.Run();