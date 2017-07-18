using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 9, 7, 4, 5, 6, 8, 3, 1, 25, 4, 6, 8, 7 };

            Res(LinearSearchFirstVariant(array, 2));
            Res(LinearSearchFirstVariant(array, 7));

            int[] binArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Res(BinarySearchIterationVar(binArray, 13));
            Res(BinarySearchRecursionVar(binArray,0,binArray.Length-1, 13));
            Console.ReadLine();
        }

        public static int LinearSearchFirstVariant(int[] array, int key)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void Res(int index)
        {
            if (index != -1)
            {
                Console.WriteLine("Index of key's element is: {0}, or order number: {1}", index, index + 1);
            }
            else
            {
                Console.WriteLine("ThisElementWasNotFounded");
            }
        }

        public static int BinarySearchIterationVar(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (key == array[middle])
                {
                    return middle;
                }

                if (array[middle] < key)
                {
                    left = middle + 1;
                }
                else //(key < array[middle])
                {
                    right = middle - 1;
                }
            }
            return -1;
        }

        public static int BinarySearchRecursionVar(int[] array, int left, int right, int key)
        {

            //int left = 0;
            //int right = array.Length - 1;
            int middle = left + (right - left) / 2;

            if (right < left)
            {
                return -1;
            }

            if (key == array[middle])
            {
                return middle;
            }

            if (array[middle] < key)
            {
                left = middle + 1;
                return BinarySearchRecursionVar(array, left, right, key);
            }
            else// if(key < array[middle])
            {
                right = middle - 1;
                return BinarySearchRecursionVar(array, left, right, key);
            }

        }
    }

}
