using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QLKhachSan.Models
{
    public class Phong
    {

        //Không thể để trống
        [Required(ErrorMessage ="Mời nhập mã phòng")]
        [Display(Name = "Mã phòng")]
        public string maphong { get; set; }
        [Required(ErrorMessage = "Mời nhập mã lập phòng")]
        [Display(Name = "Mã lập phòng")]
        public string malp { get; set; }
        [Required(ErrorMessage = "Mời nhập tên phòng")]
        [Display(Name = "Tên phòng")]
        public string tenphong { get; set; }
        [Required(ErrorMessage = "Mời nhập trạng thái phòng")]
        [Display(Name = "Trạng thái phòng")]
        public string trangthai { get; set; }
    }
    class phongList
    {
        DbConnection db;
        public phongList()
        {
            db = new DbConnection();
        }
        public List<Phong>GetPhongs(string maphong)
        {
            string Sql;
            if (string.IsNullOrEmpty(maphong))
                Sql = "select * from phong";
            else
                Sql = "select * from phong where maphong = " + maphong;
            List<Phong> phongs = new List<Phong>();
            DataTable dt = new DataTable();
            SqlConnection con = db.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(Sql, con);
            con.Open();
            da.Fill(dt);
            da.Dispose();
            con.Close();

            Phong tempPhong;

            for( int i = 0; i < dt.Rows.Count; i++)
            {
                tempPhong = new Phong();
                tempPhong.maphong = dt.Rows[i]["maphong"].ToString();   
                tempPhong.malp = dt.Rows[i]["malp"].ToString();
                tempPhong.tenphong = dt.Rows[i]["tenphong"].ToString();
                tempPhong.trangthai= dt.Rows[i]["trangthaiphong"].ToString();

                phongs.Add(tempPhong);
                
            }
            return phongs;
        }

    }
}