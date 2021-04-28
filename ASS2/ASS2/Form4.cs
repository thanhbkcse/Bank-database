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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            string oradb = "DATA SOURCE=DESKTOP-V7B2IBB:1521/xe;PERSIST SECURITY INFO=True;USER ID=THANH01;PASSWORD=03022000";
            OracleConnection con = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select E.EMPCODE,E.EFNAME, e.elname, C.CFNAME, c.CLNAME, S.SDATE FROM CUSTOMER C,EMPLOYEE E, SAVINGACC S, TK T WHERE C.EMPCODE = E.EMPCODE AND T.CUSCODE = C.CUSCODE AND T.ACCCODE = S.ACCCODE";
            //OracleDataAdapter da = new OracleDataAdapter(cmd);
            //OracleCommandBuilder cb = new OracleCommandBuilder(da);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            Saving_Acc.DataSource = dataTable;

            cmd.CommandText = "select E.EMPCODE,E.EFNAME,e.elname,C.CFNAME,c.CLNAME,H.CDATE FROM CUSTOMER C,EMPLOYEE E, CHECKINGACC H, TK T WHERE C.EMPCODE = E.EMPCODE AND T.CUSCODE = C.CUSCODE AND T.ACCCODE = H.ACCCODE";
            reader = cmd.ExecuteReader();
            DataTable dataTable1 = new DataTable();
            dataTable1.Load(reader);
            Checking_Acc.DataSource = dataTable1;

            cmd.CommandText = "select E.EMPCODE,E.EFNAME,e.elname,C.CFNAME,c.CLNAME,L.LDATE FROM CUSTOMER C,EMPLOYEE E, LOAN L, TK T WHERE C.EMPCODE = E.EMPCODE AND T.CUSCODE = C.CUSCODE AND T.ACCCODE = L.ACCCODE ";
            reader = cmd.ExecuteReader();
            DataTable dataTable2 = new DataTable();
            dataTable2.Load(reader);
            Loan.DataSource = dataTable2;
        }

        private void Checking_Acc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
