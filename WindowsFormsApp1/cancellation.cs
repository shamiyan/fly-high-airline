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
    public partial class cancellation : Form
    {
        public cancellation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\aliza\OneDrive\Documents\fly high airline.mdf';Integrated Security=True;Connect Timeout=30");
        private void fillTicketId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TId from TicketTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TId", typeof(string));
            dt.Load(rdr);
            TidCb.ValueMember = "TId";
            TidCb.DataSource = dt;
            con.Close();
        }
        private void fetchfcode()
        {
            con.Open();
            string query = "select * from TicketTbl where TId=" + TidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query,con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FcodeTb.Text = dr["Fcode"].ToString();
                
            }
            con.Close();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CancelDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancellation_Load(object sender, EventArgs e)
        {
            fillTicketId();
            populate();
        }

        private void TidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchfcode();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CanId.Text = "";
            FcodeTb.Text = "";
        }
        private void deleteTicket()
        {
           
                try
                {
                    con.Open();
                    String query = "delete from TicketTbl where TId=" + TidCb.SelectedValue.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("TIcket deleted Successfuly");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (CanId.Text == "" || FcodeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into CancelTbl values(" + CanId.Text + "," + TidCb.SelectedValue.ToString() + ",'" + FcodeTb.Text+ "','" + CancDate.Value.Date + "')" ;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancel Successfully");
                    con.Close();
                    populate();
                    deleteTicket();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
