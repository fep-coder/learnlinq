// Skip, SkipLast and SkipWhile

using LearnLINQ;

var skipThreeNumbers = Data.Numbers.Skip(3);
Console.WriteLine("skipThreeNumbers \n" + string.Join("\n", skipThreeNumbers));

var skipLastThreeNumbers = Data.Numbers.SkipLast(3);
Console.WriteLine("skipLastThreeNumbers \n" + string.Join("\n", skipLastThreeNumbers));

var getThirdAndFourthFood = Data.Food.Skip(2).Take(2);
Console.WriteLine("getThirdAndFourthFood \n" + string.Join("\n", getThirdAndFourthFood));

var skipUntil100 = Data.Numbers.SkipWhile(x => x <= 100);
Console.WriteLine("skipUntil100 \n" + string.Join("\n", skipUntil100));

Console.ReadLine();