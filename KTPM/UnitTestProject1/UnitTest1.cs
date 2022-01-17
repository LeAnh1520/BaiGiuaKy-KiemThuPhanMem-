using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTPM;
using KTPM.BLL;
using KTPM.DAL;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        BLL_TaiKhoan bTaiKhoan;
        FormDangKy f;
        [TestMethod]
        public void Test_DangKy_Success()
        {
            bTaiKhoan = new BLL_TaiKhoan();
            Assert.AreEqual(10, bTaiKhoan.LoadTK().Count);

            NhanVien tk = new NhanVien();
            tk.MaNV = "NV011";
            tk.TenNV = "Nguyen Van A";
            tk.NgaySinh = "12/21/1998";
            tk.GioiTinh = "Nam";
            tk.DiaChi = "Lam Dong";
            tk.SoDienThoai = "037890";
            tk.Gmail = "vana@gmail.com";
            tk.MatKhau = "vana2022";
            bTaiKhoan.ThemTK(tk);
            Assert.AreEqual(11, bTaiKhoan.LoadTK().Count);
        }
    }
}
