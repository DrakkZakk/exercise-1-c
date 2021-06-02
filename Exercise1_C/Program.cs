using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_C
{
    class Program
    {    
        static void Main(string[] args)
        {
            int stringSize = 0;
            int[] list = new int[8] {10, 21, 32, 40, 5, 7, 9, 100};
            String[] sortList = new string[] { "Jose", "Juan", "Ana", "Patricia"};

            Class1 one = new Class1();
            Console.WriteLine(one.StringComparison("Hello", "Hello"));
            one.VerifyBiggestNumber(list);
            one.SortList(sortList);
            stringSize = one.CountStringLength("Amoxicilina");
            Console.WriteLine("Length of String given: " + stringSize);

            Class2 two = new Class2();
            Console.WriteLine("First five values: ");
            two.PrintFirstFiveValues(list);
            two.PrintSmallestNumber(list);
        }
    }
}
