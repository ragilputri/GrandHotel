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
    public partial class CheckIn : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();

        string proses;
        string id;

        public CheckIn()
        {
            InitializeComponent();
        }

        void ShowRoomDetails()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from ReservationRoom join Room on ReservationRoom.RoomID = Room.ID join RoomType on Room.RoomTypeID = RoomType.ID join Reservation on ReservationRoom.ReservationID = Reservation.ID where Reservation.Code = '" + txtBookingCode.Text + "'", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = row["RoomNumber"];
                dataGridView1.Rows[n].Cells[1].Value = row["RoomFloor"];
                dataGridView1.Rows[n].Cells[2].Value = row["Name"];
                dataGridView1.Rows[n].Cells[3].Value = row["StartDateTime"];
                dataGridView1.Rows[n].Cells[4].Value = row["DurationNights"];
                dataGridView1.Rows[n].Cells[5].Value = row["RoomPrice"];
            }
            conn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Reservation join Customer on Reservation.CustomerID = Customer.ID join ReservationRoom on Reservation.ID = ReservationRoom.ReservationID where Reservation.Code = '" + txtBookingCode.Text+"'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (dr["CheckInDateTime"] == DBNull.Value)
                {
                    ShowRoomDetails();
                    txtPhone.Text = (string)dr["PhoneNumber"];
                    txtName.Text = (string)dr["Name"];
                    txtEmail.Text = (string)dr["Email"];
                    txtEge.Text = dr["Age"].ToString();
                    txtNik.Text = (string)dr["NIK"];
                    if ((string)dr["Gender"] == "M")
                    {
                        RBMale.Checked = true;
                        RBFemale.Checked = false;
                    }
                    else if ((string)dr["Gender"] == "F")
                    {
                        RBFemale.Checked = true;
                        RBMale.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Sudah Melakukan Check In"
                        + Environment.NewLine
                        + "Name : "+ (string)dr["Name"] +""
                        + Environment.NewLine
                        + "Phone : " + (string)dr["PhoneNumber"] + ""
                        + Environment.NewLine
                        + "Check in : "+(DateTime)dr["CheckInDateTime"]+""
                        + Environment.NewLine
                        + "", "CONFIRM CHECK IN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                

            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }
            conn.Close();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("update ReservationRoom set CheckInDateTime = '"+DateTime.Now.ToString("yyyy-MM-dd")+ "' where ID IN (select ReservationRoom.ID from ReservationRoom join Reservation on ReservationRoom.ReservationID = Reservation.ID where Reservation.Code = '"+txtBookingCode.Text+"')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil melakukan check in");
            conn.Close();
        }
    }
}
