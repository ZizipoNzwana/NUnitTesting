// using System;
// using System.Net.NetworkInformation;
// using NUnit.Framework;
namespace TestingWithNUnit.Tests;

public class MyFirstUNitTests 
{
    [Test]
public void IamDoingGreat()
    {
        Console.WriteLine("See you in the test output");
        Assert.That(true);
    }
    [Test]
    public static void ThisIsAStaticTests()
    {
        
    }
}
