using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Promt the user for their name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); // input

            // string interpolation
            string favoriteColor = ("Blue");
            Console.WriteLine($"My favortite color is {favoriteColor}");

            //Prompt user for their favorite animal
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine(); // input

            //Prompt user for their favorite vacation destination
            Console.WriteLine("Where would you like to vacation?");
            string vacation = Console.ReadLine(); // input

            //Promy user to explain why they chose that destination
            Console.WriteLine("What do you like about this destination?");
            string destination = Console.ReadLine(); // input


        }
    }
}

