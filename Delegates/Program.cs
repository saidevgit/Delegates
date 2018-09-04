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

        /*
         *This is useful for hooking of your custom logging
         * https://www.codeproject.com/Articles/884981/Understanding-Delegates-in-Csharp-for-Beginners?msg=5551340#xx5551340xx
         */
        public static void CustomLog(string a)
        {
            Console.WriteLine(a);
        }
    }
}
