using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCLib.Delegates
{
    public delegate void ProgressMade(int Progress, string[] Actions, string[] Warnings, string[] Errors);
    public delegate void CommandCompleted(Interfaces.I_MCC_Action ExitAction, string[] Actions, string[] Warnings, string[] Errors);
}
