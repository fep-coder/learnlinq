// Concat and Union

var numbers1 = new[] { 1, 2, 3 };
var numbers2 = new[] { 3, 4, 5, 6 };

var allNumbers = numbers1.Concat(numbers2);
Console.WriteLine("allNumbers \n" + string.Join("\n", allNumbers));

var allNumbersUnion = numbers1.Union(numbers2);
Console.WriteLine("allNumbersUnion \n" + string.Join("\n", allNumbersUnion));

Console.ReadLine();