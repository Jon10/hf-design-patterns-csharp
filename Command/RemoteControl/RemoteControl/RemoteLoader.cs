using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl
{
    class RemoteLoader
    {
        static void Main(string[] args)
        {
            //SimpleRemoteControlTest();
            //RemoteControlTest();
            //RemoteControlTestCeilingFan();
            RemoteControlTestMacro();

            Console.ReadKey();
        }

        static void RemoteControlTestMacro()
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            Stereo stereo = new Stereo("Living Room");
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            CeilingFanHighCommand ceilingFanOn = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            ICommand[] partyOn = { livingRoomLightOn, ceilingFanOn, stereoOnWithCd };
            ICommand[] partyOff = { livingRoomLightOff, ceilingFanOff, stereoOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
        }

        static void RemoteControlTestCeilingFan()
        {
            RemoteControl remoteControl = new RemoteControl();

            CeilingFan ceilingFan = new CeilingFan("Living Room");
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(1);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
        }

        static void RemoteControlTest()
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand ceilingFanOn = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCd, stereoOff);
            remoteControl.SetCommand(4, garageDoorUp, garageDoorDown);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OffButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
        }

        //static void SimpleRemoteControlTest()
        //{
        //    SimpleRemoteControl remote = new SimpleRemoteControl();

        //    Light light = new Light();
        //    GarageDoor garageDoor = new GarageDoor();

        //    LightOnCommand lightOn = new LightOnCommand(light);
        //    GarageDoorUpCommand garageOpen = new GarageDoorUpCommand(garageDoor);

        //    remote.SetCommand(lightOn);
        //    remote.ButtonWasPressed();
        //    remote.SetCommand(garageOpen);
        //    remote.ButtonWasPressed();
        //}
    }
}
