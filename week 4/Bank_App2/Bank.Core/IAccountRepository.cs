using System;
using System.Collections.Generic;
using System.Text;
using Week3_Task.Commons;

namespace Bank.Core
{
    interface IAccountRepository
    {
        public static Account SearchAccountWin { get; }
        public static Account SearchAccountDB { get; }
    }
}
