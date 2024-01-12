namespace QLNhaHang
{
    partial class FormPrintBill
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            lblStaff = new Label();
            lblTable = new Label();
            lblIDBill = new Label();
            lblDateCheckOut = new Label();
            label7 = new Label();
            lblDiscount = new Label();
            lblTotalPrice = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuDTOBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(170, 43);
            label1.Name = "label1";
            label1.Size = new Size(321, 46);
            label1.TabIndex = 1;
            label1.Text = "Hóa đơn thanh toán";
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaff.Location = new Point(2, 23);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(97, 23);
            lblStaff.TabIndex = 10;
            lblStaff.Text = "Nhân viên: ";
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTable.Location = new Point(61, 207);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(48, 23);
            lblTable.TabIndex = 11;
            lblTable.Text = "Bàn: ";
            // 
            // lblIDBill
            // 
            lblIDBill.AutoSize = true;
            lblIDBill.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblIDBill.Location = new Point(61, 163);
            lblIDBill.Name = "lblIDBill";
            lblIDBill.Size = new Size(107, 23);
            lblIDBill.TabIndex = 12;
            lblIDBill.Text = "Hóa đơn số: ";
            // 
            // lblDateCheckOut
            // 
            lblDateCheckOut.AutoSize = true;
            lblDateCheckOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateCheckOut.Location = new Point(61, 115);
            lblDateCheckOut.Name = "lblDateCheckOut";
            lblDateCheckOut.Size = new Size(59, 23);
            lblDateCheckOut.TabIndex = 13;
            lblDateCheckOut.Text = "Ngày: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(106, 703);
            label7.Name = "label7";
            label7.Size = new Size(432, 41);
            label7.TabIndex = 14;
            label7.Text = "Hân hạnh phục vụ quý khách ";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscount.Location = new Point(447, 580);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(117, 31);
            lblDiscount.TabIndex = 15;
            lblDiscount.Text = "Giảm giá: ";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(447, 626);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(122, 31);
            lblTotalPrice.TabIndex = 16;
            lblTotalPrice.Text = "Tổng tiền: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(2, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 298);
            panel1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = menuDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(673, 298);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Thực đơn";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 230;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            countDataGridViewTextBoxColumn.MinimumWidth = 6;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // menuDTOBindingSource
            // 
            menuDTOBindingSource.DataSource = typeof(DTO.MenuDTO);
            // 
            // FormPrintBill
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(677, 769);
            Controls.Add(panel1);
            Controls.Add(lblStaff);
            Controls.Add(lblTable);
            Controls.Add(lblIDBill);
            Controls.Add(lblDateCheckOut);
            Controls.Add(label7);
            Controls.Add(lblDiscount);
            Controls.Add(lblTotalPrice);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrintBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn ";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStaff;
        private Label lblTable;
        private Label lblIDBill;
        private Label lblDateCheckOut;
        private Label label7;
        private Label lblDiscount;
        private Label lblTotalPrice;
        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource menuDTOBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}