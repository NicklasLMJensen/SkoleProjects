using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoxingGame
{
    public class Boxer
    {
        private int _currenthealth;
        private int _maxhealth;
        private Random _random;

        public string Name { get; set; } // Name of the boxer.

        public Boxer(string name)
        {
            Name = name;
            _maxhealth = 100;
            _currenthealth = _maxhealth;
            _random = new Random();
        }

        public int CurrentHealth
        {
            get { return _currenthealth; }
            set { _currenthealth = Math.Max(0, value); } // Ensure health doesn't go below 0.
        }

        public int DoDamage(int chosenNumber)
        {
            int baseDamage = _random.Next(10, 20); // Random base damage between 10 and 20.
            int modifier = _random.Next(1, 10);    // Random "lucky" number.

            if (chosenNumber == modifier)
            {
                Console.WriteLine("🔥🔥 CRITICAL HIT! 🔥🔥");
                return baseDamage + 15; // Extra damage for a critical hit.
            }
            else
            {
                Console.WriteLine("Normal hit.");
                return baseDamage; // Regular damage.
            }
        }

        public void Heal()
        {
            int healAmount = _random.Next(5, 15); // Random healing between 5 and 15.
            _currenthealth = Math.Min(_currenthealth + healAmount, _maxhealth); // Cap health at max.
            Console.WriteLine($"{Name} healed for {healAmount} points! Current health: {_currenthealth}/{_maxhealth}");
        }

        public void DisplayHealth()
        {
            // Visualize health as a bar.
            int healthBars = _currenthealth / 10; // One bar per 10 health points.
            string healthBar = new string('|', healthBars).PadRight(10, '-'); // Remaining bars are dashes.

            Console.WriteLine($"{Name}'s Health: [{healthBar}] {_currenthealth}/{_maxhealth}");
        }
    }
}
