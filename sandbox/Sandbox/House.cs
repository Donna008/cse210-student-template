using System;
using System.Collections.Generic;

class House
{
    private List<Room> Rooms;

    public House()
    {
        Rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        Rooms.Add(room);
    }

    public void TurnOnAllLightsInRoom(int roomNumber)
    {
        if (roomNumber >= 0 && roomNumber < Rooms.Count)
        {
            Rooms[roomNumber].TurnOnAllLights();
        }
        else
        {
            Console.WriteLine("Invalid room number.");
        }
    }

    public void TurnOffAllLightsInRoom(int roomNumber)
    {
        if (roomNumber >= 0 && roomNumber < Rooms.Count)
        {
            Rooms[roomNumber].TurnOffAllLights();
        }
        else
        {
            Console.WriteLine("Invalid room number.");
        }
    }

    public void TurnOnDevice(string deviceName)
    {
        foreach (var room in Rooms)
        {
            var device = room.Devices.Find(d => d.Name == deviceName);
            if (device != null)
            {
                room.TurnOnDevice(device);
                return;
            }
        }

        Console.WriteLine($"Device '{deviceName}' not found.");
    }

    public void TurnOffDevice(string deviceName)
    {
        foreach (var room in Rooms)
        {
            var device = room.Devices.Find(d => d.Name == deviceName);
            if (device != null)
            {
                room.TurnOffDevice(device);
                return;
            }
        }

        Console.WriteLine($"Device '{deviceName}' not found.");
    }

    public void ReportAllItemsAndStatus()
    {
        foreach (var room in Rooms)
        {
            room.ReportAllItemsAndStatus();
        }
    }

    public void ReportAllItemsOn()
    {
        foreach (var room in Rooms)
        {
            room.ReportAllItemsOn();
        }
    }

    public void ReportLongestOnItem()
    {
        TimeSpan longestOnDuration = TimeSpan.MinValue;
        SmartDevice longestOnDevice = null;

        foreach (var room in Rooms)
        {
            var device = room.GetLongestOnDevice();
            if (device != null && room.GetUptime(device) > longestOnDuration)
            {
                longestOnDuration = room.GetUptime(device);
                longestOnDevice = device;
            }
        }

        if (longestOnDevice != null)
        {
            Console.WriteLine($"Longest on item: {longestOnDevice.GetType().Name}, Duration: {longestOnDuration}");
        }
        else
        {
            Console.WriteLine("No items have been on.");
        }
    }

    // internal void SimulateRandomizedActivation(int duration)
    // {
    //     throw new NotImplementedException();
    // }
    public void SimulateRandomizedActivation(int duration)
    {
        Random rand = new Random();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            int roomIndex = rand.Next(Rooms.Count);
            Room randomRoom = Rooms[roomIndex];

            int deviceIndex = rand.Next(randomRoom.Devices.Count);
            SmartDevice randomDevice = randomRoom.Devices[deviceIndex];

            if (!randomDevice.IsDeviceOn())
            {
                randomRoom.TurnOnDevice(randomDevice);
            }

            // Simulate some delay between activations
            System.Threading.Thread.Sleep(rand.Next(500, 1500));

            // Turn off the device after a random duration
            if (DateTime.Now < endTime)
            {
                randomRoom.TurnOffDevice(randomDevice);
            }
        }
}
}

