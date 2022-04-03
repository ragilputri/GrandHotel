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

namespace HakAkses
{
    public partial class AddHousekeepingS : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();

        string proses;
        string id;

        public AddHousekeepingS()
        {
            InitializeComponent();
        }

        void ShowHousekeeper()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select Employee.ID, Employee.Name from Employee join Job on Employee.JobID = Job.ID where Job.Name = 'Housekeeper'", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CBHousekeeping.DataSource = dt;
            CBHousekeeping.ValueMember = "Name";
            CBHousekeeping.DisplayMember = "Name";
            conn.Close();
        }

        void ShowRoomNumber()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Room", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CBRoomNum.DataSource = dt;
            CBRoomNum.ValueMember = "RoomNumber";
            CBRoomNum.DisplayMember = "RoomNumber";
            conn.Close();
        }

        private void AddHousekeepingS_Load(object sender, EventArgs e)
        {
            ShowHousekeeper();
            ShowRoomNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(dateTimeP.Value, CBHousekeeping.SelectedValue, CBHousekeeping.SelectedValue);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }
    }
}
