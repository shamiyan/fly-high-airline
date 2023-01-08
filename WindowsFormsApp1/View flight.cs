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
    public partial class View_flight : Form
    {
        public View_flight()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\aliza\OneDrive\Documents\fly high airline.mdf';Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void View_flight_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightTbl Addfl = new FlightTbl();
            Addfl.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            Seatnum.Text = "";
        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FcodeTb.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
            SrcCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
            DstCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
            Seatnum.Text = FlightDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(FcodeTb.Text == "")
            {
                MessageBox.Show("Enter The Flight To Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    String query = "delete from FlightTbl where Fcode='"+FcodeTb.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfuly");
                    con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(FcodeTb.Text == "" || Seatnum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update FlightTbl set Fsrc='" + SrcCb.SelectedItem.ToString() + "',FDest='" + DstCb.SelectedItem.ToString() + "',FDate='" + FDate.Value.Date.ToString() + "',FCap=" + Seatnum.Text + " where Fcode='" + FcodeTb.Text + "';";
                    SqlCommand Cmd = new SqlCommand(query, con);
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Updated Successfully");
                    con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }
    }
}
