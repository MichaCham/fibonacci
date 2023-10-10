using Leonardo;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Sa marche. Essaye la route /Fibonacci !");

app.MapGet("/Fibonacci", async () => await Fibonacci.RunAsync(new[] { "44", "44" }));
app.Run();