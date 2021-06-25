using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelperLoanCalculator
{
    public class DataAccess
    {
        static int myID;
        static string myAccountNumber;
        static string myMembershipBond;
        static string myFirstName;
        static string myLastName;
        static string myPassword;
        static string myEmailAddress;
        static string myBirthday;

        double myInterest;
        double myTotalLoanDue;
        double myMonthlyAmortization;
       


        public static string MyAccountNumber { get => myAccountNumber; set => myAccountNumber = value; }
        public static string MyMembershipBond { get => myMembershipBond; set => myMembershipBond = value; }
        public double MyInterest { get => myInterest; set => myInterest = value; }
        public double MyTotalLoanDue { get => myTotalLoanDue; set => myTotalLoanDue = value; }
        public double MyMonthlyAmortization { get => myMonthlyAmortization; set => myMonthlyAmortization = value; }
        public static string MyFirstName { get => myFirstName; set => myFirstName = value; }
        public static string MyLastName { get => myLastName; set => myLastName = value; }
        public static string MyPassword { get => myPassword; set => myPassword = value; }
        public static string MyEmailAddress { get => myEmailAddress; set => myEmailAddress = value; }
        public static string MyBirthday { get => myBirthday; set => myBirthday = value; }
        public static int MyID { get => myID; set => myID = value; }

        static string myConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\Visual Studio 2019\Form_Projects\LOANCALCULATOR\DataHelperLoanCalculator\MasterFile.mdf;Integrated Security=True";
        SqlConnection myConn = new SqlConnection(myConnStr);

        
        //Formula
        public void ComputeLoan(double InterestRate, double loanAmount, int NumMonths)
        {
            myInterest = (InterestRate * loanAmount) * NumMonths;
            myTotalLoanDue = loanAmount + myInterest;
            myMonthlyAmortization = myTotalLoanDue/NumMonths;
        }


        public void AddNewUser(string FirstName, string LastName, string MembershipBond, string Password, string Birthday, string EmailAddress, string AccountNumber)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("AddNewUser", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            saveCmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            saveCmd.Parameters.Add("@MembershipBond", SqlDbType.NVarChar).Value = MembershipBond;
            saveCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
            saveCmd.Parameters.Add("@Birthday", SqlDbType.NVarChar).Value = Birthday;
            saveCmd.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = EmailAddress;
            saveCmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = AccountNumber;

            saveCmd.ExecuteNonQuery();
            myConn.Close();

        }

        public bool CheckUserAccount(string AccountNumber, string Password)
        {
            bool found = false;

            myConn.Open();
            SqlCommand readCmd = new SqlCommand("CheckUserAccount", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = AccountNumber;
            readCmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
            SqlDataReader dr;
            dr = readCmd.ExecuteReader();

            while (!found && dr.Read())
            {
                found = true;
                myAccountNumber = dr.GetString(7);
                myMembershipBond = dr.GetString(3);
                 myFirstName = dr.GetString(1); 
                myLastName = dr.GetString(2);
                myPassword = dr.GetString(4);
                myEmailAddress = dr.GetString(6);
                myBirthday = dr.GetString(5);
                break;
            }

            myConn.Close();
            return found;

        }
        public void AddNewLoan(string AccountNumber, string MembershipBond, string LoanType, string LoanAmount, string Interest, string MonthlyAmor, string MonthsToPay, string TotalLoanDue, string LoanStatus)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("AddNewLoan", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = AccountNumber;
            saveCmd.Parameters.Add("@MemberBond", SqlDbType.NVarChar).Value = MembershipBond;
            saveCmd.Parameters.Add("@LoanType", SqlDbType.NVarChar).Value = LoanType;
            saveCmd.Parameters.Add("@LoanAmount", SqlDbType.NVarChar).Value = LoanAmount;
            saveCmd.Parameters.Add("@Interest", SqlDbType.NVarChar).Value = Interest;
            saveCmd.Parameters.Add("@MonthlyAmortization", SqlDbType.NVarChar).Value = MonthlyAmor;
            saveCmd.Parameters.Add("@MonthsToPay", SqlDbType.NVarChar).Value = MonthsToPay;
            saveCmd.Parameters.Add("@TotalLoanDue", SqlDbType.NVarChar).Value = TotalLoanDue; 
            saveCmd.Parameters.Add("@LoanStatus", SqlDbType.NVarChar).Value = LoanStatus;

            saveCmd.ExecuteNonQuery();
            myConn.Close();

        }

        
        public DataTable ViewAllRecords()
        {
            SqlDataAdapter da = new SqlDataAdapter("ViewAllRecords", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable ViewAllLoanTransacction()
        {
            SqlDataAdapter da = new SqlDataAdapter("ViewAllLoanTransaction", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable SearchLoanTransaction(string AccountNumber)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SearchLoanTransaction", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = AccountNumber;
            saveCmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(saveCmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            myConn.Close();
            return dt;
            
        }

        public DataTable SearchLoanID(string AccountNumber, int id)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SearchLoanID", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = AccountNumber;
            saveCmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            saveCmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(saveCmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            myConn.Close();
            return dt;

        }


        public DataTable UpdateLoanType(int id,string accnum, string loantype)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("UpdateLoanType", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@LoanStatus", SqlDbType.NVarChar).Value = loantype;
            saveCmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = accnum;
            saveCmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            saveCmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(saveCmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            myConn.Close();
            return dt;

        }

        public void ResetPasswordPending(string AccountNumber, string Status)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("ResetPasswordPending", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = AccountNumber;
            saveCmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = Status;
            saveCmd.ExecuteNonQuery();
            myConn.Close();

        }

        public DataTable ViewRequestPassword()
        {
            SqlDataAdapter da = new SqlDataAdapter("ViewRequestPassword", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable UpdateResetPassword(string AccountNumber, string Status, string Password)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("UpdateResetPassword", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = AccountNumber;
            saveCmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = Status;
            saveCmd.Parameters.Add("@Password", SqlDbType.Int).Value = Password;
            saveCmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(saveCmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            myConn.Close();
            return dt;

        }
        public void UpdateProfile(string membond, string pass, string bday, string email, string accnum)
        {
            myConn.Open();
            SqlCommand savecmd = new SqlCommand("ProfileUpdate", myConn);
            savecmd.CommandType = CommandType.StoredProcedure;
            savecmd.Parameters.Add("@MembershipBond", SqlDbType.NVarChar).Value = membond;
            savecmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = pass;
            savecmd.Parameters.Add("@Birthday", SqlDbType.NVarChar).Value = bday;
            savecmd.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = email;
            savecmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = accnum;
            savecmd.ExecuteNonQuery();

            myConn.Close();
        }

        public DataTable ViewLoanGraph()
        {
            SqlDataAdapter da = new SqlDataAdapter("LoanGraph", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        public int getLoanTransactionCount(string loanType)
        {
            myConn.Open();
            SqlCommand cmd = new SqlCommand("GetLoanTransactionCount", myConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@loanType", SqlDbType.NVarChar).Value = loanType;
            int count = (int)cmd.ExecuteScalar();
            myConn.Close();
            return count;
        }
        




    }
}
