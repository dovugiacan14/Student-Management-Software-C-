//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement.Subject
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_BANGDIEMMON
    {
        public int MALHKT { get; set; }
        public int MABDM { get; set; }
        public Nullable<double> DIEM { get; set; }
    
        public virtual BANGDIEMMON BANGDIEMMON { get; set; }
        public virtual BANGDIEMMON BANGDIEMMON1 { get; set; }
        public virtual LOAIHINHKIEMTRA LOAIHINHKIEMTRA { get; set; }
    }
}
