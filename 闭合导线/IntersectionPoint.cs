using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 闭合导线
{
    class IntersectionPoint
    {
        /// <summary>
        /// 前方交会
        /// </summary>
        /// <param name="AX"></param>
        /// <param name="AY"></param>
        /// <param name="BX"></param>
        /// <param name="BY"></param>
        /// <param name="Anga"></param>
        /// <param name="Angb"></param>
        /// <returns></returns>
        public string QFJH(double AX, double AY, double BX, double BY, double Anga, double Angb)
        {
            string pXpY = null;
            double PX = 0, PY = 0;

            PX = ((AX / Math.Tan(Angb)) + (BX / Math.Tan(Anga)) + (BY - AY)) / ((1 / Math.Tan(Anga)) + (1 / Math.Tan(Angb)));
            PY = ((AY / Math.Tan(Angb)) + (BY / Math.Tan(Anga)) + (AX - BX)) / ((1 / Math.Tan(Anga)) + (1 / Math.Tan(Angb)));

            pXpY = PX.ToString() + " " + PY.ToString();

            return pXpY;
        }

        /// <summary>
        /// 侧边交会
        /// </summary>
        /// <param name="AX"></param>
        /// <param name="AY"></param>
        /// <param name="BX"></param>
        /// <param name="BY"></param>
        /// <param name="Disa"></param>
        /// <param name="Disb"></param>
        /// <returns></returns>
        public string CBJH(double AX, double AY, double BX, double BY, double Disa, double Disb)
        {
            string pXpY = null;
            double S1 = 0;
            double angA = 0, angAB = 0, angAP = 0;
            double PX = 0, PY = 0;

            S1 = Math.Sqrt(Math.Pow((AX - BX), 2) + Math.Pow((AY - BY), 2));
            angAB = Math.Atan((BY - AY) / (BX - AX));
            angA = Math.Acos((Math.Pow(S1, 2) + Math.Pow(Disa, 2) - Math.Pow(Disb, 2)) / (2 * S1 * Disa));
            angAP = angAB - angA;

            PX = AX + Disa * Math.Cos(angAP);
            PY = AY + Disa * Math.Sin(angAP);

            pXpY = PX.ToString() + " " + PY.ToString();

            return pXpY;
        }

        /// <summary>
        /// 后方交会
        /// </summary>
        /// <param name="AX"></param>
        /// <param name="AY"></param>
        /// <param name="BX"></param>
        /// <param name="BY"></param>
        /// <param name="CX"></param>
        /// <param name="CY"></param>
        /// <param name="Anga"></param>
        /// <param name="Angb"></param>
        /// <param name="Angc"></param>
        /// <returns></returns>
        public string HFJH(double AX, double AY, double BX, double BY, double CX, double CY, double Anga, double Angb, double Angc)
        {
            string pXpY = null;
            double a = 0, b = 0, c = 0;//边长
            double A = 0, B = 0, C = 0;//角度
            double Pa = 0, Pb = 0, Pc = 0;//P参数
            double PX = 0, PY = 0;//P坐标

            a = Math.Sqrt(Math.Pow((CX - BX), 2) + Math.Pow((CY - BY), 2));
            b = Math.Sqrt(Math.Pow((CX - AX), 2) + Math.Pow((CY - AY), 2));
            c = Math.Sqrt(Math.Pow((AX - BX), 2) + Math.Pow((AY - BY), 2));

            A = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c));
            B = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * c * a));
            C = Math.Acos((Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a));

            Pa = 1 / ((1 / Math.Tan(A)) -(1 / Math.Tan(Anga)));
            Pb = 1 / ((1 / Math.Tan(B)) - (1 / Math.Tan(Angb)));
            Pc = 1 / ((1 / Math.Tan(C)) - (1 / Math.Tan(Angc)));

            PX = (Pa * AX + Pb * BX + Pc * CX) / (Pa + Pb + Pc);
            PY = (Pa * AY + Pb * BY + Pc * CY) / (Pa + Pb + Pc);

            pXpY = PX.ToString() + " " + PY.ToString();

            return pXpY;
        }
    }
}
