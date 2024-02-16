// Aggregate

using LearnLINQ;

var sumOfNumbers = Data.Numbers.Aggregate((sum, nextNumber) => sum + nextNumber);
Console.WriteLine("sumOfNumbers " + string.Join(", ", sumOfNumbers));

var words = "red green blue";

var longestWord = words.Split(" ")
    .Aggregate(
        (longestSoFar, nextWord) =>
            nextWord.Length >
                    longestSoFar.Length ?
                    nextWord : longestSoFar
    );
Console.WriteLine("longestWord " + longestWord);

var jointWords = Data.Words
                    .Aggregate(
                        (resultSoFar, next) => resultSoFar + ", " + next
                    );
Console.WriteLine("jointWords " + string.Join("", jointWords));

var allLengths = words.Split(" ")
    .Aggregate(
        Enumerable.Empty<int>(),
        (lengthsCollection, next) => lengthsCollection.Append(next.Length)
    );
Console.WriteLine("allLengths \n" + string.Join("\n", allLengths));

Console.ReadLine();