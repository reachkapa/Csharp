using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("working with 3x3 array");
            Printing_matrix pm = new Printing_matrix();
            
            pm.Printing_matrix_Format();
            Console.ReadKey();
        }

    }
}
