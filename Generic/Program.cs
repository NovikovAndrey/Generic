using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Mass<T>
    {
        T[] arrays;
        public Mass()
        {
            arrays = new T[0];
        }
        public void Add(T item)
        {
            T[] ts = new T[arrays.Length + 1];
            for (int i=0; i<arrays.Length;i++)
            {
                ts[i] = arrays[i];
            }
            ts[arrays.Length] = item;
            arrays = ts;
        }
        public void Del(T item)
        {
            int index = -1;
            for (int i=0; i<arrays.Length; i++)
            {
                if (arrays[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            if (index>-1)
            {
                T[] ts = new T[arrays.Length - 1];
                for (int i=0, j=0; i<arrays.Length; i++)
                {
                    if (i==index)
                    {
                        continue;
                    }
                    ts[j] = arrays[i];
                    j++;
                }
                arrays = ts;
            }
            
        }
        public T GetMass(int z)
        {

            return arrays[z];
        }
        public int GetLength()
        {
            return arrays.Length;
        }
    }

}
