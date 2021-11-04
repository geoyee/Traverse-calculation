namespace 闭合导线
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPanleft = new System.Windows.Forms.TextBox();
            this.txtPanright = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTra = new System.Windows.Forms.TextBox();
            this.txtAng = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.rbtNSZ = new System.Windows.Forms.RadioButton();
            this.rbtSSZ = new System.Windows.Forms.RadioButton();
            this.gbx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "盤左";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "盤右";
            // 
            // txtPanleft
            // 
            this.txtPanleft.Location = new System.Drawing.Point(61, 9);
            this.txtPanleft.Name = "txtPanleft";
            this.txtPanleft.Size = new System.Drawing.Size(193, 21);
            this.txtPanleft.TabIndex = 1;
            this.txtPanleft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPanright
            // 
            this.txtPanright.Location = new System.Drawing.Point(61, 36);
            this.txtPanright.Name = "txtPanright";
            this.txtPanright.Size = new System.Drawing.Size(193, 21);
            this.txtPanright.TabIndex = 2;
            this.txtPanright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "指標差";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "豎直角";
            // 
            // txtTra
            // 
            this.txtTra.BackColor = System.Drawing.Color.Silver;
            this.txtTra.Location = new System.Drawing.Point(76, 63);
            this.txtTra.Name = "txtTra";
            this.txtTra.ReadOnly = true;
            this.txtTra.Size = new System.Drawing.Size(178, 21);
            this.txtTra.TabIndex = 6;
            this.txtTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAng
            // 
            this.txtAng.BackColor = System.Drawing.Color.Silver;
            this.txtAng.Location = new System.Drawing.Point(76, 90);
            this.txtAng.Name = "txtAng";
            this.txtAng.ReadOnly = true;
            this.txtAng.Size = new System.Drawing.Size(178, 21);
            this.txtAng.TabIndex = 7;
            this.txtAng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(133, 169);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 36);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "計  算";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("康煕字典體(Demo)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 169);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清  除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbx1
            // 
            this.gbx1.Controls.Add(this.rbtNSZ);
            this.gbx1.Controls.Add(this.rbtSSZ);
            this.gbx1.Font = new System.Drawing.Font("康煕字典體(Demo)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx1.Location = new System.Drawing.Point(12, 115);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(242, 48);
            this.gbx1.TabIndex = 12;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "註記";
            // 
            // rbtNSZ
            // 
            this.rbtNSZ.AutoSize = true;
            this.rbtNSZ.Location = new System.Drawing.Point(128, 16);
            this.rbtNSZ.Name = "rbtNSZ";
            this.rbtNSZ.Size = new System.Drawing.Size(108, 26);
            this.rbtNSZ.TabIndex = 4;
            this.rbtNSZ.Text = "逆時針註記";
            this.rbtNSZ.UseVisualStyleBackColor = true;
            // 
            // rbtSSZ
            // 
            this.rbtSSZ.AutoSize = true;
            this.rbtSSZ.Checked = true;
            this.rbtSSZ.Location = new System.Drawing.Point(6, 16);
            this.rbtSSZ.Name = "rbtSSZ";
            this.rbtSSZ.Size = new System.Drawing.Size(108, 26);
            this.rbtSSZ.TabIndex = 3;
            this.rbtSSZ.TabStop = true;
            this.rbtSSZ.Text = "順時針註記";
            this.rbtSSZ.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 214);
            this.Controls.Add(this.gbx1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAng);
            this.Controls.Add(this.txtTra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPanright);
            this.Controls.Add(this.txtPanleft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(283, 253);
            this.MinimumSize = new System.Drawing.Size(283, 253);
            this.Name = "Form8";
            this.Text = "竖直角计算";
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPanleft;
        private System.Windows.Forms.TextBox txtPanright;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTra;
        private System.Windows.Forms.TextBox txtAng;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.RadioButton rbtNSZ;
        private System.Windows.Forms.RadioButton rbtSSZ;
    }
}