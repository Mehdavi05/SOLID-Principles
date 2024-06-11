using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3. Liskov Substitution Principle (LSP)
//Principle: Objects of a superclass should be replaceable with objects of a subclass without affecting
//the correctness of the program.

namespace Solid
{
    // Base class
    public abstract class Bird
    {
        public abstract void MakeSound();
    }

    // Derived class that can fly
    public class Sparrow : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("Sparrow chirps!");
        }

        public void Fly()
        {
            Console.WriteLine("Sparrow is flying!");
        }
    }

    // Derived class that cannot fly
    public class Penguin : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("Penguin squawks!");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming!");
        }
    }
}
