var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApiDocument();
//builder.Services.AddSwaggerDocument();

var app = builder.Build();

//app.UseRouting().UseEndpoints( conf =>
//{
//	conf.MapControllers();
//});
app.UseOpenApi();
app.UseSwaggerUi();

app.UseReDoc(options =>
{
	options.Path = "/redoc";
});

app.UseHsts();

app.Run();
