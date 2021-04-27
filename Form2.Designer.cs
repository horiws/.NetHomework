namespace Homework8
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_cargo = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.tb_cargo = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.btn_addCargo = new System.Windows.Forms.Button();
            this.btn_deleteCargo = new System.Windows.Forms.Button();
            this.flowLayoutPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_client = new System.Windows.Forms.Label();
            this.tb_client = new System.Windows.Forms.TextBox();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv_cargo);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanelBottom);
            this.splitContainer1.Size = new System.Drawing.Size(817, 490);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgv_cargo
            // 
            this.dgv_cargo.AutoGenerateColumns = false;
            this.dgv_cargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Column5});
            this.dgv_cargo.DataSource = this.cargoBindingSource;
            this.dgv_cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cargo.Location = new System.Drawing.Point(0, 0);
            this.dgv_cargo.Name = "dgv_cargo";
            this.dgv_cargo.RowTemplate.Height = 30;
            this.dgv_cargo.Size = new System.Drawing.Size(817, 326);
            this.dgv_cargo.TabIndex = 2;
            this.dgv_cargo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_cargo_RowPostPaint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_cargo);
            this.flowLayoutPanel1.Controls.Add(this.tb_cargo);
            this.flowLayoutPanel1.Controls.Add(this.lbl_quantity);
            this.flowLayoutPanel1.Controls.Add(this.tb_quantity);
            this.flowLayoutPanel1.Controls.Add(this.lbl_price);
            this.flowLayoutPanel1.Controls.Add(this.tb_price);
            this.flowLayoutPanel1.Controls.Add(this.btn_addCargo);
            this.flowLayoutPanel1.Controls.Add(this.btn_deleteCargo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 326);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(817, 88);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Location = new System.Drawing.Point(3, 0);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(44, 34);
            this.lbl_cargo.TabIndex = 0;
            this.lbl_cargo.Text = "货物";
            this.lbl_cargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_cargo
            // 
            this.tb_cargo.Location = new System.Drawing.Point(53, 3);
            this.tb_cargo.Name = "tb_cargo";
            this.tb_cargo.Size = new System.Drawing.Size(100, 28);
            this.tb_cargo.TabIndex = 1;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(159, 0);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(44, 34);
            this.lbl_quantity.TabIndex = 2;
            this.lbl_quantity.Text = "数量";
            this.lbl_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(209, 3);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(100, 28);
            this.tb_quantity.TabIndex = 3;
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(315, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(44, 34);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "单价";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_price
            // 
            this.tb_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_price.Location = new System.Drawing.Point(365, 3);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(100, 28);
            this.tb_price.TabIndex = 5;
            // 
            // btn_addCargo
            // 
            this.btn_addCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addCargo.AutoSize = true;
            this.btn_addCargo.Location = new System.Drawing.Point(471, 3);
            this.btn_addCargo.Name = "btn_addCargo";
            this.btn_addCargo.Size = new System.Drawing.Size(90, 28);
            this.btn_addCargo.TabIndex = 0;
            this.btn_addCargo.Text = "添加货物";
            this.btn_addCargo.UseVisualStyleBackColor = true;
            this.btn_addCargo.Click += new System.EventHandler(this.btn_addCargo_Click);
            // 
            // btn_deleteCargo
            // 
            this.btn_deleteCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deleteCargo.AutoSize = true;
            this.btn_deleteCargo.Location = new System.Drawing.Point(567, 3);
            this.btn_deleteCargo.Name = "btn_deleteCargo";
            this.btn_deleteCargo.Size = new System.Drawing.Size(90, 28);
            this.btn_deleteCargo.TabIndex = 1;
            this.btn_deleteCargo.Text = "删除货物";
            this.btn_deleteCargo.UseVisualStyleBackColor = true;
            //this.btn_deleteCargo.Click += new System.EventHandler(this.btn_deleteCargo_Click);
            // 
            // flowLayoutPanelBottom
            // 
            this.flowLayoutPanelBottom.Controls.Add(this.lbl_client);
            this.flowLayoutPanelBottom.Controls.Add(this.tb_client);
            this.flowLayoutPanelBottom.Controls.Add(this.btn_addOrder);
            this.flowLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBottom.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            this.flowLayoutPanelBottom.Size = new System.Drawing.Size(817, 72);
            this.flowLayoutPanelBottom.TabIndex = 0;
            // 
            // lbl_client
            // 
            this.lbl_client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(3, 0);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(62, 34);
            this.lbl_client.TabIndex = 5;
            this.lbl_client.Text = "客户名";
            this.lbl_client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_client
            // 
            this.tb_client.Location = new System.Drawing.Point(71, 3);
            this.tb_client.Name = "tb_client";
            this.tb_client.Size = new System.Drawing.Size(100, 28);
            this.tb_client.TabIndex = 4;
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addOrder.AutoSize = true;
            this.btn_addOrder.Location = new System.Drawing.Point(177, 3);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(90, 28);
            this.btn_addOrder.TabIndex = 3;
            this.btn_addOrder.Text = "添加订单";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataSource = typeof(Homework5.Cargo);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "货物";
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
            // Column5
            // 
            this.Column5.HeaderText = "总价";
            this.Column5.Name = "Column5";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 490);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "添加/修改订单";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanelBottom.ResumeLayout(false);
            this.flowLayoutPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBottom;
        private System.Windows.Forms.Button btn_addCargo;
        private System.Windows.Forms.Button btn_deleteCargo;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.DataGridView dgv_cargo;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.TextBox tb_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}