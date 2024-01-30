using HotelVanier.HotelVanierDBDataSetTableAdapters;
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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.hotelVanierDBDataSet.Bill);
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.ViewCustomerAndBill' table. You can move, or remove it, as needed.
            this.viewCustomerAndBillTableAdapter.Fill(this.hotelVanierDBDataSet.ViewCustomerAndBill);

        }

        private void addBillButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.addBillCustomerIDTextBox.Text) || string.IsNullOrEmpty(this.addBillDescriptionComboBox.Text) || string.IsNullOrEmpty(this.addBillAmountTextBox.Text))
                {
                    MessageBox.Show("One or more fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int customerID = 0;
                try
                {
                    customerID = int.Parse(addBillCustomerIDTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string billDescription = addBillDescriptionComboBox.Text;

                decimal billAmount = 0;
                try
                {
                    billAmount = decimal.Parse(addBillAmountTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Bill Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                this.billTableAdapter.AddBill(customerID, billDescription, billAmount);

                this.viewCustomerAndBillTableAdapter.Fill(this.hotelVanierDBDataSet.ViewCustomerAndBill);

                this.Validate();
                this.billBindingSource.EndEdit();
                this.customerBindingSource.EndEdit();
                this.viewCustomerAndBillBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer doesn't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void searchBillsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.searchBillsCustomerIDTextBox.Text))
            {
                try
                {
                    this.viewCustomerAndBillTableAdapter.FillBySearchByCustomerID(this.hotelVanierDBDataSet.ViewCustomerAndBill, int.Parse(this.searchBillsCustomerIDTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(this.searchBillsCustomerFirstNameTextBox.Text))
            {
                    this.viewCustomerAndBillTableAdapter.FillBySearchByCustomerFirstName(this.hotelVanierDBDataSet.ViewCustomerAndBill, this.searchBillsCustomerFirstNameTextBox.Text);
            }

            if (!string.IsNullOrEmpty(this.searchBillsCustomerLastNameTextBox.Text))
            {
                this.viewCustomerAndBillTableAdapter.FillBySearchByCustomerLastName(this.hotelVanierDBDataSet.ViewCustomerAndBill, this.searchBillsCustomerLastNameTextBox.Text);
            }

            if (!string.IsNullOrEmpty(this.searchBillsIDTextBox.Text))
            {
                try
                {
                    this.viewCustomerAndBillTableAdapter.FillBySearchByBillID(this.hotelVanierDBDataSet.ViewCustomerAndBill, int.Parse(this.searchBillsIDTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Bill ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }

            if (!string.IsNullOrEmpty(this.searchBillsDescriptionTextBox.Text))
            {
                this.viewCustomerAndBillTableAdapter.FillBySearchByBillDescription(this.hotelVanierDBDataSet.ViewCustomerAndBill, this.searchBillsDescriptionTextBox.Text);
            }

            if (!string.IsNullOrEmpty(this.searchBillsAmountTextBox.Text))
            {
                try
                {
                    this.viewCustomerAndBillTableAdapter.FillBySearchByBillAmount(this.hotelVanierDBDataSet.ViewCustomerAndBill, decimal.Parse(this.searchBillsAmountTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Bill Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }

        }

        private void searchBillsCustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.searchBillsCustomerFirstNameTextBox.Text = "";
            this.searchBillsCustomerLastNameTextBox.Text = "";
            this.searchBillsIDTextBox.Text = "";
            this.searchBillsDescriptionTextBox.Text = "";
            this.searchBillsAmountTextBox.Text = "";
        }

        private void searchBillsCustomerFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.searchBillsCustomerIDTextBox.Text = "";
            this.searchBillsCustomerLastNameTextBox.Text = "";
            this.searchBillsIDTextBox.Text = "";
            this.searchBillsDescriptionTextBox.Text = "";
            this.searchBillsAmountTextBox.Text = "";
        }

        private void searchBillsCustomerLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.searchBillsCustomerIDTextBox.Text = "";
            this.searchBillsCustomerFirstNameTextBox.Text = "";
            this.searchBillsIDTextBox.Text = "";
            this.searchBillsDescriptionTextBox.Text = "";
            this.searchBillsAmountTextBox.Text = "";
        }

        private void searchBillsIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.searchBillsCustomerIDTextBox.Text = "";
            this.searchBillsCustomerFirstNameTextBox.Text = "";
            this.searchBillsCustomerLastNameTextBox.Text = "";
            this.searchBillsDescriptionTextBox.Text = "";
            this.searchBillsAmountTextBox.Text = "";
        }

        private void searchBillsDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            this.searchBillsCustomerIDTextBox.Text = "";
            this.searchBillsCustomerFirstNameTextBox.Text = "";
            this.searchBillsCustomerLastNameTextBox.Text = "";
            this.searchBillsIDTextBox.Text = "";
            this.searchBillsAmountTextBox.Text = "";
        }

        private void searchBillsAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            this.searchBillsCustomerIDTextBox.Text = "";
            this.searchBillsCustomerFirstNameTextBox.Text = "";
            this.searchBillsCustomerLastNameTextBox.Text = "";
            this.searchBillsIDTextBox.Text = "";
            this.searchBillsDescriptionTextBox.Text = "";
        }

        private void deleteBillsButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in this.viewCustomerAndBillDataGridView.SelectedRows)
            {
                try
                {
                    int billID = (int)selectedRow.Cells[0].Value;
                    this.billTableAdapter.DeleteBill(billID);
                }
                catch (Exception ex)
                {

                }
            }
            this.viewCustomerAndBillTableAdapter.Fill(this.hotelVanierDBDataSet.ViewCustomerAndBill);
        }

        private void payBillsButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in this.viewCustomerAndBillDataGridView.SelectedRows)
            {
                int billID = (int)selectedRow.Cells[0].Value;
                this.billTableAdapter.PayBill(billID);
            }
            this.viewCustomerAndBillTableAdapter.Fill(this.hotelVanierDBDataSet.ViewCustomerAndBill);
        }

        private void resetSeachBillsButton_Click(object sender, EventArgs e)
        {
            this.viewCustomerAndBillTableAdapter.Fill(this.hotelVanierDBDataSet.ViewCustomerAndBill);

            this.searchBillsCustomerIDTextBox.Text = "";
            this.searchBillsCustomerFirstNameTextBox.Text = "";
            this.searchBillsCustomerLastNameTextBox.Text = "";
            this.searchBillsIDTextBox.Text = "";
            this.searchBillsDescriptionTextBox.Text = "";
            this.searchBillsAmountTextBox.Text = "";
        }

        private void viewCustomerAndBillDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow selectedRow in this.viewCustomerAndBillDataGridView.SelectedRows)
            {
                try
                {
                    totalAmount += (decimal)selectedRow.Cells[5].Value;
                }
                catch (Exception ex)
                {

                }
            }
            this.totalAmountSelectedTextBox.Text = "$" + totalAmount.ToString();
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
