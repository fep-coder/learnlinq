// select query syntax 

using LearnLINQ;

var doubled = from number in Data.Numbers
              select number * 2;
Console.WriteLine("doubled \n" + string.Join("\n", doubled));

var wordsUppercase = from word in Data.Words
                     select word.ToUpper();
Console.WriteLine("wordsUppercase \n" + string.Join("\n", wordsUppercase));

var foodNames = from food in Data.Food
                select food.Name;
Console.WriteLine("foodNames \n" + string.Join("\n", foodNames));

var pricesOverOne = (from food in Data.Food
                     where food.Price > 1
                     select food.FoodType).Distinct();
Console.WriteLine("pricesOverOne \n" + string.Join("\n", pricesOverOne));

var foodInfo = from food in Data.Food
               orderby food.Name
               select $"{food.Name.First()}. " +
                       $"{food.FoodType} " +
                       $"${food.Price}";

Console.WriteLine("foodInfo \n" + string.Join("\n", foodInfo));

Console.ReadLine();