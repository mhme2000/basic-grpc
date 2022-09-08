using Basic_grpc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc(); //Serviço específico para comunicação grpc

var app = builder.Build(); //Subindo servidor

app.MapGrpcService<GreeterService>(); // Mapeando serviços definidos no protocolo grpc
//app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
