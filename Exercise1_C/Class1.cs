using System;
using System.Collections;

namespace Exercise1_C
{
    class Class1
    {

        public String StringComparison(String text1, String text2)
        {
            if(String.Equals(text1, text2))
            {
                return "The Strings have the same value";
            }
            return "The Strings don't have the same value";
        }

        public void VerifyBiggestNumber(int[] list)
        {
            int aux = list[0];
            for(int i = 0; i < list.Length; i++)
            {
                if(aux < list[i])
                {
                    aux = list[i];
                }
            }
            Console.WriteLine("Biggest Number: ");
            Console.WriteLine(aux);
        }

        public void SortList(String[] list)
        {
            //Array.Sort(list, StringComparer.InvariantCulture);
            Array.Sort(list);
            Console.WriteLine("Ascending Order:");
            Array.ForEach(list, x => Console.WriteLine(x));
            Array.Reverse(list);
            Console.WriteLine("Descending Order:");
            Array.ForEach(list, x => Console.WriteLine(x));
        }

        public int CountStringLength(String text)
        {
            int size = text.Length;
            return size;
        }

    }
}
