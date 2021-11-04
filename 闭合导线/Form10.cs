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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnga.Clear();
            txtAngb.Clear();
            txtAX.Clear();
            txtAY.Clear();
            txtBX.Clear();
            txtBY.Clear();
            txtPX.Clear();
            txtPY.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AngleCount AC = new AngleCount();
            IntersectionPoint IP = new IntersectionPoint();
            string pxpy = null;
            string[] anw = new string[3];

            try
            {
                pxpy = IP.QFJH(double.Parse(txtAX.Text), double.Parse(txtAY.Text), double.Parse(txtBX.Text), double.Parse(txtBY.Text),
                    AC.AngleToRadian(txtAnga.Text), AC.AngleToRadian(txtAngb.Text));

                //MessageBox.Show(pxpy);//test
                anw = pxpy.Split(' ');
                txtPX.Text = anw[0];
                txtPY.Text = anw[1];
            }
            catch
            {
                MessageBox.Show("请检查输入", "提示");
            }
        }
    }
}
