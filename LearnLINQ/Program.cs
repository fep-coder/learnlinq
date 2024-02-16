// OrderBy

using LearnLINQ;

var foodOrderedByName = Data.Food.OrderBy(x => x.Name);
Console.WriteLine("foodOrderedByName \n" + 
                    string.Join("\n", foodOrderedByName));

var foodOrderedByNameDesc = Data.Food.OrderByDescending(x => x.Name);
Console.WriteLine("foodOrderedByNameDesc \n" + 
                    string.Join("\n", foodOrderedByNameDesc));

var orderedNumbers = Data.Numbers.OrderBy(number => number);
Console.WriteLine("orderedNumbers \n" +
                    string.Join("\n", orderedNumbers));

var foodOrderedByTypeThenName = 
                                Data.Food
                                .OrderBy(x => x.FoodType)
                                .ThenBy(x => x.Name);
Console.WriteLine("foodOrderedByTypeThenName \n" +
                    string.Join("\n", foodOrderedByTypeThenName));

Console.ReadLine();