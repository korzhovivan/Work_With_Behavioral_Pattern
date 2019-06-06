using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class SportsMen
    {
        protected int Score { get; set; } = 1000;
        protected int Hits { get; set; }
        protected int Seconds { get; set; }

        public SportsMen() { }

        public int CountScore()
        {
            Score = this.GetScoreByHits() - this.GetScoreBySeconds();
            Console.WriteLine("Score: "+Score);
            if (Score<=0)
            {
                Score = 0;
            }
            return Score;
            
        }
        public abstract int GetScoreByHits();
        public abstract int GetScoreBySeconds();
        
    }
    class Men : SportsMen
    {
        public Men(int hits,int seconds)
        {
            this.Hits = hits;
            this.Seconds = seconds;
        }
        public override int GetScoreByHits()
        {
            return 100 * Hits;
        }

        public override int GetScoreBySeconds()
        {
            return 5 * Seconds;
        }
    }
    class Women : SportsMen
    {
        public Women(int hits, int seconds)
        {
            this.Hits = hits;
            this.Seconds = seconds;
        }
        public override int GetScoreByHits()
        {
            return 100 * Hits;
        }

        public override int GetScoreBySeconds()
        {
            return 4 * Seconds;
        }
    }
    class Child : SportsMen
    {
        public Child(int hits, int seconds)
        {
            this.Hits = hits;
            this.Seconds = seconds;
        }
        public override int GetScoreByHits()
        {
            return 200 * Hits;
        }

        public override int GetScoreBySeconds()
        {
            return 2 * Seconds;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Men men = new Men(4, 36);
            Women women = new Women(4, 36);
            Child child = new Child(4, 36);

            men.CountScore();
            women.CountScore();
            child.CountScore();

            Console.ReadKey();
        }
    }

}
