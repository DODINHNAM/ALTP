using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace AiLaTrieuPhu
{
    public partial class GameALTP : Form
    {
        public int demsocau = 1;
        public static String taikhoan;
        public static String name;
        WindowsMediaPlayer chodapan = new WindowsMediaPlayer();
        WindowsMediaPlayer dongho = new WindowsMediaPlayer();
        WindowsMediaPlayer trogiup = new WindowsMediaPlayer();
        WindowsMediaPlayer dapanchon = new WindowsMediaPlayer();
        WindowsMediaPlayer dapansai = new WindowsMediaPlayer();
        WindowsMediaPlayer dapan = new WindowsMediaPlayer();
        WindowsMediaPlayer cauhoi = new WindowsMediaPlayer();
        WindowsMediaPlayer dungchoi = new WindowsMediaPlayer();
        DataProcessing data = new DataProcessing();
        public GameALTP()
        {
            InitializeComponent();
        }
        public List<int> dsMaCH()
        {
            
            List<int> ds = new List<int>();
            DataTable dt = new DataTable();
            dt = data.ShowAllCauHoi();
            foreach (DataRow dataRow in dt.Rows)
            {
                ds.Add(int.Parse(dataRow["ID"].ToString()));
            }
            return ds;
            
        }
        //tránh việc câu hỏi lập lại
        List<int> mard = new List<int>();
        public CauHoi layCH()
        {
            CauHoi n = new CauHoi();
            Random rd = new Random();
            List<int> ma = dsMaCH();
            
            int rand;
            do
            {
                rand = rd.Next(0, ma.Count);
            }
            while (mard.Contains(rand));
            mard.Add(rand);
            DataTable tableCauHoi = data.GetCauHoi(ma[rand]);
            foreach (DataRow dataRow in tableCauHoi.Rows)
            {
                n.cauHoi = dataRow["CauHoi"].ToString();
                n.A = dataRow["A"].ToString();
                n.B = dataRow["B"].ToString();
                n.C = dataRow["C"].ToString();
                n.D = dataRow["D"].ToString();
                n.dapan = dataRow["DapAn"].ToString();
            }
            return n;
        }
        private void displaycauhoi(int x)
        {//thiết lập lại

            tmthoigian.Start();
            dongho.URL = @Application.StartupPath + @"\Music\dongho.wav";
            dongho.controls.play();

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            //Đến câu nào thì btn câu đó đổi màu
            if (x == 1)
            {
                btn1.BackColor = Color.Red;
                btntuvan.Visible = false;// Thiết lập lại tránh lỗi khi chơi lại
                cauhoi.URL= @Application.StartupPath + @"\Music\start_cau1.mp3";
            }
            if (x == 2)
            {
                btn2.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau2.mp3";
            }
            if (x == 3)
            {
                btn3.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau3.mp3";
            }
            if (x == 4)
            {
                btn4.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau4.mp3";
            }
            if (x == 5)
            {
                btn5.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau5.mp3";
            }
            if (x == 6)
            {
                btn6.BackColor = Color.Red;
                btntuvan.Visible = true;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau6.mp3";
            }
            if (x == 7)
            {
                btn7.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau7.mp3";
            }
            if (x == 8)
            {
                btn8.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau8.mp3";
            }
            if (x == 9)
            {
                btn9.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau9.mp3";
            }
            if (x == 10)
            {
                btn10.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau10.mp3";
            }
            if (x == 11)
            {
                btn11.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau11.mp3";
            }
            if (x == 12)
            {
                btn12.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau12.mp3";
            }
            if (x == 13)
            {
                btn13.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau13.mp3";
            }
            if (x == 14)
            {
                btn14.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau14.mp3";
            }
            if (x == 15)
            {
                btn15.BackColor = Color.Red;
                cauhoi.URL = @Application.StartupPath + @"\Music\start_cau15.mp3";
            }
            cauhoi.controls.play();
            btnA.BackColor = Color.Blue;
            btnB.BackColor = Color.Blue;
            btnC.BackColor = Color.Blue;
            btnD.BackColor = Color.Blue;
            //thiết lập lại giá trị rangbuoc để tránh lỗi
            rangBuoc = 60;
            lbthoigian.Visible = true;
            lbthoigian.BackColor = Color.Red;
            tmthoigian.Start();
            if (x == 16)
            {
                TienThuong.Text = lblDiem.Text+ " $";
                lblNhanThuong.Text = "Chúc mừng "+name+ ". Bạn là triệu phú !!!";
                grbthongbao.Visible = false;
                grbnhanthuong.Visible = true;

                DateTime now = DateTime.Now;
                data.UpdateThanhTich(int.Parse(lblDiem.Text), now, taikhoan);
            }
            else
            {//khai báo cauhoi outCH để nhận giá trị đưa ra từ hàm lcauhoi(int x).
                CauHoi outCH = new CauHoi();


                //thiết lập lại
                btnDung.Visible = true;
                btnkhangia2.Enabled = true;
                btn5050.Enabled = true;
                btngoidien2.Enabled = true;
                btntuvan.Enabled = true;
                lblcauhoi.Text = "";
                btnA.Text = "";
                btnB.Text = "";
                btnC.Text = "";
                btnD.Text = "";
                lblcauhoi.Visible = true;
                btnA.Visible = true;
                btnB.Visible = true;
                btnC.Visible = true;
                btnD.Visible = true;
                //Gán 
                outCH = layCH();
                lblcauhoi.Text = "Câu " + x.ToString() + ":   " + outCH.cauHoi;
                LuuDapAn.Text = outCH.dapan;
                //Random đáp án
                Random laydapan = new Random();
                int rdda = laydapan.Next(1, 4);
                if (rdda == 1)
                {

                    btnA.Text = outCH.A;
                    btnB.Text = outCH.B;
                    btnC.Text = outCH.C;
                    btnD.Text = outCH.D;

                }
                if (rdda == 2)
                {

                    btnA.Text = outCH.D;
                    btnB.Text = outCH.C;
                    btnC.Text = outCH.A;
                    btnD.Text = outCH.B;

                }
                if (rdda == 3)
                {

                    btnA.Text = outCH.C;
                    btnB.Text = outCH.A;
                    btnC.Text = outCH.D;
                    btnD.Text = outCH.B;

                }
                if (rdda == 4)
                {

                    btnA.Text = outCH.B;
                    btnB.Text = outCH.D;
                    btnC.Text = outCH.C;
                    btnD.Text = outCH.A;

                }
            }
        }
        
        private void GameALTP_Load(object sender, EventArgs e)
        {
            displaycauhoi(demsocau);
        }
        int tinhdiem(int x)
        {
            if (x == 0)
                return 0;
            if (x == 1)
                return 100;
            if (x == 2)
                return 200;
            if (x == 3)
                return 300;
            if (x == 4)
                return 500;
            if (x == 5)
                return 1000;
            if (x == 6)
                return 2000;
            if (x == 7)
                return 4000;
            if (x == 8)
                return 8000;
            if (x == 9)
                return 16000;
            if (x == 10)
                return 25000;
            if (x == 11)
                return 50000;
            if (x == 12)
                return 100000;
            if (x == 13)
                return 250000;
            if (x == 14)
                return 500000;
            if (x == 15)
                return 1000000;
            else return 0;
        }
        public void tinhthuongSai()
        {
            if (demsocau >=0 && demsocau<5)
            {
                lblDiem.Text = "0 ";
            }
            else
            {
                if (demsocau >= 5 && demsocau < 10)
                {
                    lblDiem.Text = "1000 ";
                }
                else
                    lblDiem.Text = "25000 ";
            }
        }
        int rangBuoc = 60;
        private void tmthoigian_Tick(object sender, EventArgs e)
        {
            lbtrogiup.Text = "";
            lbtrogiup.Visible = false;
            grbdisplaytrogiup.Visible = true;
            lbthoigian.Text = (rangBuoc).ToString();
            rangBuoc--;

            pictureBox1.Visible = true;
            picA.Visible = false;
            picB.Visible = false;
            picC.Visible = false;
            picD.Visible = false;
            if (rangBuoc == 60)
            {

                pictureBox1.Visible = true;
                picthongtin2.Visible = false;
                pictureBox2.Visible = false;


            }
            if (rangBuoc == 55)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                picthongtin2.Visible = true;


            }
            if (rangBuoc == 50)
            {

                pictureBox1.Visible = false;
                picthongtin2.Visible = false;
                pictureBox2.Visible = true;

            }
            if (rangBuoc == 40)
            {

                pictureBox1.Visible = true;
                picthongtin2.Visible = false;
                pictureBox2.Visible = false;


            }


            if (rangBuoc < 0)
            {
                lbthoigian.Text = "0";

            }

            if (rangBuoc < -1)
            {
                lbtrogiup.Visible = true;
                grbdisplaytrogiup.Visible = true;
                lbtrogiup.Text = "\n\nBạn đã hết thời gian!!!!!!!!!";
                picA.Visible = false;
                picB.Visible = false;
                picC.Visible = false;
                picD.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                picthongtin2.Visible = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

            }
            if (rangBuoc == -5)
            {
                grbthongbao.Visible = false;
                tinhthuongSai();
                btnThuong.Text = lblDiem.Text;

                grbnhanthuong.Visible = true;
                grbdisplaytrogiup.Visible = false;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                lbtrogiup.Visible = false;
                tmthoigian.Stop();
            }
        }
        string test;
        int AA = 0;
        private void btnA_Click(object sender, EventArgs e)
        {
            dongho.controls.stop();
            dapanchon.URL= @Application.StartupPath + @"\Music\answer_a.mp3";
            dapanchon.controls.play();
            btnkhangia2.Enabled = false;
            btn5050.Enabled = false;
            btngoidien2.Enabled = false;
            btntuvan.Enabled = false;
            btnstop.Visible = false;
            btnDung.Visible = false;
            tmgoidien.Stop();
            tmtuvan.Stop();
            tmkhangia.Stop();
            lbtrogiup.Text = "";
            lbtrogiup.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            picthongtin2.Visible = false;
            picA.Visible = true;
            picB.Visible = false;
            picC.Visible = false;
            picD.Visible = false;
            lbthoigian.Text = "";
            lbthoigian.Visible = false;
            btnA.Enabled = false; btnB.Enabled = false; btnC.Enabled = false; btnD.Enabled = false;
            tmthoigian.Stop();
            tmdapan.Stop();
            btnA.BackColor = Color.Yellow;
            chodapan.URL = @Application.StartupPath + @"\Music\true.wav";
            chodapan.controls.play();
            test = "Adung";

            AA = 0;
            tmdapan.Start();
            

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            dongho.controls.stop();
            dapanchon.URL = @Application.StartupPath + @"\Music\answer_b.mp3";
            dapanchon.controls.play();
            btnkhangia2.Enabled = false;
            btn5050.Enabled = false;
            btngoidien2.Enabled = false;
            btntuvan.Enabled = false;
            btnstop.Visible = false;
            btnDung.Visible = false;
            tmgoidien.Stop();
            tmtuvan.Stop();
            tmkhangia.Stop();
            lbtrogiup.Text = "";
            lbtrogiup.Visible = false;
            picA.Visible = false;
            picB.Visible = true;
            picC.Visible = false;
            picD.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            picthongtin2.Visible = false;
            lbthoigian.Text = "";
            lbthoigian.Visible = false;
            btnA.Enabled = false; btnB.Enabled = false; btnC.Enabled = false; btnD.Enabled = false;
            tmthoigian.Stop();
            tmdapan.Stop();
            btnB.BackColor = Color.Yellow;
            chodapan.URL = @Application.StartupPath + @"\Music\true.wav";
            chodapan.controls.play();
            test = "Bdung";
            AA = 0;
            tmdapan.Start();

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            dongho.controls.stop();
            dapanchon.URL = @Application.StartupPath + @"\Music\answer_c.mp3";
            dapanchon.controls.play();
            btnkhangia2.Enabled = false;
            btn5050.Enabled = false;
            btngoidien2.Enabled = false;
            btntuvan.Enabled = false;
            btnstop.Visible = false;
            btnDung.Visible = false;
            tmgoidien.Stop();
            tmtuvan.Stop();
            tmkhangia.Stop();
            lbtrogiup.Text = "";
            lbtrogiup.Visible = false;
            picA.Visible = false;
            picB.Visible = false;
            picC.Visible = true;
            picD.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            picthongtin2.Visible = false;

            lbthoigian.Text = "";
            lbthoigian.Visible = false;
            btnA.Enabled = false; btnB.Enabled = false; btnC.Enabled = false; btnD.Enabled = false;
            tmthoigian.Stop();
            tmdapan.Stop();
            btnC.BackColor = Color.Yellow;
            chodapan.URL = @Application.StartupPath + @"\Music\true.wav";
            chodapan.controls.play();
            test = "Cdung";
            AA = 0;
            tmdapan.Start();

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            dongho.controls.stop();
            dapanchon.URL = @Application.StartupPath + @"\Music\answer_d.mp3";
            dapanchon.controls.play();
            btnkhangia2.Enabled = false;
            btn5050.Enabled = false;
            btngoidien2.Enabled = false;
            btntuvan.Enabled = false;
            btnstop.Visible = false;
            btnDung.Visible = false;
            tmgoidien.Stop();
            tmtuvan.Stop();
            tmkhangia.Stop();
            lbtrogiup.Text = "";
            lbtrogiup.Visible = false;
            picA.Visible = false;
            picB.Visible = false;
            picC.Visible = false;
            picD.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            picthongtin2.Visible = false;
            lbthoigian.Text = "";
            lbthoigian.Visible = false;
            btnA.Enabled = false; btnB.Enabled = false; btnC.Enabled = false; btnD.Enabled = false;
            tmthoigian.Stop();
            tmdapan.Stop();
            btnD.BackColor = Color.Yellow;
            chodapan.URL = @Application.StartupPath + @"\Music\true.wav";
            chodapan.controls.play();
            test = "Ddung";

            AA = 0;
            tmdapan.Start();


        }
        

        void thongbaodungchoi()
        {

            btnstop.Visible = false;
            btnDung.Visible = false;
            btnThuong.Visible = true;
            lbcauhoi.Visible = false;
            lblcauhoi.Visible = false;
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            grbdisplaytrogiup.Visible = false;
            grbthongbao.Visible = true;

            if (lblDiem.Text == "")
            {
                lblDiem.Text = "0 ";
            }
            lbthongbao.Text = "Bạn đã chơi đến câu " + demsocau + " .Chúc bạn may mắn lần sau !!!";
            btntieptuc.Visible = false;
            btnThuong.Text = "Nhận thưởng";
            

        }
        private void btnDung_Click(object sender, EventArgs e)
        {
            tmthoigian.Stop();
            dongho.controls.pause();
            dungchoi.URL = @Application.StartupPath + @"\Music\tro_giup_dung_choi.mp3";
            dungchoi.controls.play();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn dừng cuộc chơi ở đây", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if(dialogResult== DialogResult.Yes)
            {
                dungchoi.URL = @Application.StartupPath + @"\Music\sound_chiatay.mp3";
                dungchoi.controls.play();
                thongbaodungchoi();
            }
            else
            {
                tmthoigian.Start();
                dongho.controls.play();
            }
        }
        void thongbaosai()
        {

            btnstop.Visible = false;
            btnDung.Visible = false;
            btnThuong.Visible = true;
            lbcauhoi.Visible = false;
            lblcauhoi.Visible = false;
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            grbdisplaytrogiup.Visible = false;
            grbthongbao.Visible = true;

            tinhthuongSai();


            if (LuuDapAn.Text == btnA.Text)
            {
                lbthongbao.Text = "Là A!Rất tiếc! ";
                btntieptuc.Visible = false;
                btnThuong.Text = "Nhận thưởng";
            }
            if (LuuDapAn.Text == btnB.Text)
            {
                lbthongbao.Text = "Bạn đã trả lời sai.";
                btntieptuc.Visible = false;
                btnThuong.Text = "Nhận thưởng";
            }
            if (LuuDapAn.Text == btnC.Text)
            {
                lbthongbao.Text = "Là C!Có 1 sự mất bình tĩnh ở đây! ";
                btntieptuc.Visible = false;
                btnThuong.Text = "Nhận thưởng";
            }
            if (LuuDapAn.Text == btnD.Text)
            {
                lbthongbao.Text = "Là D!Quá tiếc cho bạn! ";
                btntieptuc.Visible = false;
                btnThuong.Text = "Nhận thưởng";
            }

        }
        //Hàm hiển thị khi trả lời đúng


        void thongbaodung()
        {

            lbcauhoi.Visible = false;
            lblcauhoi.Visible = false;
            btnstop.Visible = true;
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            grbthongbao.Visible = true;
            grbdisplaytrogiup.Visible = false;
            btntieptuc.Visible = true;
            if (LuuDapAn.Text == btnA.Text)
            {
                lblDiem.Text = tinhdiem(demsocau).ToString();

                demsocau++;
                lbthongbao.Text = "Là A!Xin chúc mừng! ";
                btntieptuc.Text = "Tiếp tục";
                btnstop.Text = "Dừng chơi";

            }
            if (LuuDapAn.Text == btnB.Text)
            {
                lblDiem.Text = tinhdiem(demsocau).ToString();
                demsocau++;
                lbthongbao.Text = "Bạn đã trả lời đúng. Bạn muốn tiếp tục không?";
                btntieptuc.Text = "Tiếp tục";
                btnstop.Text = "Dừng chơi";
            }
            if (LuuDapAn.Text == btnC.Text)
            {
                lblDiem.Text = tinhdiem(demsocau).ToString();
                demsocau++;
                lbthongbao.Text = "Là C!Bạn đang chơi rất tốt! ";
                btntieptuc.Text = "Tiếp tục";
                btnstop.Text = "Dừng chơi";
            }
            if (LuuDapAn.Text == btnD.Text)
            {
                lblDiem.Text = tinhdiem(demsocau).ToString();
                demsocau++;
                lbthongbao.Text = "Là D!Xin chúc mừng! ";
                btntieptuc.Text = "Tiếp tục";
                btnstop.Text = "Dừng chơi";
            }
        }
        private void tmdapan_Tick(object sender, EventArgs e)
        {
            
            AA++;
            if (AA == 96)
            {
                if (test == "Adung") //Khi chọn A
                {
                    if (LuuDapAn.Text == btnA.Text) //Khi A đúng
                    {
                        dapan.URL = @Application.StartupPath + @"\Music\true_a.mp3";
                        dapan.controls.play();
                        if (AA % 2 == 0)
                        {
                            btnA.BackColor = Color.Red;

                        }

                        else
                        {
                            btnA.BackColor = Color.Blue;
                        }
                        
                    }
                    else //Khi A sai
                    {
                        if (LuuDapAn.Text == btnB.Text) 
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_b.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnB.BackColor = Color.Red;
                            }
                            else
                            {
                                btnB.BackColor = Color.Blue;
                            }
                            
                        }
                        if (LuuDapAn.Text == btnC.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_c.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnC.BackColor = Color.Red;
                            }
                            else
                            {
                                btnC.BackColor = Color.Blue;
                            }
                            
                        }
                        if (LuuDapAn.Text == btnD.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_d.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnD.BackColor = Color.Red;
                            }
                            else
                            {
                                btnD.BackColor = Color.Blue;
                            }
                            
                        }
                        
                    }
                }
                //Khi chọn B 
                if (test == "Bdung")
                {
                    if (LuuDapAn.Text == btnB.Text)
                    {
                        dapan.URL = @Application.StartupPath + @"\Music\true_b.mp3";
                        dapan.controls.play();
                        if (AA % 2 == 0)
                        {
                            btnB.BackColor = Color.Red;

                        }

                        else
                        {
                            btnB.BackColor = Color.Blue;
                        }

                    }
                    else
                    {
                        if (LuuDapAn.Text == btnA.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_a.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnA.BackColor = Color.Red;
                            }
                            else
                            {
                                btnA.BackColor = Color.Blue;
                            }

                        }
                        if (LuuDapAn.Text == btnC.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_c.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnC.BackColor = Color.Red;
                            }
                            else
                            {
                                btnC.BackColor = Color.Blue;
                            }

                        }
                        if (LuuDapAn.Text == btnD.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_d.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnD.BackColor = Color.Red;
                            }
                            else
                            {
                                btnD.BackColor = Color.Blue;
                            }

                        }

                    }
                }
                //Khi chọn C
                if (test == "Cdung")
                {
                    if (LuuDapAn.Text == btnC.Text)
                    {
                        dapan.URL = @Application.StartupPath + @"\Music\true_c.mp3";
                        dapan.controls.play();
                        if (AA % 2 == 0)
                        {
                            btnC.BackColor = Color.Red;

                        }

                        else
                        {
                            btnC.BackColor = Color.Blue;
                        }

                    }
                    else
                    {
                        if (LuuDapAn.Text == btnB.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_b.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnB.BackColor = Color.Red;
                            }
                            else
                            {
                                btnB.BackColor = Color.Blue;
                            }

                        }
                        if (LuuDapAn.Text == btnA.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_a.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnA.BackColor = Color.Red;
                            }
                            else
                            {
                                btnA.BackColor = Color.Blue;
                            }

                        }
                        if (LuuDapAn.Text == btnD.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_d.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnD.BackColor = Color.Red;
                            }
                            else
                            {
                                btnD.BackColor = Color.Blue;
                            }

                        }

                    }
                }
                //Khi chọn D
                if (test == "Ddung")
                {
                    if (LuuDapAn.Text == btnD.Text)
                    {
                        dapan.URL = @Application.StartupPath + @"\Music\true_d.mp3";
                        dapan.controls.play();
                        if (AA % 2 == 0)
                        {
                            btnD.BackColor = Color.Red;

                        }

                        else
                        {
                            btnD.BackColor = Color.Blue;
                        }

                    }
                    else
                    {
                        if (LuuDapAn.Text == btnB.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_b.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnB.BackColor = Color.Red;
                            }
                            else
                            {
                                btnB.BackColor = Color.Blue;
                            }

                        }
                        if (LuuDapAn.Text == btnC.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_c.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnC.BackColor = Color.Red;
                            }
                            else
                            {
                                btnC.BackColor = Color.Blue;
                            }

                        }
                        if (LuuDapAn.Text == btnA.Text)
                        {
                            dapansai.URL = @Application.StartupPath + @"\Music\lose_a.mp3";
                            dapansai.controls.play();
                            if (AA % 2 == 0)
                            {
                                btnA.BackColor = Color.Red;
                            }
                            else
                            {
                                btnA.BackColor = Color.Blue;
                            }

                        }

                    }
                }
            }
            if (AA == 150)
            {
                btnA.BackColor = Color.Blue;
                btnB.BackColor = Color.Blue;
                btnC.BackColor = Color.Blue;
                btnD.BackColor = Color.Blue;
                if (test == "Adung")
                {
                    if (btnA.Text == LuuDapAn.Text)
                    {
                        thongbaodung();
                    }
                    else
                    {
                        thongbaosai();
                    }
                }
                if (test == "Bdung")
                {
                    if (btnB.Text == LuuDapAn.Text)
                    {
                        thongbaodung();
                    }
                    else
                    {
                        thongbaosai();
                    }
                }
                if (test == "Cdung")
                {
                    if (btnC.Text == LuuDapAn.Text)
                    {
                        thongbaodung();
                    }
                    else
                    {
                        thongbaosai();
                    }
                }
                if (test == "Ddung")
                {
                    if (btnD.Text == LuuDapAn.Text)
                    {
                        thongbaodung();
                    }
                    else
                    {
                        thongbaosai();
                    }
                }
                tmdapan.Stop();


            }
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            displaycauhoi(demsocau);
            grbthongbao.Visible = false;
            lbcauhoi.Visible = true;
        }

        //nút nhận thưởng ở grbThongBao thay nút tiếp tục
        private void btnThuong_Click(object sender, EventArgs e)
        {
            dungchoi.URL = @Application.StartupPath + @"\Music\sound_ket_thuc.mp3";
            dungchoi.controls.play();
            TienThuong.Text = lblDiem.Text+" $";
            if (TienThuong.Text.Equals(" $"))
                TienThuong.Text = "0 $";
            grbthongbao.Visible = false;
            grbnhanthuong.Visible = true;
            try
            {
                DateTime now = DateTime.Now;
                data.UpdateThanhTich( int.Parse(lblDiem.Text), now, taikhoan);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            
            trogiup.URL = @Application.StartupPath + @"\Music\sound_trogiup_50_50.mp3";
            trogiup.controls.play();
            btn5050.Visible = false;
            if (LuuDapAn.Text == btnA.Text)
            {
                btnB.Visible = false;
                btnB.Text = "";
                btnC.Visible = false;
                btnC.Text = "";

            }

            if (LuuDapAn.Text == btnB.Text)
            {

                btnA.Visible = false;
                btnA.Text = "";
                btnD.Visible = false;
                btnD.Text = "";

            }

            if (LuuDapAn.Text == btnC.Text)
            {
                btnB.Visible = false;
                btnB.Text = "";
                btnD.Visible = false;
                btnD.Text = "";

            }

            if (LuuDapAn.Text == btnD.Text)
            {

                btnB.Visible = false;
                btnB.Text = "";
                btnA.Visible = false;
                btnA.Text = "";

            }
        }

        private void btngoidien2_Click(object sender, EventArgs e)
        {

            tmkhangia.Stop();
            tmtuvan.Stop();
            tmthoigian.Stop();
            dongho.controls.pause();
            picA.Visible = false;
            picB.Visible = false;
            picC.Visible = false;
            picD.Visible = false;
            pictureBox1.Visible = false;
            picthongtin2.Visible = false;
            pictureBox2.Visible = false;
            btngoidien2.Visible = false;
            thoigiangoidien = 0;
            tmgoidien.Start();
            trogiup.URL = @Application.StartupPath + @"\Music\dongho.wav";
            trogiup.controls.play();
            dongho.controls.pause();
        }
        int thoigiangoidien = 0;
        private void tmgoidien_Tick(object sender, EventArgs e)
        {
            thoigiangoidien++;
            grbdisplaytrogiup.Visible = true;
            lbtrogiup.Visible = true;

            if (thoigiangoidien == 1)
            {
                lbtrogiup.Text = "Hệ thống đang kết nối đến số điện thoại yêu cầu...";
            }
            if (thoigiangoidien == 5)
            {
                lbtrogiup.Text = "-Alo...";
            }
            if (thoigiangoidien == 6)
            {
                lbtrogiup.Text += "\n-Hi, mình đang ở câu hỏi số " + demsocau.ToString() + " và cần bạn trợ giúp";
            }
            if (thoigiangoidien == 9)
            {
                lbtrogiup.Text += "\n-Câu hỏi là:  \n" + lblcauhoi.Text;
            }
            if (thoigiangoidien == 11)
            {
                lbtrogiup.Text += "\nA: " + btnA.Text + "   B: " + btnB.Text + "    C: " + btnC.Text + "    D: " + btnD.Text;
            }
            if (thoigiangoidien == 13)
            {
                lbtrogiup.Text += "\n-Theo mình thì đáp án là " + LuuDapAn.Text;
            }

            if (thoigiangoidien == 15)
            {
                lbtrogiup.Text += "\n-Chắc chắn không?";
            }
            if (thoigiangoidien == 17)
            {
                lbtrogiup.Text = "-Chắc chắn mà, Vì mình gặp câu này 3 lần rồi\n-Cám ơn nhé!?\n-Không có gì!!!";
            }


            if (thoigiangoidien == 21)
            {
                lbtrogiup.Text = "";
                tmgoidien.Stop();
                tmthoigian.Start();
                trogiup.controls.stop();
                dongho.controls.play();
            }
        }
        private void btnkhangia2_Click(object sender, EventArgs e)
        {
            trogiup.URL = @Application.StartupPath + @"\Music\sound_chon_y_kien.mp3";
            trogiup.controls.play();
            tmgoidien.Stop();
            tmtuvan.Stop();
            tmthoigian.Stop();
            dongho.controls.pause();
            picA.Visible = false;
            picB.Visible = false;
            picC.Visible = false;
            picD.Visible = false;
            pictureBox1.Visible = false;
            picthongtin2.Visible = false;
            pictureBox2.Visible = false;
            thoigiankhangia = 0;
            tmkhangia.Start();
            btnkhangia2.Visible = false;
        }
        int thoigiankhangia = 0;
        private void tmkhangia_Tick(object sender, EventArgs e)
        {
            
            thoigiankhangia++;
            grbdisplaytrogiup.Visible = true;
            lbtrogiup.Visible = true;

            lbtrogiup.Text = "Đang lấy ý kiến khán giả trường quay.\n\n";
            

            if (thoigiankhangia > 20)
            {
                if (LuuDapAn.Text == btnA.Text)
                {
                    lbtrogiup.Text += "            \nA:   70%    B:    13%   C:     7%    D:    10%";

                }
                if (LuuDapAn.Text == btnB.Text)
                {
                    lbtrogiup.Text += "         \nA:    5%    B:    60%     C:     25%    D:    10%";

                }
                if (LuuDapAn.Text == btnC.Text)
                {
                    lbtrogiup.Text += "         \nA:   40%     B:    0%     C:     60%     D:    0%";

                }
                if (LuuDapAn.Text == btnD.Text)
                {
                    lbtrogiup.Text += "          \nA:   3%       B:    7%      C:     10%    D:    80%";

                }
            }


            if (thoigiankhangia == 35)
            {
                lbtrogiup.Text = "";
                tmkhangia.Stop();
                tmthoigian.Start();
                trogiup.controls.stop();
                dongho.controls.play();
            }


        }
        private void btntuvan_Click(object sender, EventArgs e)
        {
            trogiup.URL = @Application.StartupPath + @"\Music\sound_trogiup_tuvan.mp3";
            trogiup.controls.play();
            tmthoigian.Stop();
            lbtrogiup.Visible = true;
            picA.Visible = false;
            picB.Visible = false;
            picC.Visible = false;
            picD.Visible = false;
            pictureBox1.Visible = false;
            picthongtin2.Visible = false;
            pictureBox2.Visible = false;
            lbtrogiup.Text = "";
            btntuvan.Visible = false;
            grbdisplaytrogiup.Visible = true;
            tmtv = 0;
            tmtuvan.Start();
            dongho.controls.pause();

        }
        int tmtv = 0;
        private void tmtuvan_Tick(object sender, EventArgs e)
        {
            string dapan = "";
            if (btnA.Text == LuuDapAn.Text)
                dapan = "A";
            if (btnB.Text == LuuDapAn.Text)
                dapan = "B";
            if (btnC.Text == LuuDapAn.Text)
                dapan = "C";
            if (btnD.Text == LuuDapAn.Text)
                dapan = "D";
            tmtv++;
            
            grbdisplaytrogiup.Visible = true;
            if (tmtv == 1)
                lbtrogiup.Text += "\n Chúng tôi xin nhờ tổ tư vấn";
            if (tmtv == 5)
                lbtrogiup.Text += "\nKhán giả A: Tôi xin trợ giúp cho bạn đáp án " + dapan + ". ";
            if (tmtv == 10)
                lbtrogiup.Text += "\nKhán giả B: Tôi chắc chắn với bạn đáp án là " + dapan + ". ";
            if (tmtv == 15)
                lbtrogiup.Text += "\nKhán giả C: Tôi xin trợ giúp cho bạn đáp án " + dapan + ". ";
            if (tmtv == 25)
            {
                lbtrogiup.Text = "";
                grbdisplaytrogiup.Visible = false;
                tmtuvan.Stop();
                tmthoigian.Start();
                trogiup.controls.stop();
                dongho.controls.play();
            }

        }
        //nút dùng chơi trong grbThongBao
        private void btnstop_Click(object sender, EventArgs e)
        {
            dungchoi.URL = @Application.StartupPath + @"\Music\sound_ket_thuc.mp3";
            dungchoi.controls.play();
            TienThuong.Text = lblDiem.Text +" $";
            if (TienThuong.Text.Equals(" $"))
                TienThuong.Text = "0 $";
            grbthongbao.Visible = false;
            grbnhanthuong.Visible = true;

            DateTime now = DateTime.Now;
            data.UpdateThanhTich(int.Parse(lblDiem.Text), now, taikhoan);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            User frmGame = new User();
            frmGame.Show();
            this.Hide();
            mard.Clear(); // dọn danh sách random cũ
        }

        private void GameALTP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            GameALTP frmALTP = new GameALTP();
            frmALTP.Show();
            this.Hide();
            mard.Clear();
        }
    }
}
