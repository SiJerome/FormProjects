using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace DataHelper
{
    public class DataAccess
    {
        static string myConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\Visual Studio 2019\Form_Projects\DelosSantos_Activity4\DelosSantos_Activity4\MasterFIle.mdf;Integrated Security=True";
        SqlConnection myConn = new SqlConnection(myConnStr);

        public void AddNewRecords(string custname, string custemail, DateTime custbday, string custpass)
        {
            myConn.Open();
            SqlCommand sqlcmd = new SqlCommand("AddNewRecord", myConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = custname;
            sqlcmd.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = custemail;
            sqlcmd.Parameters.Add("@CustomerBirthday", SqlDbType.Date).Value = custbday;
            sqlcmd.Parameters.Add("@CustomerPassword", SqlDbType.NVarChar).Value = custpass;
            sqlcmd.ExecuteNonQuery();
            myConn.Close();
        }
        public DataTable ViewRecords()
        {
            SqlDataAdapter da = new SqlDataAdapter("ViewRecords", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        static string userTypeAccount;

        public static string UserTypeAccount { get => userTypeAccount; set => userTypeAccount = value; }

        public bool CheckUserAcc(string username, string userpass)
        {
            bool found = false;
            myConn.Open();
            SqlCommand readcmd = new SqlCommand("CheckUser", myConn);
            readcmd.CommandType = CommandType.StoredProcedure;
            readcmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = username;
            readcmd.Parameters.Add("@userPassword", SqlDbType.NVarChar).Value = userpass;
            SqlDataReader dr;
            dr = readcmd.ExecuteReader();

            while(!found && dr.Read())
            {
                found = true;
                userTypeAccount = dr.GetString(3);
                break;
            }
            myConn.Close();
            return found;
        }
    }
}
