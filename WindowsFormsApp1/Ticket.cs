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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\aliza\OneDrive\Documents\fly high airline.mdf';Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void fillPassenger()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id from PassengerTbl",con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Load(rdr);
            PassengerIDCb.ValueMember = "Id";
            PassengerIDCb.DataSource = dt;
            con.Close();
        }
        private void fillFlightCode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl",con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FCodeCb.ValueMember = "Fcode";
            FCodeCb.DataSource = dt;
            con.Close();
        }
        string pname, ppass, pnat;

        private void PassengerIDCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PassengerIDCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpassenger();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Tid.Text == "" || PNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into TicketTbl values("+Tid.Text+",'"+FCodeCb.SelectedValue.ToString()+"',"+PassengerIDCb.SelectedValue.ToString()+",'"+PNameTb.Text+"','"+PPassTb.Text+"','"+PNatTb.Text+"',"+PAmtTb.Text+")";
                    SqlCommand cmd =  new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
                    con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PNameTb.Text = "";
            PPassTb.Text = "";
            PNatTb.Text = "";
            PAmtTb.Text = "";
            Tid.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void fetchpassenger()
        {
            con.Open();
            string query  = "select * from PassengerTbl where Id="+PassengerIDCb.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                pname = dr["PassName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassNat"].ToString();
                PNameTb.Text = pname;
                PPassTb.Text = ppass;
                PNatTb.Text = pnat;
            }
            con.Close();
        }
        private void Ticket_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillFlightCode();
            populate();
        }
    }
}
