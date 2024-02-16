// ToLookup and GroupBy

using LearnLINQ;

var foodPriceByTypeLookup =
    Data.Food
        .ToLookup(
            food => food.FoodType, // key
            food => food.Price // value
        );

var sumOfPricesByType =
                    foodPriceByTypeLookup
                        .ToDictionary(
                            lookup => lookup.Key,
                            lookup => lookup.Sum()
                        );

Console.WriteLine("sumOfPricesByType " + string.Join(", ", sumOfPricesByType));

var groupings =
    Data.Food
        .GroupBy(
            food => food.FoodType, // key
            food => food.Price // value
        );

var sumOfPricesByType2 =
                    foodPriceByTypeLookup
                        .ToDictionary(
                            x => x.Key,
                            x => x.Sum()
                        );

Console.WriteLine("sumOfPricesByType2 " + string.Join(", ", sumOfPricesByType2));

Console.ReadLine();