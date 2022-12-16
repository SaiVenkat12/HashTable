using System;
using System.Collections.Generic;

namespace HashTables
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hash Table");

            //MyMapNode<int, string> hasht = new MyMapNode<int, string>(5);
            //hasht.Add(0, "To");
            //hasht.Add(1, "be");
            //hasht.Add(2, "or");
            //hasht.Add(3, "not");
            //hasht.Add(4, "to");
            //hasht.Add(5, "be");

            //string hasht5 = hasht.Get(5);
            //Console.WriteLine("5th index value: " + hasht5);

            //hash.Remove(3);
            //string hash3 = hash.Get(3);
            //Console.WriteLine("3nd index value:" + hash3);

            MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "Paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "beacause");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situation");

            string hash12 = hash.Get("12");
            Console.WriteLine("12th index value: " + hash12);
            string hash16 = hash.Get("16");
            Console.WriteLine("16th index value: " + hash16);

            hash.Remove("17");
            string hash17 = hash.Get("17");
            Console.WriteLine("17th index value: " + hash17);
            Console.WriteLine("Avoidable is removed from the hash");
        }
    }
}