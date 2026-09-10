using System;

namespace GameEncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat object karakter
            Character hero = new Character();

            // Mengakses atribut (perhatikan access modifier)
            hero.characterID = "C-001";
            hero.characterName = "Arthas";      // Apakah ini bisa?
            hero.characterClass = "Warrior";   // Apakah ini bisa?
            hero.health = 100;                 // Apakah ini bisa?
            hero.level = 1;                    // Apakah ini bisa?

            // Memanggil method
            hero.Start();
            hero.TakeDamage(30);
            hero.Heal(10);

            // Mencoba memanggil method private dari luar class
            // hero.LevelUp(); // Apakah ini bisa?

            hero.ShowStats();

            Console.ReadKey();
        }
    }
}