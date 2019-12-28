using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => FromS1(),
                () => FromS2()
                );

            Console.ReadLine();

        }

        private static void FromS2()
        {
            Singleton s2 = Singleton.getInstance;

            s2.PrintMessage("Second Message");
        }

        private static void FromS1()
        {
            Singleton s1 = Singleton.getInstance;

            s1.PrintMessage("First Message");
        }
    }
}
