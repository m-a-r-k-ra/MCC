using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCLib.Interfaces
{
    /// <summary>
    /// Represents an Argument
    /// Example : /f MyFileName.txt 
    /// Example : /f =MyFileName.txt
    /// Example : /f =MyFileName.txt =SecondFileName.txt
    /// /// Example : /f ="c:\SomeDIR\M y F i l e N  a m e.txt" ="SecondFile Name.txt"
    /// </summary>
    public interface I_MCC_Argument
    {
        string ArgumentName { get; }
        List<I_MCC_Argument> SubArguments { get; }
        bool ExpectsValue { get; }        
        int MaxNumberOfValues { get; }
        string ValueStartIndicator { get; }        
        string Help { get; }
        I_MCC_Action ArgumentAction { get; }
    }
}
