using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo_1
{
    //sealed restrict the inhertitance

  public sealed  class Singleton
    {
        private  int counter;

        // below is example of eager loading , when object is available before it is use //
        //private static readonly Singleton instance = new Singleton();


        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=> new Singleton());



        public static Singleton getInstance
        {
            get
            {              
                return instance.Value;
            }
        }

        /*  
         *  Private COnstructor ensures that Object is not instantiated other than with in the class itself
         *  */

        private Singleton()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public void PrintMessage(string text)
        {
            Console.WriteLine(text);
        }
    }
}
