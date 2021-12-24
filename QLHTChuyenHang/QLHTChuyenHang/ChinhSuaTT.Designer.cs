
namespace QLHTChuyenHang
{
    partial class ChinhSuaTT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCSTT_DT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCSTT = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCSTT_DT);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 566);
            this.panel1.TabIndex = 0;
            // 
            // btnCSTT_DT
            // 
            this.btnCSTT_DT.BackColor = System.Drawing.Color.MintCream;
            this.btnCSTT_DT.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSTT_DT.Location = new System.Drawing.Point(7, 37);
            this.btnCSTT_DT.Name = "btnCSTT_DT";
            this.btnCSTT_DT.Size = new System.Drawing.Size(286, 59);
            this.btnCSTT_DT.TabIndex = 0;
            this.btnCSTT_DT.Text = "ĐỐI TÁC";
            this.btnCSTT_DT.UseVisualStyleBackColor = false;
            this.btnCSTT_DT.Click += new System.EventHandler(this.btnCSTT_DT_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "CHI NHÁNH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelCSTT
            // 
            this.panelCSTT.Location = new System.Drawing.Point(314, 5);
            this.panelCSTT.Name = "panelCSTT";
            this.panelCSTT.Size = new System.Drawing.Size(1196, 563);
            this.panelCSTT.TabIndex = 1;
            // 
            // ChinhSuaTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.panelCSTT);
            this.Controls.Add(this.panel1);
            this.Name = "ChinhSuaTT";
            this.Size = new System.Drawing.Size(1511, 570);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCSTT_DT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelCSTT;
    }
}
