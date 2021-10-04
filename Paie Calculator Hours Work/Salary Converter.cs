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
    public partial class Salary_Converter : Form
    {

        SqlConnection sc = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");


        public Salary_Converter()
        {
            InitializeComponent(); AfficherValue();
        }

        private void AfficherValue()
        {
            sc.Open();
            string Sql = "select distinct Id_Table from QZ_Convert_Hours order by Id_Table desc";
            SqlCommand cmd = new SqlCommand(Sql, sc);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox1.Items.Add(DR[0]); }
            sc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand(" select distinct matricule, name, Total_hours from QZ_Convert_Hours where Id_Table = '" + comboBox1.Text + "' ", sc);
            sc.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), 0, 0);
            }
            sc.Close();

            Calculation();
            //CheckTotal();

            MessageBox.Show(dataGridView1.Rows.Count.ToString(), "Number of lines");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into QZ_Calcul (Id_Table,matricule,name,Total_hours,H_Cibel,H_Blue) values(@Id_Table,@matricule,@name,@Total_hours,@H_Cibel,@H_Blue) ", sc);
                cmd.Parameters.AddWithValue("@Id_Table", comboBox1.Text);
                cmd.Parameters.AddWithValue("@matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@Total_hours", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@H_Cibel", dataGridView1.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@H_Blue", dataGridView1.Rows[i].Cells[4].Value);
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();
            }

            MessageBox.Show("The add was successful!", "Saving", MessageBoxButtons.OK);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dt.Rows.Clear();
        }

        private void Calculation()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                double C2 = double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                double C3 = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                double C4 = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());

                double TextboxValue = double.Parse(textBox1.Text);
                double S14 = 14.81;
                double S125 = 14.81 * 1.25;

                double Z1 = C2 / S14;
                double Z2 = Z1 - TextboxValue;
                double Z3 = C2 - (TextboxValue * 14.81);
                double Z4 = Z3 / S125;

                double W1 = Convert.ToDouble(Math.Round(Z1));
                double W4 = Convert.ToDouble(Math.Round(Z4));
                //double W1 = Convert.ToDouble(Z1.ToString("0.0"));
                //double W4 = Convert.ToDouble(Z4.ToString("0.0"));



                if (Z1 > TextboxValue)
                {
                    dataGridView1.Rows[i].Cells[3].Value = TextboxValue;
                    dataGridView1.Rows[i].Cells[4].Value = W4;

                }

                if (Z1 < TextboxValue)
                {
                    dataGridView1.Rows[i].Cells[3].Value = W1;
                    dataGridView1.Rows[i].Cells[4].Value = 0;
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }
    }
}
