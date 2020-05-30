using System.Diagnostics.CodeAnalysis;

namespace DickinsonBros.Telemetry.Abstractions.Models
{
    [ExcludeFromCodeCoverage]
    public class SQLTelemetry
    {
        public string Database { get; set; }
        public int ElapsedMilliseconds { get; set; }
        public string CorrelationId { get; set; }
        public string Query { get; set; }
        public string ResponseRedacted { get; set; }
        public bool IsSuccessful { get; set; }
        public string RequestRedacted { get; set; }
        public string Source { get; set; }
    }
}
