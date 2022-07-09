using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Printing_matrix
    {
        int[,] a = new int [3,3] { {4, 5, 6}, {7,8,9}, {0, 1, 2} };

        public Printing_matrix()
        {
            Console.WriteLine("Printing the each element of the array using 'Foreach'");
            foreach (int i in a)
            {

                Console.WriteLine(i);
            }

        }

        public void Printing_matrix_Format()
        {
            Console.WriteLine("Printing the array in matrix Format");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3;j++)
                Console.Write(a[i,j]+"  ");
                Console.WriteLine();
            }

        }
    }
}
