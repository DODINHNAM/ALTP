
namespace AiLaTrieuPhu
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.lbchaomung2 = new System.Windows.Forms.Label();
            this.btnThoatGame = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.tmchuchay = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.btnOutLS = new System.Windows.Forms.Button();
            this.grbLichSu = new System.Windows.Forms.GroupBox();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbHuongDan = new System.Windows.Forms.GroupBox();
            this.lbtexthuongdan = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tmhuongdan = new System.Windows.Forms.Timer(this.components);
            this.grbLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.grbHuongDan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbchaomung2
            // 
            this.lbchaomung2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbchaomung2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchaomung2.ForeColor = System.Drawing.Color.White;
            this.lbchaomung2.Location = new System.Drawing.Point(-2, -1);
            this.lbchaomung2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbchaomung2.Name = "lbchaomung2";
            this.lbchaomung2.Size = new System.Drawing.Size(1371, 79);
            this.lbchaomung2.TabIndex = 8;
            this.lbchaomung2.Text = "Chào mừng bạn đến với chương trình ai là triệu phú";
            this.lbchaomung2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoatGame
            // 
            this.btnThoatGame.BackColor = System.Drawing.Color.Red;
            this.btnThoatGame.Location = new System.Drawing.Point(945, 617);
            this.btnThoatGame.Name = "btnThoatGame";
            this.btnThoatGame.Size = new System.Drawing.Size(140, 67);
            this.btnThoatGame.TabIndex = 4;
            this.btnThoatGame.Text = "Đăng xuất";
            this.btnThoatGame.UseVisualStyleBackColor = false;
            this.btnThoatGame.Visible = false;
            this.btnThoatGame.Click += new System.EventHandler(this.btnThoatGame_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLichSu.Location = new System.Drawing.Point(732, 617);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(140, 67);
            this.btnLichSu.TabIndex = 3;
            this.btnLichSu.Text = "Lịch sử";
            this.btnLichSu.UseVisualStyleBackColor = false;
            this.btnLichSu.Visible = false;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHuongDan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnHuongDan.Location = new System.Drawing.Point(525, 617);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(140, 67);
            this.btnHuongDan.TabIndex = 2;
            this.btnHuongDan.Text = "Hướng dẫn";
            this.btnHuongDan.UseVisualStyleBackColor = false;
            this.btnHuongDan.Visible = false;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBatDau.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBatDau.Location = new System.Drawing.Point(344, 617);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(126, 67);
            this.btnBatDau.TabIndex = 1;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Visible = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // tmchuchay
            // 
            this.tmchuchay.Interval = 60;
            this.tmchuchay.Tick += new System.EventHandler(this.tmchuchay_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(175, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(353, 51);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lịch sử gần nhất";
            // 
            // btnOutLS
            // 
            this.btnOutLS.BackColor = System.Drawing.Color.Red;
            this.btnOutLS.Location = new System.Drawing.Point(298, 401);
            this.btnOutLS.Name = "btnOutLS";
            this.btnOutLS.Size = new System.Drawing.Size(93, 48);
            this.btnOutLS.TabIndex = 3;
            this.btnOutLS.Text = "Thoát";
            this.btnOutLS.UseVisualStyleBackColor = false;
            this.btnOutLS.Click += new System.EventHandler(this.btnOutLS_Click);
            // 
            // grbLichSu
            // 
            this.grbLichSu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.grbLichSu.Controls.Add(this.dgvLichSu);
            this.grbLichSu.Controls.Add(this.btnOutLS);
            this.grbLichSu.Controls.Add(this.label9);
            this.grbLichSu.Location = new System.Drawing.Point(344, 92);
            this.grbLichSu.Name = "grbLichSu";
            this.grbLichSu.Size = new System.Drawing.Size(741, 478);
            this.grbLichSu.TabIndex = 13;
            this.grbLichSu.TabStop = false;
            this.grbLichSu.Visible = false;
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToResizeColumns = false;
            this.dgvLichSu.AllowUserToResizeRows = false;
            this.dgvLichSu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLichSu.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvLichSu.ColumnHeadersHeight = 29;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Diem,
            this.NgayChoi});
            this.dgvLichSu.Location = new System.Drawing.Point(0, 72);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLichSu.RowTemplate.Height = 24;
            this.dgvLichSu.Size = new System.Drawing.Size(741, 323);
            this.dgvLichSu.TabIndex = 4;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ten.Width = 150;
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "Diem";
            this.Diem.HeaderText = "Điểm";
            this.Diem.MinimumWidth = 6;
            this.Diem.Name = "Diem";
            this.Diem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Diem.Width = 120;
            // 
            // NgayChoi
            // 
            this.NgayChoi.DataPropertyName = "NgayChoi";
            this.NgayChoi.HeaderText = "Ngày Chơi";
            this.NgayChoi.MinimumWidth = 6;
            this.NgayChoi.Name = "NgayChoi";
            this.NgayChoi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NgayChoi.Width = 231;
            // 
            // grbHuongDan
            // 
            this.grbHuongDan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.grbHuongDan.Controls.Add(this.lbtexthuongdan);
            this.grbHuongDan.Controls.Add(this.btnQuayLai);
            this.grbHuongDan.Controls.Add(this.label1);
            this.grbHuongDan.Location = new System.Drawing.Point(344, 92);
            this.grbHuongDan.Name = "grbHuongDan";
            this.grbHuongDan.Size = new System.Drawing.Size(741, 478);
            this.grbHuongDan.TabIndex = 5;
            this.grbHuongDan.TabStop = false;
            this.grbHuongDan.Visible = false;
            // 
            // lbtexthuongdan
            // 
            this.lbtexthuongdan.AutoSize = true;
            this.lbtexthuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtexthuongdan.Location = new System.Drawing.Point(77, 109);
            this.lbtexthuongdan.Name = "lbtexthuongdan";
            this.lbtexthuongdan.Size = new System.Drawing.Size(117, 25);
            this.lbtexthuongdan.TabIndex = 7;
            this.lbtexthuongdan.Text = "Hướng dẫn";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Red;
            this.btnQuayLai.Location = new System.Drawing.Point(335, 401);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(93, 48);
            this.btnQuayLai.TabIndex = 6;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(202, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hướng dẫn chơi";
            // 
            // tmhuongdan
            // 
            this.tmhuongdan.Tick += new System.EventHandler(this.tmhuongdan_Tick);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1369, 728);
            this.Controls.Add(this.grbHuongDan);
            this.Controls.Add(this.grbLichSu);
            this.Controls.Add(this.btnThoatGame);
            this.Controls.Add(this.btnLichSu);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.lbchaomung2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ai Là Triệu Phú";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.grbLichSu.ResumeLayout(false);
            this.grbLichSu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.grbHuongDan.ResumeLayout(false);
            this.grbHuongDan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbchaomung2;
        private System.Windows.Forms.Button btnThoatGame;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Timer tmchuchay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOutLS;
        private System.Windows.Forms.GroupBox grbLichSu;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Timer tmhuongdan;
        private System.Windows.Forms.GroupBox grbHuongDan;
        private System.Windows.Forms.Label lbtexthuongdan;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChoi;
    }
}