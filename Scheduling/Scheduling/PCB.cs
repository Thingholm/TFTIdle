using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    public class PCB
    {
        public string ProcessName { get; set; }
        public int ProcessPriority { get; set; }
        public enum ProcessStateType { New, Ready, Running, Waiting, Terminated };

        public ProcessStateType ProcessState { get; set; }
        public override string ToString()
        {
            return $"{ProcessName}({ProcessPriority})";
        }

        public PCB(string processName, int processPriority)
        {
            ProcessName = processName ;
            ProcessPriority = processPriority ;
        }
    }
}
