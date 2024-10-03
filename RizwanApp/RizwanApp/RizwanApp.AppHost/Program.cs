var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.RizwanApp_ApiService>("apiservice");

builder.AddProject<Projects.RizwanApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
