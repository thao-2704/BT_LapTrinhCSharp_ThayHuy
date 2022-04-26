using System;

namespace Bai_2_diemdanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Cat: ");
            Cat cat_258 = new Cat();
            cat_258.Eat();
            cat_258.makeSound();
            cat_258.Run();
            Console.WriteLine("\n");

            Console.WriteLine("Class Bird: ");
            Bird bird_258 = new Bird();
            bird_258.Eat();
            bird_258.makeSound();
            bird_258.Fly();

            Console.ReadKey();
        }
    }
}
