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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new HotelVanierHomeForm().ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new About().ShowDialog();
            this.Close();
        }

        private void signoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPageForm().ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
