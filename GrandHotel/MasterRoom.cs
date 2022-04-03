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
    public partial class MasterRoom : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();

        string proses;
        string id;
        public MasterRoom()
        {
            InitializeComponent();
        }

        private void txtRoomP_TextChanged(object sender, EventArgs e)
        {

        }

        void Enabledtext()
        {
            txtRNumber.Enabled = true;
            txtRFloor.Enabled = true;
            txtDesc.Enabled = true;
            CBoxRType.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void Disabledtext()
        {
            txtRNumber.Enabled = false;
            txtRFloor.Enabled = false;
            txtDesc.Enabled = false;
            CBoxRType.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        void ClearText()
        {
            txtRNumber.Clear();
            txtRFloor.Clear();
            txtDesc.Clear();
        }
        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Room join RoomType on Room.RoomTypeID = RoomType.ID", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridVMRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridVMRoom.Rows.Add();
                dataGridVMRoom.Rows[n].Cells[0].Value = item["RoomNumber"];
                dataGridVMRoom.Rows[n].Cells[1].Value = item["Name"];
                dataGridVMRoom.Rows[n].Cells[2].Value = item["RoomFloor"];
                dataGridVMRoom.Rows[n].Cells[3].Value = item["Description"];
            }
            conn.Close();
        }

        void ShowwRoomT()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from RoomType", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CBoxRType.DataSource = dt;
            CBoxRType.ValueMember = "ID";
            CBoxRType.DisplayMember = "Name";
            conn.Close();
        }

        private void MasterRoom_Load(object sender, EventArgs e)
        {
            ShowwRoomT();
            dataGridVMRoom.Rows.Clear();
            ShowData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Enabledtext();
            ClearText();
            proses = "input";
            txtRNumber.Focus();
        }

        private void txtRNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtRFloor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
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
            txtRNumber.Focus();

            btnSave.Text = "Delete";
        }

        private void dataGridVMRoom_Click(object sender, EventArgs e)
        {

        }

        private void dataGridVMRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridVMRoom.Rows[e.RowIndex];
            txtRNumber.Text = row.Cells["Rnumber"].Value.ToString();
            txtRFloor.Text = row.Cells["Rfloor"].Value.ToString();
            txtDesc.Text = row.Cells["Desc"].Value.ToString();


            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Room where RoomNumber = '" + txtRNumber.Text + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                id = (string)dr["ID"].ToString();
                CBoxRType.SelectedValue = (string)dr["RoomTypeID"].ToString();
            }
            conn.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
            errorProvider1.Dispose();
            Disabledtext();
            btnSave.Text = "Save";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRNumber.Text))
            {
                errorProvider1.SetError(txtRNumber, "Room Number Tidak Boleh Kosong");
            }
            else if (string.IsNullOrEmpty(txtRFloor.Text))
            {
                errorProvider1.SetError(txtRFloor, "Room Floor Tidak Boleh Kosong");
            }
            else
            {
                errorProvider1.Dispose();

                if (proses == "input")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("insert into Room (RoomTypeID, RoomNumber, RoomFloor, Description) values ('" + CBoxRType.SelectedValue+ "', '" + txtRNumber.Text + "', '" + txtRFloor.Text + "', '" + txtDesc.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Ditambahkan");
                    dataGridVMRoom.Rows.Clear();
                    ShowData();
                    ClearText();
                    Disabledtext();
                    conn.Close();
                }
                else if (proses == "update")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("update Room set RoomTypeID = '"+CBoxRType.SelectedValue+"', RoomNumber = '"+txtRNumber.Text+"', RoomFloor = '"+txtRFloor.Text+"', Description = '"+txtDesc.Text+"' where ID = '"+id+"'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diperbarui");
                    btnSave.Text = "Save";
                    dataGridVMRoom.Rows.Clear();
                    ShowData();
                    ClearText();
                    Disabledtext();
                    conn.Close();
                }
                else if(proses == "delete")
                {
                    if(MessageBox.Show("Yakin menghapus data ini?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SqlConnection conn = koneksi.GetConn();
                        conn.Open();
                        cmd = new SqlCommand("delete from Room where ID = '" + id + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        btnSave.Text = "Save";
                        dataGridVMRoom.Rows.Clear();
                        ShowData();
                        ClearText();
                        Disabledtext();
                        conn.Close();
                    }
                }
            }
        }
    }
}
