using System;

namespace HeavyLiftThirdParty
{
    public delegate void Logger(string a);
    public class HeavyLift : IHeavyLift
    {
        public Logger LoggerHook { get; set; }
        public void Process()
        {
            Console.WriteLine("++++++++++++HeavyLift Process1..+++++++++++++++");
            LoggerHook("Log for HeavyLift Process1");
            Console.WriteLine("++++++++++++HeavyLift Process2..+++++++++++++++");
            LoggerHook("Log for HeavyLift Process2");
            Console.WriteLine("++++++++++++HeavyLift Process3..+++++++++++++++");
            LoggerHook("Log for HeavyLift Process3");
        }
    }
}
