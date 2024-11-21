using System.ComponentModel;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user to tell their name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); // input
            Console.WriteLine($"My name is {name}");

            // string interpolation
            string favoriteColor = ("Blue");
            Console.WriteLine($"My favortite color is {favoriteColor}");

            //Prompt user for their favorite animal
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine(); // input
            Console.WriteLine($"My favorite animal is {animal}");

            //Prompt user for their favorite vacation destination
            Console.WriteLine("Where would you like to vacation?");
            string vacation = Console.ReadLine(); // input
            Console.WriteLine($"My favorite vacation destination is {vacation}");

            //Promt user to explain why they chose that destination
            Console.WriteLine("What do you like about this destination?");
            string destination = Console.ReadLine(); // input
            Console.WriteLine($"What I like about this destination is {destination}");



            // Addition
            Console.WriteLine("What is the sum of two numbers?");
            int add = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose second number");
            int add2 = int.Parse(Console.ReadLine());

            var sum = Add(add, add2);

            Console.WriteLine(sum);

            //Subtraction
            Console.WriteLine("What is the difference of two number?");
            int sub = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose second number");
            int sub2 = int.Parse(Console.ReadLine());

            var diff = Diff(sub, sub2);

            Console.WriteLine(diff);

            //Multiplication
            Console.WriteLine("What is the product of two number?");
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose second number");
            int times2 = int.Parse(Console.ReadLine());

            var result = times * times2;

            Console.WriteLine(result);

            //Division
            Console.WriteLine("What do you get when you divide two numbers?");
            int div = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose second number");
            int div2 = int.Parse(Console.ReadLine());

            var quotient = div / div2;  

            Console.WriteLine(quotient);
        }

        public static int Add(int numOne, int numTwo)
         {
            return numOne + numTwo;

         }

        public static int Diff(int numOne, int numTwo) 
        {
            return numOne - numTwo;
        }

        public static int Times(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Qoutient(int numOne, int numTwo)                   
        { 
            return numOne / numTwo;
        }
    }
}