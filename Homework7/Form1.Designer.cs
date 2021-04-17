namespace Homework7
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPen = new System.Windows.Forms.TextBox();
            this.textBoxTh2 = new System.Windows.Forms.TextBox();
            this.textBoxTh1 = new System.Windows.Forms.TextBox();
            this.textBoxPer2 = new System.Windows.Forms.TextBox();
            this.textBoxPer1 = new System.Windows.Forms.TextBox();
            this.textBoxLeng = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelLeng = new System.Windows.Forms.Label();
            this.labelPer1 = new System.Windows.Forms.Label();
            this.labelPer2 = new System.Windows.Forms.Label();
            this.labelTh1 = new System.Windows.Forms.Label();
            this.labelTh2 = new System.Windows.Forms.Label();
            this.labelPen = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.drawBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 546;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(93, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 286);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(451, 389);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(75, 40);
            this.drawBtn.TabIndex = 0;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxPen, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTh2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTh1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPer2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPer1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLeng, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLeng, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPer1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPer2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTh1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelTh2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelPen, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxN, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxPen
            // 
            this.textBoxPen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPen.Location = new System.Drawing.Point(103, 403);
            this.textBoxPen.Name = "textBoxPen";
            this.textBoxPen.Size = new System.Drawing.Size(144, 28);
            this.textBoxPen.TabIndex = 13;
            // 
            // textBoxTh2
            // 
            this.textBoxTh2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTh2.Location = new System.Drawing.Point(103, 338);
            this.textBoxTh2.Name = "textBoxTh2";
            this.textBoxTh2.Size = new System.Drawing.Size(144, 28);
            this.textBoxTh2.TabIndex = 12;
            // 
            // textBoxTh1
            // 
            this.textBoxTh1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTh1.Location = new System.Drawing.Point(103, 274);
            this.textBoxTh1.Name = "textBoxTh1";
            this.textBoxTh1.Size = new System.Drawing.Size(144, 28);
            this.textBoxTh1.TabIndex = 11;
            // 
            // textBoxPer2
            // 
            this.textBoxPer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPer2.Location = new System.Drawing.Point(103, 210);
            this.textBoxPer2.Name = "textBoxPer2";
            this.textBoxPer2.Size = new System.Drawing.Size(144, 28);
            this.textBoxPer2.TabIndex = 10;
            // 
            // textBoxPer1
            // 
            this.textBoxPer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPer1.Location = new System.Drawing.Point(103, 146);
            this.textBoxPer1.Name = "textBoxPer1";
            this.textBoxPer1.Size = new System.Drawing.Size(144, 28);
            this.textBoxPer1.TabIndex = 9;
            // 
            // textBoxLeng
            // 
            this.textBoxLeng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLeng.Location = new System.Drawing.Point(103, 82);
            this.textBoxLeng.Name = "textBoxLeng";
            this.textBoxLeng.Size = new System.Drawing.Size(144, 28);
            this.textBoxLeng.TabIndex = 8;
            // 
            // labelN
            // 
            this.labelN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelN.Location = new System.Drawing.Point(3, 20);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(94, 24);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "递归深度";
            // 
            // labelLeng
            // 
            this.labelLeng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLeng.AutoSize = true;
            this.labelLeng.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLeng.Location = new System.Drawing.Point(3, 84);
            this.labelLeng.Name = "labelLeng";
            this.labelLeng.Size = new System.Drawing.Size(94, 24);
            this.labelLeng.TabIndex = 1;
            this.labelLeng.Text = "主干长度";
            // 
            // labelPer1
            // 
            this.labelPer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPer1.AutoSize = true;
            this.labelPer1.Font = new System.Drawing.Font("微软雅黑", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPer1.Location = new System.Drawing.Point(3, 150);
            this.labelPer1.Name = "labelPer1";
            this.labelPer1.Size = new System.Drawing.Size(94, 20);
            this.labelPer1.TabIndex = 2;
            this.labelPer1.Text = "右分支长度比";
            // 
            // labelPer2
            // 
            this.labelPer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPer2.AutoSize = true;
            this.labelPer2.Font = new System.Drawing.Font("微软雅黑", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPer2.Location = new System.Drawing.Point(3, 214);
            this.labelPer2.Name = "labelPer2";
            this.labelPer2.Size = new System.Drawing.Size(94, 20);
            this.labelPer2.TabIndex = 3;
            this.labelPer2.Text = "左分支长度比";
            // 
            // labelTh1
            // 
            this.labelTh1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTh1.AutoSize = true;
            this.labelTh1.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTh1.Location = new System.Drawing.Point(3, 277);
            this.labelTh1.Name = "labelTh1";
            this.labelTh1.Size = new System.Drawing.Size(94, 21);
            this.labelTh1.TabIndex = 4;
            this.labelTh1.Text = "右分支角度";
            // 
            // labelTh2
            // 
            this.labelTh2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTh2.AutoSize = true;
            this.labelTh2.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTh2.Location = new System.Drawing.Point(3, 341);
            this.labelTh2.Name = "labelTh2";
            this.labelTh2.Size = new System.Drawing.Size(94, 21);
            this.labelTh2.TabIndex = 5;
            this.labelTh2.Text = "左分支角度";
            // 
            // labelPen
            // 
            this.labelPen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPen.AutoSize = true;
            this.labelPen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPen.Location = new System.Drawing.Point(3, 405);
            this.labelPen.Name = "labelPen";
            this.labelPen.Size = new System.Drawing.Size(94, 24);
            this.labelPen.TabIndex = 6;
            this.labelPen.Text = "画笔颜色";
            // 
            // textBoxN
            // 
            this.textBoxN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxN.Location = new System.Drawing.Point(103, 18);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(144, 28);
            this.textBoxN.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelLeng;
        private System.Windows.Forms.Label labelPer1;
        private System.Windows.Forms.Label labelPer2;
        private System.Windows.Forms.Label labelTh1;
        private System.Windows.Forms.Label labelTh2;
        private System.Windows.Forms.Label labelPen;
        private System.Windows.Forms.TextBox textBoxLeng;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxPen;
        private System.Windows.Forms.TextBox textBoxTh2;
        private System.Windows.Forms.TextBox textBoxTh1;
        private System.Windows.Forms.TextBox textBoxPer2;
        private System.Windows.Forms.TextBox textBoxPer1;
    }
}

