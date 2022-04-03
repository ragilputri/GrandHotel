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
    public partial class CheckOut : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();

        public CheckOut()
        {
            InitializeComponent();
        }

        void ShowRoom()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select ReservationRoom.ID, Room.RoomNumber from Room join ReservationRoom on Room.ID = ReservationRoom.RoomID where StartDateTime = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and StartDateTime < DATEADD(day, DurationNights, '" + DateTime.Now.ToString("yyyy-MM-dd") + "') and CheckOutDateTime is null", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CBRoomNumber.DataSource = dt;
            CBRoomNumber.ValueMember = "ID";
            CBRoomNumber.DisplayMember = "RoomNumber";
            conn.Close();
        }

        void ShowItem()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Item", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CBItem.DataSource = dt;
            CBItem.ValueMember = "ID";
            CBItem.DisplayMember = "Name";
            conn.Close();
        }

        void ShowItemStatus()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from ItemStatus", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CBItemStatus.DataSource = dt;
            CBItemStatus.ValueMember = "ID";
            CBItemStatus.DisplayMember = "Name";
            conn.Close();
        }

        void TotalAllPrice()
        {
            try
            {
                int jumlah = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    jumlah += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                }
                LTotal.Text = jumlah.ToString();
            }
            catch
            {
                LTotal.Text = "Rp. 0";
            }


        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            ShowRoom();
            ShowItem();
            ShowItemStatus();
            TotalAllPrice();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (numericQty.Value.ToString() != "0")
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                bool flag = true;
                cmd = new SqlCommand("select * from Item where ID = '" + CBItem.SelectedValue + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    errorProvider1.Dispose();
                    int no = dataGridView1.Rows.Count;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == (string)dr["Name"] && dataGridView1.Rows[i].Cells[1].Value.ToString() == numericQty.Value.ToString())
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        errorProvider1.Dispose();

                        int hasil = Convert.ToInt32(dr["RequestPrice"]) * Convert.ToInt32(numericQty.Value);
                        dataGridView1.Rows.Add((string)dr["name"], numericQty.Value, hasil.ToString());
                        TotalAllPrice();
                    }
                    else
                    {
                        errorProvider1.SetError(numericQty, "Data " + (string)dr["Name"] + " dengan qty " + numericQty.Value.ToString() + " sudah dimasukan");
                    }


                }
                else
                {
                    MessageBox.Show("Data Item Tidak Ditemukan!");
                }
                conn.Close();
            }
            else
            {
                errorProvider1.SetError(numericQty, "Qty tidak boleh 0");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            TotalAllPrice();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                errorProvider1.SetError(dataGridView1, "Setidaknya 1 item terpilih");
            }
            else
            {
                errorProvider1.Dispose();
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    cmd = new SqlCommand("select ID from Item where Name = '" + dataGridView1.Rows[i].Cells[0].Value + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cmd = new SqlCommand("insert into ReservationRequestItem (ReservationRoomID, ItemID, Qty, TotalPrice) values ('" + CBRoomNumber.SelectedValue + "', '" + dr["ID"].ToString() + "', '" + dataGridView1.Rows[i].Cells[1].Value + "', '" + dataGridView1.Rows[i].Cells[2].Value + "') ", conn);
                        cmd.ExecuteNonQuery();
                    }
                }

                cmd = new SqlCommand("update ReservationRoom set CheckOutDateTime = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' where ID = '" + CBRoomNumber.SelectedValue + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil melakukan check out");

                dataGridView1.Rows.Clear();
                LTotal.Text = "Rp. 0";
                conn.Close();

            }
        }
    }
}
