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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "DATA SOURCE=DESKTOP-V7B2IBB:1521/xe;PERSIST SECURITY INFO=True;USER ID=THANH01;PASSWORD=03022000";
            OracleConnection con = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            con.Open();
            param.OracleDbType = OracleDbType.Varchar2;
            param.Value = textBoxUsername.Text;
            cmd.Connection = con;
            cmd.Parameters.Add(param);
            cmd.CommandText = "Select passwords from admin where username = :1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (String.Equals(textBox2.Text, reader.GetString(0)))
                {
                    DialogResult d;
                    d = MessageBox.Show("Login Successfully", "Notify");
                    Form2 function = new Form2();
                    this.Hide();
                    function.Show();
                }
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("Wrong password", "Notify");
                }
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Admin doesn't exist", "Notify");
            }
            //con.Dispose();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
