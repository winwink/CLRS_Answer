using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace CLRS.Para2
{
    class InsertionSort
    {
        public int[] GetAnInt(int length)
        {
            if (length <= 0) throw new  ArgumentException("length must lager than 0");
            int[] a = new int[length];
            Random random = new Random();
            for(int i=0;i<length;i++)
            {
                a[i] = random.Next(0, 100);
            }
            return a;
        }

        public void SortUnDesc(int[] a)
        {
            for (int j = 1; j < a.Length; j++)
            {
                int key = a[j];
                int i = j - 1;
                while (i >= 0 && a[i] > key)
                {
                    a[i + 1] = a[i];
                    i --;
                }
                a[i + 1] = key;
            }
        }
        //question 2.1-2
        public void SortUnAsc(int[] a)
        {
            for (int j = 1; j < a.Length; j++)
            {
                int key = a[j];
                int i = j - 1;
                while (i >= 0 && a[i] < key)
                {
                    a[i + 1] = a[i];
                    i--;
                }
                a[i + 1] = key;
            }
        }

        public void FindNum(int[] a, int v)
        {
            
        }
    }
}
