using System;

namespace Pewarisan
{
    public class ArchMage : Mage
    {
        public int ancientKnowledge; 

        public ArchMage()
        {
            Console.WriteLine("----> Konstruktor default ArchMage <----");
        }

        public ArchMage(int ancientKnowledge, int spellPower, string id, string name, int basePower, string address) 
        : base(spellPower, id, name, basePower, address)
        {
             Console.WriteLine("----> Konstruktor berparameter ArchMage <----");
             this.ancientKnowledge = ancientKnowledge;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("ANCIENT KNOWELDGE       = " + ancientKnowledge);
            Console.WriteLine("TOTAL POWER = "  + (GetBasePower() + spellPower + ancientKnowledge));
            Console.WriteLine("==========================="); 
        }
    }
}