namespace 闭合导线
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBX = new System.Windows.Forms.TextBox();
            this.txtBY = new System.Windows.Forms.TextBox();
            this.rbtLeft = new System.Windows.Forms.RadioButton();
            this.rbtRight = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAng = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column4});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvList.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(626, 365);
            this.dgvList.TabIndex = 1;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "觀測角";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "距離";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "站點";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "方位角";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.HeaderText = "X增量";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column7.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column7.HeaderText = "Y增量";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column4.HeaderText = "坐標";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("康煕字典體(Demo)", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(321, 371);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(305, 81);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "確       認";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "已知點坐標";
            // 
            // txtBX
            // 
            this.txtBX.Location = new System.Drawing.Point(108, 373);
            this.txtBX.Name = "txtBX";
            this.txtBX.Size = new System.Drawing.Size(100, 21);
            this.txtBX.TabIndex = 2;
            this.txtBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBY
            // 
            this.txtBY.Location = new System.Drawing.Point(215, 373);
            this.txtBY.Name = "txtBY";
            this.txtBY.Size = new System.Drawing.Size(100, 21);
            this.txtBY.TabIndex = 3;
            this.txtBY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtLeft
            // 
            this.rbtLeft.AutoSize = true;
            this.rbtLeft.Checked = true;
            this.rbtLeft.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtLeft.Location = new System.Drawing.Point(16, 424);
            this.rbtLeft.Name = "rbtLeft";
            this.rbtLeft.Size = new System.Drawing.Size(60, 26);
            this.rbtLeft.TabIndex = 5;
            this.rbtLeft.TabStop = true;
            this.rbtLeft.Text = "左角";
            this.rbtLeft.UseVisualStyleBackColor = true;
            // 
            // rbtRight
            // 
            this.rbtRight.AutoSize = true;
            this.rbtRight.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRight.Location = new System.Drawing.Point(82, 424);
            this.rbtRight.Name = "rbtRight";
            this.rbtRight.Size = new System.Drawing.Size(60, 26);
            this.rbtRight.TabIndex = 6;
            this.rbtRight.Text = "右角";
            this.rbtRight.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "初始方位角";
            // 
            // txtAng
            // 
            this.txtAng.Location = new System.Drawing.Point(108, 400);
            this.txtAng.Name = "txtAng";
            this.txtAng.Size = new System.Drawing.Size(207, 21);
            this.txtAng.TabIndex = 4;
            this.txtAng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("康煕字典體(Demo)", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(215, 427);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清      除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 455);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rbtRight);
            this.Controls.Add(this.rbtLeft);
            this.Controls.Add(this.txtAng);
            this.Controls.Add(this.txtBY);
            this.Controls.Add(this.txtBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(642, 494);
            this.MinimumSize = new System.Drawing.Size(642, 494);
            this.Name = "Form4";
            this.Text = "支导线";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBX;
        private System.Windows.Forms.TextBox txtBY;
        private System.Windows.Forms.RadioButton rbtLeft;
        private System.Windows.Forms.RadioButton rbtRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAng;
        private System.Windows.Forms.Button btnClear;
    }
}