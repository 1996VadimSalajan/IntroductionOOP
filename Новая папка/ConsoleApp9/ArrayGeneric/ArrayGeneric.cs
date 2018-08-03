using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGeneric
{
    class ArrayGeneric<T>
    {
        private T[] Array;
        public ArrayGeneric(int size)
        {
            Array = new T[size + 1];
        }
        public T GetItem(int index)
        {
            return Array[index];
        }
        public void SetItem(int index, T value)
        {
            Array[index] = value;
        }
        public void Swap(int a, int b)
        {
            int temp = 0;
            Array[temp] = Array[a];
            Array[a] = Array[b];
            Array[b] = Array[temp];
        }
        public void Swap1(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
