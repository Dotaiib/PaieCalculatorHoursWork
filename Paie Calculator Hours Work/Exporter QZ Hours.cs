using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Paie_Calculator_Hours_Work
{
    public partial class Exporter_QZ_Hours : Form
    {
        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");

        public Exporter_QZ_Hours()
        {
            InitializeComponent(); AfficherValue();
        }


        private void AfficherValue()
        {
            cn.Open();
            string Sql = "select distinct Id_Table from HoursCreation where HoursType = 'QZ' order by Id_Table desc";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox1.Items.Add(DR[0]); }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand(" select Matricule, FullName, The_Date, left(TimeOfEntry,5) TimeOfEntry, left(TimeOfExit,5) TimeOfExit  from HoursCreation where Id_Table = '" + comboBox1.Text + "' and HoursType = 'QZ' ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), textBox2.Text);
            }
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            ExportTOExcel(dataGridView1);

            button1.Enabled = true;
            button2.Enabled = true;
        }

        void ExportTOExcel(DataGridView dataGridView1)
        {

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //add data 
            int StartCol = 1;
            int StartRow = 1;
            int j = 0, i = 0;

            //Write Headers
            for (j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }

            StartRow++;

            //Write datagridview content
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        //string value = string.Format("{dd/MM/yyyy}", dataGridView1.Rows[i].Cells[2].FormattedValue);
                        //xlWorkSheet.Cells["Date"].NumberFormat = "d/m/yy";
                        ////myRange.EntireColumn[2].NumberFormat = "DD/MM/YYYY";
                        myRange.Cells[2].NumberFormat = "@";
                    }
                    catch
                    {
                        ;
                    }
                }
            }

            xlApp.Visible = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) { textBox2.Enabled = true; }
            else { textBox2.Enabled = false; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "") { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "") { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }
    }
}
