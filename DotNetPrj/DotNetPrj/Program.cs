using System;

namespace DotNetPrj
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool bval = (new Random().Next(1, 2) == 0 ? false : true);
            if (bval) return;
            else
            {
                Console.WriteLine("hz"); 
                return;
            }
        }
    }
}