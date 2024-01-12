namespace QLNhaHang
{
    partial class FormChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePass));
            txtConfirmPass = new TextBox();
            txtNewPass = new TextBox();
            txtPass = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnYes = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPass.Location = new Point(216, 216);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(279, 30);
            txtConfirmPass.TabIndex = 10;
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPass.Location = new Point(216, 161);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(279, 30);
            txtNewPass.TabIndex = 9;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(216, 104);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(279, 30);
            txtPass.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 223);
            label6.Name = "label6";
            label6.Size = new Size(158, 23);
            label6.TabIndex = 5;
            label6.Text = "Xác nhận mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 168);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 6;
            label5.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 111);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 7;
            label4.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 41);
            label1.TabIndex = 11;
            label1.Text = "Đổi mật khẩu";
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.CornflowerBlue;
            btnYes.Cursor = Cursors.Hand;
            btnYes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnYes.ForeColor = SystemColors.HighlightText;
            btnYes.Location = new Point(44, 294);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(134, 48);
            btnYes.TabIndex = 13;
            btnYes.Text = "Đồng ý";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(361, 294);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 48);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            CancelButton = btnCancel;
            ClientSize = new Size(560, 364);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnYes);
            Controls.Add(label1);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtNewPass);
            Controls.Add(txtPass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormChangePass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConfirmPass;
        private TextBox txtNewPass;
        private TextBox txtPass;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnYes;
        private Button btnCancel;
    }
}