using System;
using System.Diagnostics;

namespace Basic_Sorting_Algorithms
{
    class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;
        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }
        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
                numElements = 0;
            }
        }
        public void BubbleSort()
        {
            int temp;
            for (int outer = upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }     
            }
        }
        public void SelectionSort()
        {
            int temp, min;
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)
                {
                    if (arr[inner] < arr[min])
                    {
                        min = inner;
                    }
                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
      
            }
        }
        public void InsertionSort()
        {
            int temp, inner;
            for (int outer = 1; outer <= upper; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while (inner > 0 && arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    //inner--;
                    inner -= 1;
                }
                arr[inner] = temp;
            }
        }
        static void Main()
        {
            Stopwatch timer = new Stopwatch(); // https://www.codeguru.com/csharp/article.php/c18827/Timing-Your-C-Code-with-the-Stopwatch-Class.htm
            
            CArray randomNums = new CArray(10000);
            Random rnd = new Random(100);
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                randomNums.Insert((int)(rnd.NextDouble() * 100));
            }
            randomNums.InsertionSort();

            timer.Stop();
            Console.WriteLine("Time for Insertion sort : {0}",timer.Elapsed);
            randomNums.Clear();
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                randomNums.Insert((int)(rnd.NextDouble() * 100));
            }
            randomNums.SelectionSort();

            timer.Stop();
            Console.WriteLine("Time for Selection sort : {0}", timer.Elapsed);
            randomNums.Clear();
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                randomNums.Insert((int)(rnd.NextDouble() * 100));
            }
            randomNums.BubbleSort();

            timer.Stop();
            Console.WriteLine("Time for Bubble sort    : {0}", timer.Elapsed);          

            Console.ReadKey();
        }
    }
}
