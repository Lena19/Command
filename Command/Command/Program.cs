using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light();
            Hottub hottub = new Hottub();
            GarageDoor garagedoor = new GarageDoor();
            CeilingFan ceilingfan = new CeilingFan();
            Stereo stereo = new Stereo();

            CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingfan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingfan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garagedoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garagedoor);

            HottubOnCommand hottubOn = new HottubOnCommand(hottub);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            LivingroomLightOnCommand livingRoomOn = new LivingroomLightOnCommand(light);
            LivingroomLightOffCommand livingRoomOff = new LivingroomLightOffCommand(light);

            StereoOnWithCDCommand stereoOn = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.setCommand(0, ceilingFanOn, ceilingFanOff);
            remoteControl.setCommand(1, garageDoorUp, garageDoorDown);
            remoteControl.setCommand(2, hottubOn, hottubOff);
            remoteControl.setCommand(3, lightOn, lightOff);
            remoteControl.setCommand(4, livingRoomOn, livingRoomOff);
            remoteControl.setCommand(5, stereoOn, stereoOff);

            Console.WriteLine(remoteControl.toString());

            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(1);
            remoteControl.offButtonWasPushed(1);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(2);
            remoteControl.offButtonWasPushed(2);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(3);
            remoteControl.offButtonWasPushed(3);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(4);
            remoteControl.offButtonWasPushed(4);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(5);
            remoteControl.offButtonWasPushed(5);
            remoteControl.undoButtonWasPushed();
        }
    }
}
