using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBlackJack
{
    public partial class hongkongPanel : UserControl
    {
        List<string> rCards = new List<string>()
        {
            @"C:\BSIT 1\C#\blackjack\cards\2_of_clubs.png",
            @"C:\BSIT 1\C#\blackjack\cards\2_of_diamonds.png",
            @"C:\BSIT 1\C#\blackjack\cards\2_of_hearts.png",
            @"C:\BSIT 1\C#\blackjack\cards\2_of_spades.png",
            @"C:\BSIT 1\C#\blackjack\cards\3_of_clubs.png",
            @"C:\BSIT 1\C#\blackjack\cards\3_of_diamonds.png",
            @"C:\BSIT 1\C#\blackjack\cards\3_of_hearts.png",
            @"C:\BSIT 1\C#\blackjack\cards\3_of_spades.png",
            @"C:\BSIT 1\C#\blackjack\cards\4_of_clubs.png",
            @"C:\BSIT 1\C#\blackjack\cards\4_of_diamonds.png",
            @"C:\BSIT 1\C#\blackjack\cards\4_of_hearts.png",
            @"C:\BSIT 1\C#\blackjack\cards\4_of_spades.png",
            @"C:\BSIT 1\C#\blackjack\cards\5_of_clubs.png",
            @"C:\BSIT 1\C#\blackjack\cards\5_of_diamonds.png",
            @"C:\BSIT 1\C#\blackjack\cards\5_of_hearts.png",
            @"C:\BSIT 1\C#\blackjack\cards\5_of_spades.png",
            @"C:\BSIT 1\C#\blackjack\cards\6_of_clubs.png",
            @"C:\BSIT 1\C#\blackjack\cards\6_of_diamonds.png",
            @"C:\BSIT 1\C#\blackjack\cards\6_of_hearts.png",
            @"C:\BSIT 1\C#\blackjack\cards\6_of_spades.png",
            @"C:\BSIT 1\C#\blackjack\cards\7_of_clubs.png",
            @"C:\BSIT 1\C#\blackjack\cards\7_of_diamonds.png",
            @"C:\BSIT 1\C#\blackjack\cards\7_of_hearts.png",
            @"C:\BSIT 1\C#\blackjack\cards\7_of_spades.png",
            @"C:\BSIT 1\C#\blackjack\cards\8_of_clubs.png",
            @"C:\BSIT 1\C#\blackjack\cards\8_of_diamonds.png",
            @"C:\BSIT 1\C#\blackjack\cards\8_of_hearts.png",
            @"C:\BSIT 1\C#\blackjack\cards\8_of_spades.png",
            @"C:\BSIT 1\C#\blackjack\cards\9_of_clubs.png",
            @"C:\BSIT 1\C#\blackjack\cards\9_of_diamonds.png",
            @"C:\BSIT 1\C#\blackjack\cards\9_of_hearts.png",
            @"C:\BSIT 1\C#\blackjack\cards\9_of_spades.png",
            @"C:\BSIT 1\C#\blackjack\cards\10_of_clubs.png",
            @"C:\BSIT 1\C#\blackjack\cards\10_of_diamonds.png",
            @"C:\BSIT 1\C#\blackjack\cards\10_of_hearts.png",
            @"C:\BSIT 1\C#\blackjack\cards\10_of_spades.png",
            @"C:\BSIT 1\C#\blackjack\cards\ace_of_clubs.png",
            @"C:\BSIT 1\C#\blackjack\cards\ace_of_diamonds.png",
            @"C:\BSIT 1\C#\blackjack\cards\ace_of_hearts.png",
            @"C:\BSIT 1\C#\blackjack\cards\ace_of_spades2.png",
            @"C:\BSIT 1\C#\blackjack\cards\jack_of_clubs2.png",
            @"C:\BSIT 1\C#\blackjack\cards\jack_of_diamonds2.png",
            @"C:\BSIT 1\C#\blackjack\cards\jack_of_hearts2.png",
            @"C:\BSIT 1\C#\blackjack\cards\jack_of_spades2.png",
            @"C:\BSIT 1\C#\blackjack\cards\queen_of_clubs2.png",
            @"C:\BSIT 1\C#\blackjack\cards\queen_of_diamonds2.png",
            @"C:\BSIT 1\C#\blackjack\cards\queen_of_spades2.png",
            @"C:\BSIT 1\C#\blackjack\cards\king_of_clubs2.png",
            @"C:\BSIT 1\C#\blackjack\cards\king_of_diamonds2.png",
            @"C:\BSIT 1\C#\blackjack\cards\king_of_hearts2.png",
            @"C:\BSIT 1\C#\blackjack\cards\king_of_spades2.png"
        };

        private int GetCardValue(string cardPath) // ----------------------------- GET CARD VALUES ------------------------------------------
        {
            string fileName = Path.GetFileNameWithoutExtension(cardPath).ToLower();

            if (fileName.StartsWith("ace")) return 1;
            else if (fileName.StartsWith("2")) return 2;
            else if (fileName.StartsWith("3")) return 3;
            else if (fileName.StartsWith("4")) return 4;
            else if (fileName.StartsWith("5")) return 5;
            else if (fileName.StartsWith("6")) return 6;
            else if (fileName.StartsWith("7")) return 7;
            else if (fileName.StartsWith("8")) return 8;
            else if (fileName.StartsWith("9")) return 9;
            else if (fileName.StartsWith("10")) return 10;
            else if (fileName.StartsWith("jack")) return 10;
            else if (fileName.StartsWith("queen")) return 10;
            else if (fileName.StartsWith("king")) return 10;


            return 0;
        }

        private void hiddenCards() // -------------------------------------- HIDDEN CARDS FOR LATER REVEAL EVERY ROUND -----------------------------------------------
        {
            rDealer2.Image = botHiddenCards[0];
            rDealer3.Image = botHiddenCards[1];
            rDealer4.Image = botHiddenCards[2];
        }

        int botCard = 0;
        int playerCard = 0;
        private void resetRound() // -------------------------------------------- RESET VARIABLES ---------------------------------------------------------
        {
            botCard = 0;
            playerCard = 0;
            rDealer1.Image = null;
            rDealer2.Image = null;
            rDealer3.Image = null;
            rDealer4.Image = null;
            rPlayer1.Image = null;
            rPlayer2.Image = null;
            rPlayer3.Image = null;
            rPlayer4.Image = null;

            currentBet = 0;
            playerReveal = 0;
            dealerReveal = 0;
            playerTotal = 0;
            botTotal = 0;
            playerValue.Text = "0";
            botValue.Text = "0";
            latestBet = 0;

            roundOver = false;
            playerHasStood = false;
            botValue.Visible = false;
            isDrawn = false;
            startRound.Visible = true;
            dealerDialogue.Visible = false;
            actionLog.Visible = true;
            roundStarted = false;
            hitBtn.Enabled = false;
            standBtn.Enabled = false;
            doubleBtn.Enabled = false;
            startRound.Enabled = false;


            playerDraw1.Location = new Point(656, 121);
            playerDraw2.Location = new Point(656, 121);
            playerDraw3.Location = new Point(656, 121);
            playerDraw4.Location = new Point(656, 121);
            dealerDraw1.Location = new Point(656, 121);
            dealerDraw2.Location = new Point(656, 121);
            dealerDraw3.Location = new Point(656, 121);
            dealerDraw4.Location = new Point(656, 121);

            initialDraw.Enabled = false;
            pCardAnimation3.Enabled = false;
            pCardAnimation4.Enabled = false;
            dCardAnimation3.Enabled = false;
            dCardAnimation4.Enabled = false;

            rPlayer1.Visible = false;
            rPlayer2.Visible = false;
            rPlayer3.Visible = false;
            rPlayer4.Visible = false;
            rDealer1.Visible = false;
            rDealer2.Visible = false;
            rDealer3.Visible = false;
            rDealer4.Visible = false;

            // Make the moving PictureBoxes visible (if not already)
            playerDraw1.Visible = true;
            playerDraw2.Visible = true;
            playerDraw3.Visible = true;
            playerDraw4.Visible = true;
            dealerDraw1.Visible = true;
            dealerDraw2.Visible = true;
            dealerDraw3.Visible = true;
            dealerDraw4.Visible = true;

            returnBet.Visible = true;
            returnAllBet.Visible = true;


            hitBtn.BackColor = Color.DimGray;
            standBtn.BackColor = Color.DimGray;
            doubleBtn.BackColor = Color.DimGray;
            startRound.BackColor = Color.DimGray;

            botHiddenCards[0] = null;
            botHiddenCards[1] = null;
            botHiddenCards[2] = null;

            checkGameWinner();

            rBet.Text = "Bet : " + currentBet.ToString();
        }

        private bool checkBalance(int chipAmount)
        {
            return AccountData.accountsBalance[AccountData.currentAccount] >= chipAmount;
        }

        private void checkGameWinner()
        {
            if (AccountData.accountsBalance[AccountData.currentAccount] == 0 || AccountData.accountsBalance[AccountData.currentAccount] < minBet)
            {
                MessageBox.Show("You have no more balance left! Game Over.");
                if (this.ParentForm is mainGameForm mainForm)
                {
                    mainForm.ReturnToCarousel();
                }
            }

            else if (dealerBalance == 0 || dealerBalance < minBet)
            {
                MessageBox.Show("Dealer have no more balance left! You won!.");
                if (this.ParentForm is mainGameForm mainForm)
                {
                    mainForm.ReturnToCarousel();
                }
            }

            else
            {
                r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            }
        }

        private void balanceWinUpdate()
        {
            ingameWinnings += currentBet * 2;
            AccountData.accountsBalance[AccountData.currentAccount] += currentBet * 2;
            dealerBalance -= currentBet;
            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
        }


        private void balanceWinUpdateDouble()
        {
            ingameWinnings += (currentBet * 2) * 2;
            dealerBalance -= (currentBet * 2);
            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
        }

        private void balanceLoseUpdate()
        {
            dealerBalance += currentBet;
            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
        }

        private void balanceLoseUpdateDouble()
        {
            dealerBalance += (currentBet * 2);
            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
        }

        private void displayValues()
        {
            botValue.Text = botTotal.ToString();
            playerValue.Text = playerTotal.ToString();
        }
        private void setValueVisible()
        {
            botValue.Visible = true;
        }

        private void startGameEnabled()
        {
            if (currentBet > 0)
            {
                startRound.Enabled = true;
                startRound.BackColor = Color.Red;
            }
        }

        private void actionsEnabled()
        {
            hitBtn.BackColor = Color.ForestGreen;
            standBtn.BackColor = Color.Yellow;
            doubleBtn.BackColor = Color.OrangeRed;

            hitBtn.Enabled = true;
            standBtn.Enabled = true;
            doubleBtn.Enabled = true;
        }

        private void playerBlackJack()
        {
            roundWinnerSound();
            MessageBox.Show("Player BlackJack, Dealer lost!");
            roundOver = true;
            balanceWinUpdate();
            resetRound();
            return;
        }

        private void playerBlackJackDouble()
        {
            roundWinnerSound();
            MessageBox.Show("Player BlackJack, Dealer lost!");
            roundOver = true;
            balanceWinUpdateDouble();
            resetRound();
            return;
        }

        private void dealerBlackJack()
        {
            roundWinnerSound();
            MessageBox.Show("Dealer BlackJack, Player lost!");
            roundOver = true;
            balanceWinUpdate();
            resetRound();
            return;
        }

        private void dealerBlackJackDouble()
        {
            roundWinnerSound();
            MessageBox.Show("Dealer BlackJack, Player lost!");
            roundOver = true;
            balanceWinUpdateDouble();
            resetRound();
            return;
        }

        private void matched()
        {
            roundLoserSound();
            MessageBox.Show("Draw matched, returning cards.");
            roundOver = true;
            AccountData.accountsBalance[AccountData.currentAccount] += currentBet;
            resetRound();
            return;
        }

        private void matchedDouble()
        {
            roundLoserSound();
            MessageBox.Show("Draw matched, returning cards.");
            roundOver = true;
            AccountData.accountsBalance[AccountData.currentAccount] += currentBet;
            resetRound();
            return;
        }

        private void checkNearest()
        {
            if (playerTotal == botTotal)
            {
                roundLoserSound();
                MessageBox.Show("Draw match!");
                r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
            }
            else if ((playerTotal - 21) < (botTotal - 21))
            {
                roundWinnerSound();
                dealerBustDialogue();
                MessageBox.Show("Player's the nearest to 21, you won!");
                balanceWinUpdate();
            }
            else
            {
                roundLoserSound();
                playerBustDialogue();
                MessageBox.Show("Dealer's the nearest to 21, Dealer won!");
                balanceLoseUpdate();
            }
            resetRound();
            return;
        }

        private void checkNearestDouble()
        {
            if (playerTotal == botTotal)
            {
                roundLoserSound();
                MessageBox.Show("Draw match!, returning cards.");
                AccountData.accountsBalance[AccountData.currentAccount] += currentBet;

            }
            else if ((playerTotal - 21) < (botTotal - 21))
            {
                roundWinnerSound();
                dealerBustDialogue();
                MessageBox.Show("Player's the nearest to 21, you won!");
                balanceLoseUpdateDouble();
            }
            else
            {
                roundLoserSound();
                playerBustDialogue();
                MessageBox.Show("Dealer's the nearest to 21, Dealer won!");
                balanceLoseUpdateDouble();
            }
            resetRound();
            return;
        }

        private void playerWinner()
        {
            roundWinnerSound();
            standWinDialogue();
            MessageBox.Show("Player wins!");
            roundOver = true;
            balanceWinUpdate();
            resetRound();
            return;
        }

        private void playerWinnerDouble()
        {
            roundWinnerSound();
            standWinDialogue();
            MessageBox.Show("Player wins!");
            roundOver = true;
            balanceWinUpdateDouble();
            resetRound();
            return;
        }

        private void dealerWinner()
        {
            roundWinnerSound();
            standLoseDialogue();
            MessageBox.Show("Dealer wins!");
            roundOver = true;
            balanceLoseUpdate();
            resetRound();
            return;
        }

        private void dealerWinnerDouble()
        {
            roundWinnerSound();
            standLoseDialogue();
            MessageBox.Show("Dealer wins!");
            roundOver = true;
            balanceLoseUpdateDouble();
            resetRound();
            return;
        }

        private void playerBusted()
        {
            roundLoserSound();
            playerBustDialogue();
            hiddenCards();
            roundOver = true;

            MessageBox.Show("Player's busted, Dealer won!");
            balanceLoseUpdate();
            resetRound();
            return;
        }

        private void playerBustedDouble()
        {
            roundLoserSound();
            playerBustDialogue();
            hiddenCards();

            roundOver = true;
            MessageBox.Show("Player's busted, Dealer won!");
            balanceLoseUpdateDouble();
            resetRound();
            return;
        }

        private void dealerBusted()
        {
            roundWinnerSound();
            dealerBustDialogue();
            hiddenCards();
            roundOver = true;

            MessageBox.Show("Dealer's busted, Player won!");
            balanceWinUpdate();
            resetRound();
            return;
        }
        private void dealerBustedDouble()
        {
            roundWinnerSound();
            dealerBustDialogue();
            hiddenCards();
            roundOver = true;

            MessageBox.Show("Dealer's busted, Player won!");
            balanceWinUpdateDouble();
            resetRound();
            return;
        }

        private void addChips(int bet)
        {
            if (roundStarted == true)
            {
                MessageBox.Show("You are not allowed to add chips while the round has started.");
            }

            else
            {
                int tempBalance = AccountData.accountsBalance[AccountData.currentAccount];

                chipsSound();
                currentBet += bet;
                tempBalance -= bet;

                rBet.Text = "Round Bet : " + currentBet.ToString();
                r_BankRoll.Text = "Bankroll : " + (AccountData.accountsBalance[AccountData.currentAccount] -= bet);

                AccountData.accountsBalance[AccountData.currentAccount] = tempBalance;
            }
        }

        private void round()
        {
            ingameRound++;
            currentRound.Text = "Round : " + ingameRound.ToString();
        }


        private void startGameDialogue()
        {
            Random randDialogue = new Random();
            int index = randDialogue.Next(dialogues.startGame.Count);

            string selectedDialogue = dialogues.startGame[index];
            dealerDialogue.Text = "Dealer: " + selectedDialogue;
        }

        private void dealerBustDialogue()
        {
            Random randDialogue = new Random();
            int index = randDialogue.Next(dialogues.bustDialoguesWin.Count);

            string selectedDialogue = dialogues.bustDialoguesWin[index];
            dealerDialogue.Text = "Dealer: " + selectedDialogue;
        }

        private void playerBustDialogue()
        {
            Random randDialogue = new Random();
            int index = randDialogue.Next(dialogues.bustDialoguesLose.Count);

            string selectedDialogue = dialogues.bustDialoguesLose[index];
            dealerDialogue.Text = "Dealer: " + selectedDialogue;
        }

        private void playerHitDialogue()
        {
            Random randDialogue = new Random();
            int index = randDialogue.Next(dialogues.hitDialogues.Count);

            string selectedDialogue = dialogues.hitDialogues[index];
            dealerDialogue.Text = "Dealer: " + selectedDialogue;
        }

        private void standWinDialogue()
        {
            Random randDialogue = new Random();
            int index = randDialogue.Next(dialogues.standWinDialogues.Count);

            string selectedDialogue = dialogues.standWinDialogues[index];
            dealerDialogue.Text = "Dealer: " + selectedDialogue;
        }

        private void standLoseDialogue()
        {
            Random randDialogue = new Random();
            int index = randDialogue.Next(dialogues.standLoseDialogues.Count);

            string selectedDialogue = dialogues.standLoseDialogues[index];
            dealerDialogue.Text = "Dealer: " + selectedDialogue;
        }

        private gamesounds cardsound;
        private void drawCardsSound()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\draw-card.wav";
            cardsound = new gamesounds(musicPath);
            cardsound.PlayOnce();
        }

        private void chipsSound()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\chips.wav";
            cardsound = new gamesounds(musicPath);
            cardsound.PlayOnce();
        }

        private void errorSound()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\no-bet.wav";
            cardsound = new gamesounds(musicPath);
            cardsound.PlayOnce();
        }

        private void roundWinnerSound()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\round-winner.wav";
            cardsound = new gamesounds(musicPath);
            cardsound.PlayOnce();
        }

        private void roundLoserSound()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\round-loser.wav";
            cardsound = new gamesounds(musicPath);
            cardsound.PlayOnce();
        }

        Random playerRandom = new Random();
        Random botRandom = new Random();

        // ----------------------------- DEALER/PLAYER CARDS/BET VARS ------------------------------------------
        public int playerReveal = 0;
        public int dealerReveal = 0;
        public int playerTotal = 0;
        public int botTotal = 0;
        public int latestBet = 0;
        public int minBet = 1;

        public int playerBalance = 0;
        public int dealerBalance = (AccountData.accountsBalance[AccountData.currentAccount] + 500);
        public int currentBet = 0;
        public int ingameWinnings = 0;

        private bool roundOver = false;
        private bool playerHasStood = false;
        private bool isDrawn = false;
        private bool roundStarted = false;

        private int ingameRound = 1;



        // ----------------------------- BOT IMAGES ------------------------------------------
        public Image bot1;
        public Image bot2;
        public Image bot3;
        public Image bot4;
        public Image[] botHiddenCards = new Image[3];

        string currentUser = AccountData.usernames[AccountData.currentAccount];

        public hongkongPanel()
        {
            InitializeComponent();
        }

        private void hongkongPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dCardAnimation3_Tick(object sender, EventArgs e)
        {

        }

        private void dCardAnimation4_Tick(object sender, EventArgs e)
        {

        }

        private void pCardAnimation4_Tick(object sender, EventArgs e)
        {

        }

        private void pCardAnimation3_Tick(object sender, EventArgs e)
        {

        }

        private void initialDraw_Tick(object sender, EventArgs e)
        {

        }

        private void returnTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void standBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
