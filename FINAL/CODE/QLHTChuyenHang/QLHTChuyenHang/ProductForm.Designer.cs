
namespace QLHTChuyenHang
{
    partial class ProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.cateBT = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.DataGridView();
            this.cateCB = new System.Windows.Forms.ComboBox();
            this.refreshBT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prodDes = new System.Windows.Forms.TextBox();
            this.prodName = new System.Windows.Forms.TextBox();
            this.prodID = new System.Windows.Forms.TextBox();
            this.editProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prodBT = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.categoryCB);
            this.panel1.Controls.Add(this.cateBT);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Category);
            this.panel1.Controls.Add(this.cateCB);
            this.panel1.Controls.Add(this.refreshBT);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Products);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.prodDes);
            this.panel1.Controls.Add(this.prodName);
            this.panel1.Controls.Add(this.prodID);
            this.panel1.Controls.Add(this.editProd);
            this.panel1.Location = new System.Drawing.Point(181, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 697);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // categoryCB
            // 
            this.categoryCB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCB.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(211, 117);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(184, 31);
            this.categoryCB.TabIndex = 32;
            this.categoryCB.Text = "ID Loại Hàng";
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // cateBT
            // 
            this.cateBT.AutoSize = true;
            this.cateBT.BackColor = System.Drawing.Color.White;
            this.cateBT.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.cateBT.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cateBT.Location = new System.Drawing.Point(341, 653);
            this.cateBT.Name = "cateBT";
            this.cateBT.Size = new System.Drawing.Size(91, 29);
            this.cateBT.TabIndex = 31;
            this.cateBT.Text = "Refresh";
            this.cateBT.Click += new System.EventHandler(this.cateBT_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(160, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "Loại Hàng";
            // 
            // Category
            // 
            this.Category.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Category.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Category.Location = new System.Drawing.Point(11, 380);
            this.Category.Name = "Category";
            this.Category.RowHeadersWidth = 51;
            this.Category.RowTemplate.Height = 24;
            this.Category.Size = new System.Drawing.Size(426, 267);
            this.Category.TabIndex = 29;
            // 
            // cateCB
            // 
            this.cateCB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cateCB.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cateCB.FormattingEnabled = true;
            this.cateCB.Location = new System.Drawing.Point(640, 22);
            this.cateCB.Name = "cateCB";
            this.cateCB.Size = new System.Drawing.Size(218, 31);
            this.cateCB.TabIndex = 28;
            this.cateCB.Text = "Chọn ID Loại Hàng";
            this.cateCB.SelectedIndexChanged += new System.EventHandler(this.cateCB_SelectedIndexChanged);
            // 
            // refreshBT
            // 
            this.refreshBT.AutoSize = true;
            this.refreshBT.BackColor = System.Drawing.Color.White;
            this.refreshBT.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.refreshBT.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.refreshBT.Location = new System.Drawing.Point(892, 25);
            this.refreshBT.Name = "refreshBT";
            this.refreshBT.Size = new System.Drawing.Size(91, 29);
            this.refreshBT.TabIndex = 27;
            this.refreshBT.Text = "Refresh";
            this.refreshBT.Click += new System.EventHandler(this.refreshBT_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(892, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 28);
            this.label10.TabIndex = 26;
            // 
            // Products
            // 
            this.Products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Products.Location = new System.Drawing.Point(494, 70);
            this.Products.Name = "Products";
            this.Products.RowHeadersWidth = 51;
            this.Products.RowTemplate.Height = 24;
            this.Products.Size = new System.Drawing.Size(609, 468);
            this.Products.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(6, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mô tả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tên Sản Phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID Loại Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(172, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "THÔNG TIN SẢN PHẨM";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // prodDes
            // 
            this.prodDes.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDes.Location = new System.Drawing.Point(211, 213);
            this.prodDes.Name = "prodDes";
            this.prodDes.Size = new System.Drawing.Size(184, 27);
            this.prodDes.TabIndex = 19;
            // 
            // prodName
            // 
            this.prodName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodName.Location = new System.Drawing.Point(211, 165);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(184, 27);
            this.prodName.TabIndex = 18;
            // 
            // prodID
            // 
            this.prodID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodID.Location = new System.Drawing.Point(211, 70);
            this.prodID.Name = "prodID";
            this.prodID.Size = new System.Drawing.Size(184, 27);
            this.prodID.TabIndex = 16;
            // 
            // editProd
            // 
            this.editProd.AutoSize = true;
            this.editProd.BackColor = System.Drawing.Color.White;
            this.editProd.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.editProd.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.editProd.Location = new System.Drawing.Point(242, 255);
            this.editProd.Name = "editProd";
            this.editProd.Size = new System.Drawing.Size(118, 29);
            this.editProd.TabIndex = 15;
            this.editProd.Text = "Chỉnh Sửa";
            this.editProd.Click += new System.EventHandler(this.editProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(569, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÍ SẢN PHẨM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(2, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 18;
            // 
            // prodBT
            // 
            this.prodBT.BackColor = System.Drawing.Color.Honeydew;
            this.prodBT.FlatAppearance.BorderSize = 2;
            this.prodBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodBT.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodBT.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.prodBT.Location = new System.Drawing.Point(6, 55);
            this.prodBT.Name = "prodBT";
            this.prodBT.Size = new System.Drawing.Size(168, 75);
            this.prodBT.TabIndex = 19;
            this.prodBT.Text = "SẢN PHẨM";
            this.prodBT.UseVisualStyleBackColor = false;
            this.prodBT.Click += new System.EventHandler(this.prodBT_Click);
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.logout.Location = new System.Drawing.Point(3, 711);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(174, 40);
            this.logout.TabIndex = 33;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1309, 754);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.prodBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prodDes;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.TextBox prodID;
        private System.Windows.Forms.Label editProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label refreshBT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Products;
        private System.Windows.Forms.ComboBox cateCB;
        private System.Windows.Forms.Label cateBT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView Category;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Button prodBT;
        private System.Windows.Forms.Button logout;
    }
}