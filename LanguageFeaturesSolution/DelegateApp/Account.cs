using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    public delegate void BalanceChangeHandler(int aid, string hn, decimal bal, decimal change);
    public class Account
    {
      
        public int AccountID { get; set; }
        public string HoldersName { get; set; }
        public decimal Balance { get; set; }
        public event BalanceChangeHandler BalanceChange;
        public Account (int ad,string hn,decimal bal)
        {
            AccountID = ad;
            HoldersName = hn;
            Balance = bal;
        }
        public void Deposite(decimal amount)
        {
            Balance += amount;
            if (BalanceChange != null)
            {
                BalanceChange(AccountID, HoldersName, Balance, amount);
            }
            
        }
        public override string ToString()
        {
            return String.Format("Account ID : {0}, Holders Name :{1}, Balance :{2}",AccountID,HoldersName,Balance);
        }
    }
}
