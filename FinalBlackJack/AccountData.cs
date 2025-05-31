using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBlackJack
{
    internal class Transaction
    {
        public string Activity { get; set; }
        public string Time { get; set; }
        public string Amount { get; set; }

        public Transaction(string activity, string time, string amount)
        {
            Activity = activity;
            Time = time;
            Amount = amount;
        }
    }

    internal class AccountData
    {
        public static List<string> usernames = new List<string> { "test", "Marjorie", "123" };
        public static List<string> passwords = new List<string> { "test123", "Marjorie", "123" };
        public static List<string> emails = new List<string> { "test@gmail.com", "Marj@gmail.com", "aronefbs@gmail.com" };
        public static List<int> accountsBalance = new List<int> { 0, 420, 5000 };
        public static List<int> totalWins = new List<int> { 0, 100 , 100};
        public static List<int> totalLosses = new List<int> { 0, 32 , 50};
        public static List<int> bustCount = new List<int> { 25, 96 , 100};
        public static List<int> totalWinnings = new List<int> { 0, 1000 , 999999};
        public static int currentAccount = 0;

        // Store a list of transactions for each account
        public static List<List<Transaction>> transactions = new List<List<Transaction>>
        {
            new List<Transaction> { new Transaction("No Activity yet", "0", "0") }, //year-date-day hour:mins:second
            new List<Transaction> { new Transaction("Withdrawal", "2025-06-31", "100") },
            new List<Transaction> { new Transaction("Deposit", "2025-06-27", "999999") },
        };
    }
}
