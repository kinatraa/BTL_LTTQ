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

            string query = "SELECT COUNT (*) FROM HOADON WHERE MaPhuTung = @maPt ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] {MaPhuTung});

            if(Convert.ToInt32(result) <= 0)
            {
                string query1 = "INSERT INTO HOADON (MaHoaDon, MaNhanVien, MaPhuTung, MaSuaChua, NgayIn, GiaiPhap, SoLuong, TongTien) " +
                    "VALUES ( @maHd , @maNv , @maPt , @maSc , @ngayIn , @giaiPhap , @soLuong , @tongTien )";

                int result1 = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { MaHoaDon, MaNhanVien,
                MaPhuTung,MaSuaChua,NgayIn,GiaiPhap,SoLuong,TongTien});

                return result1 > 0;
            }
            else
            {
                return false;
            }


        }

        public List<HoaDonYeuCauDTO> GetListHoaDon()
        {
            string query = "select MaSuaChua, MaXe,YEUCAUSUACHUA.MaKhachHang,TenKhachHang from " +
                "YEUCAUSUACHUA join KHACHHANG on YEUCAUSUACHUA.MaKhachHang = KHACHHANG.MaKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<HoaDonYeuCauDTO> listYeuCau = new List<HoaDonYeuCauDTO>();
            foreach (DataRow row in data.Rows)
            {
                HoaDonYeuCauDTO hoaDonYeuCauDTO = new HoaDonYeuCauDTO(
                   
                    row["MaSuaChua"].ToString(),
                    row["MaXe"].ToString(),
                    row["MaKhachHAng"].ToString(),
                    row["TenKhachHang"].ToString()
                );
                listYeuCau.Add(hoaDonYeuCauDTO);
            }
            return listYeuCau;
        }
    }
}
