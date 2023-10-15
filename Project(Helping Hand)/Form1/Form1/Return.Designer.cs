
namespace Form1
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.FineFeeTb = new System.Windows.Forms.TextBox();
            this.CostTb = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CustId = new System.Windows.Forms.TextBox();
            this.product = new System.Windows.Forms.Label();
            this.ReturnCustNameTb = new System.Windows.Forms.TextBox();
            this.ModelTb = new System.Windows.Forms.Label();
            this.BrandTb = new System.Windows.Forms.Label();
            this.ReturnHandRegTb = new System.Windows.Forms.TextBox();
            this.CashBookInfoDGV = new System.Windows.Forms.DataGridView();
            this.ReturnDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.DelayTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashBookInfoDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 123);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1131, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(415, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Return";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(316, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome To helping Hnad Service";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(841, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 47);
            this.label4.TabIndex = 23;
            this.label4.Text = "Customer List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(0, 594);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 28);
            this.panel2.TabIndex = 26;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(195, 284);
            this.ReturnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(200, 22);
            this.ReturnDate.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 35);
            this.label5.TabIndex = 82;
            this.label5.Text = "HandReg";
            // 
            // FineFeeTb
            // 
            this.FineFeeTb.Location = new System.Drawing.Point(203, 362);
            this.FineFeeTb.Margin = new System.Windows.Forms.Padding(4);
            this.FineFeeTb.Name = "FineFeeTb";
            this.FineFeeTb.Size = new System.Drawing.Size(191, 22);
            this.FineFeeTb.TabIndex = 80;
            // 
            // CostTb
            // 
            this.CostTb.AutoSize = true;
            this.CostTb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTb.Location = new System.Drawing.Point(73, 353);
            this.CostTb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostTb.Name = "CostTb";
            this.CostTb.Size = new System.Drawing.Size(56, 35);
            this.CostTb.TabIndex = 79;
            this.CostTb.Text = "Fine";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(203, 459);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 44);
            this.button4.TabIndex = 78;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(60, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 46);
            this.button1.TabIndex = 75;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustId
            // 
            this.CustId.Location = new System.Drawing.Point(203, 142);
            this.CustId.Margin = new System.Windows.Forms.Padding(4);
            this.CustId.Name = "CustId";
            this.CustId.Size = new System.Drawing.Size(191, 22);
            this.CustId.TabIndex = 74;
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(105, 142);
            this.product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(37, 35);
            this.product.TabIndex = 73;
            this.product.Text = "ID";
            // 
            // ReturnCustNameTb
            // 
            this.ReturnCustNameTb.Location = new System.Drawing.Point(203, 240);
            this.ReturnCustNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnCustNameTb.Name = "ReturnCustNameTb";
            this.ReturnCustNameTb.Size = new System.Drawing.Size(191, 22);
            this.ReturnCustNameTb.TabIndex = 72;
            // 
            // ModelTb
            // 
            this.ModelTb.AutoSize = true;
            this.ModelTb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTb.Location = new System.Drawing.Point(44, 277);
            this.ModelTb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelTb.Name = "ModelTb";
            this.ModelTb.Size = new System.Drawing.Size(139, 35);
            this.ModelTb.TabIndex = 71;
            this.ModelTb.Text = "Return Date";
            // 
            // BrandTb
            // 
            this.BrandTb.AutoSize = true;
            this.BrandTb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandTb.Location = new System.Drawing.Point(36, 231);
            this.BrandTb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrandTb.Name = "BrandTb";
            this.BrandTb.Size = new System.Drawing.Size(116, 35);
            this.BrandTb.TabIndex = 70;
            this.BrandTb.Text = "CustName";
            // 
            // ReturnHandRegTb
            // 
            this.ReturnHandRegTb.Location = new System.Drawing.Point(203, 185);
            this.ReturnHandRegTb.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnHandRegTb.Name = "ReturnHandRegTb";
            this.ReturnHandRegTb.Size = new System.Drawing.Size(191, 22);
            this.ReturnHandRegTb.TabIndex = 86;
            // 
            // CashBookInfoDGV
            // 
            this.CashBookInfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CashBookInfoDGV.Location = new System.Drawing.Point(437, 166);
            this.CashBookInfoDGV.Margin = new System.Windows.Forms.Padding(4);
            this.CashBookInfoDGV.Name = "CashBookInfoDGV";
            this.CashBookInfoDGV.RowHeadersWidth = 51;
            this.CashBookInfoDGV.Size = new System.Drawing.Size(719, 167);
            this.CashBookInfoDGV.TabIndex = 87;
            this.CashBookInfoDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CashBookInfoDGV_CellContentClick);
            // 
            // ReturnDGV
            // 
            this.ReturnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnDGV.Location = new System.Drawing.Point(437, 389);
            this.ReturnDGV.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnDGV.Name = "ReturnDGV";
            this.ReturnDGV.RowHeadersWidth = 51;
            this.ReturnDGV.Size = new System.Drawing.Size(719, 167);
            this.ReturnDGV.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(707, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 35);
            this.label6.TabIndex = 89;
            this.label6.Text = "Product Returned";
            // 
            // DelayTb
            // 
            this.DelayTb.Location = new System.Drawing.Point(203, 322);
            this.DelayTb.Margin = new System.Windows.Forms.Padding(4);
            this.DelayTb.Name = "DelayTb";
            this.DelayTb.Size = new System.Drawing.Size(191, 22);
            this.DelayTb.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 35);
            this.label7.TabIndex = 90;
            this.label7.Text = "Delay";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 622);
            this.Controls.Add(this.DelayTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReturnDGV);
            this.Controls.Add(this.CashBookInfoDGV);
            this.Controls.Add(this.ReturnHandRegTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ModelTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BrandTb);
            this.Controls.Add(this.ReturnCustNameTb);
            this.Controls.Add(this.FineFeeTb);
            this.Controls.Add(this.product);
            this.Controls.Add(this.CostTb);
            this.Controls.Add(this.CustId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashBookInfoDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FineFeeTb;
        private System.Windows.Forms.Label CostTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CustId;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.TextBox ReturnCustNameTb;
        private System.Windows.Forms.Label ModelTb;
        private System.Windows.Forms.Label BrandTb;
        private System.Windows.Forms.TextBox ReturnHandRegTb;
        private System.Windows.Forms.DataGridView CashBookInfoDGV;
        private System.Windows.Forms.DataGridView ReturnDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DelayTb;
        private System.Windows.Forms.Label label7;
    }
}