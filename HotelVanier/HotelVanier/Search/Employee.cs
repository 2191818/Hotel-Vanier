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

namespace HotelVanier.Search
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelVanierDBDataSet);

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelVanierDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotelVanierDBDataSet.Employee);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SearchByName(this.hotelVanierDBDataSet.Employee, searchNameTextBox.Text);

            if (!string.IsNullOrEmpty(this.searchEmployeeIDTextBox.Text))
            {
                try
                {
                    this.employeeTableAdapter.FillByEmpId(this.hotelVanierDBDataSet.Employee, int.Parse(this.searchEmployeeIDTextBox.Text));
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void resetViewButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.hotelVanierDBDataSet.Employee);
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
            new HotelVanierHomeForm().ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HotelVanierHomeForm().ShowDialog();
            this.Close();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HotelVanierHomeForm().ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
