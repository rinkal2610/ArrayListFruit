using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppArrayListFruit
{
    
    internal class Program
    {
        static ArrayList fruitList;
        static void Main(string[] args)
        {
            fruitList=new ArrayList { "apple", "banana", "cherry", "date", "elderberry" };
            Console.WriteLine("total number of elements in list: "+fruitList.Count);
            Console.WriteLine("elements in list");
            PrintList();
            Console.WriteLine("eneter an element to search");
            string searchElement=Console.ReadLine();
            bool present=fruitList.Contains(searchElement);
            if(present==true)
            {
                Console.WriteLine("yes it is present");
            }
            else Console.WriteLine("no its not present");
            Console.WriteLine("eneter an element to insert");
            string insetElement=Console.ReadLine();
            fruitList.Add(insetElement);
            Console.WriteLine("list after insertion");
            PrintList();
            Console.WriteLine("which element you want to remove from list");
            string d=Console.ReadLine();
            fruitList.Remove(d);
            Console.WriteLine("list after removing element");
            PrintList();
            Console.ReadKey();
        }
        public static void PrintList()
        {
            foreach(var item in fruitList)   Console.WriteLine(item);
        }
       

    }
}
