using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Runtime.InteropServices;

namespace HakAkses
{
    public partial class CleaningRoom : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        moduleExcel excelImp = new moduleExcel();

        string Name;
        string ID;
        public CleaningRoom()
        {
            InitializeComponent();
        }

        public CleaningRoom( string IDEmployee, string EmployeeName)
            : this()
        {
            Name = EmployeeName;
            ID = IDEmployee;
        }

        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Room rm left join CleaningRoomDetail crd on rm.ID = crd.RoomID join ReservationRoom rr on rm.ID = rr.RoomID where rr.StartDateTime = CONVERT(datetime, '"+DateTime.Now.ToString("yyyy-MM-dd")+"') and rr.StartDateTime <= DATEADD(DAY, DurationNights, CONVERT(datetime, '"+DateTime.Now.ToString("yyyy-MM-dd")+"'))", conn);
            //cmd = new SqlCommand("select * from Room rm left join CleaningRoomDetail crd on rm.ID = crd.RoomID join ReservationRoom rr on rm.ID = rr.RoomID where (Room.ID in (select RoomID from ReservationRoom where (StartDateTime >= CONVERT(DATETIME, '" + DateTime.Now.ToString("yyyy-MM-dd") + "')) AND (StartDateTime <= DATEADD(day, DurationNights, CONVERT(DATETIME, '" + DateTime.Now.ToString("yyyy-MM-dd") + "')))))", conn);
            //cmd = new SqlCommand("select * from Room rm left join CleaningRoomDetail crd on rm.ID = crd.RoomID join ReservationRoom rr on rm.ID = rr.RoomID (ID in (select RoomID from ReservationRoom where '"+DateTime.Now.ToString("yyyy-MM-dd")+"' between StartDateTime AND (DATEADD(day, DurationNights, CONVERT(DATETIME, '" + DateTime.Now.ToString("yyyy-MM-dd") + "')))))", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewCS.Rows.Clear();
            dataGridViewCS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewCS.Rows.Add();
                dataGridViewCS.Rows[n].Cells[0].Value = item["RoomNumber"];
                dataGridViewCS.Rows[n].Cells[1].Value = item["StartDateTime"];
                dataGridViewCS.Rows[n].Cells[2].Value = item["FinishDateTime"];
                dataGridViewCS.Rows[n].Cells[3].Value = item["Note"];
                dataGridViewCS.Rows[n].Cells[4].Value = item["StatusCleaning"];
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = false;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Cells[1, 1] = "Date : " + DateTime.Now.ToLongDateString();
            worksheet.Cells[2, 1] = "Employee : " + Name;

            //Header
            for (int i = 1; i < dataGridViewCS.Columns.Count + 1; i++)
            {
                worksheet.Cells[4, i] = dataGridViewCS.Columns[i - 1].HeaderText;

            }
            for (int j = 1; j < dataGridViewCSD.Columns.Count + 1; j++)
            {
                worksheet.Cells[4, 5 + j] = dataGridViewCSD.Columns[j - 1].HeaderText;
            }

            //Data
            for (int i = 0; i < dataGridViewCS.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewCS.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = dataGridViewCS.Rows[i].Cells[j].Value.ToString();
                    
                }
            }

            for (int i = 0; i < dataGridViewCSD.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewCSD.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 6] = dataGridViewCSD.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application
            workbook.SaveAs("d:\\"+Name+"_"+DateTime.Now.ToString("ddMMyyyy")+".xls", Type.Missing, Type.Missing, Type.Missing,
            Type.Missing,
            Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application
            app.Quit();
            MessageBox.Show("Excel file created , you can find the file d:\\" + Name + "_" + DateTime.Now.ToString("ddMMyyyy") + ".xls");

        }

        private void CleaningRoom_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;

            openFileDialog1.Filter = "Excel Office |*.xls; *xlsx";
            openFileDialog1.ShowDialog();

            strFileName = openFileDialog1.FileName;

            if(strFileName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strFileName);
                xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                xlRange = xlWorksheet.UsedRange;

                int i = 0;

                for(xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    if(xlRange.Cells[xlRow, 1].Text != "")
                    {
                        i++;
                        dataGridViewCS.Rows.Add(xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text);
                        
                    }
                    if(xlRange.Cells[xlRow, 6].Text != "")
                    {
                        dataGridViewCSD.Rows.Add(xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text);
                    }
                    
                }
                xlWorkbook.Close();
                xlApp.Quit();

            }

        }
    }
}
