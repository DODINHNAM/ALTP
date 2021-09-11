using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace AiLaTrieuPhu
{
    public partial class Main : Form
    {
        WindowsMediaPlayer batdau = new WindowsMediaPlayer();
        DataProcessing data = new DataProcessing();
        public Main()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            grbDangNhap.Visible = true;
            btnDangNhap.Visible = false;
            btnDangKy.Visible = false;
            btnThoat.Visible = false;
            btnTop.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            grbDangNhap.Visible = false;
            btnDangNhap.Visible = true;
            btnDangKy.Visible = true;
            btnThoat.Visible = true;
            btnTop.Visible = true;

        }

        private void btnVaoDN_Click(object sender, EventArgs e)
        {
            
            String tk = txtTaiKhoan.Text;
            String mk = txtMatKhau.Text;
            
            if (data.Login(tk, mk) == true)
            {
                grbDangNhap.Visible = false;

                DataTable table = new DataTable();
                table = data.GetTenTK(tk, mk);
                String quyen = data.GetQuyen(tk);
                if (quyen.Equals("admin") || quyen.Equals("manager"))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Admin.name = row["Ten"].ToString();
                        Admin.taikhoan = row["TaiKhoan"].ToString();
                        Admin.q = row["Quyen"].ToString();
                    }
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    foreach (DataRow row in table.Rows)
                    {
                        User.name = row["Ten"].ToString();
                        User.taikhoan = row["TaiKhoan"].ToString();
                    }
                    User frmGame = new User();
                    frmGame.Show();
                    this.Hide();
                }
                batdau.controls.stop();
            }
            else
            {
                grbDangNhap.Visible = true;
                btnDangNhap.Visible = false;
                btnDangKy.Visible = false;
                btnThoat.Visible = false;
                btnTop.Visible = false;
            }
        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            grbDangKy.Visible = false;
            btnDangNhap.Visible = true;
            btnDangKy.Visible = true;
            btnThoat.Visible = true;
            btnTop.Visible = true;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            try
            {
                String tk = txtTK.Text;
                String mk1 = txtMK1.Text;
                String mk2 = txtMK2.Text;
                String ten = txtTenND.Text;
                double sdt = double.Parse(txtSDT.Text);
                if (tk.Equals("") || mk1.Equals("") || mk2.Equals("") || ten.Equals("") || sdt.Equals(""))
                {
                    MessageBox.Show("Không được để trống thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!mk1.Equals(mk2))
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (data.AddTK(tk, ten, mk1, sdt, "guest") == true)
                        {
                            grbDangKy.Visible = false;
                            btnDangNhap.Visible = true;
                            btnDangKy.Visible = true;
                            btnThoat.Visible = true;
                            btnTop.Visible = true;
                            clearDK();
                        }
                        else
                        {
                            grbDangKy.Visible = true;
                            btnDangNhap.Visible = false;
                            btnDangKy.Visible = false;
                            btnThoat.Visible = false;
                            btnTop.Visible = false;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số điện thoại nhập chữ số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            grbTop.Visible = true;
            btnDangNhap.Visible = false;
            btnDangKy.Visible = false;
            btnThoat.Visible = false;
            btnTop.Visible = false;

            List<String> ten = new List<string>();
            List<String> diem = new List<string>();
            DataTable table = new DataTable();
            table = data.GetTop();
            foreach (DataRow row in table.Rows)
            {
                ten.Add(row["Ten"].ToString());
                diem.Add(row["Diem"].ToString());
            }
            Top1Ten.Text = "1. " + ten[0];
            Top1Diem.Text = diem[0];
            Top2Ten.Text = "2. " + ten[1];
            Top2Diem.Text = diem[1];
            Top3Ten.Text = "3. " + ten[2];
            Top3Diem.Text = diem[2];
            Top4Ten.Text = "4. " + ten[3];
            Top4Diem.Text = diem[3];
            Top5Ten.Text = "5. " + ten[4];
            Top5Diem.Text = diem[4];
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            grbTop.Visible = false;
            btnDangNhap.Visible = true;
            btnDangKy.Visible = true;
            btnThoat.Visible = true;
            btnTop.Visible = true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            grbDangKy.Visible = true;
            btnDangNhap.Visible = false;
            btnDangKy.Visible = false;
            btnThoat.Visible = false;
            btnTop.Visible = false;
        }
        private void clearDK()
        {
            txtTenND.Clear();
            txtTK.Clear();
            txtMK1.Clear();
            txtMK2.Clear();
            txtSDT.Clear();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            batdau.URL=@Application.StartupPath + @"\Music\mo_dau_game.mp3";
            batdau.controls.play();
        }
    }
}
