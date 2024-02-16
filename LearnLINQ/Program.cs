// Average

using LearnLINQ;

var average = Data.Numbers.Average();
Console.WriteLine("average " + average);

var averageFoodPrice = Data.Food.Average(x => x.Price);
Console.WriteLine("averageFoodPrice " + averageFoodPrice);

Console.ReadLine();