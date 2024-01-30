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
    public partial class CheckInForm : Form
    {
        public CheckInForm()
        {
            InitializeComponent();
        }

        private void hotelRoomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelRoomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.RoomStatusInfo' table. You can move, or remove it, as needed.
            this.roomStatusInfoTableAdapter.Fill(this.hotelVanierDBDataSet.RoomStatusInfo);
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.HotelRoom' table. You can move, or remove it, as needed.
            this.hotelRoomTableAdapter.Fill(this.hotelVanierDBDataSet.HotelRoom);

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
        private void checkInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.customerIdTextBox.Text) || string.IsNullOrEmpty(this.roomNumberTextBox.Text))
                {
                    MessageBox.Show("One or more fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int customerID = 0;
                try
                {
                    customerID = int.Parse(this.customerIdTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var customerName = this.customerTableAdapter.GetCustomer(customerID);

                string customerFirstName = customerName.Rows[0][1].ToString();
                string customerLastName = customerName.Rows[0][2].ToString();

                int roomNumber = 0;
                try
                {
                    roomNumber = int.Parse(this.roomNumberTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Room Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime occupiedFrom = this.stayingFromDateTimePicker.Value;
                DateTime occupiedTo = this.stayingToDateTimePicker.Value;

                try
                {
                    var hotelRoom = this.hotelRoomTableAdapter.GetRoomByRoomNumber(roomNumber).Rows[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Room doesn't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.customerTableAdapter.CheckinCustomer(customerID);
                this.roomStatusInfoTableAdapter.CheckedinCustomer(customerID, customerFirstName, customerLastName, occupiedFrom, occupiedTo, roomNumber);

                this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);
                this.roomStatusInfoTableAdapter.Fill(this.hotelVanierDBDataSet.RoomStatusInfo);

                this.Validate();
                this.customerBindingSource.EndEdit();
                this.roomStatusInfoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

                this.customerIdTextBox.Text = "";
                this.roomNumberTextBox.Text = "";
                this.stayingFromDateTimePicker.Value = DateTime.Now;
                this.stayingToDateTimePicker.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer doesn't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HotelVanierHomeForm().ShowDialog();
            this.Close();
        }

        private void roomNumberSearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.searchRoomNumberTextBox.Text))
            {
                try
                {
                    this.hotelRoomTableAdapter.FillBySelectByRoomNumber(this.hotelVanierDBDataSet.HotelRoom, int.Parse(this.searchRoomNumberTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Room Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nameSearchButton_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.SearchByName(this.hotelVanierDBDataSet.Customer, searchNameTextBox.Text);
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);
            this.hotelRoomTableAdapter.Fill(this.hotelVanierDBDataSet.HotelRoom);

            this.searchNameTextBox.Text = "";
            this.searchRoomNumberTextBox.Text = "";
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.firstNameTextBox.Text) || string.IsNullOrEmpty(this.lastNameTextBox.Text) || string.IsNullOrEmpty(this.numberOfPeopleTextBox.Text))
            {
                MessageBox.Show("One or more fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = firstNameTextBox.Text;

            string lastName = lastNameTextBox.Text;

            int numOfPeople = 0;
            try
            {
                numOfPeople = int.Parse(numberOfPeopleTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Number of People.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            customerTableAdapter.AddCustomer(firstName, lastName, numOfPeople);

            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);

            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.numberOfPeopleTextBox.Text = "";
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in this.customerDataGridView.SelectedRows)
            {
                try
                {
                    int customerID = (int)selectedRow.Cells[0].Value;
                    this.roomStatusInfoTableAdapter.CheckoutOrDeletedCustomer(customerID);
                    this.customerTableAdapter.DeleteCustomer(customerID);
                }
                catch (Exception ex)
                {

                }
                
            }
            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);
        }
    }
}
