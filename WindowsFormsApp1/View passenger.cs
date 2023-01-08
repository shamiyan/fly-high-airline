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
    public partial class View_passenger : Form
    {
        public View_passenger()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\aliza\OneDrive\Documents\fly high airline.mdf';Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(PidTb.Text == "" || Pname.Text == "" || PpassTb.Text == "" || PaddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update PassengerTbl set PassName='"+Pname.Text+"',Passport='"+PpassTb.Text+"',PassAd='"+PaddTb.Text+"',PassNat='"+natCb.SelectedItem.ToString()+"',PassGend='"+GendCb.SelectedItem.ToString()+"',PassPhone='"+PphoneTb.Text+"'where Id="+PidTb.Text+"";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfull");
                    con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }

        private void View_passenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_passenger addpas = new Add_passenger();
            addpas.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(PidTb.Text == "")
            {
                MessageBox.Show("Enter The Passenger To Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from PassengerTbl where Id="+PidTb.Text+";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PidTb.Text = "";
            Pname.Text = "";
            PaddTb.Text = "";
            PpassTb.Text = "";
            natCb.SelectedItem = "";
            GendCb.SelectedItem = "";
            PphoneTb.Text = "";
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PidTb.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
            Pname.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PpassTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PaddTb.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
            natCb.SelectedItem = PassengerDGV.SelectedRows[4].Cells[0].Value.ToString();
            GendCb.SelectedItem = PassengerDGV.SelectedRows[5].Cells[0].Value.ToString();
        }
    }
}
