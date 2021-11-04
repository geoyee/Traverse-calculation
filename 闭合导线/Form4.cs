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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int num = 0;//測站數
            bool RorL = true;//左右角  
            string D = "", F = "", M = "";
            int j;
            double fraziangle;
            Traverse traverse = new Traverse();

            num = dgvList.RowCount - 1;//获取测站数

            try
            {
                #region 角度轉化
                //观测角转换
                for (int i = 0; i < num; i++)
                {
                    string[] sArray = dgvList.Rows[i].Cells[0].Value.ToString().Split(' ');

                    D = sArray[0];
                    F = sArray[1];
                    M = sArray[2];

                    dgvList.Rows[i].Cells[0].Value = traverse.AngleToRadian(Convert.ToDouble(D), Convert.ToDouble(F), Convert.ToDouble(M)).ToString();//***
                }
                //初始方位角转换
                string[] aArray = txtAng.Text.Split(' ');
                D = aArray[0];
                F = aArray[1];
                M = aArray[2];
                txtAng.Text = traverse.AngleToRadian(Convert.ToDouble(D), Convert.ToDouble(F), Convert.ToDouble(M)).ToString();//***
                #endregion

                #region 計算增量
                fraziangle = double.Parse(txtAng.Text);//得到初始方位角
                dgvList.Rows[0].Cells[3].Value = traverse.GetAngle(fraziangle, double.Parse(dgvList.Rows[0].Cells[0].Value.ToString()), RorL);
                dgvList.Rows[0].Cells[2].Value = "X1";

                for (j = 1; j < num; j++)
                {
                    //显示测站号
                    dgvList.Rows[j].Cells[2].Value = "X" + (j + 1);
                    //显示方位角
                    if (rbtLeft.Checked == true)
                    {
                        RorL = true;
                    }
                    else if (rbtRight.Checked == true)
                    {
                        RorL = false;
                    }
                    dgvList.Rows[j].Cells[3].Value = traverse.GetAngle
                    (double.Parse(dgvList.Rows[j - 1].Cells[3].Value.ToString()), double.Parse(dgvList.Rows[j].Cells[0].Value.ToString()), RorL);
                }

                traverse.GetVariateDistance(dgvList, num);//计算坐标增量
                #endregion

                //得到坐標
                traverse.GetPoint(double.Parse(txtBX.Text.ToString()), double.Parse(txtBY.Text.ToString()), dgvList, num);
            }
            catch
            {
                MessageBox.Show("请检查输入是否正确");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvList.RowCount; i++)
            {
                for (int j = 0; j < dgvList.ColumnCount; j++)
                {
                    dgvList.Rows[i].Cells[j].Value = "";
                }
            }
        }
    }
}
