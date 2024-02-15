//var allPeopleInTheWorldOver18 = people.Where(x => x.age > 18);

//var take100 = allPeopleInTheWorldOver18.Take(100);

var names = new List<string> { "John", "Mary", "Bob", "Jack" };

var namesStartWithJ = names
    .Where(name =>
        {
            Console.WriteLine("Checking name: " + name);
            return name.StartsWith('J');
        });

foreach (var name in namesStartWithJ)
{
    Console.WriteLine(name);
}

Console.ReadLine();