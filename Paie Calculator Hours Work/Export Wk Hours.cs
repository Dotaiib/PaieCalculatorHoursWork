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
    public partial class Export_Wk_Hours : Form
    {

        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");

        public Export_Wk_Hours()
        {
            InitializeComponent(); AfficherValue();
        }

        BackgroundWorker bgw = new BackgroundWorker();


        private void AfficherValue()
        {
            cn.Open();
            string Sql = "select distinct Id_Table from HoursCreation where HoursType = 'WK' order by Id_Table desc";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox1.Items.Add(DR[0]); }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand(" select Matricule, FullName, The_Date, left(TimeOfEntry,5) TimeOfEntry, left(TimeOfExit,5) TimeOfExit  from HoursCreation where Id_Table = '" + comboBox1.Text + "' and HoursType = 'WK' ", cn);
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
            /*bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();
            progressBar1.Visible = true;
            label2.Visible = true;*/

            button1.Enabled = false;
            button2.Enabled = false;

            ExportTOExcel(dataGridView1);

            button1.Enabled = true;
            button2.Enabled = true;
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = 25; //some number (this is your variable to change)!!


            for (int i = 0; i <= total; i++) //some number (total)
            {
                System.Threading.Thread.Sleep(100);
                int percents = (i * 90) / total;
                bgw.ReportProgress(percents, i);
                //2 arguments:
                //1. procenteges (from 0 t0 100) - i do a calcumation 
                //2. some current value!

            }
            
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label2.Text = String.Format("Progress: {0} %", e.ProgressPercentage);
            //label3.Text = String.Format("Total items transfered: {0}", e.UserState);
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //do the code when bgv completes its work

            progressBar1.Visible = false;
            label2.Visible = false;
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
