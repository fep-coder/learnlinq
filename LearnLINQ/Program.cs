// where query syntax 

using LearnLINQ;

var evenNumbers = from number in Data.Numbers
                  where number % 2 == 0
                  orderby number descending
                  select number;

Console.WriteLine("evenNumbers \n" + string.Join("\n", evenNumbers));

var specificFood = (from food in Data.Food
                    where
                    (food.FoodType == FoodType.Meat ||
                    food.FoodType == FoodType.Fruit) &&
                    food.Price > 1 && food.Name.Length > 4
                    select food).Count();

Console.WriteLine("specificFood \n" + string.Join("\n", specificFood));

Console.ReadLine();