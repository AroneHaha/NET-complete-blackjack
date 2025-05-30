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
        public static List<string> usernames = new List<string> { "123", "a" };
        public static List<string> passwords = new List<string> { "123", "a" };
        public static List<string> emails = new List<string> { "aronefbs@gmail.com", "a@gmail.com" };
        public static List<int> accountsBalance = new List<int> { 5000000, 6969 };
        public static List<int> totalWins = new List<int> { 50, 26 };
        public static List<int> totalLosses = new List<int> { 25, 56 };
        public static List<int> bustCount = new List<int> { 81, 96 };
        public static List<int> totalWinnings = new List<int> { 15993, 321334 };
        public static int currentAccount = 0;

        // Store a list of transactions for each account
        public static List<List<Transaction>> transactions = new List<List<Transaction>>
        {
            new List<Transaction> { new Transaction("Deposit", "1", "0") },
            new List<Transaction> { new Transaction("Withdrawal", "2", "0") }
        };
    }
}
