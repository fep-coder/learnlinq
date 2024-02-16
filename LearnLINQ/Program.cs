// ElementAt

using LearnLINQ;

var firstNumber = Data.Numbers[0];
Console.WriteLine("firstNumber " + firstNumber);

var firstFoodList = Data.Food.ToList();
Console.WriteLine("firstFoodList " + firstFoodList[0]);

var firstFoodLinq = Data.Food.ElementAt(0);
Console.WriteLine("firstFoodLinq " + firstFoodLinq);

//var noIndex = Data.Food.ElementAt(100);
var noIndex = Data.Food.ElementAtOrDefault(100);
Console.WriteLine("noIndex " + noIndex);

Console.ReadLine();