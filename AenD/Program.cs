using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AenD;

namespace AenD
{
    class Program
    {
        static void Main(string[] args)
        {
            AenD.SingleLinkedList<string> list = new SingleLinkedList<string>();
            
            list.Add("I shit on the sheriff");
            list.Add("But not on the deputy");

             Console.WriteLine(list);

            Console.ReadLine();
        }
    }
}
