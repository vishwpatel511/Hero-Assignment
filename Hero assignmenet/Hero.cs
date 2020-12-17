using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hero_assignmenet
{
    public class Hero
    {
        // PRIVATE INSTANCE VARIABLES

        private int _strength;
        private int _speed;
        private int _health;
        private string _name;


        //PUBLIC PROPERTIES

        public string Name
        {

            get
            {
                return _name;
            }
            

        }

        public int Strength
        {
            get
            {
                return _strength;
            }
            set
            {
                _strength = value; 
            }
           
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
            
        }

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
            
        }

        //CONSTRUCTOR

         public Hero(string name)
        {
            this._name = name;
            generateAbilities();
           

        }

        //METHODS

        private void generateAbilities()
        {
            Random rndm = new Random();
            Speed = rndm.Next(1,101);
            Health = rndm.Next(1, 101);
            Strength = rndm.Next(1, 101);


        }

        public void Fight()
        {
            hitDamage();
            hitAttempt();
        }

        private bool hitAttempt()
        {
            
            Random rndm = new Random();
            int isHit = rndm.Next(0,2);
            int chances = rndm.Next(1, 6);
         
            if (isHit == 1)
            {
                if (chances == 3)
                {
                    hitDamage();
                    Console.WriteLine($"Bullet hits to the {Name}...");
                    Console.WriteLine("Damage is: " + hitDamage());
                    return true;
                }
                else
                {
                    Console.WriteLine("Attempt hasn't made");
                    return false;
                }
               
               
            }
          
            else
            {
                Console.WriteLine($"Bullet misses {Name}");
                return false;
            }

        }

        private int hitDamage()
        {
            Random rndm = new Random();
            int damageValue;
            return damageValue = rndm.Next(1, 7) * Strength;
            
        }

        public void Show()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"| Player Name    : {Name}");
            Console.WriteLine($"| {Name}'s Health: {Health}");
            Console.WriteLine($"| {Name}'s Speed : {Speed}");
            Console.WriteLine($"| {Name}'s Health: {Strength}");
            Console.WriteLine("-------------------------------------");

        }


    }
}
