using System;

class SmartTV : SmartDevice
{
    public bool IsDeviceO { get; private set; }

    public SmartTV(string name) : base(name) { }

    public override void TurnOn()
    {
        Console.WriteLine("SmartTV is turned on.");
        IsDeviceO = true;
    }

    public override void TurnOff()
    {
        Console.WriteLine("SmartTV is turned off.");
        IsDeviceO = false;
    }
}
