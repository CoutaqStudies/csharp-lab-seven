using LabOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSeven
{
    class Sorter
    {
        public static void Execute()
        {
            int[] nums = { 4, 2, 3, 5, 1 };
            Console.WriteLine("Selection: ");
            /*foreach (int num in ShellSort(nums))
            {
                Console.WriteLine(num);
            }*/
            Console.WriteLine("Insertion: ");
            foreach (int num in InsertionSort(nums))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Bubble: ");
            foreach (int num in BubbleSort(nums))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Ripple: ");
            foreach (int num in RippleSort(nums))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Shell: ");
            foreach (int num in ShellSort(nums))
            {
                Console.WriteLine(num);
            }
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
            while (list.Count > 0)
            {
                int smallestPop = list.Min(country => country.getPopulation());
                finalList.Add(list.Find(country => country.getPopulation() == smallestPop));
                list.Remove(list.Find(country => country.getPopulation() == smallestPop));
            }
            return finalList;
        }
        public static int[] InsertionSort(int[] list)
        {
            while (!isListSorted(list))
            {
                for (int i = 0; i < list.Length-1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        int tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                    }
                }
            }
            return list;
        }
        public static int[] BubbleSort(int[] list)
        {
            while(!isListSorted(list))
            for(int i = 0; i < list.Length-1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    int tmp = list[i];
                    list[i] =  list[i + 1];
                    list[i+1] = tmp;
                }
            }
            return list;
        }
        public static int[] RippleSort(int[] list)
        {
            while (!isListSorted(list))
                for (int i = 0; i < list.Length - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        int tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                    }
                }
            while (!isListSorted(list))
                for (int i = list.Length - 1 ; i >0; i--)
                {
                    if (list[i] > list[i - 1])
                    {
                        int tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                    }
                }
            return list;
        }
        public static int[] ShellSort(int[] list)
        {
            for (int s = (list.Length-1)/2; s>0; s /= 2)
            {
                for (int i = 0; i <= list.Length; i++)
                {
                    if ((i + s) < (list.Length - 1) && list[i] > list[i + s])
                    {
                        int tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                    }
                }
            }
            return list;
        }
    }
}
