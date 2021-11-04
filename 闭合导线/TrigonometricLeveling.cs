using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 闭合导线
{
    class TrigonometricLeveling
    {
        /// <summary>
        /// 计算平距
        /// </summary>
        /// <param name="rul">尺间隔</param>
        /// <param name="vAng">竖直角</param>
        /// <returns>平距</returns>
        public double GetDis(double rul, double vAng)
        {
            double distance = 0;

            distance = 100 * rul * Math.Pow(Math.Cos(vAng / 180 * Math.PI), 2);

            return distance;
        }

        /// <summary>
        /// 计算高差
        /// </summary>
        /// <param name="dis">平距</param>
        /// <param name="vAng">竖直角</param>
        /// <param name="ins">仪器高</param>
        /// <param name="obj">目标高</param>
        /// <returns>高差</returns>
        public double GetHei(double dis, double vAng, double ins, double obj)
        {
            double heigh = 0;

            heigh = dis * Math.Tan(vAng / 180 * Math.PI) + ins - obj;

            return heigh;
        }
    }
}
