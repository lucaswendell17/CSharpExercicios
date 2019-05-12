using System;
using System.Collections.Generic;

namespace ExListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco");

            foreach(string obj in list){
                System.Console.WriteLine(obj);
            }
            System.Console.WriteLine(list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            System.Console.WriteLine("First 'A': "+ s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            System.Console.WriteLine("Last 'A': "+ s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            System.Console.WriteLine("First position 'A': " + pos1);

             int pos2 = list.FindLastIndex(x => x[0] == 'A');
            System.Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            System.Console.WriteLine("----------------------------");
            foreach(string obj in list2){
                System.Console.WriteLine(obj);
            }

            list.Remove("Alex");
            System.Console.WriteLine("----------------------------");
            foreach(string obj in list){
                System.Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            System.Console.WriteLine("----------------------------");
            foreach(string obj in list){
                System.Console.WriteLine(obj);
            }
        }
    }
}
