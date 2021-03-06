using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace HakAkses
{
    class moduleExcel
    {
        public void ToCsV(DataGridView dgv, DataGridView dgvd, string Date, string name, string filename)
        {
            //========Data from textbox==========//      
            string stOutput = "";
            string stDate = "";
            string sHeaders = "";
            string sHeaders2 = "";
            string stName = "";
            stDate = "Date : "+ Date + "\r";
            stName = "\n Employee : "+ name + "\r\n\n";
            stOutput += stDate;
            stOutput += stName;
            for (int j = 0; j < dgv.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dgv.Columns[j].HeaderText) + "\t";
            for (int k = 0; k<dgvd.Columns.Count; k++)
                sHeaders2 = sHeaders2.ToString() + Convert.ToString(dgvd.Columns[k].HeaderText) + "\t";
            stOutput += sHeaders + sHeaders2 + "\r\n";
            // Export data.

            for (int i = 0; i < dgv.RowCount; i++)
            {
                string stLine = "";
                string stLine2 = "";
                for (int k = 0; k < dgvd.Rows.Count; k++)
                    stLine2 = stLine2.ToString() + Convert.ToString(dgvd.Rows[k].Cells[k].Value) + "\t";
                for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dgv.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + stLine2 + "\r\n";
            }

            


            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private Worksheet FindSheet(Workbook workbook, string sheet_name)
        {
            foreach (Worksheet sheet in workbook.Sheets)
            {
                if (sheet.Name == sheet_name) return sheet;
            }
            return null;
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
