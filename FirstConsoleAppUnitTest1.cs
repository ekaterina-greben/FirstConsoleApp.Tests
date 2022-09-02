namespace FirstConsoleApp.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        System.Console.WriteLine("==== Tests started =====");
    }

    [Test]
    public void Test1()
    {
        Assert.That(10+10, Is.EqualTo(20));
    }

    [Test]
    public void Test2()
    {
        Assert.Zero(5); 
    }   
}

