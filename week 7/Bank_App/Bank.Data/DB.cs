using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using Week3_Task.Commons;

namespace Bank.Data
{
    public class DB
    {

        protected static SqlConnection conn;
        protected static SqlCommand cmd;
        public static string stringConnection = "Data Source=LAPTOP-R0IBRK5V;Initial Catalog=EDeyPayBank;Integrated Security=True;";
        static SqlDataAdapter moAdapter = new SqlDataAdapter();
        static DataSet moDataSet = new DataSet();

        public SqlConnection GetConnection()
        {
            conn = new SqlConnection(stringConnection);
            return conn;
        }

        public async Task<bool> QueryExecute(string stmt)
        {
            GetConnection();
            using (cmd = new SqlCommand(stmt, conn))
            {
                if (conn == null)
                    throw new Exception("Failed to connect");

                conn.Open();
                await cmd.ExecuteNonQueryAsync();
                
            }
            conn.Close();
            return true;
        }

        public Account GetFromDB(string query) {
            GetConnection();
            Account account = new Account();
            using (var command = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        account.AccountId = reader["id"].ToString();
                        account.AccountName = reader["account_name"].ToString();
                        account.AccountNumber = reader["account_number"].ToString();
                        account.AccountType = reader["account_type"].ToString(); // hash
                        account.AccountEmail = reader["account_mail"].ToString();
                        account.AccountPassword = reader["account_password"].ToString();
                       account.Balance = Double.Parse(reader["account_balance"].ToString());
          
                        //display retrieved record                          
                    }

                    return account;
                }
            }
            //return null;

        }

        public Account FetchFromDB(string query) {
           
            //variables to store the query results
            double id = 0;
            string account_name = "", account_number ="", account_type = "", account_mail = "", account_password = "", account_balance = "";
           

            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //open connection
                    conn.Open();

                    //execute the SQLCommand
                    SqlDataReader dr = cmd.ExecuteReader();

                    Console.WriteLine(Environment.NewLine + "Retrieving data from database..." + Environment.NewLine);
                    Console.WriteLine("Retrieved records:");
                    Account account = new Account();

                    //check if there are records
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            id = dr.GetDouble(0);
                            account_name = dr.GetString(1);
                            account_number = dr.GetString(2);
                            account_type = dr.GetString(3);
                            account_mail = dr.GetString(4);
                            account_password = dr.GetString(5);
                            account_balance = dr.GetString(6);
                            //display retrieved record                          
                        }
                        account.AccountId = id.ToString();
                        account.AccountName = account_name;
                        account.AccountNumber = account_number;
                        account.AccountType = account_type;
                        account.AccountType = account_password;

                        return account;

                    }
                    else
                    {
                        Console.WriteLine("No data found.");
                        return null;
                    }

                    //close data reader
                    dr.Close();

                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }


        }

        public List<Transaction> GetTransacetionsDB(string query)
        {
            List<Transaction> listTransactions = new List<Transaction>();
          
            GetConnection();
            using (var command = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listTransactions.Add(new Transaction(reader["note"].ToString(), reader["type_of_transaction"].ToString(), reader["customers_name"].ToString(), reader["customers_account"].ToString(), reader["transaction_amount"].ToString()));
                        
                    }

                    return listTransactions;
                }
            }
            return null;

        }


    }
}
