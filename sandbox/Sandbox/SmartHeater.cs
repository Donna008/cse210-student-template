using System;

class SmartHeater : SmartDevice
{
    public bool IsDeviceO { get; private set; }

    public SmartHeater(string name) : base(name) { }

    public override void TurnOn()
    {
        Console.WriteLine("SmartHeater is turned on.");
        IsDeviceO = true;
    }

    public override void TurnOff()
    {
        Console.WriteLine("SmartHeater is turned off.");
        IsDeviceO = false;
    }
}
