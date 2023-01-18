using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18.SubTask18._4._2
{
    public class RemoteControl
    {
        ICommand[] Commands;
        public RemoteControl()
        {
            Commands = new ICommand[2];
        }
        public void buttonWasPressed(int slot)
        {
            Commands[slot].execute();
        }
        public void setCommand(int slot, ICommand command)
        {
            Commands[slot] = command;
        }
    }
}
