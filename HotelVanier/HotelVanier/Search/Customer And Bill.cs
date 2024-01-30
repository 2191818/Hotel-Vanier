using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelVanier.Search
{
    public partial class Customer_And_Bill : Form
    {
        public Customer_And_Bill()
        {
            InitializeComponent();
        }

        private void Customer_And_Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.ViewCustomerAndBill' table. You can move, or remove it, as needed.
            this.viewCustomerAndBillTableAdapter.Fill(this.hotelVanierDBDataSet.ViewCustomerAndBill);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.searchBillIdTextBox.Text))
            {
                try
                {
                    this.viewCustomerAndBillTableAdapter.FillBySearchByBillID(this.hotelVanierDBDataSet.ViewCustomerAndBill, int.Parse(this.searchBillIdTextBox.Text));
                }
                catch (Exception ex)
                {

                }
            }
            if (!string.IsNullOrEmpty(this.searchCustomerIdTextBox.Text))
            {
                try
                {
                    this.viewCustomerAndBillTableAdapter.FillBySearchByCustomerID(this.hotelVanierDBDataSet.ViewCustomerAndBill, int.Parse(this.searchCustomerIdTextBox.Text));
                }
                catch (Exception ex)
                {

                }
            }
            this.viewCustomerAndBillTableAdapter.SearchByName(this.hotelVanierDBDataSet.ViewCustomerAndBill, searchNameTextBox.Text);

            if (!string.IsNullOrEmpty(this.searchAmountTextBox.Text))
            {
                try
                {
                    this.viewCustomerAndBillTableAdapter.FillBySearchByBillAmount(this.hotelVanierDBDataSet.ViewCustomerAndBill, int.Parse(this.searchAmountTextBox.Text));
                }
                catch (Exception ex)
                {

                }
            }
            if (!string.IsNullOrEmpty(this.ifPaidCheckBox.Text))
            {
                this.viewCustomerAndBillTableAdapter.FillByPaid(this.hotelVanierDBDataSet.ViewCustomerAndBill, this.ifPaidCheckBox.Checked);
            }
        }

        private void resetViewButton_Click(object sender, EventArgs e)
        {
            this.viewCustomerAndBillTableAdapter.Fill(this.hotelVanierDBDataSet.ViewCustomerAndBill);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HotelVanierHomeForm().ShowDialog();
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
    }
}
