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
    
    public partial class TONGKETMON
    {
        public int MATKM { get; set; }
        public Nullable<int> MAMH { get; set; }
        public Nullable<int> MALOP { get; set; }
        public Nullable<int> MAHK { get; set; }
        public Nullable<int> SOLUONGDAT { get; set; }
        public Nullable<double> TILE { get; set; }
    
        public virtual HOCKY HOCKY { get; set; }
        public virtual LOP LOP { get; set; }
        public virtual MONHOC MONHOC { get; set; }
    }
}