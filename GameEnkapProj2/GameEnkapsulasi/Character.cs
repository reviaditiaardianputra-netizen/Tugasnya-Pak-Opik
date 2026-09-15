using System;

namespace GameEncapsulationDemo
{
    public class Character
    {
        public string characterID = "";
        public string characterName = "";
        internal string characterClass = "";
        public float health = 0;
        public int level = 0;


        public Character()
        {
            characterID = "Unknown";
            characterName = "Adit";
            characterClass = "Hero";
            health = 100;
            level = 1;
            Console.WriteLine($"Object Character dibuat dengan konstruktor default.");
        }

        public Character(string id, string name)
        {
            characterID = id;
            characterName = name;
            characterClass = "Adventurer";
            health = 100;
            level = 1;
            Console.WriteLine($"Object Character dibuat dengan konstruktor berparameter (2 parameter).");
        }

        public Character(string id, string name, string classType)
        {
            characterID = id;
            characterName = name;
            characterClass = classType;
            health = 100;
            level = 1;
            Console.WriteLine($"Object Character dibuat dengan konstruktor berparameter (3 parameter).");
        }

        public void Start()
        {
            level = 1;
            health = 100;
            Console.WriteLine($"Karakter {characterName} (Level {level}) memulai petualangan!");
        }

        public void LevelUp()
        {
            level++;
            Console.WriteLine($"{characterName} naik level! Level sekarang: {level}");
        }

        public void TakeDamage(float dmg)
        {
            health -= dmg;
            Console.WriteLine($"{characterName} menerima {dmg} damage. Health tersisa: {health}");

            if (health <= 0)
            {
                Console.WriteLine($"{characterName} telah gugur!");
            }
        }

        public void Heal(float healAmt)
        {
            health += healAmt;
            Console.WriteLine($"{characterName} sembuh sebesar {healAmt}. Health sekarang: {health}");
        }

        public void ShowStats()
        {
            Console.WriteLine("=== STATS KARAKTER ===");
            Console.WriteLine($"ID      : {characterID}");
            Console.WriteLine($"Nama    : {characterName}");
            Console.WriteLine($"Class   : {characterClass}");
            Console.WriteLine($"Level   : {level}");
            Console.WriteLine($"Health  : {health}");
            Console.WriteLine("======================");
        }
    }
}
