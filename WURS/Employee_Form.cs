using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace WURS
{
    public partial class Employee_Form : Form
    {
        DAL DAL = new DAL();
        private static float WorkedHours;
        private static string ActivityType;
        private static string Comments;
        private static bool SickCheck;
        private static bool HomeCheck;
        private static int SelectedWeek;

        private static int MonApproved;
        private static int TueApproved;
        private static int WedApproved;
        private static int ThuApproved;
        private static int FriApproved;

        private static float HourMa, HourDi, HourWo, HourDo, HourVr;
        private static float WorkedWeek1, WorkedWeek2, WorkedWeek3, WorkedWeek4, WorkedWeek5;
        private static float WorkedThisMonth;
        private static float WorkedYear;
        private static float HWorkedWeek;
        private static float HourlyWage;
        private static bool IsInternal = false;

        private static DayOfWeek CurDay;

        private static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            CurDay = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (CurDay >= DayOfWeek.Monday && CurDay <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        private static DateTime YearWeekToDateTime(int year, DayOfWeek day, int week)
        {
            DateTime startOfYear = new DateTime(year, 1, 1);

            // The +7 and %7 stuff is to avoid negative numbers etc.
            int daysToFirstCorrectDay = (((int)day - (int)startOfYear.DayOfWeek) + 7) % 7;

            return startOfYear.AddDays(7 * (week - 1) + daysToFirstCorrectDay);
        }

        public Employee_Form()
        {
            InitializeComponent();

            int week = GetIso8601WeekOfYear(DateTime.Now);
            for (int i = 1; i <= week; i++)
            {
                Week_ComboBox.Items.Add(i);
            }
            //Week_ComboBox.SelectedItem = Week_ComboBox.Items.Count;

            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT Name From ActivityType", conn);
                conn.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    Acti_Box_Ma.Items.Add(sqlReader["Name"].ToString());
                    Acti_Box_Di.Items.Add(sqlReader["Name"].ToString());
                    Acti_Box_Wo.Items.Add(sqlReader["Name"].ToString());
                    Acti_Box_Do.Items.Add(sqlReader["Name"].ToString());
                    Acti_Box_Vr.Items.Add(sqlReader["Name"].ToString());
                }

                sqlReader.Close();
            }

            HoursWorkedWeek.Visible = false;
            HoursWorkedWeekBG.Visible = false;
            MoneyEarnedWeek.Visible = false;
            MoneyEarnedWeekBG.Visible = false;
            Rapporten_ComboBox.Visible = false;
            RapportenText.Visible = false;

            Rapporten_ComboBox.Items.Add("Dag");
            Rapporten_ComboBox.Items.Add("Week");
            Rapporten_ComboBox.Items.Add("Maand");
            Rapporten_ComboBox.Items.Add("Jaar");
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DAL.Logout(DAL.OldUsername, false);
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DAL.Logout(DAL.OldUsername, true);
            }
        }

        private void ChangePass_Button_Click(object sender, EventArgs e)
        {
            DAL.ChangePass(false);
        }

        private void Send_Hour_Button_Click(object sender, EventArgs e)
        {
            CheckEmpty();
            CheckMaxHours();
        }

        private void InsertHours()
        {
            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                conn.Open();

                for (int i = 1; i < 6; i++)
                {
                    using (SqlCommand cmd = new SqlCommand("Insert_Hours", conn))
                    {
                        if (i == 1)
                        {
                            WorkedHours = float.Parse(Hour_Box_Ma.Text);
                            ActivityType = Acti_Box_Ma.Text;
                            Comments = Comment_Box_Ma.Text;
                            SickCheck = Sick_Check_Ma.Checked;
                            HomeCheck = Home_Check_Ma.Checked;
                        }
                        else if (i == 2)
                        {
                            WorkedHours = float.Parse(Hour_Box_Di.Text);
                            ActivityType = Acti_Box_Di.Text;
                            Comments = Comment_Box_Di.Text;
                            SickCheck = Sick_Check_Di.Checked;
                            HomeCheck = Home_Check_Di.Checked;
                        }
                        else if (i == 3)
                        {
                            WorkedHours = float.Parse(Hour_Box_Wo.Text);
                            ActivityType = Acti_Box_Wo.Text;
                            Comments = Comment_Box_Wo.Text;
                            SickCheck = Sick_Check_Wo.Checked;
                            HomeCheck = Home_Check_Wo.Checked;
                        }
                        else if (i == 4)
                        {
                            WorkedHours = float.Parse(Hour_Box_Do.Text);
                            ActivityType = Acti_Box_Do.Text;
                            Comments = Comment_Box_Do.Text;
                            SickCheck = Sick_Check_Do.Checked;
                            HomeCheck = Home_Check_Do.Checked;
                        }
                        else if (i == 5)
                        {
                            WorkedHours = float.Parse(Hour_Box_Vr.Text);
                            ActivityType = Acti_Box_Vr.Text;
                            Comments = Comment_Box_Vr.Text;
                            SickCheck = Sick_Check_Vr.Checked;
                            HomeCheck = Home_Check_Vr.Checked;
                        }

                        if (SickCheck)
                        {
                            WorkedHours = 0;
                            HomeCheck = false;
                            ActivityType = " ";
                        }

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@in_Username", SqlDbType.VarChar).Value = DAL.OldUsername;
                        cmd.Parameters.Add("@in_Week", SqlDbType.Int).Value = Week_ComboBox.SelectedItem;
                        cmd.Parameters.Add("@in_Day", SqlDbType.Int).Value = i;
                        cmd.Parameters.Add("@in_Year", SqlDbType.Int).Value = 2019;
                        cmd.Parameters.Add("@in_WorkedHours", SqlDbType.Float).Value = Math.Round(WorkedHours, 1);
                        cmd.Parameters.Add("@in_ActivityType", SqlDbType.VarChar).Value = ActivityType;
                        cmd.Parameters.Add("@in_Comments", SqlDbType.VarChar).Value = Comments;
                        cmd.Parameters.Add("@in_Sick", SqlDbType.Int).Value = SickCheck;
                        cmd.Parameters.Add("@in_Home", SqlDbType.Int).Value = HomeCheck;
                        cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                        cmd.ExecuteNonQuery(); // execute stored procedure
                    }
                }

                MessageBox.Show("Je uren zijn opgeslagen.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearBoxes();
            }
        }

        private void Load_Hours_Click(object sender, EventArgs e)
        {
            SelectedWeek = Convert.ToInt32(Week_ComboBox.SelectedItem);
            RapportenText.Visible = true;
            Rapporten_ComboBox.Visible = true;

            if (!HoursWorkedWeekBG.Visible)
            {
                HoursWorkedWeekBG.Visible = true;
                HoursWorkedWeek.Visible = true;
            }

            if (!MoneyEarnedWeekBG.Visible)
            {
                MoneyEarnedWeekBG.Visible = true;
                MoneyEarnedWeek.Visible = true;
            }

            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Return_Hours_Employee", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@in_Username", System.Data.SqlDbType.VarChar).Value = DAL.OldUsername;
                    cmd.Parameters.Add("@in_SelectedWeek", System.Data.SqlDbType.Int).Value = SelectedWeek;
                    cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;
                    
                    cmd.ExecuteNonQuery();

                    SqlDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        Hour_Box_Ma.Text = sqlReader[0].ToString();
                        Acti_Box_Ma.Text = sqlReader[1].ToString();
                        Comment_Box_Ma.Text = sqlReader[2].ToString();
                        Sick_Check_Ma.Checked = Convert.ToBoolean(sqlReader[3]);
                        Home_Check_Ma.Checked = Convert.ToBoolean(sqlReader[4]);
                        MonApproved = Convert.ToInt32(sqlReader[25]);

                        Hour_Box_Di.Text = sqlReader[5].ToString();
                        Acti_Box_Di.Text = sqlReader[6].ToString();
                        Comment_Box_Di.Text = sqlReader[7].ToString();
                        Sick_Check_Di.Checked = Convert.ToBoolean(sqlReader[8]);
                        Home_Check_Di.Checked = Convert.ToBoolean(sqlReader[9]);
                        TueApproved = Convert.ToInt32(sqlReader[26]);

                        Hour_Box_Wo.Text = sqlReader[10].ToString();
                        Acti_Box_Wo.Text = sqlReader[11].ToString();
                        Comment_Box_Wo.Text = sqlReader[12].ToString();
                        Sick_Check_Wo.Checked = Convert.ToBoolean(sqlReader[13]);
                        Home_Check_Wo.Checked = Convert.ToBoolean(sqlReader[14]);
                        WedApproved = Convert.ToInt32(sqlReader[27]);

                        Hour_Box_Do.Text = sqlReader[15].ToString();
                        Acti_Box_Do.Text = sqlReader[16].ToString();
                        Comment_Box_Do.Text = sqlReader[17].ToString();
                        Sick_Check_Do.Checked = Convert.ToBoolean(sqlReader[18]);
                        Home_Check_Do.Checked = Convert.ToBoolean(sqlReader[19]);
                        ThuApproved = Convert.ToInt32(sqlReader[28]);

                        Hour_Box_Vr.Text = sqlReader[20].ToString();
                        Acti_Box_Vr.Text = sqlReader[21].ToString();
                        Comment_Box_Vr.Text = sqlReader[22].ToString();
                        Sick_Check_Vr.Checked = Convert.ToBoolean(sqlReader[23]);
                        Home_Check_Vr.Checked = Convert.ToBoolean(sqlReader[24]);
                        FriApproved = Convert.ToInt32(sqlReader[29]);
                        if (Convert.ToInt32(sqlReader[30]) == 1) // if user is internal, don't allow Home to be checked
                        {
                            IsInternal = true;
                        }
                    }

                    sqlReader.Close();
                }
            }

            bool Mon = true;
            bool Tue = true;
            bool Wed = true;
            bool Thu = true;
            bool Fri = true;

            if (MonApproved == 1)
            {
                Hour_Box_Ma.BackColor = Color.LightGreen;
                Mon = false;
            }
            else if (MonApproved == 2)
                Hour_Box_Ma.BackColor = Color.Red;
            else
                Hour_Box_Ma.BackColor = Color.Orange;

            if (TueApproved == 1)
            {
                Hour_Box_Di.BackColor = Color.LightGreen;
                Tue = false;
            }
            else if (TueApproved == 2)
                Hour_Box_Di.BackColor = Color.Red;
            else
                Hour_Box_Di.BackColor = Color.Orange;

            if (WedApproved == 1)
            {
                Hour_Box_Wo.BackColor = Color.LightGreen;
                Wed = false;
            }
            else if (WedApproved == 2)
                Hour_Box_Wo.BackColor = Color.Red;
            else
                Hour_Box_Wo.BackColor = Color.Orange;

            if (ThuApproved == 1)
            {
                Hour_Box_Do.BackColor = Color.LightGreen;
                Thu = false;
            }
            else if (ThuApproved == 2)
                Hour_Box_Do.BackColor = Color.Red;
            else
                Hour_Box_Do.BackColor = Color.Orange;

            if (FriApproved == 1)
            {
                Hour_Box_Vr.BackColor = Color.LightGreen;
                Fri = false;
            }
            else if (FriApproved == 2)
                Hour_Box_Vr.BackColor = Color.Red;
            else
                Hour_Box_Vr.BackColor = Color.Orange;

            ChangeBoxState(Mon, Tue, Wed, Thu, Fri);

            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Load_Contract_Wage_Employee", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@in_Username", System.Data.SqlDbType.VarChar).Value = DAL.OldUsername;
                    cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                    cmd.ExecuteNonQuery();

                    SqlDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        string HourlyWage_String = sqlReader[0].ToString();
                        float.TryParse(HourlyWage_String, out HourlyWage);
                    }
                    sqlReader.Close();
                }
            }

            float.TryParse(Hour_Box_Ma.Text, out HourMa);
            float.TryParse(Hour_Box_Di.Text, out HourDi);
            float.TryParse(Hour_Box_Wo.Text, out HourWo);
            float.TryParse(Hour_Box_Do.Text, out HourDo);
            float.TryParse(Hour_Box_Vr.Text, out HourVr);

            HWorkedWeek = HourMa + HourDi + HourWo + HourDo + HourVr;

            HoursWorkedWeek.Text = String.Format("{0} uren gewerkt", HWorkedWeek);
            MoneyEarnedWeek.Text = String.Format("€ {0} verdient", HWorkedWeek * HourlyWage);
            }

        private void Week_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void ChangeBoxState(bool StateMon, bool StateTue, bool StateWed, bool StateThu, bool StateFri)
        {
            Hour_Box_Ma.Enabled = StateMon;
            Acti_Box_Ma.Enabled = StateMon;
            Comment_Box_Ma.Enabled = StateMon;
            Sick_Check_Ma.Enabled = StateMon;
            Home_Check_Ma.Enabled = StateMon;

            Hour_Box_Di.Enabled = StateTue;
            Acti_Box_Di.Enabled = StateTue;
            Comment_Box_Di.Enabled = StateTue;
            Sick_Check_Di.Enabled = StateTue;
            Home_Check_Di.Enabled = StateTue;

            Hour_Box_Wo.Enabled = StateWed;
            Acti_Box_Wo.Enabled = StateWed;
            Comment_Box_Wo.Enabled = StateWed;
            Sick_Check_Wo.Enabled = StateWed;
            Home_Check_Wo.Enabled = StateWed;

            Hour_Box_Do.Enabled = StateThu;
            Acti_Box_Do.Enabled = StateThu;
            Comment_Box_Do.Enabled = StateThu;
            Sick_Check_Do.Enabled = StateThu;
            Home_Check_Do.Enabled = StateThu;

            Hour_Box_Vr.Enabled = StateFri;
            Acti_Box_Vr.Enabled = StateFri;
            Comment_Box_Vr.Enabled = StateFri;
            Sick_Check_Vr.Enabled = StateFri;
            Home_Check_Vr.Enabled = StateFri;

            if (IsInternal)
            {
                Home_Check_Ma.Enabled = false;
                Home_Check_Di.Enabled = false;
                Home_Check_Wo.Enabled = false;
                Home_Check_Do.Enabled = false;
                Home_Check_Vr.Enabled = false;
            }
        }

        private void ClearBoxes()
        {
            Hour_Box_Ma.ResetText();
            Hour_Box_Ma.BackColor = Color.White;
            Acti_Box_Ma.SelectedItem = null;
            Comment_Box_Ma.ResetText();
            Sick_Check_Ma.Checked = false;
            Home_Check_Ma.Checked = false;

            Hour_Box_Di.ResetText();
            Hour_Box_Di.BackColor = Color.White;
            Acti_Box_Di.SelectedItem = null;
            Comment_Box_Di.ResetText();
            Sick_Check_Di.Checked = false;
            Home_Check_Di.Checked = false;

            Hour_Box_Wo.ResetText();
            Hour_Box_Wo.BackColor = Color.White;
            Acti_Box_Wo.SelectedItem = null;
            Comment_Box_Wo.ResetText();
            Sick_Check_Wo.Checked = false;
            Home_Check_Wo.Checked = false;

            Hour_Box_Do.ResetText();
            Hour_Box_Do.BackColor = Color.White;
            Acti_Box_Do.SelectedItem = null;
            Comment_Box_Do.ResetText();
            Sick_Check_Do.Checked = false;
            Home_Check_Do.Checked = false;

            Hour_Box_Vr.ResetText();
            Hour_Box_Vr.BackColor = Color.White;
            Acti_Box_Vr.SelectedItem = null;
            Comment_Box_Vr.ResetText();
            Sick_Check_Vr.Checked = false;
            Home_Check_Vr.Checked = false;

            Load_Hours.PerformClick();
        }

        private void CheckEmpty()
        {
            if (Hour_Box_Ma.Text == "") Hour_Box_Ma.Text = "0";
            if (Acti_Box_Ma.Text == "") Acti_Box_Ma.Text = " ";
            if (Comment_Box_Ma.Text == "") Comment_Box_Ma.Text = "Geen commentaar";

            if (Hour_Box_Di.Text == "") Hour_Box_Di.Text = "0";
            if (Acti_Box_Di.Text == "") Acti_Box_Di.Text = " ";
            if (Comment_Box_Di.Text == "") Comment_Box_Di.Text = "Geen commentaar";

            if (Hour_Box_Wo.Text == "") Hour_Box_Wo.Text = "0";
            if (Acti_Box_Wo.Text == "") Acti_Box_Wo.Text = " ";
            if (Comment_Box_Wo.Text == "") Comment_Box_Wo.Text = "Geen commentaar";

            if (Hour_Box_Do.Text == "") Hour_Box_Do.Text = "0";
            if (Acti_Box_Do.Text == "") Acti_Box_Do.Text = " ";
            if (Comment_Box_Do.Text == "") Comment_Box_Do.Text = "Geen commentaar";

            if (Hour_Box_Vr.Text == "") Hour_Box_Vr.Text = "0";
            if (Acti_Box_Vr.Text == "") Acti_Box_Vr.Text = " ";
            if (Comment_Box_Vr.Text == "") Comment_Box_Vr.Text = "Geen commentaar";
        }

        private void CheckMaxHours()
        {
            float HoursMa, HoursDi, HoursWo, HoursDo, HoursVr;
            float.TryParse(Hour_Box_Ma.Text, out HoursMa);
            float.TryParse(Hour_Box_Di.Text, out HoursDi);
            float.TryParse(Hour_Box_Wo.Text, out HoursWo);
            float.TryParse(Hour_Box_Do.Text, out HoursDo);
            float.TryParse(Hour_Box_Vr.Text, out HoursVr);

            float HoursWorkedThisWeek = HoursMa + HoursDi + HoursWo + HoursDo + HoursVr;

            if (HoursWorkedThisWeek > 60)
                MessageBox.Show(String.Format("Je mag maximaal 60 uren per week indienen. Je hebt er momenteel {0} ingevuld.", HoursWorkedThisWeek));
            else
                InsertHours();
        }

        private void Hour_Box_Ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rapporten_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int CurMonth = Convert.ToInt32(DateTime.Now.Month);

            if (Rapporten_ComboBox.SelectedItem == "Dag")
            {
                int CurDayOfWeek = Convert.ToInt32(CurDay);

                if (CurDayOfWeek == 1)
                    MessageBox.Show(String.Format("Je hebt vandaag ({0}) {1} uren gewerkt en € {2} verdient.", CurDay, HourMa, HourMa * HourlyWage));
                else if (CurDayOfWeek == 2)
                    MessageBox.Show(String.Format("Je hebt vandaag ({0}) {1} uren gewerkt en € {2} verdient.", CurDay, HourDi, HourDi * HourlyWage));
                else if (CurDayOfWeek == 3)
                    MessageBox.Show(String.Format("Je hebt vandaag ({0}) {1} uren gewerkt en € {2} verdient.", CurDay, HourWo, HourWo * HourlyWage));
                else if (CurDayOfWeek == 4)
                    MessageBox.Show(String.Format("Je hebt vandaag ({0}) {1} uren gewerkt en € {2} verdient.", CurDay, HourDo, HourDo * HourlyWage));
                else if (CurDayOfWeek == 5)
                    MessageBox.Show(String.Format("Je hebt vandaag ({0}) {1} uren gewerkt en € {2} verdient.", CurDay, HourVr, HourVr * HourlyWage));
                else // weekend
                    MessageBox.Show("Je hebt vandaag niet gewerkt.");
            }

            else if (Rapporten_ComboBox.SelectedItem == "Week")
                MessageBox.Show(String.Format("Je hebt in week {0} {1} uren gewerkt en € {2} verdient.", SelectedWeek, HWorkedWeek, HWorkedWeek * HourlyWage));
            
            else if (Rapporten_ComboBox.SelectedItem == "Maand")
            {
                using (SqlConnection conn = new SqlConnection(DAL.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Return_Hours_Worked", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@in_Username", System.Data.SqlDbType.VarChar).Value = DAL.OldUsername;
                        cmd.Parameters.Add("@in_CurrentMonth", System.Data.SqlDbType.Int).Value = CurMonth;
                        cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                        cmd.ExecuteNonQuery();

                        SqlDataReader sqlReader = cmd.ExecuteReader();

                        while (sqlReader.Read())
                        {
                            string WorkedThisMonth1_String = sqlReader[0].ToString();
                            string WorkedThisMonth2_String = sqlReader[1].ToString();
                            string WorkedThisMonth3_String = sqlReader[2].ToString();
                            string WorkedThisMonth4_String = sqlReader[3].ToString();
                            string WorkedThisMonth5_String = sqlReader[4].ToString();

                            float.TryParse(WorkedThisMonth1_String, out WorkedWeek1);
                            float.TryParse(WorkedThisMonth2_String, out WorkedWeek2);
                            float.TryParse(WorkedThisMonth3_String, out WorkedWeek3);
                            float.TryParse(WorkedThisMonth4_String, out WorkedWeek4);
                            float.TryParse(WorkedThisMonth5_String, out WorkedWeek5);
                            WorkedThisMonth = WorkedWeek1 + WorkedWeek2 + WorkedWeek3 + WorkedWeek4 + WorkedWeek5;
                        }
                        sqlReader.Close();
                    }
                }

                MessageBox.Show(String.Format("Je hebt deze maand {0} uren gewerkt en € {1} verdient.", WorkedThisMonth, WorkedThisMonth * HourlyWage));
            }

            else if (Rapporten_ComboBox.SelectedItem == "Jaar")
            {
                using (SqlConnection conn = new SqlConnection(DAL.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Return_Hours_Worked", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@in_Username", System.Data.SqlDbType.VarChar).Value = DAL.OldUsername;
                        cmd.Parameters.Add("@in_CurrentMonth", System.Data.SqlDbType.Int).Value = 20;
                        cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                        cmd.ExecuteNonQuery();

                        SqlDataReader sqlReader = cmd.ExecuteReader();

                        while (sqlReader.Read())
                        {
                            string WorkedThisYear_String = sqlReader[5].ToString();
                            float.TryParse(WorkedThisYear_String, out WorkedYear);
                        }
                        sqlReader.Close();
                    }
                }

                MessageBox.Show(String.Format("Je hebt dit jaar {0} uren gewerkt en € {1} verdient.", WorkedYear, WorkedYear * HourlyWage));
            }
        }
    }
}
