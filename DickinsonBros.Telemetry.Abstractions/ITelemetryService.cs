using DickinsonBros.Telemetry.Abstractions.Models;
using System.Threading.Tasks;

namespace DickinsonBros.Telemetry.Abstractions
{
    public interface ITelemetryService
    {
        void Insert(TelemetryData telemetryData);
        Task FlushAsync();

    }
}
