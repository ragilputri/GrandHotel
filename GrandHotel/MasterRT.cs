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
    public partial class MasterRT : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();

        string proses;
        string id;
        public MasterRT()
        {
            InitializeComponent();
        }

        void Enabledtext()
        {
            txtName.Enabled = true;
            txtCapacity.Enabled = true;
            txtRoomP.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void Disabledtext()
        {
            txtName.Enabled = false;
            txtCapacity.Enabled = false;
            txtRoomP.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        void ClearText()
        {
            txtName.Clear();
            txtRoomP.Clear();
        }
        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from RoomType", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Name"];
                dataGridView1.Rows[n].Cells[1].Value = item["Capacity"];
                dataGridView1.Rows[n].Cells[2].Value = item["RoomPrice"];
            }
            conn.Close();
        }

        private void MasterRT_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ShowData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Enabledtext();
            ClearText();
            proses = "input";
            txtName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Enabledtext();
            proses = "update";
            btnSave.Text = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Enabledtext();
            proses = "delete";
            btnSave.Text = "Delete";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Disabledtext();
            ClearText();
            errorProvider1.Dispose();
            btnSave.Text = "Save";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Username Tidak Boleh Kosong");
            }
            else if (string.IsNullOrEmpty(txtRoomP.Text))
            {
                errorProvider1.SetError(txtRoomP, "Username Tidak Boleh Kosong");
            }
            else
            {
                errorProvider1.Dispose();

                if (proses == "input")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("insert into RoomType (Name, Capacity, RoomPrice) values ('" + txtName.Text + "', '" + txtCapacity.Text + "', '" + txtRoomP.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Ditambahkan");
                    dataGridView1.Rows.Clear();
                    ShowData();
                    ClearText();
                    Disabledtext();
                    conn.Close();
                }
                else if (proses == "update")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("update RoomType set Name = '" + txtName.Text + "', Capacity = '" + txtCapacity.Text + "', RoomPrice = '" + txtRoomP.Text + "' where ID = '" + id + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diperbarui");
                    btnSave.Text = "Save";
                    dataGridView1.Rows.Clear();
                    ShowData();
                    ClearText();
                    Disabledtext();
                    conn.Close();
                }
                else if (proses == "delete")
                {
                    if (MessageBox.Show("Yakin menghapus data ini?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SqlConnection conn = koneksi.GetConn();
                        conn.Open();
                        cmd = new SqlCommand("delete from RoomType where ID = '" + id + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        btnSave.Text = "Save";
                        dataGridView1.Rows.Clear();
                        ShowData();
                        ClearText();
                        Disabledtext();
                        conn.Close();
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txtName.Text = row.Cells["name"].Value.ToString();
            txtRoomP.Text = row.Cells["roomprice"].Value.ToString();
            txtCapacity.Value = decimal.Parse(row.Cells["capacity"].Value.ToString());

            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from RoomType where Name = '" + txtName.Text + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                id = (string)dr["ID"].ToString();
            }
            conn.Close();
        }

        private void txtRoomP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }
    }
}
