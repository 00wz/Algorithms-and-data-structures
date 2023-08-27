using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = PrepareArray(20);
            PrintArray(arr);

            HeapSort(arr);

            PrintArray(arr);

        }

        static void HeapSort(int[] arr)
        {
            for (int i =  arr.Length/ 2 - 1; i >= 0; i--)
                Heapify(arr, i, arr.Length);

            int tmp;
            for(int i = arr.Length-1; i > 0; i--)
            {
                tmp = arr[i];
                arr[i] = arr[0];
                arr[0] = tmp;

                Heapify(arr, 0, i);
            }
        }

        static void Heapify(int[] arr,int i,int n)
        {
            int left = i * 2 + 1;
            int right = i * 2 + 2;
            int tmp;
            int largest = i;
            if (left<n && arr[left] > arr[largest])
            {
                largest = left;

            }
            if (right<n && arr[right] > arr[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                tmp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = tmp;

                Heapify(arr, largest, n);
            }

        }

        private static int[] PrepareArray(int N)
        {
            var r = new Random();
            int[] res = new int[N];
            for (int i = 0; i < res.Length; i++)
                res[i] = r.Next(0, 10);
            return res;
        }

        private static void PrintArray(int[] arr)
        {
            String result = "massiv = [";
            for (int i = 0; i < arr.Length; i++)
            {
                result += " " + arr[i];
                if (i != arr.Length - 1) result += " ,";
            }
            result += " ]";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
