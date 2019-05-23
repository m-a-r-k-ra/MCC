using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCLib.Interfaces
{
    public interface I_MCC_Action
    {
        I_MCC_Action Execute(string[] Data);
        bool ExitConsole { get; set; }
        string[] ExitArguments { get; set; }
        string ExitCommandLine { get; set; }
        Func<I_MCC_Action> ExitAction { get; set; }
        Func<string, I_MCC_Action> ExitActionStr { get; set; }
        Delegates.ProgressMade OnProgressMade { get; set; }

    }
}
