using ConsoleApp8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            TheHavchik Probnoe_TheHavchik = new TheHavchik();
            foreach (Bludo TheHavchik in Probnoe_TheHavchik.TheHavchick)
            {
                Console.WriteLine(TheHavchik.Name + " " + TheHavchik.Prise + "р");
                Console.ReadKey();
            }
        }
    }
}
