using Grpc.Core;
using System.Threading.Tasks;
using Morai.Proto;

namespace GrpcServerTest
{
    public class Service : MoraiService.MoraiServiceBase
    {
        public override Task<VehicleInfo> CreateVehicle(CreateVehicleParam request, ServerCallContext context)
        {
            return base.CreateVehicle(request, context);
        }
    }
}
