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
    public partial class Room_Status : Form
    {
        public Room_Status()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomStatusInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomStatusInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void Room_Status_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.RoomStatusInfo' table. You can move, or remove it, as needed.
            this.roomStatusInfoTableAdapter.Fill(this.hotelVanierDBDataSet.RoomStatusInfo);

        }
    }
}
