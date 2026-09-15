using System;

namespace CharacterTugas
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("=== DEMO KONSTRUKTOR ===\n");

        //1. Instansiasi menggunakan Konstruktor Default
        Character hero1 = new Character();   
        hero1.Showstats();  

        //2. Instansiasi menggunakan Konstruktor Berparameter (2 parameter)
        Character hero2 = new Character("C-002", "Liara");   
        hero2.Showstats();

        //3. Intansiasi menggunakan Konstruktor Berparameter (3 parameter)
        Character hero3 = new Character("C-003", "Garrosh", "Orc Warrior");   
        hero3.Showstats();

        Character hero4 = new Character("C-004", "Arthas", "Paladin", 10);
        hero4.Showstats();


            Console.ReadKey();
            
        }
    }
}