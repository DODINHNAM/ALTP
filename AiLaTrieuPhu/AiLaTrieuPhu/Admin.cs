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
    public partial class Admin : Form
    {
        WindowsMediaPlayer chao = new WindowsMediaPlayer();
        public static String name;
        public static String taikhoan;
        public static String q;
        DataProcessing data = new DataProcessing();
        public Admin()
        {
            InitializeComponent();
        }
        int chuchay = 0;
        private void tmchuchay_Tick(object sender, EventArgs e)
        {
            chuchay++;
            lblChaomung.Text = "Chào mừng " + name + " đến với giao diện quản lý";
            btnTaiKhoan.Visible = false;
            btnCauHoi.Visible = false;
            btnChoi.Visible = false;
            btnThoatGame.Visible = false;
            lblChaomung.Left += 18;
            if (chuchay == 60)
            {
                tmchuchay.Stop();
                btnTaiKhoan.Visible = true;
                btnCauHoi.Visible = true;
                btnChoi.Visible = true;
                btnThoatGame.Visible = true;
            }
        }

        private void btnThoatGame_Click(object sender, EventArgs e)
        {
            Main frmALTP = new Main();
            frmALTP.Show();
            this.Hide();
        }

        private void btnChoi_Click(object sender, EventArgs e)
        {
            User.taikhoan = taikhoan;
            User.name = name;
            User frmGame = new User();
            frmGame.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            chao.URL = @Application.StartupPath + @"\Music\begin.wav";
            chao.controls.play();
            tmchuchay.Enabled = true;
            

        }

        private void comboID(DataTable dt)
        {
            cbbID.DataSource = dt;
            cbbID.DisplayMember = "ID";
            cbbID.ValueMember = "ID";
        }

        private void comboQuyen(DataTable dt)
        {
            cbbQuyen.DataSource = dt;
            cbbQuyen.DisplayMember = "Quyen";
            cbbQuyen.ValueMember = "Quyen";
        }

        public void hienTK()
        {
            DataTable dt = new DataTable();
            DataTable dq = new DataTable();
            if (q.Equals("manager"))
            {
                dt = data.ShowTaiKhoan();
                dq = data.ShowQuyen();
            }
            if (q.Equals("admin"))
            {
                dt = data.ShowAllTaiKhoan();
                dq = data.ShowAllQuyen();
            }
            dgvTK.DataSource = dt;
            comboQuyen(dq);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            grbTaiKhoan.Visible = true;
            btnTaiKhoan.Visible = false;
            btnCauHoi.Visible = false;
            btnChoi.Visible = false;
            btnThoatGame.Visible = false;
            hienTK();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            grbTaiKhoan.Visible = false;
            btnTaiKhoan.Visible = true;
            btnCauHoi.Visible = true;
            btnChoi.Visible = true;
            btnThoatGame.Visible = true;
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtTaiKhoan.Text = dgvTK.Rows[row].Cells[0].Value.ToString();
                txtTen.Text = dgvTK.Rows[row].Cells[1].Value.ToString();
                txtMatKhau.Text = dgvTK.Rows[row].Cells[2].Value.ToString();
                txtSDT.Text = dgvTK.Rows[row].Cells[3].Value.ToString();
                cbbQuyen.SelectedValue = dgvTK.Rows[row].Cells[4].Value.ToString();
            }
        }
        private void clearTK()
        {
            txtTen.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtSDT.Clear();
            cbbQuyen.SelectedIndex = 0;

        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String tk = txtTaiKhoan.Text;
                String mk = txtMatKhau.Text;
                String ten = txtTen.Text;
                double sdt = double.Parse(txtSDT.Text);
                if (tk.Equals("") || mk.Equals("") || ten.Equals("") || sdt.Equals(""))
                {
                    MessageBox.Show("Không được để trống thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (cbbQuyen.SelectedIndex == -1)
                    {
                        MessageBox.Show("Chọn Quyền trong comboBox Quyền", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        String quyen = cbbQuyen.SelectedValue.ToString();
                        if (quyen.Equals(q))
                        {
                            MessageBox.Show("Không được thêm tài khoản có quyền bằng mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearTK();
                        }
                        else
                        {
                            if (data.AddTK(tk, ten, mk, sdt, quyen) == true)
                            {
                                hienTK();
                                clearTK();
                            }
                            else
                            {
                                clearTK();
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số điện thoại nhập chữ số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                String tk = txtTaiKhoan.Text;
                String mk = txtMatKhau.Text;
                String ten = txtTen.Text;
                double sdt = double.Parse(txtSDT.Text);
                if (tk.Equals("") || mk.Equals("") || ten.Equals("") || sdt.Equals(""))
                {
                    MessageBox.Show("Không được để trống thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (cbbQuyen.SelectedIndex == -1)
                    {
                        MessageBox.Show("Chọn Quyền trong comboBox Quyền", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        String quyen = cbbQuyen.SelectedValue.ToString();
                        if (quyen.Equals(q))
                        {
                            MessageBox.Show("Không được sửa tài khoản có quyền bằng mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearTK();
                        }
                        else
                        {
                            if (data.EditTK(tk, ten, mk, sdt, quyen) == true)
                            {
                                hienTK();
                                clearTK();
                            }
                            else
                            {
                                clearTK();
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số điện thoại nhập chữ số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String tk = txtTaiKhoan.Text;
            if (tk.Equals(""))
            {
                MessageBox.Show("Tài khoản không được để trống thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String quyen = data.GetQuyen(tk);
                if (quyen.Equals(q))
                {
                    MessageBox.Show("Không được xóa tài khoản có quyền bằng mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTK();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (data.DelTK(tk) == true)
                        {
                            hienTK();
                            clearTK();
                        }
                        else
                        {
                            clearTK();
                        }
                    }
                }   
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void hienCH()
        {
            DataTable dt = new DataTable();
            if (q.Equals("manager"))
            {
                dt = data.ShowCauHoi(taikhoan);
            }
            if (q.Equals("admin"))
            {
                dt = data.ShowAllCauHoi();
            }
            dgvCH.DataSource = dt;
            comboID(dt);
        }

        private void btnCauHoi_Click(object sender, EventArgs e)
        {
            grbCauHoi.Visible = true;
            btnTaiKhoan.Visible = false;
            btnCauHoi.Visible = false;
            btnChoi.Visible = false;
            btnThoatGame.Visible = false;
            hienCH();
           
        }

        private void btnBackCH_Click(object sender, EventArgs e)
        {
            grbCauHoi.Visible = false;
            btnTaiKhoan.Visible = true;
            btnCauHoi.Visible = true;
            btnChoi.Visible = true;
            btnThoatGame.Visible = true;
        }

        private void dgvCH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                cbbID.SelectedValue = dgvCH.Rows[row].Cells[0].Value.ToString();
                txtCauHoi.Text = dgvCH.Rows[row].Cells[1].Value.ToString();
                txtA.Text = dgvCH.Rows[row].Cells[2].Value.ToString();
                txtB.Text = dgvCH.Rows[row].Cells[3].Value.ToString();
                txtC.Text = dgvCH.Rows[row].Cells[4].Value.ToString();
                txtD.Text = dgvCH.Rows[row].Cells[5].Value.ToString();
                txtDapAn.Text = dgvCH.Rows[row].Cells[6].Value.ToString();
                txtTacGia.Text = dgvCH.Rows[row].Cells[7].Value.ToString();
            }
        }

        private void clearCH()
        {
            txtCauHoi.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtD.Clear();
            txtDapAn.Clear();
            cbbID.SelectedIndex = 0;
        }
        private void btnThemCH_Click(object sender, EventArgs e)
        {
            String ch = txtCauHoi.Text;
            String a = txtA.Text;
            String b = txtB.Text;
            String c = txtC.Text;
            String d = txtD.Text;
            String da = txtDapAn.Text;
            if (ch.Equals("") || a.Equals("") || b.Equals("") || c.Equals("") || d.Equals("") || da.Equals(""))
            {
                MessageBox.Show("Không được để trống thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!da.Equals(a) && !da.Equals(b) && !da.Equals(c) && !da.Equals(d))
                {
                    MessageBox.Show("Đáp án phải trùng với 1 trong 4 đáp án ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (data.AddCH(ch, a, b, c, d, da, taikhoan) == true)
                    {
                        hienCH();
                        clearCH();
                    }
                    else
                    {
                        clearCH();
                    }
                }
            }
        }

        private void btnSuaCH_Click(object sender, EventArgs e)
        {
            if (cbbID.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn ID trong ComboBox ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(cbbID.SelectedValue.ToString());
                String ch = txtCauHoi.Text;
                String a = txtA.Text;
                String b = txtB.Text;
                String c = txtC.Text;
                String d = txtD.Text;
                String da = txtDapAn.Text;
                if (ch.Equals("") || a.Equals("") || b.Equals("") || c.Equals("") || d.Equals("") || da.Equals(""))
                {
                    MessageBox.Show("Không được để trống thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!da.Equals(a) && !da.Equals(b) && !da.Equals(c) && !da.Equals(d))
                    {
                        MessageBox.Show("Đáp án phải trùng với 1 trong 4 đáp án ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (data.EditCH(id, ch, a, b, c, d, da, taikhoan) == true)
                        {
                            hienCH();
                            clearCH();
                        }
                        else
                        {
                            clearCH();
                        }
                    }
                }
            }
        }

        private void btnXoaCH_Click(object sender, EventArgs e)
        {
            if (cbbID.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn ID trong ComboBox ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(cbbID.SelectedValue.ToString());
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa câu hỏi này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    if (data.DelCH(id) == true)
                    {
                        hienCH();
                        clearCH();
                    }
                    else
                    {
                        clearCH();
                    }
                }
            }
        }
    } 
}
