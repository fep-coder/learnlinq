// Where

using LearnLINQ;

var allEvenNumbers = Data.Numbers.Where(x => x % 2 == 0);
Console.WriteLine("allEvenNumbers \n" + string.Join("\n", allEvenNumbers));

var allEvenNumbersOver300 = Data.Numbers.Where(x => x % 2 == 0 && x > 300);
Console.WriteLine("allEvenNumbersOver300 \n" + string.Join("\n", allEvenNumbersOver300));

var verySpecificFood = Data.Food.Where(x =>
                            (x.FoodType == FoodType.Fruit ||
                            x.FoodType == FoodType.Vegetables) &&
                            x.Price < 2 && x.Id % 2 == 1);

Console.WriteLine("verySpecificFood \n" + string.Join("\n", verySpecificFood));

var selectedIndexes = new[] { 0, 2, 5 };
var foodSelectedIndexes = Data.Food
                            .Where((food, index) =>
                            food.Price < 4 &&
                            selectedIndexes.Contains(index));

Console.WriteLine("foodSelectedIndexes \n" + string.Join("\n", foodSelectedIndexes));

var countOfExpensiveFood = Data.Food.Where(x => x.Price > 4).Count();
var countOfExpensiveFood2 = Data.Food.Count(x => x.Price > 4);
Console.WriteLine("Count " +
                            countOfExpensiveFood + " " +
                            countOfExpensiveFood2);

Console.ReadLine();