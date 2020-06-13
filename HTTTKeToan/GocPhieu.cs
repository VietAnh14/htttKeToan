using HTTTKeToan.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTTKeToan
{
    public class GocPhieu
    {
        public int id { get; set; }
        public string pso { get; set; }
        public string loaiCT { get; set; }
        public string msCH { get; set; }
        public string ngayLap { get; set; }
        public string msCH1 { get; set; }
        public string msKh { get; set; }
        public string soHD { get; set; }
        public string loaiHD { get; set; }
        public string ngPHHD { get; set; }
        public string nttoan { get; set; }
        public string quyenHD { get; set; }
        public string lyDo { get; set; }
        public string ctGoc { get; set; }
        public string namThang { get; set; }

        public string toInsertString(string psoStr)
        {
            int id = getNextId();
            string query = "INSERT INTO GOC_PHIEU (PSO, LOAICT, MSCH, NLAP, MSKH, SOHD, LOAIHD, NTTOAN, NGPHHD, QUYEN_HD, LYDO) ";
            query += "VALUES('" + psoStr + "','" + loaiCT.ToString();
            query += "','"+ msCH +"','"+ ngayLap +"','"+msKh+"','"+soHD+"','"+loaiHD+"','"+nttoan+"','"+ngPHHD+"',"+quyenHD+",'"+lyDo+"')";
            return query;
        }

        public int getNextId()
        {
            var maxId = DbUtils.Instance.ExecuteScalar("SELECT MAX(GOC_PHIEU.ID) FROM GOC_PHIEU");
            return maxId == null ? 0 : (int)maxId;
        }

        public bool insert(string psoStr)
        {
            try
            {
                string insertString = toInsertString(psoStr);
                var row = DbUtils.Instance.ExecuteNonQuery(toInsertString(psoStr));
                return row > 0;
            } catch(Exception e)
            {
                string err = e.StackTrace;
                return false;
            }
        }
    }
}
