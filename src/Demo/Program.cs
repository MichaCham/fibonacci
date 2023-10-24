using Leonardo;

using var context = new FibonacciDataContext();
var result = new Fibonacci(context).RunAsync(args);
Console.WriteLine(($"Finished"));
result.Wait();