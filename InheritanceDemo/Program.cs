using System;

namespace InheritanceDemo
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Inheritance & Method Overriding ---");

            // This creates instances
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // to call MakeSound on each
            Console.Write("Animal says: ");
            genericAnimal.MakeSound();

            Console.Write("Dog says: ");
            dog.MakeSound();

            Console.Write("Cat says: ");
            cat.MakeSound();

            Console.ReadKey(); 
        }
    }h
}