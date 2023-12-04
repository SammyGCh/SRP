var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SRP_Web>("web");

builder.AddProject<Projects.SRP_Api>("api");

builder.Build().Run();
