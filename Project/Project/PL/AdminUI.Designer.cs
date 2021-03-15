
namespace Project
{
    partial class frmAdmin
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxMenu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlAddForm = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTittle);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(244, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(827, 47);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(30, 13);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(212, 29);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "Xin Chào Quản Lý!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Project.Properties.Resources.cancel;
            this.pictureBox1.Location = new System.Drawing.Point(797, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlLeft.Controls.Add(this.btnAccount);
            this.pnlLeft.Controls.Add(this.btnLogOut);
            this.pnlLeft.Controls.Add(this.btnFood);
            this.pnlLeft.Controls.Add(this.btnTable);
            this.pnlLeft.Controls.Add(this.btnCategory);
            this.pnlLeft.Controls.Add(this.btnRevenue);
            this.pnlLeft.Controls.Add(this.panel3);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(244, 682);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Image = global::Project.Properties.Resources.user__1_;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 428);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(244, 43);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::Project.Properties.Resources.log_out;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 506);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(244, 44);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnFood
            // 
            this.btnFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Image = global::Project.Properties.Resources.chicken;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFood.Location = new System.Drawing.Point(0, 206);
            this.btnFood.Margin = new System.Windows.Forms.Padding(0);
            this.btnFood.Name = "btnFood";
            this.btnFood.Padding = new System.Windows.Forms.Padding(3);
            this.btnFood.Size = new System.Drawing.Size(244, 54);
            this.btnFood.TabIndex = 5;
            this.btnFood.Text = "Thức Ăn";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnTable
            // 
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Image = global::Project.Properties.Resources.chair__1_;
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTable.Location = new System.Drawing.Point(0, 353);
            this.btnTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(244, 46);
            this.btnTable.TabIndex = 4;
            this.btnTable.Text = "Bàn Ăn";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Image = global::Project.Properties.Resources._14291991451579780443_32;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 284);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(244, 43);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Danh Mục";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.Image = global::Project.Properties.Resources.hand__3_;
            this.btnRevenue.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRevenue.Location = new System.Drawing.Point(0, 139);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(0);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.btnRevenue.Size = new System.Drawing.Size(244, 43);
            this.btnRevenue.TabIndex = 2;
            this.btnRevenue.Text = "Doanh Thu";
            this.btnRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbxMenu);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 94);
            this.panel3.TabIndex = 8;
            // 
            // pbxMenu
            // 
            this.pbxMenu.Image = global::Project.Properties.Resources.list__1_;
            this.pbxMenu.Location = new System.Drawing.Point(9, 0);
            this.pbxMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pbxMenu.Name = "pbxMenu";
            this.pbxMenu.Size = new System.Drawing.Size(31, 34);
            this.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMenu.TabIndex = 0;
            this.pbxMenu.TabStop = false;
            this.pbxMenu.Click += new System.EventHandler(this.pbxMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(108, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clover ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Project.Properties.Resources.clover;
            this.pictureBox2.Location = new System.Drawing.Point(43, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlAddForm
            // 
            this.pnlAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddForm.Location = new System.Drawing.Point(244, 47);
            this.pnlAddForm.Name = "pnlAddForm";
            this.pnlAddForm.Size = new System.Drawing.Size(827, 635);
            this.pnlAddForm.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1071, 682);
            this.Controls.Add(this.pnlAddForm);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlLeft);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admincs";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbxMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAddForm;
        private System.Windows.Forms.Label lblTittle;
    }
}