using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat210 = new Cat();
            cat210.eat();
            cat210.makeSound();
            cat210.run();
            Bird bird210 = new Bird();
            bird210.eat();
            bird210.makeSound();
            bird210.fly();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Thuc an");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("some sound");
        }
    }
    class Cat : Animal
    {
        public void run()
        {
            Console.WriteLine("cat is running");

        }
        public override void eat()
        {
            Console.WriteLine("cat is eating");
        }
        public override void makeSound()
        {
            Console.WriteLine("meow meow");
        }
    }
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("bird is flying");

        }
        public override void eat()
        {
            Console.WriteLine("bird is eating");
        }
        public override void makeSound()
        {
            Console.WriteLine("bird sound");
        }
    }
}