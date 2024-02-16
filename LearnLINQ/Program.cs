// Min and Max

using LearnLINQ;

var smallest = Data.Numbers.Min();
var largest = Data.Numbers.Max();

Console.WriteLine("smallest " + smallest);
Console.WriteLine("largest " + largest);

var minPrice = Data.Food.Min(x => x.Price);
var maxPrice = Data.Food.Max(x => x.Price);

Console.WriteLine("minPrice " + minPrice);
Console.WriteLine("maxPrice " + maxPrice);

var minFood = Data.Food.Min();
Console.WriteLine("minFood " + minFood);

var emptyNumbers = new int[0];
var minEmptyNumbers = emptyNumbers.Min();

Console.ReadLine();