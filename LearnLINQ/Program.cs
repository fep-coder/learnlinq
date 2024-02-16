// Generating new collections

using LearnLINQ;

var emptyInts = Enumerable.Empty<int>();
if (!emptyInts.Any()) Console.WriteLine("Empty");

var tenCopies = Enumerable.Repeat(1, 10);
Console.WriteLine("tenCopies " + string.Join(", ", tenCopies));

var copiesWithIndex = Enumerable
                        .Repeat("banana", 3)
                        .Select((x, i) => $"{i + 1}. {x}");
Console.WriteLine("copiesWithIndex " + string.Join(", ", copiesWithIndex));

var oneToTen = Enumerable.Range(1, 10);
Console.WriteLine("oneToTen " + string.Join(", ", oneToTen));

var defaultIfEmpty = Data.Numbers.DefaultIfEmpty();
Console.WriteLine("defaultIfEmpty " + string.Join(", ", defaultIfEmpty));

Console.ReadLine();