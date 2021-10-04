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
    public partial class Import_Cumulative : Form
    {

        SqlConnection sc = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");


        public Import_Cumulative()
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
                SqlCommand cmd = new SqlCommand("insert into cibel_liste (value,matricule,name,persnl_time) values(@value,@matricule,@name,@persnl_time) ", sc);
                cmd.Parameters.AddWithValue("@value", textBox2.Text);
                cmd.Parameters.AddWithValue("@matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@persnl_time", dataGridView1.Rows[i].Cells[2].Value.ToString());
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
            textBox1.Clear();
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel Files | *.xlsx; *.xls;";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                { this.textBox3.Text = ofd.FileName; }


                string path = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox3.Text + ";Extended Properties = \"Excel 12.0; HDR=YES\" ; ";
                OleDbConnection cn = new OleDbConnection(path);
                cn.Open();

                comboBox2.DataSource = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                comboBox2.DisplayMember = "TABLE_NAME";
                comboBox2.ValueMember = "TABLE_NAME";

                cn.Close();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                string path = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox3.Text + ";Extended Properties = \"Excel 12.0; HDR=YES\" ; ";
                OleDbConnection cn = new OleDbConnection(path);
                OleDbDataAdapter dta = new OleDbDataAdapter("Select * from [" + comboBox2.SelectedValue + "]", cn);
                DataTable dt = new DataTable();
                dta.Fill(dt);
                MessageBox.Show(dt.Rows.Count.ToString(), "Number of lines");

                foreach (DataRow row in dt.Rows)
                {
                    dataGridView2.DataSource = dt;
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 0; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into archiv_liste (value,matricule,name,persnl_time) values(@value,@matricule,@name,@persnl_time) ", sc);
                cmd.Parameters.AddWithValue("@value", textBox4.Text);
                cmd.Parameters.AddWithValue("@matricule", dataGridView2.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@name", dataGridView2.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@persnl_time", dataGridView2.Rows[i].Cells[2].Value.ToString());
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();
            }

            MessageBox.Show("The add was successful!", "Saving", MessageBoxButtons.OK);
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            DataTable dt = new DataTable();
            dataGridView2.DataSource = dt;
            dt.Rows.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "") { button3.Enabled = true; }
            else { button3.Enabled = false; }

            if (textBox4.Text != "") { button6.Enabled = true; }
            else { button6.Enabled = false; }

            textBox4.Text = textBox2.Text;
        }
    }
}
