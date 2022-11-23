using System;
using Grpc.Core;
using Morai.Proto;

namespace GrpcServerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region gRPC server Test example            
            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Services = { MoraiService.BindService(new Service()) },
                Ports = { new ServerPort("localhost", 7789, ServerCredentials.Insecure) }
            };
            server.Start();            

            Console.WriteLine("Morai gRPC chat server listening on port " + 7788);
            Console.WriteLine("Press esc key to stop the server...");

            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.S)
                {
                    // something code
                }
            } while (cki.Key != ConsoleKey.Escape);

            server.ShutdownAsync().Wait();
            #endregion            
        }
    }
}
