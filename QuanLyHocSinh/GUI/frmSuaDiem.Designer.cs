namespace QuanLy.GUI
{
    partial class frmSuaDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaDiem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.txtChuyenCan = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtCuoiKi = new System.Windows.Forms.TextBox();
            this.btnSuaDiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtTBM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiuaKi = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuyên cần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giữa kì";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cuối kì";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(116, 66);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.ReadOnly = true;
            this.txtMaHS.Size = new System.Drawing.Size(99, 21);
            this.txtMaHS.TabIndex = 6;
            // 
            // txtChuyenCan
            // 
            this.txtChuyenCan.Location = new System.Drawing.Point(116, 99);
            this.txtChuyenCan.Name = "txtChuyenCan";
            this.txtChuyenCan.Size = new System.Drawing.Size(99, 21);
            this.txtChuyenCan.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 21);
            this.textBox3.TabIndex = 8;
            // 
            // txtCuoiKi
            // 
            this.txtCuoiKi.Location = new System.Drawing.Point(308, 99);
            this.txtCuoiKi.Name = "txtCuoiKi";
            this.txtCuoiKi.Size = new System.Drawing.Size(93, 21);
            this.txtCuoiKi.TabIndex = 9;
            // 
            // btnSuaDiem
            // 
            this.btnSuaDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDiem.ImageOptions.Image")));
            this.btnSuaDiem.Location = new System.Drawing.Point(116, 183);
            this.btnSuaDiem.Name = "btnSuaDiem";
            this.btnSuaDiem.Size = new System.Drawing.Size(39, 37);
            this.btnSuaDiem.TabIndex = 10;
            this.btnSuaDiem.Click += new System.EventHandler(this.btnSuaDiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(174, 183);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 37);
            this.btnThoat.TabIndex = 11;
            // 
            // txtTBM
            // 
            this.txtTBM.Location = new System.Drawing.Point(308, 137);
            this.txtTBM.Name = "txtTBM";
            this.txtTBM.ReadOnly = true;
            this.txtTBM.Size = new System.Drawing.Size(93, 21);
            this.txtTBM.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Trung bình môn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "SỬA ĐIỂM";
            // 
            // txtGiuaKi
            // 
            this.txtGiuaKi.Location = new System.Drawing.Point(116, 137);
            this.txtGiuaKi.Name = "txtGiuaKi";
            this.txtGiuaKi.Size = new System.Drawing.Size(99, 21);
            this.txtGiuaKi.TabIndex = 8;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(308, 66);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(93, 21);
            this.txtMaLop.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã lớp";
            // 
            // frmSuaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 235);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTBM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSuaDiem);
            this.Controls.Add(this.txtCuoiKi);
            this.Controls.Add(this.txtGiuaKi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtChuyenCan);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSuaDiem";
            this.Text = "Sửa điểm";
            this.Load += new System.EventHandler(this.frmSuaDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMaHS;
        public System.Windows.Forms.TextBox txtChuyenCan;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox txtCuoiKi;
        public DevExpress.XtraEditors.SimpleButton btnSuaDiem;
        public DevExpress.XtraEditors.SimpleButton btnThoat;
        public System.Windows.Forms.TextBox txtTBM;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtGiuaKi;
        public System.Windows.Forms.TextBox txtMaLop;
        public System.Windows.Forms.Label label7;
    }
}