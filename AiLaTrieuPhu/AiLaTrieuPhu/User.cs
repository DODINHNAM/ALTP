using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AiLaTrieuPhu
{
    public partial class User : Form
    {
        WindowsMediaPlayer sansang = new WindowsMediaPlayer();
        WindowsMediaPlayer huongdan = new WindowsMediaPlayer();
        public static String name;
        public static String taikhoan;
        DataProcessing data = new DataProcessing();
        public User()
        {
            InitializeComponent();
        }

        private void btnThoatGame_Click(object sender, EventArgs e)
        {
            Main frmALTP = new Main();
            frmALTP.Show();
            this.Hide();
        }
        int chuchay = 0;
        private void tmchuchay_Tick(object sender, EventArgs e)
        {
            chuchay++;
            lbchaomung2.Text = "Chào mừng " +name+" đến với chương trình ai là triệu phú";
            btnBatDau.Visible = false;
            btnHuongDan.Visible = false;
            btnLichSu.Visible = false;
            btnThoatGame.Visible = false;
            lbchaomung2.Left += 18;
            if (chuchay == 60)
            {
                tmchuchay.Stop();
                btnBatDau.Visible = true;
                btnHuongDan.Visible = true;
                btnLichSu.Visible = true;
                btnThoatGame.Visible = true;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            sansang.URL = @Application.StartupPath + @"\Music\san_sang_choi_chua.mp3";
            sansang.controls.play();
            tmchuchay.Enabled = true;
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            grbLichSu.Visible = true;
            btnBatDau.Visible = false;
            btnHuongDan.Visible = false;
            btnLichSu.Visible = false;
            btnThoatGame.Visible = false;

            
            DataTable dt = new DataTable();
            dt = data.ShowLichSu(taikhoan);

            dgvLichSu.DataSource = dt;
        }

        private void btnOutLS_Click(object sender, EventArgs e)
        {
            grbLichSu.Visible = false;
            btnBatDau.Visible = true;
            btnHuongDan.Visible = true;
            btnLichSu.Visible = true;
            btnThoatGame.Visible = true;
        }
        int hd = 0;
        private void tmhuongdan_Tick(object sender, EventArgs e)
        {
            hd++;

            if (hd == 1)
                lbtexthuongdan.Text += " ";

            if (hd == 2)
                lbtexthuongdan.Text += "Bạn";
            if (hd == 3)
                lbtexthuongdan.Text += " sẽ";
            if (hd == 4)
                lbtexthuongdan.Text += " phải";
            if (hd == 5)
                lbtexthuongdan.Text += " trả";

            if (hd == 6)
                lbtexthuongdan.Text += " lời";
            if (hd == 7)
                lbtexthuongdan.Text += " 15";
            if (hd == 8)
                lbtexthuongdan.Text += " câu";
            if (hd == 9)
                lbtexthuongdan.Text += " hỏi";

            if (hd == 10)
                lbtexthuongdan.Text += " ,cũng";
            if (hd == 11)
                lbtexthuongdan.Text += " như";
            if (hd == 12)
                lbtexthuongdan.Text += " tất";
            if (hd == 13)
                lbtexthuongdan.Text += " cả";

            if (hd == 14)
                lbtexthuongdan.Text += " những";
            if (hd == 15)
                lbtexthuongdan.Text += " người";
            if (hd == 16)
                lbtexthuongdan.Text += "\n đến";
            if (hd == 17)
                lbtexthuongdan.Text += " với";
            if (hd == 18)
                lbtexthuongdan.Text += " Ai";
            if (hd == 19)
                lbtexthuongdan.Text += " là";
            if (hd == 20)
                lbtexthuongdan.Text += " triệu";
            if (hd == 21)
                lbtexthuongdan.Text += " phú.\n";
            if (hd == 22)
                lbtexthuongdan.Text += " Và";
            if (hd == 23)
                lbtexthuongdan.Text += " có";
            if (hd == 24)
                lbtexthuongdan.Text += " 3";
            if (hd == 25)
                lbtexthuongdan.Text += " mốc";
            if (hd == 26)
                lbtexthuongdan.Text += " rất";
            if (hd == 27)
                lbtexthuongdan.Text += " quan";
            if (hd == 28)
                lbtexthuongdan.Text += " là";
            if (hd == 29)
                lbtexthuongdan.Text += " 5,";
            if (hd == 30)
                lbtexthuongdan.Text += " 10,";
            if (hd == 31)
                lbtexthuongdan.Text += " 15";
            if (hd == 32)
                lbtexthuongdan.Text += " bạn";
            if (hd == 33)
                lbtexthuongdan.Text += " cần";
            if (hd == 34)
                lbtexthuongdan.Text += " phải";
            if (hd == 35)
                lbtexthuongdan.Text += " vượt";
            if (hd == 36)
                lbtexthuongdan.Text += " qua";
           
            if (hd == 37)
                lbtexthuongdan.Text += "\n\n Chúng";
            if (hd == 38)
                lbtexthuongdan.Text += " ta";
            if (hd == 39)
                lbtexthuongdan.Text += " bắt";
            if (hd == 40)
                lbtexthuongdan.Text += " đầu";
            if (hd == 41)
                lbtexthuongdan.Text += " đi";
            if (hd == 42)
                lbtexthuongdan.Text += " tìm";
            if (hd == 43)
                lbtexthuongdan.Text += " AI ";
            if (hd == 44)
                lbtexthuongdan.Text += " LÀ";
            if (hd == 45)
                lbtexthuongdan.Text += " TRIỆU";
            if (hd == 46)
                lbtexthuongdan.Text += " PHÚ";
            if (hd == 47)
                lbtexthuongdan.Text += "!!!";
        }


        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            huongdan.URL = @Application.StartupPath + @"\Music\huong_dan.mp3";
            huongdan.controls.play();
            lbtexthuongdan.Text = "";
            grbHuongDan.Visible = true;
            btnBatDau.Visible = false;
            btnHuongDan.Visible = false;
            btnLichSu.Visible = false;
            btnThoatGame.Visible = false;
            tmhuongdan.Enabled = true;
        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            grbHuongDan.Visible = false;
            btnBatDau.Visible = true;
            btnHuongDan.Visible = true;
            btnLichSu.Visible = true;
            btnThoatGame.Visible = true;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            GameALTP.taikhoan = taikhoan;
            GameALTP.name = name;
            GameALTP frmALTP = new GameALTP();
            frmALTP.Show();
            this.Hide();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
