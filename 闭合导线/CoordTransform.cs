using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 闭合导线
{
    class CoordTransform
    {
        /// <summary>
        /// 读取GCP获得转换参数
        /// </summary>
        /// <returns>转换参数(m θ Δx Δy)</returns>
        public string GCPReader(string path)
        {
            string parameter = null;//结果
            int num = 0;//测站数

            StreamReader sr = new StreamReader(path, Encoding.Default);
            num = int.Parse(sr.ReadLine());
            int i = 0;
            String[] line = new string[num];

            while ((line[i++] = sr.ReadLine()) != null){ }

            double[,] point = new double[num,4];
            for (int j = 0; j < num; j++)
            {
                string[] p = new string[4]; 
                p = line[j].Split(' ');
                for (int k = 0; k < 4; k++)
                {
                    point[j, k] = double.Parse(p[k]);
                }
            }

            return parameter;
        }

        /// <summary>
        /// 坐标正算
        /// </summary>
        /// <param name="X1">原始X1坐标</param>
        /// <param name="Y1">原始Y1坐标</param>
        /// <param name="m">坐标尺度参数</param>
        /// <param name="ang">坐标旋转角</param>
        /// <param name="xMov">X平移参数</param>
        /// <param name="yMov">Y平移参数</param>
        /// <returns>新坐标(X2 Y2)</returns>
        public string PointUp(double X1, double Y1, double m, double ang, double xMov, double yMov)
        {
            string point = null;


            return point;
        }

        /// <summary>
        /// 坐标反算
        /// </summary>
        /// <param name="X1">转换后X2坐标</param>
        /// <param name="Y1">转换后Y2坐标</param>
        /// <param name="m">坐标尺度参数</param>
        /// <param name="ang">坐标旋转角</param>
        /// <param name="xMov">X平移参数</param>
        /// <param name="yMov">Y平移参数</param>
        /// <returns>原始坐标(X1 Y1)</returns>
        public string PointDowm(double X2, double Y2, double m, double ang, double xMov, double yMov)
        {
            string point = null;


            return point;
        }
    }
}
