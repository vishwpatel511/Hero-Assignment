using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hero_assignmenet;

namespace Hero_assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            
        
                Hero hero = new Hero("Vishw");
                hero.Show();
                hero.Fight();
                Console.WriteLine("------------------------------------");
            

            Console.ReadKey();
        }
    }
}
