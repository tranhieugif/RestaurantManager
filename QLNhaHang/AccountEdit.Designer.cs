namespace QLNhaHang
{
    partial class AccountEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountEdit));
            panel7 = new Panel();
            btnClose = new Button();
            btnYes = new Button();
            lblTitle = new Label();
            cmbType = new ComboBox();
            txtDisplayName = new TextBox();
            txtUsername = new TextBox();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.GradientInactiveCaption;
            panel7.Controls.Add(btnClose);
            panel7.Controls.Add(btnYes);
            panel7.Controls.Add(lblTitle);
            panel7.Controls.Add(cmbType);
            panel7.Controls.Add(txtDisplayName);
            panel7.Controls.Add(txtUsername);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label12);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(550, 353);
            panel7.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(348, 279);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 53);
            btnClose.TabIndex = 10;
            btnClose.Text = "Bỏ qua";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.CornflowerBlue;
            btnYes.Cursor = Cursors.Hand;
            btnYes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnYes.ForeColor = SystemColors.HighlightText;
            btnYes.Location = new Point(50, 279);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(118, 53);
            btnYes.TabIndex = 9;
            btnYes.Text = "Đồng ý";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(114, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 41);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Thêm tài khoản mới";
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(172, 202);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(294, 31);
            cmbType.TabIndex = 2;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplayName.Location = new Point(172, 145);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(294, 30);
            txtDisplayName.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(172, 92);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(294, 30);
            txtUsername.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(50, 203);
            label8.Name = "label8";
            label8.Size = new Size(121, 23);
            label8.TabIndex = 0;
            label8.Text = "Loại tài khoản:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(50, 148);
            label11.Name = "label11";
            label11.Size = new Size(103, 23);
            label11.TabIndex = 0;
            label11.Text = "Tên hiển thị:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(50, 95);
            label12.Name = "label12";
            label12.Size = new Size(91, 23);
            label12.TabIndex = 0;
            label12.Text = "Username:";
            // 
            // AccountEdit
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(550, 353);
            ControlBox = false;
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccountEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tài khoản ";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Button btnClose;
        private Button btnYes;
        private Label lblTitle;
        private ComboBox cmbType;
        private TextBox txtDisplayName;
        private TextBox txtUsername;
        private Label label8;
        private Label label11;
        private Label label12;
    }
}