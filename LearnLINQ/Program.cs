// SelectMany query syntax 

using LearnLINQ;

var nestedListOfNumbers = new List<List<int>>
{
    new() {1, 2, 3 },
    new() {1, 2, 3 },
    new() {1, 2, 3 },
};

var allNumbers = from list in nestedListOfNumbers
                 from number in list
                 select number;

Console.WriteLine("allNumbers \n" + string.Join("\n", allNumbers));

var peopleFood = from person in Data.People
                 where person.Name.StartsWith('J')
                 from food in person.Food
                 select food;

Console.WriteLine("peopleFood \n" + string.Join("\n", peopleFood));

var veryNestedListOfNumbers = new List<List<List<int>>>
{
    new()
    {
        new() {1, 2, 3 },
        new() {1, 2, 3 },
        new() {1, 2, 3 },
    },
    new()
    {
        new() {1, 2, 3 },
        new() {1, 2, 3 },
        new() {1, 2, 3 },
    },
};

var flattenedList = from nestedList in veryNestedListOfNumbers
                    from list in nestedList
                    from number in list
                    select number;

Console.WriteLine("flattenedList \n" + string.Join("\n", flattenedList));

Console.ReadLine();