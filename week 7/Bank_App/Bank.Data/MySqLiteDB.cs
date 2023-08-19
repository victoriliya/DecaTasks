using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Dapper;
using System.Threading.Tasks;
using Week3_Task.Commons;

namespace Bank.Data
{
    public class MySqLiteDB
    {
        public static string connStr = @"Data Source=.\BankDb.db;Version=3;";
        protected static IDbConnection conn;

        /*
         cnn.Execute("INSERT INTO Person (FirstName, LastName) Values (@FirstName, @LastName)", person);
         */

        public IDbConnection GetConnection()
        {
            conn = new SQLiteConnection(connStr);
            return conn;
        }

        public bool QueryExecute(string stmt, Object obj)
        {
            GetConnection();
            conn.Execute(stmt, obj);
            return true;
        }

        
        public Account GetFromDB(string stmt)
        {
            GetConnection();
            Account acc = new Account();
            //List<Account> accounts = new List<Account>();
            //conn.Execute("INSERT INTO Account (AccountName) VALUES ('Great Khalid')", acc);
            var account = conn.Query<Account>(stmt, new DynamicParameters());
            foreach (var item in account)
            {

            }

            return account;
        }

        public List<Account> GetTransactionsFromDB()
        {
            GetConnection();
            Account acc = new Account();
            List<Account> accounts = new List<Account>();
            //conn.Execute("INSERT INTO Account (AccountName) VALUES ('Great Khalid')", acc);
            var accountsFromDb = conn.Query<Account>("SELECT * FROM Account", new DynamicParameters());
            foreach (var account in accountsFromDb)
            {
                accounts.Add(account);
            }
            return accounts;
        }

        /*  public Account FetchFromDB(string query)
          {

              //variables to store the query results
              double id = 0;
              string account_name = "", account_number = "", account_type = "", account_mail = "", account_password = "", account_balance = "";


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


  */

    }
}
