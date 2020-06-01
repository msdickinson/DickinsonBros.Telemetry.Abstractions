using System.Diagnostics.CodeAnalysis;

namespace DickinsonBros.Telemetry.Abstractions.Models
{
    [ExcludeFromCodeCoverage]
    public class TelemetryData
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int ElapsedMilliseconds { get; set; }
        public int TelemetryState { get; set; }
    }
}
