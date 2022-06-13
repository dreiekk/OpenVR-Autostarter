using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OpenVR_Autostarter
{
    public class AutostartTask
    {
        public string UUID { get; set; }
        public bool Enabled { get; set; } = true;
        public string Name { get; set; } = "";
        public StartStopAction StartAction { get; set; } = StartStopAction.START_PROGRAM;
        public StartStopAction StopAction { get; set; } = StartStopAction.STOP_PROGRAM;
        public string ProgramPath { get; set; } = "";
        public string ProgramArguments { get; set; } = "";
        public bool StartMinimized { get; set; } = false;
        public bool CloseByProcessName { get; set; } = false;
        public string ProcessName { get; set; } = "";
        public bool ForceKillAfterTime { get; set; } = false;

        public AutostartTask()
        {
            UUID = Guid.NewGuid().ToString();
        }
    }

}
