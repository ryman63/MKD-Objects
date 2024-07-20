using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace MDKObjects
{
    public class ExcelFile : IDisposable
    {
        public Excel.Application _excel;
        private Excel.Workbook _workbook;
        private string _filePath;
        public ExcelFile() 
        {
            _excel = new Excel.Application();
        }

        public void Copy(Excel.Worksheet source)
        {
            source.Copy(Before: _workbook.Worksheets[1]);
        }

        public bool Open(string filePath)
        {
            try
            {
                if(File.Exists(filePath))
                {
                    _workbook = _excel.Workbooks.Open(filePath);
                }
                else
                {
                    _workbook = _excel.Workbooks.Add();
                    _filePath = filePath;
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool Set(string column, int row, object data)
        {
            try
            {
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column] = data;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public void Save()
        {
            if (!string.IsNullOrEmpty(_filePath))
            {
                _workbook.SaveAs(Filename: _filePath);
                _filePath = null;
            }
            else
            {
                _workbook.Save();
            }
            _filePath = string.Empty;
        }

        public void Dispose()
        {
            try
            {
                _workbook.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Excel.Worksheet GetWorkSheet()
        {
            return _workbook.Worksheets[1];
        }
    }
}
