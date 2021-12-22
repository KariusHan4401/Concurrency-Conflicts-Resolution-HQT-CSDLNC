
namespace QLHTChuyenHang
{
    partial class DoanhThuDT
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
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnXemInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridViewDSDH = new System.Windows.Forms.DataGridView();
            this.gridViewDT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.FlatAppearance.BorderSize = 2;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDoanhThu.Location = new System.Drawing.Point(12, 123);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(189, 37);
            this.btnDoanhThu.TabIndex = 10;
            this.btnDoanhThu.Text = "Xem doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gridViewDSDH);
            this.panel1.Controls.Add(this.gridViewDT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(208, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 560);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(528, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Xem đơn hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(34, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "DANH SÁCH ĐƠN HÀNG GIAO THÀNH CÔNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "TỔNG DOANH THU";
            // 
            // gridViewDSDH
            // 
            this.gridViewDSDH.AllowUserToAddRows = false;
            this.gridViewDSDH.AllowUserToDeleteRows = false;
            this.gridViewDSDH.BackgroundColor = System.Drawing.Color.Honeydew;
            this.gridViewDSDH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewDSDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDSDH.Location = new System.Drawing.Point(38, 313);
            this.gridViewDSDH.Name = "gridViewDSDH";
            this.gridViewDSDH.ReadOnly = true;
            this.gridViewDSDH.RowHeadersWidth = 51;
            this.gridViewDSDH.RowTemplate.Height = 24;
            this.gridViewDSDH.Size = new System.Drawing.Size(702, 178);
            this.gridViewDSDH.TabIndex = 17;
            // 
            // gridViewDT
            // 
            this.gridViewDT.AllowUserToAddRows = false;
            this.gridViewDT.AllowUserToDeleteRows = false;
            this.gridViewDT.BackgroundColor = System.Drawing.Color.Honeydew;
            this.gridViewDT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDT.Location = new System.Drawing.Point(38, 123);
            this.gridViewDT.Name = "gridViewDT";
            this.gridViewDT.ReadOnly = true;
            this.gridViewDT.RowHeadersWidth = 51;
            this.gridViewDT.RowTemplate.Height = 24;
            this.gridViewDT.Size = new System.Drawing.Size(702, 132);
            this.gridViewDT.TabIndex = 16;
            this.gridViewDT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(278, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "XEM DOANH THU";
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
            // DoanhThuDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(983, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.btnXemInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoanhThuDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu đối tác";
            this.Load += new System.EventHandler(this.DoanhThuDT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnXemInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridViewDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridViewDSDH;
    }
}