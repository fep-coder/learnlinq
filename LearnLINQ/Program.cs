// Take, TakeLast and TakeWhile

using LearnLINQ;

var firstThreeNumbers = Data.Numbers.Take(3);
Console.WriteLine("firstThreeNumbers \n" + string.Join("\n", firstThreeNumbers));

var moreNumbers = Data.Numbers.Take(300);
Console.WriteLine("moreNumbers \n" + string.Join("\n", moreNumbers));

var lastThreeNumbers = Data.Numbers.TakeLast(3);
Console.WriteLine("lastThreeNumbers \n" + string.Join("\n", lastThreeNumbers));

var secondLargestNumber = Data.Numbers.OrderBy(x => x).TakeLast(2).First();
Console.WriteLine("secondLargestNumber " + secondLargestNumber);

var takeUntil12 = Data.Numbers.TakeWhile(x => x <= 12);
Console.WriteLine("takeUntil12 \n" + string.Join("\n", takeUntil12));

Console.ReadLine();