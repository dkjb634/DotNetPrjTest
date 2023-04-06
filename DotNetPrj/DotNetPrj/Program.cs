using System;

namespace DotNetPrj
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool bval = (new Random().Next(3, 4) == 3 ? false : true);
            if (!bval) return;
            else
            {
                Console.WriteLine("QQQQ"); 
                return;
            }
        }
    }
}