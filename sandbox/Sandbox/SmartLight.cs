using System;

class SmartLight : SmartDevice
{
    public bool IsDeviceO { get; private set; }

    public SmartLight(string name) : base(name) { }

    public override void TurnOn()
    {
        Console.WriteLine("SmartLight is turned on.");
        IsDeviceO = true;
    }

    public override void TurnOff()
    {
        Console.WriteLine("SmartLight is turned off.");
        IsDeviceO = false;
     
    }
}