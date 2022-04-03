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
    public partial class login : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        Hashing hasing = new Hashing();

        public login()
        {
            InitializeComponent();
        }

        

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Employee where Username = '" + txtUsername.Text + "' and Password = '" +Hashing.EncryptSHA256(txtPass.Text) + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                string DataUser;
                string EmployeeID;
                DataUser = (string)dr["JobID"].ToString();
                EmployeeID = (string)dr["ID"].ToString();
                MenuUtama MU = new MenuUtama(DataUser, EmployeeID);
                this.Hide();
                MU.ShowDialog();

            }
            else
            {
                MessageBox.Show("Akun Tidak Terdaftar");
            }
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
