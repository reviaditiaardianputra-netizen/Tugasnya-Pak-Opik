using System;

namespace GameEncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
{
    Console.WriteLine("=== DEMO KONSTRUKTOR ===\n");

    Character hero1 = new Character();
    hero1.ShowStats();

    Character hero2 = new Character("C-002", "Liara");
    hero2.ShowStats();

    Character hero3 = new Character("C-003", "Garrosh", "Orc Warrior");
    hero3.ShowStats();

    Console.ReadKey();
}
    }
}
