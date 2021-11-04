using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 闭合导线
{
    class AngleCount
    {
        /// <summary>
        /// 字符串转小数角度
        /// </summary>
        /// <param name="D">度</param>
        /// <param name="F">分</param>
        /// <param name="M">秒</param>
        /// <returns></returns>
        public double AngleToRadian(string angle)
        {
            string[] A = new string[4];
            double anwser = 0;
            double D = 0, F = 0, M = 0;

            A = angle.Split(' ');
            D = double.Parse(A[0]);
            F = double.Parse(A[1]);
            M = double.Parse(A[2]);

            //MessageBox.Show("D="+D+"\nF="+F+"\nM="+M);//test

            try
            {
                anwser = D + F / 60 + M / 3600;//度分秒转换为小数 
                //MessageBox.Show(anwser.ToString());//test
            }
            catch
            {
                MessageBox.Show("请正确输入角度");
            }

            return anwser;
        }

        /// <summary>
        /// 小数角度转字符串
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

        //计算半测回值
        public double HalfCount(double angA, double angB)
        {
            double anwser = 0;

            anwser = (angB - angA);

            return anwser;
        }

        //计算一测回值
        public double RawCount(double angLeft, double angRight)
        {
            double anwser = 0;

            anwser = (angLeft + angRight) / 2;

            return anwser;
        }

        //超限计算
        public bool ExError(double angA, double angB)
        {
            bool Ex = false;

            if (Math.Abs(angA - angB) >= (40 / 3600))
            {
                Ex = true;
            }
            else
            {
                Ex = false;
            }

            return Ex;
        }

        //竖直角公式
        //顺时针
        public double VAngSSZ(double angL, double angR)
        {
            double answer = 0;

            answer = 0.5 * (angR - angL - 180);

            return answer;
        }
        //逆时针
        public double VAngNSZ(double angL, double angR)
        {
            double answer = 0;

            answer = 0.5 * (angL - angR + 180);

            return answer;
        }

        //输盘指标差
        public double VTraErr(double angL, double angR)
        {
            double answer = 0;

            answer = 0.5 * (angL + angR - 360);

            return answer;
        }
    }
}
