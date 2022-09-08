using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using xl = Microsoft.Office.Interop.Excel;

namespace CsharpExcelPractice
{
    class ExcelApiTest
    {
        xl.Application xlApp = null;
        xl.Workbooks xlWorkbooks = null;
        xl.Workbook xlWorkbook = null;
        Hashtable sheets;
        public string xlFilePath;
        public ExcelApiTest(string xlFilePath)
        {
            this.xlFilePath = xlFilePath;
        }
        public void OpenExcel()
        {
            xlApp = new xl.Application();
            xlWorkbooks = xlApp.Workbooks;
            xlWorkbook = xlWorkbooks.Open(xlFilePath);
            sheets = new Hashtable();
            int count = 1;
            foreach(xl.Worksheet sheet in xlWorkbook.Sheets)
            {
                sheets[count] = sheet.Name;
                count++;
            }

        }
        public void CloseExcel()
        {
            xlWorkbook.Close(false, xlFilePath, null);
            Marshal.FinalReleaseComObject(xlWorkbook);
            xlWorkbook = null;

            xlWorkbooks.Close();
            Marshal.FinalReleaseComObject(xlWorkbooks);
            xlWorkbooks = null;

            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);
            xlApp = null;
        }

        public int GetRowCount(string sheetName)
        {
            OpenExcel();
            int rowCount = 0;
            int sheetIndex = 0;

            if (sheets.ContainsValue(sheetName))
            {
                foreach (DictionaryEntry sheet in sheets)
                {
                    if (sheet.Value.Equals(sheetName))
                    {
                        sheetIndex = (int)sheet.Key;
                    }
                }
                xl.Worksheet worksheet = xlWorkbook.Worksheets[sheetIndex] as xl.Worksheet;
                xl.Range range = worksheet.UsedRange;
                rowCount = range.Rows.Count;
                Marshal.FinalReleaseComObject(worksheet);
            }
            CloseExcel();
            return rowCount;
        }
        public int GetColumnCount(string sheetName)
        {
            OpenExcel();
            int colCount = 0;
            int sheetIndex = 0;

            if (sheets.ContainsValue(sheetName))
            {
                foreach (DictionaryEntry sheet in sheets)
                {
                    if (sheet.Value.Equals(sheetName))
                    {
                        sheetIndex = (int)sheet.Key;
                    }
                }
                xl.Worksheet worksheet = xlWorkbook.Worksheets[sheetIndex] as xl.Worksheet;
                xl.Range range = worksheet.UsedRange;
                colCount = range.Columns.Count;
                Marshal.FinalReleaseComObject(worksheet);
            }
            CloseExcel();
            return colCount;
        }
        public string GetCellValue(string sheetName, int colNum, int rowNum)
        {
            OpenExcel();
            
            string value = string.Empty;
            int sheetIndex = 0;

            if (sheets.ContainsValue(sheetName))
            {
                foreach (DictionaryEntry sheet in sheets)
                {
                    if (sheet.Value.Equals(sheetName))
                    {
                        sheetIndex = (int)sheet.Key;
                    }
                }
                xl.Worksheet worksheet = null;
                worksheet = xlWorkbook.Worksheets[sheetIndex] as xl.Worksheet;
                xl.Range range = worksheet.UsedRange;
                value = Convert.ToString((range.Cells[rowNum,colNum] as xl.Range).Value2);
                Marshal.FinalReleaseComObject(worksheet);
                worksheet = null;
            }
            CloseExcel();
            return value;
        }
    }
}
