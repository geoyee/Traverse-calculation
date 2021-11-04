using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.RegularExpressions;

namespace 闭合导线
{
    public partial class Form5 : Form
    {
        int num2;
        //坐标储存**双为X，单为Y**
        string[][] pointXY = new string[50][];

        public Form5()
        {
            InitializeComponent();
        }

        //重写构造函数
        public Form5(int num)
        {
            InitializeComponent();

            num2 = num;
        }

        //实时坐标
        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            sslX.Text = "X:" + e.X.ToString();
            sslY.Text = "Y:" + e.Y.ToString();
        }

        //显示时画图
        private void Form5_Shown(object sender, EventArgs e)
        {
            try
            {
                //跨窗口传值
                Form1 parent = (Form1)this.Owner;

                for (int m = 0; m < num2; m++)
                {
                    pointXY[m] = parent.point2form5[m].Split(new char[3] { '(', '|', ')' });
                }

                //画图
                Graphics graphics = CreateGraphics();//创建graphic对象
                graphics.SmoothingMode = SmoothingMode.AntiAlias;//反锯齿
                //绘图区域的掌握
                Regions(graphics);
                //graphics.FillRectangle(Brushes.White, this.ClientRectangle);//涂白工作区
                Pen linePen = new Pen(Color.Red);
                //设置线段开头结尾的造型
                linePen.StartCap = LineCap.RoundAnchor;
                linePen.EndCap = LineCap.RoundAnchor;

                //绘制坐标对
                int j = 0;
                for (int i = 0; i < num2 - 1; i++)
                {
                    graphics.DrawLine(linePen, float.Parse(pointXY[j][1]), float.Parse(pointXY[j][2]),
                        float.Parse(pointXY[j + 1][1]), float.Parse(pointXY[j + 1][2]));//连线
                    j++;
                }
                //闭合
                graphics.DrawLine(linePen, float.Parse(pointXY[num2 - 1][1]), float.Parse(pointXY[num2 - 1][2]),
                        float.Parse(pointXY[0][1]), float.Parse(pointXY[0][2]));//连线

                //绘制指北针
                Pen penN = new Pen(Color.Green, 3);
                penN.StartCap = LineCap.Round;
                penN.EndCap = LineCap.ArrowAnchor;
                graphics.DrawLine(penN, float.Parse(pointXY[num2 - 1][1]), float.Parse(pointXY[num2 - 1][2]), float.Parse(pointXY[num2 - 1][1]) + 60, float.Parse(pointXY[num2 - 1][2]));
                graphics.DrawString("N", new Font("微软雅黑", 12), new SolidBrush(Color.Green), new PointF(float.Parse(pointXY[num2 - 1][1]) + 64, float.Parse(pointXY[num2 - 1][2]) - 16));

                //绘制文字
                int k = 0;
                for (int i = 0; i < num2 - 1; i++)
                {
                    graphics.DrawString("X" + (i + 1) + ":(" + pointXY[k][1].ToString() + "," + pointXY[k][2].ToString() + ")",
                        new Font("微软雅黑", 12), new SolidBrush(Color.Black), new PointF(float.Parse(pointXY[k][1]), float.Parse(pointXY[k][2])));
                    k++;
                }
                //绘制B站
                graphics.DrawString("B:(" + pointXY[num2 - 1][1].ToString() + "," + pointXY[num2 - 1][2].ToString() + ")",
                        new Font("微软雅黑", 12), new SolidBrush(Color.Black), new PointF(float.Parse(pointXY[num2 - 1][1]), float.Parse(pointXY[num2 - 1][2])));  
            }
            catch//(Exception err)
            {
                Close();
                MessageBox.Show("请得到正确的坐标后再使用绘图功能", "提示");
            }
        }

        //绘图区域把握
        private void Regions(Graphics graphics)
        {
            double xMin = double.Parse(pointXY[0][1]);
            double yMin = double.Parse(pointXY[0][2]);
            double xMax = double.Parse(pointXY[0][1]);
            double yMax = double.Parse(pointXY[0][2]);
            int strMax = 0;

            //找出最大的X坐标范围
            for (int i = 0; i < num2; i++)
            {
                if (double.Parse(pointXY[i][1]) >= xMax) xMax = double.Parse(pointXY[i][1]);
                else if (double.Parse(pointXY[i][1]) <= xMin) xMin = double.Parse(pointXY[i][1]);
            }

            //找出最大的Y坐标范围
            for (int i = 0; i < num2; i++)
            {
                if (double.Parse(pointXY[i][2]) >= yMax) yMax = double.Parse(pointXY[i][2]);
                else if (double.Parse(pointXY[i][2]) <= yMin) yMin = double.Parse(pointXY[i][2]);
            }

            //MessageBox.Show("xmax:" + xMax + "\n" +
            //                "xmin:" + xMin + "\n" +
            //                "yman:" + yMax + "\n" +
            //                "ymin:" + yMin + "\n");//test成功

            //获取最大字体长度
            strMax = pointXY[0][1].Length;
            for (int i = 0; i < num2; i++)
            {
                if (pointXY[i][1].Length >= strMax)
                {
                    strMax = pointXY[i][1].Length;
                }
                else if (pointXY[i][2].Length >= strMax)
                {
                    strMax = pointXY[i][2].Length;
                }
            }
            //MessageBox.Show(strMax.ToString());//test成功

            //根据大小改变绘图窗口大小
            //MessageBox.Show((xMax - xMin + 40).ToString() + "\n" + (yMax - yMin + 40).ToString());//test成功
            Height = (int)(yMax - yMin + 140);
            Width = (int)(xMax - xMin + 12 * (2 * strMax) + 40);

            //移动坐标轴
            graphics.TranslateTransform(-float.Parse(xMin.ToString()) + 40, -float.Parse(yMin.ToString()) + 40);
        }
    }
}