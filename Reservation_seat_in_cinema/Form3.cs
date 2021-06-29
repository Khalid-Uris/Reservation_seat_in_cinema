using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_seat_in_cinema
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void addCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Cashier obj = new Add_Cashier();
            obj.Show();
            this.Hide();
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movies obj = new Movies();
            obj.Show();
            this.Hide();
        }
    }
}
