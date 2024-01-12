namespace QLNhaHang
{
    partial class FoodCategoryEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodCategoryEdit));
            panel8 = new Panel();
            btnClose = new Button();
            btnYes = new Button();
            lblTitle = new Label();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            label9 = new Label();
            label10 = new Label();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.GradientInactiveCaption;
            panel8.Controls.Add(btnClose);
            panel8.Controls.Add(btnYes);
            panel8.Controls.Add(lblTitle);
            panel8.Controls.Add(txtCategoryName);
            panel8.Controls.Add(txtCategoryID);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label10);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(502, 332);
            panel8.TabIndex = 7;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(304, 234);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 55);
            btnClose.TabIndex = 8;
            btnClose.Text = "Bỏ qua";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.CornflowerBlue;
            btnYes.Cursor = Cursors.Hand;
            btnYes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnYes.ForeColor = SystemColors.HighlightText;
            btnYes.Location = new Point(35, 234);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(118, 55);
            btnYes.TabIndex = 7;
            btnYes.Text = "Đồng ý";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(93, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 41);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Thêm danh mục mới";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.Location = new Point(169, 165);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(253, 30);
            txtCategoryName.TabIndex = 1;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryID.Location = new Point(169, 105);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(253, 30);
            txtCategoryID.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(35, 172);
            label9.Name = "label9";
            label9.Size = new Size(122, 23);
            label9.TabIndex = 0;
            label9.Text = "Tên danh mục:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(35, 112);
            label10.Name = "label10";
            label10.Size = new Size(31, 23);
            label10.TabIndex = 0;
            label10.Text = "ID:";
            // 
            // FoodCategoryEdit
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(502, 332);
            ControlBox = false;
            Controls.Add(panel8);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FoodCategoryEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FoodCategoryEdit";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private TextBox txtCategoryName;
        private TextBox txtCategoryID;
        private Label label9;
        private Label label10;
        private Label lblTitle;
        private Button btnClose;
        private Button btnYes;
    }
}