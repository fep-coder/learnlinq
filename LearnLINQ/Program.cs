// Query syntax and orderby

using LearnLINQ;

var orderedNumbers = from number in Data.Numbers
                     let timesTwo = number * 2
                     orderby timesTwo
                     select timesTwo;

Console.WriteLine("orderedNumbers \n" + string.Join("\n", orderedNumbers));

var foodDescending = from food in Data.Food
                     orderby food.Name descending
                     select food;

Console.WriteLine("foodDescending \n" + string.Join("\n", foodDescending));

var foodByTypeAndId = (from food in Data.Food
                       orderby food.FoodType, food.Id
                       select food).Reverse();

Console.WriteLine("foodByTypeAndId \n" + string.Join("\n", foodByTypeAndId));

Console.ReadLine();