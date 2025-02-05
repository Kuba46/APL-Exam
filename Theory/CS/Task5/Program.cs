using System;
using System.Collections;
using System.Collections.Generic;

//1. List
List<string> names = new List<string> { "Alice", "Charlie", "David" };
names.Add("Bob");
foreach (var name in names)
{
    Console.WriteLine(name);
}

//2. ArrayList
ArrayList list = new ArrayList { 1, "two", 3.14, 4.89, "five", 'a' };
list.Add(5);
foreach (var elem in list)
{
    Console.WriteLine(elem);
}

//3. Dictionary
Dictionary<int, string> dict = new Dictionary<int, string>
{
    { 1, "One" },
    { 2, "Two" }
};
dict.Add(3, "Three");
foreach (var kvp in dict)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

//4. HashSet
HashSet<int> set = new HashSet<int> { 1, 2, 3 };
set.Add(4);
foreach (var item in set)
{
    Console.WriteLine(item);
}

//5. Linked List
var company = new LinkedList<Person>();

company.AddLast(new Person("Tom"));
company.AddLast(new Person("Sam"));
company.AddFirst(new Person("Bill"));

foreach (var person in company)
{ 
    Console.WriteLine(person.Name); 
}

//6. Stack
var employeesList = new List<string> { "Tom", "Sam", "Bob" };
Stack<string> peopleStack = new Stack<string>(employeesList);
foreach (var person in peopleStack) Console.WriteLine(person);

//7. Queue
var employeesListNew = new List<string> { "Tom", "Sam", "Bob" };
Queue<string> peopleQueue = new Queue<string>(employeesListNew);
foreach (var person in peopleQueue) Console.WriteLine(person);

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}