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
        // Arrange
        var number = 10;

        // Act
        dynamic result = FizzBuzz.WriteNumber(number);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<int>());
            Assert.That(result, Is.InRange(1, 100));
        });
    }

    [Test]
    public void WriteNumber_ResultIsFizzWhenDevisibleByThree()
    {
        // Arrange
        var number = 30;

        // Act
        dynamic result = FizzBuzz.WriteNumber(number);

        // Assert
        Assert.Multiple(() => 
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<string>());
            Assert.That(result, Is.EqualTo("Fizz"));
        });
    }
}