
namespace QLHTChuyenHang
{
    partial class HomePage
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
            this.Products = new System.Windows.Forms.DataGridView();
            this.Reload = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(396, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOMEPAGE";
            // 
            // Products
            // 
            this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products.Location = new System.Drawing.Point(159, 136);
            this.Products.Name = "Products";
            this.Products.RowHeadersWidth = 51;
            this.Products.RowTemplate.Height = 24;
            this.Products.Size = new System.Drawing.Size(677, 343);
            this.Products.TabIndex = 2;
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Reload.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.Reload.ForeColor = System.Drawing.Color.Transparent;
            this.Reload.Location = new System.Drawing.Point(713, 495);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(123, 38);
            this.Reload.TabIndex = 3;
            this.Reload.Text = "TẢI LẠI";
            this.Reload.UseVisualStyleBackColor = false;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(263, 78);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(428, 36);
            this.txtSearch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(124, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "TÌM KIẾM";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.findButton.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.ForeColor = System.Drawing.Color.Transparent;
            this.findButton.Location = new System.Drawing.Point(713, 76);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(123, 38);
            this.findButton.TabIndex = 9;
            this.findButton.Text = "TÌM";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Products;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findButton;
    }
}