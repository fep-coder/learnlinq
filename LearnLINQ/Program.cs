bool isAnyGreaterThan100(int[] numbers)
{
    foreach (var number in numbers)
    {
        if (number > 100)
        {
            return true;
        }
    }

    return false;
}

bool isAnyEven(int[] numbers)
{
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            return true;
        }
    }

    return false;
}

var numbers = new[] { 1, 4, 6, 29, 200, 50 };

Console.WriteLine("isAnyGreaterThan100 " + isAnyGreaterThan100(numbers));
Console.WriteLine("isAnyEven " + isAnyEven(numbers));

Console.ReadLine();