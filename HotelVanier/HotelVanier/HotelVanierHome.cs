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
    public partial class HotelVanierHomeForm : Form
    {
        public HotelVanierHomeForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new About().ShowDialog();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void roomStatusInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomStatusInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void HotelVanierHomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.RoomStatusInfo' table. You can move, or remove it, as needed.
            this.roomStatusInfoTableAdapter.Fill(this.hotelVanierDBDataSet.RoomStatusInfo);

        }

        private void roomStatusInfoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.roomStatusInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void roomStatusInfoBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.roomStatusInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void roomStatusInfoBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.roomStatusInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CheckInForm().ShowDialog();
            this.Close();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPageForm().ShowDialog();
            this.Close();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new HotelVanierHomeForm().ShowDialog();
            this.Close();
        }

        private void hotelRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConfigureHotelRooms().ShowDialog();
            this.Close();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Billing().ShowDialog();
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchDatabase().ShowDialog();
            this.Close();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow selectedRow in this.roomStatusInfoDataGridView.SelectedRows)
            {
                try
                {
                    int customerId = (int)selectedRow.Cells[2].Value;
                    this.roomStatusInfoTableAdapter.CheckoutOrDeletedCustomer(customerId);
                    this.customerTableAdapter.CheckoutCustomer(customerId);
                }
                catch (Exception ex)
                {

                }
            }
            this.roomStatusInfoTableAdapter.Fill(this.hotelVanierDBDataSet.RoomStatusInfo);
        }
    }
}
