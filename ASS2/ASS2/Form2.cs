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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void SearchCustom_Click(object sender, EventArgs e)
        {
            string oradb = "DATA SOURCE=DESKTOP-V7B2IBB:1521/xe;PERSIST SECURITY INFO=True;USER ID=THANH01;PASSWORD=03022000";
            OracleConnection con = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            con.Open();
            param.OracleDbType = OracleDbType.Varchar2;
            param.Value = CusCodeTextBox.Text;
            cmd.Connection = con;
            cmd.Parameters.Add(param);
            cmd.CommandText = "Select * from customer where cuscode = :1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
    
            if (reader.HasRows)
            {
                reader.Read();
                FirstName.Text = reader["CFNAME"].ToString();
                LastName.Text = reader["CLNAME"].ToString();

                cmd.CommandText = "Select * from cus_phone where cuscode = :1";
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                string a = "";
                while (reader.Read())
                {
                    a = a + reader["CUSPHONE"].ToString() + '\n';
                }
                CusPhone.Text = a;

                cmd.CommandText = "Select * from tk where cuscode = :1";
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                string b = "";
                while (reader.Read())
                {
                    b = b + reader["ANUMBER"].ToString() + '\n';
                }
                listAcc.Text = b;



            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Customer Code doesn't exist", "Notify");
            }
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SearchAcc_Click(object sender, EventArgs e)
        {
            string oradb = "DATA SOURCE=DESKTOP-V7B2IBB:1521/xe;PERSIST SECURITY INFO=True;USER ID=THANH01;PASSWORD=03022000";
            OracleConnection con = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            con.Open();
            param.OracleDbType = OracleDbType.Varchar2;
            param.Value = Account_code.Text;
            cmd.Connection = con;
            cmd.Parameters.Add(param);
            cmd.CommandText = "Select * from tk d, savingacc s where d.anumber = :1 and d.acccode = s.acccode";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            bool check = false;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                TypeAcc.Text = "Saving Account";
                Sdate.Text = reader["SDATE"].ToString();
                Balance.Text = reader["SBALANCE"].ToString();
                Rate.Text = reader["SINSRATE"].ToString();
                check = true;
            }


            cmd.CommandText = "Select * from tk d, checkingacc c where d.anumber = :1 and d.acccode = c.acccode";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                TypeAcc.Text = "Checking Account";
                Sdate.Text = reader["CDATE"].ToString();
                Balance.Text = reader["CBALANCE"].ToString();
                check = true;
            }

            cmd.CommandText = "Select * from tk d, loan l where d.anumber = :1 and d.acccode = l.acccode";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                TypeAcc.Text = "Loan";
                Sdate.Text = reader["LDATE"].ToString();
                Balance.Text = reader["LBALANCE"].ToString();
                Rate.Text = reader["LINSRATE"].ToString();
                check = true;
            }
            if (check == false)
            {
                DialogResult d;
                d = MessageBox.Show("Account Code doesn't exist", "Notify");
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 function = new Form1();
            this.Hide();
            function.Show();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Form3 function = new Form3();
            this.Hide();
            function.Show();
        }

        private void Report_Service_Click(object sender, EventArgs e)
        {
            Form4 function = new Form4();
            this.Hide();
            function.Show();
        }
    }
}
