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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AngleCount AC = new AngleCount();
            double halfLeft = 0, halfRight = 0, rawNum = 0;

            try
            {
                halfLeft = AC.HalfCount(AC.AngleToRadian(txtAleft.Text), AC.AngleToRadian(txtBleft.Text));
                halfRight = AC.HalfCount(AC.AngleToRadian(txtAright.Text), AC.AngleToRadian(txtBright.Text));
                rawNum = AC.RawCount(halfLeft, halfRight);
                //MessageBox.Show("Left="+ halfLeft+ "\nRight="+ halfRight+"\nRaw="+ rawNum);//test
                if (AC.ExError(halfLeft, halfRight))
                {
                    MessageBox.Show("误差超限(40″)，请检查数据", "提示");
                }
                else
                {
                    txtLeft.Text = AC.RadianToAngle(halfLeft);
                    txtRight.Text = AC.RadianToAngle(halfRight);
                    txtNum.Text = AC.RadianToAngle(rawNum);
                }
            }
            catch
            {
                MessageBox.Show("请检查输入是否正确", "提示");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAleft.Clear();
            txtAright.Clear();
            txtBleft.Clear();
            txtBright.Clear();
            txtLeft.Clear();
            txtRight.Clear();
            txtNum.Clear();
        }
    }
}
