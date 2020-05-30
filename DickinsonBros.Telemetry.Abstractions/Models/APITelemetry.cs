using System.Diagnostics.CodeAnalysis;

namespace DickinsonBros.Telemetry.Abstractions.Models
{
    [ExcludeFromCodeCoverage]
    public class APITelemetry
    {
        public string CorrelationId { get; set; }
        public string Url { get; set; }
        public string RequestRedacted { get; set; }
        public string ResponseRedacted { get; set; }
        public int ElapsedMilliseconds { get; set; }
        public int StatusCode { get; set; }
        public string Source { get; set; }
    }
}
