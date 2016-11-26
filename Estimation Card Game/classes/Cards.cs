using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimation.classes
{
    class Cards
    {
        public List<KeyValuePair<string, int>> Clubs = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string, int>> Diamond = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string, int>> Hearts = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string, int>> Spades = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string, int>> player1 = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string, int>> player2 = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string, int>> player3 = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string, int>> player4 = new List<KeyValuePair<string, int>>();

        public void cards()
        {
            //clubs cards
            Clubs.Add(new KeyValuePair<string, int>("Clubs/AC", 14));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/2C", 2));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/3C", 3));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/4C", 4));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/5C", 5));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/6C", 6));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/7C", 7));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/8C", 8));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/9C", 9));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/10C", 10));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/JC", 11));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/QC", 12));
            Clubs.Add(new KeyValuePair<string, int>("Clubs/KC", 13));

            //Diamond cards

            Diamond.Add(new KeyValuePair<string, int>("Diamonds/AD", 14));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/2D", 2));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/3D", 3));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/4D", 4));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/5D", 5));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/6D", 6));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/7D", 7));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/8D", 8));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/9D", 9));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/10D", 10));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/JD", 11));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/QD", 12));
            Diamond.Add(new KeyValuePair<string, int>("Diamonds/KD", 13));

            //Hearts cards
            Hearts.Add(new KeyValuePair<string, int>("Hearts/AH", 14));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/2H", 2));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/3H", 3));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/4H", 4));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/5H", 5));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/6H", 6));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/7H", 7));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/8H", 8));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/9H", 9));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/10H", 10));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/JH", 11));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/QH", 12));
            Hearts.Add(new KeyValuePair<string, int>("Hearts/KH", 13));

            //Spades cards
            Spades.Add(new KeyValuePair<string, int>("Spades/AS", 14));
            Spades.Add(new KeyValuePair<string, int>("Spades/2S", 2));
            Spades.Add(new KeyValuePair<string, int>("Spades/3S", 3));
            Spades.Add(new KeyValuePair<string, int>("Spades/4S", 4));
            Spades.Add(new KeyValuePair<string, int>("Spades/5S", 5));
            Spades.Add(new KeyValuePair<string, int>("Spades/6S", 6));
            Spades.Add(new KeyValuePair<string, int>("Spades/7S", 7));
            Spades.Add(new KeyValuePair<string, int>("Spades/8S", 8));
            Spades.Add(new KeyValuePair<string, int>("Spades/9S", 9));
            Spades.Add(new KeyValuePair<string, int>("Spades/10S", 10));
            Spades.Add(new KeyValuePair<string, int>("Spades/JS", 11));
            Spades.Add(new KeyValuePair<string, int>("Spades/QS", 12));
            Spades.Add(new KeyValuePair<string, int>("Spades/KS", 13));
        }
        public void SpreadIntoList()
        {
            //insert all the cards into one list randomly 
            Random rnd = new Random();

            int temp = 0;
            for (int i = 1; i <= 13; i++)
            {
                int r = rnd.Next(Spades.Count);

                if (list.Any(e => e.Key == Spades[r].Key))
                    temp = 1;
                else
                    temp = 0;

                if (temp == 0)
                {
                    list.Add(Spades[r]);
                    Spades.Remove(Spades[r]);
                }
            }

            for (int i = 1; i <= 13; i++)
            {
                int r = rnd.Next(Clubs.Count);

                if (list.Any(e => e.Key == Clubs[r].Key))
                    temp = 1;
                else
                    temp = 0;

                if (temp == 0)
                {
                    list.Add(Clubs[r]);
                    Clubs.Remove(Clubs[r]);
                }
            }
            for (int i = 1; i <= 13; i++)
            {
                int r = rnd.Next(Hearts.Count);

                if (list.Any(e => e.Key == Hearts[r].Key))
                    temp = 1;
                else
                    temp = 0;

                if (temp == 0)
                {
                    list.Add(Hearts[r]);
                    Hearts.Remove(Hearts[r]);
                }
            }
            for (int i = 1; i <= 13; i++)
            {
                int r = rnd.Next(Diamond.Count);

                if (list.Any(e => e.Key == Diamond[r].Key))
                    temp = 1;
                else
                    temp = 0;

                if (temp == 0)
                {
                    list.Add(Diamond[r]);
                    Diamond.Remove(Diamond[r]);
                }
            }

        }

        public void Lists()
        {
            //four players lists

            Random rnd = new Random();
            int temp = 0;
            //spread the cards to the four players randomly
            int v = 0;
            //  Console.WriteLine("list.count" + list.Count);
            while (v < 13)
            {
                int r = rnd.Next(list.Count);
                if (player1.Any(e => e.Key == list[r].Key))
                    temp = 1;
                else
                    temp = 0;

                if (temp == 0)
                {
                    player1.Add(list[r]);
                    list.Remove(list[r]);
                    v++;
                }

            }
            int k = 0;
            while (k < 13)
            {
                int r = rnd.Next(list.Count);
                if (player2.Any(e => e.Key == list[r].Key))
                    temp = 1;
                else
                    temp = 0;

                if (temp == 0)
                {
                    player2.Add(list[r]);
                    list.Remove(list[r]);
                    k++;
                }

            }

            int j = 0;
            while (j < 13)
            {
                int r = rnd.Next(list.Count);
                if (player3.Any(e => e.Key == list[r].Key))
                    temp = 1;
                else
                    temp = 0;

                if (temp == 0)
                {
                    player3.Add(list[r]);
                    list.Remove(list[r]);
                    j++;
                }

            }
            int m = 0;
            while (m < 13)
            {
                int r = rnd.Next(list.Count);
                if (player4.Any(e => e.Key == list[r].Key))
                    temp = 1;
                else
                    temp = 0;

                if (temp == 0)
                {
                    player4.Add(list[r]);
                    list.Remove(list[r]);
                    m++;
                }

            }

        }

    }
}
