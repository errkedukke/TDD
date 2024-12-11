namespace TDD.UnitTests;

public class FizzBuzzTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void WriteNumber_ResultInRangeOfOneToOneHundred()
    {
        // Act
        dynamic result = FizzBuzz.WriteNumber();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<int>());
            Assert.That(result, Is.InRange(1, 100));
        });
    }
}