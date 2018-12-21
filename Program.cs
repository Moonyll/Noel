using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Noel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\x02");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, choose your christmas gift !" +"\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. A Snowman..." + "\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("2. An Elf..." + "\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3. Mr. Santa Claus..." + "\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("4. The Reindeer..." + "\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("5. Just A Tree..." + "\n");
            Console.ForegroundColor = ConsoleColor.Gray; string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\x01" + " " + "\x01" + " Merry Christmas from Snowman ! "+"\x01" + " " + "\x01");
                Console.ReadKey();
                
            }
            else if (choice == "2")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\x04" + " " + "\x04" +" Merry Christmas From The Elf ! " +"\x04"+" "+ "\x04");
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\x03" + " " + "\x03" + " Merry Christmas Santa Claus ! "+ "\x03" + " " + "\x03");
                Console.ReadKey();
            }
            else if (choice == "4")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\x05" + " " + "\x05" + " Merry Christmas from Reindeer  ! " + "\x05" + " " + "\x05");
                Console.ReadKey();
            }
            else if (choice == "5")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\x06" + " " + "\x06" + " Merry Christmas from Tree ! "+"\x06" + " " + "\x06");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Oups, wrong choice !");
            }
        }

    }
}
