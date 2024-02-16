// Intersect and Except


var numbers1 = new[] { 1, 2, 3, 4, 5, 6 };
var numbers2 = new[] { 4, 5, 6, 7, 8, 9 };

var numbersIntersect = numbers1.Intersect(numbers2);
Console.WriteLine("numbersIntersect " + string.Join(", ", numbersIntersect));

var numbersExcept = numbers1.Except(numbers2);
Console.WriteLine("numbersExcept " + string.Join(", ", numbersExcept));

Console.ReadLine();