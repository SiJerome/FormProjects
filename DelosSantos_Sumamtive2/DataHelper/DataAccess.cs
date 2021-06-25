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
        static string myConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\Visual Studio 2019\Form_Projects\DelosSantos_Sumamtive2\DelosSantos_Sumamtive2\Masterfile.mdf;Integrated Security=True";
        SqlConnection myConn = new SqlConnection(myConnStr);


        public int Randomvalue()
        {
            Random randomNumber = new Random();
            int num = randomNumber.Next(1000000,9999999);
            return num;
        }
        //Goodluck sa pag iintindi neto kasi di ko din naiintindihan//
        static string accnumber1, acctype1, initialdeposit1; // act as session variable
        string initialdeposit2; // value storage variable
        double fromtransfer; // value storage variable
        double deposit, withdraw, transfer; // value storage variable

        double dep, with, trans; // value storage variable

        //add acc 
        public void AddRecords(string fname, string lname, string emailadd, string pass, string accnumber, string acctype, string initialdeposit)
        {
            myConn.Open();
            SqlCommand savecmd = new SqlCommand("AddAccount", myConn);
            savecmd.CommandType = CommandType.StoredProcedure;
            savecmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fname;
            savecmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lname;
            savecmd.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = emailadd;
            savecmd.Parameters.Add("@AccPassword", SqlDbType.NVarChar).Value = pass;
            savecmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = accnumber;
            savecmd.Parameters.Add("@AccountType", SqlDbType.NVarChar).Value = acctype;
            savecmd.Parameters.Add("@InitialDeposit", SqlDbType.NVarChar).Value = initialdeposit;
            savecmd.ExecuteNonQuery();
            myConn.Close();
    
        }
        //add transaction record
        public void AddRTransactionRecord(string transtype, string amount, DateTime dateTime , string fromoacc, string toacc)
        {
            myConn.Open();
            SqlCommand insertcmd = new SqlCommand("AddTransactionHistory", myConn);
            insertcmd.CommandType = CommandType.StoredProcedure;
            insertcmd.Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = transtype;
            insertcmd.Parameters.Add("@Amount", SqlDbType.NVarChar).Value = amount;
            insertcmd.Parameters.Add("@DateAndTimeOfTransactions", SqlDbType.NVarChar).Value = dateTime;
            insertcmd.Parameters.Add("@FromAccount", SqlDbType.NVarChar).Value = fromoacc;
            insertcmd.Parameters.Add("@ToAccount", SqlDbType.NVarChar).Value = toacc;
            insertcmd.ExecuteNonQuery();
            myConn.Close();

        }
        public static string Accnumber1 { get => accnumber1; set => accnumber1 = value; }
        public static string Acctype1 { get => acctype1; set => acctype1 = value; }
        public static string Initialdeposit1 { get => initialdeposit1; set => initialdeposit1 = value; }
        public double Fromtransfer { get => fromtransfer; set => fromtransfer = value; }
        public double Deposit { get => deposit; set => deposit = value; }
        public double Withdraw { get => withdraw; set => withdraw = value; }
        public double Transfer { get => transfer; set => transfer = value; }
        public double Dep { get => dep; set => dep = value; }
        public double With { get => with; set => with = value; }
        public double Trans { get => trans; set => trans = value; }

        //check login acc
        public bool CheckAcc(string accnumber, string pass)
        {
            bool found = false;
            myConn.Open();
            SqlCommand readcmd = new SqlCommand("CheckAccUser", myConn);
            readcmd.CommandType = CommandType.StoredProcedure;
            readcmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = accnumber;
            readcmd.Parameters.Add("@AccPassWord", SqlDbType.NVarChar).Value = pass;
            SqlDataReader dr;
            dr = readcmd.ExecuteReader();

            while(!found && dr.Read())
            {
                found = true;
                accnumber1 = dr.GetString(5);
                acctype1 = dr.GetString(6);
                initialdeposit1 = dr.GetString(7);
                break;
            }
            myConn.Close();
            return found;
        }
        //compute deposit (maybe buggy need more fix)
        public void ComputeDeposit(string accnum, string depamount)
        {
            dep = Deposit = Convert.ToDouble(initialdeposit1) + Convert.ToDouble(depamount);

            myConn.Open();
            SqlCommand editcmd = new SqlCommand("UpdateDeposit", myConn);
            editcmd.CommandType = CommandType.StoredProcedure;
            editcmd.Parameters.Add("@InitialDeposit", SqlDbType.NVarChar).Value = Deposit;
            editcmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = accnumber1;
            editcmd.ExecuteNonQuery();
            myConn.Close();

        }
        //compute withdraw (maybe buggy need more fix)
        public void ComputeWithdraw(string accnum, string withamount)
        {

            with = Withdraw = Convert.ToDouble(initialdeposit1) - Convert.ToDouble(withamount);   

            myConn.Open();
            SqlCommand editcmd = new SqlCommand("UpdateDeposit", myConn);
            editcmd.CommandType = CommandType.StoredProcedure;
            editcmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = accnum;
            editcmd.Parameters.Add("@InitialDeposit", SqlDbType.NVarChar).Value = Withdraw;  
            editcmd.ExecuteNonQuery();
            myConn.Close();
        }
        //compute transfer (maybe buggy need more fix)
        public void ComputeTransfer1(string accnum, string transamount)
        {
            trans = Fromtransfer = Convert.ToDouble(initialdeposit1) - Convert.ToDouble(transamount);
            myConn.Open();
            SqlCommand editcmd = new SqlCommand("UpdateDeposit", myConn);
            editcmd.CommandType = CommandType.StoredProcedure;
            editcmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = accnum;
            editcmd.Parameters.Add("@InitialDeposit", SqlDbType.NVarChar).Value = Fromtransfer;
            editcmd.ExecuteNonQuery();
            myConn.Close();
        }
        //compute transfer2 (maybe buggy need more fix)
        public void ComputeTransfer2(string accnum, string transamount)
        {
            Transfer = Convert.ToDouble(initialdeposit2) + Convert.ToDouble(transamount);
            myConn.Open();
            SqlCommand editcmd = new SqlCommand("UpdateDeposit", myConn);
            editcmd.CommandType = CommandType.StoredProcedure;
            editcmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = accnum;
            editcmd.Parameters.Add("@InitialDeposit", SqlDbType.NVarChar).Value = Transfer;
            editcmd.ExecuteNonQuery();


            myConn.Close();
        }
        //getting the updated balance for compute transfer 2 (maybe buggy need more fix)
        public string GetBalance(string acc, string intdeposit)
        {
            myConn.Open();
            SqlCommand editcmd = new SqlCommand("UpdateDeposit2", myConn);
            editcmd.CommandType = CommandType.StoredProcedure;
            editcmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = acc;
            editcmd.Parameters.Add("@InitialDeposit", SqlDbType.NVarChar).Value = intdeposit;
            SqlDataReader dr;
            dr = editcmd.ExecuteReader();

            while (dr.Read())
            {
                initialdeposit2 = initialdeposit1 = dr.GetString(7);
                break;
            }
            myConn.Close();

            return(initialdeposit2.ToString());
        }
        //view records
        public DataTable ViewRecords()
        {
            SqlDataAdapter da = new SqlDataAdapter("ViewTransactHistory", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
