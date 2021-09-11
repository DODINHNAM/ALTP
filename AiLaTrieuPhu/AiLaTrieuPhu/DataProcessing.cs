using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AiLaTrieuPhu
{
    class DataProcessing
    {
        DBConnection dataConn = new DBConnection();


        //Xử lý bên đăng nhập ALTP
        public Boolean Login(String tk, String mk)
        {
            if (CheckTKMK(tk, mk))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable GetTenTK(String tk, String mk)
        {
            String sql = "select Ten, TaiKhoan, Quyen from taikhoan where TaiKhoan= '" + tk + "' and MatKhau= '" + mk + "' ";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);
            return dt;
        }
        public Boolean CheckTKMK(String tk, String mk)
        {
            try
            {
                String sql = "select * from taikhoan where TaiKhoan= '" + tk + "' and MatKhau= '" + mk + "' ";
                DataTable dt = new DataTable();
                dt = dataConn.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public String GetQuyen(String tk)
        {
            String quyen = "";
            String sql = "select Ten, TaiKhoan, Quyen from taikhoan where TaiKhoan= '" + tk + "'";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                quyen = row["Quyen"].ToString();
            }
            return quyen;
        }


        public DataTable GetTop()
        {
            String sql = "select Ten, Diem from thanhtich inner join taikhoan on thanhtich.TaiKhoan = taikhoan.TaiKhoan order by Diem desc";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);
            return dt;
        }
        public Boolean AddTK(String tk, String ten, String mk, double sdt, String quyen)
        {
            if (CheckTK(tk))
            {
                MessageBox.Show("Tài khoản đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                String sql = "exec themTK '" + tk + "' ,N'" + ten + "','" + mk + "', '" + sdt + "', '" + quyen + "'";
                dataConn.ExecuteNonQuery(sql);
                MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
        public Boolean CheckTK(String tk)
        {
            try
            {
                String sql = "select * from taikhoan where TaiKhoan= '" + tk + "'";
                DataTable dt = new DataTable();
                dt = dataConn.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        //Xử lý bên phần trò chơi ALTPGame
        public DataTable ShowAllCauHoi()
        {
            String sql = "Select * from cauhoi order by ID asc";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);

            return dt;
        }
        
        public DataTable GetCauHoi(int MaCH)
        {
            String sql = "select * from dbo.ThongTinCauHoi(" + MaCH + ")";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);
            return dt;
        }
        public void UpdateThanhTich(int diem, DateTime ngaychoi, String tk)
        {
            String sql = "exec themThanhTich '" + diem + "','" + ngaychoi.ToString("yyyy-MM-dd") + "', '" + tk + "'";
            dataConn.ExecuteNonQuery(sql);
        }

        //Xử lý bên sau khi đăng nhập thành công Game
        public DataTable ShowLichSu(String tk)
        {
            String sql = "select Ten, Diem, NgayChoi from thanhtich inner join taikhoan on thanhtich.TaiKhoan = taikhoan.TaiKhoan where thanhtich.TaiKhoan='" + tk + "' ORDER BY STT DESC";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);
            return dt;
        }

        //Admin quản lý tài khoản
        public DataTable ShowAllTaiKhoan()
        {
            String sql = "select * from taikhoan ";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);
            return dt;
        }

        public DataTable ShowAllQuyen()
        {
            String sql = "select Quyen from taikhoan group by Quyen";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);
            return dt;
        }
        public DataTable ShowTaiKhoan()
        {
            String sql = "select * from taikhoan where Quyen not in ('admin') ";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);
            return dt;
        }

        public DataTable ShowQuyen()
        {
            String sql = "select Quyen from taikhoan where Quyen not in ('admin') group by Quyen";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);
            return dt;
        }

        
        public Boolean EditTK(String tk, String ten, String mk, double sdt, String quyen)
        {
            if (!CheckTK(tk))
            {
                MessageBox.Show("Tài khoản không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                String sql = "exec suaTK '" + tk + "' ,N'" + ten + "','" + mk + "', '" + sdt + "', '" + quyen + "'";
                dataConn.ExecuteNonQuery(sql);
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
        public Boolean DelTK(String tk)
        {
            if (!CheckTK(tk))
            {
                MessageBox.Show("Tài khoản không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                String sql = "exec xoaTK '" + tk + "'";
                dataConn.ExecuteNonQuery(sql);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        //Admin quản lý câu hỏi

        public DataTable ShowCauHoi(String tk)
        {
            String sql = "Select * from cauhoi where TaiKhoan = N'" + tk + "' order by ID asc";
            DataTable dt = new DataTable();
            dt = dataConn.GetDataTable(sql);

            return dt;
        }

        public Boolean CheckIdCH(int id)
        {
            try
            {
                String sql = "select * from cauhoi where ID= '" + id + "'";
                DataTable dt = new DataTable();
                dt = dataConn.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean CheckCH(String ch)
        {
            try
            {
                String sql = "select * from cauhoi";
                DataTable dt = new DataTable();
                dt = dataConn.GetDataTable(sql);
                foreach (DataRow dataRow in dt.Rows)
                {
                    if (dataRow["CauHoi"].ToString().Equals(ch)) {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean AddCH(String ch, String a, String b, String c, String d, String da, String tk)
        {
            if (CheckCH(ch))
            {
                MessageBox.Show("Câu hỏi đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                String sql = "exec themCH N'" + ch + "',N'" + a + "',N'" + b + "',N'" + c + "',N'" + d + "',N'" + da + "',N'" + tk + "'";
                dataConn.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
        public Boolean EditCH(int id, String ch, String a, String b, String c, String d, String da, String tk)
        {
            if (!CheckIdCH(id))
            {
                MessageBox.Show("Câu hỏi không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                String sql = "exec suaCH '" + id + "' ,N'" + ch + "',N'" + a + "',N'" + b + "',N'" + c + "',N'" + d + "',N'" + da + "',N'" + tk + "'";
                dataConn.ExecuteNonQuery(sql);
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
        public Boolean DelCH(int id)
        {
            if (!CheckIdCH(id))
            {
                MessageBox.Show("Câu hỏi không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                String sql = "exec xoaCH '" + id + "'";
                dataConn.ExecuteNonQuery(sql);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
    }
}
