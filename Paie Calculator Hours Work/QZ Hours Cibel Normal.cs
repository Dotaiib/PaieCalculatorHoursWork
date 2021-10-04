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
    public partial class QZ_Hours_Cibel_Normal : Form
    {

        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");


        public QZ_Hours_Cibel_Normal()
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

        /*TimeSpan TSHMRandom0547 = new TimeSpan(5, 47, 0);
        TimeSpan TSHMRandom0548 = new TimeSpan(5, 48, 0);
        TimeSpan TSHMRandom0549 = new TimeSpan(5, 49, 0);
        TimeSpan TSHMRandom0550 = new TimeSpan(5, 50, 0);
        TimeSpan TSHMRandom0551 = new TimeSpan(5, 51, 0);
        TimeSpan TSHMRandom0552 = new TimeSpan(5, 52, 0);
        TimeSpan TSHMRandom0553 = new TimeSpan(5, 53, 0);
        TimeSpan TSHMRandom0554 = new TimeSpan(5, 54, 0);*/
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


        /*TimeSpan TSHMRandom1347 = new TimeSpan(13, 47, 0);
        TimeSpan TSHMRandom1348 = new TimeSpan(13, 48, 0);
        TimeSpan TSHMRandom1349 = new TimeSpan(13, 49, 0);
        TimeSpan TSHMRandom1350 = new TimeSpan(13, 50, 0);
        TimeSpan TSHMRandom1351 = new TimeSpan(13, 51, 0);
        TimeSpan TSHMRandom1352 = new TimeSpan(13, 52, 0);
        TimeSpan TSHMRandom1353 = new TimeSpan(13, 53, 0);
        TimeSpan TSHMRandom1354 = new TimeSpan(13, 54, 0);*/
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

        /*TimeSpan TSHMRandom0947 = new TimeSpan(13, 47, 0);
        TimeSpan TSHMRandom0948 = new TimeSpan(09, 48, 0);
        TimeSpan TSHMRandom0949 = new TimeSpan(09, 49, 0);
        TimeSpan TSHMRandom0950 = new TimeSpan(09, 50, 0);
        TimeSpan TSHMRandom0951 = new TimeSpan(09, 51, 0);
        TimeSpan TSHMRandom0952 = new TimeSpan(09, 52, 0);
        TimeSpan TSHMRandom0953 = new TimeSpan(09, 53, 0);
        TimeSpan TSHMRandom0954 = new TimeSpan(09, 54, 0);*/
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

        string Mon = "Monday";
        string Tue = "Tuesday";
        string Wed = "Wednesday";
        string Thu = "Thursday";
        string Fri = "Friday";
        string Sat = "Saturday";


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlDataAdapter sda = new SqlDataAdapter(" select distinct matricule, name, H_Cibel from QZ_Calcul where Id_Table = '" + comboBox1.Text + "' and H_Cibel >=" + textBox1.Text + " ", cn);
            cn.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            //Check difference between datetimepicker

            /*DateTime FirstPickerDate = dateTimePicker1.Value;
            DateTime SecndPickerDate = dateTimePicker2.Value;
            TimeSpan TotalPickerDate = SecndPickerDate - FirstPickerDate;

            int NbrDays14 = 14;
            int NbrDays15 = 15;

            int differenceInDays = TotalPickerDate.Days;
            string differenceAsString = differenceInDays.ToString();*/

            //Check The day of datetimepicker 1&2

            int NbrDays01 = 01;
            int NbrDays15 = 15;
            int NbrDays16 = 16;
            int NbrDays30 = 30;
            int NbrDays31 = 31;


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
                        if (checkBox1.Checked == true)
                        {
                            QZNormalAdd15days();
                            button1.Enabled = false;
                            button2.Enabled = true;
                        }

                        if (checkBox2.Checked == true)
                        {
                            QZNormalAdd16days();
                            button1.Enabled = false;
                            button2.Enabled = true;
                        }

                    }
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


            label2.Text = dataGridView1.Rows.Count.ToString();
            label4.Text = dataGridView2.Rows.Count.ToString();
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into HoursCreation (Id_Table,Matricule,FullName,TotalHours,The_Date,TheDay,TimeOfEntry,TimeOfExit,HoursType,Company) values(@Id_Table,@Matricule,@FullName,@TotalHours,@The_Date,@TheDay,@TimeOfEntry,@TimeOfExit,@HoursType,@Company) ", cn);
                cmd.Parameters.AddWithValue("@Id_Table", comboBox1.Text + "_QZCibelN");
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
            DataTable dt = new DataTable();
            dt.Rows.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            button1.Enabled = true;
            button2.Enabled = false;
            cn.Close();
        }


        private void QZNormalAdd15days()
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

            if (comboBox2.SelectedItem.ToString() == "Monday")
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

            if(comboBox2.SelectedItem.ToString() == "Tuesday")
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

            if (comboBox2.SelectedItem.ToString() == "Wednesday")
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
                dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
            }

            if (comboBox2.SelectedItem.ToString() == "Thursday")
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

            if (comboBox2.SelectedItem.ToString() == "Friday")
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

            if (comboBox2.SelectedItem.ToString() == "Saturday")
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
                dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa3);
            }

            if (comboBox2.SelectedItem.ToString() == "Sunday")
            {
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
                dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa3);
            }


        }


        private void QZNormalAdd16days()
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

            if (comboBox2.SelectedItem.ToString() == "Monday")
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

            if (comboBox2.SelectedItem.ToString() == "Tuesday")
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
                dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
            }

            if (comboBox2.SelectedItem.ToString() == "Wednesday")
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
                dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe3, randomValueFirstExitWe3);
                dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs3, randomValueFirstExitTs3);
            }

            if (comboBox2.SelectedItem.ToString() == "Thursday")
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

            if (comboBox2.SelectedItem.ToString() == "Friday")
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

            if (comboBox2.SelectedItem.ToString() == "Saturday")
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
                dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa3);
            }

            if (comboBox2.SelectedItem.ToString() == "Sunday")
            {
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
                dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa3);
                dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
            }


        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null) { button1.Enabled = true; }
            else { button1.Enabled = false; }
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
