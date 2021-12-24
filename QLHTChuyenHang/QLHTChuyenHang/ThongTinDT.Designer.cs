
namespace QLHTChuyenHang
{
    partial class ThongTinDT
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
            this.btnTTDT = new System.Windows.Forms.Button();
            this.btnTTCN = new System.Windows.Forms.Button();
            this.btnCSTT = new System.Windows.Forms.Button();
            this.panelMENU = new System.Windows.Forms.Panel();
            this.panelMAIN = new System.Windows.Forms.Panel();
            this.panelMENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTTDT
            // 
            this.btnTTDT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTTDT.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTDT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTTDT.Location = new System.Drawing.Point(103, 18);
            this.btnTTDT.Name = "btnTTDT";
            this.btnTTDT.Size = new System.Drawing.Size(340, 70);
            this.btnTTDT.TabIndex = 37;
            this.btnTTDT.Text = "THÔNG TIN ĐỐI TÁC";
            this.btnTTDT.UseVisualStyleBackColor = false;
            this.btnTTDT.Click += new System.EventHandler(this.btnTTDT_Click);
            // 
            // btnTTCN
            // 
            this.btnTTCN.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTTCN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTCN.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTTCN.Location = new System.Drawing.Point(572, 18);
            this.btnTTCN.Name = "btnTTCN";
            this.btnTTCN.Size = new System.Drawing.Size(340, 70);
            this.btnTTCN.TabIndex = 38;
            this.btnTTCN.Text = "THÔNG TIN CHI NHÁNH";
            this.btnTTCN.UseVisualStyleBackColor = false;
            this.btnTTCN.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCSTT
            // 
            this.btnCSTT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCSTT.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSTT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCSTT.Location = new System.Drawing.Point(1040, 18);
            this.btnCSTT.Name = "btnCSTT";
            this.btnCSTT.Size = new System.Drawing.Size(340, 70);
            this.btnCSTT.TabIndex = 39;
            this.btnCSTT.Text = "CHỈNH SỬA THÔNG TIN";
            this.btnCSTT.UseVisualStyleBackColor = false;
            this.btnCSTT.Click += new System.EventHandler(this.btnCSTT_Click);
            // 
            // panelMENU
            // 
            this.panelMENU.BackColor = System.Drawing.Color.PowderBlue;
            this.panelMENU.Controls.Add(this.btnCSTT);
            this.panelMENU.Controls.Add(this.btnTTCN);
            this.panelMENU.Controls.Add(this.btnTTDT);
            this.panelMENU.Location = new System.Drawing.Point(0, 0);
            this.panelMENU.Name = "panelMENU";
            this.panelMENU.Size = new System.Drawing.Size(1490, 115);
            this.panelMENU.TabIndex = 40;
            // 
            // panelMAIN
            // 
            this.panelMAIN.Location = new System.Drawing.Point(0, 121);
            this.panelMAIN.Name = "panelMAIN";
            this.panelMAIN.Size = new System.Drawing.Size(1490, 530);
            this.panelMAIN.TabIndex = 41;
            // 
            // ThongTinDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1490, 650);
            this.Controls.Add(this.panelMAIN);
            this.Controls.Add(this.panelMENU);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThongTinDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinDT";
            this.Load += new System.EventHandler(this.ThongTinDT_Load);
            this.panelMENU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTTDT;
        private System.Windows.Forms.Button btnTTCN;
        private System.Windows.Forms.Button btnCSTT;
        private System.Windows.Forms.Panel panelMENU;
        private System.Windows.Forms.Panel panelMAIN;
    }
}