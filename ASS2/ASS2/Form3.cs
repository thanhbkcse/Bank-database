using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace ASS2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string oradb = "DATA SOURCE=DESKTOP-V7B2IBB:1521/xe;PERSIST SECURITY INFO=True;USER ID=THANH01;PASSWORD=03022000";
            OracleConnection con = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
          
            con.Open();
            
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO AccType VALUES('"+Acccode1.Text+"')";
            try
            {

                int a = cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO TK VALUES ('" + Anumber.Text + "','" + CusCode.Text + "','" + Acccode1.Text + "')";
                int b = cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
            }
            catch
            {
                MessageBox.Show("Error encountered during INSERT operation.");
            }

            //cmd.CommandText = "INSERT INTO TK VALUES ('"+Anumber.Text + "," +CusCode.Text + "," + Acccode1.Text + "')";
            //try
            //{

            //    int b = cmd.ExecuteNonQuery();
            //    MessageBox.Show("Success!");
            //}
            //catch
            //{
            //    MessageBox.Show("Error encountered during INSERT operation.");
            //}
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 function = new Form2();
            this.Hide();
            function.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "DATA SOURCE=DESKTOP-V7B2IBB:1521/xe;PERSIST SECURITY INFO=True;USER ID=THANH01;PASSWORD=03022000";
            OracleConnection con = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();

            con.Open();

            cmd.Connection = con;
            if (Saving.Checked == true)
            {
                try
                {
                    cmd.CommandText = "ALTER SESSION SET NLS_DATE_FORMAT = 'DD-MM-YYYY'";
                    int d = cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO SavingAcc VALUES('" + AccountCode2.Text + "','" + Date.Text + "','" + Balance.Text + "','" + Rate.Text + "')";
                    int c = cmd.ExecuteNonQuery();
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Error encountered during INSERT operation.");
                }
            }
            else if (Checking.Checked == true)
            {
                try
                {
                    cmd.CommandText = "ALTER SESSION SET NLS_DATE_FORMAT = 'DD-MM-YYYY'";
                    int d = cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO CheckingAcc VALUES('" + AccountCode2.Text + "','" + Balance.Text + "','" + Date.Text + "')";
                    int c = cmd.ExecuteNonQuery();
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Error encountered during INSERT operation.");
                }
            }
            else if (Loan.Checked == true)
            {
               
                try
                {
                    cmd.CommandText = "ALTER SESSION SET NLS_DATE_FORMAT = 'DD-MM-YYYY'";
                    int d = cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO Loan VALUES('" + AccountCode2.Text + "','" + Rate.Text + "','" + Balance.Text + "','" + Date.Text + "')";
                    int c = cmd.ExecuteNonQuery();
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Error encountered during INSERT operation.");
                }
            }
            else
            {
                MessageBox.Show("Please Choose Type Account");
            }

           
        }
    }
}
