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
    public partial class Calculate__X_Hour : Form
    {
        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");

        public Calculate__X_Hour()
        {
            InitializeComponent(); AfficherId();
        }

        private void AfficherId()
        {

            cn.Open();
            string Sql = "select distinct Id_Table, CONVERT(char(20), The_Time) from Paie_initial order by CONVERT(char(20), The_Time) desc";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox1.Items.Add(DR[0]); }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand(" select distinct Matricule, FullName, left(The_Date,10)[The_Date],left(Original_Time_Minutes,5)[Temps_Sortie] from Paie_initial where Id_Table = '" + comboBox1.Text + "' ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3));
            }
            cn.Close();
            Heure_Sortie_moins_minus_1H();
            MessageBox.Show(dataGridView1.Rows.Count.ToString(), "Number of lines");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into Paie_total (Id_Table,Matricule,FullName,The_Date,Entree_01,Sortie_01,Entree_02,Sortie_02,Entree_03,Sortie_03,Original_Time_Minutes,Total,Temps_Sortie,The_Time) values(@Id_Table,@Matricule,@FullName,@The_Date,@Entree_01,@Sortie_01,@Entree_02,@Sortie_02,@Entree_03,@Sortie_03,@Original_Time_Minutes,@Total,@Temps_Sortie,@The_Time) ", cn);
                cmd.Parameters.AddWithValue("@Id_Table", comboBox1.Text + "--H-1");
                cmd.Parameters.AddWithValue("@Matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@FullName", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@The_Date", dataGridView1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@Entree_01", "00:00");
                cmd.Parameters.AddWithValue("@Sortie_01", "00:00");
                cmd.Parameters.AddWithValue("@Entree_02", "00:00");
                cmd.Parameters.AddWithValue("@Sortie_02", "00:00");
                cmd.Parameters.AddWithValue("@Entree_03", "00:00");
                cmd.Parameters.AddWithValue("@Sortie_03", "00:00");
                cmd.Parameters.AddWithValue("@Original_Time_Minutes", dataGridView1.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@Total", "00:00");
                cmd.Parameters.AddWithValue("@Temps_Sortie", dataGridView1.Rows[i].Cells[4].Value.ToString());
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
            comboBox1.SelectedIndex = -1;
            cn.Close();
        }

        void Heure_Sortie_moins_minus_1H()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TimeSpan C1 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                TimeSpan Textbox = TimeSpan.Parse(textBox1.Text);

                //TimeSpan TSH1 = new TimeSpan(1, 0, 0);

                dataGridView1.Rows[i].Cells[4].Value = C1 - Textbox;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }
    }
}
