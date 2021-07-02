namespace QLSANBONG
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPTH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ThemPTH = new System.Windows.Forms.Button();
            this.btn_ThemTT = new System.Windows.Forms.Button();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_Chinh = new System.Windows.Forms.DataGridView();
            this.LDQH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_CBC = new System.Windows.Forms.Button();
            this.btn_C3 = new System.Windows.Forms.Button();
            this.btn_C2 = new System.Windows.Forms.Button();
            this.btn_TimKhoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Chinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phụ thuộc hàm";
            // 
            // txtPTH
            // 
            this.txtPTH.Location = new System.Drawing.Point(230, 94);
            this.txtPTH.Name = "txtPTH";
            this.txtPTH.Size = new System.Drawing.Size(723, 34);
            this.txtPTH.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ThemPTH);
            this.groupBox1.Controls.Add(this.btn_ThemTT);
            this.groupBox1.Controls.Add(this.txtTT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPTH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_ThemPTH
            // 
            this.btn_ThemPTH.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_ThemPTH.Location = new System.Drawing.Point(959, 94);
            this.btn_ThemPTH.Name = "btn_ThemPTH";
            this.btn_ThemPTH.Size = new System.Drawing.Size(92, 34);
            this.btn_ThemPTH.TabIndex = 5;
            this.btn_ThemPTH.Text = "Thêm";
            this.btn_ThemPTH.UseVisualStyleBackColor = false;
            this.btn_ThemPTH.Click += new System.EventHandler(this.btn_ThemPTH_Click);
            // 
            // btn_ThemTT
            // 
            this.btn_ThemTT.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_ThemTT.Location = new System.Drawing.Point(959, 40);
            this.btn_ThemTT.Name = "btn_ThemTT";
            this.btn_ThemTT.Size = new System.Drawing.Size(92, 34);
            this.btn_ThemTT.TabIndex = 4;
            this.btn_ThemTT.Text = "Thêm";
            this.btn_ThemTT.UseVisualStyleBackColor = false;
            this.btn_ThemTT.Click += new System.EventHandler(this.btn_ThemTT_Click);
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(230, 40);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(723, 34);
            this.txtTT.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập thuộc tính";
            // 
            // grid_Chinh
            // 
            this.grid_Chinh.AllowUserToAddRows = false;
            this.grid_Chinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Chinh.BackgroundColor = System.Drawing.Color.White;
            this.grid_Chinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Chinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LDQH,
            this.TT,
            this.PTH,
            this.Khoa});
            this.grid_Chinh.Location = new System.Drawing.Point(6, 21);
            this.grid_Chinh.Name = "grid_Chinh";
            this.grid_Chinh.RowTemplate.Height = 24;
            this.grid_Chinh.Size = new System.Drawing.Size(1044, 235);
            this.grid_Chinh.TabIndex = 3;
            // 
            // LDQH
            // 
            this.LDQH.DataPropertyName = "LDQH";
            this.LDQH.HeaderText = "Lược đồ quan hệ";
            this.LDQH.Name = "LDQH";
            // 
            // TT
            // 
            this.TT.DataPropertyName = "TT";
            this.TT.HeaderText = "Thuộc tính";
            this.TT.Name = "TT";
            // 
            // PTH
            // 
            this.PTH.DataPropertyName = "PTH";
            this.PTH.HeaderText = "PTH";
            this.PTH.Name = "PTH";
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khoá";
            this.Khoa.Name = "Khoa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_CBC);
            this.groupBox2.Controls.Add(this.btn_C3);
            this.groupBox2.Controls.Add(this.btn_C2);
            this.groupBox2.Controls.Add(this.btn_TimKhoa);
            this.groupBox2.Controls.Add(this.grid_Chinh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1056, 324);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btn_CBC
            // 
            this.btn_CBC.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_CBC.Location = new System.Drawing.Point(916, 272);
            this.btn_CBC.Name = "btn_CBC";
            this.btn_CBC.Size = new System.Drawing.Size(132, 43);
            this.btn_CBC.TabIndex = 7;
            this.btn_CBC.Text = "Chuẩn BC";
            this.btn_CBC.UseVisualStyleBackColor = false;
            this.btn_CBC.Click += new System.EventHandler(this.btn_CBC_Click);
            // 
            // btn_C3
            // 
            this.btn_C3.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_C3.Location = new System.Drawing.Point(616, 272);
            this.btn_C3.Name = "btn_C3";
            this.btn_C3.Size = new System.Drawing.Size(123, 43);
            this.btn_C3.TabIndex = 6;
            this.btn_C3.Text = "Chuẩn 3";
            this.btn_C3.UseVisualStyleBackColor = false;
            this.btn_C3.Click += new System.EventHandler(this.btn_C3_Click);
            // 
            // btn_C2
            // 
            this.btn_C2.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_C2.Location = new System.Drawing.Point(310, 272);
            this.btn_C2.Name = "btn_C2";
            this.btn_C2.Size = new System.Drawing.Size(129, 43);
            this.btn_C2.TabIndex = 5;
            this.btn_C2.Text = "Chuẩn 2";
            this.btn_C2.UseVisualStyleBackColor = false;
            this.btn_C2.Click += new System.EventHandler(this.btn_C2_Click);
            // 
            // btn_TimKhoa
            // 
            this.btn_TimKhoa.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_TimKhoa.Location = new System.Drawing.Point(6, 272);
            this.btn_TimKhoa.Name = "btn_TimKhoa";
            this.btn_TimKhoa.Size = new System.Drawing.Size(127, 43);
            this.btn_TimKhoa.TabIndex = 4;
            this.btn_TimKhoa.Text = "Tìm khoá";
            this.btn_TimKhoa.UseVisualStyleBackColor = false;
            this.btn_TimKhoa.Click += new System.EventHandler(this.btn_TimKhoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1081, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra CSDL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Chinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPTH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ThemPTH;
        private System.Windows.Forms.Button btn_ThemTT;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_Chinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TimKhoa;
        private System.Windows.Forms.Button btn_CBC;
        private System.Windows.Forms.Button btn_C3;
        private System.Windows.Forms.Button btn_C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LDQH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
    }
}

