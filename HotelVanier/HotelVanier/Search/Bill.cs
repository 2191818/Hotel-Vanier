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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void goBackToSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new SearchDatabase().ShowDialog();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new HotelVanierHomeForm().ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new SearchDatabase().ShowDialog();
            this.Close();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new SearchDatabase().ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void billBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.hotelVanierDBDataSet.Bill);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.searchBillIDTextBox.Text))
            {
                try
                {
                    this.billTableAdapter.FillByBillId(this.hotelVanierDBDataSet.Bill, int.Parse(this.searchBillIDTextBox.Text));
                }
                catch (Exception ex)
                {

                }
            }
            if (!string.IsNullOrEmpty(this.searchAmountTextBox.Text))
            {
                try
                {
                    this.billTableAdapter.FillByAmount(this.hotelVanierDBDataSet.Bill, int.Parse(this.searchAmountTextBox.Text));
                }
                catch (Exception ex)
                {

                }
            }
            if (!string.IsNullOrEmpty(this.ifPaidCheckBox.Text))
            {
                this.billTableAdapter.FillByPaid(this.hotelVanierDBDataSet.Bill, this.ifPaidCheckBox.Checked);
            }
            if (!string.IsNullOrEmpty(this.searchCustomerIDTextBox.Text))
            {
                try
                {
                    this.billTableAdapter.FillByCustomerId(this.hotelVanierDBDataSet.Bill, int.Parse(this.searchCustomerIDTextBox.Text));
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void resetViewButton_Click(object sender, EventArgs e)
        {
            this.billTableAdapter.Fill(this.hotelVanierDBDataSet.Bill);

        }
    }
}
