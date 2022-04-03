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
using System.Text.RegularExpressions;

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
            cmd = new SqlCommand("select * from Employee join Job on Employee.JobID = Job.ID", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach(DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Username"];
                dataGridView1.Rows[n].Cells[1].Value = item["Name"];
                dataGridView1.Rows[n].Cells[2].Value = item["Email"];
                dataGridView1.Rows[n].Cells[3].Value = item["Address"];
                dataGridView1.Rows[n].Cells[4].Value = item["DateOfBirth"];

                if(item["JobID"].ToString() == "1")
                {

                    dataGridView1.Rows[n].Cells[5].Value = "Front Office";
                }
                else if (item["JobID"].ToString() == "4")
                {

                    dataGridView1.Rows[n].Cells[5].Value = "Housekeeper";
                }
                else if (item["JobID"].ToString() == "6")
                {

                    dataGridView1.Rows[n].Cells[5].Value = "Housekeeper Supervisor";
                }
                else if (item["JobID"].ToString() == "7")
                {

                    dataGridView1.Rows[n].Cells[5].Value = "Admin";
                }
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
            dataGridView1.Rows.Clear();
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EnabledText();
            DisabledBtn();
            ClearText();
            txtUsername.Focus();
            proses = "input";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnabledText();
            DisabledBtn();
            txtUsername.Focus();
            proses = "update";

            btnCPass.Visible = true;
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
            if(txtPass.Text != txtConfirPass.Text)
            {
                errorProvider1.SetError(txtConfirPass, "Konfirmnasi Password Tidak Sesuai!");
            }
            else
            {
                errorProvider1.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
            DisabledText();
            EnabledBtn();
            errorProvider1.Dispose();
            btnSave.Text = "Save";
            btnCPass.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                
                errorProvider1.SetError(txtUsername, "Username Tidak Boleh Kosong");
                //LUsername.Visible = true;
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Name Tidak Boleh Kosong");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email Tidak Boleh Kosong");
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Alamat Tidak Boleh Kosong");
            }
            else
            {
                errorProvider1.Dispose();

                if (proses == "input")
                {
                    const int minimal = 8;
                    string password = txtPass.Text;

                    var hasNumber = new Regex(@"[0-9]+");
                    var hasUpperChar = new Regex(@"[A-Z]+");
                    var hasMiniMaxChars = new Regex(@".{8,15}");
                    var hasLowerChar = new Regex(@"[a-z]+");
                    var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");


                    if (password.Length < minimal)
                    {
                        errorProvider1.SetError(txtPass, "Password Minimal 8 Karakter");
                    }
                    else if (string.IsNullOrEmpty(txtPass.Text))
                    {
                        errorProvider1.SetError(txtPass, "Password Tidak Boleh Kosong");
                    }
                    else if (string.IsNullOrEmpty(txtConfirPass.Text))
                    {
                        errorProvider1.SetError(txtConfirPass, "Konfirmasi Password Tidak Boleh Kosong");
                    }

                    else if (!hasLowerChar.IsMatch(password))
                    {
                        errorProvider1.SetError(txtPass, "Password Harus Mengandung Setidaknya 1 Huruf Kecil");
                    }
                    else if (!hasUpperChar.IsMatch(password))
                    {
                        errorProvider1.SetError(txtPass, "Password Harus Mengandung Setidaknya 1 Huruf Besar");
                    }
                    else if (!hasMiniMaxChars.IsMatch(password))
                    {
                        errorProvider1.SetError(txtPass, "Password harus lebih dari 8 dan kurang dari 15 karakter");
                    }
                    else if (!hasNumber.IsMatch(password))
                    {
                        errorProvider1.SetError(txtPass, "Password Harus Mengandung Setidaknya 1 Nilai Numerik");
                    }
                    else if (!hasSymbols.IsMatch(password))
                    {
                        errorProvider1.SetError(txtPass, "Password Harus Mengandung Setidaknya 1 Karakter");
                    }

                    else if (txtPass.Text != txtConfirPass.Text)
                    {
                        errorProvider1.SetError(txtConfirPass, "Konfirmasi Password Harus Sesuai");
                    }
                    else
                    {
                        SqlConnection conn = koneksi.GetConn();
                        conn.Open();
                        cmd = new SqlCommand("insert into Employee (Username, Password, Name, Email, Address, DateOfBirth, JobID) values ('" + txtUsername.Text + "', '" + Hashing.EncryptSHA256(txtPass.Text) + "', '" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtAddress.Text + "', '" + dateOfBirth.Value.ToString("yyyy-MM-dd") + "', '" + CBoxJob.SelectedValue.ToString() + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Ditambahkan");
                        dataGridView1.Rows.Clear();
                        ShowData();
                        ClearText();
                        DisabledText();
                        EnabledBtn();
                        conn.Close();
                    }
                    
                }
                else if (proses == "update")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("update Employee set Username = '" + txtUsername.Text + "', Name = '" + txtName.Text + "', Email = '" + txtEmail.Text + "', Address  = '" + txtAddress.Text + "', DateOfBirth = '" + dateOfBirth.Value.ToString("yyyy-MM-dd") + "', JobID = '" + CBoxJob.SelectedValue.ToString() + "' where ID = '" + id + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diperbarui");
                    btnSave.Text = "Save";
                    btnCPass.Visible = false;
                    dataGridView1.Rows.Clear();
                    ShowData();
                    ClearText();
                    DisabledText();
                    EnabledBtn();
                    conn.Close();
                }
                else if (proses == "delete")
                {
                    if (MessageBox.Show("Yakin ingin menghapus data ini?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        SqlConnection conn = koneksi.GetConn();
                        conn.Open();
                        cmd = new SqlCommand("delete from Employee where ID = '" + id + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        btnSave.Text = "Save";
                        dataGridView1.Rows.Clear();
                        ShowData();
                        ClearText();
                        DisabledText();
                        EnabledBtn();
                        conn.Close();
                    }
                }
            }

        }


        private void btnCPass_Click(object sender, EventArgs e)
        {
            const int minimal = 8;
            string password = txtPass.Text;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");


            if (password.Length < minimal)
            {
                errorProvider1.SetError(txtPass, "Password Minimal 8 Karakter");
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Password Tidak Boleh Kosong");
            }
            else if (string.IsNullOrEmpty(txtConfirPass.Text))
            {
                errorProvider1.SetError(txtConfirPass, "Konfirmasi Password Tidak Boleh Kosong");
            }

            else if (!hasLowerChar.IsMatch(password))
            {
                errorProvider1.SetError(txtPass, "Password Harus Mengandung Setidaknya 1 Huruf Kecil");
            }
            else if (!hasUpperChar.IsMatch(password))
            {
                errorProvider1.SetError(txtPass, "Password Harus Mengandung Setidaknya 1 Huruf Besar");
            }
            else if (!hasMiniMaxChars.IsMatch(password))
            {
                errorProvider1.SetError(txtPass, "Password harus lebih dari 8 dan kurang dari 15 karakter");
            }
            else if (!hasNumber.IsMatch(password))
            {
                errorProvider1.SetError(txtPass, "Password Harus Mengandung Setidaknya 1 Nilai Numerik");
            }
            else if (!hasSymbols.IsMatch(password))
            {
                errorProvider1.SetError(txtPass, "Password Harus Mengandung Setidaknya 1 Karakter");
            }

            else if (txtPass.Text != txtConfirPass.Text)
            {
                errorProvider1.SetError(txtConfirPass, "Konfirmasi Password Harus Sesuai");
            }
            else
            {
                if (MessageBox.Show("Yakin ingin mengubah password?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("update Employee set Password = '" + Hashing.EncryptSHA256(txtConfirPass.Text) + "' where ID = '" + id + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Berhasil Diubah");
                    txtPass.Clear();
                    txtConfirPass.Clear();
                    dataGridView1.Rows.Clear();
                    ShowData();
                    conn.Close();
                }
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txtUsername.Text = row.Cells["username"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            txtAddress.Text = row.Cells["address"].Value.ToString();
            dateOfBirth.Text = row.Cells["birthofbirth"].Value.ToString();

            if (row.Cells["job"].Value.Equals("Front Office"))
            {
                CBoxJob.SelectedValue = "1";
            }
            else if (row.Cells["job"].Value.Equals("Housekeeper"))
            {
                CBoxJob.SelectedValue = "4";
            }
            else if (row.Cells["job"].Value.Equals("Housekeeper Supervisor"))
            {
                CBoxJob.SelectedValue = "6";
            }
            else if (row.Cells["job"].Value.Equals("Admin"))
            {
                CBoxJob.SelectedValue = "7";
            }

            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Employee where Username = '" + txtUsername.Text + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {

                id = (string)dr["ID"].ToString();
            }
            conn.Close();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
