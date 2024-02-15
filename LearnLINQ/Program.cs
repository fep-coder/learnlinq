var numbers = new[] { 1, 10, 5, 8, 3, 2 };

var smallNumbersMethodSyntax = numbers
                                .Where(number => number < 5)
                                .OrderBy(number => number);

var smallNumbersQuerySyntax = from number in numbers
                              where number < 5
                              orderby number
                              select number;

Console.WriteLine("smallNumbersMethodSyntax " + string.Join(", ", smallNumbersMethodSyntax));
Console.WriteLine("smallNumbersQuerySyntax " + string.Join(", ", smallNumbersQuerySyntax));


Console.ReadLine();