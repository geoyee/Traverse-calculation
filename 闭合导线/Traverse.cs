using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 闭合导线
{
    class Traverse
    {
        /// <summary>
        /// 得到坐标方位角
        /// </summary>
        /// <param name="lastaziang">上一个方位角</param>
        /// <param name="turnang">转折角</param>
        /// <param name="RorL">左角右角判断（左=True，右=False）</param>
        /// <returns>坐标方位角</returns>
        public double GetAngle(double lastaziang, double turnang, bool RorL)
        {
            double aziang = 0;//坐标方位角

            if (RorL == false)//右角公式
            {
                aziang = lastaziang + 180 - turnang;//角度
            }
            else//左角公式
            {
                aziang = lastaziang - 180 + turnang;
            }

            //很重要
            while (aziang > 360 || aziang < 0)
            {
                if (aziang > 360)
                {
                    aziang -= 360;
                }
                else if (aziang < 0)
                {
                    aziang += 360;
                }
            }

            return aziang;
        }

        /// <summary>
        /// 得到坐标
        /// </summary>
        /// <param name="BX">已知点的X坐标</param>
        /// <param name="BY">已知点的Y坐标</param>
        /// <param name="dgvList">Datagridview数据</param>
        /// <param name="num">测站数</param>
        public void GetPoint(double BX, double BY, DataGridView dgvList, int num)
        {
            double X;
            double Y;

            try
            {
                X = BX + double.Parse(dgvList.Rows[0].Cells[4].Value.ToString());
                Y = BY + double.Parse(dgvList.Rows[0].Cells[5].Value.ToString());
                dgvList.Rows[0].Cells[6].Value = "(" + X + "|" + Y + ")";

                for (int i = 1; i < num; i++)
                {
                    X += double.Parse(dgvList.Rows[i].Cells[4].Value.ToString());
                    Y += double.Parse(dgvList.Rows[i].Cells[5].Value.ToString());
                    dgvList.Rows[i].Cells[6].Value = "(" + X + "|" + Y + ")";
                }
            }
            catch
            { }
        }

        /// <summary>
        /// 度分秒转小数
        /// </summary>
        /// <param name="D">度</param>
        /// <param name="F">分</param>
        /// <param name="M">秒</param>
        /// <returns></returns>
        public double AngleToRadian(double D, double F, double M)
        {
            double angle = 0;

            try
            {
                angle = D + F / 60 + M / 3600;//度分秒转换为度 
            }
            catch
            {
                MessageBox.Show("请正确输入角度");
            }

            return angle;
        }

        /// <summary>
        /// 小数转度分秒
        /// </summary>
        /// <param name="Angle">角度</param>
        /// <returns>DFM</returns>
        public string RadianToAngle(double Angle)
        {
            string strR = null;
            int D = 0, F = 0, M = 0;

            D = (int)Angle;
            F = (int)((Angle - D) * 60);
            M = (int)((((Angle - D) * 60) - F) * 60);
            strR = D + " " + F + " " + M;

            return strR;
        }

        /// <summary>
        /// 得到坐标增量
        /// </summary>
        /// <param name="dgvList">Datagridview</param>
        /// <param name="num">测站数</param>
        public void GetVariateDistance(DataGridView dgvList, int num)
        {
            int i;

            for (i = 0; i < num; i++)
            {
                dgvList.Rows[i].Cells[4].Value =
                    double.Parse(dgvList.Rows[i].Cells[1].Value.ToString()) * Math.Cos(double.Parse(dgvList.Rows[i].Cells[3].Value.ToString()) / 180 * Math.PI);
                dgvList.Rows[i].Cells[5].Value =
                    double.Parse(dgvList.Rows[i].Cells[1].Value.ToString()) * Math.Sin(double.Parse(dgvList.Rows[i].Cells[3].Value.ToString()) / 180 * Math.PI);
            }
        }

        /// <summary>
        /// 坐标增量平差
        /// </summary>
        /// <param name="dgvList">Datagridview</param>
        /// <param name="num">测站数</param>
        /// <param name="xVariate">X增量和</param>
        /// <param name="yVariate">Y增量和</param>
        /// <param name="distance">距离和</param>
        public void ExVariateDistance(DataGridView dgvList, int num, double xVariate, double yVariate, double distance)
        {
            int i = 0;

            for (i = 0; i < num; i++)
            {
                xVariate += double.Parse(dgvList.Rows[i].Cells[4].Value.ToString());
                yVariate += double.Parse(dgvList.Rows[i].Cells[5].Value.ToString());
                distance += double.Parse(dgvList.Rows[i].Cells[1].Value.ToString());
            }

            MessageBox.Show("X方向闭合差：" + xVariate.ToString() + "\n" + "Y方向闭合差：" + yVariate.ToString());
            xVariate /= ((-1) * distance);
            yVariate /= ((-1) * distance);  

            for (i = 0; i < num; i++)
            {
                dgvList.Rows[i].Cells[4].Value =
                    (Convert.ToDouble(dgvList.Rows[i].Cells[4].Value.ToString()) + (xVariate * Convert.ToDouble(dgvList.Rows[i].Cells[1].Value.ToString())));
                dgvList.Rows[i].Cells[5].Value =
                    (Convert.ToDouble(dgvList.Rows[i].Cells[5].Value.ToString()) + (yVariate * Convert.ToDouble(dgvList.Rows[i].Cells[1].Value.ToString())));
            }

            dgvList.Rows[i].Cells[4].Value = "校正";
            dgvList.Rows[i].Cells[5].Value = "校正";
        }
    }
}
