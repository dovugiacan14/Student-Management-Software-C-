using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagement.Class
{
    public class ClassInfoDTO
    {
        public string HO { get; set; }
        public string TEN { get; set;}
        public string GIOITINH { get; set;}
        public DateTime NGSINH { get; set;}
        public string DIACHI { get; set;}
        public string TENLOP { get; set;}

        public ClassInfoDTO(string ho, string ten, string gioitinh, DateTime ngsinh, string diachi, string tenlop)
        {
            this.HO = ho;
            this.TEN = ten;
            this.GIOITINH = gioitinh;
            this.NGSINH = ngsinh;
            this.DIACHI = diachi;
            this.TENLOP = tenlop;
        }
        public ClassInfoDTO(DataRow row)
        {
            this.HO = row["ho"].ToString();
            this.TEN = row["ten"].ToString();
            this.GIOITINH = row["gioitinh"].ToString();
            this.NGSINH = (DateTime)row["ngsinh"];
            this.DIACHI = row["diachi"].ToString();
            // this.TENLOP = row["tenlop"].ToString();
            this.TENLOP = row["tenlop"].ToString();
        }


    }
}
