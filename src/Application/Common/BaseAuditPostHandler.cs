namespace Application.Common;

using Domain;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

public abstract class BaseAuditPostHandler<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly ILogger<TRequest> _logger;

    public BaseAuditPostHandler(ILogger<TRequest> logger)
    {
        _logger = logger;
    }

    public abstract Audit GetAudit(TRequest request, TResponse response);

    public async Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
    {
        Audit audit = GetAudit(request, response);
        await SaveToAudit(request, audit, cancellationToken);
    }

    private async Task SaveToAudit(TRequest request, Audit audit, CancellationToken cancellationToken)
    {
        try
        {
            // Logic to save the audit

            await Task.CompletedTask;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled Exception at BaseAuditPostHandler");
        }
    }

    //private static string GetRequestPayload(TRequest request) => System.Text.Json.JsonSerializer.Serialize(request);
}
