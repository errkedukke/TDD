namespace TDD;

public class FizzBuzz
{
    public static dynamic WriteNumber()
    {
        var random = new Random();
        dynamic result = random.Next(0, 100);

        return result;
    }
}
