using HeavyLiftThirdParty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            IHeavyLift obj = new HeavyLift();
            Console.WriteLine("Hello World! Lets Heavy Lift");
            obj.LoggerHook += new Logger(CustomLog);
            obj.Process();

            Console.ReadKey();
        }

        public static void CustomLog(string a)
        {
            Console.WriteLine(a);
        }
    }
}
