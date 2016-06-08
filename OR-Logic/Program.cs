using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OR_Logic
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(GetX() | GetY());
            System.Console.WriteLine(GetX() || GetY());
            Console.ReadLine();
        }

        public static bool GetX()
        {
            System.Console.WriteLine("GetX()");
            return true;
        }

        public static bool GetY()
        {
            System.Console.WriteLine("GetY()");
            return false;
        }
    }
}
