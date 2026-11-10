var builder = DistributedApplication.CreateBuilder(args);

// Connection String DI
//var db = builder.AddConnectionString(name: "FolioOne2", "connstr");
//builder.AddProject<Projects.PA_FolioOne>("pa-folioone")
//    .WithReference(db);

// Ortam Değişkeni olarak connection string
//builder.AddProject<Projects.PA_FolioOne>("pa-folioone")
//    .WithEnvironment(name: "ConnectionStings__FolioOne3", "connstre");

builder.AddProject<Projects.PA_FolioOne>("pa-folioone");

builder.Build().Run();
