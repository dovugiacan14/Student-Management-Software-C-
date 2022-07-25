using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagement.Class
{
    public class ClassInfoDAO
    {
        private static ClassInfoDAO instance;
        public static ClassInfoDAO Instance
        {
            get { if (instance == null) instance = new ClassInfoDAO(); return ClassInfoDAO.instance; }
            private set { ClassInfoDAO.instance = value; }
        }
        private ClassInfoDAO() { }
        public List<ClassInfoDTO> getClassbyName(string TENLOP)
        {
            List<ClassInfoDTO> list = new List<ClassInfoDTO>();
            string query =string.Format("select HO,TEN,GIOITINH,NGSINH,DIACHI,TENLOP from HOCSINH HS, QUATRINHHOC QTH, LOP where HS.MAHS = QTH.MAHS and QTH.MALOP = LOP.MALOP and TENLOP = N'{0}'", TENLOP);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                ClassInfoDTO classinfo = new ClassInfoDTO(item);
                list.Add(classinfo);
            }    
            return list;

        }

         
       
    }
}
