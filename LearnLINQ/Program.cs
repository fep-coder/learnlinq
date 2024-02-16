// Contains

using LearnLINQ;

var isSixPresent = Data.Numbers.Contains(6);
Console.WriteLine("isSixPresent " + isSixPresent);

var isLionPresent = Data.Words.Contains("lion");
Console.WriteLine("isLionPresent " + isLionPresent);

Console.ReadLine();