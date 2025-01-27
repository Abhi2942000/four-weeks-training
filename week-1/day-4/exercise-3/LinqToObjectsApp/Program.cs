﻿namespace LinqToObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 25, Country = "USA" },
                new Person { Name = "Jane", Age = 30, Country = "Canada" },
                new Person { Name = "Mark", Age = 28, Country = "USA" },
                new Person { Name = "Emily", Age = 22, Country = "Australia" }
            };
            int filterAge = 20;
            var filteredPeople = people.Where(p => p.Age > filterAge);
            var sortedPeople = filteredPeople.OrderBy(p => p.Name);
            var projectedPeople = sortedPeople.Select(p => new { p.Name, p.Country });
            foreach (var person in projectedPeople)
            {
                Console.WriteLine($"Name: {person.Name}, Country: {person.Country}");
            }
            //Write queries using LINQ for following operations
            //1. Get all people from USA
            //2. Get all people above 30
            //3. Sort people by name
            //4. Project/Select only Name and Country of all people
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}







