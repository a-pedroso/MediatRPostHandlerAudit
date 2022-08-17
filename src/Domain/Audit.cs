namespace Domain;

using static Domain.Audit;

public record Audit(
    AuditAction Action,
    string Description,
    string EntityName,
    string EntityId)
{
    public enum AuditAction
    {
        GetWeatherForecast
    }
}
