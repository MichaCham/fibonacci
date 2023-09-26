using Leonardo;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Ton père le chauve :)");

app.MapGet("/Fibonacci", async () => await Fibonacci.RunAsync(new[] { "44", "44" }));
app.Run();