using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_2_diemdanh
{
    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void makeSound();
    }

    public class Cat : Animal
    {
        public Cat()
        {

        }
        public override void Eat()
        {
            Console.WriteLine("Meo meo meo meo meo");
        }
        public override void makeSound()
        {
            Console.WriteLine("Meo dang tam, dung lam phien!!!");
        }

        public void Run()
        {
            Console.WriteLine("Meo co bon chan");
        }

    }

    public class Bird : Animal
    {
        public Bird()
        {

        }
        public override void Eat()
        {
            Console.WriteLine("Meo meo meo meo meo");
        }
        public override void makeSound()
        {
            Console.WriteLine("Meo dang tam, dung lam phien!!!");
        }

        public void Fly()
        {
            Console.WriteLine("Chim co hai canh de bay !!!");
        }

    }
}
