using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCLib.Interfaces
{
    public interface I_MCC_Command
    {
        bool QuickCheck(string CommandLine);
        string MainCommand { get; }
        List<I_MCC_Argument> AvailableArguments { get; }
        event Delegates.ProgressMade OnProgressMade;
        event Delegates.CommandCompleted OnCommandCompleted;
    }
}
