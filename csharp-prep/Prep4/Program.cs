using System;
using System;

using System.Collections.Generic;

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        for (int i=2; i<=20;i=i+5)
        { 
            Console.WriteLine(i);
        }
        // string a = "Alice";
        // string b = "Bob";
        // string c = "Chris";
        // List<string> colors = new List<string>{ a, b, c };
        List<int> list = new List<int>{1,2,3,4,5};
        foreach (int color in list)
        {
            Console.WriteLine($"{color}");
        }
    }
}