// Any 

using LearnLINQ;

var isAnyGreaterThan10 = Data.Numbers.Any(x => x > 10);
Console.WriteLine("isAnyGreaterThan10 " + isAnyGreaterThan10);

var isAnyMeatChicken= Data.Food.Any(food => food.Name == "Chicken");
Console.WriteLine("isAnyMeatChicken " + isAnyMeatChicken);

var isAnyFoodFruit= Data.Food.Any(food => food.FoodType == FoodType.Fruit);
Console.WriteLine("isAnyFoodFruit " + isAnyFoodFruit);

var isNameLengthAndOddId = 
            Data.Food
            .Any(food => food.Name.Length > 8 && food.Id % 2 == 1);
Console.WriteLine("isNameLengthAndOddId " + isNameLengthAndOddId);

var isNotEmpty = Data.Food.Any();
Console.WriteLine("isNotEmpty " + isNotEmpty);

Console.ReadLine();