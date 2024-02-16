// Count

using LearnLINQ;

var countMeat = Data.Food.Count(x => x.FoodType == FoodType.Meat);
Console.WriteLine("countMeat " + countMeat);

var countChickenMeat = Data.Food.LongCount(x => x.Name == "Chicken");
Console.WriteLine("countChickenMeat " + countChickenMeat);

var meatCheaperThanSix = 
            Data.Food
            .Count(x => x.FoodType == FoodType.Meat && x.Price < 6);
Console.WriteLine("meatCheaperThanSix " + meatCheaperThanSix);

var foodCount = Data.Food.Count();
Console.WriteLine("foodCount " + foodCount);

Console.ReadLine();