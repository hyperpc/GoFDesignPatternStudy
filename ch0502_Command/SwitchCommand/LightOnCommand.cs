using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0502_Command.SwitchCommand
{
    public class LightOnCommand : ICommand
    {
        protected Light myLight;
        public LightOnCommand(Light l)
        {
            myLight = l;
        }
        public void execute()
        {
            myLight.turnOn();
        }
    }
}
