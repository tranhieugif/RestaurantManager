namespace QLNhaHang
{
    partial class FormAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            btnChart = new Button();
            btnViewBill = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TableName = new DataGridViewTextBoxColumn();
            dateCheckInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCheckOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            billDTOBindingSource = new BindingSource(components);
            panel2 = new Panel();
            label2 = new Label();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            tpFood = new TabPage();
            panel4 = new Panel();
            dtgvFood = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idCategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foodDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnDeleteFood = new ToolStripButton();
            btnEditFood = new ToolStripButton();
            btnAddFood = new ToolStripButton();
            panel6 = new Panel();
            btnRefreshFood = new Button();
            txtSearchFood = new TextBox();
            btnSearchFood = new Button();
            tpFoodCategory = new TabPage();
            panel3 = new Panel();
            txtSearchFoodCat = new TextBox();
            btnRefreshFoodCat = new Button();
            btnSearchFoodCat = new Button();
            panel9 = new Panel();
            dtgvCategory = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            foodTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foodCategoryDTOBindingSource = new BindingSource(components);
            toolStrip2 = new ToolStrip();
            btnDeleteFoodCat = new ToolStripButton();
            btnEditFoodCat = new ToolStripButton();
            btnAddFoodCat = new ToolStripButton();
            tpTable = new TabPage();
            panel5 = new Panel();
            txtSearchTable = new TextBox();
            btnRefreshTable = new Button();
            btnSearchTable = new Button();
            panel11 = new Panel();
            dtgvTable = new DataGridView();
            iDDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            tableNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableDTOBindingSource = new BindingSource(components);
            toolStrip3 = new ToolStrip();
            btnDeleteTable = new ToolStripButton();
            btnEditTable = new ToolStripButton();
            btnAddTable = new ToolStripButton();
            tabPage1 = new TabPage();
            panel8 = new Panel();
            button3 = new Button();
            txtAccount = new TextBox();
            btnResetPass = new Button();
            btnSearchAccount = new Button();
            panel7 = new Panel();
            dataGridView2 = new DataGridView();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            displayNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountDTOBindingSource = new BindingSource(components);
            toolStrip4 = new ToolStrip();
            btnDeleteAccount = new ToolStripButton();
            btnAddAccount = new ToolStripButton();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billDTOBindingSource).BeginInit();
            panel2.SuspendLayout();
            tpFood.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            panel6.SuspendLayout();
            tpFoodCategory.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodCategoryDTOBindingSource).BeginInit();
            toolStrip2.SuspendLayout();
            tpTable.SuspendLayout();
            panel5.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableDTOBindingSource).BeginInit();
            toolStrip3.SuspendLayout();
            tabPage1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountDTOBindingSource).BeginInit();
            toolStrip4.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpFoodCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tabPage1);
            tcAdmin.Cursor = Cursors.Hand;
            tcAdmin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.RightToLeft = RightToLeft.No;
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(932, 529);
            tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(btnChart);
            tpBill.Controls.Add(btnViewBill);
            tpBill.Controls.Add(panel1);
            tpBill.Controls.Add(panel2);
            tpBill.Location = new Point(4, 34);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(924, 491);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // btnChart
            // 
            btnChart.Location = new Point(724, 447);
            btnChart.Name = "btnChart";
            btnChart.Size = new Size(193, 37);
            btnChart.TabIndex = 3;
            btnChart.Text = "Biểu đồ";
            btnChart.UseVisualStyleBackColor = true;
            btnChart.Click += btnChart_Click;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(495, 447);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(193, 37);
            btnViewBill.TabIndex = 3;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 435);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, TableName, dateCheckInDataGridViewTextBoxColumn, dateCheckOutDataGridViewTextBoxColumn, Discount, totalPriceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = billDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(916, 435);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID Hóa đơn";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // TableName
            // 
            TableName.DataPropertyName = "TableName";
            TableName.HeaderText = "Bàn";
            TableName.MinimumWidth = 6;
            TableName.Name = "TableName";
            TableName.Width = 90;
            // 
            // dateCheckInDataGridViewTextBoxColumn
            // 
            dateCheckInDataGridViewTextBoxColumn.DataPropertyName = "DateCheckIn";
            dateCheckInDataGridViewTextBoxColumn.HeaderText = "Ngày mở sổ";
            dateCheckInDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateCheckInDataGridViewTextBoxColumn.Name = "dateCheckInDataGridViewTextBoxColumn";
            dateCheckInDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateCheckOutDataGridViewTextBoxColumn
            // 
            dateCheckOutDataGridViewTextBoxColumn.DataPropertyName = "DateCheckOut";
            dateCheckOutDataGridViewTextBoxColumn.HeaderText = "Ngày thanh toán";
            dateCheckOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateCheckOutDataGridViewTextBoxColumn.Name = "dateCheckOutDataGridViewTextBoxColumn";
            dateCheckOutDataGridViewTextBoxColumn.Width = 170;
            // 
            // Discount
            // 
            Discount.DataPropertyName = "Discount";
            Discount.HeaderText = "Giảm giá";
            Discount.MinimumWidth = 6;
            Discount.Name = "Discount";
            Discount.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng thành tiền";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // billDTOBindingSource
            // 
            billDTOBindingSource.DataSource = typeof(DTO.BillDTO);
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpToDate);
            panel2.Controls.Add(dtpFromDate);
            panel2.Location = new Point(6, 447);
            panel2.Name = "panel2";
            panel2.Size = new Size(483, 37);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 6);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 2;
            label2.Text = "Đến ";
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(271, 3);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(209, 31);
            dtpToDate.TabIndex = 0;
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(3, 3);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(207, 31);
            dtpFromDate.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel6);
            tpFood.Location = new Point(4, 34);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(924, 491);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thực đơn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgvFood);
            panel4.Controls.Add(toolStrip1);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(923, 418);
            panel4.TabIndex = 3;
            // 
            // dtgvFood
            // 
            dtgvFood.AutoGenerateColumns = false;
            dtgvFood.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dtgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dtgvFood.ColumnHeadersHeight = 29;
            dtgvFood.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, idCategoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dtgvFood.DataSource = foodDTOBindingSource;
            dtgvFood.Dock = DockStyle.Fill;
            dtgvFood.EnableHeadersVisualStyles = false;
            dtgvFood.Location = new Point(0, 30);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersVisible = false;
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.RowTemplate.Height = 29;
            dtgvFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvFood.Size = new Size(923, 388);
            dtgvFood.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Mã món ";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Tên món";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // idCategoryDataGridViewTextBoxColumn
            // 
            idCategoryDataGridViewTextBoxColumn.DataPropertyName = "IdCategory";
            idCategoryDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            idCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            idCategoryDataGridViewTextBoxColumn.Name = "idCategoryDataGridViewTextBoxColumn";
            idCategoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // foodDTOBindingSource
            // 
            foodDTOBindingSource.DataSource = typeof(DTO.FoodDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDeleteFood, btnEditFood, btnAddFood });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(923, 30);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Alignment = ToolStripItemAlignment.Right;
            btnDeleteFood.Image = (Image)resources.GetObject("btnDeleteFood.Image");
            btnDeleteFood.ImageTransparentColor = Color.Magenta;
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(63, 27);
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Alignment = ToolStripItemAlignment.Right;
            btnEditFood.Image = (Image)resources.GetObject("btnEditFood.Image");
            btnEditFood.ImageTransparentColor = Color.Magenta;
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(62, 27);
            btnEditFood.Text = "Sửa";
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Alignment = ToolStripItemAlignment.Right;
            btnAddFood.Image = (Image)resources.GetObject("btnAddFood.Image");
            btnAddFood.ImageTransparentColor = Color.Magenta;
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(77, 27);
            btnAddFood.Text = "Thêm";
            btnAddFood.Click += btnAddFood_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnRefreshFood);
            panel6.Controls.Add(txtSearchFood);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(6, 427);
            panel6.Name = "panel6";
            panel6.Size = new Size(915, 54);
            panel6.TabIndex = 2;
            // 
            // btnRefreshFood
            // 
            btnRefreshFood.Location = new Point(702, 5);
            btnRefreshFood.Name = "btnRefreshFood";
            btnRefreshFood.Size = new Size(213, 44);
            btnRefreshFood.TabIndex = 2;
            btnRefreshFood.Text = "Quay về";
            btnRefreshFood.UseVisualStyleBackColor = true;
            btnRefreshFood.Click += btnRefreshFood_Click;
            // 
            // txtSearchFood
            // 
            txtSearchFood.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchFood.Location = new Point(3, 12);
            txtSearchFood.Name = "txtSearchFood";
            txtSearchFood.PlaceholderText = "Nhập mã hoặc tên món ăn";
            txtSearchFood.Size = new Size(459, 31);
            txtSearchFood.TabIndex = 1;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(478, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(204, 48);
            btnSearchFood.TabIndex = 0;
            btnSearchFood.Text = "Tìm kiếm";
            btnSearchFood.UseVisualStyleBackColor = true;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel3);
            tpFoodCategory.Controls.Add(panel9);
            tpFoodCategory.Location = new Point(4, 34);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(924, 491);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục thực đơn";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSearchFoodCat);
            panel3.Controls.Add(btnRefreshFoodCat);
            panel3.Controls.Add(btnSearchFoodCat);
            panel3.Location = new Point(6, 431);
            panel3.Name = "panel3";
            panel3.Size = new Size(911, 50);
            panel3.TabIndex = 8;
            // 
            // txtSearchFoodCat
            // 
            txtSearchFoodCat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchFoodCat.Location = new Point(3, 8);
            txtSearchFoodCat.Name = "txtSearchFoodCat";
            txtSearchFoodCat.PlaceholderText = "Nhập mã hoặc tên loại món ăn";
            txtSearchFoodCat.Size = new Size(448, 31);
            txtSearchFoodCat.TabIndex = 1;
            // 
            // btnRefreshFoodCat
            // 
            btnRefreshFoodCat.Location = new Point(695, 3);
            btnRefreshFoodCat.Name = "btnRefreshFoodCat";
            btnRefreshFoodCat.Size = new Size(213, 44);
            btnRefreshFoodCat.TabIndex = 0;
            btnRefreshFoodCat.Text = "Quay về";
            btnRefreshFoodCat.UseVisualStyleBackColor = true;
            btnRefreshFoodCat.Click += btnRefreshFoodCat_Click;
            // 
            // btnSearchFoodCat
            // 
            btnSearchFoodCat.Location = new Point(468, 3);
            btnSearchFoodCat.Name = "btnSearchFoodCat";
            btnSearchFoodCat.Size = new Size(203, 44);
            btnSearchFoodCat.TabIndex = 0;
            btnSearchFoodCat.Text = "Tìm kiếm";
            btnSearchFoodCat.UseVisualStyleBackColor = true;
            btnSearchFoodCat.Click += btnSearchFoodCat_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(dtgvCategory);
            panel9.Controls.Add(toolStrip2);
            panel9.Location = new Point(6, 6);
            panel9.Name = "panel9";
            panel9.Size = new Size(911, 419);
            panel9.TabIndex = 7;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AutoGenerateColumns = false;
            dtgvCategory.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dtgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dtgvCategory.ColumnHeadersHeight = 29;
            dtgvCategory.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, foodTypeDataGridViewTextBoxColumn });
            dtgvCategory.DataSource = foodCategoryDTOBindingSource;
            dtgvCategory.Dock = DockStyle.Fill;
            dtgvCategory.EnableHeadersVisualStyles = false;
            dtgvCategory.Location = new Point(0, 30);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersVisible = false;
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.RowTemplate.Height = 29;
            dtgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvCategory.Size = new Size(911, 389);
            dtgvCategory.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Mã loại";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Width = 300;
            // 
            // foodTypeDataGridViewTextBoxColumn
            // 
            foodTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foodTypeDataGridViewTextBoxColumn.DataPropertyName = "FoodType";
            foodTypeDataGridViewTextBoxColumn.HeaderText = "Tên loại";
            foodTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            foodTypeDataGridViewTextBoxColumn.Name = "foodTypeDataGridViewTextBoxColumn";
            // 
            // foodCategoryDTOBindingSource
            // 
            foodCategoryDTOBindingSource.DataSource = typeof(DTO.FoodCategoryDTO);
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnDeleteFoodCat, btnEditFoodCat, btnAddFoodCat });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(911, 30);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnDeleteFoodCat
            // 
            btnDeleteFoodCat.Alignment = ToolStripItemAlignment.Right;
            btnDeleteFoodCat.Image = (Image)resources.GetObject("btnDeleteFoodCat.Image");
            btnDeleteFoodCat.ImageTransparentColor = Color.Magenta;
            btnDeleteFoodCat.Name = "btnDeleteFoodCat";
            btnDeleteFoodCat.Size = new Size(59, 27);
            btnDeleteFoodCat.Text = "Xóa";
            btnDeleteFoodCat.Click += btnDeleteFoodCat_Click;
            // 
            // btnEditFoodCat
            // 
            btnEditFoodCat.Alignment = ToolStripItemAlignment.Right;
            btnEditFoodCat.Image = (Image)resources.GetObject("btnEditFoodCat.Image");
            btnEditFoodCat.ImageTransparentColor = Color.Magenta;
            btnEditFoodCat.Name = "btnEditFoodCat";
            btnEditFoodCat.Size = new Size(58, 27);
            btnEditFoodCat.Text = "Sửa";
            btnEditFoodCat.Click += btnEditFoodCat_Click;
            // 
            // btnAddFoodCat
            // 
            btnAddFoodCat.Alignment = ToolStripItemAlignment.Right;
            btnAddFoodCat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFoodCat.Image = (Image)resources.GetObject("btnAddFoodCat.Image");
            btnAddFoodCat.ImageTransparentColor = Color.Magenta;
            btnAddFoodCat.Name = "btnAddFoodCat";
            btnAddFoodCat.Size = new Size(77, 27);
            btnAddFoodCat.Text = "Thêm";
            btnAddFoodCat.Click += btnAddFoodCat_Click;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel5);
            tpTable.Controls.Add(panel11);
            tpTable.Location = new Point(4, 34);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(924, 491);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtSearchTable);
            panel5.Controls.Add(btnRefreshTable);
            panel5.Controls.Add(btnSearchTable);
            panel5.Location = new Point(7, 431);
            panel5.Name = "panel5";
            panel5.Size = new Size(911, 50);
            panel5.TabIndex = 9;
            // 
            // txtSearchTable
            // 
            txtSearchTable.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchTable.Location = new Point(3, 8);
            txtSearchTable.Name = "txtSearchTable";
            txtSearchTable.PlaceholderText = "Nhập mã hoặc số bàn";
            txtSearchTable.Size = new Size(445, 31);
            txtSearchTable.TabIndex = 1;
            // 
            // btnRefreshTable
            // 
            btnRefreshTable.Location = new Point(695, 3);
            btnRefreshTable.Name = "btnRefreshTable";
            btnRefreshTable.Size = new Size(213, 44);
            btnRefreshTable.TabIndex = 0;
            btnRefreshTable.Text = "Quay về";
            btnRefreshTable.UseVisualStyleBackColor = true;
            btnRefreshTable.Click += btnRefreshTable_Click;
            // 
            // btnSearchTable
            // 
            btnSearchTable.Location = new Point(468, 3);
            btnSearchTable.Name = "btnSearchTable";
            btnSearchTable.Size = new Size(203, 44);
            btnSearchTable.TabIndex = 0;
            btnSearchTable.Text = "Tìm kiếm";
            btnSearchTable.UseVisualStyleBackColor = true;
            btnSearchTable.Click += btnSearchTable_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(dtgvTable);
            panel11.Controls.Add(toolStrip3);
            panel11.Location = new Point(6, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(911, 419);
            panel11.TabIndex = 5;
            // 
            // dtgvTable
            // 
            dtgvTable.AutoGenerateColumns = false;
            dtgvTable.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dtgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dtgvTable.ColumnHeadersHeight = 29;
            dtgvTable.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn2, tableNumberDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dtgvTable.DataSource = tableDTOBindingSource;
            dtgvTable.Dock = DockStyle.Fill;
            dtgvTable.EnableHeadersVisualStyles = false;
            dtgvTable.Location = new Point(0, 30);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersVisible = false;
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.RowTemplate.Height = 29;
            dtgvTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTable.Size = new Size(911, 389);
            dtgvTable.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn2.HeaderText = "Mã bàn";
            iDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            iDDataGridViewTextBoxColumn2.Width = 250;
            // 
            // tableNumberDataGridViewTextBoxColumn
            // 
            tableNumberDataGridViewTextBoxColumn.DataPropertyName = "TableNumber";
            tableNumberDataGridViewTextBoxColumn.HeaderText = "Tên bàn";
            tableNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            tableNumberDataGridViewTextBoxColumn.Name = "tableNumberDataGridViewTextBoxColumn";
            tableNumberDataGridViewTextBoxColumn.Width = 300;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // tableDTOBindingSource
            // 
            tableDTOBindingSource.DataSource = typeof(DTO.TableDTO);
            // 
            // toolStrip3
            // 
            toolStrip3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Items.AddRange(new ToolStripItem[] { btnDeleteTable, btnEditTable, btnAddTable });
            toolStrip3.Location = new Point(0, 0);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(911, 30);
            toolStrip3.TabIndex = 1;
            toolStrip3.Text = "toolStrip3";
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Alignment = ToolStripItemAlignment.Right;
            btnDeleteTable.Image = (Image)resources.GetObject("btnDeleteTable.Image");
            btnDeleteTable.ImageTransparentColor = Color.Magenta;
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(63, 27);
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnEditTable
            // 
            btnEditTable.Alignment = ToolStripItemAlignment.Right;
            btnEditTable.Image = (Image)resources.GetObject("btnEditTable.Image");
            btnEditTable.ImageTransparentColor = Color.Magenta;
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(62, 27);
            btnEditTable.Text = "Sửa";
            btnEditTable.Click += btnEditTable_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.Alignment = ToolStripItemAlignment.Right;
            btnAddTable.Image = (Image)resources.GetObject("btnAddTable.Image");
            btnAddTable.ImageTransparentColor = Color.Magenta;
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(77, 27);
            btnAddTable.Text = "Thêm";
            btnAddTable.Click += btnAddTable_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel8);
            tabPage1.Controls.Add(panel7);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(924, 491);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Tài khoản";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(button3);
            panel8.Controls.Add(txtAccount);
            panel8.Controls.Add(btnResetPass);
            panel8.Controls.Add(btnSearchAccount);
            panel8.Location = new Point(6, 428);
            panel8.Name = "panel8";
            panel8.Size = new Size(911, 50);
            panel8.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(547, 3);
            button3.Name = "button3";
            button3.Size = new Size(161, 44);
            button3.TabIndex = 2;
            button3.Text = "Quay về";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccount.Location = new Point(3, 8);
            txtAccount.Name = "txtAccount";
            txtAccount.PlaceholderText = "Nhập tài khoản hoặc tên nhân viên ";
            txtAccount.Size = new Size(299, 31);
            txtAccount.TabIndex = 1;
            // 
            // btnResetPass
            // 
            btnResetPass.Location = new Point(736, 3);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(172, 44);
            btnResetPass.TabIndex = 0;
            btnResetPass.Text = "Đặt lại mật khẩu";
            btnResetPass.UseVisualStyleBackColor = true;
            btnResetPass.Click += btnResetPass_Click;
            // 
            // btnSearchAccount
            // 
            btnSearchAccount.Location = new Point(319, 3);
            btnSearchAccount.Name = "btnSearchAccount";
            btnSearchAccount.Size = new Size(203, 44);
            btnSearchAccount.TabIndex = 0;
            btnSearchAccount.Text = "Tìm kiếm";
            btnSearchAccount.UseVisualStyleBackColor = true;
            btnSearchAccount.Click += btnSearchAccount_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(dataGridView2);
            panel7.Controls.Add(toolStrip4);
            panel7.Location = new Point(6, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(911, 419);
            panel7.TabIndex = 6;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView2.ColumnHeadersHeight = 29;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { userNameDataGridViewTextBoxColumn, displayNameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn });
            dataGridView2.DataSource = accountDTOBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(0, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(911, 389);
            dataGridView2.TabIndex = 0;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "Tài khoản ";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            displayNameDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            displayNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            displayNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Loại tài khoản";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // accountDTOBindingSource
            // 
            accountDTOBindingSource.DataSource = typeof(DTO.AccountDTO);
            // 
            // toolStrip4
            // 
            toolStrip4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip4.ImageScalingSize = new Size(20, 20);
            toolStrip4.Items.AddRange(new ToolStripItem[] { btnDeleteAccount, btnAddAccount });
            toolStrip4.Location = new Point(0, 0);
            toolStrip4.Name = "toolStrip4";
            toolStrip4.Size = new Size(911, 30);
            toolStrip4.TabIndex = 1;
            toolStrip4.Text = "toolStrip4";
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Alignment = ToolStripItemAlignment.Right;
            btnDeleteAccount.Image = (Image)resources.GetObject("btnDeleteAccount.Image");
            btnDeleteAccount.ImageTransparentColor = Color.Magenta;
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(63, 27);
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Alignment = ToolStripItemAlignment.Right;
            btnAddAccount.Image = (Image)resources.GetObject("btnAddAccount.Image");
            btnAddAccount.ImageTransparentColor = Color.Magenta;
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(77, 27);
            btnAddAccount.Text = "Thêm";
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(945, 540);
            Controls.Add(tcAdmin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)billDTOBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tpFood.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tpFoodCategory.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodCategoryDTOBindingSource).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            tpTable.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableDTOBindingSource).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountDTOBindingSource).EndInit();
            toolStrip4.ResumeLayout(false);
            toolStrip4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpFoodCategory;
        private TabPage tpTable;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private Button btnViewBill;
        private DataGridView dataGridView1;
        private Panel panel4;
        private DataGridView dtgvFood;
        private Panel panel6;
        private TextBox txtSearchFood;
        private Button btnSearchFood;
        private Panel panel9;
        private DataGridView dtgvCategory;
        private Panel panel11;
        private DataGridView dtgvTable;
        private DataGridViewTextBoxColumn tableIDDataGridViewTextBoxColumn;
        private BindingSource billDTOBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton btnDeleteFood;
        private ToolStripButton btnEditFood;
        private ToolStripButton btnAddFood;
        private Panel panel3;
        private TextBox txtSearchFoodCat;
        private Button btnSearchFoodCat;
        private ToolStrip toolStrip2;
        private ToolStripButton btnDeleteFoodCat;
        private ToolStripButton btnEditFoodCat;
        private ToolStripButton btnAddFoodCat;
        private BindingSource foodDTOBindingSource;
        private BindingSource foodCategoryDTOBindingSource;
        private Button btnRefreshFoodCat;
        private Button btnRefreshFood;
        private BindingSource tableDTOBindingSource;
        private ToolStrip toolStrip3;
        private ToolStripButton btnDeleteTable;
        private ToolStripButton btnEditTable;
        private ToolStripButton btnAddTable;
        private Panel panel5;
        private TextBox txtSearchTable;
        private Button btnRefreshTable;
        private Button btnSearchTable;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn foodTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn tableNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private TabPage tabPage1;
        private Panel panel7;
        private DataGridView dataGridView2;
        private BindingSource accountDTOBindingSource;
        private ToolStrip toolStrip4;
        private ToolStripButton btnDeleteAccount;
        private ToolStripButton btnAddAccount;
        private Panel panel8;
        private TextBox txtAccount;
        private Button btnResetPass;
        private Button btnSearchAccount;
        private Button button3;
        private Button btnChart;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TableName;
        private DataGridViewTextBoxColumn dateCheckInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCheckOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}