// All

using LearnLINQ;

var allGreaterThanZero = Data.Numbers.All(x => x > 0);
Console.WriteLine("allGreaterThanZero " + allGreaterThanZero);

var isAllFoodPriced = Data.Food.All(x => x.Price > 0);
Console.WriteLine("isAllFoodPriced " + isAllFoodPriced);

var isThereOnlyMeat = Data.Food.All(x => x.FoodType == FoodType.Meat);
Console.WriteLine("isThereOnlyMeat " + isThereOnlyMeat);

Console.ReadLine();