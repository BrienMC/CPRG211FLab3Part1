using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_211_F_Lab_3
{
    public abstract class Animal
    {

        public string? Name { get; set; }
        public string? Colour { get; set; }
        public int Age { get; set; }
        
        public abstract void Eat();

    }

    public class Dog : Animal
    {

        public override void Eat()
        {
            Console.WriteLine("Dogs eats meat.");
        }

    }

    public class Cat : Animal
    {

        public override void Eat()
        {
            Console.WriteLine("Cats eats mice.");
        }

    }

}
