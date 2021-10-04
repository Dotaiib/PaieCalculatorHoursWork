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
    public partial class QZ_Hours_Cibel_Rest : Form
    {

        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");


        public QZ_Hours_Cibel_Rest()
        {
            InitializeComponent(); AfficherValue();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void AfficherValue()
        {
            cn.Open();
            string Sql = "select distinct Id_Table from QZ_Calcul order by Id_Table desc";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox1.Items.Add(DR[0]); }
            cn.Close();
        }

        private void AfficherMatricule()
        {
            cn.Open();
            string Sql = "select distinct Matricule from QZ_Calcul where Id_Table = '"+comboBox1.Text+ "' and H_Cibel < '"+textBox2.Text+"' ";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox3.Items.Add(DR[0]); }
            cn.Close();
        }

        private void AfficherH_Cibel()
        {
            cn.Open();
            string Sql = "select distinct H_Cibel from QZ_Calcul where Id_Table = '" + comboBox1.Text + "' and matricule = '" + comboBox3.Text+"' ";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { textBox1.Text = DR[0].ToString(); }
            cn.Close();
        }

        TimeSpan TSHMRandom0555 = new TimeSpan(5, 55, 0);
        TimeSpan TSHMRandom0556 = new TimeSpan(5, 56, 0);
        TimeSpan TSHMRandom0557 = new TimeSpan(5, 57, 0);
        TimeSpan TSHMRandom0558 = new TimeSpan(5, 58, 0);
        TimeSpan TSHMRandom0559 = new TimeSpan(5, 59, 0);
        TimeSpan TSHMRandom0600 = new TimeSpan(6, 00, 0);
        TimeSpan TSHMRandom0601 = new TimeSpan(6, 01, 0);
        TimeSpan TSHMRandom0602 = new TimeSpan(6, 02, 0);
        TimeSpan TSHMRandom0603 = new TimeSpan(6, 03, 0);
        TimeSpan TSHMRandom0604 = new TimeSpan(6, 04, 0);
        TimeSpan TSHMRandom0605 = new TimeSpan(6, 05, 0);
        TimeSpan TSHMRandom0606 = new TimeSpan(6, 06, 0);
        TimeSpan TSHMRandom0607 = new TimeSpan(6, 07, 0);
        TimeSpan TSHMRandom0608 = new TimeSpan(6, 08, 0);
        TimeSpan TSHMRandom0609 = new TimeSpan(6, 09, 0);
        TimeSpan TSHMRandom0610 = new TimeSpan(6, 10, 0);
        TimeSpan TSHMRandom0611 = new TimeSpan(6, 11, 0);
        TimeSpan TSHMRandom0612 = new TimeSpan(6, 12, 0);
        TimeSpan TSHMRandom0613 = new TimeSpan(6, 13, 0);

        TimeSpan TSHMRandom1355 = new TimeSpan(13, 55, 0);
        TimeSpan TSHMRandom1356 = new TimeSpan(13, 56, 0);
        TimeSpan TSHMRandom1357 = new TimeSpan(13, 57, 0);
        TimeSpan TSHMRandom1358 = new TimeSpan(13, 58, 0);
        TimeSpan TSHMRandom1359 = new TimeSpan(13, 59, 0);
        TimeSpan TSHMRandom1400 = new TimeSpan(14, 00, 0);
        TimeSpan TSHMRandom1401 = new TimeSpan(14, 01, 0);
        TimeSpan TSHMRandom1402 = new TimeSpan(14, 02, 0);
        TimeSpan TSHMRandom1403 = new TimeSpan(14, 03, 0);
        TimeSpan TSHMRandom1404 = new TimeSpan(14, 04, 0);
        TimeSpan TSHMRandom1405 = new TimeSpan(14, 05, 0);
        TimeSpan TSHMRandom1406 = new TimeSpan(14, 06, 0);
        TimeSpan TSHMRandom1407 = new TimeSpan(14, 07, 0);
        TimeSpan TSHMRandom1408 = new TimeSpan(14, 08, 0);
        TimeSpan TSHMRandom1409 = new TimeSpan(14, 09, 0);
        TimeSpan TSHMRandom1410 = new TimeSpan(14, 10, 0);
        TimeSpan TSHMRandom1411 = new TimeSpan(14, 11, 0);
        TimeSpan TSHMRandom1412 = new TimeSpan(14, 12, 0);
        TimeSpan TSHMRandom1413 = new TimeSpan(14, 13, 0);

        TimeSpan TSHMRandom0955 = new TimeSpan(09, 55, 0);
        TimeSpan TSHMRandom0956 = new TimeSpan(09, 56, 0);
        TimeSpan TSHMRandom0957 = new TimeSpan(09, 57, 0);
        TimeSpan TSHMRandom0958 = new TimeSpan(09, 58, 0);
        TimeSpan TSHMRandom0959 = new TimeSpan(09, 59, 0);
        TimeSpan TSHMRandom1000 = new TimeSpan(10, 00, 0);
        TimeSpan TSHMRandom1001 = new TimeSpan(10, 01, 0);
        TimeSpan TSHMRandom1002 = new TimeSpan(10, 02, 0);
        TimeSpan TSHMRandom1003 = new TimeSpan(10, 03, 0);
        TimeSpan TSHMRandom1004 = new TimeSpan(10, 04, 0);
        TimeSpan TSHMRandom1005 = new TimeSpan(10, 05, 0);
        TimeSpan TSHMRandom1006 = new TimeSpan(10, 06, 0);
        TimeSpan TSHMRandom1007 = new TimeSpan(10, 07, 0);
        TimeSpan TSHMRandom1008 = new TimeSpan(10, 08, 0);
        TimeSpan TSHMRandom1009 = new TimeSpan(10, 09, 0);
        TimeSpan TSHMRandom1010 = new TimeSpan(10, 10, 0);
        TimeSpan TSHMRandom1011 = new TimeSpan(10, 11, 0);
        TimeSpan TSHMRandom1012 = new TimeSpan(10, 12, 0);
        TimeSpan TSHMRandom1013 = new TimeSpan(10, 13, 0);

        TimeSpan TSEnde = new TimeSpan(99,99,99,99);

        string Mon = "Monday";
        string Tue = "Tuesday";
        string Wed = "Wednesday";
        string Thu = "Thursday";
        string Fri = "Friday";
        string Sat = "Saturday";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(" select distinct matricule, name, H_Cibel from QZ_Calcul where Id_Table = '" + comboBox1.Text + "' and Matricule = '" + comboBox3.Text + "' ", cn);
            cn.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int NbrDays01 = 01;
            int NbrDays14 = 14;
            int NbrDays15 = 15;
            int NbrDays16 = 16;
            int NbrDays30 = 30;
            int NbrDays31 = 31;

            DateTime FirstPickerDate = dateTimePicker1.Value;
            DateTime SecndPickerDate = dateTimePicker2.Value;
            TimeSpan TotalPickerDate = SecndPickerDate - FirstPickerDate;


            int differenceInDays = TotalPickerDate.Days;
            string differenceAsString = differenceInDays.ToString();

            if(differenceInDays <= NbrDays15 && differenceInDays >= NbrDays14) 

            {
                if ((dateTimePicker1.Value.Day == NbrDays01 || dateTimePicker1.Value.Day == NbrDays16) && (dateTimePicker2.Value.Day == NbrDays15 || dateTimePicker2.Value.Day == NbrDays30 || dateTimePicker2.Value.Day == NbrDays31))
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var startDate = dateTimePicker1;
                        var endDate = dateTimePicker2;

                        for (DateTime counter = startDate.Value; counter <= endDate.Value; counter = counter.AddDays(1))
                        {
                            if (counter.DayOfWeek != DayOfWeek.Sunday)
                                dataGridView1.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), counter);
                        }

                        if (comboBox2.SelectedItem != null)
                        {
                            if(checkBox1.Checked == true)
                            {
                                QZRestAdd15days();
                                ChangeCalculatedNumberToHours();
                            }

                            if (checkBox2.Checked == true)
                            {
                                QZRestAdd16days();
                                ChangeCalculatedNumberToHours();
                            }
                        }

                        cn.Close();
                        if (comboBox3.SelectedIndex < comboBox3.Items.Count - 1)
                        {
                            comboBox3.SelectedIndex = comboBox3.SelectedIndex + 1;
                        }
                        else
                        {                            
                            comboBox3.SelectedIndex = -1;
                            //comboBox1.SelectedIndex = -1;
                            textBox1.Clear();
                            //button1.Enabled = false;
                            button2.Enabled = true;
                        }
                        cn.Open();
                    }
                }

                else
                {
                    MessageBox.Show("Change The Date: " + Environment.NewLine +
                        "" + Environment.NewLine +
                        "*/ First Date should be either 01 or 16" + Environment.NewLine +
                        "*/ Last Date should be either 15, 30 or 31",
                        "Error Date",
                        MessageBoxButtons.OK);
                }
            }
            
            else { MessageBox.Show("Please Check The Date, The date cannot be more than 16 days"); }


            label2.Text = dataGridView1.Rows.Count.ToString();
            label4.Text = dataGridView2.Rows.Count.ToString();
            cn.Close();            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into HoursCreation (Id_Table,Matricule,FullName,TotalHours,The_Date,TheDay,TimeOfEntry,TimeOfExit,HoursType,Company) values(@Id_Table,@Matricule,@FullName,@TotalHours,@The_Date,@TheDay,@TimeOfEntry,@TimeOfExit,@HoursType,@Company) ", cn);
                cmd.Parameters.AddWithValue("@Id_Table", comboBox1.Text + "_QZCibelR");
                cmd.Parameters.AddWithValue("@Matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@FullName", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@TotalHours", dataGridView1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@The_Date", dataGridView1.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@TheDay", dataGridView2.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@TimeOfEntry", dataGridView2.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@TimeOfExit", dataGridView2.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@HoursType", "QZ");
                cmd.Parameters.AddWithValue("@Company", "Cibel");

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            MessageBox.Show("The add was successful!", "Saving", MessageBoxButtons.OK);
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            //button1.Enabled = true;
            button2.Enabled = false;
            cn.Close();
        }

        private void QZRestAdd15days()
        {
            Random rand = new Random();

            //All Entrys
            //*************************************Monday*************************************
            TimeSpan[] selectableIntsEnM01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryMo1 = selectableIntsEnM01[rand.Next(0, selectableIntsEnM01.Length)];

            TimeSpan[] selectableIntsEnM02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryMo2 = selectableIntsEnM02[rand.Next(0, selectableIntsEnM02.Length)];

            TimeSpan[] selectableIntsEnM03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryMo3 = selectableIntsEnM03[rand.Next(0, selectableIntsEnM03.Length)];

            //*************************************Tuesday*************************************
            TimeSpan[] selectableIntsEnTu01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTu1 = selectableIntsEnTu01[rand.Next(0, selectableIntsEnTu01.Length)];

            TimeSpan[] selectableIntsEnTu02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTu2 = selectableIntsEnTu02[rand.Next(0, selectableIntsEnTu02.Length)];

            TimeSpan[] selectableIntsEnTu03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTu3 = selectableIntsEnTu03[rand.Next(0, selectableIntsEnTu03.Length)];

            //*************************************Wednesday*************************************
            TimeSpan[] selectableIntsEnW01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryWe1 = selectableIntsEnW01[rand.Next(0, selectableIntsEnW01.Length)];

            TimeSpan[] selectableIntsEnW02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryWe2 = selectableIntsEnW02[rand.Next(0, selectableIntsEnW02.Length)];

            TimeSpan[] selectableIntsEnW03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryWe3 = selectableIntsEnW03[rand.Next(0, selectableIntsEnW03.Length)];

            //*************************************Thursday*************************************
            TimeSpan[] selectableIntsEnTs01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTs1 = selectableIntsEnTs01[rand.Next(0, selectableIntsEnTs01.Length)];

            TimeSpan[] selectableIntsEnTs02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTs2 = selectableIntsEnTs02[rand.Next(0, selectableIntsEnTs02.Length)];

            TimeSpan[] selectableIntsEnTs03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTs3 = selectableIntsEnTs03[rand.Next(0, selectableIntsEnTs03.Length)];

            //*************************************Friday*************************************
            TimeSpan[] selectableIntsEnF01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryFr1 = selectableIntsEnF01[rand.Next(0, selectableIntsEnF01.Length)];

            TimeSpan[] selectableIntsEnF02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryFr2 = selectableIntsEnF02[rand.Next(0, selectableIntsEnF02.Length)];

            TimeSpan[] selectableIntsEnF03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryFr3 = selectableIntsEnF03[rand.Next(0, selectableIntsEnF03.Length)];

            //*************************************Saturday*************************************
            TimeSpan[] selectableIntsEnS01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntrySa1 = selectableIntsEnS01[rand.Next(0, selectableIntsEnS01.Length)];

            TimeSpan[] selectableIntsEnS02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntrySa2 = selectableIntsEnS02[rand.Next(0, selectableIntsEnS02.Length)];

            TimeSpan[] selectableIntsEnS03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntrySa3 = selectableIntsEnS03[rand.Next(0, selectableIntsEnS03.Length)];


            //All Exits
            //*************************************Monday*************************************
            TimeSpan[] selectableIntsExM01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitMo1 = selectableIntsExM01[rand.Next(0, selectableIntsExM01.Length)];

            TimeSpan[] selectableIntsExM02 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitMo2 = selectableIntsExM02[rand.Next(0, selectableIntsExM02.Length)];

            TimeSpan[] selectableIntsExM03 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitMo3 = selectableIntsExM03[rand.Next(0, selectableIntsExM03.Length)];

            //*************************************Tuesday*************************************
            TimeSpan[] selectableIntsExTu01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTu1 = selectableIntsExTu01[rand.Next(0, selectableIntsExTu01.Length)];

            TimeSpan[] selectableIntsExTu02 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTu2 = selectableIntsExTu02[rand.Next(0, selectableIntsExTu02.Length)];

            TimeSpan[] selectableIntsExTu03 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTu3 = selectableIntsExTu03[rand.Next(0, selectableIntsExTu03.Length)];

            //*************************************Wednesday*************************************
            TimeSpan[] selectableIntsExW01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitWe1 = selectableIntsExW01[rand.Next(0, selectableIntsExW01.Length)];

            TimeSpan[] selectableIntsExW02 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitWe2 = selectableIntsExW02[rand.Next(0, selectableIntsExW02.Length)];

            TimeSpan[] selectableIntsExW03 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitWe3 = selectableIntsExW03[rand.Next(0, selectableIntsExW03.Length)];

            //*************************************Thursday*************************************
            TimeSpan[] selectableIntsExTs01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTs1 = selectableIntsExTs01[rand.Next(0, selectableIntsExTs01.Length)];

            TimeSpan[] selectableIntsExTs02 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTs2 = selectableIntsExTs02[rand.Next(0, selectableIntsExTs02.Length)];

            TimeSpan[] selectableIntsExTs03 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTs3 = selectableIntsExTs03[rand.Next(0, selectableIntsExTs03.Length)];

            //*************************************Friday*************************************
            TimeSpan[] selectableIntsExF01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitFr1 = selectableIntsExF01[rand.Next(0, selectableIntsExF01.Length)];

            TimeSpan[] selectableIntsExF02 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitFr2 = selectableIntsExF02[rand.Next(0, selectableIntsExF02.Length)];

            TimeSpan[] selectableIntsExF03 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitFr3 = selectableIntsExF03[rand.Next(0, selectableIntsExF03.Length)];

            //*************************************Saturday*************************************
            TimeSpan[] selectableIntsExS01 = new TimeSpan[19] { TSHMRandom0955, TSHMRandom0956, TSHMRandom0957, TSHMRandom0958, TSHMRandom0959, TSHMRandom1000, TSHMRandom1001, TSHMRandom1002, TSHMRandom1003, TSHMRandom1004, TSHMRandom1005, TSHMRandom1006, TSHMRandom1007, TSHMRandom1008, TSHMRandom1009, TSHMRandom1010, TSHMRandom1011, TSHMRandom1012, TSHMRandom1013 };
            TimeSpan randomValueFirstExitSa1 = selectableIntsExS01[rand.Next(0, selectableIntsExS01.Length)];

            TimeSpan[] selectableIntsExS02 = new TimeSpan[19] { TSHMRandom0955, TSHMRandom0956, TSHMRandom0957, TSHMRandom0958, TSHMRandom0959, TSHMRandom1000, TSHMRandom1001, TSHMRandom1002, TSHMRandom1003, TSHMRandom1004, TSHMRandom1005, TSHMRandom1006, TSHMRandom1007, TSHMRandom1008, TSHMRandom1009, TSHMRandom1010, TSHMRandom1011, TSHMRandom1012, TSHMRandom1013 };
            TimeSpan randomValueFirstExitSa2 = selectableIntsExS02[rand.Next(0, selectableIntsExS02.Length)];

            TimeSpan[] selectableIntsExS03 = new TimeSpan[19] { TSHMRandom0955, TSHMRandom0956, TSHMRandom0957, TSHMRandom0958, TSHMRandom0959, TSHMRandom1000, TSHMRandom1001, TSHMRandom1002, TSHMRandom1003, TSHMRandom1004, TSHMRandom1005, TSHMRandom1006, TSHMRandom1007, TSHMRandom1008, TSHMRandom1009, TSHMRandom1010, TSHMRandom1011, TSHMRandom1012, TSHMRandom1013 };
            TimeSpan randomValueFirstExitSa3 = selectableIntsExS03[rand.Next(0, selectableIntsExS03.Length)];

            double RestTT00 = Convert.ToDouble(textBox1.Text);
            double RestTT04 = Convert.ToDouble(textBox1.Text) - 04;
            double RestTT08 = Convert.ToDouble(textBox1.Text) - 08;
            double RestTT12 = Convert.ToDouble(textBox1.Text) - 12;
            double RestTT16 = Convert.ToDouble(textBox1.Text) - 16;
            double RestTT20 = Convert.ToDouble(textBox1.Text) - 20;
            double RestTT24 = Convert.ToDouble(textBox1.Text) - 24;
            double RestTT28 = Convert.ToDouble(textBox1.Text) - 28;
            double RestTT32 = Convert.ToDouble(textBox1.Text) - 32;
            double RestTT36 = Convert.ToDouble(textBox1.Text) - 36;
            double RestTT40 = Convert.ToDouble(textBox1.Text) - 40;
            double RestTT44 = Convert.ToDouble(textBox1.Text) - 44;
            double RestTT48 = Convert.ToDouble(textBox1.Text) - 48;
            double RestTT52 = Convert.ToDouble(textBox1.Text) - 52;
            double RestTT56 = Convert.ToDouble(textBox1.Text) - 56;
            double RestTT60 = Convert.ToDouble(textBox1.Text) - 60;
            double RestTT64 = Convert.ToDouble(textBox1.Text) - 64;
            double RestTT68 = Convert.ToDouble(textBox1.Text) - 68;
            double RestTT72 = Convert.ToDouble(textBox1.Text) - 72;
            double RestTT76 = Convert.ToDouble(textBox1.Text) - 76;
            double RestTT80 = Convert.ToDouble(textBox1.Text) - 80;
            double RestTT84 = Convert.ToDouble(textBox1.Text) - 84;
            double RestTT88 = Convert.ToDouble(textBox1.Text) - 88;
            double RestTT92 = Convert.ToDouble(textBox1.Text) - 92;
            double RestTT96 = Convert.ToDouble(textBox1.Text) - 96;
            double RestTT104= Convert.ToDouble(textBox1.Text) - 104;
            double RestTT112= Convert.ToDouble(textBox1.Text) - 112;


            if (comboBox2.SelectedItem.ToString() == "Monday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, RestTT00);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, RestTT08);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 16)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 24 && Convert.ToDouble(textBox1.Text) > 16)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, RestTT16);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 24)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 32 && Convert.ToDouble(textBox1.Text) > 24)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, RestTT24);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 32)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 40 && Convert.ToDouble(textBox1.Text) > 32)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT32);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 40)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 40)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT40);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT44);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 60 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT52);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 60)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 68 && Convert.ToDouble(textBox1.Text) > 60)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT60);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 68)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 76 && Convert.ToDouble(textBox1.Text) > 68)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT68);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 76)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 84 && Convert.ToDouble(textBox1.Text) > 76)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT76);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 84)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 84)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT84);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT88);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                }
            }


            if (comboBox2.SelectedItem.ToString() == "Tuesday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, RestTT00);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, RestTT08);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 16)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 24 && Convert.ToDouble(textBox1.Text) > 16)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, RestTT16);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 24)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 32 && Convert.ToDouble(textBox1.Text) > 24)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT24);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 32)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 36 && Convert.ToDouble(textBox1.Text) > 32)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT32);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 36)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 36)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, RestTT36);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT44);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 60 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT52);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 60)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 68 && Convert.ToDouble(textBox1.Text) > 60)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT60);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 68)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 76 && Convert.ToDouble(textBox1.Text) > 68)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT68);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 76)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 80 && Convert.ToDouble(textBox1.Text) > 76)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT76);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 80)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 80)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT80);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT88);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                }
            }


            if (comboBox2.SelectedItem.ToString() == "Wednesday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, RestTT00);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, RestTT08);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 16)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 24 && Convert.ToDouble(textBox1.Text) > 16)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT16);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 24)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 28 && Convert.ToDouble(textBox1.Text) > 24)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT24);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 28)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 36 && Convert.ToDouble(textBox1.Text) > 28)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT28);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 36)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 36)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT36);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT44);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 60 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT52);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 60)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 68 && Convert.ToDouble(textBox1.Text) > 60)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT60);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 68)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 72 && Convert.ToDouble(textBox1.Text) > 68)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT68);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 72)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 80 && Convert.ToDouble(textBox1.Text) > 72)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT72);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 80)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 80)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT80);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, RestTT88);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe2);
                }
            }


            if (comboBox2.SelectedItem.ToString() == "Thursday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, RestTT00);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT08);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 16)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 20 && Convert.ToDouble(textBox1.Text) > 16)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT16);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 20)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 28 && Convert.ToDouble(textBox1.Text) > 20)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT20);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 28)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 36 && Convert.ToDouble(textBox1.Text) > 28)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT28);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 36)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 36)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT36);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT44);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 60 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT52);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 60)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 64 && Convert.ToDouble(textBox1.Text) > 60)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT60);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 64)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 72 && Convert.ToDouble(textBox1.Text) > 64)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT64);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 72)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 80 && Convert.ToDouble(textBox1.Text) > 72)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT72);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 80)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 80)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, RestTT80);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, RestTT88);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                }
            }


            if (comboBox2.SelectedItem.ToString() == "Friday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT00);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 12 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT08);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 12)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 20 && Convert.ToDouble(textBox1.Text) > 12)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT12);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 20)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 28 && Convert.ToDouble(textBox1.Text) > 20)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT20);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 28)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 36 && Convert.ToDouble(textBox1.Text) > 28)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT28);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 36)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 36)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT36);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT44);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 56 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT52);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 56)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 64 && Convert.ToDouble(textBox1.Text) > 56)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT56);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 64)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 72 && Convert.ToDouble(textBox1.Text) > 64)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT64);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 72)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 80 && Convert.ToDouble(textBox1.Text) > 72)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, RestTT72);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 80)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 80)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, RestTT80);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, RestTT88);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                }
            }


            if (comboBox2.SelectedItem.ToString() == "Saturday")
            {
                if (Convert.ToDouble(textBox1.Text) < 4 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT00);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 4)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 12 && Convert.ToDouble(textBox1.Text) > 4)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT04);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 12)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 20 && Convert.ToDouble(textBox1.Text) > 12)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT12);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 20)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 28 && Convert.ToDouble(textBox1.Text) > 20)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT20);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 28)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 36 && Convert.ToDouble(textBox1.Text) > 28)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT28);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 36)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 36)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT36);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 48 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT44);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 48)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 56 && Convert.ToDouble(textBox1.Text) > 48)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT48);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 56)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 64 && Convert.ToDouble(textBox1.Text) > 56)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT56);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 64)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 72 && Convert.ToDouble(textBox1.Text) > 64)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, RestTT64);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 72)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 80 && Convert.ToDouble(textBox1.Text) > 72)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, RestTT72);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 80)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 80)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, RestTT80);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 92 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa3, RestTT88);
                }

                if (Convert.ToDouble(textBox1.Text) == 92)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa3, randomValueFirstExitSa3);
                }
            }


            if (comboBox2.SelectedItem.ToString() == "Sunday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, RestTT00);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, RestTT08);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 16)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 24 && Convert.ToDouble(textBox1.Text) > 16)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, RestTT16);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 24)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 32 && Convert.ToDouble(textBox1.Text) > 24)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, RestTT24);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 32)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 40 && Convert.ToDouble(textBox1.Text) > 32)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT32);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 40)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 40)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT40);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT44);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 60 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT52);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 60)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 68 && Convert.ToDouble(textBox1.Text) > 60)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT60);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 68)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 76 && Convert.ToDouble(textBox1.Text) > 68)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT68);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 76)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 84 && Convert.ToDouble(textBox1.Text) > 76)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT76);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 84)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 84)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT84);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                }

            }


        }

        private void QZRestAdd16days()
        {
            Random rand = new Random();

            //All Entrys
            //*************************************Monday*************************************
            TimeSpan[] selectableIntsEnM01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryMo1 = selectableIntsEnM01[rand.Next(0, selectableIntsEnM01.Length)];

            TimeSpan[] selectableIntsEnM02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryMo2 = selectableIntsEnM02[rand.Next(0, selectableIntsEnM02.Length)];

            TimeSpan[] selectableIntsEnM03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryMo3 = selectableIntsEnM03[rand.Next(0, selectableIntsEnM03.Length)];

            //*************************************Tuesday*************************************
            TimeSpan[] selectableIntsEnTu01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTu1 = selectableIntsEnTu01[rand.Next(0, selectableIntsEnTu01.Length)];

            TimeSpan[] selectableIntsEnTu02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTu2 = selectableIntsEnTu02[rand.Next(0, selectableIntsEnTu02.Length)];

            TimeSpan[] selectableIntsEnTu03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTu3 = selectableIntsEnTu03[rand.Next(0, selectableIntsEnTu03.Length)];

            //*************************************Wednesday*************************************
            TimeSpan[] selectableIntsEnW01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryWe1 = selectableIntsEnW01[rand.Next(0, selectableIntsEnW01.Length)];

            TimeSpan[] selectableIntsEnW02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryWe2 = selectableIntsEnW02[rand.Next(0, selectableIntsEnW02.Length)];

            TimeSpan[] selectableIntsEnW03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryWe3 = selectableIntsEnW03[rand.Next(0, selectableIntsEnW03.Length)];

            //*************************************Thursday*************************************
            TimeSpan[] selectableIntsEnTs01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTs1 = selectableIntsEnTs01[rand.Next(0, selectableIntsEnTs01.Length)];

            TimeSpan[] selectableIntsEnTs02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTs2 = selectableIntsEnTs02[rand.Next(0, selectableIntsEnTs02.Length)];

            TimeSpan[] selectableIntsEnTs03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTs3 = selectableIntsEnTs03[rand.Next(0, selectableIntsEnTs03.Length)];

            //*************************************Friday*************************************
            TimeSpan[] selectableIntsEnF01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryFr1 = selectableIntsEnF01[rand.Next(0, selectableIntsEnF01.Length)];

            TimeSpan[] selectableIntsEnF02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryFr2 = selectableIntsEnF02[rand.Next(0, selectableIntsEnF02.Length)];

            TimeSpan[] selectableIntsEnF03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryFr3 = selectableIntsEnF03[rand.Next(0, selectableIntsEnF03.Length)];

            //*************************************Saturday*************************************
            TimeSpan[] selectableIntsEnS01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntrySa1 = selectableIntsEnS01[rand.Next(0, selectableIntsEnS01.Length)];

            TimeSpan[] selectableIntsEnS02 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntrySa2 = selectableIntsEnS02[rand.Next(0, selectableIntsEnS02.Length)];

            TimeSpan[] selectableIntsEnS03 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntrySa3 = selectableIntsEnS03[rand.Next(0, selectableIntsEnS03.Length)];


            //All Exits
            //*************************************Monday*************************************
            TimeSpan[] selectableIntsExM01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitMo1 = selectableIntsExM01[rand.Next(0, selectableIntsExM01.Length)];

            TimeSpan[] selectableIntsExM02 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitMo2 = selectableIntsExM02[rand.Next(0, selectableIntsExM02.Length)];

            TimeSpan[] selectableIntsExM03 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitMo3 = selectableIntsExM03[rand.Next(0, selectableIntsExM03.Length)];

            //*************************************Tuesday*************************************
            TimeSpan[] selectableIntsExTu01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTu1 = selectableIntsExTu01[rand.Next(0, selectableIntsExTu01.Length)];

            TimeSpan[] selectableIntsExTu02 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTu2 = selectableIntsExTu02[rand.Next(0, selectableIntsExTu02.Length)];

            TimeSpan[] selectableIntsExTu03 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTu3 = selectableIntsExTu03[rand.Next(0, selectableIntsExTu03.Length)];

            //*************************************Wednesday*************************************
            TimeSpan[] selectableIntsExW01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitWe1 = selectableIntsExW01[rand.Next(0, selectableIntsExW01.Length)];

            TimeSpan[] selectableIntsExW02 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitWe2 = selectableIntsExW02[rand.Next(0, selectableIntsExW02.Length)];

            TimeSpan[] selectableIntsExW03 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitWe3 = selectableIntsExW03[rand.Next(0, selectableIntsExW03.Length)];

            //*************************************Thursday*************************************
            TimeSpan[] selectableIntsExTs01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTs1 = selectableIntsExTs01[rand.Next(0, selectableIntsExTs01.Length)];

            TimeSpan[] selectableIntsExTs02 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTs2 = selectableIntsExTs02[rand.Next(0, selectableIntsExTs02.Length)];

            TimeSpan[] selectableIntsExTs03 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTs3 = selectableIntsExTs03[rand.Next(0, selectableIntsExTs03.Length)];

            //*************************************Friday*************************************
            TimeSpan[] selectableIntsExF01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitFr1 = selectableIntsExF01[rand.Next(0, selectableIntsExF01.Length)];

            TimeSpan[] selectableIntsExF02 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitFr2 = selectableIntsExF02[rand.Next(0, selectableIntsExF02.Length)];

            TimeSpan[] selectableIntsExF03 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitFr3 = selectableIntsExF03[rand.Next(0, selectableIntsExF03.Length)];

            //*************************************Saturday*************************************
            TimeSpan[] selectableIntsExS01 = new TimeSpan[19] { TSHMRandom0955, TSHMRandom0956, TSHMRandom0957, TSHMRandom0958, TSHMRandom0959, TSHMRandom1000, TSHMRandom1001, TSHMRandom1002, TSHMRandom1003, TSHMRandom1004, TSHMRandom1005, TSHMRandom1006, TSHMRandom1007, TSHMRandom1008, TSHMRandom1009, TSHMRandom1010, TSHMRandom1011, TSHMRandom1012, TSHMRandom1013 };
            TimeSpan randomValueFirstExitSa1 = selectableIntsExS01[rand.Next(0, selectableIntsExS01.Length)];

            TimeSpan[] selectableIntsExS02 = new TimeSpan[19] { TSHMRandom0955, TSHMRandom0956, TSHMRandom0957, TSHMRandom0958, TSHMRandom0959, TSHMRandom1000, TSHMRandom1001, TSHMRandom1002, TSHMRandom1003, TSHMRandom1004, TSHMRandom1005, TSHMRandom1006, TSHMRandom1007, TSHMRandom1008, TSHMRandom1009, TSHMRandom1010, TSHMRandom1011, TSHMRandom1012, TSHMRandom1013 };
            TimeSpan randomValueFirstExitSa2 = selectableIntsExS02[rand.Next(0, selectableIntsExS02.Length)];

            TimeSpan[] selectableIntsExS03 = new TimeSpan[19] { TSHMRandom0955, TSHMRandom0956, TSHMRandom0957, TSHMRandom0958, TSHMRandom0959, TSHMRandom1000, TSHMRandom1001, TSHMRandom1002, TSHMRandom1003, TSHMRandom1004, TSHMRandom1005, TSHMRandom1006, TSHMRandom1007, TSHMRandom1008, TSHMRandom1009, TSHMRandom1010, TSHMRandom1011, TSHMRandom1012, TSHMRandom1013 };
            TimeSpan randomValueFirstExitSa3 = selectableIntsExS03[rand.Next(0, selectableIntsExS03.Length)];

            double RestTT00 = Convert.ToDouble(textBox1.Text);
            double RestTT04 = Convert.ToDouble(textBox1.Text) - 04;
            double RestTT08 = Convert.ToDouble(textBox1.Text) - 08;
            double RestTT12 = Convert.ToDouble(textBox1.Text) - 12;
            double RestTT16 = Convert.ToDouble(textBox1.Text) - 16;
            double RestTT20 = Convert.ToDouble(textBox1.Text) - 20;
            double RestTT24 = Convert.ToDouble(textBox1.Text) - 24;
            double RestTT28 = Convert.ToDouble(textBox1.Text) - 28;
            double RestTT32 = Convert.ToDouble(textBox1.Text) - 32;
            double RestTT36 = Convert.ToDouble(textBox1.Text) - 36;
            double RestTT40 = Convert.ToDouble(textBox1.Text) - 40;
            double RestTT44 = Convert.ToDouble(textBox1.Text) - 44;
            double RestTT48 = Convert.ToDouble(textBox1.Text) - 48;
            double RestTT52 = Convert.ToDouble(textBox1.Text) - 52;
            double RestTT56 = Convert.ToDouble(textBox1.Text) - 56;
            double RestTT60 = Convert.ToDouble(textBox1.Text) - 60;
            double RestTT64 = Convert.ToDouble(textBox1.Text) - 64;
            double RestTT68 = Convert.ToDouble(textBox1.Text) - 68;
            double RestTT72 = Convert.ToDouble(textBox1.Text) - 72;
            double RestTT76 = Convert.ToDouble(textBox1.Text) - 76;
            double RestTT80 = Convert.ToDouble(textBox1.Text) - 80;
            double RestTT84 = Convert.ToDouble(textBox1.Text) - 84;
            double RestTT88 = Convert.ToDouble(textBox1.Text) - 88;
            double RestTT92 = Convert.ToDouble(textBox1.Text) - 92;
            double RestTT96 = Convert.ToDouble(textBox1.Text) - 96;
            double RestTT100 = Convert.ToDouble(textBox1.Text) - 100;
            double RestTT104 = Convert.ToDouble(textBox1.Text) - 104;
            double RestTT112 = Convert.ToDouble(textBox1.Text) - 112;


            if (comboBox2.SelectedItem.ToString() == "Monday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, RestTT00);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, RestTT08);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 16)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 24 && Convert.ToDouble(textBox1.Text) > 16)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, RestTT16);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 24)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 32 && Convert.ToDouble(textBox1.Text) > 24)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, RestTT24);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 32)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 40 && Convert.ToDouble(textBox1.Text) > 32)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT32);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 40)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 40)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT40);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT44);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 60 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT52);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 60)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 68 && Convert.ToDouble(textBox1.Text) > 60)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT60);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 68)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 76 && Convert.ToDouble(textBox1.Text) > 68)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT68);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 76)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 84 && Convert.ToDouble(textBox1.Text) > 76)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT76);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 84)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 84)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT84);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT88);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 104 && Convert.ToDouble(textBox1.Text) > 96)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT96);
                }

                if (Convert.ToDouble(textBox1.Text) == 104)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                }

            }


            if (comboBox2.SelectedItem.ToString() == "Tuesday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, RestTT00);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, RestTT08);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 16)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 24 && Convert.ToDouble(textBox1.Text) > 16)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, RestTT16);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 24)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 32 && Convert.ToDouble(textBox1.Text) > 24)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT24);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 32)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 36 && Convert.ToDouble(textBox1.Text) > 32)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT32);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 36)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 36)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, RestTT36);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT44);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 60 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT52);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 60)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 68 && Convert.ToDouble(textBox1.Text) > 60)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, RestTT60);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 68)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 76 && Convert.ToDouble(textBox1.Text) > 68)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT68);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 76)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 80 && Convert.ToDouble(textBox1.Text) > 76)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT76);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 80)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 80)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT80);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT88);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 104 && Convert.ToDouble(textBox1.Text) > 96)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, RestTT96);
                }

                if (Convert.ToDouble(textBox1.Text) == 104)
                {
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                }
            }


            if (comboBox2.SelectedItem.ToString() == "Wednesday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, RestTT00);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, RestTT08);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 16)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 24 && Convert.ToDouble(textBox1.Text) > 16)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT16);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 24)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 28 && Convert.ToDouble(textBox1.Text) > 24)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT24);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 28)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 36 && Convert.ToDouble(textBox1.Text) > 28)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT28);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 36)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 36)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT36);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT44);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 60 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, RestTT52);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 60)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 68 && Convert.ToDouble(textBox1.Text) > 60)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT60);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 68)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 72 && Convert.ToDouble(textBox1.Text) > 68)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT68);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 72)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 80 && Convert.ToDouble(textBox1.Text) > 72)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT72);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 80)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 80)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT80);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, RestTT88);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 104 && Convert.ToDouble(textBox1.Text) > 96)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, RestTT96);
                }

                if (Convert.ToDouble(textBox1.Text) == 104)
                {
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                }

            }


            if (comboBox2.SelectedItem.ToString() == "Thursday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, RestTT00);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT08);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 16)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 20 && Convert.ToDouble(textBox1.Text) > 16)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT16);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 20)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 28 && Convert.ToDouble(textBox1.Text) > 20)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT20);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 28)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 36 && Convert.ToDouble(textBox1.Text) > 28)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT28);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 36)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 36)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT36);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT44);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 60 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT52);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 60)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 64 && Convert.ToDouble(textBox1.Text) > 60)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT60);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 64)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 72 && Convert.ToDouble(textBox1.Text) > 64)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT64);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 72)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 80 && Convert.ToDouble(textBox1.Text) > 72)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT72);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 80)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 80)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, RestTT80);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, RestTT88);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 104 && Convert.ToDouble(textBox1.Text) > 96)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, RestTT96);
                }

                if (Convert.ToDouble(textBox1.Text) == 104)
                {
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                }

            }


            if (comboBox2.SelectedItem.ToString() == "Friday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT00);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 12 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT08);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 12)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 20 && Convert.ToDouble(textBox1.Text) > 12)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT12);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 20)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 28 && Convert.ToDouble(textBox1.Text) > 20)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT20);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 28)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 36 && Convert.ToDouble(textBox1.Text) > 28)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT28);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 36)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 36)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT36);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT44);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 56 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT52);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 56)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 64 && Convert.ToDouble(textBox1.Text) > 56)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT56);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 64)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 72 && Convert.ToDouble(textBox1.Text) > 64)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT64);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 72)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 80 && Convert.ToDouble(textBox1.Text) > 72)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, RestTT72);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 80)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 80)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, RestTT80);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, RestTT88);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 100 && Convert.ToDouble(textBox1.Text) > 96)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa3, RestTT96);
                }

                if (Convert.ToDouble(textBox1.Text) == 100)
                {
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa3, randomValueFirstExitSa3);
                }

            }


            if (comboBox2.SelectedItem.ToString() == "Saturday")
            {
                if (Convert.ToDouble(textBox1.Text) < 4 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT00);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 4)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 12 && Convert.ToDouble(textBox1.Text) > 4)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT08);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 12)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 20 && Convert.ToDouble(textBox1.Text) > 12)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT12);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 20)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 28 && Convert.ToDouble(textBox1.Text) > 20)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT20);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 28)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 36 && Convert.ToDouble(textBox1.Text) > 28)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT28);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 36)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 36)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT36);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 48 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT44);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 48)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 56 && Convert.ToDouble(textBox1.Text) > 48)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT48);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 56)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 64 && Convert.ToDouble(textBox1.Text) > 56)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, RestTT56);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 64)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 72 && Convert.ToDouble(textBox1.Text) > 64)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, RestTT64);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 72)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 80 && Convert.ToDouble(textBox1.Text) > 72)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, RestTT72);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 80)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 80)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, RestTT80);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 92 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa3, RestTT88);
                }

                if (Convert.ToDouble(textBox1.Text) == 92)
                {
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu3, randomValueFirstExitTu3);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr3, randomValueFirstExitFr3);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa3, randomValueFirstExitSa3);
                }
            }


            if (comboBox2.SelectedItem.ToString() == "Sunday")
            {
                if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, RestTT00);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 8)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, RestTT08);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 16)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 24 && Convert.ToDouble(textBox1.Text) > 16)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, RestTT16);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 24)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 32 && Convert.ToDouble(textBox1.Text) > 24)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, RestTT24);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 32)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 40 && Convert.ToDouble(textBox1.Text) > 32)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT32);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 40)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 40)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT40);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 44)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 52 && Convert.ToDouble(textBox1.Text) > 44)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, RestTT44);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 52)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 60 && Convert.ToDouble(textBox1.Text) > 52)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, RestTT52);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 60)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 68 && Convert.ToDouble(textBox1.Text) > 60)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, RestTT60);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 68)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 76 && Convert.ToDouble(textBox1.Text) > 68)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, RestTT68);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 76)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 84 && Convert.ToDouble(textBox1.Text) > 76)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, RestTT76);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 84)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, TSEnde, TSEnde);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 88 && Convert.ToDouble(textBox1.Text) > 84)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, RestTT84);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) == 88)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, TSEnde, TSEnde);
                }

                if (Convert.ToDouble(textBox1.Text) < 96 && Convert.ToDouble(textBox1.Text) > 88)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, RestTT88);
                }

                if (Convert.ToDouble(textBox1.Text) == 96)
                {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo2, randomValueFirstExitMo2);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu2, randomValueFirstExitTu2);
                    dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe2, randomValueFirstExitWe2);
                    dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs2, randomValueFirstExitTs2);
                    dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr2, randomValueFirstExitFr2);
                    dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa2, randomValueFirstExitSa2);
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo3, randomValueFirstExitMo3);
                }

            }




        }

        private void ChangeCalculatedNumberToHours()
        {
            double NbrDays0_5 = 0.5;
            double NbrDays1_0 = 1;
            double NbrDays1_5 = 1.5;
            double NbrDays2_0 = 2;
            double NbrDays2_5 = 2.5;
            double NbrDays3_0 = 3;
            double NbrDays3_5 = 3.5;
            double NbrDays4_0 = 4;
            double NbrDays4_5 = 4.5;
            double NbrDays5_0 = 5;
            double NbrDays5_5 = 5.5;
            double NbrDays6_0 = 6;
            double NbrDays6_5 = 6.5;
            double NbrDays7_0 = 7;
            double NbrDays7_5 = 7.5;

            TimeSpan Ts06h30 = new TimeSpan(06, 33, 0);
            TimeSpan Ts07h00 = new TimeSpan(07, 02, 0);
            TimeSpan Ts07h30 = new TimeSpan(07, 33, 0);
            TimeSpan Ts08h00 = new TimeSpan(08, 05, 0);
            TimeSpan Ts08h30 = new TimeSpan(08, 31, 0);
            TimeSpan Ts09h00 = new TimeSpan(09, 01, 0);
            TimeSpan Ts09h30 = new TimeSpan(09, 30, 0);
            TimeSpan Ts10h00 = new TimeSpan(10, 06, 0);
            TimeSpan Ts10h30 = new TimeSpan(10, 34, 0);
            TimeSpan Ts11h00 = new TimeSpan(11, 03, 0);
            TimeSpan Ts11h30 = new TimeSpan(11, 35, 0);
            TimeSpan Ts12h00 = new TimeSpan(12, 05, 0);
            TimeSpan Ts12h30 = new TimeSpan(12, 32, 0);
            TimeSpan Ts13h00 = new TimeSpan(13, 02, 0);
            TimeSpan Ts13h30 = new TimeSpan(13, 31, 0);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //Monday to Friday
                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays0_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts06h30; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays1_0.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts07h00; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays1_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts07h30; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays2_0.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts08h00; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays2_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts08h30; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays3_0.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts09h00; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays3_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts09h30; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays4_0.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts10h00; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays4_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts10h30; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays5_0.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts11h00; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays5_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts11h30; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays6_0.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts12h00; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays6_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts12h30; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays7_0.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts13h00; }

                if ((dataGridView2.Rows[i].Cells[0].Value.ToString() == Mon || dataGridView2.Rows[i].Cells[0].Value.ToString() == Tue || dataGridView2.Rows[i].Cells[0].Value.ToString() == Wed || dataGridView2.Rows[i].Cells[0].Value.ToString() == Thu || dataGridView2.Rows[i].Cells[0].Value.ToString() == Fri) && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays7_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts13h30; }

                //Saturday
                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == Sat && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays0_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts06h30; }

                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == Sat && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays1_0.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts07h00; }

                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == Sat && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays1_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts07h30; }

                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == Sat && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays2_0.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts08h00; }

                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == Sat && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays2_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts08h30; }

                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == Sat && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays3_0.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts09h00; }

                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == Sat && dataGridView2.Rows[i].Cells[2].Value.ToString() == NbrDays3_5.ToString())
                { dataGridView2.Rows[i].Cells[2].Value = Ts09h30; }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherMatricule();
            /*dataGridView1.Rows.Clear();
            comboBox2.SelectedIndex = -1;*/
            if(comboBox1.SelectedIndex != -1)
            { comboBox3.SelectedIndex = 0; }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherH_Cibel();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Monday) { comboBox2.SelectedIndex = 0; }
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Tuesday) { comboBox2.SelectedIndex = 1; }
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Wednesday) { comboBox2.SelectedIndex = 2; }
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Thursday) { comboBox2.SelectedIndex = 3; }
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Friday) { comboBox2.SelectedIndex = 4; }
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday) { comboBox2.SelectedIndex = 5; }
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday) { comboBox2.SelectedIndex = 6; }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            /*if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null) { button1.Enabled = true; }
            else { button1.Enabled = false; }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime FirstPickerDate = dateTimePicker1.Value;
            DateTime SecndPickerDate = dateTimePicker2.Value;
            TimeSpan TotalPickerDate = SecndPickerDate - FirstPickerDate;

            int NbrDays14 = 14;
            int NbrDays15 = 15;

            int differenceInDays = TotalPickerDate.Days;
            string differenceAsString = differenceInDays.ToString();

            if (differenceInDays == NbrDays14)
                { checkBox1.Checked = true; }
            else { checkBox1.Checked = false; }

            if (differenceInDays == NbrDays15)
            { checkBox2.Checked = true; }
            else { checkBox2.Checked = false; }
        }


    }
}
