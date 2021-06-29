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

namespace Reservation_seat_in_cinema
{
   
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-153RETS;Initial Catalog=Movies_Reservation;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Login where username='" + txtuser.Text + "' and password='" + txtpass.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if(dt.Rows.Count>0)
            {
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    if(dt.Rows[i]["usertype"].ToString()==cmbItemValue)
                    {
                        MessageBox.Show("You are login as " + dt.Rows[i][2]);
                        if(comboBox1.SelectedIndex==0)
                        {
                            Form3 obj1 = new Form3();
                            obj1.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form2 obj2 = new Form2();
                            obj2.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
