using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 闭合导线
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //得到初始方位角
        public void GetFraziAngle()
        {
            double inang = 0;
            double dert_X = 0;
            double dert_Y = 0;
            double distance = 0;

            try
            {
                Traverse traverse = new Traverse();

                dert_X = Convert.ToDouble(txtBX.Text) - Convert.ToDouble(txtAX.Text);
                dert_Y = Convert.ToDouble(txtBY.Text) - Convert.ToDouble(txtAY.Text);

                inang = Math.Atan(dert_Y / dert_X);//方向角计算
                inang = inang / Math.PI * 180;//转角度
           
                //检验转化坐标方位角
                if (dert_X > 0 && dert_Y > 0) { }
                else if (dert_X > 0 && dert_Y < 0)
                {
                    inang = 360 - inang;
                }
                else if (dert_X < 0 && dert_Y > 0)
                {
                    inang = 180 - inang;
                }
                else
                {
                    inang = 180 + inang;
                }

                //距离
                distance = Math.Sqrt(Math.Pow(Convert.ToDouble(txtBX.Text) - Convert.ToDouble(txtAX.Text), 2) + 
                    Math.Pow(Convert.ToDouble(txtBY.Text) - Convert.ToDouble(txtAY.Text), 2));

                txtDis.Text = distance.ToString();
                txtReturn.Text = traverse.RadianToAngle(inang);
            }
            catch
            {
                MessageBox.Show("请输入正确的坐标");
            }
        }

        //确认**按钮
        private void btnOK_Click(object sender, EventArgs e)
        {
            GetFraziAngle();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAX.Clear();
            txtAY.Clear();
            txtBX.Clear();
            txtBY.Clear();
            txtDis.Clear();
            txtReturn.Clear();
        }
    }
}
