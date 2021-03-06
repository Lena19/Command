﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for(int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }
        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }
        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }
        public void undoButtonWasPushed()
        {
            undoCommand.undo();
        }
        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append("[slot " + i + "] " + onCommands[i].GetType().Name
                    + "    " + offCommands[i].GetType().Name + "\n");
            }
            return sb.ToString();
        }
    }
}
