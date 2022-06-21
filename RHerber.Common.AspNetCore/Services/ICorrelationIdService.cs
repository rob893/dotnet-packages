namespace RHerber.Common.AspNetCore.Services
{
    public interface ICorrelationIdService
    {
        string CorrelationId { get; set; }
    }
}