bool IsAnyWordUppercase(IEnumerable<string> words)
{
    foreach (var word in words)
    {
        bool allAreUppercase = true;

        foreach (var letter in word)
        {
            if (char.IsLower(letter))
            {
                allAreUppercase = false;
            }
        }

        if (allAreUppercase)
        {
            return true;
        }
    }

    return false;
}

var wordsNoUppercase = new[] { "red", "green", "blue" };
var wordsWithUppercase = new[] { "red", "GREEN", "blue" };

Console.WriteLine(IsAnyWordUppercase(wordsNoUppercase));
Console.WriteLine(IsAnyWordUppercase(wordsWithUppercase));

bool IsAnyWordUppercaseLinq(IEnumerable<string> words)
{
    return words.Any(word => word.All(letter => char.IsUpper(letter)));
}

Console.WriteLine(IsAnyWordUppercaseLinq(wordsNoUppercase));
Console.WriteLine(IsAnyWordUppercaseLinq(wordsWithUppercase));

Console.ReadLine();