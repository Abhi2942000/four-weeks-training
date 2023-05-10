// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void MakeSound();
}
class Dog : Animal, IMovable
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
    public void Move()
    {
        Console.WriteLine("Running on four legs");
    }
}
class Cat : Animal, IMovable
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
    public void Move()
    {
        Console.WriteLine("Jumping and climbing");
    }
}
interface IMovable
{
    void Move();
}
class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        animals.Add(new Dog() { Name = "Buddy", Age = 2 });
        animals.Add(new Cat() { Name = "Whiskers", Age = 1 });
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
            animal.MakeSound();
            if (animal is IMovable movable)
            {
                movable.Move();
            }
        }
    }
}