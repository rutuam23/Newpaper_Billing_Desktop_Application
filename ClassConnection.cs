using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NewspaperBillingApp
{
    class ClassConnection
    {

        public static string CompanyID = "";
        public static string CustID = "";
        public static DateTime DateEvenOdd = new DateTime();

        //Server connection
        //OleDbConnection con = new OleDbConnection("PROVIDER=SQLOLEDB.1;Network Library=DBMSSOCN;Data Source=148.72.232.166;Initial Catalog=DesktopMilkDB;Trusted_Connection=False;UID=DesktopMilkDB;PWD=Y50g@7em");       
        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataAdapter adp = new OleDbDataAdapter();
        //DataSet ds = new DataSet();

        //Local connection
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HG2U0S4\\SQLEXPRESS;Initial Catalog=NewspaperDB;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet ds = new DataSet();

        //method To insert,update,delete
        public void execute(string str)
    {
        cmd = new SqlCommand(str, con);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd.ExecuteNonQuery();
        con.Close();
    }

     //method To select
    int cnt;
    public int executescal(string str)
    {
        cmd = new SqlCommand(str, con);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cnt = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        return cnt;
    }
    //method To fill ds
    public DataSet fillDs(string sql)
    {
        ds = new DataSet();
        adp = new SqlDataAdapter(sql, con);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        adp.Fill(ds);
        con.Close();
        return ds;
    }
}
}