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
    public partial class MasterEmployee : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        Hashing hasing = new Hashing();

        string proses;
        string id;
        int JobID;

        public MasterEmployee()
        {
            InitializeComponent();
        }
        void ShowJob()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Job", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CBoxJob.DataSource = dt;
            CBoxJob.ValueMember = "ID";
            CBoxJob.DisplayMember = "Name";
            conn.Close();
        }

        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select Employee.Username, Employee.Email, Employee.Address, Employee.DateOfBirth, Job.Name from Employee join Job on Employee.JobID = Job.ID", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach(DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Username"];
                dataGridView1.Rows[n].Cells[1].Value = item["Email"];
                dataGridView1.Rows[n].Cells[2].Value = item["Address"];
                dataGridView1.Rows[n].Cells[3].Value = item["DateOfBirth"];
                dataGridView1.Rows[n].Cells[4].Value = item["Name"];
            }
            conn.Close();
        }
        void EnabledText()
        {
            txtUsername.Enabled = true;
            txtPass.Enabled = true;
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtConfirPass.Enabled = true;
            txtAddress.Enabled = true;
            dateOfBirth.Enabled = true;
            CBoxJob.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        void DisabledText()
        {
            txtUsername.Enabled = false;
            txtPass.Enabled = false;
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtConfirPass.Enabled = false;
            txtAddress.Enabled = false;
            dateOfBirth.Enabled = false;
            CBoxJob.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        void DisabledBtn()
        {
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void EnabledBtn()
        {
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        void ClearText()
        {
            txtUsername.Clear();
            txtPass.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtConfirPass.Clear();
            txtAddress.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void MasterEmployee_Load(object sender, EventArgs e)
        {
            ShowJob();
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EnabledText();
            DisabledBtn();
            txtUsername.Focus();
            proses = "input";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnabledText();
            DisabledBtn();
            txtUsername.Focus();
            proses = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EnabledText();
            DisabledBtn();
            txtUsername.Focus();
            proses = "delete";
            btnSave.Text = "Delete";
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                cmd = new SqlCommand("select * from Employee where Username = '" + txtUsername.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    
                    id = (string)dr["ID"].ToString();
                    JobID = (int)dr["JobID"];
                    CBoxJob.SelectedValue = (string)dr["JobID"].ToString();
                    txtName.Text = (string)dr["Name"];
                    txtEmail.Text = (string)dr["Email"];
                    txtAddress.Text = (string)dr["Address"];
                    dateOfBirth.Value = (DateTime)dr["DateOfBirth"];

                    if(proses == "input")
                    {
                        btnSave.Enabled = false;
                    }
                    else if (proses == "update")
                    {
                        txtPass.Focus();
                        btnCPass.Visible = true;
                    }
                    else if (proses == "delete")
                    {
                        txtPass.Focus();
                    }

                }
                else
                {
                    if (proses == "input")
                    {
                        txtPass.Focus();
                    }
                    else if (proses == "update")
                    {
                        MessageBox.Show("data tidak ditemukan");
                    }
                    else if (proses == "delete")
                    {
                        MessageBox.Show("data tidak ditemukan");
                    }
                }
                conn.Close();
            }
        }

        private void txtConfirPass_TextChanged(object sender, EventArgs e)
        {
            if(txtPass.Text == txtConfirPass.Text)
            {
                LCPass.Visible = false;
            }
            else
            {
                LCPass.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
            DisabledText();
            EnabledBtn();
            btnSave.Text = "Save";
            btnCPass.Visible = false;
            lPass.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(proses == "input")
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                cmd = new SqlCommand("insert into Employee (Username, Password, Name, Email, Address, DateOfBirth, JobID) values ('"+txtUsername.Text+"', '"+Hashing.EncryptSHA256(txtPass.Text)+"', '"+txtName.Text+"', '"+txtEmail.Text+"', '"+txtAddress.Text+"', '"+dateOfBirth.Value.ToString("yyyy-MM-dd")+"', '"+CBoxJob.SelectedValue.ToString()+"')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Ditambahkan");
                ShowData();
                ClearText();
                DisabledText();
                EnabledBtn();
                conn.Close();
            }
            else if (proses == "update")
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                cmd = new SqlCommand("update Employee set Username = '"+txtUsername.Text+"', Name = '"+txtName.Text+"', Email = '"+txtEmail.Text+"', Address  = '"+txtAddress.Text+"', DateOfBirth = '"+dateOfBirth.Value.ToString("yyyy-MM-dd")+"', JobID = '"+CBoxJob.SelectedValue.ToString()+"' where ID = '"+id+"'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diperbarui");
                btnSave.Text = "Save";
                btnCPass.Visible = false;
                ShowData();
                ClearText();
                DisabledText();
                EnabledBtn();
                conn.Close();
            }
            else if (proses == "delete")
            {
                if(MessageBox.Show("Yakin ingin menghapus data ini?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {

                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("delete from Employee where ID = '" + id + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");
                    btnSave.Text = "Save";
                    ShowData();
                    ClearText();
                    DisabledText();
                    EnabledBtn();
                    conn.Close();
                }
            }
        }

        private void btnCPass_Click(object sender, EventArgs e)
        {
            
            if(txtPass.Text == txtConfirPass.Text)
            {
                lPass.Visible = false;
                LCPass.Visible = false;
                if (MessageBox.Show("Yakin ingin mengubah password?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("update Employee set Password = '" + Hashing.EncryptSHA256(txtConfirPass.Text) + "' where ID = '" + id + "'", conn);
                    cmd.ExecuteNonQuery();
                    txtPass.Clear();
                    txtConfirPass.Clear();
                    ShowData();
                    conn.Close();
                }
                    
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                lPass.Visible = true;
            }
            else if (string.IsNullOrEmpty(txtConfirPass.Text))
            {
                LCPass.Visible = true;
            }
            else
            {
                MessageBox.Show("Konfirmasi Password Tidak Setara");
            }
                
            

        }
    }
}
