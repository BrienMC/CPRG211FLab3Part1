using System.Data.Common;

namespace CPRG_211_F_Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal dog = new Dog();
            Animal cat = new Cat();



            //Dog Class
            
            Console.WriteLine("Enter dog name: ");

            dog.Name = Console.ReadLine();

            Console.WriteLine("Enter dog color: ");

            dog.Colour = Console.ReadLine();

            Console.WriteLine("Enter dog age: ");

            dog.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe dog's name is {dog.Name}, its colour is {dog.Colour} and is {dog.Age} years old.");
            dog.Eat();
            Console.WriteLine();



            //Cat Class

            Console.WriteLine("Enter cat name: ");

            cat.Name = Console.ReadLine();

            Console.WriteLine("Enter cat color: ");

            cat.Colour = Console.ReadLine();

            Console.WriteLine("Enter cat age: ");

            cat.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe cat's name is {cat.Name}, its colour is {cat.Colour} and is {cat.Age} years old.");
            cat.Eat();
            Console.WriteLine();

        }
    }
}
