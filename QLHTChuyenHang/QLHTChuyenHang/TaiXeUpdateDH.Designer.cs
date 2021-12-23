
namespace QLHTChuyenHang
{
    partial class TaiXeUpdateDH
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
            this.btnDaNhan = new System.Windows.Forms.Button();
            this.btnXemInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.gridViewTTDH = new System.Windows.Forms.DataGridView();
            this.cbMaDH = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridViewDSDH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTTDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSDH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDaNhan
            // 
            this.btnDaNhan.FlatAppearance.BorderSize = 2;
            this.btnDaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaNhan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaNhan.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDaNhan.Location = new System.Drawing.Point(40, 123);
            this.btnDaNhan.Name = "btnDaNhan";
            this.btnDaNhan.Size = new System.Drawing.Size(125, 64);
            this.btnDaNhan.TabIndex = 10;
            this.btnDaNhan.Text = "Đơn hàng đã nhận";
            this.btnDaNhan.UseVisualStyleBackColor = true;
            this.btnDaNhan.Click += new System.EventHandler(this.btnDaNhan_Click);
            // 
            // btnXemInfo
            // 
            this.btnXemInfo.FlatAppearance.BorderSize = 0;
            this.btnXemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemInfo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnXemInfo.Location = new System.Drawing.Point(23, 57);
            this.btnXemInfo.Name = "btnXemInfo";
            this.btnXemInfo.Size = new System.Drawing.Size(178, 37);
            this.btnXemInfo.TabIndex = 9;
            this.btnXemInfo.Text = "Xem thông tin";
            this.btnXemInfo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gridViewTTDH);
            this.panel1.Controls.Add(this.cbMaDH);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbTrangThai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gridViewDSDH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(208, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 714);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(265, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "TRẠNG THÁI ĐƠN HÀNG";
            // 
            // gridViewTTDH
            // 
            this.gridViewTTDH.AllowUserToAddRows = false;
            this.gridViewTTDH.AllowUserToDeleteRows = false;
            this.gridViewTTDH.BackgroundColor = System.Drawing.Color.Honeydew;
            this.gridViewTTDH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewTTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTTDH.Location = new System.Drawing.Point(16, 524);
            this.gridViewTTDH.Name = "gridViewTTDH";
            this.gridViewTTDH.ReadOnly = true;
            this.gridViewTTDH.RowHeadersWidth = 51;
            this.gridViewTTDH.RowTemplate.Height = 24;
            this.gridViewTTDH.Size = new System.Drawing.Size(747, 178);
            this.gridViewTTDH.TabIndex = 29;
            // 
            // cbMaDH
            // 
            this.cbMaDH.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaDH.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cbMaDH.FormattingEnabled = true;
            this.cbMaDH.Location = new System.Drawing.Point(226, 98);
            this.cbMaDH.Name = "cbMaDH";
            this.cbMaDH.Size = new System.Drawing.Size(195, 32);
            this.cbMaDH.TabIndex = 28;
            this.cbMaDH.Text = "Chọn MADH";
            this.cbMaDH.SelectedIndexChanged += new System.EventHandler(this.cbMaDH_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 205);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 12, 23, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(325, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(325, 32);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.Value = new System.DateTime(2021, 12, 23, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(64, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Thời gian";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Đang giao hàng",
            "Đã giao hàng",
            "Đã hủy"});
            this.cbTrangThai.Location = new System.Drawing.Point(226, 150);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(325, 32);
            this.cbTrangThai.TabIndex = 25;
            this.cbTrangThai.Text = "Chọn trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(64, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(64, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã đơn hàng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.Location = new System.Drawing.Point(325, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 37);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(222, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "DANH SÁCH ĐƠN HÀNG ĐÃ NHẬN";
            // 
            // gridViewDSDH
            // 
            this.gridViewDSDH.AllowUserToAddRows = false;
            this.gridViewDSDH.AllowUserToDeleteRows = false;
            this.gridViewDSDH.BackgroundColor = System.Drawing.Color.Honeydew;
            this.gridViewDSDH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewDSDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDSDH.Location = new System.Drawing.Point(16, 347);
            this.gridViewDSDH.Name = "gridViewDSDH";
            this.gridViewDSDH.ReadOnly = true;
            this.gridViewDSDH.RowHeadersWidth = 51;
            this.gridViewDSDH.RowTemplate.Height = 24;
            this.gridViewDSDH.Size = new System.Drawing.Size(747, 147);
            this.gridViewDSDH.TabIndex = 17;
            this.gridViewDSDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewDSDH_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(278, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "CẬP NHẬT ĐƠN HÀNG";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Honeydew;
            this.lblExit.Location = new System.Drawing.Point(725, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(25, 28);
            this.lblExit.TabIndex = 13;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // TaiXeUpdateDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(983, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDaNhan);
            this.Controls.Add(this.btnXemInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaiXeUpdateDH";
            this.Text = "Tài xế cập nhật đơn hàng";
            this.Load += new System.EventHandler(this.TaiXeUpdateDH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTTDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDaNhan;
        private System.Windows.Forms.Button btnXemInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridViewDSDH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbMaDH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridViewTTDH;
    }
}