using System;

namespace I_require_assistance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's try the comment thingy 
            // Success!!
            // Reminder to commit all and push 
            Console.WriteLine("Hello World!");
            Console.WriteLine("Kethup and Mustard");
            Console.WriteLine("Potatoes");
            const int number = 15;
            Console.WriteLine(number);

            string name = "Toaster";
            Console.WriteLine(name);
            Console.WriteLine(number + " " + name);

            string kitchens = "Oven";
            string bestAppliance = (name + " " + kitchens);
            Console.WriteLine(bestAppliance + "   " + bestAppliance);

            long bigNum = 36543535873735L;
            Console.WriteLine(bigNum);
            // long for big numbers, int for small numbers
            Console.WriteLine("Air");

            bool isCSharpFun = true;
            bool isFishTasty = true;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

        }
    }
}
