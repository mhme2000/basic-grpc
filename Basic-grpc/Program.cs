using Basic_grpc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc(); //Servi�o espec�fico para comunica��o grpc

var app = builder.Build(); //Subindo servidor

app.MapGrpcService<GreeterService>(); // Mapeando servi�os definidos no protocolo grpc
//app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
