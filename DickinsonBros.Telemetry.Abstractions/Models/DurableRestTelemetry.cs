using System.Diagnostics.CodeAnalysis;

namespace DickinsonBros.Telemetry.Abstractions.Models
{
    [ExcludeFromCodeCoverage]
    public class DurableRestTelemetry
    {
        public string Name { get; set; }
        public string CorrelationId { get; set; }
        public int Attempt { get; set; }
        public string BaseUrl { get; set; }
        public string Resource { get; set; }
        public string RequestRedacted { get; set; }
        public string ResponseRedacted { get; set; }
        public int ElapsedMilliseconds { get; set; }
        public int StatusCode { get; set; }
        public string Source { get; set; }
    }
}
