using System;
using System.Collections.Generic;

namespace zd33
{
    public class Arr : ICloneable, IComparable<Arr>, IComparer<Arr>
    {
        private string[] array;
        private int index;

        public Arr(string[] mas, int length)
        {
            array = new string[length];
            for (int i = 0; i < length; i++)
                array[i] = mas[i];
            index = length;
        }

        public Arr(int length)
        {
            array = new string[length];
            index = length;
        }

        public string GetDataByIndex(int indx)
        {
            if (indx >= index | indx < 0)
            {
                return "Error";
            }
            else
            {
                return array[indx];
            }
        }

        public void SetDataByIndex(int indx, string value)
        {
            if (indx >= Index)
                throw new IndexOutOfRangeException();
            else
                array[indx] = value;
        }
        
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string[] Array
        {
            get { return array; }
            set { array = value; }
        }
        
        static public Arr NewClWithoutException(Arr first, Arr second)
        {
            var newArr = new Arr(first.Index + second.Index);
            first.array.CopyTo(newArr.array, 0);
            second.array.CopyTo(newArr.array, first.Index);
            return newArr;
        }

        static public Arr NewClWithException(Arr first, Arr second)
        {
            var newArr = new Arr(first.Index + second.Index);
            first.array.CopyTo(newArr.array, 0);
            int k = first.Index;
            
            for (int i = 0; i < second.Index; i++)
            {
                bool flag = false;
                for (int j = 0; j < k; j++)
                {
                    if (second.array[i] == newArr.array[j])
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    k++;
                    newArr.array[k] = second.array[i];
                }
            }

            var resArr = new Arr(k);
            for (int i = 0; i < k; i++)
                resArr.array[i] = newArr.array[i];
            return resArr;
        }
        
        public void Show()
        {
            for (int i = 0; i < index; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public void Show(int indx)
        {
            if (indx >= index | indx < 0)
                Console.WriteLine("Error");
            else
                Console.WriteLine(array[indx]);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Arr arr)
        {
            return this.Index.CompareTo(arr.Index);
        }
        
        
        public int Compare(Arr arr1, Arr arr2)
        {
            if (arr1.Index > arr2.Index)
                return 1;
            else if (arr1.Index < arr2.Index)
                return -1;
            else
                return 0;
        }
    }
}