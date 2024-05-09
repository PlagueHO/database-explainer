var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DatabaseExplainer>("databaseexplainer");

builder.Build().Run();
