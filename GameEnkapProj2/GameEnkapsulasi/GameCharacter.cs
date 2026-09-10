using System;

namespace GameEncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
{
    Console.WriteLine("=== DEMO KONSTRUKTOR ===\n");

    // 1. Instansiasi menggunakan konstruktor Default
    Character hero1 = new Character();
    hero1.ShowStats();

    // 2. Instansiasi menggunakan konstruktor Berparameter (2 parameter)
    Character hero2 = new Character("C-002", "Liara");
    hero2.ShowStats();

    // 3. Instansiasi menggunakan konstruktor Berparameter (3 parameter)
    Character hero3 = new Character("C-003", "Garrosh", "Orc Warrior");
    hero3.ShowStats();

    Console.ReadKey();
}
    }
}