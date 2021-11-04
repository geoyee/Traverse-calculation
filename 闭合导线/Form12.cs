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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnga.Clear();
            txtAngb.Clear();
            txtAngc.Clear();
            txtAX.Clear();
            txtAY.Clear();
            txtBX.Clear();
            txtBY.Clear();
            txtCX.Clear();
            txtCY.Clear();
            txtPX.Clear();
            txtPY.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AngleCount AC = new AngleCount();
            IntersectionPoint IP = new IntersectionPoint();
            string pxpy = null;
            string[] anwser = new string[3];

            try
            {
                pxpy = IP.HFJH(double.Parse(txtAX.Text), double.Parse(txtAY.Text), double.Parse(txtBX.Text), double.Parse(txtBY.Text),
                    double.Parse(txtCX.Text), double.Parse(txtCY.Text), AC.AngleToRadian(txtAnga.Text), AC.AngleToRadian(txtAngb.Text), AC.AngleToRadian(txtAngc.Text));
                anwser = pxpy.Split(' ');

                txtPX.Text = anwser[0];
                txtPY.Text = anwser[1];
            }
            catch
            {
                MessageBox.Show("请检查输入", "提示");
            }
        }
    }
}
