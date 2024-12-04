using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoxingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player setup
            Console.Write("Enter Player 1's name: ");
            string player1Name = Console.ReadLine();
            Boxer b1 = new Boxer(player1Name);

            Console.Write("Enter Player 2's name: ");
            string player2Name = Console.ReadLine();
            Boxer b2 = new Boxer(player2Name);

            int round = 1; // Tracks the current round.

            Console.WriteLine($"\n{b1.Name} vs {b2.Name}! Let the fight begin!\n");

            // Game loop
            while (b1.CurrentHealth > 0 && b2.CurrentHealth > 0)
            {
                Console.WriteLine($"\n======== ROUND {round} ========");

                // Player 1's turn
                Console.Write($"{b1.Name}, choose a number between 1 and 10: ");
                int playerChoice = int.Parse(Console.ReadLine());
                Console.WriteLine($"{b1.Name} attacks!");
                b2.CurrentHealth -= b1.DoDamage(playerChoice);
                b2.DisplayHealth();

                if (b2.CurrentHealth <= 0)
                {
                    Console.WriteLine($"\n{b1.Name} wins the fight! 🏆");
                    break;
                }

                // Player 2's turn (computer-controlled opponent)
                Console.WriteLine($"{b2.Name} is attacking!");
                int enemyChoice = new Random().Next(1, 10); // Random number chosen by Player 2.
                b1.CurrentHealth -= b2.DoDamage(enemyChoice);
                b1.DisplayHealth();

                if (b1.CurrentHealth <= 0)
                {
                    Console.WriteLine($"\n{b2.Name} wins the fight! 🏆");
                    break;
                }

                // End of round healing
                Console.WriteLine("\n--- End of Round Healing ---");
                b1.Heal();
                b2.Heal();

                // End of round summary
                Console.WriteLine($"\n======== END OF ROUND {round} ========");
                b1.DisplayHealth();
                b2.DisplayHealth();
                Console.WriteLine("---------------------------------------");

                round++; // Move to the next round.
            }
        }
    }
}
