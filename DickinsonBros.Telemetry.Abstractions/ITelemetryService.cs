using DickinsonBros.Telemetry.Abstractions.Models;
using System.Threading.Tasks;

namespace DickinsonBros.Telemetry.Abstractions
{
    public interface ITelemetryService
    {
        void InsertAPI(APITelemetry apiTelemetry);
        void InsertDurableRest(DurableRestTelemetry durableRestTelemetry);
        void InsertEmail(EmailTelemetry emailTelemetry);
        void InsertQueue(QueueTelemetry queueTelemetry);
        void InsertSQL(SQLTelemetry sqlTelemetry);
        Task Flush();

    }
}
