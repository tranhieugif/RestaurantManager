namespace QLNhaHang
{
    partial class FormAccountProfile
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountProfile));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtun = new TextBox();
            txtName = new TextBox();
            txtPass = new TextBox();
            btnYes = new Button();
            btnCancel = new Button();
            btnChangePass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 41);
            label1.TabIndex = 0;
            label1.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 86);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 142);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 0;
            label3.Text = "Tên hiển thị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(58, 195);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtun
            // 
            txtun.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtun.Location = new Point(209, 79);
            txtun.Name = "txtun";
            txtun.ReadOnly = true;
            txtun.Size = new Size(330, 30);
            txtun.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(209, 135);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 30);
            txtName.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(209, 188);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(330, 30);
            txtPass.TabIndex = 2;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.CornflowerBlue;
            btnYes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnYes.ForeColor = SystemColors.HighlightText;
            btnYes.Location = new Point(233, 264);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(124, 55);
            btnYes.TabIndex = 3;
            btnYes.Text = "Đồng ý";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(418, 264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 55);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Bỏ qua";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnChangePass
            // 
            btnChangePass.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePass.Location = new Point(58, 264);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(124, 55);
            btnChangePass.TabIndex = 3;
            btnChangePass.Text = "Đổi mật khẩu";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // FormAccountProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            CancelButton = btnCancel;
            ClientSize = new Size(618, 343);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnChangePass);
            Controls.Add(btnYes);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(txtun);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin tài khoản ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtun;
        private TextBox txtName;
        private TextBox txtPass;
        private Button btnYes;
        private Button btnCancel;
        private Button btnChangePass;
    }
}