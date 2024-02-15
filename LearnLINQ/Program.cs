var words = new List<string> { "a", "bb", "ccc", "dddd" };

var shortWords = words.Where(x => x.Length < 3).ToList();

Console.WriteLine("First iteration:");
foreach (var word in shortWords)
{
    Console.WriteLine(word);
}

words.Add("e");

Console.WriteLine("Second iteration:");
foreach (var word in shortWords)
{
    Console.WriteLine(word);
}

Console.ReadLine();