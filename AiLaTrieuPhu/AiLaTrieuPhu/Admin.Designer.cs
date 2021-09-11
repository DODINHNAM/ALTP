
namespace AiLaTrieuPhu
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnThoatGame = new System.Windows.Forms.Button();
            this.btnChoi = new System.Windows.Forms.Button();
            this.btnCauHoi = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.lblChaomung = new System.Windows.Forms.Label();
            this.tmchuchay = new System.Windows.Forms.Timer(this.components);
            this.grbTaiKhoan = new System.Windows.Forms.GroupBox();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTaikhoan = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBackCH = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtDapAn = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.dgvCH = new System.Windows.Forms.DataGridView();
            this.btnThemCH = new System.Windows.Forms.Button();
            this.btnSuaCH = new System.Windows.Forms.Button();
            this.btnXoaCH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.grbCauHoi = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCH)).BeginInit();
            this.grbCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoatGame
            // 
            this.btnThoatGame.BackColor = System.Drawing.Color.Red;
            this.btnThoatGame.Location = new System.Drawing.Point(942, 608);
            this.btnThoatGame.Name = "btnThoatGame";
            this.btnThoatGame.Size = new System.Drawing.Size(140, 67);
            this.btnThoatGame.TabIndex = 8;
            this.btnThoatGame.Tag = "4";
            this.btnThoatGame.Text = "Đăng xuất";
            this.btnThoatGame.UseVisualStyleBackColor = false;
            this.btnThoatGame.Visible = false;
            this.btnThoatGame.Click += new System.EventHandler(this.btnThoatGame_Click);
            // 
            // btnChoi
            // 
            this.btnChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnChoi.Location = new System.Drawing.Point(729, 608);
            this.btnChoi.Name = "btnChoi";
            this.btnChoi.Size = new System.Drawing.Size(140, 67);
            this.btnChoi.TabIndex = 7;
            this.btnChoi.Tag = "3";
            this.btnChoi.Text = "Chơi game";
            this.btnChoi.UseVisualStyleBackColor = false;
            this.btnChoi.Visible = false;
            this.btnChoi.Click += new System.EventHandler(this.btnChoi_Click);
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCauHoi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCauHoi.Location = new System.Drawing.Point(522, 608);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.Size = new System.Drawing.Size(140, 67);
            this.btnCauHoi.TabIndex = 6;
            this.btnCauHoi.Tag = "2";
            this.btnCauHoi.Text = "Quản lý Câu hỏi";
            this.btnCauHoi.UseVisualStyleBackColor = false;
            this.btnCauHoi.Visible = false;
            this.btnCauHoi.Click += new System.EventHandler(this.btnCauHoi_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTaiKhoan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnTaiKhoan.Location = new System.Drawing.Point(341, 608);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(126, 67);
            this.btnTaiKhoan.TabIndex = 5;
            this.btnTaiKhoan.Tag = "1";
            this.btnTaiKhoan.Text = "Quản lý Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Visible = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // lblChaomung
            // 
            this.lblChaomung.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblChaomung.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChaomung.ForeColor = System.Drawing.Color.White;
            this.lblChaomung.Location = new System.Drawing.Point(-1, -1);
            this.lblChaomung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChaomung.Name = "lblChaomung";
            this.lblChaomung.Size = new System.Drawing.Size(1371, 79);
            this.lblChaomung.TabIndex = 9;
            this.lblChaomung.Text = "Chào mừng bạn đến với chương trình ai là triệu phú";
            this.lblChaomung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmchuchay
            // 
            this.tmchuchay.Interval = 60;
            this.tmchuchay.Tick += new System.EventHandler(this.tmchuchay_Tick);
            // 
            // grbTaiKhoan
            // 
            this.grbTaiKhoan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.grbTaiKhoan.Controls.Add(this.cbbQuyen);
            this.grbTaiKhoan.Controls.Add(this.btnXoa);
            this.grbTaiKhoan.Controls.Add(this.btnSua);
            this.grbTaiKhoan.Controls.Add(this.btnThem);
            this.grbTaiKhoan.Controls.Add(this.dgvTK);
            this.grbTaiKhoan.Controls.Add(this.txtSDT);
            this.grbTaiKhoan.Controls.Add(this.txtMatKhau);
            this.grbTaiKhoan.Controls.Add(this.txtTen);
            this.grbTaiKhoan.Controls.Add(this.txtTaiKhoan);
            this.grbTaiKhoan.Controls.Add(this.label13);
            this.grbTaiKhoan.Controls.Add(this.label4);
            this.grbTaiKhoan.Controls.Add(this.label3);
            this.grbTaiKhoan.Controls.Add(this.label2);
            this.grbTaiKhoan.Controls.Add(this.lblTaikhoan);
            this.grbTaiKhoan.Controls.Add(this.btnQuayLai);
            this.grbTaiKhoan.Controls.Add(this.label1);
            this.grbTaiKhoan.Location = new System.Drawing.Point(137, 89);
            this.grbTaiKhoan.Name = "grbTaiKhoan";
            this.grbTaiKhoan.Size = new System.Drawing.Size(1108, 478);
            this.grbTaiKhoan.TabIndex = 10;
            this.grbTaiKhoan.TabStop = false;
            this.grbTaiKhoan.Visible = false;
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Location = new System.Drawing.Point(270, 206);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(187, 24);
            this.cbbQuyen.TabIndex = 13;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(854, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 35);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(729, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 35);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(602, 206);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 35);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvTK
            // 
            this.dgvTK.AllowUserToAddRows = false;
            this.dgvTK.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaiKhoan,
            this.Ten,
            this.MatKhau,
            this.SoDT,
            this.Quyen});
            this.dgvTK.Location = new System.Drawing.Point(82, 247);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 24;
            this.dgvTK.Size = new System.Drawing.Size(903, 150);
            this.dgvTK.TabIndex = 9;
            this.dgvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellClick);
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "Tài khoản";
            this.TaiKhoan.MinimumWidth = 6;
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Width = 150;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên khách";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 160;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 120;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.Width = 120;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            this.Quyen.Width = 50;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(760, 158);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(187, 22);
            this.txtSDT.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(270, 162);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(187, 22);
            this.txtMatKhau.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(760, 105);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 22);
            this.txtTen.TabIndex = 8;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(270, 109);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(187, 22);
            this.txtTaiKhoan.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(106, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "Quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khách";
            // 
            // lblTaikhoan
            // 
            this.lblTaikhoan.AutoSize = true;
            this.lblTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaikhoan.Location = new System.Drawing.Point(106, 109);
            this.lblTaikhoan.Name = "lblTaikhoan";
            this.lblTaikhoan.Size = new System.Drawing.Size(108, 25);
            this.lblTaikhoan.TabIndex = 7;
            this.lblTaikhoan.Text = "Tài khoản";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Red;
            this.btnQuayLai.Location = new System.Drawing.Point(506, 424);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(93, 48);
            this.btnQuayLai.TabIndex = 6;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(387, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(374, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 51);
            this.label9.TabIndex = 5;
            this.label9.Text = "Quản lý câu hỏi";
            // 
            // btnBackCH
            // 
            this.btnBackCH.BackColor = System.Drawing.Color.Red;
            this.btnBackCH.Location = new System.Drawing.Point(507, 414);
            this.btnBackCH.Name = "btnBackCH";
            this.btnBackCH.Size = new System.Drawing.Size(93, 48);
            this.btnBackCH.TabIndex = 6;
            this.btnBackCH.Text = "Quay lại";
            this.btnBackCH.UseVisualStyleBackColor = false;
            this.btnBackCH.Click += new System.EventHandler(this.btnBackCH_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(83, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Đáp án";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "C";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(427, 161);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(154, 22);
            this.txtA.TabIndex = 8;
            // 
            // txtDapAn
            // 
            this.txtDapAn.Location = new System.Drawing.Point(185, 208);
            this.txtDapAn.Name = "txtDapAn";
            this.txtDapAn.Size = new System.Drawing.Size(118, 22);
            this.txtDapAn.TabIndex = 8;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(427, 207);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(154, 22);
            this.txtC.TabIndex = 8;
            // 
            // dgvCH
            // 
            this.dgvCH.AllowUserToAddRows = false;
            this.dgvCH.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CauHoi,
            this.A,
            this.B,
            this.C,
            this.D,
            this.DapAn,
            this.tk});
            this.dgvCH.Location = new System.Drawing.Point(82, 247);
            this.dgvCH.Name = "dgvCH";
            this.dgvCH.RowHeadersWidth = 51;
            this.dgvCH.RowTemplate.Height = 24;
            this.dgvCH.Size = new System.Drawing.Size(933, 161);
            this.dgvCH.TabIndex = 9;
            this.dgvCH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCH_CellClick);
            // 
            // btnThemCH
            // 
            this.btnThemCH.BackColor = System.Drawing.Color.White;
            this.btnThemCH.Location = new System.Drawing.Point(922, 77);
            this.btnThemCH.Name = "btnThemCH";
            this.btnThemCH.Size = new System.Drawing.Size(93, 35);
            this.btnThemCH.TabIndex = 10;
            this.btnThemCH.Text = "Thêm";
            this.btnThemCH.UseVisualStyleBackColor = false;
            this.btnThemCH.Click += new System.EventHandler(this.btnThemCH_Click);
            // 
            // btnSuaCH
            // 
            this.btnSuaCH.BackColor = System.Drawing.Color.White;
            this.btnSuaCH.Location = new System.Drawing.Point(922, 145);
            this.btnSuaCH.Name = "btnSuaCH";
            this.btnSuaCH.Size = new System.Drawing.Size(93, 35);
            this.btnSuaCH.TabIndex = 10;
            this.btnSuaCH.Text = "Sửa";
            this.btnSuaCH.UseVisualStyleBackColor = false;
            this.btnSuaCH.Click += new System.EventHandler(this.btnSuaCH_Click);
            // 
            // btnXoaCH
            // 
            this.btnXoaCH.BackColor = System.Drawing.Color.White;
            this.btnXoaCH.Location = new System.Drawing.Point(922, 204);
            this.btnXoaCH.Name = "btnXoaCH";
            this.btnXoaCH.Size = new System.Drawing.Size(93, 35);
            this.btnXoaCH.TabIndex = 10;
            this.btnXoaCH.Text = "Xóa";
            this.btnXoaCH.UseVisualStyleBackColor = false;
            this.btnXoaCH.Click += new System.EventHandler(this.btnXoaCH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // cbbID
            // 
            this.cbbID.FormattingEnabled = true;
            this.cbbID.Location = new System.Drawing.Point(185, 162);
            this.cbbID.Name = "cbbID";
            this.cbbID.Size = new System.Drawing.Size(118, 24);
            this.cbbID.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(662, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "B";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(662, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "D";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(711, 162);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(174, 22);
            this.txtB.TabIndex = 14;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(711, 208);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(174, 22);
            this.txtD.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(83, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Câu hỏi";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Location = new System.Drawing.Point(185, 77);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(396, 75);
            this.txtCauHoi.TabIndex = 16;
            // 
            // grbCauHoi
            // 
            this.grbCauHoi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.grbCauHoi.Controls.Add(this.label14);
            this.grbCauHoi.Controls.Add(this.txtCauHoi);
            this.grbCauHoi.Controls.Add(this.label12);
            this.grbCauHoi.Controls.Add(this.txtD);
            this.grbCauHoi.Controls.Add(this.txtTacGia);
            this.grbCauHoi.Controls.Add(this.txtB);
            this.grbCauHoi.Controls.Add(this.label10);
            this.grbCauHoi.Controls.Add(this.label6);
            this.grbCauHoi.Controls.Add(this.cbbID);
            this.grbCauHoi.Controls.Add(this.label5);
            this.grbCauHoi.Controls.Add(this.btnXoaCH);
            this.grbCauHoi.Controls.Add(this.btnSuaCH);
            this.grbCauHoi.Controls.Add(this.btnThemCH);
            this.grbCauHoi.Controls.Add(this.dgvCH);
            this.grbCauHoi.Controls.Add(this.txtC);
            this.grbCauHoi.Controls.Add(this.txtDapAn);
            this.grbCauHoi.Controls.Add(this.txtA);
            this.grbCauHoi.Controls.Add(this.label7);
            this.grbCauHoi.Controls.Add(this.label11);
            this.grbCauHoi.Controls.Add(this.label8);
            this.grbCauHoi.Controls.Add(this.btnBackCH);
            this.grbCauHoi.Controls.Add(this.label9);
            this.grbCauHoi.Location = new System.Drawing.Point(137, 83);
            this.grbCauHoi.Name = "grbCauHoi";
            this.grbCauHoi.Size = new System.Drawing.Size(1111, 478);
            this.grbCauHoi.TabIndex = 12;
            this.grbCauHoi.TabStop = false;
            this.grbCauHoi.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(605, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "Tác giả";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Enabled = false;
            this.txtTacGia.Location = new System.Drawing.Point(711, 104);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(174, 22);
            this.txtTacGia.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 40;
            // 
            // CauHoi
            // 
            this.CauHoi.DataPropertyName = "CauHoi";
            this.CauHoi.HeaderText = "Câu hỏi";
            this.CauHoi.MinimumWidth = 6;
            this.CauHoi.Name = "CauHoi";
            this.CauHoi.Width = 200;
            // 
            // A
            // 
            this.A.DataPropertyName = "A";
            this.A.HeaderText = "Đáp án A";
            this.A.MinimumWidth = 6;
            this.A.Name = "A";
            this.A.Width = 125;
            // 
            // B
            // 
            this.B.DataPropertyName = "B";
            this.B.HeaderText = "Đáp án B";
            this.B.MinimumWidth = 6;
            this.B.Name = "B";
            this.B.Width = 125;
            // 
            // C
            // 
            this.C.DataPropertyName = "C";
            this.C.HeaderText = "Đáp án C";
            this.C.MinimumWidth = 6;
            this.C.Name = "C";
            this.C.Width = 125;
            // 
            // D
            // 
            this.D.DataPropertyName = "D";
            this.D.HeaderText = "Đáp án D";
            this.D.MinimumWidth = 6;
            this.D.Name = "D";
            this.D.Width = 125;
            // 
            // DapAn
            // 
            this.DapAn.DataPropertyName = "DapAn";
            this.DapAn.HeaderText = "Đáp án đúng";
            this.DapAn.MinimumWidth = 6;
            this.DapAn.Name = "DapAn";
            this.DapAn.Width = 125;
            // 
            // tk
            // 
            this.tk.DataPropertyName = "TaiKhoan";
            this.tk.HeaderText = "Tác giả";
            this.tk.MinimumWidth = 6;
            this.tk.Name = "tk";
            this.tk.Width = 125;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1369, 729);
            this.Controls.Add(this.grbCauHoi);
            this.Controls.Add(this.grbTaiKhoan);
            this.Controls.Add(this.lblChaomung);
            this.Controls.Add(this.btnThoatGame);
            this.Controls.Add(this.btnChoi);
            this.Controls.Add(this.btnCauHoi);
            this.Controls.Add(this.btnTaiKhoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.grbTaiKhoan.ResumeLayout(false);
            this.grbTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCH)).EndInit();
            this.grbCauHoi.ResumeLayout(false);
            this.grbCauHoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoatGame;
        private System.Windows.Forms.Button btnChoi;
        private System.Windows.Forms.Button btnCauHoi;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Label lblChaomung;
        private System.Windows.Forms.Timer tmchuchay;
        private System.Windows.Forms.GroupBox grbTaiKhoan;
        private System.Windows.Forms.Label lblTaikhoan;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBackCH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtDapAn;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.DataGridView dgvCH;
        private System.Windows.Forms.Button btnThemCH;
        private System.Windows.Forms.Button btnSuaCH;
        private System.Windows.Forms.Button btnXoaCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.GroupBox grbCauHoi;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk;
    }
}