using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL
{
    public class HoaDonYeuCauDAL
    {

        public bool ThemHoaDon(string MaHoaDon, string MaNhanVien, string MaPhuTung, string MaSuaChua,
    DateTime NgayIn, string GiaiPhap, int SoLuong, decimal TongTien)
        {
            string query = "INSERT INTO HOADON (MaHoaDon, MaNhanVien, MaPhuTung, MaSuaChua, NgayIn, GiaiPhap, SoLuong, TongTien) " +
               "VALUES (@maHd, @maNv, @maPt, @maSc, @ngayIn, @giaiPhap, @soLuong, @tongTien)";


            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
        MaHoaDon,
        MaNhanVien,
        MaPhuTung,
        MaSuaChua,
        NgayIn,
        GiaiPhap,
        SoLuong,
        TongTien
    });

            return result > 0;
        }



        public List<HoaDonYeuCauDTO> GetListHoaDon()
        {
            string query = "select MaHoaDon,MaNhanVien, MaPhuTung ,HoaDon.MaSuaChua,TenKhachHang,MaXe,NgayIn,SoLuong,TongTien,YEUCAUSUACHUA.MaKhachHang " +
                "from HOADON join YEUCAUSUACHUA on HOADON.MaSuaChua = YEUCAUSUACHUA.MaSuaChua " +
                "join KHACHHANG on YEUCAUSUACHUA.MaKhachHang = KHACHHANG.MaKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<HoaDonYeuCauDTO> listYeuCau = new List<HoaDonYeuCauDTO>();
            foreach (DataRow row in data.Rows)
            {
                decimal tongTien = row["TongTien"] != DBNull.Value ? Convert.ToDecimal(row["TongTien"]) : 0;
                HoaDonYeuCauDTO hoaDonYeuCauDTO = new HoaDonYeuCauDTO(
                    row["MaHoaDon"].ToString(),
                    row["MaNhanVien"].ToString(),
                    row["MaPhuTung"].ToString(),
                    row["MaSuaChua"].ToString(),
                    row["TenKhachHang"].ToString(),
                    row["MaXe"].ToString(),
                    DateTime.Parse(row["NgayIn"].ToString()),
                    row["GiaiPhap"].ToString(),
                    int.Parse(row["SoLuong"].ToString()),
                    tongTien,
                    row["MaKhachHAng"].ToString()
                );
                listYeuCau.Add(hoaDonYeuCauDTO);
            }
            return listYeuCau;
        }
    }
}
