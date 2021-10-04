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
    public partial class Cumulative_Hours : Form
    {

        SqlConnection sc = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");


        public Cumulative_Hours()
        {
            InitializeComponent(); AfficherValue();
        }

        private void AfficherValue()
        {

            sc.Open();
            string Sql = "select distinct value from cibel_liste order by value desc";
            SqlCommand cmd = new SqlCommand(Sql, sc);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox1.Items.Add(DR[0]); }
            sc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sc.Open();
            SqlCommand cmd = new SqlCommand("select cibel_liste.matricule, cibel_liste.name, right(cibel_liste.persnl_time, 6) [time], archiv_liste.matricule, archiv_liste.name, right(archiv_liste.persnl_time, 5) [time] from archiv_liste, cibel_liste where archiv_liste.matricule = cibel_liste.matricule and cibel_liste.value='" + comboBox1.Text + "' and archiv_liste.value= '" + comboBox1.Text + "' ", sc);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5));
            }
            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sc.Open();
            SqlCommand cmd = new SqlCommand("select cibel_liste.matricule, cibel_liste.name, right(cibel_liste.persnl_time, 6) [time] from cibel_liste where cibel_liste.matricule not in (select archiv_liste.matricule from archiv_liste where archiv_liste.value='" + comboBox1.Text + "') and cibel_liste.value='" + comboBox1.Text + "' ", sc);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), "", "", "00:00");
            }
            sc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into Final_Total (Id_Table,Matricule,FullName,H_Cibel,H_Blue,The_Time) values(@Id_Table,@Matricule,@FullName,@H_Cibel,@H_Blue,@The_Time) ", sc);
                cmd.Parameters.AddWithValue("@Id_Table", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@FullName", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@H_Cibel", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@H_Blue", dataGridView1.Rows[i].Cells[5].Value);
                cmd.Parameters.AddWithValue("@The_Time", DateTime.Now);
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();
            }

            MessageBox.Show("The add was successful!", "Saving", MessageBoxButtons.OK);
            button3.Enabled = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dt.Rows.Clear();
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportTOExcel(dataGridView1);
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
            if (comboBox1.Text != "") { button1.Enabled = true; button2.Enabled = true; }
            else { button1.Enabled = false; button2.Enabled = false; }
        }
    }
}
