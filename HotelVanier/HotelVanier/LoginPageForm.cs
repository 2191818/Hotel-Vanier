using HotelVanier.HotelVanierDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelVanier
{
    public partial class LoginPageForm : Form
    {
        public LoginPageForm()
        {
            InitializeComponent();

            ErrorLabel.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            HotelVanierDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter = new HotelVanierDBDataSetTableAdapters.EmployeeTableAdapter();
            HotelVanierDBDataSet.EmployeeDataTable Employee = employeeTableAdapter.GetData();

            try
            {
                string correctPassword = (string)employeeTableAdapter.GetPassword(int.Parse(EmployeeIDTextBox.Text));

                if (correctPassword == null)
                {
                    throw new Exception();
                }

                if (PasswordTextBox.Text.Equals(correctPassword))
                {
                    this.Hide();
                    new HotelVanierHomeForm().ShowDialog();
                    this.Close();
                }
                else
                {
                    ErrorLabel.Text = "Incorrect Password";
                }
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = "Incorrect Employee Id";
            }
        }

        public void PressedEnterOnTextBox(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(this, new EventArgs());
            }
        }

        private void radioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {

            var changeLanguage = new ChangeLanguage();

            changeLanguage.UpdateConfig("language", "en");
        }

        private void radioButtonFrench_CheckedChanged(object sender, EventArgs e)
        {

            var changeLanguage = new ChangeLanguage();

            changeLanguage.UpdateConfig("language", "fr-CA");
            Application.Restart();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();

            switch (languageComboBox.SelectedIndex)
            {
                case 0: changeLanguage.UpdateConfig("language", "en");
                    Application.Restart();
                    break;
                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
            }
        }
    }
}
