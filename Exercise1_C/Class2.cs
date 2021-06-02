using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_C
{
    class Class2
    {

        public void PrintFirstFiveValues(int[] list)
        {
            for(int i = 0; i < list.Length-3; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public void PrintSmallestNumber(int[] list)
        {
            int aux = list[0];
            for(int i = 0; i < list.Length; i++)
            {
                if(aux > list[i])
                {
                    aux = list[i];
                }
            }
            Console.WriteLine("Smallest number is: " + aux);
        }

        public void PrintDictionary()
        {

        }

    }
}
