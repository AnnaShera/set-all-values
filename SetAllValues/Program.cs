using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetAllValues
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary dict = new MyDictionary();
            dict.Add(1, 10);
            dict.Add(2, 20);
            dict.Add(3, 30);
            dict.Add(4, 40);
            dict.Add(5, 50);
            dict.Add(6, 60);
            dict.PrintDictionary();
            dict.Set(6, 15);
            dict.PrintValueOfKey(6);
            dict.Set(6, 55);
            dict.PrintValueOfKey(6);
            dict.SetAll(4000);
            dict.PrintValueOfKey(6);
            dict.PrintValueOfKey(2);
            dict.SetAll(8000);
            dict.PrintValueOfKey(6);
            dict.PrintValueOfKey(2);
            dict.PrintValueOfKey(1);
            dict.Set(2, 200);
            dict.PrintDictionary();
            Console.ReadKey();
        }
    }
}
