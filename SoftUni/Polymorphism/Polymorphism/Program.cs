﻿
using Animals;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MathOperations mo = new MathOperations();
            //Console.WriteLine(mo.Add(2, 3));
            //Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            //Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));


            Animal cat = new Cat("Peter", "Whiskas");
            //Animal dog = new Dog("George", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            //Console.WriteLine(dog.ExplainSelf());

        }
    }
}
