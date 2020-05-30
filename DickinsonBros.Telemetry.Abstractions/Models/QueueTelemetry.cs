using System.Diagnostics.CodeAnalysis;

namespace DickinsonBros.Telemetry.Abstractions.Models
{
    [ExcludeFromCodeCoverage]
    public class QueueTelemetry
    {
        public string Name { get; set; }
        public string CorrelationId { get; set; }
        public string Source { get; set; }
        public int QueueId { get; set; }
        public int ElapsedMilliseconds { get; set; }
        public QueueState State { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
