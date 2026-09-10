using System;

namespace GameEnkapsulasi1
{
    public class Character
    {
        // Atribut dengan berbagai access modifier
        public string characterID = "";
        public string characterName = "";
        public string characterClass = "";
        public float health = 0;
        public int level = 0;

        private static int characterCount = 0;

        public static int getCharacterCount()
        {
            return characterCount;
        }

        public Character()
        {
            characterCount++;
            Console.WriteLine($"Karakter baru dibuat! Total karakter: {characterCount}");
            characterID = "Unknown";
            characterName = "Adit";
            characterClass = "Hero";
            health = 100;
            level = 1;
        }

        public Character(string id, string name)
        {
            characterCount++;
            Console.WriteLine($"Karakter baru dibuat! Total karakter: {characterCount}");
            characterID = id;
            characterName = name;
            characterClass = "Adventurer";
            health = 100;
            level = 1;
        }

        public Character(string id, string name, string classType)
        {
            characterCount++;
            Console.WriteLine($"Karakter baru dibuat! Total karakter: {characterCount}");
            characterID = id;
            characterName = name;
            characterClass = classType;
            health = 100;
            level = 1;
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
            // Tambah health maksimal, dll.
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