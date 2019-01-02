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
            Console.SetCursorPosition(10, 0); // Décalage du texte de 10 à gauche...
            Console.ForegroundColor = ConsoleColor.Green; // Mise en couleur des textes...
            Console.WriteLine("\x02" + " "+ "Hello ! It's Christmas time ! So pick your christmas gift !" +"\n"); // \x.. + N° pour créer un symbole
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. A Snowman... " + "\x01"+ "\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("2. An Elf... " + "\x04" + "\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3. Mr. Santa Claus... " + "\x03" + "\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("4. The Reindeer... " + "\x05" + "\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("5. Just A Tree... " + "\x06" + "\n");
            Console.ForegroundColor = ConsoleColor.Gray; string choice = Console.ReadLine();
            if (choice == "1") // Création des boucles if
            {
                Console.SetCursorPosition(10, 20); // Décalage du texte de 10 à gauche & 20 du haut...
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\x01" + " " + "\x01" + " Brrrr ! Snowman wish you a Merry Christmas ! " + "\x01" + " " + "\x01");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.SetCursorPosition(10, 20);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\x04" + " " + "\x04" +" Shamrock ! Elf wish you a Merry Christmas ! " +"\x04"+" "+ "\x04");
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                Console.SetCursorPosition(10, 20);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\x03" + " " + "\x03" + " Oh Oh Oh ! Santa Claus wish you a Merry Christmas ! " + "\x03" + " " + "\x03");
                Console.ReadKey();
            }
            else if (choice == "4")
            {
                Console.SetCursorPosition(10, 20);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\x05" + " " + "\x05" + " Hi Ho ! Reindeer wish you a Merry Christmas ! " + "\x05" + " " + "\x05");
                Console.ReadKey();
            }
            else if (choice == "5")
            {
                Console.SetCursorPosition(10, 20);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\x06" + " " + "\x06" + " I'm a Tree, nevertheless i wish you Merry Christmas ! " + "\x06" + " " + "\x06");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue; // Message d'erreur si mauvais choix...
                Console.SetCursorPosition(10, 20);
                Console.WriteLine("\x02" + " " +"Ding Dong ! Oups, you've choose a wrong choice !");
            }
        }

    }
}
