// Single

using LearnLINQ;

var singleGreaterThan100 = Data.Numbers.Single(x => x > 300);
Console.WriteLine("singleGreaterThan100 " + singleGreaterThan100);

Console.ReadLine();