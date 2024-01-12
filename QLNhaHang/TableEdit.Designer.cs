namespace QLNhaHang
{
    partial class TableEdit
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
            panel7 = new Panel();
            btnClose = new Button();
            btnYes = new Button();
            lblTitle = new Label();
            cmbTableStatus = new ComboBox();
            txtTableName = new TextBox();
            txtTableID = new TextBox();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(btnClose);
            panel7.Controls.Add(btnYes);
            panel7.Controls.Add(lblTitle);
            panel7.Controls.Add(cmbTableStatus);
            panel7.Controls.Add(txtTableName);
            panel7.Controls.Add(txtTableID);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label12);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(633, 370);
            panel7.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(389, 287);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(136, 52);
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
            btnYes.Location = new Point(109, 287);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(136, 52);
            btnYes.TabIndex = 9;
            btnYes.Text = "Đồng ý";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(206, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 41);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Thêm bàn mới";
            // 
            // cmbTableStatus
            // 
            cmbTableStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTableStatus.FormattingEnabled = true;
            cmbTableStatus.Location = new Point(231, 215);
            cmbTableStatus.Name = "cmbTableStatus";
            cmbTableStatus.Size = new Size(294, 31);
            cmbTableStatus.TabIndex = 2;
            // 
            // txtTableName
            // 
            txtTableName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTableName.Location = new Point(231, 158);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(294, 30);
            txtTableName.TabIndex = 1;
            // 
            // txtTableID
            // 
            txtTableID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTableID.Location = new Point(231, 105);
            txtTableID.Name = "txtTableID";
            txtTableID.ReadOnly = true;
            txtTableID.Size = new Size(294, 30);
            txtTableID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(109, 216);
            label8.Name = "label8";
            label8.Size = new Size(91, 23);
            label8.TabIndex = 0;
            label8.Text = "Trạng thái:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(109, 161);
            label11.Name = "label11";
            label11.Size = new Size(74, 23);
            label11.TabIndex = 0;
            label11.Text = "Tên bàn:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(109, 108);
            label12.Name = "label12";
            label12.Size = new Size(31, 23);
            label12.TabIndex = 0;
            label12.Text = "ID:";
            // 
            // TableEdit
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            CancelButton = btnClose;
            ClientSize = new Size(633, 370);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TableEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bàn ";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private ComboBox cmbTableStatus;
        private TextBox txtTableName;
        private TextBox txtTableID;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label lblTitle;
        private Button btnClose;
        private Button btnYes;
    }
}