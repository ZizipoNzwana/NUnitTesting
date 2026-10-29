using NUnit.Framework;
using System;

namespace TestingWithNUnit.Tests;

[TestFixture]
public class EqualityAssertions
{
    [Test]
    public void AreEqual()
    {
        string expected = "Hello";
        string actual = "Hello";
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AreEqualWithDescription()
    {
        string expected = "Hello";
        string actual = "Hello";
        Assert.That(actual, Is.EqualTo(expected),"What does this mean");
    }

    [Test]
    public void AreEqualNumbers()
    {
        int expected = 1 + 2;
        int actual = 3;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void AreEqualArrays()
    {
        var expected = new int[]{1, 2, 3};
        var actual = new int[]{1, 3, 2};
        Array.Sort(actual);
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void AreObjectsEqual()
    {
        var obj1 = new object();
        var obj2 = new object();
 
        Assert.That(obj1, Is.Not.EqualTo(obj2));
    }
}
