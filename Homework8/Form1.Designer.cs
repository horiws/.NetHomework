<<<<<<< HEAD:Form1.Designer.cs
﻿namespace Homework8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanelQuery = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_queryItems = new System.Windows.Forms.ComboBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_detail = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_viewAll = new System.Windows.Forms.Button();
            this.flowLayoutPanelQuery.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelQuery
            // 
            this.flowLayoutPanelQuery.Controls.Add(this.cb_queryItems);
            this.flowLayoutPanelQuery.Controls.Add(this.btn_query);
            this.flowLayoutPanelQuery.Controls.Add(this.textBox1);
            this.flowLayoutPanelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelQuery.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelQuery.Name = "flowLayoutPanelQuery";
            this.flowLayoutPanelQuery.Size = new System.Drawing.Size(1031, 50);
            this.flowLayoutPanelQuery.TabIndex = 0;
            // 
            // cb_queryItems
            // 
            this.cb_queryItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_queryItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_queryItems.FormattingEnabled = true;
            this.cb_queryItems.Location = new System.Drawing.Point(3, 4);
            this.cb_queryItems.Name = "cb_queryItems";
            this.cb_queryItems.Size = new System.Drawing.Size(121, 26);
            this.cb_queryItems.TabIndex = 0;
            // 
            // btn_query
            // 
            this.btn_query.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_query.Location = new System.Drawing.Point(130, 3);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 28);
            this.btn_query.TabIndex = 2;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn_add);
            this.flowLayoutPanel2.Controls.Add(this.btn_modify);
            this.flowLayoutPanel2.Controls.Add(this.btn_delete);
            this.flowLayoutPanel2.Controls.Add(this.btn_export);
            this.flowLayoutPanel2.Controls.Add(this.btn_import);
            this.flowLayoutPanel2.Controls.Add(this.btn_viewAll);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(151, 357);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.Location = new System.Drawing.Point(18, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 34);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加订单";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_modify.Location = new System.Drawing.Point(18, 43);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(105, 34);
            this.btn_modify.TabIndex = 1;
            this.btn_modify.Text = "修改订单";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Location = new System.Drawing.Point(18, 83);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 34);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "删除订单";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_export
            // 
            this.btn_export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_export.Location = new System.Drawing.Point(18, 123);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(105, 34);
            this.btn_export.TabIndex = 3;
            this.btn_export.Text = "导出订单";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_import
            // 
            this.btn_import.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_import.Location = new System.Drawing.Point(18, 163);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(105, 34);
            this.btn_import.TabIndex = 4;
            this.btn_import.Text = "导入订单";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // dgv_order
            // 
            this.dgv_order.AutoGenerateColumns = false;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.ClientName,
            this.CreateTime});
            this.dgv_order.DataSource = this.orderBindingSource;
            this.dgv_order.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_order.Location = new System.Drawing.Point(151, 50);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowTemplate.Height = 30;
            this.dgv_order.Size = new System.Drawing.Size(424, 357);
            this.dgv_order.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "客户";
            this.ClientName.Name = "ClientName";
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 150;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Homework5.Order);
            // 
            // dgv_detail
            // 
            this.dgv_detail.AutoGenerateColumns = false;
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgv_detail.DataSource = this.cargoBindingSource1;
            this.dgv_detail.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_detail.Location = new System.Drawing.Point(581, 50);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.RowTemplate.Height = 30;
            this.dgv_detail.Size = new System.Drawing.Size(450, 357);
            this.dgv_detail.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "货物名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // cargoBindingSource1
            // 
            this.cargoBindingSource1.DataSource = typeof(Homework5.Cargo);
            // 
            // btn_viewAll
            // 
            this.btn_viewAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_viewAll.Location = new System.Drawing.Point(3, 203);
            this.btn_viewAll.Name = "btn_viewAll";
            this.btn_viewAll.Size = new System.Drawing.Size(136, 38);
            this.btn_viewAll.TabIndex = 5;
            this.btn_viewAll.Text = "查看全部订单";
            this.btn_viewAll.UseVisualStyleBackColor = true;
            this.btn_viewAll.Click += new System.EventHandler(this.btn_viewAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 407);
            this.Controls.Add(this.dgv_detail);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanelQuery);
            this.Name = "Form1";
            this.Text = "订单管理系统";
            this.flowLayoutPanelQuery.ResumeLayout(false);
            this.flowLayoutPanelQuery.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuery;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.ComboBox cb_queryItems;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.DataGridView dgv_order;
        public System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_detail;
        private System.Windows.Forms.BindingSource cargoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.Button btn_viewAll;
    }
}

=======
﻿namespace Homework8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanelQuery = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_queryItems = new System.Windows.Forms.ComboBox();
            this.textBox_query = new System.Windows.Forms.TextBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_detail = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanelQuery.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelQuery
            // 
            this.flowLayoutPanelQuery.Controls.Add(this.cb_queryItems);
            this.flowLayoutPanelQuery.Controls.Add(this.textBox_query);
            this.flowLayoutPanelQuery.Controls.Add(this.btn_query);
            this.flowLayoutPanelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelQuery.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelQuery.Name = "flowLayoutPanelQuery";
            this.flowLayoutPanelQuery.Size = new System.Drawing.Size(974, 50);
            this.flowLayoutPanelQuery.TabIndex = 0;
            // 
            // cb_queryItems
            // 
            this.cb_queryItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_queryItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_queryItems.FormattingEnabled = true;
            this.cb_queryItems.Location = new System.Drawing.Point(3, 4);
            this.cb_queryItems.Name = "cb_queryItems";
            this.cb_queryItems.Size = new System.Drawing.Size(121, 26);
            this.cb_queryItems.TabIndex = 0;
            // 
            // textBox_query
            // 
            this.textBox_query.Location = new System.Drawing.Point(130, 3);
            this.textBox_query.Name = "textBox_query";
            this.textBox_query.Size = new System.Drawing.Size(206, 28);
            this.textBox_query.TabIndex = 1;
            // 
            // btn_query
            // 
            this.btn_query.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_query.Location = new System.Drawing.Point(342, 3);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 28);
            this.btn_query.TabIndex = 2;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn_add);
            this.flowLayoutPanel2.Controls.Add(this.btn_modify);
            this.flowLayoutPanel2.Controls.Add(this.btn_delete);
            this.flowLayoutPanel2.Controls.Add(this.btn_export);
            this.flowLayoutPanel2.Controls.Add(this.btn_import);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(151, 357);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.Location = new System.Drawing.Point(3, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 34);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加订单";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_modify.Location = new System.Drawing.Point(3, 43);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(105, 34);
            this.btn_modify.TabIndex = 1;
            this.btn_modify.Text = "修改订单";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Location = new System.Drawing.Point(3, 83);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 34);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "删除订单";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_export
            // 
            this.btn_export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_export.Location = new System.Drawing.Point(3, 123);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(105, 34);
            this.btn_export.TabIndex = 3;
            this.btn_export.Text = "导出订单";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_import
            // 
            this.btn_import.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_import.Location = new System.Drawing.Point(3, 163);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(105, 34);
            this.btn_import.TabIndex = 4;
            this.btn_import.Text = "导入订单";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // dgv_order
            // 
            this.dgv_order.AutoGenerateColumns = false;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.CreateTime});
            this.dgv_order.DataSource = this.orderBindingSource;
            this.dgv_order.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_order.Location = new System.Drawing.Point(151, 50);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowTemplate.Height = 30;
            this.dgv_order.Size = new System.Drawing.Size(395, 357);
            this.dgv_order.TabIndex = 2;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 150;
            // 
            // dgv_detail
            // 
            this.dgv_detail.AutoGenerateColumns = false;
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgv_detail.DataSource = this.cargoBindingSource1;
            this.dgv_detail.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_detail.Location = new System.Drawing.Point(552, 50);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.RowTemplate.Height = 30;
            this.dgv_detail.Size = new System.Drawing.Size(422, 357);
            this.dgv_detail.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "货物名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // cargoBindingSource1
            // 
            this.cargoBindingSource1.DataSource = typeof(Homework5.Cargo);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientDataGridViewTextBoxColumn.HeaderText = "客户名";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Homework5.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 407);
            this.Controls.Add(this.dgv_detail);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanelQuery);
            this.Name = "Form1";
            this.Text = "订单管理系统";
            this.flowLayoutPanelQuery.ResumeLayout(false);
            this.flowLayoutPanelQuery.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuery;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.ComboBox cb_queryItems;
        private System.Windows.Forms.TextBox textBox_query;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.DataGridView dgv_order;
        public System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridView dgv_detail;
        private System.Windows.Forms.BindingSource cargoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;


    }
}

>>>>>>> 94c0b778d904731f3b62070ef8e4d57898108342:Homework8/Form1.Designer.cs
