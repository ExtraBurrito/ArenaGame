using ArenaGame;
using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Hero two = null;
            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            Console.WriteLine("Choose your weapon: 1) Sword, 2) Bow, 3) Axe");
            int weaponChoice = int.Parse(Console.ReadLine());

            Weapon weapon = null;

            switch (weaponChoice)
            {
                case 1:
                    weapon = new Sword();
                    break;
                case 2:
                    weapon = new Bow();
                    break;
                case 3:
                    weapon = new Axe();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Default weapon (Sword) will be used.");
                    weapon = new Sword(); 
                    break;
            }

            for (int i = 0; i < rounds; i++)
            {
                Hero one = new Knight("Sir Lancelot", weapon);
                two = ChooseOpponent(); 
                Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) oneWins++; else twoWins++;
                Console.WriteLine();
                Console.WriteLine($"One has {oneWins} wins.");
                Console.WriteLine($"Two has {twoWins} wins.");
                Console.ReadLine();
            }
        }

        public static Hero ChooseOpponent() 
        {
            Console.Clear();
            Console.Write("choose your opponent:");
            int enemy = Int32.Parse(Console.ReadLine());
            switch (enemy)
            {
                case 1:
                    return new Rogue("Robih Hood");
                case 2:
                    return new Mage("Sagami");
                case 3:
                    return new Bandit("Zargo");
                default:
                    Console.WriteLine("Incorrect value, try again.");
                    return ChooseOpponent(); 
            }
        }
        
    }
}