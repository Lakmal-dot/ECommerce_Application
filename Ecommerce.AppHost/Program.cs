using Google.Protobuf.WellKnownTypes;

var builder = DistributedApplication.CreateBuilder(args);

var productApi = builder.AddProject<Projects.Ecommerce_ProductService>("apiservice-product");
var orderApi = builder.AddProject<Projects.Ecommerce_OrderService>("apiorder-service");

builder.AddProject<Projects.Ecommerce_Web>("webfrontend")
    .WithReference(productApi)
    .WithReference(orderApi);

builder.Build().Run();
