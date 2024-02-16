// Prepend and Append

using LearnLINQ;

var append = Data.Numbers.Append(1000);
var prepend = Data.Numbers.Prepend(0);

Console.WriteLine("append \n" + string.Join("\n", append));
Console.WriteLine("prepend \n" + string.Join("\n", prepend));

Console.ReadLine();