using Leonardo;

var result = Fibonacci.RunAsync(args);
Console.WriteLine(($"Finished"));
result.Wait();