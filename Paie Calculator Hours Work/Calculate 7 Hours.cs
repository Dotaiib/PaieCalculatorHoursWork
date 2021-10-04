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
    public partial class Calculate_7_Hours : Form
    {
        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = Paie ; integrated security = false; User ID = Paie; Password = P@ie@mdesk0823;");

        public Calculate_7_Hours()
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
            SqlCommand cmd = new SqlCommand(" select distinct * from Paie_initial where Id_Table = '" + comboBox1.Text + "' ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9), dr.GetValue(10));
            }
            cn.Close();
            Minutes_Check();
            Change_Night_Hours_for_Calculation();
            Calculating_7Hours();
            Less_time();
            Change_Night_hours_total_To_Normal_Hours();
            Minutes_45_and_15();
            MessageBox.Show(dataGridView1.Rows.Count.ToString(), "Number of lines");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into Paie_total (Id_Table,Matricule,FullName,The_Date,Entree_01,Sortie_01,Entree_02,Sortie_02,Entree_03,Sortie_03,Original_Time_Minutes,Total,Temps_Sortie,The_Time) values(@Id_Table,@Matricule,@FullName,@The_Date,@Entree_01,@Sortie_01,@Entree_02,@Sortie_02,@Entree_03,@Sortie_03,@Original_Time_Minutes,@Total,@Temps_Sortie,@The_Time) ", cn);
                cmd.Parameters.AddWithValue("@Id_Table", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@FullName", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@The_Date", dataGridView1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@Entree_01", dataGridView1.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@Sortie_01", dataGridView1.Rows[i].Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("@Entree_02", dataGridView1.Rows[i].Cells[5].Value.ToString());
                cmd.Parameters.AddWithValue("@Sortie_02", dataGridView1.Rows[i].Cells[6].Value.ToString());
                cmd.Parameters.AddWithValue("@Entree_03", dataGridView1.Rows[i].Cells[7].Value.ToString());
                cmd.Parameters.AddWithValue("@Sortie_03", dataGridView1.Rows[i].Cells[8].Value.ToString());
                cmd.Parameters.AddWithValue("@Original_Time_Minutes", dataGridView1.Rows[i].Cells[9].Value.ToString());
                cmd.Parameters.AddWithValue("@Total", dataGridView1.Rows[i].Cells[10].Value.ToString());
                cmd.Parameters.AddWithValue("@Temps_Sortie", dataGridView1.Rows[i].Cells[11].Value.ToString());
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


        void Minutes_45_and_15()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                TimeSpan C10 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[11].Value.ToString());
                TimeSpan TSM45 = new TimeSpan(45);
                TimeSpan TSM15 = new TimeSpan(15);
                TimeSpan TSMC10 = new TimeSpan(Convert.ToInt32(C10.Minutes));
                TimeSpan TSM45C10 = new TimeSpan(Convert.ToInt32(C10.Hours), 44, 0);
                TimeSpan TSM15C10 = new TimeSpan(Convert.ToInt32(C10.Hours), 14, 0);

                if (TSMC10 == TSM45) { dataGridView1.Rows[i].Cells[11].Value = TSM45C10; }
                if (TSMC10 == TSM15) { dataGridView1.Rows[i].Cells[11].Value = TSM15C10; }

            }
        }

        void Change_Night_hours_total_To_Normal_Hours()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                /*Total equal night hours change it to normal 1.03:25:00*/

                TimeSpan C10 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[11].Value.ToString());
                TimeSpan TSHC10 = new TimeSpan(Convert.ToInt32(C10.Days));
                TimeSpan TSD1 = new TimeSpan(1);

                TimeSpan TSM0C10 = new TimeSpan(0, Convert.ToInt32(C10.Hours), Convert.ToInt32(C10.Minutes), 0);
                TimeSpan TSM1C10 = new TimeSpan(0, Convert.ToInt32(C10.Hours), Convert.ToInt32(C10.Minutes), 0);
                TimeSpan TSM2C10 = new TimeSpan(0, Convert.ToInt32(C10.Hours), Convert.ToInt32(C10.Minutes), 0);
                TimeSpan TSM3C10 = new TimeSpan(0, Convert.ToInt32(C10.Hours), Convert.ToInt32(C10.Minutes), 0);
                TimeSpan TSM4C10 = new TimeSpan(0, Convert.ToInt32(C10.Hours), Convert.ToInt32(C10.Minutes), 0);
                TimeSpan TSM5C10 = new TimeSpan(0, Convert.ToInt32(C10.Hours), Convert.ToInt32(C10.Minutes), 0);
                TimeSpan TSM6C10 = new TimeSpan(0, Convert.ToInt32(C10.Hours), Convert.ToInt32(C10.Minutes), 0);
                TimeSpan TSM7C10 = new TimeSpan(0, Convert.ToInt32(C10.Hours), Convert.ToInt32(C10.Minutes), 0);

                if (TSHC10 == TSD1) { dataGridView1.Rows[i].Cells[11].Value = TSM0C10; }
                if (TSHC10 == TSD1) { dataGridView1.Rows[i].Cells[11].Value = TSM1C10; }
                if (TSHC10 == TSD1) { dataGridView1.Rows[i].Cells[11].Value = TSM2C10; }
                if (TSHC10 == TSD1) { dataGridView1.Rows[i].Cells[11].Value = TSM3C10; }
                if (TSHC10 == TSD1) { dataGridView1.Rows[i].Cells[11].Value = TSM4C10; }
                if (TSHC10 == TSD1) { dataGridView1.Rows[i].Cells[11].Value = TSM5C10; }
                if (TSHC10 == TSD1) { dataGridView1.Rows[i].Cells[11].Value = TSM6C10; }
                if (TSHC10 == TSD1) { dataGridView1.Rows[i].Cells[11].Value = TSM7C10; }

            }
        }


        void Less_time()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TimeSpan Ts0 = new TimeSpan(00, 00, 00);
                TimeSpan Ts9 = new TimeSpan(99, 99, 99, 99);
                TimeSpan Ts11 = new TimeSpan(00, 11, 00);
                TimeSpan Ts04 = new TimeSpan(04, 00, 00);

                TimeSpan C2 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                TimeSpan C3 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                TimeSpan C4 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                TimeSpan C5 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                TimeSpan C6 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                TimeSpan C7 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                TimeSpan C10 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[11].Value.ToString());

                /*if (C10 <= (C6 + Ts11)) { dataGridView1.Rows[i].Cells[11].Value = Ts9; }
                if (C10 <= (C4 + Ts11)) { dataGridView1.Rows[i].Cells[11].Value = Ts9; }
                if (C10 <= (C2 + Ts11)) { dataGridView1.Rows[i].Cells[11].Value = Ts9; }*/

                if (C10 <= (C4 + Ts11) && +C3.Subtract(C2) <= Ts04) { dataGridView1.Rows[i].Cells[11].Value = Ts9; }


            }
        }


        void Minutes_Check()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                TimeSpan C2 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                TimeSpan C3 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                TimeSpan C4 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                TimeSpan C5 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                TimeSpan C6 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                TimeSpan C7 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                /*TimeSpan C10 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[11].Value.ToString());*/

                TimeSpan Th0 = new TimeSpan(00, 00, 00);


                /*= SI(MINUTE(E8) >= MINUTE(TEMPS(0; 45; 0)); TEMPS(HEURE(E8 + TEMPS(1; 0; 0)); 0; 0); SI(ET(MINUTE(E8) < MINUTE(TEMPS(0; 45; 0)); MINUTE(E8) >= MINUTE(TEMPS(0; 15; 0))); TEMPS(HEURE(E8); 30; 0); TEMPS(HEURE(E8); 0; 0))); "")*/

                TimeSpan TSM15 = new TimeSpan(0, 15, 0);
                TimeSpan TSM45 = new TimeSpan(0, 45, 0);

                TimeSpan TSMC2 = new TimeSpan(0, Convert.ToInt32(C2.Minutes), 0);
                TimeSpan TSMC21 = new TimeSpan(Convert.ToInt32(C2.Hours + 1), 0, 0);
                TimeSpan TSMC22 = new TimeSpan(Convert.ToInt32(C2.Hours), 30, 0);
                TimeSpan TSMC23 = new TimeSpan(Convert.ToInt32(C2.Hours), 0, 0);

                TimeSpan TSMC3 = new TimeSpan(0, Convert.ToInt32(C3.Minutes), 0);
                TimeSpan TSMC31 = new TimeSpan(Convert.ToInt32(C3.Hours + 1), 0, 0);
                TimeSpan TSMC32 = new TimeSpan(Convert.ToInt32(C3.Hours), 30, 0);
                TimeSpan TSMC33 = new TimeSpan(Convert.ToInt32(C3.Hours), 0, 0);


                TimeSpan TSMC4 = new TimeSpan(0, Convert.ToInt32(C4.Minutes), 0);
                TimeSpan TSMC41 = new TimeSpan(Convert.ToInt32(C4.Hours + 1), 0, 0);
                TimeSpan TSMC42 = new TimeSpan(Convert.ToInt32(C4.Hours), 30, 0);
                TimeSpan TSMC43 = new TimeSpan(Convert.ToInt32(C4.Hours), 0, 0);


                TimeSpan TSMC5 = new TimeSpan(0, Convert.ToInt32(C5.Minutes), 0);
                TimeSpan TSMC51 = new TimeSpan(Convert.ToInt32(C5.Hours + 1), 0, 0);
                TimeSpan TSMC52 = new TimeSpan(Convert.ToInt32(C5.Hours), 30, 0);
                TimeSpan TSMC53 = new TimeSpan(Convert.ToInt32(C5.Hours), 0, 0);


                TimeSpan TSMC6 = new TimeSpan(0, Convert.ToInt32(C6.Minutes), 0);
                TimeSpan TSMC61 = new TimeSpan(Convert.ToInt32(C6.Hours + 1), 0, 0);
                TimeSpan TSMC62 = new TimeSpan(Convert.ToInt32(C6.Hours), 30, 0);
                TimeSpan TSMC63 = new TimeSpan(Convert.ToInt32(C6.Hours), 0, 0);


                TimeSpan TSMC7 = new TimeSpan(0, Convert.ToInt32(C7.Minutes), 0);
                TimeSpan TSMC71 = new TimeSpan(Convert.ToInt32(C7.Hours + 1), 0, 0);
                TimeSpan TSMC72 = new TimeSpan(Convert.ToInt32(C7.Hours), 30, 0);
                TimeSpan TSMC73 = new TimeSpan(Convert.ToInt32(C7.Hours), 0, 0);



                if (TSMC2 >= TSM45) { dataGridView1.Rows[i].Cells[3].Value = TSMC21; }
                if (TSMC2 < TSM45 && TSMC2 >= TSM15) { dataGridView1.Rows[i].Cells[3].Value = TSMC22; }
                if (TSMC2 < TSM15) { dataGridView1.Rows[i].Cells[3].Value = TSMC23; }

                if (TSMC3 > TSM45) { dataGridView1.Rows[i].Cells[4].Value = TSMC31; }
                if (TSMC3 <= TSM45 && TSMC3 > TSM15) { dataGridView1.Rows[i].Cells[4].Value = TSMC32; }
                if (TSMC3 <= TSM15) { dataGridView1.Rows[i].Cells[4].Value = TSMC33; }

                if (TSMC4 >= TSM45) { dataGridView1.Rows[i].Cells[5].Value = TSMC41; }
                if (TSMC4 < TSM45 && TSMC4 >= TSM15) { dataGridView1.Rows[i].Cells[5].Value = TSMC42; }
                if (TSMC4 < TSM15) { dataGridView1.Rows[i].Cells[5].Value = TSMC43; }

                if (TSMC5 > TSM45) { dataGridView1.Rows[i].Cells[6].Value = TSMC51; }
                if (TSMC5 <= TSM45 && TSMC5 > TSM15) { dataGridView1.Rows[i].Cells[6].Value = TSMC52; }
                if (TSMC5 <= TSM15) { dataGridView1.Rows[i].Cells[6].Value = TSMC53; }

                if (TSMC6 >= TSM45) { dataGridView1.Rows[i].Cells[7].Value = TSMC61; }
                if (TSMC6 < TSM45 && TSMC6 >= TSM15) { dataGridView1.Rows[i].Cells[7].Value = TSMC62; }
                if (TSMC6 < TSM15) { dataGridView1.Rows[i].Cells[7].Value = TSMC63; }

                if (TSMC7 > TSM45) { dataGridView1.Rows[i].Cells[8].Value = TSMC71; }
                if (TSMC7 <= TSM45 && TSMC7 > TSM15) { dataGridView1.Rows[i].Cells[8].Value = TSMC72; }
                if (TSMC7 <= TSM15) { dataGridView1.Rows[i].Cells[8].Value = TSMC73; }


            }

        }

        void Change_Night_Hours_for_Calculation()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TimeSpan NT1 = new TimeSpan(24, 00, 00);
                TimeSpan C2 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                TimeSpan C3 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                TimeSpan C4 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                TimeSpan C5 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                TimeSpan C6 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                TimeSpan C7 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                TimeSpan C8 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());

                TimeSpan timeSpan = new TimeSpan(0);
                TimeSpan Th0 = new TimeSpan(00, 00, 00);
                TimeSpan Th1 = new TimeSpan(00, 30, 00);
                TimeSpan Th2 = new TimeSpan(01, 00, 00);
                TimeSpan Th3 = new TimeSpan(01, 30, 00);
                TimeSpan Th4 = new TimeSpan(02, 00, 00);
                TimeSpan Th5 = new TimeSpan(02, 30, 00);
                TimeSpan Th6 = new TimeSpan(03, 00, 00);
                TimeSpan Th7 = new TimeSpan(03, 30, 00);
                TimeSpan Th8 = new TimeSpan(04, 00, 00);
                TimeSpan Th9 = new TimeSpan(04, 30, 00);
                TimeSpan Th10 = new TimeSpan(05, 00, 00);
                TimeSpan Th11 = new TimeSpan(05, 30, 00);
                TimeSpan Th12 = new TimeSpan(06, 00, 00);
                TimeSpan Th13 = new TimeSpan(06, 30, 00);
                TimeSpan Th14 = new TimeSpan(07, 00, 00);

                /*TimeSpan TSC21 = new TimeSpan(24, Convert.ToInt32(C2.TotalMinutes), 0);*/

                TimeSpan TSC240 = new TimeSpan(24, 00, 0);
                TimeSpan TSC245 = new TimeSpan(24, 30, 0);
                TimeSpan TSC250 = new TimeSpan(25, 00, 0);
                TimeSpan TSC255 = new TimeSpan(25, 30, 0);
                TimeSpan TSC260 = new TimeSpan(26, 00, 0);
                TimeSpan TSC265 = new TimeSpan(26, 30, 0);
                TimeSpan TSC270 = new TimeSpan(27, 00, 0);
                TimeSpan TSC275 = new TimeSpan(27, 30, 0);
                TimeSpan TSC280 = new TimeSpan(28, 00, 0);
                TimeSpan TSC285 = new TimeSpan(28, 30, 0);
                TimeSpan TSC290 = new TimeSpan(29, 00, 0);
                TimeSpan TSC295 = new TimeSpan(29, 30, 0);
                TimeSpan TSC300 = new TimeSpan(30, 00, 0);
                TimeSpan TSC305 = new TimeSpan(30, 30, 0);
                TimeSpan TSC310 = new TimeSpan(31, 00, 0);

                TimeSpan TSC81 = new TimeSpan(24, Convert.ToInt32(C8.Minutes), 0);
                TimeSpan TSC82 = new TimeSpan(25, Convert.ToInt32(C8.Minutes), 0);
                TimeSpan TSC83 = new TimeSpan(26, Convert.ToInt32(C8.Minutes), 0);
                TimeSpan TSC84 = new TimeSpan(27, Convert.ToInt32(C8.Minutes), 0);
                TimeSpan TSC85 = new TimeSpan(28, Convert.ToInt32(C8.Minutes), 0);
                TimeSpan TSC86 = new TimeSpan(29, Convert.ToInt32(C8.Minutes), 0);
                TimeSpan TSC87 = new TimeSpan(30, Convert.ToInt32(C8.Minutes), 0);
                TimeSpan TSC88 = new TimeSpan(31, Convert.ToInt32(C8.Minutes), 0);

                if (C8 >= Th0 && C8 < Th2) { dataGridView1.Rows[i].Cells[9].Value = TSC81; }
                if (C8 >= Th2 && C8 < Th4) { dataGridView1.Rows[i].Cells[9].Value = TSC82; }
                if (C8 >= Th4 && C8 < Th6) { dataGridView1.Rows[i].Cells[9].Value = TSC83; }
                if (C8 >= Th6 && C8 < Th8) { dataGridView1.Rows[i].Cells[9].Value = TSC84; }
                if (C8 >= Th8 && C8 < Th10) { dataGridView1.Rows[i].Cells[9].Value = TSC85; }
                if (C8 >= Th10 && C8 < Th12) { dataGridView1.Rows[i].Cells[9].Value = TSC86; }
                if (C8 >= Th12 && C8 < Th14) { dataGridView1.Rows[i].Cells[9].Value = TSC87; }



                if (C3 != Th0 && C2 == Th0) { dataGridView1.Rows[i].Cells[3].Value = TSC240; }
                if (C3 != Th0 && C2 == Th1) { dataGridView1.Rows[i].Cells[3].Value = TSC245; }
                if (C3 != Th0 && C2 == Th2) { dataGridView1.Rows[i].Cells[3].Value = TSC250; }
                if (C3 != Th0 && C2 == Th3) { dataGridView1.Rows[i].Cells[3].Value = TSC255; }
                if (C3 != Th0 && C2 == Th4) { dataGridView1.Rows[i].Cells[3].Value = TSC260; }
                if (C3 != Th0 && C2 == Th5) { dataGridView1.Rows[i].Cells[3].Value = TSC265; }
                if (C3 != Th0 && C2 == Th6) { dataGridView1.Rows[i].Cells[3].Value = TSC270; }
                if (C3 != Th0 && C2 == Th7) { dataGridView1.Rows[i].Cells[3].Value = TSC275; }
                if (C3 != Th0 && C2 == Th8) { dataGridView1.Rows[i].Cells[3].Value = TSC280; }
                if (C3 != Th0 && C2 == Th9) { dataGridView1.Rows[i].Cells[3].Value = TSC285; }


                if (C2 != Th0 && C3 == Th0) { dataGridView1.Rows[i].Cells[4].Value = TSC240; }
                if (C2 != Th0 && C3 == Th1) { dataGridView1.Rows[i].Cells[4].Value = TSC245; }
                if (C2 != Th0 && C3 == Th2) { dataGridView1.Rows[i].Cells[4].Value = TSC250; }
                if (C2 != Th0 && C3 == Th3) { dataGridView1.Rows[i].Cells[4].Value = TSC255; }
                if (C2 != Th0 && C3 == Th4) { dataGridView1.Rows[i].Cells[4].Value = TSC260; }
                if (C2 != Th0 && C3 == Th5) { dataGridView1.Rows[i].Cells[4].Value = TSC265; }
                if (C2 != Th0 && C3 == Th6) { dataGridView1.Rows[i].Cells[4].Value = TSC270; }
                if (C2 != Th0 && C3 == Th7) { dataGridView1.Rows[i].Cells[4].Value = TSC275; }
                if (C2 != Th0 && C3 == Th8) { dataGridView1.Rows[i].Cells[4].Value = TSC280; }
                if (C2 != Th0 && C3 == Th9) { dataGridView1.Rows[i].Cells[4].Value = TSC285; }
                if (C2 != Th0 && C3 == Th10) { dataGridView1.Rows[i].Cells[4].Value = TSC290; }
                if (C2 != Th0 && C3 == Th11) { dataGridView1.Rows[i].Cells[4].Value = TSC295; }
                if (C2 != Th0 && C3 == Th12) { dataGridView1.Rows[i].Cells[4].Value = TSC300; }
                if (C2 != Th0 && C3 == Th13) { dataGridView1.Rows[i].Cells[4].Value = TSC305; }
                if (C2 != Th0 && C3 == Th14) { dataGridView1.Rows[i].Cells[4].Value = TSC310; }

                if (C5 != Th0 && C4 == Th0) { dataGridView1.Rows[i].Cells[5].Value = TSC240; }
                if (C5 != Th0 && C4 == Th1) { dataGridView1.Rows[i].Cells[5].Value = TSC245; }
                if (C5 != Th0 && C4 == Th2) { dataGridView1.Rows[i].Cells[5].Value = TSC250; }
                if (C5 != Th0 && C4 == Th3) { dataGridView1.Rows[i].Cells[5].Value = TSC255; }
                if (C5 != Th0 && C4 == Th4) { dataGridView1.Rows[i].Cells[5].Value = TSC260; }
                if (C5 != Th0 && C4 == Th5) { dataGridView1.Rows[i].Cells[5].Value = TSC265; }
                if (C5 != Th0 && C4 == Th6) { dataGridView1.Rows[i].Cells[5].Value = TSC270; }
                if (C5 != Th0 && C4 == Th7) { dataGridView1.Rows[i].Cells[5].Value = TSC275; }
                if (C5 != Th0 && C4 == Th8) { dataGridView1.Rows[i].Cells[5].Value = TSC280; }
                if (C5 != Th0 && C4 == Th9) { dataGridView1.Rows[i].Cells[5].Value = TSC285; }
                if (C5 != Th0 && C4 == Th10) { dataGridView1.Rows[i].Cells[5].Value = TSC290; }
                if (C5 != Th0 && C4 == Th11) { dataGridView1.Rows[i].Cells[5].Value = TSC295; }
                if (C5 != Th0 && C4 == Th12) { dataGridView1.Rows[i].Cells[5].Value = TSC300; }
                if (C5 != Th0 && C4 == Th13) { dataGridView1.Rows[i].Cells[5].Value = TSC305; }
                if (C5 != Th0 && C4 == Th14) { dataGridView1.Rows[i].Cells[5].Value = TSC310; }

                if (C4 != Th0 && C5 == Th0) { dataGridView1.Rows[i].Cells[6].Value = TSC240; }
                if (C4 != Th0 && C5 == Th1) { dataGridView1.Rows[i].Cells[6].Value = TSC245; }
                if (C4 != Th0 && C5 == Th2) { dataGridView1.Rows[i].Cells[6].Value = TSC250; }
                if (C4 != Th0 && C5 == Th3) { dataGridView1.Rows[i].Cells[6].Value = TSC255; }
                if (C4 != Th0 && C5 == Th4) { dataGridView1.Rows[i].Cells[6].Value = TSC260; }
                if (C4 != Th0 && C5 == Th5) { dataGridView1.Rows[i].Cells[6].Value = TSC265; }
                if (C4 != Th0 && C5 == Th6) { dataGridView1.Rows[i].Cells[6].Value = TSC270; }
                if (C4 != Th0 && C5 == Th7) { dataGridView1.Rows[i].Cells[6].Value = TSC275; }
                if (C4 != Th0 && C5 == Th8) { dataGridView1.Rows[i].Cells[6].Value = TSC280; }
                if (C4 != Th0 && C5 == Th9) { dataGridView1.Rows[i].Cells[6].Value = TSC285; }
                if (C4 != Th0 && C5 == Th10) { dataGridView1.Rows[i].Cells[6].Value = TSC290; }
                if (C4 != Th0 && C5 == Th11) { dataGridView1.Rows[i].Cells[6].Value = TSC295; }
                if (C4 != Th0 && C5 == Th12) { dataGridView1.Rows[i].Cells[6].Value = TSC300; }
                if (C4 != Th0 && C5 == Th13) { dataGridView1.Rows[i].Cells[6].Value = TSC305; }
                if (C4 != Th0 && C5 == Th14) { dataGridView1.Rows[i].Cells[6].Value = TSC310; }

                if (C7 != Th0 && C6 == Th0) { dataGridView1.Rows[i].Cells[7].Value = TSC240; }
                if (C7 != Th0 && C6 == Th1) { dataGridView1.Rows[i].Cells[7].Value = TSC245; }
                if (C7 != Th0 && C6 == Th2) { dataGridView1.Rows[i].Cells[7].Value = TSC250; }
                if (C7 != Th0 && C6 == Th3) { dataGridView1.Rows[i].Cells[7].Value = TSC255; }
                if (C7 != Th0 && C6 == Th4) { dataGridView1.Rows[i].Cells[7].Value = TSC260; }
                if (C7 != Th0 && C6 == Th5) { dataGridView1.Rows[i].Cells[7].Value = TSC265; }
                if (C7 != Th0 && C6 == Th6) { dataGridView1.Rows[i].Cells[7].Value = TSC270; }
                if (C7 != Th0 && C6 == Th7) { dataGridView1.Rows[i].Cells[7].Value = TSC275; }
                if (C7 != Th0 && C6 == Th8) { dataGridView1.Rows[i].Cells[7].Value = TSC280; }
                if (C7 != Th0 && C6 == Th9) { dataGridView1.Rows[i].Cells[7].Value = TSC285; }
                if (C7 != Th0 && C6 == Th10) { dataGridView1.Rows[i].Cells[7].Value = TSC290; }
                if (C7 != Th0 && C6 == Th11) { dataGridView1.Rows[i].Cells[7].Value = TSC295; }
                if (C7 != Th0 && C6 == Th12) { dataGridView1.Rows[i].Cells[7].Value = TSC300; }
                if (C7 != Th0 && C6 == Th13) { dataGridView1.Rows[i].Cells[7].Value = TSC305; }
                if (C7 != Th0 && C6 == Th14) { dataGridView1.Rows[i].Cells[7].Value = TSC310; }

                if (C6 != Th0 && C7 == Th0) { dataGridView1.Rows[i].Cells[8].Value = TSC240; }
                if (C6 != Th0 && C7 == Th1) { dataGridView1.Rows[i].Cells[8].Value = TSC245; }
                if (C6 != Th0 && C7 == Th2) { dataGridView1.Rows[i].Cells[8].Value = TSC250; }
                if (C6 != Th0 && C7 == Th3) { dataGridView1.Rows[i].Cells[8].Value = TSC255; }
                if (C6 != Th0 && C7 == Th4) { dataGridView1.Rows[i].Cells[8].Value = TSC260; }
                if (C6 != Th0 && C7 == Th5) { dataGridView1.Rows[i].Cells[8].Value = TSC265; }
                if (C6 != Th0 && C7 == Th6) { dataGridView1.Rows[i].Cells[8].Value = TSC270; }
                if (C6 != Th0 && C7 == Th7) { dataGridView1.Rows[i].Cells[8].Value = TSC275; }
                if (C6 != Th0 && C7 == Th8) { dataGridView1.Rows[i].Cells[8].Value = TSC280; }
                if (C6 != Th0 && C7 == Th9) { dataGridView1.Rows[i].Cells[8].Value = TSC285; }
                if (C6 != Th0 && C7 == Th10) { dataGridView1.Rows[i].Cells[8].Value = TSC290; }
                if (C6 != Th0 && C7 == Th11) { dataGridView1.Rows[i].Cells[8].Value = TSC295; }
                if (C6 != Th0 && C7 == Th12) { dataGridView1.Rows[i].Cells[8].Value = TSC300; }
                if (C6 != Th0 && C7 == Th13) { dataGridView1.Rows[i].Cells[8].Value = TSC305; }
                if (C6 != Th0 && C7 == Th14) { dataGridView1.Rows[i].Cells[8].Value = TSC310; }

            }

        }

        void Calculating_7Hours()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                /*TimeSpan C1 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());*/
                TimeSpan C2 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                TimeSpan C3 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                TimeSpan C4 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                TimeSpan C5 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                TimeSpan C6 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                TimeSpan C7 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                TimeSpan C8 = TimeSpan.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());


                TimeSpan timeSpan = new TimeSpan(0);
                TimeSpan Ts = new TimeSpan(00, 00, 00);
                TimeSpan Ts9 = new TimeSpan(99, 99, 99, 99);
                //The - Values
                TimeSpan MT1 = new TimeSpan(00, 30, 00);
                TimeSpan MT2 = new TimeSpan(01, 00, 00);
                TimeSpan MT3 = new TimeSpan(01, 30, 00);
                TimeSpan MT4 = new TimeSpan(02, 00, 00);
                TimeSpan MT5 = new TimeSpan(02, 30, 00);
                TimeSpan MT6 = new TimeSpan(03, 00, 00);
                TimeSpan MT7 = new TimeSpan(03, 30, 00);
                TimeSpan MT8 = new TimeSpan(04, 00, 00);
                TimeSpan MT9 = new TimeSpan(04, 30, 00);
                TimeSpan MT10 = new TimeSpan(05, 00, 00);
                TimeSpan MT11 = new TimeSpan(05, 30, 00);
                TimeSpan MT12 = new TimeSpan(06, 00, 00);
                TimeSpan MT13 = new TimeSpan(06, 30, 00);
                TimeSpan MT14 = new TimeSpan(07, 00, 00);
                TimeSpan MT15 = new TimeSpan(07, 30, 00);
                TimeSpan MT16 = new TimeSpan(08, 00, 00);
                TimeSpan MT17 = new TimeSpan(08, 30, 00);
                TimeSpan MT18 = new TimeSpan(09, 00, 00);
                TimeSpan MT19 = new TimeSpan(09, 30, 00);
                TimeSpan MT20 = new TimeSpan(10, 00, 00);
                TimeSpan MT21 = new TimeSpan(10, 30, 00);
                TimeSpan MT22 = new TimeSpan(11, 00, 00);
                TimeSpan MT23 = new TimeSpan(11, 30, 00);
                TimeSpan MT24 = new TimeSpan(12, 00, 00);
                TimeSpan MT25 = new TimeSpan(12, 30, 00);
                TimeSpan MT26 = new TimeSpan(13, 00, 00);
                TimeSpan MT27 = new TimeSpan(13, 30, 00);
                TimeSpan MT28 = new TimeSpan(14, 00, 00);
                TimeSpan MT29 = new TimeSpan(14, 30, 00);
                TimeSpan MT30 = new TimeSpan(15, 00, 00);
                TimeSpan MT31 = new TimeSpan(15, 30, 00);
                TimeSpan MT32 = new TimeSpan(16, 00, 00);
                TimeSpan MT33 = new TimeSpan(16, 30, 00);
                TimeSpan MT34 = new TimeSpan(17, 00, 00);


                //The area time values
                TimeSpan T70 = new TimeSpan(07, 00, 00);
                //
                TimeSpan T75 = new TimeSpan(07, 30, 00);
                TimeSpan T0 = new TimeSpan(08, 00, 00);
                TimeSpan T1 = new TimeSpan(08, 30, 00);
                TimeSpan T2 = new TimeSpan(09, 00, 00);
                TimeSpan T3 = new TimeSpan(09, 30, 00);
                TimeSpan T4 = new TimeSpan(10, 00, 00);
                TimeSpan T5 = new TimeSpan(10, 30, 00);
                TimeSpan T6 = new TimeSpan(11, 00, 00);
                TimeSpan T7 = new TimeSpan(11, 30, 00);
                TimeSpan T8 = new TimeSpan(12, 00, 00);
                TimeSpan T9 = new TimeSpan(12, 30, 00);
                TimeSpan T10 = new TimeSpan(13, 00, 00);
                TimeSpan T11 = new TimeSpan(13, 30, 00);
                TimeSpan T12 = new TimeSpan(14, 00, 00);
                TimeSpan T13 = new TimeSpan(14, 30, 00);
                TimeSpan T14 = new TimeSpan(15, 00, 00);
                TimeSpan T15 = new TimeSpan(15, 30, 00);
                TimeSpan T16 = new TimeSpan(16, 00, 00);
                TimeSpan T17 = new TimeSpan(16, 30, 00);
                TimeSpan T18 = new TimeSpan(17, 00, 00);
                TimeSpan T19 = new TimeSpan(17, 30, 00);
                TimeSpan T20 = new TimeSpan(18, 00, 00);
                TimeSpan T21 = new TimeSpan(18, 30, 00);
                TimeSpan T22 = new TimeSpan(19, 00, 00);
                TimeSpan T23 = new TimeSpan(19, 30, 00);
                TimeSpan T24 = new TimeSpan(20, 00, 00);
                TimeSpan T25 = new TimeSpan(20, 30, 00);
                TimeSpan T26 = new TimeSpan(21, 00, 00);
                TimeSpan T27 = new TimeSpan(21, 30, 00);
                TimeSpan T28 = new TimeSpan(22, 00, 00);
                TimeSpan T29 = new TimeSpan(22, 30, 00);
                TimeSpan T30 = new TimeSpan(23, 00, 00);
                TimeSpan T31 = new TimeSpan(23, 30, 00);
                TimeSpan T32 = new TimeSpan(24, 00, 00);
                TimeSpan T33 = new TimeSpan(24, 30, 00);


                if (C6 == null && C7 == null)
                {
                    timeSpan = (+C3.Subtract(C2)) + (+C5.Subtract(C4));
                    dataGridView1.Rows[i].Cells[10].Value = timeSpan;
                }
                else
                {
                    if (C4 == null && C5 == null && C6 == null && C7 == null)
                    {
                        timeSpan = +C3.Subtract(C2);
                        dataGridView1.Rows[i].Cells[10].Value = timeSpan;
                    }
                    else
                    {
                        timeSpan = (+C3.Subtract(C2)) + (+C5.Subtract(C4)) + (+C7.Subtract(C6));
                        dataGridView1.Rows[i].Cells[10].Value = timeSpan;
                    }
                }

                //Calculating

                if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) <= T70)
                {
                    if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = Ts9; }
                    else
                    {
                        if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = Ts9; }
                        else { dataGridView1.Rows[i].Cells[11].Value = Ts9; }
                    }
                }
                else
                {
                    if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T75)
                    {
                        if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT1; }
                        else
                        {
                            if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT1; }
                            else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT1; }

                        }
                    }
                    else
                    {
                        if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T0)
                        {
                            if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT2; }
                            else
                            {
                                if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT2; }
                                else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT2; }
                            }
                        }
                        else
                        {
                            if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T1)
                            {
                                if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT3; }
                                else
                                {
                                    if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT3; }
                                    else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT3; }
                                }
                            }
                            else
                            {
                                if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T2)
                                {
                                    if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT4; }
                                    else
                                    {
                                        if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT4; }
                                        else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT4; }
                                    }
                                }
                                else
                                {
                                    if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T3)
                                    {
                                        if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT5; }
                                        else
                                        {
                                            if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT5; }
                                            else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT5; }
                                        }
                                    }
                                    else
                                    {
                                        if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T4)
                                        {
                                            if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT6; }
                                            else
                                            {
                                                if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT6; }
                                                else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT6; }
                                            }
                                        }
                                        else
                                        {
                                            if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T5)
                                            {
                                                if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT7; }
                                                else
                                                {
                                                    if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT7; }
                                                    else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT7; }
                                                }
                                            }
                                            else
                                            {
                                                if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T6)
                                                {
                                                    if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT8; }
                                                    else
                                                    {
                                                        if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT8; }
                                                        else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT8; }
                                                    }
                                                }
                                                else
                                                {
                                                    if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T7)
                                                    {
                                                        if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT9; }
                                                        else
                                                        {
                                                            if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT9; }
                                                            else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT9; }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T8)
                                                        {
                                                            if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT10; }
                                                            else
                                                            {
                                                                if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT10; }
                                                                else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT10; }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T9)
                                                            {
                                                                if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT11; }
                                                                else
                                                                {
                                                                    if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT11; }
                                                                    else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT11; }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T10)
                                                                {
                                                                    if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT12; }
                                                                    else
                                                                    {
                                                                        if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT12; }
                                                                        else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT12; }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T11)
                                                                    {
                                                                        if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT13; }
                                                                        else
                                                                        {
                                                                            if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT13; }
                                                                            else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT13; }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T12)
                                                                        {
                                                                            if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT14; }
                                                                            else
                                                                            {
                                                                                if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT14; }
                                                                                else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT14; }
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T13)
                                                                            {
                                                                                if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT15; }
                                                                                else
                                                                                {
                                                                                    if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT15; }
                                                                                    else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT15; }
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T14)
                                                                                {
                                                                                    if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT16; }
                                                                                    else
                                                                                    {
                                                                                        if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT16; }
                                                                                        else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT16; }
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T15)
                                                                                    {
                                                                                        if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT17; }
                                                                                        else
                                                                                        {
                                                                                            if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT17; }
                                                                                            else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT17; }
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T16)
                                                                                        {
                                                                                            if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT18; }
                                                                                            else
                                                                                            {
                                                                                                if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT18; }
                                                                                                else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT18; }
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T17)
                                                                                            {
                                                                                                if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT19; }
                                                                                                else
                                                                                                {
                                                                                                    if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT19; }
                                                                                                    else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT19; }
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T18)
                                                                                                {
                                                                                                    if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT20; }
                                                                                                    else
                                                                                                    {
                                                                                                        if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT20; }
                                                                                                        else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT20; }
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T19)
                                                                                                    {
                                                                                                        if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT21; }
                                                                                                        else
                                                                                                        {
                                                                                                            if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT21; }
                                                                                                            else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT21; }
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T20)
                                                                                                        {
                                                                                                            if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT22; }
                                                                                                            else
                                                                                                            {
                                                                                                                if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT22; }
                                                                                                                else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT22; }
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T21)
                                                                                                            {
                                                                                                                if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT23; }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT23; }
                                                                                                                    else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT23; }
                                                                                                                }
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T22)
                                                                                                                {
                                                                                                                    if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT24; }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT24; }
                                                                                                                        else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT24; }
                                                                                                                    }
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T23)
                                                                                                                    {
                                                                                                                        if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT25; }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT25; }
                                                                                                                            else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT25; }
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T24)
                                                                                                                        {
                                                                                                                            if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT26; }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT26; }
                                                                                                                                else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT26; }
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T25)
                                                                                                                            {
                                                                                                                                if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT27; }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT27; }
                                                                                                                                    else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT27; }
                                                                                                                                }
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T26)
                                                                                                                                {
                                                                                                                                    if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT28; }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT28; }
                                                                                                                                        else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT28; }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T27)
                                                                                                                                    {
                                                                                                                                        if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT29; }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT29; }
                                                                                                                                            else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT29; }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T28)
                                                                                                                                        {
                                                                                                                                            if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT30; }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT30; }
                                                                                                                                                else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT30; }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T29)
                                                                                                                                            {
                                                                                                                                                if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT31; }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT31; }
                                                                                                                                                    else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT31; }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T30)
                                                                                                                                                {
                                                                                                                                                    if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT32; }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT32; }
                                                                                                                                                        else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT32; }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {

                                                                                                                                                    if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T31)
                                                                                                                                                    {
                                                                                                                                                        if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT33; }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT33; }
                                                                                                                                                            else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT33; }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        if (TimeSpan.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()) == T32)
                                                                                                                                                        {
                                                                                                                                                            if (C6 != Ts && C7 != Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT34; }
                                                                                                                                                            else
                                                                                                                                                            {
                                                                                                                                                                if (C4 != Ts && C5 != Ts && C6 == Ts && C7 == Ts) { dataGridView1.Rows[i].Cells[11].Value = C8 - MT34; }
                                                                                                                                                                else { dataGridView1.Rows[i].Cells[11].Value = C8 - MT34; }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
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
