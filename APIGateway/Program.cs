using Ocelot.DependencyInjection;
using Ocelot.Middleware;

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("ocelot.json").Build();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOcelot(configuration);
var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
}
app.UseRouting();
app.MapControllers();

app.UseOcelot();
//app.MapGet("/", () => "Hello World!");

app.Run();
