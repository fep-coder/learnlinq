// First and Last

using LearnLINQ;

var firstNumber = Data.Numbers.First();
Console.WriteLine("firstNumber " + firstNumber);

var firstEvenNumber = Data.Numbers.First(x => x % 2 == 0);
Console.WriteLine("firstEvenNumber " + firstEvenNumber);

var lastVegetable = Data.Food.Last(x => x.FoodType == FoodType.Vegetables);
Console.WriteLine("lastVegetable " + lastVegetable);

//var lastFoodOver100 = Data.Food.Last(x => x.Price > 100);
var lastFoodOver100 = Data.Food.LastOrDefault(x => x.Price > 100);
Console.WriteLine("lastFoodOver100 " + lastFoodOver100);

var mostExpensiveFood = Data.Food.OrderBy(x => x.Price).Last();
Console.WriteLine("mostExpensiveFood " + mostExpensiveFood);


Console.ReadLine();