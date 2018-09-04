using HeavyLiftThirdParty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyLiftThirdParty
{
    public interface IHeavyLift
    {
        Logger LoggerHook { get; set; }
        void Process();
    }
}
