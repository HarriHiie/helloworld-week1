using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Is Youre Name?");
            //Readline() to read the user input from the console
            string UserName = Console.ReadLine();
            Console.WriteLine("Hello," + UserName);

            Console.Read();
        }



    }
}
