using System;

namespace project4
{
    
    public class Character
    {
        private string characterID;
        private string name;
        private int basePower;
        private string address;

        public Character()
        {
            Console.WriteLine("----> konstruktor default character <----");
        
        }

        public Character(string id,string name, int basePower, string address)
        {
            Console.WriteLine("----> konstruktor berparameter character <----");
            this.characterID = id;
            this.name = name;
            this.basePower = basePower;
            this.address = address;

        }
         public void DisplayBaseData()
        {
          Console.WriteLine("CHARACTER ID = " + characterID);
            Console.WriteLine("NAME         = " + name);
            Console.WriteLine("BASEPOWER   = " + basePower);
            Console.WriteLine("ADDRESS      = " + address);
        }

         public int GetBasePower()
        { 
            return basePower;
        }
     }
}