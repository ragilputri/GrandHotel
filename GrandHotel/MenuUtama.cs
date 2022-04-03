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
    public partial class MenuUtama : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();

        public static MenuUtama menu;
        string ide;

        public MenuUtama()
        {
            InitializeComponent();

        }


        public MenuUtama(string DataUser, string EmployeeID)
            : this()
        {
            ide = EmployeeID.ToString();
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Job where ID = '" + DataUser + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                LRole.Text = (string)dr["Name"];
                if ((string)dr["Name"] == "Front Office")
                {
                    navFrontOffice.Visible = true;
                    navHousekeeper.Visible = false;
                    navSupervisor.Visible = false;
                    navAdmin.Visible = false;
                }
                else if ((string)dr["Name"] == "Housekeeper")
                {
                    navFrontOffice.Visible = false;
                    navHousekeeper.Visible = true;
                    navSupervisor.Visible = false;
                    navAdmin.Visible = false;
                }
                else if ((string)dr["Name"] == "Housekeeper Supervisor")
                {
                    navFrontOffice.Visible = false;
                    navHousekeeper.Visible = false;
                    navSupervisor.Visible = true;
                    navAdmin.Visible = false;
                }
                else if ((string)dr["Name"] == "Admin")
                {
                    navFrontOffice.Visible = false;
                    navHousekeeper.Visible = false;
                    navSupervisor.Visible = false;
                    navAdmin.Visible = true;
                }

            }
            else
            {
                MessageBox.Show("Akun Tidak Terdaftar");
            }
            conn.Close();

            

        }


        private void MenuUtama_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNavE_Click(object sender, EventArgs e)
        {
            MasterEmployee masterEmployee = new MasterEmployee();
            masterEmployee.ShowDialog();
        }

        private void btnNavCR_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Employee where ID = '" + ide + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                string EmployeeName = (string)dr["Name"];
                string IDEmployee = dr["ID"].ToString();
                CleaningRoom cleaningRoom = new CleaningRoom(IDEmployee, EmployeeName);
                cleaningRoom.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tidak ada data employee");
            }
            conn.Close();
        }

        private void btnNavAHS_Click(object sender, EventArgs e)
        {
            AddHousekeepingS addHousekeepingS = new AddHousekeepingS();
            addHousekeepingS.ShowDialog();
        }

        private void btnNavR_Click(object sender, EventArgs e)
        {
            string EmployeeID;
            EmployeeID = ide;
            Reservation reservation = new Reservation(EmployeeID);
            reservation.ShowDialog();
        }

        private void btnNavCI_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn();
            checkIn.ShowDialog();
        }

        private void btnNavRAI_Click(object sender, EventArgs e)
        {
            RequestAI requestAI = new RequestAI();
            requestAI.ShowDialog();
        }

        private void btnNavCO_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            checkOut.ShowDialog();
        }

        private void btnNavMasterRT_Click(object sender, EventArgs e)
        {
            MasterRT masterRT = new MasterRT();
            masterRT.ShowDialog();
        }

        private void btnNavMasterR_Click(object sender, EventArgs e)
        {
            MasterRoom masterRoom = new MasterRoom();
            masterRoom.ShowDialog();
        }

        private void btnNavMasterI_Click(object sender, EventArgs e)
        {
            MasterItem masterItem = new MasterItem();
            masterItem.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }
    }
}
