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
    public partial class Hotel_Rooms : Form
    {
        public Hotel_Rooms()
        {
            InitializeComponent();
        }

        private void hotelRoomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelRoomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void Hotel_Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.HotelRoom' table. You can move, or remove it, as needed.
            this.hotelRoomTableAdapter.Fill(this.hotelVanierDBDataSet.HotelRoom);

        }

        private void searchButton_Click(object sender, EventArgs e)
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

            if (!string.IsNullOrEmpty(this.searchNameTextBox.Text))
            {
                this.hotelRoomTableAdapter.FillBySelectByRoomName(this.hotelVanierDBDataSet.HotelRoom, this.searchNameTextBox.Text);
            }
        }

        private void resetViewButton_Click(object sender, EventArgs e)
        {
            this.hotelRoomTableAdapter.Fill(this.hotelVanierDBDataSet.HotelRoom);
        }
    }
}
