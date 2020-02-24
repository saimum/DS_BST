using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BTS bts = new BTS();
            bts.Insert(50);
            bts.Insert(17);
            bts.Insert(23);
            bts.Insert(12);
            bts.Insert(19);
            
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            
        }
    }
}
