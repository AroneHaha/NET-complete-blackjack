using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Dmo;

namespace FinalBlackJack
{
    internal class dialogues
    {

        public static int dialogueIndex = 0;

        public static List<string> startGame = new List<string>
        {
            "\"Bets in, cards out!\"",
            "\"Let’s shuffle and deal!\"",
            "\"Cards are dealt, game on!\"",
            "\"Don’t be shy, play like you mean it.\"",
            "\"You better have a plan or lose fast.\"",
            "\"Let’s kick off this round!\"",
            "\"Get ready, here comes the deal!\"",
            "\"All eyes on you—don’t choke\"",
            "\"Let’s see if you’re bold or just lucky.\"",
            "\"Stakes are raised, bets are placed.\""
        };

        public static List<string> bustDialoguesLose = new List<string>
        {
            "\"Busted! Better luck next time.\"",
            "\"House wins again!\"",
            "\"Really? Chasing the 21?\"",
            "\"Ouch, that’s a hard lesson.\"",
            "\"Trying to impress me? Not working.\"",
            "\"That’s a bust, my friend.\"",
            "\"You're walking on thin ice, pal.\"",
            "\"Dogwalked by the dealer, shame on you.\"",
            "\"Maybe next round, your 21 will show up.\"",
            "\"You played too risky and lost.\"",
            "\"That’s a tough break, you busted.\""
        };

        public static List<string> bustDialoguesWin = new List<string>
        {
            "\"Your risk paid off.\"",
            "\"Hug your cards, you might need it next round.\"",
            "\"You’ve got the magic touch.\"",
            "\"Sticking up on luck is your asset, I see.\"",
            "\"Can’t argue with that win!\"",
            "\"Never do that again, remember it.\"",
            "\"You’re making this interesting.\"",
            "\"Gutsy player, just like what I'm looking for!\"",
            "\"You earned the chips on the table.\"",
            "\"Risk it all, win it all!\"",
            "\"Wildcard luckily revealed, just this time.\"",
            "\"I'll give to you, you got \nheart right there.\"",
        };

        public static List<string> hitDialogues = new List<string>
        {
            "\"Place your bets!\"",
            "\"Let’s see what fate \nhas for you.\"",
            "\"Here comes the heat!\"",
            "\"Feeling lucky, huh?\"",
            "\"Bold move—I like it!\"",
            "\"Let’s see where this leads.\"",
            "\"Could be magic, could be disaster.\"",
            "\"That’s a gutsy call!\"",
            "\"Fortune favors the brave.\"",
            "\"High risk, high reward.\"",
            "\"Don’t say I didn’t warn you.\"",
            "\"Let’s chase that 21!\"",
            "\"A swing and a miss incoming.\"",
            "\"That ego’s gonna get you busted.\"",
            "\"Hit or stand?\"",
            "\"Your move—what’s it gonna be?\""
        };

        public static List<string> standWinDialogues = new List<string>
        {
            "\"I’ll give you this round.\"",
            "\"An inch away from the cliff, lucky.\"",
            "\"Tough luck!\"",
            "\"Playing it safe, I see.\"",
            "\"Standing? I expected more fire.\"",
            "\"You’ve got patience—good call.\"",
            "\"Don’t let it get to your head.\"",
            "\"You’re reading the table well.\"",
            "\"The cards favor you today.\"",
            "\"Enjoy that win, it’s rare.\"",
            "\"Fluke or skill? I’m betting fluke.\"",
            "\"The winner takes it all!\"",
            "\"You outsmarted the dealer.\"",
            "\"Next hand’s where I get you.\""
        };

        public static List<string> standLoseDialogues = new List<string>
        {
            "\"Told you the house always wins.\"",
            "\"Nice try, Dealer won by an inch!\"",
            "\"Don’t cry, it’s just a game... for me.\"",
            "\"Almost had me there!\"",
            "\"So close, yet so far.\"",
            "\"You can surrender anytime, just saying...\"",
            "\"A for effort, F for result.\"",
            "\"I hope you’re not betting the rent.\"",
            "\"Maybe next time you’ll think twice.\"",
            "\"I’ll give you points for trying.\""
        };

    }
}
