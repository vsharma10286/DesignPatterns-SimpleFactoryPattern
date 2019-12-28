using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = null;
            Character Varun = new Character();
           

            while (true)
            {

                Console.WriteLine("Choose a weapon for Varun! (1 = Sword , 2 = Axe , 3 = Club)");
                string input = Console.ReadLine();
               
                switch (input)
                {
                    case "1":
                        weapon = new Sword();
                        break;
                    case "2":
                        weapon = new Axe();
                        break;
                    case "3":
                        weapon = new Club();
                        break;
                    default:
                        weapon = new Null();
                        break;
                }

                Varun.SetWeapon(weapon);

                Varun.Attack();


            }

        }
    }
}
