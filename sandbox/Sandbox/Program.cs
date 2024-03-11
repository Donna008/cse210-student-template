using System;

class Program
{
    static void Main()
    {
        House myHouse = CreateSampleHouse(); // Create a sample house with devices

        Console.WriteLine("Welcome to the Smart Home Simulator!");

         while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Turn on all lights in a room");
            Console.WriteLine("2. Turn off all lights in a room");
            Console.WriteLine("3. Turn on a specific device");
            Console.WriteLine("4. Turn off a specific device");
            Console.WriteLine("5. Report all items and status");
            Console.WriteLine("6. Report all items that are on");
            Console.WriteLine("7. Report the longest on item");
            Console.WriteLine("8. Simulate random device activations");
            Console.WriteLine("9. Exit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter room number: ");
                        if (int.TryParse(Console.ReadLine(), out int roomNumber1))
                        {
                            myHouse.TurnOnAllLightsInRoom(roomNumber1);
                        }
                        break;

                    case 2:
                        Console.Write("Enter room number: ");
                        if (int.TryParse(Console.ReadLine(), out int roomNumber2))
                        {
                            myHouse.TurnOffAllLightsInRoom(roomNumber2);
                        }
                        break;

                    case 3:
                        Console.Write("Enter device name: ");
                        string deviceNameOn = Console.ReadLine();
                        myHouse.TurnOnDevice(deviceNameOn);
                        break;

                    case 4:
                        Console.Write("Enter device name: ");
                        string deviceNameOff = Console.ReadLine();
                        myHouse.TurnOffDevice(deviceNameOff);
                        break;

                    case 5:
                        myHouse.ReportAllItemsAndStatus();
                        break;

                    case 6:
                        myHouse.ReportAllItemsOn();
                        break;

                    case 7:
                        myHouse.ReportLongestOnItem();
                        break;

                    case 8:
                        Console.Write("Enter duration (in seconds) for random activation: ");
                        if (int.TryParse(Console.ReadLine(), out int duration))
                        {
                            myHouse.SimulateRandomizedActivation(duration);
                        }
                        break;

                    case 9:
                        Console.WriteLine("Exiting Smart Home Simulator. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    
    }
        // ... (The rest of your existing Main method code)
    

    // Create a sample house with devices
    static House CreateSampleHouse()
    {
        House house = new House();

        Room livingRoom = new Room();
        livingRoom.AddDevice(new SmartLight("Living Room Light 1"));
        livingRoom.AddDevice(new SmartLight("Living Room Light 2"));
        livingRoom.AddDevice(new SmartTV("Living Room TV"));
        house.AddRoom(livingRoom);

        Room bedroom = new Room();
        bedroom.AddDevice(new SmartLight("Bedroom Light"));
        bedroom.AddDevice(new SmartHeater("Bedroom Heater"));
        house.AddRoom(bedroom);

        return house;
    }
}
