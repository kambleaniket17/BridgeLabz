using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.PrimeAnagramStack
{
    public class InputForStack
    {
        public static void Input()
        {
           string[,] stackarray = Utility.GetAnagrams(Utility.GetPrimeNumbersList());
            SinglyLinkedList s = new SinglyLinkedList();
            ArrayList arrayList = new ArrayList();
            arrayList.Add(stackarray);
            foreach(string abc in stackarray)
            {
                 s.Push(abc);
            }
        }
    }
}