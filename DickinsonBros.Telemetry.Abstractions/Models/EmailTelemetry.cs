using System.Diagnostics.CodeAnalysis;

namespace DickinsonBros.Telemetry.Abstractions.Models
{
    [ExcludeFromCodeCoverage]
    public class EmailTelemetry
    {
        public string CorrelationId { get; set; }
        public string To { get; set; }
        public bool IsSuccessful { get; set; }
        public string Subject { get; set; }
        public int ElapsedMilliseconds { get; set; }
        public string Source { get; set; }
    }
}
