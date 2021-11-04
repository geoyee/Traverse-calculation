using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 闭合导线
{
    public sealed class Matrix
    {
        //全局变量
        int row, column;//矩阵的行列数
        double[,] data;//矩阵的数据

        #region 构造函数
        public Matrix(int rowNum, int columnNum)
        {
            row = rowNum;
            column = columnNum;
            data = new double[row, column];
        }

        public Matrix(double[,] mdatas)
        {
            row = mdatas.GetUpperBound(0) + 1;
            column = mdatas.GetUpperBound(1) + 1;
            data = new double[row, column];
            Array.Copy(mdatas, data, row * column);
        }

        public Matrix(double[] vector)
        {
            row = 1;
            column = vector.GetUpperBound(0) + 1;
            data = new double[1, column];
            for (int i = 0; i < vector.Length; i++)
            {
                data[0, i] = vector[i];
            }
        }

        public Matrix(string error)//错误矩阵
        {
            if (error == "Error")
            {
                data = new double[0, 0];
                data[0, 0] = 1;
            }
        }
        #endregion

        #region 属性和索引器
        public int rowNum { get { return row; } }
        public int columnNum { get { return column; } }

        public double this[int r, int c]
        {
            get { return data[r, c]; }
            set { data[r, c] = value; }
        }
        #endregion

        /// <summary>
        /// 将矩阵转置，得到一个新矩阵（此操作不影响原矩阵）
        /// </summary>
        /// <param name="input">要转置的矩阵</param>
        /// <returns>原矩阵经过转置得到的新矩阵</returns>
        public static Matrix transpose(Matrix input)
        {
            double[,] inverseMatrix = new double[input.column, input.row];
            for (int r = 0; r < input.row; r++)
                for (int c = 0; c < input.column; c++)
                    inverseMatrix[c, r] = input[r, c];
            return new Matrix(inverseMatrix);
        }

        /// <summary>
        /// 得到行向量
        /// </summary>
        /// <param name="r">想得到的行</param>
        /// <returns>这一行的数据</returns>
        public Matrix getRow(int r)
        {
            if (r > row || r <= 0)
                return new Matrix("Error");
            double[] a = new double[column];
            Array.Copy(data, column * (row - 1), a, 0, column);
            Matrix m = new Matrix(a);
            return m;
        }

        /// <summary>
        /// 得到列向量
        /// </summary>
        /// <param name="c">想得到的列</param>
        /// <returns>这一列的数据</returns>
        public Matrix getColumn(int c)
        {
            if (c > column || c < 0)
                return new Matrix("Error");
            double[,] a = new double[row, 1];
            for (int i = 0; i < row; i++)
                a[i, 0] = data[i, c];
            return new Matrix(a);
        }

        #region 操作符重载(+ - *)
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.row != b.row || a.column != b.column)
                return new Matrix("Error");
            Matrix result = new Matrix(a.row, a.column);
            for (int i = 0; i < a.row; i++)
                for (int j = 0; j < a.column; j++)
                    result[i, j] = a[i, j] + b[i, j];
            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            return a + b * (-1);
        }

        #region *重载
        public static Matrix operator *(Matrix matrix, double factor)
        {
            Matrix result = new Matrix(matrix.row, matrix.column);
            for (int i = 0; i < matrix.row; i++)
                for (int j = 0; j < matrix.column; j++)
                    matrix[i, j] = matrix[i, j] * factor;
            return matrix;
        }

        public static Matrix operator *(double factor, Matrix matrix)
        {
            return matrix * factor;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.column != b.row)
                return new Matrix("Error");
            Matrix result = new Matrix(a.row, b.column);
            for (int i = 0; i < a.row; i++)
                for (int j = 0; j < b.column; j++)
                    for (int k = 0; k < a.column; k++)
                        result[i, j] += a[i, k] * b[k, j];

            return result;
        }
        #endregion
        #endregion
    }
}
