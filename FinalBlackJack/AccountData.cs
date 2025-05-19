using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBlackJack
{
    internal class AccountData
    {

        public static List<string> usernames = new List<string> { "123", "a" };
        public static List<string> passwords = new List<string> { "123", "a" };
        public static List<string> emails = new List<string> { "123@gmail.com", "a" };
        public static List<double> accountsBalance = new List<double> { 5000.00, 5000.00 };
        public static List<int> totalWins = new List<int> { 15, 21 };
        public static List<int> totalLoses = new List<int> { 17, 5 };
        public static List<int> totalWinnings = new List<int> { 15993, 321334 };
        public static int currentAccount = 0;

    }
}
