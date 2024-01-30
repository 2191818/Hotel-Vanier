using HotelVanier.Search;
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
    public partial class SearchDatabase : Form
    {
        public SearchDatabase()
        {
            InitializeComponent();
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

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer().ShowDialog();
            this.Close();
        }

        private void hotelRoomButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Hotel_Rooms().ShowDialog();
            this.Close();
        }

        private void roomStatusButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Room_Status().ShowDialog();
            this.Close();
        }

        private void bilButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Bill().ShowDialog();
            this.Close();
        }

        private void customerAndBillButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer_And_Bill().ShowDialog();
            this.Close();
        }

        private void emplyeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employee().ShowDialog();
            this.Close();
        }
    }
}