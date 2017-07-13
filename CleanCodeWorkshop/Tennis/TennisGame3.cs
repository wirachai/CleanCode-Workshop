using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeWorkshop.Tennis
{
    public class TennisGame3
    {
        private int p2;
        private int p1;
        private string p1N;
        private string p2N;

        public TennisGame3(int p1, int p2)
        {
            this.p1N = "player1";
            this.p2N = "player2";
            this.p1 = p1;
            this.p2 = p2;
        }

        public string GetScore()
        {
            string s;
            if ((p1 < 3 && p2 < 3) && (p1 + p2 < 6))
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                s = p[p1];
                return (p1 == p2) ? s + "-All" : s + "-" + p[p2];
            }
            else
            {
                if (p1 == p2)
                    return "Deuce";
                s = p1 > p2 ? p1N : p2N;
                return ((p1 - p2) * (p1 - p2) == 2) ? "Advantage " + s : "Win for " + s;
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this.p1 += 1;
            else
                this.p2 += 1;
        }

    }
}
