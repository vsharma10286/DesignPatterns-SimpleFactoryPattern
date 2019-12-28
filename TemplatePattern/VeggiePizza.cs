using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
   public class VeggiePizza : Pizza
    {
       

        //public void AddDough()
        //{
        //    Console.WriteLine("Dough is ready");
        //}
        //public void AddSauces()
        //{
        //    Console.WriteLine("Sauces are applied");
        //}

        //public void AddCheese()
        //{
        //    Console.WriteLine("Cheese applied");
        //}

        public override void AddToppings()
        {
            Console.WriteLine("Added Veggies, Onion, Tomato!!");
        }

    }
}
