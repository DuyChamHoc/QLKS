//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKSNew
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonThu
    {
        public int ID { get; set; }
        public int IDkhachhang { get; set; }
        public int IDphong { get; set; }
        public int IDbangthuephong { get; set; }
        public string phuongthuctt { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public Nullable<decimal> TienPhong { get; set; }
        public Nullable<decimal> TienDichVu { get; set; }
        public Nullable<decimal> TongTien { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual Phong Phong { get; set; }
    }
}
