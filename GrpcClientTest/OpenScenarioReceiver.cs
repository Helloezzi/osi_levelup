using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib.Grpc.Protobuf.MoraiOpenScenarioBase;
using Grpc.Core;

namespace ClientTest
{
    class OpenScenarioReceiver : MoraiOpenScenarioBaseService.MoraiOpenScenarioBaseServiceClient
    {
        public override AsyncDuplexStreamingCall<ServiceRequest, ServiceResponse> Connect(CallOptions options)
        {
            Console.WriteLine("aaa");

            return base.Connect(options);
        }
    }
}
