var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PA_FolioOne>("pa-folioone");

builder.Build().Run();
