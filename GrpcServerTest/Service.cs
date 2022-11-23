using Grpc.Core;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.IO;
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
