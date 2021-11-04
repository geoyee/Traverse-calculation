using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace 闭合导线
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 全局变量
        int num = 0;//测站数
        //判断
        bool exchange_able = false;
        bool angle_able = false;
        bool point_able = false;
        bool balance_able = false;
        bool RorL = true;//左右角
        //存储坐标的数组**用于跨窗口传参**
        public string[] point2form5 = new string[50];
        //新建导线类
        Traverse traverse = new Traverse();
        #endregion

        //确认
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (balance_able == true)
                {
                    traverse.GetPoint(double.Parse(txtBX.Text.ToString()), double.Parse(txtBY.Text.ToString()), dgvList, num);//得到坐標
                }
                else
                {
                    MessageBox.Show("请先平差", "提示");
                }
            }
            catch { }
        }

        //转换
        private void btnChange_Click(object sender, EventArgs e)
        {
            num = dgvList.RowCount - 1;//获取测站数

            try
            {
                //观测角转换
                for (int i = 0; i < num; i++)
                {
                    string[] sArray = dgvList.Rows[i].Cells[0].Value.ToString().Split(' ');

                    txtD.Text = sArray[0];
                    txtF.Text = sArray[1];
                    txtM.Text = sArray[2];

                    txtRad.Text = traverse.AngleToRadian(Convert.ToDouble(txtD.Text), Convert.ToDouble(txtF.Text), Convert.ToDouble(txtM.Text)).ToString();//***

                    dgvList.Rows[i].Cells[0].Value = txtRad.Text;
                }

                //初始方位角转换
                string[] aArray = txtAng.Text.Split(' ');
                txtD.Text = aArray[0];
                txtF.Text = aArray[1];
                txtM.Text = aArray[2];
                txtRad.Text = traverse.AngleToRadian(Convert.ToDouble(txtD.Text), Convert.ToDouble(txtF.Text), Convert.ToDouble(txtM.Text)).ToString();//***
                txtAng.Text = txtRad.Text;

                exchange_able = true;
            }
            catch
            {
                MessageBox.Show("请检查观测角及初始方位角输入是否正确", "提示");
            }
        }

        //角度误差分配
        private void btnAng_Click(object sender, EventArgs e)
        {

            double rawang = (num - 2) * 180;//理论值
            double nowang = 0;//测量值
            double exang = 0;//分配误差
            double error = 0;//允许闭合差
            int i;//控制变量

            error = 40 * Math.Sqrt(num) / 3600;

            try
            {
                if (exchange_able == true)
                {
                    for (i = 0; i < num; i++)
                    {
                        nowang += double.Parse(dgvList.Rows[i].Cells[0].Value.ToString());
                    }

                    exang = nowang - rawang;

                    //if (Math.Abs(exang) > error)
                    //{
                    //    MessageBox.Show("角度闭合差大于允许闭合差");
                    //}
                    //else
                    //{
                        exang /= (-1) * num;

                        for (i = 0; i < num; i++)
                        {
                            dgvList.Rows[i].Cells[0].Value =
                                (Convert.ToDouble(dgvList.Rows[i].Cells[0].Value.ToString()) + exang);
                        }

                        dgvList.Rows[i].Cells[0].Value = "校正";
                    //}

                    angle_able = true;
                    MessageBox.Show("角度闭合差为：" + exang.ToString());
                }
                else
                {
                    MessageBox.Show("请先输入数据并转化", "提示");
                }
                
            }
            catch{ }        
        }

        //坐标增量平差
        private void btnDis_Click(object sender, EventArgs e)
        {
            double distance = 0;
            double xVariate = 0;
            double yVariate = 0;

            try
            {
                if (point_able == true)
                {
                    traverse.ExVariateDistance(dgvList, num, xVariate, yVariate, distance);
                    balance_able = true;
                }
                else
                {
                    MessageBox.Show("请先计算坐标增量", "提示");
                }
            }
            catch { }
        }

        //计算坐标增量
        private void btnPoint_Click(object sender, EventArgs e)
        {
            int i;
            double fraziangle;

            num = dgvList.RowCount - 1;//获取测站数

            try
            {
                if (angle_able == true)
                {
                    fraziangle = double.Parse(txtAng.Text);//得到初始方位角
                    dgvList.Rows[0].Cells[3].Value = fraziangle;
                    dgvList.Rows[0].Cells[2].Value = "X1";

                    for (i = 1; i < num; i++)
                    {
                        //显示测站号
                        dgvList.Rows[i].Cells[2].Value = "X" + (i + 1);
                        //显示方位角
                        if (rbtLeft.Checked == true)
                        {
                            RorL = true;
                        }
                        else if (rbtRight.Checked == true)
                        {
                            RorL = false;
                        }
                        dgvList.Rows[i].Cells[3].Value =traverse.GetAngle
                        (double.Parse(dgvList.Rows[i - 1].Cells[3].Value.ToString()), double.Parse(dgvList.Rows[i - 1].Cells[0].Value.ToString()), RorL);
                    }

                    dgvList.Rows[num - 1].Cells[2].Value = "B";
                    dgvList.Rows[i].Cells[3].Value = dgvList.Rows[0].Cells[3].Value;//***
                    traverse.GetVariateDistance(dgvList, num);//计算坐标增量
                    point_able = true;
                }
                else
                {
                    MessageBox.Show("请先对分配角度误差", "提示");
                }
            }
            catch { }
        }

        //关闭
        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //保存
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            ExportExcel exportExcel = new ExportExcel();
            DataTable dataTable = exportExcel.GetDgvToTable(dgvList);
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "保存为Excel";
            string path = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName.ToString();
                exportExcel.toExcel(dataTable, path);//保存
            }   
        }

        //初始方位角
        private void 初始方位角ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        //主功能帮助
        private void 主功能實例ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        //支导线
        private void 支導線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        //支导线帮助
        private void 支導線ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当已知点无法直接作为闭合导线中的一个点位时，" +
                "常从已知点导一条支导线到闭合导线。" +
                "可使用 支导线 功能完成此计算再将结果用于闭合导线计算。", "帮助");
        }

        //初始方位角帮助
        private void 計算初始方位角ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("若已知两个点的坐标而不知其起始方位角，" +
                "则可以使用 计算初始方位角 工具先行计算方位角，" +
                "再将结果用于闭合导线的计算。", "帮助");
        }

        //清除
        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvList.RowCount; i++)
            {
                for (int j = 0; j < dgvList.ColumnCount; j++)
                {
                    dgvList.Rows[i].Cells[j].Value = "";
                }
            }
        }

        //截图
        private void 截屏ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(Width, Height);//实例化一个和窗体一样大的bitmap
            Graphics g = Graphics.FromImage(bit);
            g.CompositingQuality = CompositingQuality.HighQuality;//质量设为最高
            g.CopyFromScreen(Left, Top, 0, 0, new Size(Width, Height));//保存整个窗体为图片
            //g.CopyFromScreen(chartType.PointToScreen(Point.Empty), Point.Empty, chartType.Size);//只保存某个控件

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "另存为";
            saveFileDialog1.Filter = "*.png|*.png";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bit.Save(saveFileDialog1.FileName);//默认保存格式为PNG，保存成jpg格式质量不是很好
                if (File.Exists(saveFileDialog1.FileName.ToString()))
                {
                    MessageBox.Show("截图成功", "提示");
                    return;
                }
            }
        }

        //绘图
        private void 繪圖ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < num; i++)
                {
                    point2form5[i] = dgvList.Rows[i].Cells[6].Value.ToString();
                }

                Form5 form5 = new Form5(num);
                form5.Show(this);
            }
            catch { }
        }

        //logo取消显示
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer1.Enabled = false;
        }

        //关于
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        //提示信息(****每次修改****)
        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("当前版本号：2.27\n部分拓展功能开发中\n包括：投影变换和平差运算\n暂时无法使用\n非常抱歉", "提示");
        }

        //水平角计算
        private void 水平角計算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        //竖直角计算
        private void 豎直角計算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        //三角高程測量
        private void 三角高程測量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        #region 交会定点
        private void 前方交會ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void 側邊交會ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void 後方交會ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }
        #endregion

        private void 坐標轉換ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 投影變換ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*动态绘制
        protected override void OnSizeChanged(EventArgs e)
        {
            Invalidate();
            base.OnSizeChanged(e);
        }*/
    }
}
