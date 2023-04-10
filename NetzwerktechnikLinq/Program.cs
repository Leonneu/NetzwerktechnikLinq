
// Create a list of Person objects
List<Person> people = new List<Person> {
    new Person { Name = "Alice", Age = 25 },
    new Person { Name = "Dave", Age = 35 },
    new Person { Name = "Charlie", Age = 20 },
    new Person { Name = "Bob", Age = 30 },
};

// Use LINQ with lambda expressions to filter and project data from the list
var result = people
    .Where(person => person.Age > 25)
    .OrderBy(person => person.Name)
    .Select(person => person.Name);

// Use LINQ to filter and project data from the list
// var result = from person in people
//     where person.Age > 25
//     orderby person.Name
//     select person.Name;

//Do not use Linq
// var result = new List<Person>();
// foreach (Person person in people)
// {
//     if (person.Age > 25)
//     {
//         result.Add(person);
//     }
// }
// result.Sort((person1, person2) =>
//     String.Compare(person1.Name, person2.Name, StringComparison.Ordinal));

// Iterate over the result and print the names
foreach (string name in result) {
    Console.WriteLine(name);
}


class Person {
    public string Name { get; set; }
    public int Age { get; set; }
}
