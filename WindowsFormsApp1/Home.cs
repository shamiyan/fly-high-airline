using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket tic = new Ticket();
            tic.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FlightTbl fl = new FlightTbl();
            fl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_passenger addpas = new Add_passenger();
            addpas.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cancellation canc = new cancellation();
            canc.Show();
            this.Hide();
        }
    }
}
