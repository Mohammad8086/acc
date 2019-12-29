using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp5 //enumerable class test
{//33
    class Program
    {
        unsafe static void Main(params string[] args)
        {
            A<int> test = new A<int>(10);
            for (int i = 0; i < test.arr.Length; i++)
            {
                test.arr[i] = (i + 1) * 10;
            }
            
            foreach(int element in test)
            {
                Console.WriteLine(element);
            }
        }
    }
    static class initializer
    {
        public static void printVal<T>(this T value) => Console.WriteLine($"type: {typeof(T)}\t{value}");
    }
    class A<T> : IEnumerable<T>
    {
        private T[] Arr;
        public A(int sizeOf)
        {
            Arr = new T[sizeOf];
        }
        
        public T[] arr
        {
            get
            {
                return Arr;
            }
            set
            {
                Arr = value;
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }
        
    }
    


}
