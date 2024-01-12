namespace QLNhaHang
{
    partial class FormManageTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageTable));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            flpTable = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            làmMớiBảngToolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            cbbFood = new ComboBox();
            cbbCategory = new ComboBox();
            panel2 = new Panel();
            dgvShowBill = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            menuDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnDelete = new ToolStripButton();
            btnBooking = new ToolStripButton();
            btnCancelBooking = new ToolStripButton();
            panel3 = new Panel();
            btnSwitchTable = new Button();
            btnDiscount = new Button();
            btnAddFood = new Button();
            nmDiscount = new NumericUpDown();
            cbbTable = new ComboBox();
            nmFoodCount = new NumericUpDown();
            btnCheckOut = new Button();
            txtTotalPrice = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.BackColor = SystemColors.GradientInactiveCaption;
            flpTable.Location = new Point(0, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(564, 610);
            flpTable.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuBar;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1106, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.BackColor = SystemColors.MenuBar;
            adminToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            adminToolStripMenuItem.ForeColor = SystemColors.InfoText;
            adminToolStripMenuItem.Image = (Image)resources.GetObject("adminToolStripMenuItem.Image");
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(103, 27);
            adminToolStripMenuItem.Text = "Quản lý";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.BackColor = SystemColors.MenuBar;
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, làmMớiBảngToolStripMenuItem, dangXuatToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            thôngTinTàiKhoảnToolStripMenuItem.ForeColor = SystemColors.InfoText;
            thôngTinTàiKhoảnToolStripMenuItem.Image = (Image)resources.GetObject("thôngTinTàiKhoảnToolStripMenuItem.Image");
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(116, 27);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Hệ thống";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(244, 28);
            toolStripMenuItem1.Text = "Thông tin tài khoản";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // làmMớiBảngToolStripMenuItem
            // 
            làmMớiBảngToolStripMenuItem.Image = (Image)resources.GetObject("làmMớiBảngToolStripMenuItem.Image");
            làmMớiBảngToolStripMenuItem.Name = "làmMớiBảngToolStripMenuItem";
            làmMớiBảngToolStripMenuItem.Size = new Size(244, 28);
            làmMớiBảngToolStripMenuItem.Text = "Làm mới bảng";
            làmMớiBảngToolStripMenuItem.Click += làmMớiBảngToolStripMenuItem_Click;
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Image = (Image)resources.GetObject("dangXuatToolStripMenuItem.Image");
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(244, 28);
            dangXuatToolStripMenuItem.Text = "Đăng Xuất";
            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbFood);
            panel1.Controls.Add(cbbCategory);
            panel1.Location = new Point(567, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 36);
            panel1.TabIndex = 2;
            // 
            // cbbFood
            // 
            cbbFood.FormattingEnabled = true;
            cbbFood.Location = new Point(214, 3);
            cbbFood.Name = "cbbFood";
            cbbFood.Size = new Size(319, 28);
            cbbFood.TabIndex = 0;
            // 
            // cbbCategory
            // 
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(3, 3);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(205, 28);
            cbbCategory.TabIndex = 0;
            cbbCategory.SelectedIndexChanged += cbbCategory_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvShowBill);
            panel2.Controls.Add(toolStrip1);
            panel2.Location = new Point(567, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(536, 404);
            panel2.TabIndex = 3;
            // 
            // dgvShowBill
            // 
            dgvShowBill.AutoGenerateColumns = false;
            dgvShowBill.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvShowBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvShowBill.ColumnHeadersHeight = 29;
            dgvShowBill.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, TotalPrice });
            dgvShowBill.DataSource = menuDTOBindingSource;
            dgvShowBill.Dock = DockStyle.Fill;
            dgvShowBill.EnableHeadersVisualStyles = false;
            dgvShowBill.Location = new Point(0, 30);
            dgvShowBill.Name = "dgvShowBill";
            dgvShowBill.RowHeadersVisible = false;
            dgvShowBill.RowHeadersWidth = 51;
            dgvShowBill.RowTemplate.Height = 29;
            dgvShowBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShowBill.Size = new Size(536, 374);
            dgvShowBill.TabIndex = 0;
            dgvShowBill.CellClick += dgvShowBill_CellClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Tên món ăn";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 190;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            countDataGridViewTextBoxColumn.MinimumWidth = 6;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.Width = 95;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 95;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPrice.DataPropertyName = "TotalPrice";
            TotalPrice.HeaderText = "Thành tiền";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            // 
            // menuDTOBindingSource
            // 
            menuDTOBindingSource.DataSource = typeof(DTO.MenuDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.MenuBar;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDelete, btnBooking, btnCancelBooking });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(536, 30);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnDelete
            // 
            btnDelete.Alignment = ToolStripItemAlignment.Right;
            btnDelete.BackColor = SystemColors.MenuBar;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 27);
            btnDelete.Text = "Xóa món";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBooking
            // 
            btnBooking.Alignment = ToolStripItemAlignment.Right;
            btnBooking.BackColor = SystemColors.MenuBar;
            btnBooking.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBooking.Image = (Image)resources.GetObject("btnBooking.Image");
            btnBooking.ImageTransparentColor = Color.Magenta;
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(95, 27);
            btnBooking.Text = "Đặt bàn";
            btnBooking.Click += btnBooking_Click;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Alignment = ToolStripItemAlignment.Right;
            btnCancelBooking.BackColor = SystemColors.MenuBar;
            btnCancelBooking.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelBooking.Image = (Image)resources.GetObject("btnCancelBooking.Image");
            btnCancelBooking.ImageTransparentColor = Color.Magenta;
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(128, 27);
            btnCancelBooking.Text = "Hủy đặt bàn";
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnAddFood);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(cbbTable);
            panel3.Controls.Add(nmFoodCount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(567, 516);
            panel3.Name = "panel3";
            panel3.Size = new Size(536, 125);
            panel3.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.BackColor = SystemColors.GradientActiveCaption;
            btnSwitchTable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSwitchTable.Location = new Point(229, 36);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(110, 86);
            btnSwitchTable.TabIndex = 1;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = false;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = SystemColors.GradientActiveCaption;
            btnDiscount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscount.Location = new Point(116, 36);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(107, 86);
            btnDiscount.TabIndex = 1;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = false;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = SystemColors.GradientActiveCaption;
            btnAddFood.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(3, 36);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(110, 86);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(116, 3);
            nmDiscount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(107, 27);
            nmDiscount.TabIndex = 2;
            // 
            // cbbTable
            // 
            cbbTable.FormattingEnabled = true;
            cbbTable.Location = new Point(229, 3);
            cbbTable.Name = "cbbTable";
            cbbTable.Size = new Size(110, 28);
            cbbTable.TabIndex = 0;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(3, 3);
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(110, 27);
            nmFoodCount.TabIndex = 2;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = SystemColors.GradientActiveCaption;
            btnCheckOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.Location = new Point(345, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(185, 119);
            btnCheckOut.TabIndex = 1;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = SystemColors.GradientActiveCaption;
            txtTotalPrice.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalPrice.ForeColor = SystemColors.ControlText;
            txtTotalPrice.Location = new Point(567, 479);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(536, 31);
            txtTotalPrice.TabIndex = 1;
            // 
            // FormManageTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 653);
            Controls.Add(txtTotalPrice);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flpTable);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormManageTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Màn hình chính";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpTable;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem dangXuatToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cbbCategory;
        private Button btnAddFood;
        private ComboBox cbbFood;
        private NumericUpDown nmFoodCount;
        private NumericUpDown nmDiscount;
        private ComboBox cbbTable;
        private Button btnSwitchTable;
        private Button btnDiscount;
        private Button btnCheckOut;
        private ToolStripMenuItem toolStripMenuItem1;
        private TextBox txtTotalPrice;
        private DataGridView dgvShowBill;
        private BindingSource menuDTOBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton btnDelete;
        private ToolStripButton btnBooking;
        private ToolStripMenuItem làmMớiBảngToolStripMenuItem;
        private ToolStripButton btnCancelBooking;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TotalPrice;
    }
}