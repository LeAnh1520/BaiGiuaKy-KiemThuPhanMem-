using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPM.DAL
{
    public class DAL_TaiKhoan
    {
        KhachSanEntities db = new KhachSanEntities();
        public bool kiemTraTKTonTai(String tk)
        {
            bool kq = false;
            NhanVien t = db.NhanViens.FirstOrDefault(s => s.Gmail == tk);
            if (t != null)
                kq = true;
            return kq;
        }
        public bool kiemTraDN(String tk, String mk)
        {
            bool kq = false;
            NhanVien t = db.NhanViens.FirstOrDefault(s => s.Gmail == tk && s.MatKhau == mk);
            if (t != null)
                kq = true;
            return kq;
        }
        public void ThemTK(NhanVien tk)
        {
            db.NhanViens.Add(tk);
            db.SaveChanges();
        }
        public bool KiemTraDinhDangMatKhau(string mk)
        {
            if (mk.Length > 6)
            {
                return true;
            }
            return false;
        }
        public List<NhanVien> LoadTK()
        {
            return db.NhanViens.ToList();
        }
    }
}
