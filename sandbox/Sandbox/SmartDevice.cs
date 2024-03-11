
using System;
using System.Collections.Generic;

abstract class SmartDevice
{
    public string Name;
    private bool IsOn;

    public SmartDevice(string name)
    {
        Name = name;
        IsOn = false;
    }

    public abstract void TurnOn();

    public abstract void TurnOff();

    public bool IsDeviceOn()
    {
        return IsOn;
    }

    public TimeSpan GetUptime()
    {
        // Calculate and return the duration the device has been on
        return TimeSpan.FromMinutes(0); // Placeholder value
    }
}
