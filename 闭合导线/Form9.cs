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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDis.Clear();
            txtHei.Clear();
            txtIns.Clear();
            txtObj.Clear();
            txtRul.Clear();
            txtVAng.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //创建对象
            AngleCount AC = new AngleCount();
            TrigonometricLeveling TL = new TrigonometricLeveling();

            txtDis.Text = TL.GetDis(double.Parse(txtRul.Text), AC.AngleToRadian(txtVAng.Text)).ToString();
            txtHei.Text = TL.GetHei(double.Parse(txtDis.Text), AC.AngleToRadian(txtVAng.Text), double.Parse(txtIns.Text), double.Parse(txtObj.Text)).ToString();
        }
    }
}
