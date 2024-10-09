using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class KhoPhuTungDAL
    {
        public List<KhoPhuTungDTO> LayDanhSachPhuTung()
        {
            string query = "SELECT * FROM PhuTung";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            List<KhoPhuTungDTO> dsPhuTung = new List<KhoPhuTungDTO>();
            foreach (DataRow row in dataTable.Rows) 
            {
                KhoPhuTungDTO phuTung = new KhoPhuTungDTO
                {
                    MaPhuTung = row["MaPhuTung"].ToString(),
                    TenPhuTung = row["TenPhuTung"].ToString(),
                    SoLuong = int.Parse(row["SoLuong"].ToString()),
                    DonGiaNhap = decimal.Parse(row["DonGiaNhap"].ToString()),
                    DonGiaBan = decimal.Parse(row["DonGiaBan"].ToString())
                };
                dsPhuTung.Add(phuTung);
            }

            return dsPhuTung;
        }
    }
}
