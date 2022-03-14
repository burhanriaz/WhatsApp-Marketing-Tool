using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp_Marketing
{
    internal class Handler
    {
        public static List<MyNumbers> myNumbersList=new List<MyNumbers>();
        public static List<MyNumbers> myCountryList = new List<MyNumbers>();
        
        public static void exportContact()
        {
          
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\sheet.xlsx";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.Copy("sheet.xlsx", path);
                Microsoft.Office.Interop.Excel.Application document = new Microsoft.Office.Interop.Excel.Application();
                Workbook book = document.Workbooks.Open(path, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, true, 0, true, 1, 0);
                Worksheet sheet = book.Worksheets[1];
                int row = 2;
                foreach (var item in Handler.myNumbersList)
                {
                    ((Range)sheet.Cells[row, 1]).Value = item.id;
                    ((Range)sheet.Cells[row, 2]).Value = "'" + item.number;
                    row++;
                }
                book.Save();
                book.Close();

                Process.Start(path);
                // MyNumbers.Clear();

        }


        public static System.Data.DataTable importContact(String path)
        {
            System.Data.DataTable dt=new System.Data.DataTable();
            if(!path.EndsWith(".xlsx"))
            {
                return dt;
            }
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Number", typeof(String));

            Microsoft.Office.Interop.Excel.Application document = new Microsoft.Office.Interop.Excel.Application();
            Workbook book = document.Workbooks.Open(path, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, true, 0, true, 1, 0);
            Worksheet sheet = book.Worksheets[1];
            int row = 2;
            while(true)
            {
                String id = Convert.ToString(((Range)sheet.Cells[row, 1]).Value);
                var num = ((Range)sheet.Cells[row, 2]).Value;
                if(id==null)
                {
                    break;
                }
                dt.Rows.Add(Convert.ToInt32(id), Convert.ToString(num));
                row++;
            }
            book.Close();
            return dt;
        }
    }
}
