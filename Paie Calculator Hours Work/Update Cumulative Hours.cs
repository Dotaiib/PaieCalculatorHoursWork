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
    public partial class Update_Cumulative_Hours : Form
    {

        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");


        public Update_Cumulative_Hours()
        {
            InitializeComponent(); AfficherValue();
        }

        private void AfficherValue()
        {
            cn.Open();
            string Sql = "select distinct value from cibel_liste order by value desc";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox1.Items.Add(DR[0]); }
            cn.Close();
        }

        private void ShowEmptyHBlue()
        {
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand(" select distinct matricule, FullName, H_Blue from Final_Total where H_Blue ='' and Id_Table = '" + comboBox1.Text + "' ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2));
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowEmptyHBlue();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(" update Final_Total set H_Blue = @H_Blue where matricule = @matricule and  Id_Table = '" + comboBox1.Text + "' ", cn);
                cmd.Parameters.AddWithValue("@H_Blue", dataGridView1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Use the row indexer here, not the fixed row at index zero
                    cmd.Parameters["@H_Blue"].Value = row.Cells["Column3"].Value.ToString();
                    cmd.Parameters["@matricule"].Value = row.Cells["Column1"].Value.ToString();
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                MessageBox.Show("The Update was successful!", "Update", MessageBoxButtons.OK);
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                dt.Rows.Clear();
                comboBox1.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "") { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }
    }
}
