namespace TestingWithNUnit.Tests;

public class MyNewTestFixtures
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
