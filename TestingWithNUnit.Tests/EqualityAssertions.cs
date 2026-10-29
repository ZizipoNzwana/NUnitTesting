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
}
