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
    public partial class DataEntry : Form
    {
        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");

        public DataEntry()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel Files | *.xlsx; *.xls;";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                { this.textBox1.Text = ofd.FileName; }


                string path = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + ";Extended Properties = \"Excel 12.0; HDR=YES\" ; ";
                OleDbConnection cn = new OleDbConnection(path);
                cn.Open();

                comboBox1.DataSource = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                comboBox1.DisplayMember = "TABLE_NAME";
                comboBox1.ValueMember = "TABLE_NAME";

                cn.Close();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string path = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + ";Extended Properties = \"Excel 12.0; HDR=YES\" ; ";
                OleDbConnection cn = new OleDbConnection(path);
                OleDbDataAdapter dta = new OleDbDataAdapter("Select * from [" + comboBox1.SelectedValue + "]", cn);
                DataTable dt = new DataTable();
                dta.Fill(dt);
                MessageBox.Show(dt.Rows.Count.ToString(), "Number of lines");


                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.DataSource = dt;
                }

            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into Paie_initial (Id_Table,Matricule,FullName,The_Date,Entree_01,Sortie_01,Entree_02,Sortie_02,Entree_03,Sortie_03,Original_Time_Minutes,The_Time) values(@Id_Table,@Matricule,@FullName,@The_Date,@Entree_01,@Sortie_01,@Entree_02,@Sortie_02,@Entree_03,@Sortie_03,@Original_Time_Minutes,@The_Time) ", cn);
                cmd.Parameters.AddWithValue("@Id_Table", textBox2.Text);
                cmd.Parameters.AddWithValue("@Matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@FullName", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@The_Date", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@Entree_01", dataGridView1.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@Sortie_01", dataGridView1.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@Entree_02", dataGridView1.Rows[i].Cells[5].Value);
                cmd.Parameters.AddWithValue("@Sortie_02", dataGridView1.Rows[i].Cells[6].Value);
                cmd.Parameters.AddWithValue("@Entree_03", dataGridView1.Rows[i].Cells[7].Value);
                cmd.Parameters.AddWithValue("@Sortie_03", dataGridView1.Rows[i].Cells[8].Value);
                cmd.Parameters.AddWithValue("@Original_Time_Minutes", dataGridView1.Rows[i].Cells[9].Value);
                cmd.Parameters.AddWithValue("@The_Time", DateTime.Now);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            MessageBox.Show("The add was successful!", "Saving", MessageBoxButtons.OK);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dt.Rows.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "") { button3.Enabled = true; }
            else { button3.Enabled = false; }
        }

        private void Calculate8HoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate_8_Hours NewForm = new Calculate_8_Hours();
            NewForm.ShowDialog();
        }

        private void Calculate7HoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate_7_Hours NewForm = new Calculate_7_Hours();
            NewForm.ShowDialog();
        }

        private void Calculate4HoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate_4_Hours NewForm = new Calculate_4_Hours();
            NewForm.ShowDialog();
        }

        private void CalculateXHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate__X_Hour NewForm = new Calculate__X_Hour();
            NewForm.ShowDialog();
        }

        private void exportCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export_Calculation NewForm = new Export_Calculation();
            NewForm.ShowDialog();
        }

        private void importCumulativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Cumulative NewForm = new Import_Cumulative();
            NewForm.ShowDialog();
        }

        private void cumulativeHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cumulative_Hours NewForm = new Cumulative_Hours();
            NewForm.ShowDialog();
        }

        private void updateCumulativeHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Cumulative_Hours NewForm = new Update_Cumulative_Hours();
            NewForm.ShowDialog();
        }

        private void totalHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Total_Hours NewForm = new Total_Hours();
            NewForm.ShowDialog();
        }

        private void exportTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export_Total NewForm = new Export_Total();
            NewForm.ShowDialog();
        }

        private void importExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Salaries NewForm = new Import_Salaries();
            NewForm.ShowDialog();
        }

        private void salaryConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Converter NewForm = new Salary_Converter();
            NewForm.ShowDialog();
        }

        private void exportQZTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export_QZ_Total NewForm = new Export_QZ_Total();
            NewForm.ShowDialog();
        }

        private void importMatriculesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Import_QZ_Matricules NewForm = new Import_QZ_Matricules();
            NewForm.ShowDialog();
        }

        private void qZHoursNormalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QZ_Hours_Cibel_Normal NewForm = new QZ_Hours_Cibel_Normal();
            NewForm.ShowDialog();
        }

        private void qZHoursRestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QZ_Hours_Cibel_Rest NewForm = new QZ_Hours_Cibel_Rest();
            NewForm.ShowDialog();
        }

        private void qZHoursArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QZ_Hours_Archive NewForm = new QZ_Hours_Archive();
            NewForm.ShowDialog();
        }

        private void importMatriculesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Matricules NewForm = new Import_Matricules();
            NewForm.ShowDialog();
        }

        private void fMHoursCibelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WK_Hours_Cibel NewForm = new WK_Hours_Cibel();
            NewForm.ShowDialog();
        }

        private void fMHoursBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WK_Hours_Blue NewForm = new WK_Hours_Blue();
            NewForm.ShowDialog();
        }

        private void exportQZHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exporter_QZ_Hours NewForm = new Exporter_QZ_Hours();
            NewForm.ShowDialog();
        }

        private void exportFmHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export_Wk_Hours NewForm = new Export_Wk_Hours();
            NewForm.ShowDialog();
        }


        private void clearCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(" BEGIN DELETE FROM    Paie_initial  DELETE FROM    Paie_total END ", cn);
            var result = MessageBox.Show("Are you sure you want to clear the Calculation?", "Clear Calculation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteReader();

            }
            cn.Close();
        }

        private void clearCumulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(" BEGIN DELETE FROM    cibel_liste  DELETE FROM    archiv_liste END ", cn);
            var result = MessageBox.Show("Are you sure you want to clear the Cumul?", "Clear Cumul", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteReader();

            }
            cn.Close();
        }

        private void clearTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(" BEGIN DELETE FROM    Final_Total  DELETE FROM    Final_Total_Calculated END ", cn);
            var result = MessageBox.Show("Are you sure you want to clear the Total?", "Clear Total", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteReader();

            }
            cn.Close();
        }

        private void clearConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(" BEGIN DELETE FROM    QZ_Convert_Hours DELETE FROM    QZ_Calcul END ", cn);
            var result = MessageBox.Show("Are you sure you want to clear the Converter?", "Clear Converter", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteReader();
            }
            cn.Close();
        }

        private void clearCOfHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(" BEGIN DELETE FROM    FM_Hours DELETE FROM    HoursCreation END ", cn);
            var result = MessageBox.Show("Are you sure you want to clear the Creation of Hours?", "Clear Creation of Hours", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteReader();
            }
            cn.Close();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(" BEGIN DELETE FROM QZ_Convert_Hours DELETE FROM    QZ_Calcul DELETE FROM Final_Total  DELETE FROM    Final_Total_Calculated DELETE FROM cibel_liste  DELETE FROM    archiv_liste DELETE FROM Paie_initial  DELETE FROM    Paie_total  DELETE FROM    QZ_Convert_Hours DELETE FROM    QZ_Calcul  DELETE FROM    FM_Hours DELETE FROM    HoursCreation END ", cn);
            var result = MessageBox.Show("Are you sure you want to clear All?", "Clear All", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteReader();
            }
            cn.Close();
        }


    }
}
