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
using System.Windows;

namespace WURS
{
    public partial class Add_Employee_Form : Form
    {
        public Add_Employee_Form()
        {
            InitializeComponent();
            Employee_Function_ComboBox.Items.Add("Medewerker");
            Employee_Function_ComboBox.Items.Add("Manager");
            Employee_Function_ComboBox.SelectedItem = "Medewerker";

            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Load_Managers", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                    cmd.ExecuteNonQuery();

                    SqlDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        Employee_Manager_ComboBox.Items.Add(string.Format("{0}", sqlReader[0]));
                        Employee_Manager_ComboBox.SelectedItem = Employee_Manager_ComboBox.Items[0];
                    }
                    sqlReader.Close();
                }
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Add_Employee_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DAL.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Add_Employee", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@in_Username", SqlDbType.VarChar).Value = DAL.OldUsername;
                    cmd.Parameters.Add("@in_ManagerUsername", SqlDbType.VarChar).Value = Employee_Manager_ComboBox.SelectedItem.ToString();
                    cmd.Parameters.Add("@in_Email", SqlDbType.VarChar).Value = Employee_Email_TextBox.Text;
                    cmd.Parameters.Add("@in_FirstName", SqlDbType.VarChar).Value = Employee_FirstName_TextBox.Text;
                    cmd.Parameters.Add("@in_MiddleName", SqlDbType.VarChar).Value = Employee_MiddleName_TextBox.Text;
                    cmd.Parameters.Add("@in_FamilyName", SqlDbType.VarChar).Value = Employee_FamilyName_TextBox.Text;
                    cmd.Parameters.Add("@in_Function", SqlDbType.VarChar).Value = Employee_Function_ComboBox.SelectedItem.ToString();
                    cmd.Parameters.Add("@in_InternalEmployee", SqlDbType.Int).Value = Convert.ToInt32(Employee_Intern_CheckBox.Checked);
                    cmd.Parameters.Add("@in_DistanceFromWork", SqlDbType.Float).Value = Math.Round(Convert.ToDouble(Employee_Distance_TextBox.Text), 1);
                    cmd.Parameters.Add("@in_ContractHours", SqlDbType.Float).Value = Math.Round(Convert.ToDouble(Employee_ContractHour_TextBox.Text), 1);
                    cmd.Parameters.Add("@in_HourlyWage", SqlDbType.Float).Value = Math.Round(Convert.ToDouble(Employee_HourWage_TextBox.Text), 2);
                    cmd.Parameters.Add("@in_IP", System.Data.SqlDbType.VarChar).Value = Program.UserIP;

                    SqlDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        MessageBox.Show(String.Format("Gebruiker aangemaakt met gebruikersnaam {0}", sqlReader[0], "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information));
                    }
                    sqlReader.Close();
                }
            }
        }

        private void Employee_Function_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
