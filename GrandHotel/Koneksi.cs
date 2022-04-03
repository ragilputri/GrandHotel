using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HakAkses
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "data source = ASUS; initial catalog = PC_15; integrated security = true; MultipleActiveResultSets=true;";
            return Conn;
        }
    }
}
