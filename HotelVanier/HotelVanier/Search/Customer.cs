using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelVanier
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HotelVanierHomeForm().ShowDialog();
            this.Close();
        }

        private void goBackToSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchDatabase().ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new About().ShowDialog();
            this.Close();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPageForm().ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetViewButton_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.searchCustomerIDTextBox.Text))
            {
                try
                {
                    this.customerTableAdapter.FillByCustomer(this.hotelVanierDBDataSet.Customer, int.Parse(this.searchCustomerIDTextBox.Text));
                }
                catch (Exception ex)
                {

                }
            }
            this.customerTableAdapter.SearchByName(this.hotelVanierDBDataSet.Customer, searchNameTextBox.Text);

            if (!string.IsNullOrEmpty(this.searchNumOfPeopleTextBox.Text))
            {
                try
                {
                    this.customerTableAdapter.FillByNumOfPeople(this.hotelVanierDBDataSet.Customer, int.Parse(this.searchNumOfPeopleTextBox.Text));
                }
                catch (Exception ex)
                {

                }
            }
            if (!string.IsNullOrEmpty(this.ifCheck.Text))
            {
                this.customerTableAdapter.FillByCheckIn(this.hotelVanierDBDataSet.Customer, this.ifCheck.Checked);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);
        }
    }
}
