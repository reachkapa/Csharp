using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExcelPractice
{
    class Program
    {
        static void Main(string[] args)

        {
            string xlFilePath = @"C:\Users\CLD16766\Automation\TestData.xlsx";
            ExcelApiTest eat = new ExcelApiTest(xlFilePath);
            Console.WriteLine("Row Count for the given sheet --> " + eat.GetRowCount("Testsheet"));

            Console.WriteLine("Column Count for the given sheet --> " + eat.GetColumnCount("Environment"));

            Console.WriteLine("Cell data from the given sheet --> " + eat.GetCellValue("Testsheet",3,2));
            Console.Read();

        }
    }
}
