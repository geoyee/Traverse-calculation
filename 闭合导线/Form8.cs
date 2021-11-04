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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPanleft.Clear();
            txtPanright.Clear();
            txtTra.Clear();
            txtAng.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AngleCount AC = new AngleCount();
            double pLeft = 0, pRight = 0;
            double anwser = 0;
            double err = 0;

            try
            {
                pLeft = AC.AngleToRadian(txtPanleft.Text);
                pRight = AC.AngleToRadian(txtPanright.Text);

                if (rbtSSZ.Checked == true)
                {
                    anwser = AC.VAngSSZ(pLeft, pRight);
                }
                else
                {
                    anwser = AC.VAngNSZ(pLeft, pRight);
                }

                err = AC.VTraErr(pLeft, pRight);

                MessageBox.Show("L=" + pLeft + "\nR=" + pRight + "\nANG=" + anwser + "\nerr=" + err);//test

                txtAng.Text = AC.RadianToAngle(anwser);
                txtTra.Text = AC.RadianToAngle(err);
            }
            catch
            {
                MessageBox.Show("输入有误，请检查数据", "提示");
            }
        }
    }
}
