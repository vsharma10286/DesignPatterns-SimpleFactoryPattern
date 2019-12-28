using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Making Veggie Pizza==========");
            Pizza pizza = new VeggiePizza();
            pizza.MakePizza();


            Console.WriteLine("=======Making Meat Pizza==========");
            pizza = new MeatPizza();
            pizza.MakePizza();

            Console.ReadKey();
        }
    }
}
