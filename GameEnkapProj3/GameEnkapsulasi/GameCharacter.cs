using System;

namespace GameEnkapsulasi1
{
    public class GameCharacter
    {
        static void Main(string[] args)
{
    Console.WriteLine("=== DEMO KONSTRUKTOR ===\n");

    Console.WriteLine("total karakter saat ini: " + Character.getCharacterCount());

    Character hero1 = new Character();
    Character hero2 = new Character("C-002", "Luna");
    Character hero3 = new Character("C-003", "Ragnar", "Warrior");

    hero1.ShowStats();
    hero2.ShowStats();
    hero3.ShowStats();

    Console.WriteLine("total karakter yang telah dibuat: " + Character.getCharacterCount());

    Console.ReadKey();
}
     }
 }
