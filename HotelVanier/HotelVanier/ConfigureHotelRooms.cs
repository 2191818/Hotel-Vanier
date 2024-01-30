using HotelVanier.HotelVanierDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelVanier
{
    public partial class ConfigureHotelRooms : Form
    {
        public ConfigureHotelRooms()
        {
            InitializeComponent();
        }

        private void hotelRoomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelRoomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void ConfigureHotelRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.RoomStatusInfo' table. You can move, or remove it, as needed.
            this.roomStatusInfoTableAdapter.Fill(this.hotelVanierDBDataSet.RoomStatusInfo);
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotelVanierDBDataSet.Customer);
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotelVanierDBDataSet.Employee);
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotelVanierDBDataSet.Employee);
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.HotelRoom' table. You can move, or remove it, as needed.
            this.hotelRoomTableAdapter.Fill(this.hotelVanierDBDataSet.HotelRoom);
        }

        private void addRoomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addRoomTypeComboBox.SelectedIndex == 3)
            {
                addRoomNameTextBox.Enabled= true;
            }
            else
            {
                addRoomNameTextBox.Text = "";
                addRoomNameTextBox.Enabled= false;
            }
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.addRoomNumberTextBox.Text) || string.IsNullOrEmpty(this.addRoomFloorTextBox.Text) || string.IsNullOrEmpty(this.addRoomTypeComboBox.Text))
            {
                MessageBox.Show("One or more fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int roomNumber = 0;
            try
            {
                roomNumber = int.Parse(addRoomNumberTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Room Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int roomFloor = 0;
            try
            {
                roomFloor = int.Parse(addRoomFloorTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Floor Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string roomType = addRoomTypeComboBox.Text;
            string roomName;
            if (roomType == "Suite")
            {
                roomName = addRoomNameTextBox.Text;
            }
            else
            {
                roomName = null;
            }

            hotelRoomTableAdapter.AddHotelRoom(roomNumber, roomFloor, roomType, roomName, 999, null);
            roomStatusInfoTableAdapter.AddRoomStatusInfo(roomNumber, null, null, null, false, null, null, "clean");
            hotelRoomTableAdapter.SetRoomStatusInfoId(roomNumber);

            this.hotelRoomTableAdapter.Fill(this.hotelVanierDBDataSet.HotelRoom);

            this.Validate();
            this.hotelRoomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

            this.addRoomNumberTextBox.Text = "";
            this.addRoomFloorTextBox.Text = "";
            this.addRoomTypeComboBox.SelectedIndex = 0;
            this.addRoomNameTextBox.Text = "";

        }

        private void searchRoomsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.searchRoomNumberTextBox.Text))
            {
                try
                {
                    this.hotelRoomTableAdapter.FillBySelectByRoomNumber(this.hotelVanierDBDataSet.HotelRoom, int.Parse(this.searchRoomNumberTextBox.Text));
                }
                catch (Exception ex)
                {

                }
            }

            if (!string.IsNullOrEmpty(this.searchRoomFloorTextBox.Text))
            {
                try
                {
                    this.hotelRoomTableAdapter.FillBySelectByRoomFloor(this.hotelVanierDBDataSet.HotelRoom, int.Parse(this.searchRoomFloorTextBox.Text));
                }
                catch (Exception ex)
                {

                }
            }

            if (!string.IsNullOrEmpty(this.searchRoomTypeComboBox.Text))
            {
                this.hotelRoomTableAdapter.FillBySelectByRoomType(this.hotelVanierDBDataSet.HotelRoom, this.searchRoomTypeComboBox.Text);
            }

            if (!string.IsNullOrEmpty(this.searchRoomNameTextBox.Text))
            {
                this.hotelRoomTableAdapter.FillBySelectByRoomName(this.hotelVanierDBDataSet.HotelRoom, this.searchRoomNameTextBox.Text);
            }

        }

        private void deleteRoomsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.employeeTableAdapter.GetPassword(int.Parse(this.employeeIDTextBox.Text)).Equals(this.passwordTextBox.Text))
                {
                    foreach (DataGridViewRow selectedRow in this.hotelRoomDataGridView.SelectedRows)
                    {
                        int roomNumber = (int)selectedRow.Cells[0].Value;
                        this.hotelRoomTableAdapter.DeleteRoom(roomNumber);
                        this.roomStatusInfoTableAdapter.DeletedRoom(roomNumber);
                    }
                    this.hotelRoomTableAdapter.Fill(this.hotelVanierDBDataSet.HotelRoom);
                }
                else
                {
                    MessageBox.Show("Incorrect Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void hotelRoomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resetSearchRoomsButton_Click(object sender, EventArgs e)
        {
            this.hotelRoomTableAdapter.Fill(this.hotelVanierDBDataSet.HotelRoom);

            this.searchRoomNumberTextBox.Text = string.Empty;
            this.searchRoomFloorTextBox.Text = string.Empty;
            this.searchRoomNameTextBox.Text = string.Empty;
            this.searchRoomTypeComboBox.SelectedIndex = 0;
        }

        private void searchRoomNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            this.searchRoomFloorTextBox.Text = string.Empty;
            this.searchRoomTypeComboBox.SelectedIndex = 0;
            this.searchRoomNameTextBox.Text = string.Empty;
        }

        private void searchRoomFloorTextBox_TextChanged(object sender, EventArgs e)
        {
            this.searchRoomNumberTextBox.Text = string.Empty;
            this.searchRoomTypeComboBox.SelectedIndex = 0;
            this.searchRoomNameTextBox.Text = string.Empty;
        }

        private void searchRoomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.searchRoomNumberTextBox.Text = string.Empty;
            this.searchRoomFloorTextBox.Text = string.Empty;
            this.searchRoomNameTextBox.Text = string.Empty;
        }

        private void searchRoomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.searchRoomNumberTextBox.Text = string.Empty;
            this.searchRoomFloorTextBox.Text = string.Empty;
            this.searchRoomTypeComboBox.SelectedIndex = 0;
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
