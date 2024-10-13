using System.Collections.Generic;
using DTO;
using DAL;

namespace BLL
{
    public class XeMayBLL
    {
        private XeMayDAL _xeMayDAL;

        public XeMayBLL()
        {
            _xeMayDAL = new XeMayDAL();
        }

        public bool CheckDuplication(string maXe, string currentMaXe = null)
        {
            return _xeMayDAL.CheckDuplication(maXe, currentMaXe);
        }

        public void ThemXeMay(XeMayDTO xeMay)
        {
            _xeMayDAL.ThemXeMay(xeMay);
        }

        public void SuaXeMay(XeMayDTO xeMay)
        {
            _xeMayDAL.SuaXeMay(xeMay);
        }

        public void XoaXeMay(string maXe)
        {
            _xeMayDAL.XoaXeMay(maXe);
        }
        public List<XeMayDTO> TimXeMayTheoTen(string ten)
        {
            return _xeMayDAL.TimXeMayTheoTen(ten);
        }
        public List<XeMayDTO> LayDanhSachXeMay()
        {
            return _xeMayDAL.LayDanhSachXeMay();
        }
    }
}