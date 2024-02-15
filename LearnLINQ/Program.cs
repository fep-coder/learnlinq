bool isAnyGreaterThan100(int[] numbers)
{
    foreach (var number in numbers)
    {
        if (isGreaterThan100(number))
        {
            return true;
        }
    }

    return false;
}

bool isGreaterThan100(int number)
{
    return number > 100;
}

bool isAnyEven(int[] numbers)
{
    foreach (var number in numbers)
    {
        if (isEven(number))
        {
            return true;
        }
    }

    return false;
}

bool isEven(int number)
{
    return number % 2 == 0;
}

var numbers = new[] { 1, 4, 6, 29, 200, 50 };

Console.WriteLine("isAnyGreaterThan100 " + isAnyGreaterThan100(numbers));
Console.WriteLine("isAnyEven " + isAnyEven(numbers));

Console.ReadLine();