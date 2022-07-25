using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Student;
using System.Data.SqlClient;

namespace StudentManagement.Subject
{
    public partial class ScoreSubjectForm : Form
    {
        public ScoreSubjectForm()
        {
            InitializeComponent();
        }

        public void ScoreSubjectForm_Load(object sender, EventArgs e)
        {
            using (QLHSEntities1 db = new QLHSEntities1())
            {
                cbBoxLop.DataSource = db.LOPs.ToList();
                cbBoxLop.ValueMember = "MALOP";
                cbBoxLop.DisplayMember = "TENLOP";
                cbBoxMonHoc.DataSource = db.MONHOCs.ToList();
                cbBoxMonHoc.ValueMember = "MAMH";
                cbBoxMonHoc.DisplayMember = "TENMH";
                cbBoxHK.DataSource = db.HOCKies.ToList();
                cbBoxHK.ValueMember = "MAHK";
                cbBoxHK.DisplayMember = "HOCKY1";
            }
            LoadDataScore();
        }
        public void LoadDataScore()
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select HS.MAHS, HO, TEN, STUFF((select  '; ' + cast(CTD1.DIEM as varchar) from CT_BANGDIEMMON CTD1 JOIN LOAIHINHKIEMTRA LHKT1 ON CTD1.MALHKT = LHKT1.MALHKT "
                + "where CTD1.MABDM = BDM.MABDM and LHKT1.MALHKT = '1000' FOR XML PATH('')), 1, 1, '')[DIEM15P], STUFF ((select  '; ' + cast(CTD1.DIEM as varchar) from CT_BANGDIEMMON CTD1 JOIN LOAIHINHKIEMTRA LHKT1 ON CTD1.MALHKT = LHKT1.MALHKT "
                + "where CTD1.MABDM = BDM.MABDM and LHKT1.MALHKT = '1001' FOR XML PATH('')), 1, 1, '') [DIEM1T], STUFF((select  '; ' + cast(CTD1.DIEM as varchar) from CT_BANGDIEMMON CTD1 JOIN LOAIHINHKIEMTRA LHKT1 ON CTD1.MALHKT = LHKT1.MALHKT "
                + "where CTD1.MABDM = BDM.MABDM and LHKT1.MALHKT = '1002' FOR XML PATH('')), 1, 1, '') [DIEMCK] from HOCSINH HS JOIN QUATRINHHOC QTH ON HS.MAHS = QTH.MAHS JOIN BANGDIEMMON BDM ON QTH.MAQTH = BDM.MAQTH "
                + "where MALOP = @MALOP and MAHK = @MAHK and MAMH = @MAMH ", con);
            DataTable dtScore = new DataTable();
            HOCKY objHK = cbBoxHK.SelectedItem as HOCKY;
            sda.SelectCommand.Parameters.Add("@MAHK", SqlDbType.Int).Value = objHK.MAHK;
            LOP objLop = cbBoxLop.SelectedItem as LOP;
            sda.SelectCommand.Parameters.Add("@MALOP", SqlDbType.Int).Value = objLop.MALOP;
            MONHOC objMH = cbBoxMonHoc.SelectedItem as MONHOC;
            sda.SelectCommand.Parameters.Add("@MAMH", SqlDbType.Int).Value = objMH.MAMH;

            sda.Fill(dtScore);
            DataGridViewScore.Rows.Clear();
            foreach (DataRow item in dtScore.Rows)
            {
                int n = DataGridViewScore.Rows.Add();
                DataGridViewScore.Rows[n].Cells[0].Value = "false";
                DataGridViewScore.Rows[n].Cells[1].Value = item["MAHS"].ToString();
                DataGridViewScore.Rows[n].Cells[2].Value = item["HO"].ToString();
                DataGridViewScore.Rows[n].Cells[3].Value = item["TEN"].ToString();
                DataGridViewScore.Rows[n].Cells[5].Value = item["DIEM15P"].ToString();
                DataGridViewScore.Rows[n].Cells[6].Value = item["DIEM1T"].ToString();
                DataGridViewScore.Rows[n].Cells[7].Value = item["DIEMCK"].ToString();
            }
            con.Close();
        }
    

        private void cbBoxLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataScore();
            Cursor.Current = Cursors.Default;
        }

        private void cbBoxMonHoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataScore();
            Cursor.Current = Cursors.Default;
        }

        private void cbBoxHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataScore();
            Cursor.Current = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ScoreDetail detailModel = new ScoreDetail();
            bool ValidScore = true;
            bool NonScore = false;
            List<ScoreDetail> objectDetailList = new List<ScoreDetail>();
            var con = ConnectionToSql.getConnection();
            foreach (DataGridViewRow item in DataGridViewScore.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select distinct BDM.MABDM from HOCSINH HS JOIN QUATRINHHOC QTH ON HS.MAHS = QTH.MAHS "
                        + "JOIN BANGDIEMMON BDM ON QTH.MAQTH = BDM.MAQTH "
                        + "where MALOP = @MALOP and MAHK = @MAHK and MAMH = @MAMH and HS.MAHS = @MAHS ", con);
                    DataTable dtScore1 = new DataTable();
                    HOCKY objHK = cbBoxHK.SelectedItem as HOCKY;
                    sda.SelectCommand.Parameters.Add("@MAHK", SqlDbType.Int).Value = objHK.MAHK;
                    LOP objLop = cbBoxLop.SelectedItem as LOP;
                    sda.SelectCommand.Parameters.Add("@MALOP", SqlDbType.Int).Value = objLop.MALOP;
                    MONHOC objMH = cbBoxMonHoc.SelectedItem as MONHOC;
                    sda.SelectCommand.Parameters.Add("@MAMH", SqlDbType.Int).Value = objMH.MAMH;
                    sda.SelectCommand.Parameters.Add("@MAHS", SqlDbType.Int).Value = Int32.Parse(item.Cells[1].Value.ToString());
                    sda.Fill(dtScore1);
                    string Diem15p = item.Cells[5].Value.ToString();
                    Diem15p = Diem15p.Replace(" ", String.Empty);
                    String[] List15p = Diem15p.Split(new string[] { ";" }, StringSplitOptions.None);
      
                    foreach (string item1 in List15p)
                    {
                        int number;
                        if (Int32.TryParse(item1.ToString(), out number))
                        {
                            var detail = new ScoreDetail()
                            {
                                MABDM = dtScore1.Rows[0].Field<int>("MABDM"),
                                MALHKT = Int32.Parse("1000"),
                                DIEM = float.Parse(item1.ToString()),
                            };
                            if (detail.DIEM > 10 || detail.DIEM < 0)
                            {
                                ValidScore = false;
                            }
                            else
                            {
                                objectDetailList.Add(detail);
                            }
                        }
                        else
                        {
                            NonScore = true;
                        }
                    }
                    string Diem1t = item.Cells[6].Value.ToString();
                    Diem1t = Diem1t.Replace(" ", String.Empty);
                    String[] List1t = Diem1t.Split(new string[] { ";" }, StringSplitOptions.None);
                    foreach (string item2 in List1t)
                    {
                        int number;
                        if (Int32.TryParse(item2.ToString(), out number))
                        {
                            var detail = new ScoreDetail()
                            {
                                MABDM = dtScore1.Rows[0].Field<int>("MABDM"),
                                MALHKT = Int32.Parse("1001"),
                                DIEM = float.Parse(item2.ToString()),
                            };
                            if (detail.DIEM > 10 || detail.DIEM < 0)
                            {
                                ValidScore = false;
                            }
                            else
                            {
                                objectDetailList.Add(detail);
                            }
                        }
                        else
                        {
                            NonScore = true;
                        }
                    }
                    string DiemCK = item.Cells[7].Value.ToString();
                    DiemCK = DiemCK.Replace(" ", String.Empty);
                    String[] ListCK = DiemCK.Split(new string[] { ";" }, StringSplitOptions.None);
                    foreach (string item3 in ListCK)
                    {
                        int number;
                        if (Int32.TryParse(item3.ToString(), out number))
                        {
                            var detail = new ScoreDetail()
                            {
                                MABDM = dtScore1.Rows[0].Field<int>("MABDM"),
                                MALHKT = Int32.Parse("1002"),
                                DIEM = float.Parse(item3.ToString()),
                            };
                            if (detail.DIEM > 10 || detail.DIEM < 0)
                            {
                                ValidScore = false;
                            }
                            else
                            {
                                objectDetailList.Add(detail);
                            }
                        }
                        else
                        {
                            NonScore = true;
                        }
                    }
                    con.Close();
                }
            }
            if (ValidScore == true && NonScore == false )
            {
                detailModel = new ScoreDetail();
                detailModel.add_MultipleScoresSingleInsert(objectDetailList);
                MessageBox.Show("Thêm điểm cho học sinh thành công");
            }
            else if (ValidScore == false)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 tới 10");
            }
            else
            {
                MessageBox.Show("Điểm phải là một số nằm trong khoảng từ 0 tới 10");
            }
            LoadDataScore();        
        }
    }
}
