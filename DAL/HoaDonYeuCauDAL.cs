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
        public int LaySLHoaDon()
        {
            string query = "SELECT COUNT(*) FROM HOADON";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }

        public int LaySLYeuCau()
        {
            string query = "SELECT COUNT(*) FROM YEUCAUSUACHUA";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }
        public bool ThemHoaDon(string MaHoaDon, string MaNhanVien, string MaPhuTung, string MaSuaChua,
            DateTime NgayIn, string GiaiPhap, int SoLuong, decimal TongTien)
        {
            string query = "exec addHoaDon @mahoadon , @manhanvien , @maphutung , @masuachua , @ngayin , @giaiphap , @soluong , @tongtien ";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { (object)MaHoaDon ?? DBNull.Value,MaNhanVien,MaPhuTung
                ,MaSuaChua,NgayIn,GiaiPhap,SoLuong,TongTien});
            return result > 0;

        }
        public string GetMaHoaDon(string MaSuaChua)
        {
            string query = "SELECT MaHoaDon FROM HoaDon WHERE MaSuaChua = @masuachua ";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSuaChua });

            if (dataTable.Rows.Count > 0) 
            {
                DataRow row = dataTable.Rows[0]; 
                return row["MaHoaDon"].ToString(); 
            }

            return null; 
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
                    row["MaKhachHang"].ToString(),
                    row["TenKhachHang"].ToString()
                    
                );
                listYeuCau.Add(hoaDonYeuCauDTO);
            }
            return listYeuCau;
        }
    }
}
