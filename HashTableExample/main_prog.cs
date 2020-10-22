using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableExample
{
    public class main_prog
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "a");
            hash.Add("1", "b");
            hash.Add("2", "c");
            hash.Add("3", "d");

            string hash3 = hash.Get("3");
            Console.WriteLine(hash3);

        }
    }
}
