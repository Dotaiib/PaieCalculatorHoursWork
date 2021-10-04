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
    public partial class Total_Hours : Form
    {

        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");


        public Total_Hours()
        {
            InitializeComponent(); AfficherId();
        }

        private void AfficherId()
        {

            cn.Open();
            string Sql = "select distinct Id_Table from Final_Total order by Id_Table desc";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox1.Items.Add(DR[0]); }
            cn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand(" select distinct * from Final_Total where Id_Table= '" + comboBox1.Text + "' ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), "", "", 0, 0);
            }
            cn.Close();

            TransferHoursToFloat(); //Transferer les heures et les converter en ',' en plus changer 30 minutes en ,5 
            Calculating_44_or_more_Hours();

            MessageBox.Show(dataGridView1.Rows.Count.ToString(), "Number of lines");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into Final_Total_Calculated (Id_Table,Matricule,FullName,H_Cibel,H_Blue,NH_Cibel,NH_Blue,Prime,H_All,H_Blue_100,H_Blue_125,The_Time) values (@Id_Table,@Matricule,@FullName,@H_Cibel,@H_Blue,@NH_Cibel,@NH_Blue,@Prime,@H_All,@H_Blue_100,@H_Blue_125,@The_Time) ", cn);
                cmd.Parameters.AddWithValue("@Id_Table", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@FullName", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@H_Cibel", dataGridView1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@H_Blue", dataGridView1.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@NH_Cibel", dataGridView1.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@NH_Blue", dataGridView1.Rows[i].Cells[5].Value);
                cmd.Parameters.AddWithValue("@Prime", dataGridView1.Rows[i].Cells[6].Value);
                cmd.Parameters.AddWithValue("@H_All", dataGridView1.Rows[i].Cells[7].Value);
                cmd.Parameters.AddWithValue("@H_Blue_100", dataGridView1.Rows[i].Cells[8].Value);
                cmd.Parameters.AddWithValue("@H_Blue_125", dataGridView1.Rows[i].Cells[9].Value);
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

        private void TransferHoursToFloat()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                string C3 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                string C4 = dataGridView1.Rows[i].Cells[3].Value.ToString();


                string ReplaceCell3 = C3.Replace(':', ',');
                string ReplaceCell4 = C4.Replace(':', ',');

                string DemiHeure = ":30";
                string GetLastThreeC3 = C3.GetLast(3);
                string GetLastThreeC4 = C4.GetLast(3);

                // Heure Cibel Change
                if (GetLastThreeC3 == DemiHeure)
                {
                    float NewReplaceCell3 = float.Parse(ReplaceCell3.Insert(3, "5").RemoveLast("3"));
                    dataGridView1.Rows[i].Cells[4].Value = NewReplaceCell3;
                }
                else
                {
                    float NormalReplaceCell3 = float.Parse(ReplaceCell3);
                    dataGridView1.Rows[i].Cells[4].Value = NormalReplaceCell3;
                }

                // Heure Blue Change
                if (GetLastThreeC4 == DemiHeure)
                {
                    float NewReplaceCell4 = float.Parse(ReplaceCell4.Insert(3, "5").RemoveLast("3"));
                    dataGridView1.Rows[i].Cells[5].Value = NewReplaceCell4;
                }

                else
                {
                    float NormalReplaceCell4 = float.Parse(ReplaceCell4);
                    dataGridView1.Rows[i].Cells[5].Value = NormalReplaceCell4;
                }

            }
        }

        private void Calculating_44_or_more_Hours()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                float C5 = float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                float C6 = float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());

                float TextboxValue = float.Parse(textBox1.Text);
                float TT00 = 00;


                if (C5 < TextboxValue)
                {
                    float X1 = TextboxValue - C5;

                    if (C6 >= X1)
                    {
                        float X2 = C6 - X1;
                        dataGridView1.Rows[i].Cells[8].Value = X1;
                        dataGridView1.Rows[i].Cells[9].Value = X2;
                    }

                    if (C6 < X1)
                    {
                        dataGridView1.Rows[i].Cells[8].Value = C6;
                        dataGridView1.Rows[i].Cells[9].Value = TT00;
                    }
                }
                else
                {
                    dataGridView1.Rows[i].Cells[8].Value = TT00;
                    dataGridView1.Rows[i].Cells[9].Value = C6;
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
