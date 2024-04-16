using System;
using System;

using System.Collections.Generic;

using System.Text;

// for (int i=2; i<=20;i=i+5)
// { 
//     Console.WriteLine(i);
// }
// string a = "Alice";
// string b = "Bob";
// string c = "Chris";
// List<string> colors = new List<string>{ a, b, c };
// List<int> list = new List<int>{1,2,3,4,5};

// # 1 for i in list,and print the items of the list
// foreach (int color in list)
// {
//     Console.WriteLine($"{color}");
// }
// # 2
// for (int i = 0; i< list.Count;i++)
// {
//     Console.WriteLine($"{list[i]}");
// }


// Compute the sum, or total, of the numbers in the list.
Console.WriteLine("Enter a list of number, type 0 when finished ");
// string _fnum  = Console.ReadLine();
// int _dnum =int.Parse(_fnum);
List<int> _numbers = new List<int>();
int _inum;
do
{
    Console.Write("Enter a number: ");
    string _number = Console.ReadLine();
     _inum = int.Parse(_number);
    _numbers.Add(_inum);
} while (_inum != 0);

// Console.WriteLine(_numbers);
// foreach(int num in _numbers)
// {
//     Console.Write(num);
// }
// Compute the average of the numbers in the list.
double _avg = Queryable.Average(_numbers.AsQueryable());
Console.WriteLine("Average:"+ _avg);

// Find the maximum, or largest, number in the list.
int _max = _numbers.Max();
int _min = _numbers.Min();
Console.WriteLine($"Max: {_max}, Min: {_min}");

// Stretch Challenge
// Have the user enter both positive and negative numbers, then find the smallest positive number (the positive number that is closest to zero).
int _positive = int.MaxValue;
foreach(int numb in _numbers)
{
    if (numb>0 && numb<_positive)
    {
         _positive = numb;
    }
}

Console.WriteLine("The min positive number is: " + _positive);
_numbers.Sort();
Console.WriteLine("The sorted list is:");
foreach(int i in _numbers)
{
    Console.WriteLine(i);
}
