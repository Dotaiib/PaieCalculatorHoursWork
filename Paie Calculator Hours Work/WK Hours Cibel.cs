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
    public partial class WK_Hours_Cibel : Form
    {
        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");

        public WK_Hours_Cibel()
        {
            InitializeComponent(); AfficherValue();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void AfficherValue()
        {
            cn.Open();
            string Sql = "select distinct Id_Table from WK_Hours order by Id_Table desc";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox1.Items.Add(DR[0]); }
            cn.Close();
        }

        private void AfficherMatricule()
        {
            cn.Open();
            string Sql = "select distinct Matricule from WK_Hours where Id_Table = '" + comboBox1.Text + "' ";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            { comboBox3.Items.Add(DR[0]); }
            cn.Close();
        }

        private void AfficherH_Cibel()
        {
            cn.Open();
            string Sql = "select distinct H_Cibel from WK_Hours where Id_Table = '" + comboBox1.Text + "' and matricule = '" + comboBox3.Text + "' ";
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

        TimeSpan TSEnde = new TimeSpan(99, 99, 99, 99);

        string Mon = "Monday";
        string Tue = "Tuesday";
        string Wed = "Wednesday";
        string Thu = "Thursday";
        string Fri = "Friday";
        string Sat = "Saturday";



        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(" select distinct matricule, name, H_Cibel from WK_Hours where Id_Table = '" + comboBox1.Text + "' and Matricule = '" + comboBox3.Text + "' ", cn);
            cn.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            int NbrDays5 = 5;

            DateTime FirstPickerDate = dateTimePicker1.Value;
            DateTime SecndPickerDate = dateTimePicker2.Value;
            TimeSpan TotalPickerDate = SecndPickerDate - FirstPickerDate;


            int differenceInDays = TotalPickerDate.Days;
            string differenceAsString = differenceInDays.ToString();


            if (differenceInDays > NbrDays5)
                { MessageBox.Show("Please Check The Date, The date cannot be more than 5 days"); }
            else
            {
                if (dateTimePicker1.Value.DayOfWeek != DayOfWeek.Monday)
                    { MessageBox.Show("The first day of the week must be Monday"); }
                else
                {
                    if (dateTimePicker2.Value.DayOfWeek != DayOfWeek.Saturday)
                        { MessageBox.Show("The last day of the week must be Saturday"); }
                    else
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

                            WKAdd6days();
                            ChangeCalculatedNumberToHours();

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
                                button1.Enabled = false;
                                button2.Enabled = true;
                            }
                            cn.Open();


                        }
                    }
                }
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
                cmd.Parameters.AddWithValue("@Id_Table", comboBox1.Text + "_WKCibel");
                cmd.Parameters.AddWithValue("@Matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@FullName", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@TotalHours", dataGridView1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@The_Date", dataGridView1.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@TheDay", dataGridView2.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@TimeOfEntry", dataGridView2.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@TimeOfExit", dataGridView2.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@HoursType", "WK");
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
            cn.Close();
        }

        private void WKAdd6days()
        {
            Random rand = new Random();

            //All Entrys
            //*************************************Monday*************************************
            TimeSpan[] selectableIntsEnM01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryMo1 = selectableIntsEnM01[rand.Next(0, selectableIntsEnM01.Length)];

            //*************************************Tuesday*************************************
            TimeSpan[] selectableIntsEnTu01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTu1 = selectableIntsEnTu01[rand.Next(0, selectableIntsEnTu01.Length)];

            //*************************************Wednesday*************************************
            TimeSpan[] selectableIntsEnW01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryWe1 = selectableIntsEnW01[rand.Next(0, selectableIntsEnW01.Length)];

            //*************************************Thursday*************************************
            TimeSpan[] selectableIntsEnTs01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryTs1 = selectableIntsEnTs01[rand.Next(0, selectableIntsEnTs01.Length)];

            //*************************************Friday*************************************
            TimeSpan[] selectableIntsEnF01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntryFr1 = selectableIntsEnF01[rand.Next(0, selectableIntsEnF01.Length)];

            //*************************************Saturday*************************************
            TimeSpan[] selectableIntsEnS01 = new TimeSpan[19] { TSHMRandom0555, TSHMRandom0556, TSHMRandom0557, TSHMRandom0558, TSHMRandom0559, TSHMRandom0600, TSHMRandom0601, TSHMRandom0602, TSHMRandom0603, TSHMRandom0604, TSHMRandom0605, TSHMRandom0606, TSHMRandom0607, TSHMRandom0608, TSHMRandom0609, TSHMRandom0610, TSHMRandom0611, TSHMRandom0612, TSHMRandom0613 };
            TimeSpan randomValueFirstEntrySa1 = selectableIntsEnS01[rand.Next(0, selectableIntsEnS01.Length)];


            //All Exits
            //*************************************Monday*************************************
            TimeSpan[] selectableIntsExM01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitMo1 = selectableIntsExM01[rand.Next(0, selectableIntsExM01.Length)];

            //*************************************Tuesday*************************************
            TimeSpan[] selectableIntsExTu01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTu1 = selectableIntsExTu01[rand.Next(0, selectableIntsExTu01.Length)];

            //*************************************Wednesday*************************************
            TimeSpan[] selectableIntsExW01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitWe1 = selectableIntsExW01[rand.Next(0, selectableIntsExW01.Length)];

            //*************************************Thursday*************************************
            TimeSpan[] selectableIntsExTs01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitTs1 = selectableIntsExTs01[rand.Next(0, selectableIntsExTs01.Length)];

            //*************************************Friday*************************************
            TimeSpan[] selectableIntsExF01 = new TimeSpan[19] { TSHMRandom1355, TSHMRandom1356, TSHMRandom1357, TSHMRandom1358, TSHMRandom1359, TSHMRandom1400, TSHMRandom1401, TSHMRandom1402, TSHMRandom1403, TSHMRandom1404, TSHMRandom1405, TSHMRandom1406, TSHMRandom1407, TSHMRandom1408, TSHMRandom1409, TSHMRandom1410, TSHMRandom1411, TSHMRandom1412, TSHMRandom1413 };
            TimeSpan randomValueFirstExitFr1 = selectableIntsExF01[rand.Next(0, selectableIntsExF01.Length)];

            //*************************************Saturday*************************************
            TimeSpan[] selectableIntsExS01 = new TimeSpan[19] { TSHMRandom0955, TSHMRandom0956, TSHMRandom0957, TSHMRandom0958, TSHMRandom0959, TSHMRandom1000, TSHMRandom1001, TSHMRandom1002, TSHMRandom1003, TSHMRandom1004, TSHMRandom1005, TSHMRandom1006, TSHMRandom1007, TSHMRandom1008, TSHMRandom1009, TSHMRandom1010, TSHMRandom1011, TSHMRandom1012, TSHMRandom1013 };
            TimeSpan randomValueFirstExitSa1 = selectableIntsExS01[rand.Next(0, selectableIntsExS01.Length)];


            double RestTT00 = Convert.ToDouble(textBox1.Text);
            double RestTT08 = Convert.ToDouble(textBox1.Text) - 08;
            double RestTT16 = Convert.ToDouble(textBox1.Text) - 16;
            double RestTT24 = Convert.ToDouble(textBox1.Text) - 24;
            double RestTT32 = Convert.ToDouble(textBox1.Text) - 32;
            double RestTT40 = Convert.ToDouble(textBox1.Text) - 40;
            double RestTT44 = Convert.ToDouble(textBox1.Text) - 44;

            if (Convert.ToDouble(textBox1.Text) < 8 && Convert.ToDouble(textBox1.Text) > 0)
            {
                dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, RestTT00);
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
            }

            if (Convert.ToDouble(textBox1.Text) < 16 && Convert.ToDouble(textBox1.Text) > 8)
            {
                    dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                    dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, RestTT08);
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
            }

            if (Convert.ToDouble(textBox1.Text) < 24 && Convert.ToDouble(textBox1.Text) > 16)
            {
                dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, RestTT16);
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
            }

            if (Convert.ToDouble(textBox1.Text) < 32 && Convert.ToDouble(textBox1.Text) > 24)
            {
                dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, RestTT24);
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
            }

            if (Convert.ToDouble(textBox1.Text) < 40 && Convert.ToDouble(textBox1.Text) > 32)
            {
                dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, RestTT32);
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
            }

            if (Convert.ToDouble(textBox1.Text) < 44 && Convert.ToDouble(textBox1.Text) > 40)
            {
                dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, RestTT40);
            }

            if (Convert.ToDouble(textBox1.Text) == 44)
            {
                dataGridView2.Rows.Add(Mon, randomValueFirstEntryMo1, randomValueFirstExitMo1);
                dataGridView2.Rows.Add(Tue, randomValueFirstEntryTu1, randomValueFirstExitTu1);
                dataGridView2.Rows.Add(Wed, randomValueFirstEntryWe1, randomValueFirstExitWe1);
                dataGridView2.Rows.Add(Thu, randomValueFirstEntryTs1, randomValueFirstExitTs1);
                dataGridView2.Rows.Add(Fri, randomValueFirstEntryFr1, randomValueFirstExitFr1);
                dataGridView2.Rows.Add(Sat, randomValueFirstEntrySa1, randomValueFirstExitSa1);
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
            if (comboBox1.SelectedIndex != -1)
            { comboBox3.SelectedIndex = 0; }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherH_Cibel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != null) { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }
    }
}
