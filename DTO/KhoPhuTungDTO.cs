using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoPhuTungDTO
    {
        public string MaHoaDon {  get; set; }
        public string MaPhuTung { get; set; }
        public string TenPhuTung { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
    }
}
