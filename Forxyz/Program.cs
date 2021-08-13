using System;

namespace Forxyz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Unesite broj: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Unesite broj: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite operaciju: ");
            string operacija = Console.ReadLine();
            //+ - * / 

            switch(operacija)
            {
                case "+":
                    Console.WriteLine($"{x} {operacija} {y} = {x + y}");
                    break;
                case "-":
                    Console.WriteLine($"{x} {operacija} {y} = {x - y}");
                    break;
                case "*":
                    Console.WriteLine($"{x} {operacija} {y} = {x * y}");
                    break;
                case "/":
                    Console.WriteLine($"{x} {operacija} {y} = {x / y}");
                    break;
                default:
                    Console.WriteLine("Ne znam tu operaciju :/");
                    break;
            }

            /*
            if (operacija == "+")
            {
                Console.WriteLine($"{x} {operacija} {y} = {x + y}");
            }
            else if (operacija == "-")
            {
                Console.WriteLine($"{x} {operacija} {y} = {x - y}");
            }
            else if (operacija == "*")
            {
                Console.WriteLine($"{x} {operacija} {y} = {x * y}");
            }
            else if (operacija == "/")
            {
                Console.WriteLine($"{x} {operacija} {y} = {x/y}");
            }
            else
            {
                Console.WriteLine("Ne znam tu operaciju :/");
            }
            */
        }
    }
}
