// Select

using LearnLINQ;

var doubledNumbers = Data.Numbers.Select(x => x * 2);
Console.WriteLine("doubledNumbers \n" + string.Join("\n", doubledNumbers));

var uppercaseWords = Data.Words.Select(x => x.ToUpper());
Console.WriteLine("uppercaseWords \n" + string.Join("\n", uppercaseWords));

var numberToString = Data.Numbers
                        .Select(number => number.ToString()); // works

var numberedWords = Data.Words.Select((word, index) => $"{index}. {word}");
Console.WriteLine("numberedWords \n" + string.Join("\n", numberedWords));

var prices = Data.Food.Select(x => x.Price);
Console.WriteLine("prices \n" + string.Join("\n", prices));

var foodOverOne = Data.Food
    .Where(food => food.Price > 1)
    .Select(food => food.FoodType)
    .Distinct();
Console.WriteLine("foodOverOne \n" + string.Join("\n", foodOverOne));

var foodFirstLetter = Data.Food
                        .OrderBy(x => x.Name)
                        .Select(x => x.Name.First());
Console.WriteLine("foodFirstLetter \n" + string.Join("\n", foodFirstLetter));

var foodData = Data.Food
                    .Select(x => $"Food name: {x.Name} " +
                    $"of type {x.FoodType} " +
                    $"and price ${x.Price} ");
Console.WriteLine("foodData \n" + string.Join("\n", foodData));

Console.ReadLine();