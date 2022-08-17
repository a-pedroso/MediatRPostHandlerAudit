## This solution is based on:
The idea of leverage MediatR IRequestPostProcessor in order to audit every action done applying template method pattern. This way we centralize and standardize how audit is done only by implementing an abstract class per IRequest.
Also, this solution applies clean architecture over the default template WeatherForecast.
## Run Application
From your IDE run the app or at "\src\WebApi" on your shell of your choice type
```text
dotnet run
```
#### CMD Curl
```text 
curl http://localhost:5272/weatherforecast 
```
#### Powershell Curl
```text 
curl http://localhost:5272/weatherforecast -UseBasicParsing
```
## After running app

| WebPage       | Link          | 
| ------------- |---------------|
| API - Swagger | http://localhost:5272/swagger/index.html |
## Technologies
* .NET 6.0
* ASP.NET Core 6.0
* Swagger
* CQRS with MediatR
## License
This project is licensed with the [MIT license](LICENSE).