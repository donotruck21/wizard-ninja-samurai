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

        public void Attack(Human human){
            Console.WriteLine("Attacking!!");
            int damage = strength * 3;
            human.health -= damage;
        }
    }







    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human donovan = new Human("Donovan");
            Human kris = new Human("Kris");
            Console.WriteLine(donovan.name);
            Console.WriteLine(kris.name);
            Console.WriteLine(kris.health);
            donovan.Attack(kris);
            Console.WriteLine(kris.health);

        }
    }
}
