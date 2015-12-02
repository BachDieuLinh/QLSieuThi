using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SanPham
    {
        KetNoiDB da = new KetNoiDB();
        public DataTable ShowSanPham(string DieuKien)
        {
            string sql = @"SELECT MaSP, TenSP, SoLuong, LoiNhuan, GiaNhap, GiaBan, MoTa, NSX, TenLH
                                                    FROM SANPHAM sp, LOAIHANG lh
                                                    WHERE sp.MaLH = lh.MaLH " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
        public DataTable HienThiSP_LH()
        {
            DataTable dt = new DataTable();
            string str = @"SELECT     dbo.SANPHAM.MaSP, dbo.SANPHAM.TenSP, dbo.LOAIHANG.TenLH, dbo.SANPHAM.NSX, 
                                      dbo.SANPHAM.GiaBan AS GiaBan, dbo.SANPHAM.SoLuong, dbo.SANPHAM.HinhAnh
                            FROM  dbo.SANPHAM INNER JOIN dbo.LOAIHANG ON dbo.SANPHAM.MaLH = dbo.LOAIHANG.MaLH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(dt);
            con.Close();

            return dt;
        }
        public DataTable LaySP(string _MaSP)
        {
            DataTable dt = new DataTable();
            string str = @"SELECT * FROM SANPHAM WHERE MaSP = " + _MaSP;
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LaySPMax()
        {
            DataTable dt = new DataTable();
            string str = @"ShowSPBanChayNhat";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable ThongKeSPN(DateTime _NgayDau, DateTime _NgayCuoi)
        {
            string sql = "ThongKeSPB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaydau", _NgayDau);
            cmd.Parameters.AddWithValue("@ngaycuoi", _NgayCuoi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ThongKeTop10(DateTime _NgayDau, DateTime _NgayCuoi)
        {
            string sql = "ThongKeTop10";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaydau", _NgayDau);
            cmd.Parameters.AddWithValue("@ngaycuoi", _NgayCuoi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
