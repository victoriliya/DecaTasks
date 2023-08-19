using Bank.Config;
using Bank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankWinform.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bank.Core.IAccountRepository accRepo = BankConfig.IAccountInstance;

            MySqLiteDB db = new MySqLiteDB();

            string stmt = @$"SELECT * FROM Account WHERE AccountName = 'Great Khalid'";
            db.GetFromDB(stmt);

            //DB.GetConnection();
            //Application.Run(new Login(accRepo));
        }
    }
}
