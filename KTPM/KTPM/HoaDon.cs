//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KTPM
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public string MaPhong { get; set; }
        public string MaDV { get; set; }
        public string NgayLap { get; set; }
    
        public virtual DichVu DichVu { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual Phong Phong { get; set; }
    }
}