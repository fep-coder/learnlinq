// SelectMany

using LearnLINQ;

var peopleFood = Data.People.SelectMany(x => x.Food);
Console.WriteLine("peopleFood \n" + string.Join("\n", peopleFood));

var peopleStartWithJ = Data.People
                            .Where(x => x.Name.StartsWith('J'))
                            .SelectMany(x => x.Food)
                            .Select(x => x.Name);
Console.WriteLine("peopleStartWithJ \n" + string.Join("\n", peopleStartWithJ));

var nestedListOfNumbers = new List<List<int>>
{
    new() { 1, 2, 3 },
    new() { 1, 2, 3 },
    new() { 1, 2, 3 },
};
var sum = nestedListOfNumbers.SelectMany(x => x).Sum();
Console.WriteLine("sum " + sum);

var veryNestedListOfNumbers = new List<List<List<int>>>
{
    new()
    {
        new() { 1, 2, 3 },
        new() { 1, 2, 3 },
        new() { 1, 2, 3 },
    },
    new()
    {
        new() { 1, 2, 3 },
        new() { 1, 2, 3 },
        new() { 1, 2, 3 },
    },

};

var sum2 = veryNestedListOfNumbers.SelectMany(x => x).SelectMany(x => x).Sum();
Console.WriteLine("sum2 " + sum2);

var personFoodInfo =
    Data.People
        .SelectMany(person => person.Food,
        (person, food) => $"{person.Name} likes {food.Name}");
Console.WriteLine("personFoodInfo \n" + string.Join("\n", personFoodInfo));

Console.ReadLine();