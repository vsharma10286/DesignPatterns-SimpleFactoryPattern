using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
   public class MeatPizza : Pizza
    {
        

        public override void AddToppings()
        {
            Console.WriteLine("Added Meat , Onion, Tomato!!");
        }
    }
}
