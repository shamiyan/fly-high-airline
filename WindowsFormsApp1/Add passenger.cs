using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Add_passenger : Form
    {
        public Add_passenger()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\aliza\OneDrive\Documents\fly high airline.mdf';Integrated Security=True;Connect Timeout=30");
        private void button2_Click(object sender, EventArgs e)
        {
            if(PassengerID.Text == "" || Passengeraddress.Text == "" || PassengerName.Text == "" || PassportTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into PassengerTbl values(" + PassengerID.Text + ",'" + PassengerName.Text + "','" + PassportTb.Text + "','" + Passengeraddress.Text + "','" + nationalityCb.SelectedItem.ToString() + "','" + genderCb.SelectedItem.ToString() + "','" + PhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    con.Close();
                }catch(Exception Ex)
                {
                    con.Close();
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Add_passenger_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PassengerID.Text = "";
            PassengerName.Text = "";
            PassportTb.Text = "";
            Passengeraddress.Text = "";
            nationalityCb.Text = "";
            genderCb.Text = "";
            PhoneTb.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_passenger viewpas = new View_passenger();
            viewpas.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
