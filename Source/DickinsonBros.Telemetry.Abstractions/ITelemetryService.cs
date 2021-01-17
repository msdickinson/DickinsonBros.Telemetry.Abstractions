using DickinsonBros.Telemetry.Abstractions.Models;

namespace DickinsonBros.Telemetry.Abstractions
{
    public interface ITelemetryService
    {
        public delegate void NewTelemetryEventHandler(TelemetryData telemetryData);
        void Insert(TelemetryData telemetryData);
        event NewTelemetryEventHandler NewTelemetryEvent;
    }
}
