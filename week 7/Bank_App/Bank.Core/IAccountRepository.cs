using System;
using System.Collections.Generic;
using System.Text;
using Week3_Task.Commons;

namespace Bank.Core
{

    /// <summary>
    /// This specifies contract for account operations
    /// </summary>
    public interface IAccountRepository
    {

        /// <summary>
        /// This method search account to be used in winform
        /// </summary>
        public static Account SearchAccountWin { get; }

        /// <summary>
        /// This method searches for account form databes
        /// </summary>
        public static Account SearchAccountDB { get; }
    }
}
