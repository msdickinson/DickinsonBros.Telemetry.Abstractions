using System;
using System.Diagnostics.CodeAnalysis;

namespace DickinsonBros.Telemetry.Abstractions.Models
{
    [ExcludeFromCodeCoverage]
    public class TelemetryData
    {
        public string Name { get; set; }
        public TelemetryType TelemetryType { get; set; }
        public int ElapsedMilliseconds { get; set; }
        public TelemetryState TelemetryState { get; set; }
        public DateTime DateTime { get; set; }
        public string Source { get; set; }
    }
}
