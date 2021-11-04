using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;
using System.Data;

public class ExportExcel
{
    /// <summary>
    /// 导出为Excel
    /// </summary>
    /// <param name="data">Datatable数据</param>
    /// <param name="output">导出文件的地址</param>
    public void toExcel(System.Data.DataTable data, string output)
    {
        try
        {
            //创建工作薄  
            HSSFWorkbook workbook = new HSSFWorkbook();
            //创建一个表sheet  
            Sheet sheet = workbook.CreateSheet("sheet1");
            //创建第一行,新创建的表是没有单元格的,每一个需要写入数据的单元格都要手动创建  
            Row row = sheet.CreateRow(0);

            //将列名写入表的第一行  
            for (int i = 0; i < data.Columns.Count; i++)
            {
                row.CreateCell(i);
                sheet.GetRow(0).GetCell(i).SetCellValue(data.Columns[i].ColumnName);
            }

            //写入数据  
            for (int i = 1; i <= data.Rows.Count; i++)
            {
                row = sheet.CreateRow(i);
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    row.CreateCell(j);
                    sheet.GetRow(i).GetCell(j).SetCellValue(data.Rows[i - 1][j].ToString());
                }
            }

            FileStream file = new FileStream(output, FileMode.Create);
            workbook.Write(file);
            file.Close();
        }
        catch
        {
            MessageBox.Show("错误", "Error");
        }
    }

    /// <summary>
    /// 数据转换(datagirdview to datatable)
    /// </summary>
    /// <param name="dgv">Datagridview</param>
    /// <returns>Datatable类型的数据</returns>
    public DataTable GetDgvToTable(DataGridView dgv)
    {
        DataTable dt = new DataTable();

        for (int count = 0; count < dgv.Columns.Count; count++)
        {
            DataColumn dc = new DataColumn(dgv.Columns[count].Name);
            dt.Columns.Add(dc);
        }
        for (int count = 0; count < dgv.Rows.Count; count++)
        {
            DataRow dr = dt.NewRow();
            for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
            {
                dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
            }
            dt.Rows.Add(dr);
        }
        return dt;
    }
}
