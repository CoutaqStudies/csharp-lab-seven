using LabOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabSeven
{
    class Sorter
    {
        public static Boolean isListSorted(List<int> list)
        {
            for(int i = 0; i < list.Count-1; i++)
            {
                if((list[i]>list[i+1]))
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
        public static List<int> InsertionSort(List<int> list)
        {
            List<int> finalList = new List<int>();
            while (!isListSorted(finalList) || finalList.Count<list.Count)
            {
                if(finalList.Count<list.Count)
                finalList.Add(list[finalList.Count]);

                for (int i = 0; i < finalList.Count-1; i++)
                {
                    if (finalList[i] > finalList[i + 1])
                    {
                        finalList.Insert(i, finalList[i+1]);
                        finalList.RemoveAt(i+2);
                    }
                }
            }
            return finalList;
        }
        // TODO: 
        /*public static List<int> InsertionSort(List<int> list)
        {
            List<int> finalList = new List<int>();
            while (!isListSorted(finalList) || finalList.Count < list.Count)
            {
                if (finalList.Count < list.Count)
                    finalList.Add(list[finalList.Count]);

                for (int i = 0; i < finalList.Count - 1; i++)
                {
                    if (finalList[i] > finalList[i + 1])
                    {
                        finalList.Insert(i, finalList[i + 1]);
                        finalList.RemoveAt(i + 2);
                    }
                }
            }
            return finalList;
        }*/
    }
}
