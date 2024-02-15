bool isGreaterThan100(int number)
{
    return number > 100;
}

bool isEven(int number)
{
    return number % 2 == 0;
}

bool isAny(int[] numbers, Func<int, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number))
        {
            return true;
        }
    }

    return false;
}

var numbers = new[] { 1, 4, 6, 29, 200, 50 };

bool isAnyGreaterThan100 = isAny(numbers, isGreaterThan100);
bool isAnyEven = isAny(numbers, isEven);

Console.WriteLine($"Is any > 100? {isAnyGreaterThan100}");
Console.WriteLine($"Is any even? {isAnyEven}");

bool isAnyGeneric<T>(IEnumerable<T> numbers, Func<T, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number))
        {
            return true;
        }
    }

    return false;
}

var words = new[] { "red", "green", "blue" };

bool isAnyLength5 = isAnyGeneric(words, word => word.Length == 5);
Console.WriteLine("isAnyLength5 " + isAnyLength5);

bool isAnyZero = numbers.Any(x => x == 0);

Console.ReadLine();