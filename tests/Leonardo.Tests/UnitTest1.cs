namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {  
        var result = await Leonardo.Fibonacci.RunAsync(new[] {"6"});  
        Assert.Equal(8, result[0]);  
    }
}