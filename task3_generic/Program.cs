using System;
using task3_generic;

var repository = new Repository<Person>();
repository.Add(new Person { Name = "Ali", Age = 20 });
repository.Add(new Person { Name = "Anton", Age = 21 });
repository.Add(new Person { Name = "Dima", Age = 20 });
var person = repository.Get(2);
if (person != null)
    Console.WriteLine($"Name: {person.Name}\nAge: {person.Age}");
else
    Console.WriteLine("Person not found.");

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}