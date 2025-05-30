using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FinalBlackJack
{
  

    public partial class singaporePanel : UserControl
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
            return buyinBalance >= chipAmount;
        }

        private void checkGameWinner()
        {
            if (buyinBalance == 0 || buyinBalance < minBet)
            {
                MessageBox.Show("You have no more balance left! Game Over.");
                AccountData.accountsBalance[AccountData.currentAccount] -= (buyinHolder.buyIn[0] - buyinBalance);
                AccountData.totalLosses[AccountData.currentAccount]++;
                if (this.ParentForm is mainGameForm mainForm)
                {
                    mainForm.ReturnToCarousel();
                }
            }

            else if (dealerBalance == 0 || dealerBalance < minBet)
            {
                MessageBox.Show("Dealer have no more balance left! You won!.");
                AccountData.accountsBalance[AccountData.currentAccount] += (buyinHolder.buyIn[0] - dealerBalance);
                AccountData.totalWinnings[AccountData.currentAccount] += (buyinHolder.buyIn[0] - dealerBalance);
                AccountData.totalWins[AccountData.currentAccount]++;
                if (this.ParentForm is mainGameForm mainForm)
                {
                    mainForm.ReturnToCarousel();
                }
            }

            else
            {
                r_BankRoll.Text = "Balance: " + buyinBalance.ToString();
            }
        }

        private void balanceWinUpdate()
        {
            ingameWinnings += currentBet * 2;
            buyinBalance += currentBet * 2;
            dealerBalance -= currentBet;
            r_BankRoll.Text = "Bankroll : " + buyinBalance.ToString();
            r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
        }


        private void balanceWinUpdateDouble()
        {
            buyinBalance += (currentBet * 2) * 2;
            ingameWinnings += (currentBet * 2) * 2;
            dealerBalance -= (currentBet * 2);
            r_BankRoll.Text = "Bankroll : " + buyinBalance.ToString();
            r_totalWinnings.Text = "Winnings : " + ingameWinnings.ToString();
        }

        private void balanceLoseUpdate()
        {
            dealerBalance += currentBet;
            r_BankRoll.Text = "Bankroll : " + buyinBalance.ToString();
            r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
        }

        private void balanceLoseUpdateDouble()
        {
            dealerBalance += (currentBet * 2);
            r_BankRoll.Text = "Bankroll : " + buyinBalance.ToString();
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
            balanceLoseUpdate();
            resetRound();
            return;
        }

        private void dealerBlackJackDouble()
        {
            roundWinnerSound();
            MessageBox.Show("Dealer BlackJack, Player lost!");
            roundOver = true;
            balanceLoseUpdateDouble();
            resetRound();
            return;
        }

        private void matched()
        {
            roundLoserSound();
            MessageBox.Show("Draw matched, returning cards.");
            roundOver = true;
            buyinBalance += currentBet;
            resetRound();
            return;
        }

        private void matchedDouble()
        {
            roundLoserSound();
            MessageBox.Show("Draw matched, returning cards.");
            roundOver = true;
            buyinBalance += currentBet;
            resetRound();
            return;
        }

        private void checkNearest()
        {
            if (playerTotal == botTotal)
            {
                roundLoserSound();
                MessageBox.Show("Draw match!");
                r_totalWinnings.Text = "Winnings : " + ingameWinnings.ToString();
                matched();
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
                AccountData.bustCount[AccountData.currentAccount]++;
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
                buyinBalance += currentBet;
                matchedDouble();

            }
            else if ((playerTotal - 21) < (botTotal - 21))
            {
                roundWinnerSound();
                dealerBustDialogue();
                MessageBox.Show("Player's the nearest to 21, you won!");
                balanceWinUpdateDouble();
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
            AccountData.bustCount[AccountData.currentAccount]++;
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
            AccountData.bustCount[AccountData.currentAccount]++;
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
                chipsSound();
                currentBet += bet;
                buyinBalance -= bet;

                rBet.Text = "Round Bet : " + currentBet.ToString();
                r_BankRoll.Text = "Bankroll : " + buyinBalance;
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
        public int dealerBalance = 0;
        public int currentBet = 0;
        public int ingameWinnings = 0;

        public bool roundOver = false;
        public bool playerHasStood = false;
        public bool isDrawn = false;
        public bool roundStarted = false;

        public int ingameRound = 1;

        public int balanceHolder = AccountData.accountsBalance[AccountData.currentAccount];
        public int buyinBalance = buyinHolder.buyIn[0];
        

        // ----------------------------- BOT IMAGES ------------------------------------------
        public Image bot1;
        public Image bot2;
        public Image bot3;
        public Image bot4;
        public Image[] botHiddenCards = new Image[3];

        public singaporePanel()
        {
            InitializeComponent();

            dealerBalance = buyinBalance;
            surrenderPanel.Hide();
            this.Load += singaporePanel_Load;

            r_BankRoll.Text = "Bankroll : " + buyinBalance;
            rPlayer1.Visible = false;
            rPlayer2.Visible = false;
            rPlayer3.Visible = false;
            rPlayer4.Visible = false;
            rDealer1.Visible = false;
            rDealer2.Visible = false;
            rDealer3.Visible = false;
            rDealer4.Visible = false;

            currentRound.Text = "Round : " + ingameRound;
            actionLog.Visible = false;
            dealerDialogue.Visible = false;
            playerValue.Text = "";
            botValue.Text = "";

            returnTip.SetToolTip(returnBet, "Undo");
            returnAllTip.SetToolTip(returnAllBet, "Reset Bet");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is mainGameForm mainForm)
            {
                mainForm.ReturnToCarousel();
            }
        }

        private void singaporePanel_Load(object sender, EventArgs e)
        {
            r_BankRoll.Text = "Bankroll : " + buyinBalance;
            returnTip.SetToolTip(returnBet, "Undo");
            returnAllTip.SetToolTip(returnAllBet, "Reset Bet");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void rChip25_MouseEnter(object sender, EventArgs e)
        {
            r10k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\25ChipHover.png");
        }

        private void rChip25_Click(object sender, EventArgs e)
        {
            int chipValue = 10000;
            if (checkBalance(chipValue))
            {
                latestBet = chipValue;
                addChips(chipValue);
                startGameEnabled();
            }
            else
            {
                MessageBox.Show("Insufficient balance for this chip!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rChip25_MouseLeave(object sender, EventArgs e)
        {
            r10k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\25Chip.png");
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void rChip1_MouseEnter(object sender, EventArgs e)
        {
            r1k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\TABLE 2\1kchiphover.png");
        }

        private void rChip1_MouseLeave(object sender, EventArgs e)
        {
            r1k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\TABLE 2\1kchip.png");
        }

        private void rChip5_MouseEnter_1(object sender, EventArgs e)
        {
            r2p5k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\TABLE 2\2.5kchiphover.png");
        }

        private void rChip5_MouseLeave_1(object sender, EventArgs e)
        {
            r2p5k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\TABLE 2\2.5kchip.png");
        }

        private void rChip50_MouseEnter_1(object sender, EventArgs e)
        {
            r20k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\TABLE 2\20kchiphover.png");
        }

        private void rChip50_MouseLeave_1(object sender, EventArgs e)
        {
            r20k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\TABLE 2\20kchip.png");
        }

        private void rChip10_MouseEnter_1(object sender, EventArgs e)
        {
            r5k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\TABLE 2\5kchiphover.png");
        }

        private void rChip10_MouseLeave_1(object sender, EventArgs e)
        {
            r5k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\TABLE 2\5kchip.png");
        }

        private void rChip100_MouseEnter_1(object sender, EventArgs e)
        {
            r30k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\TABLE 2\30kchiphover.png");
        }

        private void rChip100_MouseLeave(object sender, EventArgs e)
        {
            r30k.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\TABLE 2\30kchip.png");
        }

        private void rCardFolded_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // ----------------------------- HIT BUTTON ------------------------------------------
        {

            if (isDrawn == false)
            {
                errorSound();
                MessageBox.Show("You can't draw cards until the round has started.");
                return;
            }

            if (currentBet == 0)
            {
                errorSound();
                MessageBox.Show("You must place a bet first!");
                return;
            }

            if (playerReveal == 4)
            {
                errorSound();
                MessageBox.Show("You already drew 4 cards!");
                return;
            }

            drawCardsSound();
            playerHitDialogue();

            int playerIndex = playerRandom.Next(rCards.Count);
            string playerCardPath = rCards[playerIndex];
            Image playerCardImg = Image.FromFile(playerCardPath);

            // ------------------------------- PUT CARDS ON PLAYER'S DECK -----------------------------

            if (playerReveal == 2)
            {
                pCardAnimation3.Start();
                rPlayer3.Image = playerCardImg;
                playerTotal += GetCardValue(playerCardPath);
            }

            else if (playerReveal == 3)
            {
                pCardAnimation4.Start();
                rPlayer4.Image = playerCardImg;
                playerTotal += GetCardValue(playerCardPath);
            }

            playerReveal++;

            displayValues();

            // --------------------------------------- VERIFY THE WINNER -------------------------------------
            if (playerTotal > 21 && botTotal > 21) // -------------------------------------- IF BOTH BUSTED -------------------------------------------------------
            {
                hiddenCards();
                setValueVisible();
                round();
                checkNearest();
            }

            else if (botTotal > 21) // ------------------------- IF DEALER'S BUSTED ----------------------------------------
            {
                hiddenCards();
                setValueVisible();
                round();
                dealerBusted();
            }

            else if (playerTotal > 21)
            {
                hiddenCards();
                setValueVisible();
                round();
                playerBusted();
            }

        }

        private void rChip1_Click(object sender, EventArgs e)
        {
            int chipValue = 1000;
            if (checkBalance(chipValue))
            {
                latestBet = chipValue; // Store the latest bet value
                addChips(chipValue);        // Only called if user has enough money
                startGameEnabled();
            }
            else
            {
                MessageBox.Show("Insufficient balance for this chip!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rChip5_Click(object sender, EventArgs e)
        {
            int chipValue = 2500;
            if (checkBalance(chipValue))
            {
                latestBet = chipValue;
                addChips(chipValue);        // Only called if user has enough money
                startGameEnabled();
            }
            else
            {
                MessageBox.Show("Insufficient balance for this chip!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rChip50_Click(object sender, EventArgs e)
        {
            int chipValue = 20000;
            if (checkBalance(chipValue))
            {
                latestBet = chipValue;
                addChips(chipValue);        // Only called if user has enough money
                startGameEnabled();
            }
            else
            {
                MessageBox.Show("Insufficient balance for this chip!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void rChip10_Click(object sender, EventArgs e)
        {
            int chipValue = 5000;
            if (checkBalance(chipValue))
            {
                latestBet = chipValue;
                addChips(chipValue);
                startGameEnabled();
            }
            else
            {
                MessageBox.Show("Insufficient balance for this chip!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rChip100_Click(object sender, EventArgs e)
        {
            int chipValue = 30000;
            if (checkBalance(chipValue))
            {
                latestBet = chipValue;
                addChips(chipValue);
                startGameEnabled();
            }
            else
            {
                MessageBox.Show("Insufficient balance for this chip!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ----------------------- REVEAL ALL CARDS ASAP TO AVOID ANY CONFLICT DURING COMPILATION OF RESULTS -------------------------------------------

            if (currentBet == 0)
            {
                errorSound();
                MessageBox.Show("You must place a bet first!");
                return;
            }

            while (botTotal < 17)
            {
                int botIndex = botRandom.Next(rCards.Count);
                string botCardPath = rCards[botIndex];
                Image botCardImg = Image.FromFile(botCardPath);
                Image folded = Image.FromFile(@"C:\BSIT 1\C#\blackjack\cards\red_backing.png");

                if (dealerReveal == 2)
                {
                    dealerDraw3.Visible = true;
                    dCardAnimation3.Start(); // Start first animation
                    rDealer3.Image = folded;
                    bot3 = botCardImg;
                    botHiddenCards[1] = bot3;
                }
                else if (dealerReveal == 3)
                {
                    // Don't start animation here yet. Wait until animation3 is done.
                    dealerDraw4.Visible = true;
                    rDealer4.Image = folded;
                    bot4 = botCardImg;
                    botHiddenCards[2] = bot4;
                    shouldRunDCard4 = true; // <-- this flag triggers animation4 later
                }

                botTotal += GetCardValue(botCardPath);
                dealerReveal++;

                if (botTotal >= 17)
                    break;
            }


            hiddenCards();
            setValueVisible();
            displayValues();

            if (botTotal > 21 && playerTotal > 21)
            {
                round();
                checkNearest();
            }

            else if (botTotal == 21 && playerTotal == 21)
            {
                round();
                dealerBlackJack();
            }

            else if (playerTotal == 21)
            {
                playerBlackJack();
            }

            else if (botTotal == 21)
            {
                dealerBlackJack();
            }

            else if (playerTotal == botTotal)
            {
                matched();
            }

            else if (playerTotal > 21)
            {
                playerBustDialogue();
                round();
                playerBusted();
            }

            else if (botTotal > 21)
            {
                dealerBustDialogue();
                round();
                dealerBusted();
            }

            else if (playerTotal > botTotal)
            {
                standWinDialogue();
                round();
                playerWinner();
            }

            else if (playerTotal < botTotal)
            {
                standLoseDialogue();
                round();
                dealerWinner();
            }

            r_BankRoll.Text = "Balance: " + buyinBalance;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentBet == 0)
            {
                errorSound();
                MessageBox.Show("You must place a bet first!");
                return;
            }

            returnBet.Visible = false;
            returnAllBet.Visible = false;
            drawCardsSound();
            actionsEnabled();

            // Make the moving PictureBoxes visible (if not already)
            playerDraw1.Visible = true;
            playerDraw2.Visible = true;

            dealerDraw1.Visible = true;
            dealerDraw2.Visible = true;


            // Start moving
            initialDraw.Enabled = true;

            botValue.Visible = false;
            isDrawn = true;
            startRound.Visible = false;
            dealerDialogue.Visible = true;
            actionLog.Visible = true;
            currentRound.Visible = false;
            roundStarted = true;

            startGameDialogue();


            while (playerReveal != 2 && dealerReveal != 2)
            {
                int botIndex = botRandom.Next(rCards.Count);
                string botCardPath = rCards[botIndex];
                Image botCardImg = Image.FromFile(botCardPath);
                Image folded = Image.FromFile(@"C:\BSIT 1\C#\blackjack\cards\red_backing.png");

                int playerIndex = playerRandom.Next(rCards.Count);
                string playerCardPath = rCards[playerIndex];
                Image playerCardImg = Image.FromFile(playerCardPath);

                if (playerReveal == 0)
                {
                    rDealer1.Image = botCardImg;
                    rPlayer1.Image = playerCardImg;
                    botTotal += GetCardValue(botCardPath);
                    playerTotal += GetCardValue(playerCardPath);

                }
                else if (playerReveal == 1)
                {
                    rDealer2.Image = folded;
                    rPlayer2.Image = playerCardImg;
                    bot2 = botCardImg;
                    botHiddenCards[0] = bot2;
                    playerTotal += GetCardValue(playerCardPath);
                    botTotal += GetCardValue(botCardPath);

                }

                playerReveal++;
                dealerReveal++;
                displayValues();
            }
        }

        private void rPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            surrenderPanel.Visible = !surrenderPanel.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (currentBet == 0)
            {
                errorSound();
                MessageBox.Show("You must place a bet first!");
                return;
            }

            if (buyinBalance < currentBet)
            {
                errorSound();
                MessageBox.Show("You have insufficient balance to double your bet.");
                return;
            }

            drawCardsSound();
            while (botTotal < 17)
            {
                int botIndex = botRandom.Next(rCards.Count);
                string botCardPath = rCards[botIndex];
                Image botCardImg = Image.FromFile(botCardPath);
                Image folded = Image.FromFile(@"C:\BSIT 1\C#\blackjack\cards\red_backing.png");

                if (dealerReveal == 2)
                {
                    dCardAnimation3.Enabled = true;
                    rDealer3.Image = botCardImg;
                    botHiddenCards[1] = botCardImg;

                }

                else if (dealerReveal == 3)
                {
                    dCardAnimation4.Enabled = true;
                    rDealer4.Image = botCardImg;
                    botHiddenCards[2] = botCardImg;

                }

                botTotal += GetCardValue(botCardPath);
                dealerReveal++;

                if (botTotal >= 17)
                {
                    break;
                }
            }

            int playerIndex = playerRandom.Next(rCards.Count);
            string playerCardPath = rCards[playerIndex];
            Image playerCardImg = Image.FromFile(playerCardPath);


            setValueVisible();

            // ------------------------------- PUT CARDS ON PLAYER'S DECK -----------------------------

            if (playerReveal == 2)
            {
                pCardAnimation3.Enabled = true;
                rPlayer3.Image = playerCardImg;
                playerTotal += GetCardValue(playerCardPath);
            }

            else if (playerReveal == 3)
            {
                pCardAnimation4.Enabled = true;
                rPlayer4.Image = playerCardImg;
                playerTotal += GetCardValue(playerCardPath);
            }

            playerReveal++;
            buyinBalance -= currentBet;
            hiddenCards();
            displayValues();

            if (botTotal > 21 && playerTotal > 21)
            {
                setValueVisible();
                round();
                checkNearestDouble();
            }

            else if (playerTotal == botTotal)
            {
                setValueVisible();
                round();
                matchedDouble();
            }

            else if (playerTotal == 21)
            {
                setValueVisible();
                round();
                playerBlackJackDouble();
            }

            else if (botTotal == 21)
            {
                setValueVisible();
                round();
                dealerBlackJackDouble();
            }

            else if (playerTotal > 21)
            {
                setValueVisible();
                round();
                playerBustedDouble();
            }

            else if (botTotal > 21)
            {
                setValueVisible();
                round();
                dealerBustedDouble();
            }

            else if (playerTotal > botTotal)
            {
                setValueVisible();
                round();
                playerWinnerDouble();
            }

            else if (playerTotal < botTotal)
            {
                setValueVisible();
                round();
                dealerWinnerDouble();
            }

            r_BankRoll.Text = "Balance: " + buyinBalance;
            resetRound();
        }

        private void dealerDialogue_Click(object sender, EventArgs e)
        {

        }

        private void redTimer1_Tick(object sender, EventArgs e)
        {

            if (playerDraw1.Visible)
            {
                if (playerDraw1.Location.X > 334 || playerDraw1.Location.Y < 417)
                {
                    playerDraw1.Location = new Point(
                        playerDraw1.Location.X > 334 ? playerDraw1.Location.X - 10 : playerDraw1.Location.X,
                        playerDraw1.Location.Y < 417 ? playerDraw1.Location.Y + 10 : playerDraw1.Location.Y
                    );
                    return;
                }
                else
                {
                    playerDraw1.Visible = false;
                    rPlayer1.Visible = true;
                }
            }

            // -------------------------------------------------------------------------------------------------------------------
            if (dealerDraw1.Visible)
            {
                if (dealerDraw1.Location.X > 339 || dealerDraw1.Location.Y > 84)
                {
                    dealerDraw1.Location = new Point(
                        dealerDraw1.Location.X > 339 ? dealerDraw1.Location.X - 10 : dealerDraw1.Location.X,
                        dealerDraw1.Location.Y > 84 ? dealerDraw1.Location.Y - 3 : dealerDraw1.Location.Y
                    );
                    return;
                }
                else
                {
                    dealerDraw1.Visible = false;
                    rDealer1.Visible = true;
                }
            }

            if (playerDraw2.Visible)
            {
                if (playerDraw2.Location.X > 409 || playerDraw2.Location.Y < 416)
                {
                    playerDraw2.Location = new Point(
                        playerDraw2.Location.X > 409 ? playerDraw2.Location.X - 8 : playerDraw2.Location.X,
                        playerDraw2.Location.Y < 416 ? playerDraw2.Location.Y + 10 : playerDraw2.Location.Y
                    );
                    return;
                }
                else
                {
                    playerDraw2.Visible = false;
                    rPlayer2.Visible = true;
                }
            }

            if (dealerDraw2.Visible)
            {
                if (dealerDraw2.Location.X > 414 || dealerDraw2.Location.Y > 84)
                {
                    dealerDraw2.Location = new Point(
                        dealerDraw2.Location.X > 414 ? dealerDraw2.Location.X - 10 : dealerDraw2.Location.X,
                        dealerDraw2.Location.Y > 84 ? dealerDraw2.Location.Y - 3 : dealerDraw2.Location.Y
                    );
                    return;
                }
                else
                {
                    dealerDraw2.Visible = false;
                    rDealer2.Visible = true;
                }
            }

            initialDraw.Stop();
        }


        private void hit1_Tick(object sender, EventArgs e)
        {
            if (playerDraw3.Visible)
            {
                if (playerDraw3.Location.X > 484 || playerDraw3.Location.Y < 416)
                {
                    playerDraw3.Location = new Point(
                        playerDraw3.Location.X > 484 ? playerDraw3.Location.X - 10 : playerDraw3.Location.X,
                        playerDraw3.Location.Y < 416 ? playerDraw3.Location.Y + 8 : playerDraw3.Location.Y
                    );
                    return;
                }
                else
                {
                    playerDraw3.Visible = false;
                    rPlayer3.Visible = true;

                }

                initialDraw.Stop();
            }
        }

        private void pCard2_Tick(object sender, EventArgs e)
        {
            if (playerDraw4.Visible)
            {
                if (playerDraw4.Location.X > 559 || playerDraw4.Location.Y < 416)
                {
                    playerDraw4.Location = new Point(
                        playerDraw4.Location.X > 559 ? playerDraw4.Location.X - 10 : playerDraw4.Location.X,
                        playerDraw4.Location.Y < 416 ? playerDraw4.Location.Y + 8 : playerDraw4.Location.Y
                    );
                    return;
                }
                else
                {
                    playerDraw4.Visible = false;
                    rPlayer4.Visible = true;

                }

                initialDraw.Stop();
            }
        }

        private void dCard3_Tick(object sender, EventArgs e)
        {
            if (dealerDraw3.Visible)
            {
                if (dealerDraw3.Location.X > 489 || dealerDraw3.Location.Y < 84)
                {
                    dealerDraw3.Location = new Point(
                        dealerDraw3.Location.X > 489 ? dealerDraw3.Location.X - 10 : dealerDraw3.Location.X,
                        dealerDraw3.Location.Y < 84 ? dealerDraw3.Location.Y + 10 : dealerDraw3.Location.Y
                    );
                    return;
                }
                else
                {
                    dealerDraw3.Visible = false;
                    rDealer3.Visible = true;

                }
            }
        }


        private void dCard4_Tick(object sender, EventArgs e)
        {
            if (dealerDraw4.Visible)
            {
                if (dealerDraw4.Location.X > 564 || dealerDraw4.Location.Y < 84)
                {
                    dealerDraw4.Location = new Point(
                        dealerDraw4.Location.X > 564 ? dealerDraw4.Location.X - 10 : dealerDraw4.Location.X,
                        dealerDraw4.Location.Y < 84 ? dealerDraw4.Location.Y + 10 : dealerDraw4.Location.Y
                    );
                    return;
                }
                else
                {
                    dealerDraw4.Visible = false;
                    rDealer4.Visible = true;
                }
            }
        }

        private void pCardAnimation3_Tick(object sender, EventArgs e)
        {
            if (playerDraw3.Visible)
            {
                if (playerDraw3.Location.X > 484 || playerDraw3.Location.Y < 416)
                {
                    playerDraw3.Location = new Point(
                        playerDraw3.Location.X > 484 ? playerDraw3.Location.X - 10 : playerDraw3.Location.X,
                        playerDraw3.Location.Y < 416 ? playerDraw3.Location.Y + 7 : playerDraw3.Location.Y
                    );
                    return;
                }
                else
                {
                    playerDraw3.Visible = false;
                    rPlayer3.Visible = true;

                }

                pCardAnimation3.Stop();
            }
        }

        private void pCardAnimation4_Tick(object sender, EventArgs e)
        {
            if (playerDraw4.Visible)
            {
                if (playerDraw4.Location.X > 559 || playerDraw4.Location.Y < 416)
                {
                    playerDraw4.Location = new Point(
                        playerDraw4.Location.X > 559 ? playerDraw4.Location.X - 10 : playerDraw4.Location.X,
                        playerDraw4.Location.Y < 416 ? playerDraw4.Location.Y + 7 : playerDraw4.Location.Y
                    );
                    return;
                }
                else
                {
                    playerDraw4.Visible = false;
                    rPlayer4.Visible = true;

                }
                pCardAnimation4.Stop();
            }
        }

        private bool shouldRunDCard4 = false;


        private void dCardAnimation3_Tick(object sender, EventArgs e)
        {
            if (dealerDraw3.Visible)
            {
                if (dealerDraw3.Location.X > 489 || dealerDraw3.Location.Y < 84)
                {
                    dealerDraw3.Location = new Point(
                        dealerDraw3.Location.X > 489 ? dealerDraw3.Location.X - 10 : dealerDraw3.Location.X,
                        dealerDraw3.Location.Y < 84 ? dealerDraw3.Location.Y + 10 : dealerDraw3.Location.Y
                    );
                    return;
                }
                else
                {
                    dealerDraw3.Visible = false;
                    rDealer3.Visible = true;

                    dCardAnimation3.Stop();

                    // Start the second animation ONLY if needed
                    if (shouldRunDCard4)
                    {
                        dCardAnimation4.Start();
                        shouldRunDCard4 = false; // Reset the flag
                    }
                }
            }
        }


        private void dCardAnimation4_Tick(object sender, EventArgs e)
        {
            if (dealerDraw4.Visible)
            {
                if (dealerDraw4.Location.X > 564 || dealerDraw4.Location.Y < 84)
                {
                    dealerDraw4.Location = new Point(
                        dealerDraw4.Location.X > 564 ? dealerDraw4.Location.X - 10 : dealerDraw4.Location.X,
                        dealerDraw4.Location.Y < 84 ? dealerDraw4.Location.Y + 10 : dealerDraw4.Location.Y
                    );
                    return;
                }
                else
                {
                    dealerDraw4.Visible = false;
                    rDealer4.Visible = true;
                }
                dCardAnimation4.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void returnBet_Click(object sender, EventArgs e)
        {
            buyinBalance += latestBet;
            currentBet -= latestBet;
            rBet.Text = "Round Bet : " + currentBet.ToString();
            r_BankRoll.Text = "Bankroll : " + buyinBalance.ToString();
        }

        private void returnAllBet_Click(object sender, EventArgs e)
        {
            buyinBalance += currentBet;
            currentBet = 0;
            rBet.Text = "Round Be t: 0";
            r_BankRoll.Text = "Bankroll : " + buyinBalance.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            buyinBalance += latestBet;
            currentBet -= latestBet;
            rBet.Text = "Round Bet : 0";
        }

        private void returnTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void returnAllTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void rDealer2_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            surrenderPanel.Hide();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is mainGameForm mainForm)
            {
                mainForm.ReturnToCarousel();
            }
        }

        private void playerDraw4_Click(object sender, EventArgs e)
        {

        }
    }
}
