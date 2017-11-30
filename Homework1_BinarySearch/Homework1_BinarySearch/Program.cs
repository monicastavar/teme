using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            var lista = new int[] { 2, 5, 8, 33, 56, 78, 90 };
            //var lista = new String[] { "mama", "tata", "flori", "pietre", "lala", "lili", "lulu" };
            Console.WriteLine(Search(lista, 33));
            Console.WriteLine(string.Join(", ",lista.Where((n, i) => n % 2 == 0)));
            Console.WriteLine(string.Join(", ",lista.Select(n=>n % 2 == 0)));
            Console.ReadKey();
        }


        //cu int
        /*static bool Search(int[] list, int number)
        {
            int listSize = list.Count();
            int middle = list.Count() / 2;

            if (listSize > 2)
            {
                var leftList = list.Take(middle).ToArray();
                var rightList = list.Skip(middle).Take(middle + 1).ToArray();

                return Search(leftList, number) || Search(rightList, number);
            }
            if (listSize == 2)
            {
                return list[0] == number || list[1] == number;
            }
            if (listSize < 2)
            {
                return list[0] == number;
            }

            return true;
        }*/

        //cu generic method
        static bool Search<T>(T[] list, T op)
        {
            int listSize = list.Count();
            int middle = list.Count() / 2;

            if (listSize > 2)
            {
                var leftList = list.Take(middle).ToArray();
                var rightList = list.Skip(middle).Take(middle + 1).ToArray();

                return Search(leftList, op) || Search(rightList, op);
            }
            if (listSize == 2)
            {
                return list[0].Equals(op) || list[1].Equals(op);
            }
            if (listSize < 2)
            {
                return list[0].Equals(op);
            }

            return true;
        }
    }
}
