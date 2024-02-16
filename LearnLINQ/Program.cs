// OfType 

using LearnLINQ;

var objects = new object[] { 1, "red", 2, "green", new List<int>(), "blue", true };

var strings = objects.OfType<string>();

Console.WriteLine("strings \n" + string.Join("\n", strings));


// Distinct
var distinctNumbers = Data.Numbers.Distinct();
Console.WriteLine("distinctNumbers \n" + string.Join("\n", distinctNumbers));

Console.ReadLine();