using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OpenVR_Autostarter
{
    public class AutostarterConfig
    {
        public List<AutostartTask> Tasks;

        public AutostarterConfig()
        {
            Tasks = new List<AutostartTask>();
        }
    }
}
