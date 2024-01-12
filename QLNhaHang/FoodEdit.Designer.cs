namespace QLNhaHang
{
    partial class FoodEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodEdit));
            panel5 = new Panel();
            btnClose = new Button();
            btnYes = new Button();
            lblTitle = new Label();
            nmFoodPrice = new NumericUpDown();
            cmbFoodCategory = new ComboBox();
            txtFoodName = new TextBox();
            txtFoodID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(btnClose);
            panel5.Controls.Add(btnYes);
            panel5.Controls.Add(lblTitle);
            panel5.Controls.Add(nmFoodPrice);
            panel5.Controls.Add(cmbFoodCategory);
            panel5.Controls.Add(txtFoodName);
            panel5.Controls.Add(txtFoodID);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(541, 363);
            panel5.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(318, 256);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 52);
            btnClose.TabIndex = 6;
            btnClose.Text = "Bỏ qua";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.CornflowerBlue;
            btnYes.Cursor = Cursors.Hand;
            btnYes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnYes.ForeColor = SystemColors.HighlightText;
            btnYes.Location = new Point(68, 256);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(139, 52);
            btnYes.TabIndex = 5;
            btnYes.Text = "Đồng ý";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(126, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(296, 41);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Thêm thực đơn mới";
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nmFoodPrice.Location = new Point(372, 183);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(85, 30);
            nmFoodPrice.TabIndex = 3;
            // 
            // cmbFoodCategory
            // 
            cmbFoodCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Location = new Point(170, 182);
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.Size = new Size(137, 31);
            cmbFoodCategory.TabIndex = 2;
            // 
            // txtFoodName
            // 
            txtFoodName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodName.Location = new Point(170, 128);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(287, 30);
            txtFoodName.TabIndex = 1;
            // 
            // txtFoodID
            // 
            txtFoodID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodID.Location = new Point(170, 78);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.ReadOnly = true;
            txtFoodID.Size = new Size(287, 30);
            txtFoodID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(327, 190);
            label6.Name = "label6";
            label6.Size = new Size(39, 23);
            label6.TabIndex = 0;
            label6.Text = "Giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(68, 190);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 0;
            label5.Text = "Danh mục:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 135);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 0;
            label4.Text = "Tên món:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 85);
            label3.Name = "label3";
            label3.Size = new Size(31, 23);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // FoodEdit
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            CancelButton = btnClose;
            ClientSize = new Size(541, 363);
            ControlBox = false;
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FoodEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý món ăn";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private NumericUpDown nmFoodPrice;
        private ComboBox cmbFoodCategory;
        private TextBox txtFoodName;
        private TextBox txtFoodID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblTitle;
        private Button btnClose;
        private Button btnYes;
    }
}