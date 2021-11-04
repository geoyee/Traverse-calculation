namespace 闭合导线
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.观测角 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.距离 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.站点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.方位角 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X增量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y增量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.坐标 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBX = new System.Windows.Forms.TextBox();
            this.txtBY = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtRad = new System.Windows.Forms.TextBox();
            this.btnAng = new System.Windows.Forms.Button();
            this.btnDis = new System.Windows.Forms.Button();
            this.rbtLeft = new System.Windows.Forms.RadioButton();
            this.rbtRight = new System.Windows.Forms.RadioButton();
            this.btnPoint = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拓展ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.支導線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初始方位角ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角度計算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平角計算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.豎直角計算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三角高程測量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.交會定點ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前方交會ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.側邊交會ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.後方交會ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.投影變換ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平差運算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.繪圖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.截屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.幫助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主功能實例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拓展工具介紹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.支導線ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.計算初始方位角ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.紅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.坐標轉換ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.观测角,
            this.距离,
            this.站点,
            this.方位角,
            this.X增量,
            this.Y增量,
            this.坐标});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvList.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvList.Location = new System.Drawing.Point(0, 30);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(784, 405);
            this.dgvList.TabIndex = 1;
            // 
            // 观测角
            // 
            this.观测角.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.观测角.DefaultCellStyle = dataGridViewCellStyle1;
            this.观测角.FillWeight = 78.77637F;
            this.观测角.HeaderText = "觀測角";
            this.观测角.Name = "观测角";
            this.观测角.Width = 80;
            // 
            // 距离
            // 
            this.距离.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.距离.DefaultCellStyle = dataGridViewCellStyle2;
            this.距离.FillWeight = 177.6649F;
            this.距离.HeaderText = "距離";
            this.距离.Name = "距离";
            this.距离.Width = 80;
            // 
            // 站点
            // 
            this.站点.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.站点.DefaultCellStyle = dataGridViewCellStyle3;
            this.站点.FillWeight = 30.72387F;
            this.站点.HeaderText = "站點";
            this.站点.Name = "站点";
            this.站点.ReadOnly = true;
            this.站点.Width = 40;
            // 
            // 方位角
            // 
            this.方位角.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.方位角.DefaultCellStyle = dataGridViewCellStyle4;
            this.方位角.FillWeight = 74.59766F;
            this.方位角.HeaderText = "方位角";
            this.方位角.Name = "方位角";
            this.方位角.ReadOnly = true;
            this.方位角.Width = 80;
            // 
            // X增量
            // 
            this.X增量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X增量.DefaultCellStyle = dataGridViewCellStyle5;
            this.X增量.FillWeight = 92.71663F;
            this.X增量.HeaderText = "X增量";
            this.X增量.Name = "X增量";
            this.X增量.ReadOnly = true;
            this.X增量.Width = 80;
            // 
            // Y增量
            // 
            this.Y增量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y增量.DefaultCellStyle = dataGridViewCellStyle6;
            this.Y增量.FillWeight = 92.71663F;
            this.Y增量.HeaderText = "Y增量";
            this.Y增量.Name = "Y增量";
            this.Y增量.ReadOnly = true;
            this.Y增量.Width = 80;
            // 
            // 坐标
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.坐标.DefaultCellStyle = dataGridViewCellStyle7;
            this.坐标.FillWeight = 152.8038F;
            this.坐标.HeaderText = "坐標";
            this.坐标.Name = "坐标";
            this.坐标.ReadOnly = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.Font = new System.Drawing.Font("康煕字典體(Demo)", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(416, 477);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(356, 72);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "確          認";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "初始方位角";
            // 
            // txtAng
            // 
            this.txtAng.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAng.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAng.Location = new System.Drawing.Point(125, 484);
            this.txtAng.Name = "txtAng";
            this.txtAng.Size = new System.Drawing.Size(285, 21);
            this.txtAng.TabIndex = 2;
            this.txtAng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "坐標已知點";
            // 
            // txtBX
            // 
            this.txtBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBX.Location = new System.Drawing.Point(155, 522);
            this.txtBX.Name = "txtBX";
            this.txtBX.Size = new System.Drawing.Size(110, 21);
            this.txtBX.TabIndex = 3;
            this.txtBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBY
            // 
            this.txtBY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBY.Location = new System.Drawing.Point(300, 522);
            this.txtBY.Name = "txtBY";
            this.txtBY.Size = new System.Drawing.Size(110, 21);
            this.txtBY.TabIndex = 4;
            this.txtBY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.Silver;
            this.txtD.Location = new System.Drawing.Point(597, 477);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(52, 21);
            this.txtD.TabIndex = 9;
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtD.Visible = false;
            // 
            // txtF
            // 
            this.txtF.BackColor = System.Drawing.Color.Silver;
            this.txtF.Location = new System.Drawing.Point(597, 504);
            this.txtF.Name = "txtF";
            this.txtF.ReadOnly = true;
            this.txtF.Size = new System.Drawing.Size(52, 21);
            this.txtF.TabIndex = 10;
            this.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtF.Visible = false;
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.Color.Silver;
            this.txtM.Location = new System.Drawing.Point(597, 528);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(52, 21);
            this.txtM.TabIndex = 12;
            this.txtM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM.Visible = false;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.Control;
            this.btnChange.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(160, 441);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(69, 30);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "轉換";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtRad
            // 
            this.txtRad.BackColor = System.Drawing.Color.Silver;
            this.txtRad.Location = new System.Drawing.Point(695, 477);
            this.txtRad.Name = "txtRad";
            this.txtRad.ReadOnly = true;
            this.txtRad.Size = new System.Drawing.Size(77, 21);
            this.txtRad.TabIndex = 18;
            this.txtRad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRad.Visible = false;
            // 
            // btnAng
            // 
            this.btnAng.BackColor = System.Drawing.SystemColors.Control;
            this.btnAng.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAng.Location = new System.Drawing.Point(235, 441);
            this.btnAng.Name = "btnAng";
            this.btnAng.Size = new System.Drawing.Size(175, 30);
            this.btnAng.TabIndex = 8;
            this.btnAng.Text = "角度誤差分配";
            this.btnAng.UseVisualStyleBackColor = false;
            this.btnAng.Click += new System.EventHandler(this.btnAng_Click);
            // 
            // btnDis
            // 
            this.btnDis.BackColor = System.Drawing.SystemColors.Control;
            this.btnDis.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDis.Location = new System.Drawing.Point(597, 441);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(175, 30);
            this.btnDis.TabIndex = 10;
            this.btnDis.Text = "坐標增量平差";
            this.btnDis.UseVisualStyleBackColor = false;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // rbtLeft
            // 
            this.rbtLeft.AutoSize = true;
            this.rbtLeft.Checked = true;
            this.rbtLeft.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtLeft.Location = new System.Drawing.Point(12, 441);
            this.rbtLeft.Name = "rbtLeft";
            this.rbtLeft.Size = new System.Drawing.Size(68, 30);
            this.rbtLeft.TabIndex = 5;
            this.rbtLeft.TabStop = true;
            this.rbtLeft.Text = "左角";
            this.rbtLeft.UseVisualStyleBackColor = true;
            // 
            // rbtRight
            // 
            this.rbtRight.AutoSize = true;
            this.rbtRight.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRight.Location = new System.Drawing.Point(86, 441);
            this.rbtRight.Name = "rbtRight";
            this.rbtRight.Size = new System.Drawing.Size(68, 30);
            this.rbtRight.TabIndex = 6;
            this.rbtRight.Text = "右角";
            this.rbtRight.UseVisualStyleBackColor = true;
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPoint.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.Location = new System.Drawing.Point(416, 441);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(175, 30);
            this.btnPoint.TabIndex = 9;
            this.btnPoint.Text = "計算坐標增量";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.拓展ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.幫助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 30);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.清除ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.保存ToolStripMenuItem.Text = "保存為Excel";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 清除ToolStripMenuItem
            // 
            this.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            this.清除ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.清除ToolStripMenuItem.Text = "清除";
            this.清除ToolStripMenuItem.Click += new System.EventHandler(this.清除ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.关闭ToolStripMenuItem.Text = "關閉";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 拓展ToolStripMenuItem
            // 
            this.拓展ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.支導線ToolStripMenuItem,
            this.初始方位角ToolStripMenuItem,
            this.角度計算ToolStripMenuItem,
            this.三角高程測量ToolStripMenuItem,
            this.交會定點ToolStripMenuItem,
            this.坐標轉換ToolStripMenuItem,
            this.投影變換ToolStripMenuItem,
            this.平差運算ToolStripMenuItem});
            this.拓展ToolStripMenuItem.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.拓展ToolStripMenuItem.Name = "拓展ToolStripMenuItem";
            this.拓展ToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.拓展ToolStripMenuItem.Text = "拓展功能";
            // 
            // 支導線ToolStripMenuItem
            // 
            this.支導線ToolStripMenuItem.Name = "支導線ToolStripMenuItem";
            this.支導線ToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.支導線ToolStripMenuItem.Text = "支導線";
            this.支導線ToolStripMenuItem.Click += new System.EventHandler(this.支導線ToolStripMenuItem_Click);
            // 
            // 初始方位角ToolStripMenuItem
            // 
            this.初始方位角ToolStripMenuItem.Name = "初始方位角ToolStripMenuItem";
            this.初始方位角ToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.初始方位角ToolStripMenuItem.Text = "計算初始方位角";
            this.初始方位角ToolStripMenuItem.Click += new System.EventHandler(this.初始方位角ToolStripMenuItem_Click);
            // 
            // 角度計算ToolStripMenuItem
            // 
            this.角度計算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平角計算ToolStripMenuItem,
            this.豎直角計算ToolStripMenuItem});
            this.角度計算ToolStripMenuItem.Name = "角度計算ToolStripMenuItem";
            this.角度計算ToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.角度計算ToolStripMenuItem.Text = "角度計算";
            // 
            // 水平角計算ToolStripMenuItem
            // 
            this.水平角計算ToolStripMenuItem.Name = "水平角計算ToolStripMenuItem";
            this.水平角計算ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.水平角計算ToolStripMenuItem.Text = "水平角計算";
            this.水平角計算ToolStripMenuItem.Click += new System.EventHandler(this.水平角計算ToolStripMenuItem_Click);
            // 
            // 豎直角計算ToolStripMenuItem
            // 
            this.豎直角計算ToolStripMenuItem.Name = "豎直角計算ToolStripMenuItem";
            this.豎直角計算ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.豎直角計算ToolStripMenuItem.Text = "豎直角計算";
            this.豎直角計算ToolStripMenuItem.Click += new System.EventHandler(this.豎直角計算ToolStripMenuItem_Click);
            // 
            // 三角高程測量ToolStripMenuItem
            // 
            this.三角高程測量ToolStripMenuItem.Name = "三角高程測量ToolStripMenuItem";
            this.三角高程測量ToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.三角高程測量ToolStripMenuItem.Text = "三角高程測量";
            this.三角高程測量ToolStripMenuItem.Click += new System.EventHandler(this.三角高程測量ToolStripMenuItem_Click);
            // 
            // 交會定點ToolStripMenuItem
            // 
            this.交會定點ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.前方交會ToolStripMenuItem,
            this.側邊交會ToolStripMenuItem,
            this.後方交會ToolStripMenuItem});
            this.交會定點ToolStripMenuItem.Name = "交會定點ToolStripMenuItem";
            this.交會定點ToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.交會定點ToolStripMenuItem.Text = "交會定點";
            // 
            // 前方交會ToolStripMenuItem
            // 
            this.前方交會ToolStripMenuItem.Name = "前方交會ToolStripMenuItem";
            this.前方交會ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.前方交會ToolStripMenuItem.Text = "前方交會";
            this.前方交會ToolStripMenuItem.Click += new System.EventHandler(this.前方交會ToolStripMenuItem_Click);
            // 
            // 側邊交會ToolStripMenuItem
            // 
            this.側邊交會ToolStripMenuItem.Name = "側邊交會ToolStripMenuItem";
            this.側邊交會ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.側邊交會ToolStripMenuItem.Text = "側邊交會";
            this.側邊交會ToolStripMenuItem.Click += new System.EventHandler(this.側邊交會ToolStripMenuItem_Click);
            // 
            // 後方交會ToolStripMenuItem
            // 
            this.後方交會ToolStripMenuItem.Name = "後方交會ToolStripMenuItem";
            this.後方交會ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.後方交會ToolStripMenuItem.Text = "後方交會";
            this.後方交會ToolStripMenuItem.Click += new System.EventHandler(this.後方交會ToolStripMenuItem_Click);
            // 
            // 投影變換ToolStripMenuItem
            // 
            this.投影變換ToolStripMenuItem.Name = "投影變換ToolStripMenuItem";
            this.投影變換ToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.投影變換ToolStripMenuItem.Text = "投影變換";
            this.投影變換ToolStripMenuItem.Click += new System.EventHandler(this.投影變換ToolStripMenuItem_Click);
            // 
            // 平差運算ToolStripMenuItem
            // 
            this.平差運算ToolStripMenuItem.Name = "平差運算ToolStripMenuItem";
            this.平差運算ToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.平差運算ToolStripMenuItem.Text = "平差運算";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.繪圖ToolStripMenuItem,
            this.截屏ToolStripMenuItem});
            this.工具ToolStripMenuItem.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 繪圖ToolStripMenuItem
            // 
            this.繪圖ToolStripMenuItem.Name = "繪圖ToolStripMenuItem";
            this.繪圖ToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.繪圖ToolStripMenuItem.Text = "繪圖";
            this.繪圖ToolStripMenuItem.Click += new System.EventHandler(this.繪圖ToolStripMenuItem_Click);
            // 
            // 截屏ToolStripMenuItem
            // 
            this.截屏ToolStripMenuItem.Name = "截屏ToolStripMenuItem";
            this.截屏ToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.截屏ToolStripMenuItem.Text = "截屏";
            this.截屏ToolStripMenuItem.Click += new System.EventHandler(this.截屏ToolStripMenuItem_Click_1);
            // 
            // 幫助ToolStripMenuItem
            // 
            this.幫助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主功能實例ToolStripMenuItem,
            this.拓展工具介紹ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.幫助ToolStripMenuItem.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.幫助ToolStripMenuItem.Name = "幫助ToolStripMenuItem";
            this.幫助ToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.幫助ToolStripMenuItem.Text = "幫助";
            // 
            // 主功能實例ToolStripMenuItem
            // 
            this.主功能實例ToolStripMenuItem.Name = "主功能實例ToolStripMenuItem";
            this.主功能實例ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.主功能實例ToolStripMenuItem.Text = "主功能實例";
            this.主功能實例ToolStripMenuItem.Click += new System.EventHandler(this.主功能實例ToolStripMenuItem_Click);
            // 
            // 拓展工具介紹ToolStripMenuItem
            // 
            this.拓展工具介紹ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.支導線ToolStripMenuItem1,
            this.計算初始方位角ToolStripMenuItem});
            this.拓展工具介紹ToolStripMenuItem.Name = "拓展工具介紹ToolStripMenuItem";
            this.拓展工具介紹ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.拓展工具介紹ToolStripMenuItem.Text = "拓展工具介紹";
            // 
            // 支導線ToolStripMenuItem1
            // 
            this.支導線ToolStripMenuItem1.Name = "支導線ToolStripMenuItem1";
            this.支導線ToolStripMenuItem1.Size = new System.Drawing.Size(195, 26);
            this.支導線ToolStripMenuItem1.Text = "支導線";
            this.支導線ToolStripMenuItem1.Click += new System.EventHandler(this.支導線ToolStripMenuItem1_Click);
            // 
            // 計算初始方位角ToolStripMenuItem
            // 
            this.計算初始方位角ToolStripMenuItem.Name = "計算初始方位角ToolStripMenuItem";
            this.計算初始方位角ToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.計算初始方位角ToolStripMenuItem.Text = "計算初始方位角";
            this.計算初始方位角ToolStripMenuItem.Click += new System.EventHandler(this.計算初始方位角ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.关于ToolStripMenuItem.Text = "關於";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 白ToolStripMenuItem
            // 
            this.白ToolStripMenuItem.Name = "白ToolStripMenuItem";
            this.白ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 黑ToolStripMenuItem
            // 
            this.黑ToolStripMenuItem.Name = "黑ToolStripMenuItem";
            this.黑ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 紅ToolStripMenuItem
            // 
            this.紅ToolStripMenuItem.Name = "紅ToolStripMenuItem";
            this.紅ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 26);
            this.label4.TabIndex = 30;
            this.label4.Text = "Y";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 坐標轉換ToolStripMenuItem
            // 
            this.坐標轉換ToolStripMenuItem.Name = "坐標轉換ToolStripMenuItem";
            this.坐標轉換ToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.坐標轉換ToolStripMenuItem.Text = "坐標轉換";
            this.坐標轉換ToolStripMenuItem.Click += new System.EventHandler(this.坐標轉換ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.rbtRight);
            this.Controls.Add(this.rbtLeft);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.btnAng);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtBY);
            this.Controls.Add(this.txtBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtRad);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "闭合导线计算";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBX;
        private System.Windows.Forms.TextBox txtBY;
        public System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtRad;
        private System.Windows.Forms.Button btnAng;
        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.RadioButton rbtLeft;
        private System.Windows.Forms.RadioButton rbtRight;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 拓展ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 支導線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 初始方位角ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 白ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 紅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 幫助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主功能實例ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拓展工具介紹ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 支導線ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 計算初始方位角ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 观测角;
        private System.Windows.Forms.DataGridViewTextBoxColumn 距离;
        private System.Windows.Forms.DataGridViewTextBoxColumn 站点;
        private System.Windows.Forms.DataGridViewTextBoxColumn 方位角;
        private System.Windows.Forms.DataGridViewTextBoxColumn X增量;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y增量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 坐标;
        private System.Windows.Forms.ToolStripMenuItem 清除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 繪圖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 截屏ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角度計算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平角計算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 豎直角計算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三角高程測量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 交會定點ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 投影變換ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平差運算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前方交會ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 側邊交會ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 後方交會ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 坐標轉換ToolStripMenuItem;
    }
}

