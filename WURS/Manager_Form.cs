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
    public partial class Manager_Form : Form
    {
        DAL DAL = new DAL();
        private static int SelectedWeek;
        private static string FirstName;
        private static string MiddleName;
        private static string FamilyName;

        private static int MonApproved;
        private static int TueApproved;
        private static int WedApproved;
        private static int ThuApproved;
        private static int FriApproved;

        private static float WorkedHours;
        private static string ActivityType;
        private static string Comments;
        private static bool SickCheck;
        private static bool HomeCheck;

        private bool SelfSelected;

        public Manager_Form()
        {
            InitializeComponent();

            int week = GetIso8601WeekOfYear(DateTime.Now);
            for (int i = 1; i <= week; i++)
            {
                Week_ComboBox.Items.Add(i);
            }
            Week_ComboBox.SelectedItem = Week_ComboBox.Items.Count;

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

            SelectedWeek = Convert.ToInt32(Week_ComboBox.SelectedItem);

            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Load_Employee", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@in_Username", System.Data.SqlDbType.VarChar).Value = DAL.OldUsername;
                    cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                    cmd.ExecuteNonQuery();

                    SqlDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        if (sqlReader[1].ToString().Length > 0) // if employee has a middle name
                        {
                            Employee_Box.Items.Add(string.Format("{0} {1} {2}", sqlReader[0], sqlReader[1], sqlReader[2]));
                            Employee_Box.SelectedItem = string.Format("{0} {1} {2}", sqlReader[0], sqlReader[1], sqlReader[2]);
                        }
                        else
                        {
                            Employee_Box.Items.Add(string.Format("{0} {1}", sqlReader[0], sqlReader[2]));
                            Employee_Box.SelectedItem = string.Format("{0} {1}", sqlReader[0], sqlReader[2]);
                        }
                    }
                    sqlReader.Close();
                }
            }
        }

        private static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
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

        private void Load_Hours_Click(object sender, EventArgs e)
        {
            SelectedWeek = Convert.ToInt32(Week_ComboBox.SelectedItem);

            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Return_Hours_Manager", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@in_Username", System.Data.SqlDbType.VarChar).Value = DAL.OldUsername;
                    cmd.Parameters.Add("@in_SelectedFirstName", System.Data.SqlDbType.VarChar).Value = FirstName;
                    cmd.Parameters.Add("@in_SelectedMiddleName", System.Data.SqlDbType.VarChar).Value = MiddleName;
                    cmd.Parameters.Add("@in_SelectedFamilyName", System.Data.SqlDbType.VarChar).Value = FamilyName;
                    cmd.Parameters.Add("@in_SelectedWeek", System.Data.SqlDbType.Int).Value = SelectedWeek;
                    cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                    cmd.ExecuteNonQuery();

                    SqlDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        if(sqlReader[25].ToString() == DAL.OldUsername)
                        {
                            Send_Hour_Button.Text = "Indienen";
                            SelfSelected = true;
                            ChangeBoxStates(true);
                            GoedMon.Enabled = false;
                            GoedDi.Enabled = false;
                            GoedWo.Enabled = false;
                            GoedDo.Enabled = false;
                            GoedVr.Enabled = false;
                        }
                        else if(sqlReader[25].ToString() != DAL.OldUsername)
                        {
                            Send_Hour_Button.Text = "Wijzigen";
                            SelfSelected = false;
                            ChangeBoxStates(false);
                            GoedMon.Enabled = true;
                            GoedDi.Enabled = true;
                            GoedWo.Enabled = true;
                            GoedDo.Enabled = true;
                            GoedVr.Enabled = true;
                        }
                        Hour_Box_Ma.Text = sqlReader[0].ToString();
                        Acti_Box_Ma.Text = sqlReader[1].ToString();
                        Comment_Box_Ma.Text = sqlReader[2].ToString();
                        Sick_Check_Ma.Checked = Convert.ToBoolean(sqlReader[3]);
                        Home_Check_Ma.Checked = Convert.ToBoolean(sqlReader[4]);
                        MonApproved = Convert.ToInt32(sqlReader[26]);

                        Hour_Box_Di.Text = sqlReader[5].ToString();
                        Acti_Box_Di.Text = sqlReader[6].ToString();
                        Comment_Box_Di.Text = sqlReader[7].ToString();
                        Sick_Check_Di.Checked = Convert.ToBoolean(sqlReader[8]);
                        Home_Check_Di.Checked = Convert.ToBoolean(sqlReader[9]);
                        TueApproved = Convert.ToInt32(sqlReader[27]);

                        Hour_Box_Wo.Text = sqlReader[10].ToString();
                        Acti_Box_Wo.Text = sqlReader[11].ToString();
                        Comment_Box_Wo.Text = sqlReader[12].ToString();
                        Sick_Check_Wo.Checked = Convert.ToBoolean(sqlReader[13]);
                        Home_Check_Wo.Checked = Convert.ToBoolean(sqlReader[14]);
                        WedApproved = Convert.ToInt32(sqlReader[28]);

                        Hour_Box_Do.Text = sqlReader[15].ToString();
                        Acti_Box_Do.Text = sqlReader[16].ToString();
                        Comment_Box_Do.Text = sqlReader[17].ToString();
                        Sick_Check_Do.Checked = Convert.ToBoolean(sqlReader[18]);
                        Home_Check_Do.Checked = Convert.ToBoolean(sqlReader[19]);
                        ThuApproved = Convert.ToInt32(sqlReader[29]);

                        Hour_Box_Vr.Text = sqlReader[20].ToString();
                        Acti_Box_Vr.Text = sqlReader[21].ToString();
                        Comment_Box_Vr.Text = sqlReader[22].ToString();
                        Sick_Check_Vr.Checked = Convert.ToBoolean(sqlReader[23]);
                        Home_Check_Vr.Checked = Convert.ToBoolean(sqlReader[24]);
                        FriApproved = Convert.ToInt32(sqlReader[30]);
                    }

                    sqlReader.Close();
                }
            }

            if (MonApproved == 1)
            {
                Hour_Box_Ma.BackColor = Color.LightGreen;
                GoedMon.Checked = true;
            }
            else if (MonApproved == 2)
                Hour_Box_Ma.BackColor = Color.Red;
            else
                Hour_Box_Ma.BackColor = Color.Orange;

            if (TueApproved == 1)
            {
                Hour_Box_Di.BackColor = Color.LightGreen;
                GoedDi.Checked = true;
            }
            else if (TueApproved == 2)
                Hour_Box_Di.BackColor = Color.Red;
            else
                Hour_Box_Di.BackColor = Color.Orange;

            if (WedApproved == 1)
            {
                Hour_Box_Wo.BackColor = Color.LightGreen;
                GoedWo.Checked = true;
            }
            else if (WedApproved == 2)
                Hour_Box_Wo.BackColor = Color.Red;
            else
                Hour_Box_Wo.BackColor = Color.Orange;

            if (ThuApproved == 1)
            {
                Hour_Box_Do.BackColor = Color.LightGreen;
                GoedDo.Checked = true;
            }
            else if (ThuApproved == 2)
                Hour_Box_Do.BackColor = Color.Red;
            else
                Hour_Box_Do.BackColor = Color.Orange;

            if (FriApproved == 1)
            {
                Hour_Box_Vr.BackColor = Color.LightGreen;
                GoedVr.Checked = true;
            }
            else if (FriApproved == 2)
                Hour_Box_Vr.BackColor = Color.Red;
            else
                Hour_Box_Vr.BackColor = Color.Orange;

            Uren_Berekenen();
        }

        private void ChangeBoxStates(bool State)
        {
            Hour_Box_Ma.Enabled = State;
            Acti_Box_Ma.Enabled = State;
            Sick_Check_Ma.Enabled = State;
            Home_Check_Ma.Enabled = State;

            Hour_Box_Di.Enabled = State;
            Acti_Box_Di.Enabled = State;
            Sick_Check_Di.Enabled = State;
            Home_Check_Di.Enabled = State;

            Hour_Box_Wo.Enabled = State;
            Acti_Box_Wo.Enabled = State;
            Sick_Check_Wo.Enabled = State;
            Home_Check_Wo.Enabled = State;

            Hour_Box_Do.Enabled = State;
            Acti_Box_Do.Enabled = State;
            Sick_Check_Do.Enabled = State;
            Home_Check_Do.Enabled = State;

            Hour_Box_Vr.Enabled = State;
            Acti_Box_Vr.Enabled = State;
            Sick_Check_Vr.Enabled = State;
            Home_Check_Vr.Enabled = State;
        }

        private void Week_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Hours.PerformClick();
        }

        private void Employee_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            var BoxToString = Employee_Box.SelectedItem.ToString();
            FirstName = BoxToString.Split(' ').First();
            FamilyName = BoxToString.Split(' ').Last();
            MiddleName = BoxToString.Replace(FirstName, "");
            MiddleName = MiddleName.Replace(FamilyName, "");
            Load_Hours.PerformClick();
        }

        private void Add_Employee_Button_Click(object sender, EventArgs e)
        {
            Add_Employee_Form AEmpyForm = new Add_Employee_Form();
            AEmpyForm.Show();
        }

        private void Hour_Box_Ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void Manager_Form_Load(object sender, EventArgs e)
        {

        }

        private void Send_Hour_Button_Click(object sender, EventArgs e)
        {
            SelectedWeek = Convert.ToInt32(Week_ComboBox.SelectedItem);

            if (SelfSelected)
            {
                CheckEmpty();
                CheckMaxHours();
            }
            else
            {
                MonApproved = Convert.ToInt32(GoedMon.Checked);
                TueApproved = Convert.ToInt32(GoedDi.Checked);
                WedApproved = Convert.ToInt32(GoedWo.Checked);
                ThuApproved = Convert.ToInt32(GoedDo.Checked);
                FriApproved = Convert.ToInt32(GoedVr.Checked);

                using (SqlConnection conn = new SqlConnection(DAL.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Edit_Hours", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@in_Username", System.Data.SqlDbType.VarChar).Value = DAL.OldUsername;
                        cmd.Parameters.Add("@in_SelectedFirstName", System.Data.SqlDbType.VarChar).Value = FirstName;
                        cmd.Parameters.Add("@in_SelectedMiddleName", System.Data.SqlDbType.VarChar).Value = MiddleName;
                        cmd.Parameters.Add("@in_SelectedFamilyName", System.Data.SqlDbType.VarChar).Value = FamilyName;
                        cmd.Parameters.Add("@in_SelectedWeek", System.Data.SqlDbType.Int).Value = SelectedWeek;
                        cmd.Parameters.Add("@in_CommentsMon", System.Data.SqlDbType.VarChar).Value = Comment_Box_Ma.Text;
                        cmd.Parameters.Add("@in_CommentsTue", System.Data.SqlDbType.VarChar).Value = Comment_Box_Di.Text;
                        cmd.Parameters.Add("@in_CommentsWed", System.Data.SqlDbType.VarChar).Value = Comment_Box_Wo.Text;
                        cmd.Parameters.Add("@in_CommentsThu", System.Data.SqlDbType.VarChar).Value = Comment_Box_Do.Text;
                        cmd.Parameters.Add("@in_CommentsFri", System.Data.SqlDbType.VarChar).Value = Comment_Box_Vr.Text;
                        cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                        if (MonApproved == 1)
                            cmd.Parameters.Add("@in_MonApproved", System.Data.SqlDbType.Int).Value = 1;
                        else
                            cmd.Parameters.Add("@in_MonApproved", System.Data.SqlDbType.Int).Value = 2;

                        if (TueApproved == 1)
                            cmd.Parameters.Add("@in_TueApproved", System.Data.SqlDbType.Int).Value = 1;
                        else
                            cmd.Parameters.Add("@in_TueApproved", System.Data.SqlDbType.Int).Value = 2;

                        if (WedApproved == 1)
                            cmd.Parameters.Add("@in_WedApproved", System.Data.SqlDbType.Int).Value = 1;
                        else
                            cmd.Parameters.Add("@in_WedApproved", System.Data.SqlDbType.Int).Value = 2;

                        if (ThuApproved == 1)
                            cmd.Parameters.Add("@in_ThuApproved", System.Data.SqlDbType.Int).Value = 1;
                        else
                            cmd.Parameters.Add("@in_ThuApproved", System.Data.SqlDbType.Int).Value = 2;

                        if (FriApproved == 1)
                            cmd.Parameters.Add("@in_FriApproved", System.Data.SqlDbType.Int).Value = 1;
                        else
                            cmd.Parameters.Add("@in_FriApproved", System.Data.SqlDbType.Int).Value = 2;

                        cmd.ExecuteNonQuery();
                    }
                }
            }

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
            }
        }

        private void ChangePass_Button_Click(object sender, EventArgs e)
        {
            DAL.ChangePass(false);
        }

        private void New_Activity_Click(object sender, EventArgs e)
        {
            DAL.AddActivity();
        }

        private void Uren_Berekenen()
        {
            SelectedWeek = Convert.ToInt32(Week_ComboBox.SelectedItem);

            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Load_Contract_Wage", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@in_Username", System.Data.SqlDbType.VarChar).Value = DAL.OldUsername;
                    cmd.Parameters.Add("@in_SelectedFirstName", System.Data.SqlDbType.VarChar).Value = FirstName;
                    cmd.Parameters.Add("@in_SelectedMiddleName", System.Data.SqlDbType.VarChar).Value = MiddleName;
                    cmd.Parameters.Add("@in_SelectedFamilyName", System.Data.SqlDbType.VarChar).Value = FamilyName;
                    cmd.Parameters.Add("@in_SelectedWeek", System.Data.SqlDbType.Int).Value = SelectedWeek;
                    cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                    cmd.ExecuteNonQuery();

                    SqlDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        float HoursMa, HoursDi, HoursWo, HoursDo, HoursVr, HourWage;
                        float.TryParse(Hour_Box_Ma.Text, out HoursMa);
                        float.TryParse(Hour_Box_Di.Text, out HoursDi);
                        float.TryParse(Hour_Box_Wo.Text, out HoursWo);
                        float.TryParse(Hour_Box_Do.Text, out HoursDo);
                        float.TryParse(Hour_Box_Vr.Text, out HoursVr);
                        float HoursWorkedThisWeek = HoursMa + HoursDi + HoursWo + HoursDo + HoursVr;

                        string HourWage_String = sqlReader[0].ToString();
                        float.TryParse(HourWage_String, out HourWage);
                        float result = (HoursWorkedThisWeek * HourWage);

                        WageThisWeek.Text = String.Format("Loon deze week: € {0}", result);
                    }
                    sqlReader.Close();
                }
            }
        }

        private void WageThisWeek_Click(object sender, EventArgs e)
        {

        }
    }
}
