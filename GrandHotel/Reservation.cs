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
    public partial class Reservation : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();

        public static Reservation reservation;

        string proses;
        string IDRoom;
        string IDCustomer;
        string IDEmployee;
        string TRoomPrice;
        public Reservation()
        {
            InitializeComponent();
        }

        public Reservation(string EmployeeID)
            : this()
        {
            IDEmployee = EmployeeID;
        }
        void ShowRoomType()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from RoomType", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CBRoomType.DataSource = dt;
            CBRoomType.DisplayMember = "Name";
            CBRoomType.ValueMember = "ID";
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

        void ShowAvaibleRoom()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * from Room where (ID not in (select RoomID from ReservationRoom where (StartDateTime >= CONVERT(DATETIME, '"+DateTime.Now.ToString("yyyy-MM-dd")+ "')) AND (StartDateTime <= DATEADD(day, DurationNights, CONVERT(DATETIME, '"+DateTime.Now.ToString("yyyy-MM-dd")+"'))))) AND RoomTypeID = '"+CBRoomType.SelectedValue+"'", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridAvaibleR.Rows.Clear();
            dataGridAvaibleR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridAvaibleR.Rows.Add();
                dataGridAvaibleR.Rows[n].Cells[0].Value = item["RoomNumber"];
                dataGridAvaibleR.Rows[n].Cells[1].Value = item["RoomFloor"];
                dataGridAvaibleR.Rows[n].Cells[2].Value = item["Description"];
            }
            conn.Close();

        }

        void ShowCustomer()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Customer order by Name asc", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridCustomer.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridCustomer.Rows.Add();
                dataGridCustomer.Rows[n].Cells[1].Value = item["Name"];
                dataGridCustomer.Rows[n].Cells[2].Value = item["Email"];
                dataGridCustomer.Rows[n].Cells[3].Value = item["Gender"];
                dataGridCustomer.Rows[n].Cells[4].Value = item["PhoneNumber"];
                dataGridCustomer.Rows[n].Cells[5].Value = item["Age"];
            }
            conn.Close();
        }

        void TotalAllPrice()
        {
            try
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                int TotalAll;

                //Total Item
                int totalItem = 0;
                for(int i = 0; i<dataGridRequestAI.Rows.Count; i++)
                {
                    totalItem += Convert.ToInt32(dataGridRequestAI.Rows[i].Cells[2].Value);
                }

                //Total Room
                int totalRoomPrice;
                cmd = new SqlCommand("select * from RoomType where ID = '" + CBRoomType.SelectedValue + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    totalRoomPrice = (Convert.ToInt32(dr["RoomPrice"]) * Convert.ToInt32(dataGridVSRoom.Rows.Count)) * Convert.ToInt32(txtNumber.Text);

                    TotalAll = totalItem + totalRoomPrice;
                    LTotal.Text = TotalAll.ToString();
                    TRoomPrice = totalRoomPrice.ToString();
                }
                else
                {
                    LTotal.Text = "Rp. 0";
                }
                conn.Close();

            }
            catch
            {
                LTotal.Text = "Rp. 0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TotalAllPrice();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridAvaibleR.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for(int i =0; i<rowData.Length; i++)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                this.dataGridVSRoom.Rows.Add(rowData);
                this.dataGridAvaibleR.Rows.RemoveAt(dataGridAvaibleR.CurrentCell.RowIndex);
                TotalAllPrice();
            }

        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            ShowRoomType();
            ShowItem();
            ShowCustomer();
            TotalAllPrice();
            dataGridRequestAI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RBSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (RBSearch.Checked)
            {
                dataGridCustomer.Visible = true;
                txtSearch.Enabled = true;
            }
            else
            {
                dataGridCustomer.Visible = false;
                txtSearch.Enabled = false;
            }
        }

        private void RBAddNew_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAddNew.Checked)
            {
                panelAddCustomerData.Visible = true;
            }
            else
            {
                panelAddCustomerData.Visible = false;
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void CBRoomType_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CBRoomType_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void CBRoomType_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridAvaibleR.Rows.Clear();
            ShowAvaibleRoom();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridVSRoom.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; i++)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                this.dataGridAvaibleR.Rows.Add(rowData);
                this.dataGridVSRoom.Rows.RemoveAt(dataGridVSRoom.CurrentCell.RowIndex);
                TotalAllPrice();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                ShowCustomer();
            }
            else
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                cmd = new SqlCommand("select * from Customer where Name like '" + txtSearch.Text + "' ", conn);
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridCustomer.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridCustomer.Rows.Add();
                    dataGridCustomer.Rows[n].Cells[1].Value = item["Name"];
                    dataGridCustomer.Rows[n].Cells[2].Value = item["Email"];
                    dataGridCustomer.Rows[n].Cells[3].Value = item["Gender"];
                    dataGridCustomer.Rows[n].Cells[4].Value = item["PhoneNumber"];
                    dataGridCustomer.Rows[n].Cells[5].Value = item["Age"];
                }
                conn.Close();
            }
            
        }

        private void dataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Loop and uncheck all other CheckBoxes.
                foreach (DataGridViewRow row in dataGridCustomer.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        
                        SqlConnection conn = koneksi.GetConn();
                        conn.Open();
                        cmd = new SqlCommand("select ID from Customer where Name = '" + row.Cells[1].Value.ToString() + "'", conn);
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            row.Cells[0].Value = !Convert.ToBoolean(row.Cells[0].EditedFormattedValue);
                            IDCustomer = (string)dr["ID"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan");
                        }
                        conn.Close();
                    }
                    else
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
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
                    int no = dataGridRequestAI.Rows.Count;
                    for (int i = 0; i < dataGridRequestAI.Rows.Count; i++)
                    {
                        if (dataGridRequestAI.Rows[i].Cells[0].Value.ToString() == (string)dr["Name"] && dataGridRequestAI.Rows[i].Cells[1].Value.ToString() == numericQty.Value.ToString())
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        errorProvider1.Dispose();

                        int hasil = Convert.ToInt32(dr["RequestPrice"]) * Convert.ToInt32(numericQty.Value);
                        dataGridRequestAI.Rows.Add((string)dr["name"], numericQty.Value, hasil.ToString());
                        TotalAllPrice();
                    }
                    else
                    {
                        errorProvider1.SetError(numericQty, "Data "+(string)dr["Name"]+" dengan qty "+numericQty.Value.ToString()+" sudah dimasukan");
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

        private void dataGridRequestAI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridRequestAI.Rows.RemoveAt(dataGridRequestAI.CurrentCell.RowIndex);
            TotalAllPrice();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(txtNumber.Text == "0")
            {
                errorProvider1.SetError(txtNumber, "Number tidak boleh 0");
            }
            else if(dataGridVSRoom.Rows.Count == 0)
            {
                errorProvider1.SetError(dataGridVSRoom, "Setidaknya 1 data room terpilih");
            }
            else if (dataGridRequestAI.Rows.Count == 0)
            {
                errorProvider1.SetError(dataGridRequestAI, "Setidaknya 1 data item terpilih");
            }
            else
            {
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var Charsarr = new char[6];
                var random = new Random();

                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);

                errorProvider1.Dispose();
                if(MessageBox.Show("Yakin ingin submit data reservasi?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("insert into Reservation (DateTime, EmployeeID, CustomerID, Code) values ('"+this.dateTimeStart.Value.ToString("yyyy-MM-dd")+"','"+ IDEmployee+"', '"+ IDCustomer+ "', '"+resultString.ToString()+"') ", conn);
                    cmd.ExecuteNonQuery();
                    SqlCommand IDR = new SqlCommand("select top 1 * from Reservation order by ID desc;", conn);
                    dr = IDR.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        string ReservationID = dr["ID"].ToString();

                        for (int i=0; i<dataGridVSRoom.Rows.Count; i++)
                        {
                            cmd = new SqlCommand("select ID from Room where RoomNumber = '"+dataGridVSRoom.Rows[i].Cells[0].Value+"'", conn);
                            dr = cmd.ExecuteReader();
                            dr.Read();
                            if (dr.HasRows)
                            {
                                cmd = new SqlCommand("insert into ReservationRoom (ReservationID, RoomID, StartDateTime, DurationNights, RoomPrice) values ('" + ReservationID + "', '"+dr["ID"].ToString()+"' ,'" + this.dateTimeStart.Value.ToString("yyyy-MM-dd") + "', '" + txtNumber.Text + "', '" + TRoomPrice + "')", conn);
                                cmd.ExecuteNonQuery();

                                SqlCommand IDReservationRoom = new SqlCommand("select top 1 * from ReservationRoom order by ID desc", conn);
                                dr = IDReservationRoom.ExecuteReader();
                                dr.Read();
                                if (dr.HasRows)
                                {
                                    string IDResRoom = dr["ID"].ToString();
                                    for (int n = 0; n < dataGridRequestAI.Rows.Count; n++)
                                    {
                                        SqlCommand IDitem = new SqlCommand("select ID from Item where Name = '" + dataGridRequestAI.Rows[n].Cells[0].Value.ToString() + "'", conn);
                                        dr = IDitem.ExecuteReader();
                                        dr.Read();
                                        if (dr.HasRows)
                                        {
                                            cmd = new SqlCommand("insert into ReservationRequestItem (ReservationRoomID, ItemID, Qty, TotalPrice) values ('" + IDResRoom + "', '"+dr["ID"].ToString()+"', '"+dataGridRequestAI.Rows[n].Cells[1].Value+"', '"+LTotal.Text+"') ", conn);
                                            cmd.ExecuteNonQuery();
                                        }
                                        
                                    }
                                }
                            }
                        }
                        
                    }
                    MessageBox.Show("Booking Code " + resultString.ToString() + "" , "Information Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumber.Clear();
                    txtPhone.Clear();
                    txtName.Clear();
                    dataGridVSRoom.Rows.Clear();
                    dataGridRequestAI.Rows.Clear();
                    conn.Close();
                }
            }
        }

        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
