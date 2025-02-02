var builder = DistributedApplication.CreateBuilder(args);

var app1 = builder.AddProject<Projects.ConsoleApp1>("app1");

builder.AddProject<Projects.ConsoleApp2>("app2")
    .WithExternalHttpEndpoints()
    .WaitForCompletion(app1);

builder.Build().Run();
