using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;
using System.Diagnostics;

namespace excel_sql_app
{
    class ExcelReader
    {
        private Uri path;
        Form1 mainForm;
        private static readonly object lockOBJ = new object ();  
        private static ExcelReader er = null;
        public ExcelReader(Uri path)
        {
            this.path = path;

        }
  
        public HashSet<string> ExecuteDataHash()
        {
           
            HashSet<string> excelDataSet = new HashSet<string>();
            try 
            { 
                var package = new ExcelPackage(new FileInfo(path.OriginalString));
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var worksheet = package.Workbook.Worksheets[0];
                string dataListStr = string.Empty;
                Debug.WriteLine("row range: " + worksheet.Dimension.Rows);
                Debug.WriteLine("Data: ");
               

                for (int i = 1; i <= worksheet.Dimension.Rows; i++)
                {
                    if (worksheet.Cells[i, 1] != null)
                    {
                        string tmp = (string)worksheet.Cells[i, 1].Value;
                        tmp = tmp.Replace("\'", "");
                        excelDataSet.Add("'" + tmp + "'");
                    }
                }
            }


            catch (IOException e)
            {
                excelDataSet = null;
            }
            catch (Exception e)
            {
                excelDataSet = null;
            }
            return excelDataSet;

        }
        
        public StringBuilder ExecuteDataSb(int cell)
        {
            StringBuilder finalSb = null;
            try
            {
                 finalSb = new StringBuilder();
                var package = new ExcelPackage(new FileInfo(path.OriginalString));
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var worksheet = package.Workbook.Worksheets[0];
                string dataListStr = string.Empty;
                Debug.WriteLine("row range: " + worksheet.Dimension.Rows);
                Debug.WriteLine("Data: ");
                StringBuilder tempSb = new StringBuilder();


                for (int i = 1; i <= worksheet.Dimension.Rows; i++)
                {
                    if (worksheet.Cells[i, cell] != null)
                    {
                        string tmp = (string)worksheet.Cells[i, cell].Value;
                        tempSb.Append(tmp);
                        if (tempSb[0] == '\'' || tempSb[0] == '\"')
                        {
                            tempSb.Remove(0, 1);
                        }
                        if (tempSb[tempSb.Length - 1] == '\'' || tempSb[tempSb.Length - 1] == '\"')
                        {
                            tempSb.Remove(tempSb.Length - 1, 1);
                        }
                        if (i < worksheet.Dimension.Rows)
                        {
                            tempSb.Append(",");
                        }
                        finalSb.Append(tempSb);
                        tempSb.Clear();
                    }
                }
            }


            catch (IOException e)
            {
                finalSb = null;
            }
            catch (Exception e)
            {
                finalSb = null;
            }
            return finalSb;
   }
private bool IsReadAble(Uri filePath)
        {
            string ext = Path.GetExtension(filePath.OriginalString);
            if (ext.Equals(".xlsx"))
            {
                return true;
            }

            return false;
        }

        public static ExcelReader getInstance(Uri path)
        {
            lock (lockOBJ)
                {
                    return (er == null) ? er = new ExcelReader(path) : er;
                }
        }
    }
}  
      


