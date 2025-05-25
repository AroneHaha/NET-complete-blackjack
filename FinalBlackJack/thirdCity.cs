using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            roundOver = false;
            playerHasStood = false;

            botHiddenCards[0] = null;
            botHiddenCards[1] = null;
            botHiddenCards[2] = null;


            rBet.Text = "Bet : " + currentBet.ToString();
        }

        private void resetCardDraw()
        {
            isDrawn = false;
            startRound.Visible = true;
            playerReveal = 0;
            dealerReveal = 0;

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
                MessageBox.Show("Player's the nearest to 21, you won!");
                ingameWinnings += currentBet;
                r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
                AccountData.accountsBalance[AccountData.currentAccount] += currentBet;
            }
            else
            {
                roundLoserSound();
                MessageBox.Show("Dealer's the nearest to 21, Dealer won!");
                ingameWinnings -= currentBet;
                r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
                AccountData.accountsBalance[AccountData.currentAccount] -= currentBet;
            }
            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            resetCardDraw();
            resetRound();
            return;
        }

        private void checkNearestDouble()
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
                MessageBox.Show("Player's the nearest to 21, you won!");
                ingameWinnings += currentBet;
                r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
                AccountData.accountsBalance[AccountData.currentAccount] += (currentBet * 2);
            }
            else
            {
                roundLoserSound();
                MessageBox.Show("Dealer's the nearest to 21, Dealer won!");
                ingameWinnings -= currentBet;
                r_totalWinnings.Text = "Winnings: " + ingameWinnings.ToString();
                AccountData.accountsBalance[AccountData.currentAccount] -= (currentBet * 2);
            }
            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            resetCardDraw();
            resetRound();
            return;
        }

        private void playerWinner()
        {
            roundWinnerSound();
            MessageBox.Show("Player wins!");
            roundOver = true;
            ingameWinnings += currentBet;
            AccountData.accountsBalance[AccountData.currentAccount] += currentBet;
            resetCardDraw();
            resetRound();
            return;
        }

        private void playerWinnerDouble()
        {
            roundWinnerSound();
            MessageBox.Show("Player wins!");
            roundOver = true;
            ingameWinnings += currentBet;
            AccountData.accountsBalance[AccountData.currentAccount] += (currentBet * 2);
            resetCardDraw();
            resetRound();
            return;
        }

        private void dealerWinner()
        {
            roundWinnerSound();
            MessageBox.Show("Dealer wins!");
            roundOver = true;
            ingameWinnings -= currentBet;
            AccountData.accountsBalance[AccountData.currentAccount] -= currentBet;
            resetCardDraw();
            resetRound();
            return;
        }

        private void dealerWinnerDouble()
        {
            roundWinnerSound();
            MessageBox.Show("Dealer wins!");
            roundOver = true;
            ingameWinnings -= currentBet;
            AccountData.accountsBalance[AccountData.currentAccount] -= (currentBet * 2);
            resetCardDraw();
            resetRound();
            return;
        }

        private void playerBusted()
        {
            roundLoserSound();
            hiddenCards();
            roundOver = true;

            MessageBox.Show("Player's busted, Dealer won!");
            AccountData.accountsBalance[AccountData.currentAccount] -= currentBet;
            ingameWinnings -= currentBet;
            r_totalWinnings.Text = "Winnings : " + ingameWinnings.ToString();
            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            resetCardDraw();
            resetRound();
            return;
        }

        private void playerBustedDouble()
        {
            roundLoserSound();
            hiddenCards();
            roundOver = true;

            MessageBox.Show("Player's busted, Dealer won!");
            AccountData.accountsBalance[AccountData.currentAccount] -= (currentBet * 2);
            ingameWinnings -= currentBet;
            r_totalWinnings.Text = "Winnings : " + ingameWinnings.ToString();
            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            resetCardDraw();
            resetRound();
            return;
        }

        private void dealerBusted()
        {
            roundWinnerSound();
            hiddenCards();
            roundOver = true;

            MessageBox.Show("Dealer's busted, Player won!");
            AccountData.accountsBalance[AccountData.currentAccount] += currentBet;
            ingameWinnings += currentBet;
            r_totalWinnings.Text = "Winnings : " + ingameWinnings.ToString();
            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            resetCardDraw();
            resetRound();
            return;
        }

        private void dealerBustedDouble()
        {
            roundWinnerSound();
            hiddenCards();
            roundOver = true;

            MessageBox.Show("Dealer's busted, Player won!");
            AccountData.accountsBalance[AccountData.currentAccount] += (currentBet * 2);
            ingameWinnings += currentBet;
            r_totalWinnings.Text = "Winnings : " + ingameWinnings.ToString();
            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            resetCardDraw();
            resetRound();
            return;
        }

        private void addChips(int bet)
        {
            chipsSound();
            currentBet += bet;
            rBet.Text = "Bet : " + currentBet.ToString();
        }

        private void round()
        {
            ingameRound++;
            currentRound.Text = "Round : " + ingameRound.ToString();
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

        public int playerBalance = 0;
        public int currentBet = 0;
        public int ingameWinnings = 0;

        private bool roundOver = false;
        private bool playerHasStood = false;
        private bool isDrawn = false;

        private int ingameRound = 1;


        // ----------------------------- BOT IMAGES ------------------------------------------
        public Image bot1;
        public Image bot2;
        public Image bot3;
        public Image bot4;
        public Image[] botHiddenCards = new Image[3];

        string currentUser = AccountData.usernames[AccountData.currentAccount];


        public singaporePanel()
        {
            InitializeComponent();
            this.Load += singaporePanel_Load;
            currentRound.Text = "Round : " + ingameRound;

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
            r_BankRoll.Text = "Balance : " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
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
            rChip25.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\25ChipHover.png");
        }

        private void rChip25_Click(object sender, EventArgs e)
        {
            addChips(25);
        }

        private void rChip25_MouseLeave(object sender, EventArgs e)
        {
            rChip25.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\25Chip.png");
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rChip1_MouseEnter(object sender, EventArgs e)
        {
            rChip1.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\1ChipHover.png");
        }

        private void rChip1_MouseLeave(object sender, EventArgs e)
        {
            rChip1.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\1Chip.png");
        }

        private void rChip5_MouseEnter_1(object sender, EventArgs e)
        {
            rChip5.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\5ChipHover.png");
        }

        private void rChip5_MouseLeave_1(object sender, EventArgs e)
        {
            rChip5.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\5Chip.png");
        }

        private void rChip50_MouseEnter_1(object sender, EventArgs e)
        {
            rChip50.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\50ChipHover.png");
        }

        private void rChip50_MouseLeave_1(object sender, EventArgs e)
        {
            rChip50.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\50Chip.png");
        }

        private void rChip10_MouseEnter_1(object sender, EventArgs e)
        {
            rChip10.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\10ChipHover.png");
        }

        private void rChip10_MouseLeave_1(object sender, EventArgs e)
        {
            rChip10.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\10Chip.png");
        }

        private void rChip100_MouseEnter_1(object sender, EventArgs e)
        {
            rChip100.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\100ChipHover.png");
        }

        private void rChip100_MouseLeave(object sender, EventArgs e)
        {
            rChip100.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\chips\100Chip.png");
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

            if (playerReveal >= 4)
            {
                errorSound();
                MessageBox.Show("You already drew 4 cards!");
                return;
            }

            drawCardsSound();
            botValue.Text = botTotal.ToString();
            playerValue.Text = playerTotal.ToString();

            int playerIndex = playerRandom.Next(rCards.Count);
            string playerCardPath = rCards[playerIndex];
            Image playerCardImg = Image.FromFile(playerCardPath);

            // ------------------------------- PUT CARDS ON PLAYER'S DECK -----------------------------

            if (playerReveal == 2)
            {
                rPlayer3.Image = playerCardImg;
                playerTotal += GetCardValue(playerCardPath);

            }

            else if (playerReveal == 3)
            {
                rPlayer4.Image = playerCardImg;
                playerTotal += GetCardValue(playerCardPath);
            }

            playerReveal++;

            // ------------------------------- CHECK IF DEALER STILL HAS BELOW 17 CARD VALUE ------------------------------------------
            // PUT DEALER'S CARD INSIDE HIDDENCARDS ARRAY PARA MA-STORE YUNG IREREVEAL LATER

            if (botTotal < 17)
            {
                int botIndex = botRandom.Next(rCards.Count);
                string botCardPath = rCards[botIndex];
                Image botCardImg = Image.FromFile(botCardPath);
                Image folded = Image.FromFile(@"C:\BSIT 1\C#\blackjack\cards\folded.png");

                if (dealerReveal == 2)
                {
                    rDealer3.Image = folded;
                    bot3 = botCardImg;
                    botHiddenCards[1] = bot3;
                    botTotal += GetCardValue(botCardPath);
                }
                else if (dealerReveal == 3)
                {
                    rDealer4.Image = folded;
                    bot4 = botCardImg;
                    botHiddenCards[2] = bot4;
                    botTotal += GetCardValue(botCardPath);
                }
            }
            
            dealerReveal++;


            // --------------------------------------- VERIFY THE WINNER -------------------------------------
            if (playerTotal > 21 && botTotal > 21) // -------------------------------------- IF BOTH BUSTED -------------------------------------------------------
            {
                hiddenCards();
                botValue.Text = botTotal.ToString();
                playerValue.Text = playerTotal.ToString();
                round();
                checkNearest();
            }

            else if (botTotal > 21) // ------------------------- IF DEALER'S BUSTED ----------------------------------------
            {
                hiddenCards();
                    botValue.Text = botTotal.ToString();
                    playerValue.Text = playerTotal.ToString();
                round();
                dealerBusted();
            }

            else if (playerTotal > 21)
            {
                hiddenCards();
                botValue.Text = botTotal.ToString();
                playerValue.Text = playerTotal.ToString();
                round();
                playerBusted();
            }
        }

        private void rChip1_Click(object sender, EventArgs e)
        {
            addChips(1);
        }

        private void rChip5_Click(object sender, EventArgs e)
        {
            addChips(5);
        }

        private void rChip50_Click(object sender, EventArgs e)
        {
            addChips(50);
        }

        private void rChip10_Click(object sender, EventArgs e)
        {
            addChips(10);
        }

        private void rChip100_Click(object sender, EventArgs e)
        {
            addChips(100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
    // ----------------------- REVEAL ALL CARDS ASAP TO AVOID ANY CONFLICT DURING COMPILATION OF RESULTS -------------------------------------------

            if (playerReveal <= 1)
            {
                errorSound();
                MessageBox.Show("You need at least 2 cards to stand.");
                return;
            }

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
                Image folded = Image.FromFile(@"C:\BSIT 1\C#\blackjack\cards\folded.png");



                if (dealerReveal == 2)
                {
                    rDealer3.Image = botCardImg;
                    botHiddenCards[1] = botCardImg;

                }

                else if (dealerReveal == 3)
                {
                    rDealer4.Image = botCardImg;
                    botHiddenCards[2] = botCardImg;

                }

                botTotal += GetCardValue(botCardPath);
                dealerReveal++;
                botValue.Text = botTotal.ToString();
                playerValue.Text = playerTotal.ToString();

                if (botTotal >= 17)
                {
                    break;
                }
            }

            hiddenCards();

            if (botTotal > 21 && playerTotal > 21)
            {
                round();
                checkNearest();
            }

            else if (playerTotal > 21)
            {
                
                round();
                playerBusted();
            }

            else if (botTotal > 21)
            {
                round();
                dealerBusted();
            }

            else if (playerTotal > botTotal)
            {
                round();
                playerWinner();
            }

            else if (playerTotal < botTotal)
            {
                round();
                dealerWinner();
            }

            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawCardsSound();
            isDrawn = true;
            startRound.Visible = false;


            while (playerReveal != 2 && dealerReveal != 2)
            {
                int botIndex = botRandom.Next(rCards.Count);
                string botCardPath = rCards[botIndex];
                Image botCardImg = Image.FromFile(botCardPath);
                Image folded = Image.FromFile(@"C:\BSIT 1\C#\blackjack\cards\folded.png");

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
                botValue.Text = botTotal.ToString();
                playerValue.Text = playerTotal.ToString();
                
            }
        }

        private void rPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is mainGameForm mainForm)
            {
                mainForm.ReturnToCarousel();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawCardsSound();

            int playerIndex = playerRandom.Next(rCards.Count);
            string playerCardPath = rCards[playerIndex];
            Image playerCardImg = Image.FromFile(playerCardPath);

            // ------------------------------- PUT CARDS ON PLAYER'S DECK -----------------------------

            if (playerReveal == 2)
            {
                rPlayer3.Image = playerCardImg;
                playerTotal += GetCardValue(playerCardPath);
            }

            else if (playerReveal == 3)
            {
                rPlayer4.Image = playerCardImg;
                playerTotal += GetCardValue(playerCardPath);
            }

            hiddenCards();

            if (botTotal > 21 && playerTotal > 21)
            {
                round();
                checkNearestDouble();
            }

            else if (playerTotal > 21)
            {
                round();
                playerBustedDouble();

            }

            else if (botTotal > 21)
            {
                round();
                dealerBustedDouble();
            }

            else if (playerTotal > botTotal)
            {
                round();
                playerWinnerDouble();
            }

            else if (playerTotal < botTotal)
            {
                round();
                dealerWinnerDouble();
            }

            r_BankRoll.Text = "Balance: " + AccountData.accountsBalance[AccountData.currentAccount].ToString();
            resetRound();
        }
    }
}
