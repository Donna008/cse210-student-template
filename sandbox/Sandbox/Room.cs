using System;
using System.Collections.Generic;

class Room
{
    public List<SmartDevice> Devices;

    public Room()
    {
        Devices = new List<SmartDevice>();
    }

    public void AddDevice(SmartDevice device)
    {
        Devices.Add(device);
    }

    public void TurnOnAllLights()
    {
        foreach (SmartDevice device in Devices)
        {
            if (device is SmartLight)
            {
                device.TurnOn();
            }
        }
    }

    public void TurnOffAllLights()
    {
        foreach (SmartDevice device in Devices)
        {
            if (device is SmartLight)
            {
                device.TurnOff();
            }
        }
    }

    public void TurnOnDevice(SmartDevice device)
    {
        device.TurnOn();
    }

    public void TurnOffDevice(SmartDevice device)
    {
        device.TurnOff();
    }

    public void ReportAllItemsAndStatus()
    {
        foreach (SmartDevice device in Devices)
        {
            Console.WriteLine($"Item: {device.GetType().Name}, Status: {(device.IsDeviceOn() ? "On" : "Off")}");
        }
    }

    public void ReportAllItemsOn()
    {
        foreach (SmartDevice device in Devices)
        {
            if (device.IsDeviceOn())
            {
                Console.WriteLine($"Item: {device.GetType().Name}");
            }
        }
    }

    public void ReportLongestOnItem()
    {
        SmartDevice longestOnDevice = GetLongestOnDevice();
        if (longestOnDevice != null)
        {
            TimeSpan uptime = GetUptime(longestOnDevice);
            Console.WriteLine($"Longest on item: {longestOnDevice.GetType().Name}, Duration: {uptime}");
        }
        else
        {
            Console.WriteLine("No items have been on.");
        }
    }

    internal SmartDevice GetLongestOnDevice()
    {
        SmartDevice longestOnDevice = null;
        TimeSpan longestOnDuration = TimeSpan.MinValue;

        foreach (SmartDevice device in Devices)
        {
            TimeSpan uptime = GetUptime(device);
            if (device.IsDeviceOn() && uptime > longestOnDuration)
            {
                longestOnDevice = device;
                longestOnDuration = uptime;
            }
        }

        return longestOnDevice;
    }

    internal TimeSpan GetUptime(SmartDevice device)
    {
        // Calculate and return the duration the device has been on
        // You need to implement the logic to calculate the uptime for a specific device
        // For now, the method returns a placeholder value
        return TimeSpan.FromMinutes(0);
    }
}
