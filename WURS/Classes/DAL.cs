using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WURS
{
    class DAL
    {
        public static string connectionString = "Server=daysafterdead.com,1444;Database=WURS;User ID="INSERTNAME";Password="INSERTPASSWORD";Trusted_Connection=False;";
        public static string BlockedUntil; // needs to be public static so it can be accessed from Login_Form
        public static string OldUsername;
        
        private static string CurPass;
        private static string ActivityName;
        private static string ActivityDescription;

        private string Uname_Temp;
        private string Pass_Temp;
        private string NewPassInput = null;
        private string OldPassInput = null;

        public DAL() { }

        public void Login(string Username, string Password, bool FromSession)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString)) // opens SQL connection
                {
                    conn.Open(); // connect

                    if (!FromSession)
                    {
                        string SelectString = "SELECT LastBlockedTime FROM Accounts WHERE Username=@uname"; // query to check until when user is blocked
                        SqlCommand sqlCmd = new SqlCommand(SelectString, conn);
                        SqlParameter uname = sqlCmd.Parameters.Add("@uname", SqlDbType.NVarChar, 15);
                        uname.Value = OldUsername;
                        SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                        while (sqlReader.Read())
                        {
                            BlockedUntil = (sqlReader["LastBlockedTime"].ToString());
                        }

                        sqlReader.Close();
                    }
                    else
                        OldUsername = Uname_Temp;

                    CurPass = Password;

                    using (SqlCommand cmd = new SqlCommand("Login", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@in_Username", SqlDbType.VarChar).Value = Username;
                        cmd.Parameters.Add("@in_Password", SqlDbType.VarChar).Value = Password;
                        cmd.Parameters.Add("@in_Attempt", SqlDbType.Int).Value = Login_Form.Attempt;
                        cmd.Parameters.Add("@in_FromSession", SqlDbType.Int).Value = FromSession;
                        cmd.Parameters.Add("@in_IP", SqlDbType.VarChar).Value = Program.UserIP; // get IP address

                        var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int); // save return value from database
                        returnParameter.Direction = ParameterDirection.ReturnValue;
                        
                        cmd.ExecuteNonQuery(); // execute stored procedure

                        var result = returnParameter.Value;

                        if ((int)result == 20)
                        {
                            conn.Close(); // got to close the connection otherwise changing password will throw an exception
                            ChangePass(true); // first login = true
                        }
                        else if ((int)result == 50 || Login_Form.Attempt >= 3) // blocked
                        {
                            System.Windows.Forms.MessageBox.Show(String.Format("Je account is geblokkeerd tot {0}.", BlockedUntil), "Fout");
                            Login_Form.Attempt = -1;
                        }
                        else if ((int)result == 10) // manager
                        {
                            Manager_Form MForm = new Manager_Form();
                            MForm.ShowDialog();
                            Login_Form.Attempt = -1;
                        }
                        else // employee
                        {
                            Employee_Form EForm = new Employee_Form();
                            EForm.ShowDialog();
                            Login_Form.Attempt = -1;
                        }
                    }
                }
            }

            catch (Exception) // user failed to login
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Login_WrongPass", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@in_Username", System.Data.SqlDbType.VarChar).Value = Username;
                        cmd.Parameters.Add("@in_Password", System.Data.SqlDbType.VarChar).Value = Password;
                        cmd.Parameters.Add("@in_Attempt", System.Data.SqlDbType.Int).Value = Login_Form.Attempt;
                        cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                        var returnParameter = cmd.Parameters.Add("@ReturnVal", System.Data.SqlDbType.Int);
                        returnParameter.Direction = System.Data.ParameterDirection.ReturnValue;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        var result = returnParameter.Value;

                        if ((int)result == 4)
                        {
                            System.Windows.Forms.MessageBox.Show("Dat account bestaat niet.", "Verkeerde gebruikersnaam");
                        }
                        else if ((int)result == 5)
                        {
                            System.Windows.Forms.MessageBox.Show("Dat wachtwoord bestaat niet", "Verkeerde wachtwoord");
                        }
                    }
                }
            }
        }

        public void ChangePass(bool FirstTime)
        {
            var PopupText = "";

            if (!FirstTime)
            {
                while (OldPassInput != CurPass)
                    OldPassInput = Microsoft.VisualBasic.Interaction.InputBox("Vul je huidige wachtwoord in.\n\n\n", "Wachtwoord veranderen", "", 0, 0);

                PopupText = "Je nieuwe wachtwoord moet minimaal 4 en maximaal 64 karakters lang zijn, en mag geen spaties bevatten.";
            }
            else
                PopupText = "Omdat dit de eerste keer is dat je inlogt, moet je een nieuw wachtwoord aanmaken." +
                    "\n\nJe wachtwoord moet minimaal 4 en maximaal 64 karakters lang zijn, en mag geen spaties bevatten.";

            // keep asking for a new password until the input is correct
            while (string.IsNullOrEmpty(NewPassInput) || string.IsNullOrWhiteSpace(NewPassInput)
                || NewPassInput.Contains(" ") || NewPassInput.Length > 64 || NewPassInput.Length < 4 || NewPassInput == "FirstLogin"
                || NewPassInput == OldUsername || NewPassInput == CurPass)
            {
                NewPassInput = Microsoft.VisualBasic.Interaction.InputBox(PopupText, "Wachtwoord veranderen", "", 0, 0);
            }

            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                conn.Open(); // open connection again
                using (SqlCommand cmd = new SqlCommand("ChangePass", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@in_Username", SqlDbType.VarChar).Value = OldUsername;
                    cmd.Parameters.Add("@in_NewPass", SqlDbType.VarChar).Value = NewPassInput;
                    cmd.Parameters.Add("@in_ReturnToLogin", SqlDbType.Int).Value = Convert.ToInt32(FirstTime);
                    cmd.Parameters.Add("@in_IP", SqlDbType.VarChar).Value = Program.UserIP; // get IP address

                    var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int); // save return value from database
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteNonQuery(); // execute stored procedure

                    var result = returnParameter.Value;

                    if ((int)result == 1)
                        Login(OldUsername, NewPassInput, false);
                    else if ((int)result == 2)
                        MessageBox.Show("Je wachtwoord is veranderd.", "Succes");

                    CurPass = NewPassInput;
                    NewPassInput = null;
                    OldPassInput = null;
                }
            }
        }

        public void Logout(string Username, bool Exit)
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) // opens SQL connection
            {
                conn.Open(); // connect

                using (SqlCommand cmd = new SqlCommand("Logout", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@in_Username", SqlDbType.VarChar).Value = Username;
                    cmd.Parameters.Add("@in_IP", SqlDbType.VarChar).Value = Program.UserIP; // get IP address

                    var returnParameter = cmd.Parameters.Add("@ReturnVal", System.Data.SqlDbType.Int);
                    returnParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery(); // execute stored procedure

                    var result = returnParameter.Value;

                    if ((int)result == 1 && Exit) // successful logout
                    {
                        Environment.Exit(0);
                    }
                    else if ((int)result == 1 && !Exit)
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
        }

        public void CheckSession()
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) // opens SQL connection
            {
                conn.Open(); // connect

                using (SqlCommand cmd = new SqlCommand("SessionCheck", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    cmd.Parameters.Add("@in_IP", SqlDbType.VarChar).Value = Program.UserIP; // get IP address

                    var returnParameter = cmd.Parameters.Add("@ReturnVal", System.Data.SqlDbType.Int);
                    returnParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery(); // execute stored procedure

                    var result = returnParameter.Value;

                    if ((int)result == 1)
                    {
                        var result2 = MessageBox.Show("Your previous session did not end properly, would you like to continue your session?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result2 == DialogResult.Yes)
                        {
                            SqlDataReader sqlReader = cmd.ExecuteReader();

                            while (sqlReader.Read())
                            {
                                Uname_Temp = sqlReader[0].ToString();
                                Pass_Temp = sqlReader[1].ToString();
                            }

                            sqlReader.Close();

                            conn.Close();
                            Login(Uname_Temp, Pass_Temp, true);
                        }
                    }
                }
            }
        }

        public void AddActivity()
        {
            ActivityName = Microsoft.VisualBasic.Interaction.InputBox("Typ de naam van de activiteit (4-64 karakters).", "Activiteit toevoegen", "", 0, 0);
            ActivityDescription = Microsoft.VisualBasic.Interaction.InputBox("Typ de beschrijving van de activiteit (1-256 karakters).", "Activiteit toevoegen", "", 0, 0);
            
            // keep asking for a name until the input is correct
            if (string.IsNullOrEmpty(ActivityName) || string.IsNullOrWhiteSpace(ActivityName) || ActivityName.Length > 64 || ActivityName.Length < 4)
            {
                MessageBox.Show("De activiteitsnaam moet uit minimaal 4 en maximaal 64 karakters bestaan.");
                AddActivity();
            }

            while (string.IsNullOrEmpty(ActivityDescription) || string.IsNullOrWhiteSpace(ActivityDescription) || ActivityDescription.Length > 256 || ActivityDescription.Length < 1)
            {
                MessageBox.Show("De beschrijving moet uit minimaal 1 en maximaal 256 karakters bestaan.");
                AddActivity();
            }

            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("Add_Activity", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@in_Username", SqlDbType.VarChar).Value = OldUsername;
                    cmd.Parameters.Add("@in_Name", SqlDbType.VarChar).Value = ActivityName;
                    cmd.Parameters.Add("@in_Description", SqlDbType.VarChar).Value = ActivityDescription;
                    cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                    cmd.ExecuteNonQuery(); // execute stored procedure
                }
            }

            MessageBox.Show("De activiteit is toegevoegd.", "Succes");
        }
    }
}
