var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApiDocument(options =>
{
	options.DocumentName = "DEMO";
	options.Version = "DEMO";
	options.ApiGroupNames = ["DEMO"];
});

var app = builder.Build();
app.UseHsts();
app.UseOpenApi();
app.UseSwaggerUi();
app.MapControllers();

app.UseReDoc(options =>
{
	options.Path = "/redoc";
});


app.Run();
