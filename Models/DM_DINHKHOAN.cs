//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Apax.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_DINHKHOAN
    {
        public int ID_DINHKHOAN { get; set; }
        public string TAIKHOAN { get; set; }
        public string TENDINHKHOAN { get; set; }
        public Nullable<int> THUCHIEN { get; set; }
        public string QUYENNGUOIDUNG { get; set; }
        public Nullable<bool> BQGQ { get; set; }
        public Nullable<bool> BQGQ_TD { get; set; }
        public Nullable<bool> FIFO { get; set; }
        public Nullable<bool> OP_KHO { get; set; }
        public Nullable<bool> OP_LO { get; set; }
        public Nullable<int> ID_CHINHANH { get; set; }
    }
}
