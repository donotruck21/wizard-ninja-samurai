using System;

namespace ConsoleApplication
{
    public class Human{
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;


        public Human(string nameVal){
            name = nameVal;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human donovan = new Human("Donovan");
            Console.WriteLine(donovan.name);
            Console.WriteLine(donovan.strength);
            Console.WriteLine(donovan.health);
        }
    }
}
