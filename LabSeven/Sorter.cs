using LabOne;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace LabSeven
{
    class Sorter
    {
        public static void Execute()
        {
            Stopwatch stopWatch = new Stopwatch();
            TimeSpan ts;
            int[] nums = new int[100000];
            int[] dummyList = new int[nums.Length];
            Random rand = new Random();
            for(int i = 0; i<nums.Length; i++)
            {
                nums[i] = rand.Next(nums.Length);
            }
            Console.WriteLine("----Random: ");
            Console.WriteLine("Selection: ");
            stopWatch.Start();
            SelectionSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Insertion: ");
            stopWatch.Restart();
            dummyList = nums;
            InsertionSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Bubble: ");
            stopWatch.Restart();
            dummyList = nums;
            BubbleSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Ripple: ");
            stopWatch.Restart();
            dummyList = nums;
            RippleSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Shell: ");
            stopWatch.Restart();
            dummyList = nums;
            ShellSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);
            //sorted
            Console.WriteLine("----Sorted: ");
            dummyList = ShellSort(dummyList);
            Console.WriteLine("Selection: ");
            stopWatch.Start();
            SelectionSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Insertion: ");
            stopWatch.Restart();
            dummyList = nums;
            InsertionSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Bubble: ");
            stopWatch.Restart();
            dummyList = nums;
            BubbleSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Ripple: ");
            stopWatch.Restart();
            dummyList = nums;
            RippleSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Shell: ");
            stopWatch.Restart();
            dummyList = nums;
            ShellSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);
            //sorted backwards
            Array.Reverse(dummyList);
            Console.WriteLine("----Reverse: ");
            Console.WriteLine("Selection: ");
            stopWatch.Start();
            SelectionSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Insertion: ");
            stopWatch.Restart();
            dummyList = nums;
            InsertionSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Bubble: ");
            stopWatch.Restart();
            dummyList = nums;
            BubbleSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Ripple: ");
            stopWatch.Restart();
            dummyList = nums;
            RippleSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);

            Console.WriteLine("Shell: ");
            stopWatch.Restart();
            dummyList = nums;
            ShellSort(dummyList);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("Time: "+ts.Seconds + ":" + ts.Milliseconds);
        }
        public static Boolean isListSorted(List<int> list)
        {
            for(int i = 0; i < list.Count-1; i++)
            {
                if((list[i]>list[i+1]))
                    return false;
            }
            return true;
        }
        public static Boolean isListSorted(int[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                if ((list[i] > list[i + 1]))
                    return false;
            }
            return true;
        }
        public static List<GeographicalUnit> SelectionSort(List<GeographicalUnit> list){
            List<GeographicalUnit> finalList = new List<GeographicalUnit>();
            while (list.Count>0)
            {
                int smallestPop = list.Min(country => country.getPopulation());
                finalList.Add(list.Find(country => country.getPopulation() == smallestPop));
                list.Remove(list.Find(country => country.getPopulation() == smallestPop));
            }
            return finalList;
        }
        public static int[] SelectionSort(int[] list)
        {
            int[] newList = (int[])list.Clone();
            int checks = 0;
            int swaps = 0;
            for (int i = 0; i < newList.Length - 1; i++)
            {
                int sortedIndex = i;
                for (int j = i + 1; j < newList.Length; j++)
                {
                    checks++;
                    if (newList[j] < newList[sortedIndex])
                        sortedIndex = j;
                }
                swaps++;
                int tmp = newList[i];
                newList[i] = newList[sortedIndex];
                newList[sortedIndex] = tmp;
            }
            Console.WriteLine("Checks: " + checks);
            Console.WriteLine("Swaps: " + swaps);
            return newList;
        }
        public static int[] InsertionSort(int[] list)
        {
            int[] newList = (int[])list.Clone();
            int checks = 0;
            int swaps = 0;
            while (!isListSorted(newList))
            {
                for (int i = 0; i < newList.Length-1; i++)
                {
                    checks++;
                    if (newList[i] > newList[i + 1])
                    {
                        swaps++;
                        int tmp = newList[i];
                        newList[i] = newList[i + 1];
                        newList[i + 1] = tmp;
                    }
                }
            }
            Console.WriteLine("Checks: " + checks);
            Console.WriteLine("Swaps: " + swaps);
            return newList;
        }
        public static int[] BubbleSort(int[] list)
        {
            int[] newList = (int[])list.Clone();
            int checks = 0;
            int swaps = 0;
            Boolean sorted = true;
            do
            {
                sorted = true;
                for ( int sortedIndex = 0; sortedIndex < newList.Length - 1; sortedIndex++)
                {
                    for(int i = sortedIndex; i<newList.Length-1; i++)
                    {
                        checks++;
                        if (newList[i] > newList[i+1])
                        {
                            swaps++;
                            int tmp = newList[i];
                            newList[i] = newList[i + 1];
                            newList[i + 1] = tmp;
                            sorted = false;
                        }
                    }
                }
            } while (!sorted);
            Console.WriteLine("Checks: " + checks);
            Console.WriteLine("Swaps: " + swaps);
            return newList;
        }
        public static int[] RippleSort(int[] list)
        {
            int checks = 0;
            int swaps = 0;
            int[] newList = (int[])list.Clone();
            while (!isListSorted(newList))
            {
                for (int i = 0; i < newList.Length - 1; i++)
                {
                    checks++;
                    if (newList[i] > newList[i + 1])
                    {
                        swaps++;
                        int tmp = newList[i];
                        newList[i] = newList[i + 1];
                        newList[i + 1] = tmp;
                    }
                }
            }    
            while (!isListSorted(newList))
            {
                for (int i = newList.Length - 1; i > 0; i--)
                {
                    checks++;
                    if (newList[i] > newList[i - 1])
                    {
                        swaps++;
                        int tmp = newList[i];
                        newList[i] = newList[i + 1];
                        newList[i + 1] = tmp;
                    }
                }
            }
            Console.WriteLine("Checks: " + checks);
            Console.WriteLine("Swaps: " + swaps);
            return newList;
        }
        public static int[] ShellSort(int[] list)
        {
            int checks = 0;
            int swaps = 0;
            int[] newList = (int[])list.Clone();
            for (int s = (newList.Length-1)/2; s>0; s /= 2)
            {
                for (int i = 0; i <= newList.Length; i++)
                {
                    checks++;
                    if ((i + s) < (newList.Length - 1) && newList[i] > newList[i + s])
                    {
                        swaps++;
                        int tmp = newList[i];
                        newList[i] = newList[i + 1];
                        newList[i + 1] = tmp;
                    }
                }
            }
            Console.WriteLine("Checks: " + checks);
            Console.WriteLine("Swaps: " + swaps);
            return newList;
        }
    }
}
