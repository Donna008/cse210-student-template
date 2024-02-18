using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2* (width +height) * 3.25;

        glassArea = 2* (width * height);

        Console.WriteLine("a sentence...." + woodLength +"feet,a string");
        Console.WriteLine("another sentence...."+glassArea +"square meters.string");
    }
    }