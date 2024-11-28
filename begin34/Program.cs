using System;

namespace begin34
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("chand kilo shokoladi alpen girifnan mekhohed ");
              var x = int.Parse(Console.ReadLine());
              Console.WriteLine("chand kilo shokoladi snikers girifnan mekhohed");
              var y = int.Parse(Console.ReadLine());
              var b = 10;
              var a = 15;
              
              var result1 = (y * b);
              var result2 = (x * a);
              Console.WriteLine("shokoladi sniker "+result1+ " somoni shud va alpen boshad "+result2);
        }
    }
}