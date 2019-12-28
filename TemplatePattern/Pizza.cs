using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
   public abstract class Pizza
    {
        public void MakePizza()
        {
            AddDough();
            AddSauces();
            AddCheese();
            AddToppings();
        }

        private void AddDough()
        {
            Console.WriteLine("Dough is ready");
        }
        private void AddSauces()
        {
            Console.WriteLine("Sauces are applied");
        }

        private void AddCheese()
        {
            Console.WriteLine("Cheese applied");
        }

        public abstract void AddToppings();
    }
}
