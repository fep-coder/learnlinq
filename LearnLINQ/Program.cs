// Sum

using LearnLINQ;

var sumNumbers = Data.Numbers.Sum();
Console.WriteLine("sumNumbers " + sumNumbers);

var sumFoodPrice = Data.Food.Sum(x => x.Price);
Console.WriteLine("sumFoodPrice " + sumFoodPrice);

var emptyNumbers = new int[0];

var sumpEmpty = emptyNumbers.Sum();

Console.WriteLine("sumpEmpty " + sumpEmpty);

Console.ReadLine();