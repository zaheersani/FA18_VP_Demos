using System;

namespace BCS6AVisualProgrammingDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My First C# Program!");
            Console.WriteLine("No. of Arguments: " + args.Length);

            if (args.Length > 0)
            {
                if (args[0] == "BCS6A" && args[1] == "SP15")
                    Console.WriteLine("You have unlocked this class!");
            }
            Console.ReadKey();
        }
    }
}
