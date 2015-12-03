using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLY_SIEUTHI
{
    public class KetNoiDB
    {
        SqlConnection cn = new SqlConnection();
        static public String getconnect()
        {
            return (@"Data Source=VAIO;Initial Catalog=Bai6_BanHangSieuThi;Integrated Security=True");

        }
    }
}
