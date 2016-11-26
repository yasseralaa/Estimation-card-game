using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Popups;
using Windows.UI;
using Windows.UI.Xaml.Media.Animation;
using Estimation.classes;
using Cards_Windows.classes;
using Windows.UI.Text;
using System.Diagnostics;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App1
{
  
   class dash
   {
     public static int dashcall1;
     public static int dashcall2;
     public static int dashcall3;
     public static int dashcall4;
   }
   class bids
   {
       public static string sort;
       public static int counter;
       public static int pass;
       public static int dashCall;
       public static string shapShow;
       public static int highlybid;
       public static int passTapped;
       public static int allBids;
       public static int bigBidAgain;
       public static int recheckBids;
       public static int resForOne;
       public static int resForTwo;
       public static int resForThree;
       public static int resForFour;
       public static int LastBid1;
       public static int LastBid2;
       public static int LastBid3;
       public static int LastBid4;
   }

   class OnGame
   {
       public static string CardRoundKind;
       public static string Kind;
       public static int hand;
       public static int Gcounter;
       public static int p1num;
       public static string p1Sort;
       public static int p2num;
       public static string p2Sort;
       public static int p3num;
       public static string p3Sort;
       public static int p4num;
       public static string p4Sort;
       public static int collapse40;
       public static int collapse41;
       public static int collapse42;
       public static int collapse43;
       public static int collapse44;
       public static int collapse45;
       public static int collapse46;
       public static int collapse47;
       public static int collapse48;
       public static int collapse49;
       public static int collapse50;
       public static int collapse51;
       public static int collapse52;
       public static int p1counter;
       public static int p2counter;
       public static int p3counter;
       public static int p4counter;
       public static int GameFinish;
       public static int BidsWinner;
   }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Game : Page
    {
        public Game()
        {
            this.InitializeComponent();
            
        }
        bool flag = false;
        Counter counter = new Counter();
        Cards cardObj = new Cards();
        ////related to method 2
       //for check bid or dashcall
        int dash1 = 0;
        int dash2 = 0;
        int dash3 = 0;

        //for check bid or pass
        int bid1 = 0;
        int bid2 = 0;
        int bid3 = 0;
        int bid11 = 0;
        int bid22 = 0;
        int bid33 = 0;
        int pointermov40 = 0;
        int pointermov41 = 0;
        int pointermov42 = 0;
        int pointermov43 = 0;
        int pointermov44 = 0;
        int pointermov45 = 0;
        int pointermov46 = 0;
        int pointermov47 = 0;
        int pointermov48 = 0;
        int pointermov49 = 0;
        int pointermov50 = 0;
        int pointermov51 = 0;
        int pointermov52 = 0;
        ///// <summary>
        ///// Invoked when this page is about to be displayed in a Frame.
        ///// </summary>
        ///// <param name="e">Event data that describes how this page was reached.
        ///// This parameter is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            OnGame.hand = 0;
            bids.passTapped = 0;
            bids.allBids = 0;
            bids.bigBidAgain = 0;
            bids.recheckBids = 0;
            bids.dashCall = 0;
            dash.dashcall1 = 0;
            dash.dashcall2 = 0;
            dash.dashcall3 = 0;
            dash.dashcall4 = 0;
            bids.resForOne = 0;
            bids.resForTwo = 0;
            bids.resForThree = 0;
            bids.resForFour = 0;
            bids.LastBid1 = 0;
            bids.LastBid2 = 0;
            bids.LastBid3 = 0;
            bids.LastBid4 = 0;
           bids.sort = null;
      bids.counter = 0;
       bids.pass = 0;
       bids.dashCall = 0;
       bids.shapShow = null;
       bids.highlybid = 0;
       bids.passTapped = 0;
       bids.allBids = 0;
      bids.bigBidAgain = 0;
       bids.recheckBids = 0;
       bids.resForOne = 0;
       bids.resForTwo = 0;
       bids.resForThree = 0;
       bids.resForFour = 0;
       bids.LastBid1 = 0;
       bids.LastBid2 = 0;
       bids.LastBid3 = 0;
       bids.LastBid4 = 0;
       OnGame.CardRoundKind = null;
       OnGame.Kind = null;
       OnGame.hand = 0;
       OnGame.Gcounter = 0;
       OnGame.p1num = 0;
       OnGame.p1Sort = null;
       OnGame.p2num = 0;
       OnGame.p2Sort = null;
       OnGame.p3num = 0;
       OnGame.p3Sort = null;
       OnGame.p4num = 0;
       OnGame.p4Sort = null;
       OnGame.collapse40 = 0;
       OnGame.collapse41 = 0;
       OnGame.collapse42 = 0;
       OnGame.collapse43 = 0;
       OnGame.collapse44 = 0;
       OnGame.collapse45 = 0;
       OnGame.collapse46 = 0;
       OnGame.collapse47=0;
       OnGame.collapse48=0;
       OnGame.collapse49=0;
       OnGame.collapse50=0;
       OnGame.collapse51=0;
       OnGame.collapse52=0;
       OnGame.p1counter=0;
       OnGame.p2counter=0;
       OnGame.p3counter=0;
       OnGame.p4counter=0;
       OnGame.GameFinish=0;
       OnGame.BidsWinner=0;
            cardsSpread();
            await Task.Delay(TimeSpan.FromSeconds(5));
            player1.Visibility = Visibility.Visible;
            player2.Visibility = Visibility.Visible;
            player3.Visibility = Visibility.Visible;
            you.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(2));
            ListsOfStacks();
            
                Avoid();
            
            
         

        }
       
          #region for Cards animations if hover
        private void card40_PointerMoved(object sender, RoutedEventArgs e)
        {
            
            if (flag == true)
            {
                if (sender == card40 && pointermov40 ==0)
                    card40.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card41 && pointermov41 == 0)
                    card41.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card42 && pointermov42 == 0)
                    card42.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card43 && pointermov43 == 0)
                    card43.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card44 && pointermov44 == 0)
                    card44.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card45 && pointermov45 == 0)
                    card45.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card46 && pointermov46 == 0)
                    card46.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card47 && pointermov47 == 0)
                    card47.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card48 && pointermov48 == 0)
                    card48.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card49 && pointermov49 == 0)
                    card49.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card50 && pointermov50 == 0)
                    card50.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card51 && pointermov51 == 0)
                    card51.Margin = new Thickness(520, 480, 615, 40);

                else if (sender == card52 && pointermov52 == 0)
                    card52.Margin = new Thickness(520, 480, 615, 40);

            }

        }

        private async void card40_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            
            if (flag == true)
            {
                await Task.Delay(TimeSpan.FromSeconds(0.25));

                if (sender == card40)
                    card40.Margin = new Thickness(585, 469, 621, 88);

                else if (sender == card41)
                    card41.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card42)
                    card42.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card43)
                    card43.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card44)
                    card44.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card45)
                    card45.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card46)
                    card46.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card47)
                    card47.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card48)
                    card48.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card49)
                    card49.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card50)
                    card50.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card51)
                    card51.Margin = new Thickness(585, 469, 621, 88);
                else if (sender == card52)
                    card52.Margin = new Thickness(585, 469, 621, 88);
            }
                
          
        }
        #endregion
        //this method for add stackpanels to lists
        #region Lists of stack panels
        List<StackPanel> P1 = new List<StackPanel>();
         List<StackPanel> P2 = new List<StackPanel>();
        List<StackPanel> P3 = new List<StackPanel>();
        List<KeyValuePair<StackPanel, string>> P4 = new List<KeyValuePair<StackPanel, string>>();
      List<KeyValuePair<int, Image>> xxx = new List<KeyValuePair<int, Image>>();
      public List<KeyValuePair<string, int>> player1C = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player1D = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player1S = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player1H = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player2C = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player2D = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player2S = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player2H = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player3C = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player3D = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player3S = new List<KeyValuePair<string, int>>();
      public List<KeyValuePair<string, int>> player3H = new List<KeyValuePair<string, int>>();
        void ListsOfStacks()
        {
            P1.Add(card1);
            P1.Add(card2);
            P1.Add(card3);
            P1.Add(card4);
            P1.Add(card5);
            P1.Add(card6);
            P1.Add(card7);
            P1.Add(card8);
            P1.Add(card9);
            P1.Add(card10);
            P1.Add(card11);
            P1.Add(card12);
            P1.Add(card13);

            P2.Add(card14);
            P2.Add(card15);
            P2.Add(card16);
            P2.Add(card17);
            P2.Add(card18);
            P2.Add(card19);
            P2.Add(card20);
            P2.Add(card21);
            P2.Add(card22);
            P2.Add(card23);
            P2.Add(card24);
            P2.Add(card25);
            P2.Add(card26);

            P3.Add(card27);
            P3.Add(card28);
            P3.Add(card29);
            P3.Add(card30);
            P3.Add(card31);
            P3.Add(card32);
            P3.Add(card33);
            P3.Add(card34);
            P3.Add(card35);
            P3.Add(card36);
            P3.Add(card37);
            P3.Add(card38);
            P3.Add(card39);

            

            for (int i = 0; i < cardObj.player1.Count; i++)
            {
                if ((char)cardObj.player1[i].Key[0] == 'C')
                    player1C.Add(cardObj.player1[i]);
               else if ((char)cardObj.player1[i].Key[0] == 'S')
                    player1S.Add(cardObj.player1[i]);
               else if ((char)cardObj.player1[i].Key[0] == 'D')
                    player1D.Add(cardObj.player1[i]);
               else if ((char)cardObj.player1[i].Key[0] == 'H')
                    player1H.Add(cardObj.player1[i]);
            }

            for (int i = 0; i < cardObj.player2.Count; i++)
            {
                if ((char)cardObj.player2[i].Key[0] == 'C')
                    player2C.Add(cardObj.player2[i]);
                else if ((char)cardObj.player2[i].Key[0] == 'S')
                    player2S.Add(cardObj.player2[i]);
                else if ((char)cardObj.player2[i].Key[0] == 'D')
                    player2D.Add(cardObj.player2[i]);
                else if ((char)cardObj.player2[i].Key[0] == 'H')
                    player2H.Add(cardObj.player2[i]);
            }
            for (int i = 0; i < cardObj.player3.Count; i++)
            {
                if ((char)cardObj.player3[i].Key[0] == 'C')
                    player3C.Add(cardObj.player3[i]);
                else if ((char)cardObj.player3[i].Key[0] == 'S')
                    player3S.Add(cardObj.player3[i]);
                else if ((char)cardObj.player3[i].Key[0] == 'D')
                    player3D.Add(cardObj.player3[i]);
                else if ((char)cardObj.player3[i].Key[0] == 'H')
                    player3H.Add(cardObj.player3[i]);
            }
        }
        #endregion
        //1-cards spread in the table :-
        async void cardsSpread()
        {
            
            // Margin="-134,231,0,0" Width="128" Height="185"
            playerSB1.Begin();
            await Task.Delay(TimeSpan.FromSeconds(1));
            playerSB2.Begin();
            await Task.Delay(TimeSpan.FromSeconds(1));
            playerSB3.Begin();
            await Task.Delay(TimeSpan.FromSeconds(1));
            playerSB4.Begin();
           
            cardObj.cards();
            cardObj.SpreadIntoList();
            cardObj.Lists();
            #region Card Images In The Table Spread
            //image1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[0].Key + ".png"));
            //image2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[1].Key + ".png"));
            //image3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[2].Key + ".png"));
            //image4.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[3].Key + ".png"));
            //image5.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[4].Key + ".png"));
            //image6.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[5].Key + ".png"));
            //image7.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[6].Key + ".png"));
            //image8.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[7].Key + ".png"));
            //image9.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[8].Key + ".png"));
            //image10.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[9].Key + ".png"));
            //image11.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[10].Key + ".png"));
            //image12.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[11].Key + ".png"));
            //image13.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[12].Key + ".png"));

            //image14.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[0].Key + ".png"));
            //image15.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[1].Key + ".png"));
            //image16.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[2].Key + ".png"));
            //image17.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[3].Key + ".png"));
            //image18.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[4].Key + ".png"));
            //image19.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[5].Key + ".png"));
            //image20.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[6].Key + ".png"));
            //image21.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[7].Key + ".png"));
            //image22.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[8].Key + ".png"));
            //image23.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[9].Key + ".png"));
            //image24.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[10].Key + ".png"));
            //image25.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[11].Key + ".png"));
            //image26.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[12].Key + ".png"));

            //image27.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[0].Key + ".png"));
            //image28.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[1].Key + ".png"));
            //image29.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[2].Key + ".png"));
            //image30.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[3].Key + ".png"));
            //image31.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[4].Key + ".png"));
            //image32.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[5].Key + ".png"));
            //image33.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[6].Key + ".png"));
            //image34.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[7].Key + ".png"));
            //image35.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[8].Key + ".png"));
            //image36.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[9].Key + ".png"));
            //image37.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[10].Key + ".png"));
            //image38.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[11].Key + ".png"));
            //image39.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[12].Key + ".png"));
         
            //this for sort cards:-
            int var = 12;
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[0].Value, image40));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[1].Value, image41));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[2].Value, image42));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[3].Value, image43));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[4].Value, image44));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[5].Value, image45));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[6].Value, image46));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[7].Value, image47));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[8].Value, image48));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[9].Value, image49));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[10].Value, image50));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[11].Value, image51));
            xxx.Add(new KeyValuePair<int, Image>(cardObj.player4[12].Value, image52));
          cardObj.player4  = cardObj.player4.OrderByDescending(i => i.Value).ToList();
           
            for (int i = 0; i < cardObj.player4.Count; i++)
            {
                if ((char)cardObj.player4[i].Key[0] == 'C')
                {
                    xxx[var].Value.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player4[i].Key + ".png"));
                    var--;
                    P4.Add(new KeyValuePair<StackPanel, string>(card40, cardObj.player4[i].Key));
                }
            }

            for (int i = 0; i < cardObj.player4.Count; i++)
            {
                if ((char)cardObj.player4[i].Key[0] == 'D')
                {
                    xxx[var].Value.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player4[i].Key + ".png"));
                    var--;
                    P4.Add(new KeyValuePair<StackPanel, string>(card40, cardObj.player4[i].Key));
                }
            }

            for (int i = 0; i < cardObj.player4.Count; i++)
            {
                if ((char)cardObj.player4[i].Key[0] == 'S')
                {
                    xxx[var].Value.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player4[i].Key + ".png"));
                    var--;
                    P4.Add(new KeyValuePair<StackPanel, string>(card40, cardObj.player4[i].Key));
                }
            }

            for (int i = 0; i < cardObj.player4.Count; i++)
            {
                if ((char)cardObj.player4[i].Key[0] == 'H')
                {
                    xxx[var].Value.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player4[i].Key + ".png"));
                    var--;
                    P4.Add(new KeyValuePair<StackPanel, string>(card40, cardObj.player4[i].Key));
                }
            }
            
             #endregion
            flag = true;
        }

        //2-check if avoid or not :-
        #region CheckifVoid
        void Avoid()
        {
            Avoid1();
            Avoid2();
            Avoid3();
            string temp14 = null;
            string temp24 = null;
            string temp34 = null;
            string temp44 = null;

            for (int i = 0; i < cardObj.player4.Count; i++)
            {
                if ((char)cardObj.player4[i].Key[0] == 'C')
                {
                    temp14 = "C";
                }
                if ((char)cardObj.player4[i].Key[0] == 'D')
                {
                    temp24 = "D";
                }
                if ((char)cardObj.player4[i].Key[0] == 'S')
                {
                    temp34 = "S";
                }
                if ((char)cardObj.player4[i].Key[0] == 'H')
                {
                    temp44 = "H";
                }
            }
            if (temp14 != "C" || temp24 != "D" || temp34 != "S" || temp44 != "H")
            {
                avoidOrRe.Visibility = Visibility.Visible;
            }
            else
            {
                p1Result();
            }
        }
       async void Avoid1()
        {
            string temp11 = null;
            string temp21 = null;
            string temp31 = null;
            string temp41 = null;

            for (int i = 0; i < cardObj.player1.Count; i++)
            {
                if ((char)cardObj.player1[i].Key[0] == 'C')
                {
                    temp11 = "C";
                }
                if ((char)cardObj.player1[i].Key[0] == 'D')
                {
                    temp21 = "D";
                }
                if ((char)cardObj.player1[i].Key[0] == 'S')
                {
                    temp31 = "S";
                }
                if ((char)cardObj.player1[i].Key[0] == 'H')
                {
                    temp41 = "H";
                }
            }

            if (temp11 != "C" || temp21 != "D" || temp31 != "S" || temp41 != "H")
            {
                p1results.Text = "Avoid !";
                p1results.FontSize = 30;
                p1results.Foreground = GetBrushFromHexColor("#FFF72121");
                p1results.FontFamily = new FontFamily("Buxton Sketch");
                await Task.Delay(TimeSpan.FromSeconds(2));
                p1results.Text = " ";
            }
        }
       async void Avoid2()
       {


           string temp12 = null;
           string temp22 = null;
           string temp32 = null;
           string temp42 = null;

           for (int i = 0; i < cardObj.player2.Count; i++)
           {
               if ((char)cardObj.player2[i].Key[0] == 'C')
               {
                   temp12 = "C";
               }
               if ((char)cardObj.player2[i].Key[0] == 'D')
               {
                   temp22 = "D";
               }
               if ((char)cardObj.player2[i].Key[0] == 'S')
               {
                   temp32 = "S";
               }
               if ((char)cardObj.player2[i].Key[0] == 'H')
               {
                   temp42 = "H";
               }
           }
           if (temp12 != "C" || temp22 != "D" || temp32 != "S" || temp42 != "H")
           {
               p2results.Text = "Avoid !";
               p2results.FontSize = 30;
               p2results.Foreground = GetBrushFromHexColor("#FFF72121");

               await Task.Delay(TimeSpan.FromSeconds(2));
               p2results.Text = " ";
           }
       }
       async void Avoid3()
       {
           string temp13 = null;
           string temp23 = null;
           string temp33 = null;
           string temp43 = null;

           for (int i = 0; i < cardObj.player3.Count; i++)
           {
               if ((char)cardObj.player3[i].Key[0] == 'C')
               {
                   temp13 = "C";
               }
               if ((char)cardObj.player3[i].Key[0] == 'D')
               {
                   temp23 = "D";
               }
               if ((char)cardObj.player3[i].Key[0] == 'S')
               {
                   temp33 = "S";
               }
               if ((char)cardObj.player3[i].Key[0] == 'H')
               {
                   temp43 = "H";
               }
           }
           if (temp13 != "C" || temp23 != "D" || temp33 != "S" || temp43 != "H")
           {
               p3results.Text = "Avoid !";
               p3results.FontSize = 30;
               p3results.Foreground = GetBrushFromHexColor("#FFF72121");

               await Task.Delay(TimeSpan.FromSeconds(2));
               p3results.Text = " ";
           }
       }
      
        private async void AvoidTapped(object sender, TappedRoutedEventArgs e)
        {
            TxtAvoid.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtAvoid.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtAvoid.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtAvoid.Visibility = Visibility.Visible;
           
                avoidOrRe.Visibility = Visibility.Collapsed;
                p4results.Text = "Avoid !";
                p4results.FontSize = 30;
                p4results.Foreground = GetBrushFromHexColor("#FFF72121");

                await Task.Delay(TimeSpan.FromSeconds(3));
                p4results.Text = " ";
                
             BidOrDash();
        }

        private async void RedealTapped(object sender, TappedRoutedEventArgs e)
        {
            TxtRedeal.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtRedeal.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtRedeal.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtRedeal.Visibility = Visibility.Visible;

            avoidOrRe.Visibility = Visibility.Collapsed;
            p4results.Text = "Redeal !";
            p4results.FontSize = 30;
            p4results.Foreground = GetBrushFromHexColor("#FFF72121");
            await Task.Delay(TimeSpan.FromSeconds(3));
            p4results.Text = " ";
            this.Frame.Navigate(typeof(Game));
           
        }
        #endregion

        //3-Check if Bid Or dash Call
        #region Bid Or DashCall

        void BidOrDash()
        {
            bidOrDash.Visibility = Visibility.Visible;
            if (bids.dashCall == 2)
                TxtDash.IsTapEnabled = false;
        }
        async void p1Result()
        {
            for (int i = 0; i < cardObj.player1.Count; i++)
            {
                if (cardObj.player1[i].Value == 14 ||cardObj.player1[i].Value == 13 ||cardObj.player1[i].Value == 12)
                    dash1++;
            }
            if (bids.dashCall == 2)
            {
                p1results.Text = "Bid !";
                p1results.FontSize = 30;
                p1results.Foreground = GetBrushFromHexColor("#FFF72121");
                p1results.FontFamily = new FontFamily("Buxton Sketch");
                await Task.Delay(TimeSpan.FromSeconds(3));
                p1results.Text = " ";
            }
            else if (dash1 <1)
            {
                dash.dashcall1 = 1;
                p1results.Text = "Dash Call !";
                p1results.FontSize = 30;
                p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                await Task.Delay(TimeSpan.FromSeconds(3));
                p1results.Text = " ";
                bids.dashCall++;
                bids.pass++;
            }
             else
             {
                 p1results.Text = "Bid !";
                 p1results.FontSize = 30;
                 p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                 await Task.Delay(TimeSpan.FromSeconds(3));
                 p1results.Text = " ";
             }

             p2Result();
        }

        async void p2Result()
        {
            for (int i = 0; i < cardObj.player2.Count; i++)
            {
                if (cardObj.player2[i].Value == 14 || cardObj.player2[i].Value == 13 || cardObj.player2[i].Value == 12)
                    dash2++;

            }
            if (bids.dashCall == 2)
            {
                p2results.Text = "Bid !";
                p2results.FontSize = 30;
                p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                await Task.Delay(TimeSpan.FromSeconds(3));
                p2results.Text = " ";
            }
           else if (dash2 < 1)
            {
                dash.dashcall2 = 1;
                p2results.Text = "Dash Call !";
                p2results.FontSize = 30;
                p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                await Task.Delay(TimeSpan.FromSeconds(3));
                p2results.Text = " ";
                bids.dashCall++;
                bids.pass++;
            }
            else
            {
                p2results.Text = "Bid !";
                p2results.FontSize = 30;
                p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                await Task.Delay(TimeSpan.FromSeconds(3));
                p2results.Text = " ";
            }
            p3Result();
        }

        async void p3Result()
        {
            for (int i = 0; i < cardObj.player3.Count; i++)
            {
                if (cardObj.player3[i].Value == 14 || cardObj.player3[i].Value == 13 || cardObj.player3[i].Value == 12)
                    dash3++;

            }
            if (bids.dashCall == 2)
            {
                p3results.Text = "Bid !";
                p3results.FontSize = 30;
                p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                await Task.Delay(TimeSpan.FromSeconds(3));
                p3results.Text = " ";
            }
           else if (dash3 < 1)
            {
                dash.dashcall3 = 1;
                p3results.Text = "Dash Call !";
                p3results.FontSize = 30;
                p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                await Task.Delay(TimeSpan.FromSeconds(3));
                p3results.Text = " ";
                bids.dashCall++;
                bids.pass++;
            }
            else
            {
                p3results.Text = "Bid !";
                p3results.FontSize = 30;
                p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                await Task.Delay(TimeSpan.FromSeconds(3));
                p3results.Text = " ";
            }
            BidOrDash();
        }
       

        private async void BidTapped(object sender, TappedRoutedEventArgs e)
        {
            TxtBid.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtBid.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtBid.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtBid.Visibility = Visibility.Visible;

            bidOrDash.Visibility = Visibility.Collapsed;
            p4results.Text = "Bid !";
            p4results.FontSize = 30;
            p4results.Foreground = GetBrushFromHexColor("#FFF72121");

            await Task.Delay(TimeSpan.FromSeconds(3));
            p4results.Text = " ";
            Recheck();
        }

        private async void DashTapped(object sender, TappedRoutedEventArgs e)
        {
            TxtDash.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtDash.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtDash.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            TxtDash.Visibility = Visibility.Visible;

            bidOrDash.Visibility = Visibility.Collapsed;
            p4results.Text = "Dash Call !";
            p4results.FontSize = 30;
            p4results.Foreground = GetBrushFromHexColor("#FFF72121");

            await Task.Delay(TimeSpan.FromSeconds(3));
            p4results.Text = " ";
            dash.dashcall4 = 1;
            bids.pass++;
            Recheck();
        }

        

        #endregion
        
        //4-First Bid
        #region First Bid
        void BidOrPass()
        {
            if (bids.pass % 4 == 0 && bids.pass >= 4)
            {
                this.Frame.Navigate(typeof(Game));
            }
            else
            { 
                if (dash.dashcall4 == 0)
                {
                    bidOrPass.Visibility = Visibility.Visible;
                    if (bids.counter <= 4)
                    {
                        switch (bids.sort)
                        {
                            case null:
                                break;
                            case "H":
                                H.Visibility = Visibility.Collapsed;
                                S.FontSize = 80;
                                H.FontSize = 72;
                                break;
                            case "S":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 80;
                                break;
                            case "D":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                D.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 72;
                                C.FontSize = 80;
                                break;
                            case "C":
                                four.Visibility = Visibility.Collapsed;
                                four.FontSize = 72;
                                five.FontSize = 80;
                                five.Foreground = GetBrushFromHexColor("#FFFF6745");
                                break;
                        }
                    }
                    else if (bids.counter <= 5)
                    {
                        four.Visibility = Visibility.Collapsed;
                        switch (bids.sort)
                        {
                            case null:
                                break;
                            case "H":
                                H.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 80;
                                break;
                            case "S":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                D.FontSize = 80;
                                break;
                            case "D":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                D.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 72;
                                C.FontSize = 80;
                                break;
                            case "C":
                                five.Visibility = Visibility.Collapsed;
                                four.FontSize = 72;
                                five.FontSize = 72;
                                six.FontSize = 80;
                                six.Foreground = GetBrushFromHexColor("#FFFF6745");
                                break;
                        }
                    }
                    else if (bids.counter <= 6)
                    {
                        four.Visibility = Visibility.Collapsed;
                        five.Visibility = Visibility.Collapsed;
                        switch (bids.sort)
                        {
                            case null:
                                break;
                            case "H":
                                H.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 80;
                                break;
                            case "S":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 80;
                                break;
                            case "D":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                D.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 72;
                                C.FontSize = 80;
                                break;
                            case "C":
                                six.Visibility = Visibility.Collapsed;
                                four.FontSize = 72;
                                five.FontSize = 72;
                                six.FontSize = 72;
                                seven.FontSize = 80;
                                seven.Foreground = GetBrushFromHexColor("#FFFF6745");
                                break;
                        }
                    }
                    else if (bids.counter <= 7)
                    {
                        four.Visibility = Visibility.Collapsed;
                        five.Visibility = Visibility.Collapsed;
                        six.Visibility = Visibility.Collapsed;
                        switch (bids.sort)
                        {
                            case null:
                                break;
                            case "H":
                                H.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 80;
                                break;
                            case "S":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 80;
                                break;
                            case "D":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                D.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 72;
                                C.FontSize = 80;
                                break;
                            case "C":
                                seven.Visibility = Visibility.Collapsed;
                                four.FontSize = 72;
                                five.FontSize = 72;
                                six.FontSize = 72;
                                seven.FontSize = 72;
                                eight.FontSize = 80;
                                eight.Foreground = GetBrushFromHexColor("#FFFF6745");
                                break;
                        }
                    }
                    else if (bids.counter <= 8)
                    {
                        four.Visibility = Visibility.Collapsed;
                        five.Visibility = Visibility.Collapsed;
                        six.Visibility = Visibility.Collapsed;
                        seven.Visibility = Visibility.Collapsed;
                        switch (bids.sort)
                        {
                            case null:
                                break;
                            case "H":
                                H.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 80;
                                break;
                            case "S":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 80;
                                break;
                            case "D":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                D.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 72;
                                C.FontSize = 80;
                                break;
                            case "C":
                                eight.Visibility = Visibility.Collapsed;
                                four.FontSize = 72;
                                five.FontSize = 72;
                                six.FontSize = 72;
                                seven.FontSize = 72;
                                eight.FontSize = 72;
                                nine.FontSize = 80;
                                nine.Foreground = GetBrushFromHexColor("#FFFF6745");
                                break;
                        }
                    }
                    else if (bids.counter <= 9)
                    {
                        four.Visibility = Visibility.Collapsed;
                        five.Visibility = Visibility.Collapsed;
                        six.Visibility = Visibility.Collapsed;
                        seven.Visibility = Visibility.Collapsed;
                        eight.Visibility = Visibility.Collapsed;
                        switch (bids.sort)
                        {
                            case null:
                                break;
                            case "H":
                                H.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 80;
                                break;
                            case "S":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 80;
                                break;
                            case "D":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                D.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 72;
                                C.FontSize = 80;
                                break;
                            case "C":
                                nine.Visibility = Visibility.Collapsed;
                                four.FontSize = 72;
                                five.FontSize = 72;
                                six.FontSize = 72;
                                seven.FontSize = 72;
                                eight.FontSize = 72;
                                nine.FontSize = 72;
                                ten.FontSize = 80;
                                ten.Foreground = GetBrushFromHexColor("#FFFF6745");
                                break;
                        }
                    }
                    else if (bids.counter <= 10)
                    {
                        four.Visibility = Visibility.Collapsed;
                        five.Visibility = Visibility.Collapsed;
                        six.Visibility = Visibility.Collapsed;
                        seven.Visibility = Visibility.Collapsed;
                        eight.Visibility = Visibility.Collapsed;
                        nine.Visibility = Visibility.Collapsed;
                        switch (bids.sort)
                        {
                            case null:
                                break;
                            case "H":
                                H.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 80;
                                break;
                            case "S":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 80;
                                break;
                            case "D":
                                H.Visibility = Visibility.Collapsed;
                                S.Visibility = Visibility.Collapsed;
                                D.Visibility = Visibility.Collapsed;
                                H.FontSize = 72;
                                S.FontSize = 72;
                                D.FontSize = 72;
                                C.FontSize = 80;
                                break;
                            case "C":
                                ten.Visibility = Visibility.Collapsed;
                                four.FontSize = 72;
                                five.FontSize = 72;
                                six.FontSize = 72;
                                seven.FontSize = 72;
                                eight.FontSize = 72;
                                nine.FontSize = 72;
                                ten.FontSize = 72;
                                eleven.FontSize = 80;
                                eleven.Foreground = GetBrushFromHexColor("#FFFF6745");
                                break;
                        }
                    }
            
                }
                else
                {
                    Recheck();
                }
            }
        }

        async void P1BidResult()
        {
            bid1 = 0;
                if (dash.dashcall1 == 0)
                {
                    //for choose number of bids
                    for (int i = 0; i < cardObj.player1.Count; i++)
                    {
                        if (cardObj.player1[i].Value == 14 || cardObj.player1[i].Value == 13 || cardObj.player1[i].Value == 12)
                            bid1++;
                    }
                    //for choose sort of cards
                    int Ccounter = 0;
                    int Dcounter = 0;
                    int Hcounter = 0;
                    int Scounter = 0;
                    for (int i = 0; i < cardObj.player1.Count; i++)
                        if ((char)cardObj.player1[i].Key[0] == 'C')
                            Ccounter++;

                    for (int i = 0; i < cardObj.player1.Count; i++)
                        if ((char)cardObj.player1[i].Key[0] == 'D')
                            Dcounter++;

                    for (int i = 0; i < cardObj.player1.Count; i++)
                        if ((char)cardObj.player1[i].Key[0] == 'H')
                            Hcounter++;

                    for (int i = 0; i < cardObj.player1.Count; i++)
                        if ((char)cardObj.player1[i].Key[0] == 'S')
                            Scounter++;

                    //----------
                    if (bid1 < 5)
                    {
                        p1results.Text = "Pass !";
                        p1results.FontSize = 30;
                        p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p1results.Text = " ";
                        bids.pass++;
                    }
                    else if (bid1 >= 5 && bid1 < 6 && bids.counter <= 4 && bids.sort != "C")
                    {
                        bids.counter = 4;
                        bids.bigBidAgain = 1;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "4 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "4 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p1results.Text = "4 ❤";
                                    bids.sort = "H";
                                }
                                else if (Scounter > Ccounter && Scounter > Dcounter && Scounter > Hcounter)
                                {
                                    p1results.Text = "4 ♠";
                                    bids.sort = "S";
                                }
                                else
                                {
                                    p1results.Text = "4 ❤";
                                    bids.sort = "H";
                                }
                                bids.highlybid = 1;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "4 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "4 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p1results.Text = "4 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "4 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "4 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p1results.Text = "4 ♦";
                                    bids.sort = "D";
                                }
                                bids.highlybid = 1;
                                break;

                            default:
                                p1results.Text = "4 ♣";
                                bids.sort = "C";
                                bids.highlybid = 1;
                                break;
                        }
                        p1results.FontSize = 30;
                        p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p1results.Text = " ";
                    }
                    else if (bid1 >= 6 && bid1 < 7 && bids.counter <= 5 && bids.sort != "C")
                    {
                        bids.counter = 5;
                        bids.bigBidAgain = 1;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "5 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "5 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p1results.Text = "5 ❤";
                                    bids.sort = "H";
                                }
                                else if (Scounter > Ccounter && Scounter > Dcounter && Scounter > Hcounter)
                                {
                                    p1results.Text = "5 ♠";
                                    bids.sort = "S";
                                }
                                else
                                {
                                    p1results.Text = "5 ❤";
                                    bids.sort = "H";
                                }
                                bids.highlybid = 1;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "5 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "5 ♣";
                                    bids.sort = "C";
                                }
                                else if (Scounter > Ccounter && Scounter > Dcounter && Scounter > Hcounter)
                                {
                                    p1results.Text = "5 ♠";
                                    bids.sort = "S";
                                }
                                else
                                {
                                    p1results.Text = "5 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "5 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p1results.Text = "5 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 1;
                                break;

                            case "D":
                                p1results.Text = "5 ♣";
                                bids.sort = "C";
                                bids.highlybid = 1;
                                break;
                            default:
                                p1results.Text = "Pass !";
                                p1results.FontSize = 30;
                                p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                                await Task.Delay(TimeSpan.FromSeconds(3));
                                p1results.Text = " ";
                                bids.pass++;
                                break;
                        }
                        p1results.FontSize = 30;
                        p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p1results.Text = " ";
                    }
                    else if (bid1 >= 7 && bid1 < 8 && bids.counter <= 6 && bids.sort != "C")
                    {
                        bids.counter = 6;
                        bids.bigBidAgain = 1;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "6 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "6 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p1results.Text = "6 ❤";
                                    bids.sort = "H";
                                }
                                else
                                {
                                    p1results.Text = "6 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "6 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "6 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p1results.Text = "6 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "6 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p1results.Text = "6 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 1;
                                break;

                            default:
                                p1results.Text = "6 ♣";
                                bids.sort = "C";
                                bids.highlybid = 1;
                                break;


                        }
                        p1results.FontSize = 30;
                        p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p1results.Text = " ";
                    }
                    else if (bid1 >= 8 && bid1 < 9 && bids.counter <= 7 && bids.sort != "C")
                    {
                        bids.counter = 7;
                        bids.bigBidAgain = 1;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "7 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "7 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p1results.Text = "7 ❤";
                                    bids.sort = "H";
                                }
                                else
                                {
                                    p1results.Text = "7 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "7 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "7 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p1results.Text = "7 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "7 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p1results.Text = "7 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 1;
                                break;

                            default:
                                {
                                    p1results.Text = "7 ♣";
                                    bids.sort = "C";

                                    bids.highlybid = 1;
                                    break;
                                }
                        }
                        p1results.FontSize = 30;
                        p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p1results.Text = " ";
                    }
                    else if (bid1 >= 9 && bid1 < 10 && bids.counter <= 8 && bids.sort != "C")
                    {
                        bids.counter = 8;
                        bids.bigBidAgain = 1;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "8 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "8 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p1results.Text = "8 ❤";
                                    bids.sort = "H";
                                }
                                else
                                {
                                    p1results.Text = "8 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "8 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "8 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p1results.Text = "8 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "8 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p1results.Text = "8 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 1;
                                break;

                            default:
                                p1results.Text = "8 ♣";
                                bids.sort = "C";
                                bids.highlybid = 1;
                                break;
                        }
                        p1results.FontSize = 30;
                        p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p1results.Text = " ";
                    }
                    else if (bid1 >= 10 && bid1 < 11 && bids.counter <= 9 && bids.sort != "C")
                    {
                        bids.counter = 9;
                        bids.bigBidAgain = 1;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "9 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "9 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p1results.Text = "9 ❤";
                                    bids.sort = "H";
                                }
                                else
                                {
                                    p1results.Text = "9 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "9 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "9 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p1results.Text = "9 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "9 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p1results.Text = "9 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 1;
                                break;

                            default:
                                p1results.Text = "9 ♣";
                                bids.sort = "C";
                                bids.highlybid = 1;
                                break;
                        }
                        p1results.FontSize = 30;
                        p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p1results.Text = " ";
                    }
                    else if (bid1 >= 11 && bid1 < 12 && bids.counter <= 10 && bids.sort != "C")
                    {
                        bids.counter = 10;
                        bids.bigBidAgain = 1;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "10 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "10 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p1results.Text = "10 ❤";
                                    bids.sort = "H";
                                }
                                else
                                {
                                    p1results.Text = "10 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "10 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p1results.Text = "10 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p1results.Text = "10 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 1;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p1results.Text = "10 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p1results.Text = "10 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 1;
                                break;

                            default:
                                p1results.Text = "10 ♣";
                                bids.sort = "C";
                                bids.highlybid = 1;
                                break;
                        }
                        p1results.FontSize = 30;
                        p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p1results.Text = " ";
                    }
                    else
                    {
                        p1results.Text = "Pass !";
                        p1results.FontSize = 30;
                        p1results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p1results.Text = " ";
                        bids.pass++;
                    }

                    Recheck();
                }
                else
                {
                    Recheck();
                }
            
        }

        async void P2BidResult()
        {
            bid2 = 0;
            if (dash.dashcall2 == 0)
            {
                //for choose number of bids
                for (int i = 0; i < cardObj.player2.Count; i++)
                {
                    if (cardObj.player2[i].Value == 14 || cardObj.player2[i].Value == 13 || cardObj.player2[i].Value == 12)
                        bid2++;
                }
                //for choose sort of cards
                int Ccounter = 0;
                int Dcounter = 0;
                int Hcounter = 0;
                int Scounter = 0;
                for (int i = 0; i < cardObj.player2.Count; i++)
                    if ((char)cardObj.player2[i].Key[0] == 'C')
                        Ccounter++;

                for (int i = 0; i < cardObj.player2.Count; i++)
                    if ((char)cardObj.player2[i].Key[0] == 'D')
                        Dcounter++;

                for (int i = 0; i < cardObj.player2.Count; i++)
                    if ((char)cardObj.player2[i].Key[0] == 'H')
                        Hcounter++;

                for (int i = 0; i < cardObj.player2.Count; i++)
                    if ((char)cardObj.player2[i].Key[0] == 'S')
                        Scounter++;

                //----------
                if (bid2 < 5)
                {
                    p2results.Text = "Pass !";
                    p2results.FontSize = 30;
                    p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                    await Task.Delay(TimeSpan.FromSeconds(3));
                    p2results.Text = " ";
                    bids.pass++;
                }
                else if (bid2 >= 5 && bid2 < 6 && bids.counter <= 4 && bids.sort != "C")
                {
                    bids.bigBidAgain = 2;
                    bids.counter = 4;
                    switch (bids.sort)
                    {
                        case null:
                            if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "4 ♣";
                                bids.sort = "C";
                            }
                            else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "4 ♦";
                                bids.sort = "D";
                            }
                            else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                            {
                                p2results.Text = "4 ❤";
                                bids.sort = "H";
                            }
                            else if (Scounter > Ccounter && Scounter > Dcounter && Scounter > Hcounter)
                            {
                                p2results.Text = "4 ♠";
                                bids.sort = "S";
                            }
                            else
                            {
                                p2results.Text = "4 ❤";
                                bids.sort = "H";
                            }
                            bids.highlybid = 2;
                            break;

                        case "H":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "4 ♦";
                                bids.sort = "D";
                            }
                            else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "4 ♣";
                                bids.sort = "C";
                            }
                            else
                            {
                                p2results.Text = "4 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "S":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "4 ♦";
                                bids.sort = "D";
                            }
                            else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "4 ♣";
                                bids.sort = "C";
                            }
                            else
                            {
                                p2results.Text = "4 ♦";
                                bids.sort = "D";
                            }
                            bids.highlybid = 2;
                            break;

                        default:
                            p2results.Text = "4 ♣";
                            bids.sort = "C";
                            bids.highlybid = 2;
                            break;
                    }
                    p2results.FontSize = 30;
                    p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                    await Task.Delay(TimeSpan.FromSeconds(3));
                    p2results.Text = " ";
                }
                else if (bid2 >= 6 && bid2 < 7 && bids.counter <= 5 && bids.sort != "C")
                {
                    bids.bigBidAgain = 2;
                    bids.counter = 5;
                    switch (bids.sort)
                    {
                        case null:
                            if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "5 ♣";
                                bids.sort = "C";
                            }
                            else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "5 ♦";
                                bids.sort = "D";
                            }
                            else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                            {
                                p2results.Text = "5 ❤";
                                bids.sort = "H";
                            }
                            else if (Scounter > Ccounter && Scounter > Dcounter && Scounter > Hcounter)
                            {
                                p2results.Text = "5 ♠";
                                bids.sort = "S";
                            }
                            else
                            {
                                p2results.Text = "5 ❤";
                                bids.sort = "H";
                            }
                            bids.highlybid = 2;
                            break;

                        case "H":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "5 ♦";
                                bids.sort = "D";
                            }
                            else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "5 ♣";
                                bids.sort = "C";
                            }
                            else if (Scounter > Ccounter && Scounter > Dcounter && Scounter > Hcounter)
                            {
                                p2results.Text = "5 ♠";
                                bids.sort = "S";
                            }
                            else
                            {
                                p2results.Text = "5 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "S":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "5 ♦";
                                bids.sort = "D";
                            }
                            else
                            {
                                p2results.Text = "5 ♣";
                                bids.sort = "C";
                            }
                            bids.highlybid = 2;
                            break;

                        default:
                            p2results.Text = "5 ♣";
                            bids.sort = "C";
                            bids.highlybid = 2;
                            break;
                    }
                    p2results.FontSize = 30;
                    p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                    await Task.Delay(TimeSpan.FromSeconds(3));
                    p2results.Text = " ";
                }
                else if (bid2 >= 7 && bid2 < 8 && bids.counter <= 6 && bids.sort != "C")
                {
                    bids.counter = 6;
                    bids.bigBidAgain = 2;
                    switch (bids.sort)
                    {
                        case null:
                            if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "6 ♣";
                                bids.sort = "C";
                            }
                            else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "6 ♦";
                                bids.sort = "D";
                            }
                            else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                            {
                                p2results.Text = "6 ❤";
                                bids.sort = "H";
                            }
                            else
                            {
                                p2results.Text = "6 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "H":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "6 ♦";
                                bids.sort = "D";
                            }
                            else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "6 ♣";
                                bids.sort = "C";
                            }
                            else
                            {
                                p2results.Text = "6 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "S":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "6 ♦";
                                bids.sort = "D";
                            }
                            else
                            {
                                p2results.Text = "6 ♣";
                                bids.sort = "C";
                            }
                            bids.highlybid = 2;
                            break;

                        default:
                            p2results.Text = "6 ♣";
                            bids.sort = "C";
                            bids.highlybid = 2;
                            break;


                    }
                    p2results.FontSize = 30;
                    p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                    await Task.Delay(TimeSpan.FromSeconds(3));
                    p2results.Text = " ";
                }
                else if (bid2 >= 8 && bid2 < 9 && bids.counter <= 7 && bids.sort != "C")
                {
                    bids.counter = 7;
                    bids.bigBidAgain = 2;
                    switch (bids.sort)
                    {
                        case null:
                            if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "7 ♣";
                                bids.sort = "C";
                            }
                            else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "7 ♦";
                                bids.sort = "D";
                            }
                            else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                            {
                                p2results.Text = "7 ❤";
                                bids.sort = "H";
                            }
                            else
                            {
                                p2results.Text = "7 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "H":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "7 ♦";
                                bids.sort = "D";
                            }
                            else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "7 ♣";
                                bids.sort = "C";
                            }
                            else
                            {
                                p2results.Text = "7 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "S":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "7 ♦";
                                bids.sort = "D";
                            }
                            else
                            {
                                p2results.Text = "7 ♣";
                                bids.sort = "C";
                            }
                            bids.highlybid = 2;
                            break;

                        default:
                            if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "7 ♣";
                                bids.sort = "C";
                            }
                            bids.highlybid = 2;
                            break;
                    }
                    p2results.FontSize = 30;
                    p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                    await Task.Delay(TimeSpan.FromSeconds(3));
                    p2results.Text = " ";
                }
                else if (bid2 >= 9 && bid2 < 10 && bids.counter <= 8 && bids.sort != "C")
                {
                    bids.counter = 8;
                    bids.bigBidAgain = 2;
                    switch (bids.sort)
                    {
                        case null:
                            if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "8 ♣";
                                bids.sort = "C";
                            }
                            else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "8 ♦";
                                bids.sort = "D";
                            }
                            else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                            {
                                p2results.Text = "8 ❤";
                                bids.sort = "H";
                            }
                            else
                            {
                                p2results.Text = "8 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "H":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "8 ♦";
                                bids.sort = "D";
                            }
                            else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "8 ♣";
                                bids.sort = "C";
                            }
                            else
                            {
                                p2results.Text = "8 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "S":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "8 ♦";
                                bids.sort = "D";
                            }
                            else
                            {
                                p2results.Text = "8 ♣";
                                bids.sort = "C";
                            }
                            bids.highlybid = 2;
                            break;

                        default:
                            p2results.Text = "8 ♣";
                            bids.sort = "C";
                            bids.highlybid = 2;
                            break;
                    }
                    p2results.FontSize = 30;
                    p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                    await Task.Delay(TimeSpan.FromSeconds(3));
                    p2results.Text = " ";
                }
                else if (bid2 >= 10 && bid2 < 11 && bids.counter <= 9 && bids.sort != "C")
                {
                    bids.counter = 9;
                    bids.bigBidAgain = 2;
                    switch (bids.sort)
                    {
                        case null:
                            if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "9 ♣";
                                bids.sort = "C";
                            }
                            else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "9 ♦";
                                bids.sort = "D";
                            }
                            else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                            {
                                p2results.Text = "9 ❤";
                                bids.sort = "H";
                            }
                            else
                            {
                                p2results.Text = "9 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "H":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "9 ♦";
                                bids.sort = "D";
                            }
                            else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "9 ♣";
                                bids.sort = "C";
                            }
                            else
                            {
                                p2results.Text = "9 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "S":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "9 ♦";
                                bids.sort = "D";
                            }
                            else
                            {
                                p2results.Text = "9 ♣";
                                bids.sort = "C";
                            }
                            bids.highlybid = 2;
                            break;

                        default:
                            p2results.Text = "9 ♣";
                            bids.sort = "C";
                            bids.highlybid = 2;
                            break;
                    }
                    p2results.FontSize = 30;
                    p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                    await Task.Delay(TimeSpan.FromSeconds(3));
                    p2results.Text = " ";
                }
                else if (bid2 >= 11 && bid2 < 12 && bids.counter <= 10 && bids.sort != "C")
                {
                    bids.counter = 10;
                    bids.bigBidAgain = 2;
                    switch (bids.sort)
                    {
                        case null:
                            if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "10 ♣";
                                bids.sort = "C";
                            }
                            else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "10 ♦";
                                bids.sort = "D";
                            }
                            else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                            {
                                p2results.Text = "10 ❤";
                                bids.sort = "H";
                            }
                            else
                            {
                                p2results.Text = "10 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "H":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "10 ♦";
                                bids.sort = "D";
                            }
                            else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                            {
                                p2results.Text = "10 ♣";
                                bids.sort = "C";
                            }
                            else
                            {
                                p2results.Text = "10 ♠";
                                bids.sort = "S";
                            }
                            bids.highlybid = 2;
                            break;

                        case "S":
                            if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                            {
                                p2results.Text = "10 ♦";
                                bids.sort = "D";
                            }
                            else
                            {
                                p2results.Text = "10 ♣";
                                bids.sort = "C";
                            }
                            bids.highlybid = 2;
                            break;

                        default:
                            p2results.Text = "10 ♣";
                            bids.sort = "C";
                            bids.highlybid = 2;
                            break;
                    }
                    p2results.FontSize = 30;
                    p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                    await Task.Delay(TimeSpan.FromSeconds(3));
                    p2results.Text = " ";
                }
                else
                {
                    p2results.Text = "Pass !";
                    p2results.FontSize = 30;
                    p2results.Foreground = GetBrushFromHexColor("#FFF72121");

                    await Task.Delay(TimeSpan.FromSeconds(3));
                    p2results.Text = " ";
                    bids.pass++;
                }
                Recheck();
            }
            else
            {
                Recheck();
            }
        }
        async void P3BidResult()
        {
            bid3 = 0;
                if (dash.dashcall3 == 0)
                {
                    //for choose number of bids
                    for (int i = 0; i < cardObj.player3.Count; i++)
                    {
                        if (cardObj.player3[i].Value == 14 || cardObj.player3[i].Value == 13 || cardObj.player3[i].Value == 12)
                            bid3++;
                    }
                    //for choose sort of cards
                    int Ccounter = 0;
                    int Dcounter = 0;
                    int Hcounter = 0;
                    int Scounter = 0;
                    for (int i = 0; i < cardObj.player3.Count; i++)
                        if ((char)cardObj.player3[i].Key[0] == 'C')
                            Ccounter++;

                    for (int i = 0; i < cardObj.player3.Count; i++)
                        if ((char)cardObj.player3[i].Key[0] == 'D')
                            Dcounter++;

                    for (int i = 0; i < cardObj.player3.Count; i++)
                        if ((char)cardObj.player3[i].Key[0] == 'H')
                            Hcounter++;

                    for (int i = 0; i < cardObj.player3.Count; i++)
                        if ((char)cardObj.player3[i].Key[0] == 'S')
                            Scounter++;

                    //----------
                    if (bid3 < 5)
                    {
                        p3results.Text = "Pass !";
                        p3results.FontSize = 30;
                        p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p3results.Text = " ";
                        bids.pass++;
                    }
                    else if (bid3 >= 5 && bid3 < 6 && bids.counter <= 4 && bids.sort != "C")
                    {
                        bids.bigBidAgain = 3;
                        bids.counter = 4;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "4 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "4 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p3results.Text = "4 ❤";
                                    bids.sort = "H";
                                }
                                else if (Scounter > Ccounter && Scounter > Dcounter && Scounter > Hcounter)
                                {
                                    p3results.Text = "4 ♠";
                                    bids.sort = "S";
                                }
                                else
                                {
                                    p3results.Text = "4 ❤";
                                    bids.sort = "H";
                                }
                                bids.highlybid = 3;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "4 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "4 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p3results.Text = "4 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "4 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "4 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p3results.Text = "4 ♦";
                                    bids.sort = "D";
                                }
                                bids.highlybid = 3;
                                break;

                            default:
                                p3results.Text = "4 ♣";
                                bids.sort = "C";
                                bids.highlybid = 3;
                                break;
                        }
                        p3results.FontSize = 30;
                        p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p3results.Text = " ";
                    }
                    else if (bid3 >= 6 && bid3 < 7 && bids.counter <= 5 && bids.sort != "C")
                    {
                        bids.bigBidAgain = 3;
                        bids.counter = 5;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "5 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "5 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p3results.Text = "5 ❤";
                                    bids.sort = "H";
                                }
                                else if (Scounter > Ccounter && Scounter > Dcounter && Scounter > Hcounter)
                                {
                                    p3results.Text = "5 ♠";
                                    bids.sort = "S";
                                }
                                else
                                {
                                    p3results.Text = "5 ❤";
                                    bids.sort = "H";
                                }
                                bids.highlybid = 3;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "5 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "5 ♣";
                                    bids.sort = "C";
                                }
                                else if (Scounter > Ccounter && Scounter > Dcounter && Scounter > Hcounter)
                                {
                                    p3results.Text = "5 ♠";
                                    bids.sort = "S";
                                }
                                else
                                {
                                    p3results.Text = "5 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "5 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p3results.Text = "5 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 3;
                                break;

                            default:
                                p3results.Text = "5 ♣";
                                bids.sort = "C";
                                bids.highlybid = 3;
                                break;
                        }
                        p3results.FontSize = 30;
                        p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p3results.Text = " ";
                    }
                    else if (bid3 >= 7 && bid3 < 8 && bids.counter <= 6 && bids.sort != "C")
                    {
                        bids.bigBidAgain = 3;
                        bids.counter = 6;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "6 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "6 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p3results.Text = "6 ❤";
                                    bids.sort = "H";
                                }
                                else
                                {
                                    p3results.Text = "6 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "6 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "6 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p3results.Text = "6 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "6 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p3results.Text = "6 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 3;
                                break;

                            default:
                                p3results.Text = "6 ♣";
                                bids.sort = "C";
                                bids.highlybid = 3;
                                break;


                        }
                        p3results.FontSize = 30;
                        p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p3results.Text = " ";
                    }
                    else if (bid3 >= 8 && bid3 < 9 && bids.counter <= 7 && bids.sort != "C")
                    {
                        bids.bigBidAgain = 3;
                        bids.counter = 7;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "7 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "7 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p3results.Text = "7 ❤";
                                    bids.sort = "H";
                                }
                                else
                                {
                                    p3results.Text = "7 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "7 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "7 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p3results.Text = "7 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "7 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p3results.Text = "7 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 3;
                                break;

                            default:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "7 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 3;
                                break;
                        }
                        p3results.FontSize = 30;
                        p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p3results.Text = " ";
                    }
                    else if (bid3 >= 9 && bid3 < 10 && bids.counter <= 8 && bids.sort != "C")
                    {
                        bids.bigBidAgain = 3;
                        bids.counter = 8;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "8 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "8 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p3results.Text = "8 ❤";
                                    bids.sort = "H";
                                }
                                else
                                {
                                    p3results.Text = "8 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "8 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "8 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p3results.Text = "8 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "8 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p3results.Text = "8 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 3;
                                break;

                            default:
                                p3results.Text = "8 ♣";
                                bids.sort = "C";
                                bids.highlybid = 3;
                                break;
                        }
                        p3results.FontSize = 30;
                        p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p3results.Text = " ";
                    }
                    else if (bid3 >= 10 && bid3 < 11 && bids.counter <= 9 && bids.sort != "C")
                    {
                        bids.bigBidAgain = 3;
                        bids.counter = 9;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "9 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "9 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p3results.Text = "9 ❤";
                                    bids.sort = "H";
                                }
                                else
                                {
                                    p3results.Text = "9 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "9 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "9 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p3results.Text = "9 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "9 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p3results.Text = "9 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 3;
                                break;

                            default:
                                p3results.Text = "9 ♣";
                                bids.sort = "C";
                                bids.highlybid = 3;
                                break;
                        }
                        p3results.FontSize = 30;
                        p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p3results.Text = " ";
                    }
                    else if (bid3 >= 11 && bid3 < 12 && bids.counter <= 10 && bids.sort != "C")
                    {
                        bids.bigBidAgain = 3;
                        bids.counter = 10;
                        switch (bids.sort)
                        {
                            case null:
                                if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "10 ♣";
                                    bids.sort = "C";
                                }
                                else if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "10 ♦";
                                    bids.sort = "D";
                                }
                                else if (Hcounter > Ccounter && Hcounter > Dcounter && Hcounter > Scounter)
                                {
                                    p3results.Text = "10 ❤";
                                    bids.sort = "H";
                                }
                                else
                                {
                                    p3results.Text = "10 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "H":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "10 ♦";
                                    bids.sort = "D";
                                }
                                else if (Ccounter > Dcounter && Ccounter > Hcounter && Ccounter > Scounter)
                                {
                                    p3results.Text = "10 ♣";
                                    bids.sort = "C";
                                }
                                else
                                {
                                    p3results.Text = "10 ♠";
                                    bids.sort = "S";
                                }
                                bids.highlybid = 3;
                                break;

                            case "S":
                                if (Dcounter > Ccounter && Dcounter > Hcounter && Dcounter > Scounter)
                                {
                                    p3results.Text = "10 ♦";
                                    bids.sort = "D";
                                }
                                else
                                {
                                    p3results.Text = "10 ♣";
                                    bids.sort = "C";
                                }
                                bids.highlybid = 3;
                                break;

                            default:
                                p3results.Text = "10 ♣";
                                bids.sort = "C";
                                bids.highlybid = 3;
                                break;
                        }
                        p3results.FontSize = 30;
                        p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p3results.Text = " ";
                    }
                    else
                    {
                        p3results.Text = "Pass !";
                        p3results.FontSize = 30;
                        p3results.Foreground = GetBrushFromHexColor("#FFF72121");

                        await Task.Delay(TimeSpan.FromSeconds(3));
                        p3results.Text = " ";
                        bids.pass++;
                    }
                    Recheck();
                }
                else
                {
                    Recheck();
                }
            
         }
        public SolidColorBrush GetBrushFromHexColor(string hexColor)
        {
            return new SolidColorBrush(
                Color.FromArgb(
                    Convert.ToByte(hexColor.Substring(1, 2), 16),
                    Convert.ToByte(hexColor.Substring(3, 2), 16),
                    Convert.ToByte(hexColor.Substring(5, 2), 16),
                    Convert.ToByte(hexColor.Substring(7, 2), 16)
                )
            );
        }
        private void four_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (sender == four)
            {
                if (bids.counter == 4 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 4 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 4 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                    D.Visibility = Visibility.Collapsed;
                }
                four.Foreground = GetBrushFromHexColor("#FFFF6745");
                five.Foreground = GetBrushFromHexColor("#FFF90000");
                six.Foreground = GetBrushFromHexColor("#FFF90000");
                seven.Foreground = GetBrushFromHexColor("#FFF90000");
                eight.Foreground = GetBrushFromHexColor("#FFF90000");
                nine.Foreground = GetBrushFromHexColor("#FFF90000");
                ten.Foreground = GetBrushFromHexColor("#FFF90000");
                eleven.Foreground = GetBrushFromHexColor("#FFF90000");
                twelve.Foreground = GetBrushFromHexColor("#FFF90000");
                thirteen.Foreground = GetBrushFromHexColor("#FFF90000");
                
                four.FontSize = 80;
                five.FontSize = 72;
                six.FontSize = 72;
                seven.FontSize = 72;
                eight.FontSize = 72;
                nine.FontSize = 72;
                ten.FontSize = 72;
                eleven.FontSize = 72;
                twelve.FontSize = 72;
                thirteen.FontSize = 72;
            }
                
            else if (sender == five)
            {
                if (bids.counter == 4 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Visible;
                }
                if (bids.counter == 4 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                }
                if (bids.counter == 4 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                }
                if (bids.counter == 4 && bids.sort == "C")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                }
                if (bids.counter == 5 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 5 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 5 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                    D.Visibility = Visibility.Collapsed;
                }
                four.Foreground = GetBrushFromHexColor("#FFF90000");
                five.Foreground = GetBrushFromHexColor("#FFFF6745");
                six.Foreground = GetBrushFromHexColor("#FFF90000");
                seven.Foreground = GetBrushFromHexColor("#FFF90000");
                eight.Foreground = GetBrushFromHexColor("#FFF90000");
                nine.Foreground = GetBrushFromHexColor("#FFF90000");
                ten.Foreground = GetBrushFromHexColor("#FFF90000");
                eleven.Foreground = GetBrushFromHexColor("#FFF90000");
                twelve.Foreground = GetBrushFromHexColor("#FFF90000");
                thirteen.Foreground = GetBrushFromHexColor("#FFF90000");
                four.FontSize = 72;
                five.FontSize = 80;
                six.FontSize = 72;
                seven.FontSize = 72;
                eight.FontSize = 72;
                nine.FontSize = 72;
                ten.FontSize = 72;
                eleven.FontSize = 72;
                twelve.FontSize = 72;
                thirteen.FontSize = 72;
            }
            else if (sender == six)
            {
                if ((bids.counter == 5 || bids.counter == 4) && bids.sort == "H")
                {
                    H.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 5 || bids.counter == 4) && bids.sort == "S")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 5 || bids.counter == 4) && bids.sort == "D")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 5 || bids.counter == 4) && bids.sort == "C")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                }
                if (bids.counter == 6 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 6 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 6 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                    D.Visibility = Visibility.Collapsed;
                }
                four.Foreground = GetBrushFromHexColor("#FFF90000");
                five.Foreground = GetBrushFromHexColor("#FFF90000");
                six.Foreground = GetBrushFromHexColor("#FFFF6745");
                seven.Foreground = GetBrushFromHexColor("#FFF90000");
                eight.Foreground = GetBrushFromHexColor("#FFF90000");
                nine.Foreground = GetBrushFromHexColor("#FFF90000");
                ten.Foreground = GetBrushFromHexColor("#FFF90000");
                eleven.Foreground = GetBrushFromHexColor("#FFF90000");
                twelve.Foreground = GetBrushFromHexColor("#FFF90000");
                thirteen.Foreground = GetBrushFromHexColor("#FFF90000");
                four.FontSize = 72;
                five.FontSize = 72;
                six.FontSize = 80;
                seven.FontSize = 72;
                eight.FontSize = 72;
                nine.FontSize = 72;
                ten.FontSize = 72;
                eleven.FontSize = 72;
                twelve.FontSize = 72;
                thirteen.FontSize = 72;
            }
            else if (sender == seven)
            {
                if ((bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "H")
                {
                    H.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "S")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "D")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "C")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                }
                if (bids.counter == 7 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 7 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 7 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                    D.Visibility = Visibility.Collapsed;
                }
                four.Foreground = GetBrushFromHexColor("#FFF90000");
                five.Foreground = GetBrushFromHexColor("#FFF90000");
                six.Foreground = GetBrushFromHexColor("#FFF90000");
                seven.Foreground = GetBrushFromHexColor("#FFFF6745");
                eight.Foreground = GetBrushFromHexColor("#FFF90000");
                nine.Foreground = GetBrushFromHexColor("#FFF90000");
                ten.Foreground = GetBrushFromHexColor("#FFF90000");
                eleven.Foreground = GetBrushFromHexColor("#FFF90000");
                twelve.Foreground = GetBrushFromHexColor("#FFF90000");
                thirteen.Foreground = GetBrushFromHexColor("#FFF90000");
                four.FontSize = 72;
                five.FontSize = 72;
                six.FontSize = 72;
                seven.FontSize = 80;
                eight.FontSize = 72;
                nine.FontSize = 72;
                ten.FontSize = 72;
                eleven.FontSize = 72;
                twelve.FontSize = 72;
                thirteen.FontSize = 72;
            }
            else if (sender == eight)
            {
                if ((bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "H")
                {
                    H.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "S")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "D")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "C")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                }
                if (bids.counter == 8 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 8 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 8 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                    D.Visibility = Visibility.Collapsed;
                }
                four.Foreground = GetBrushFromHexColor("#FFF90000");
                five.Foreground = GetBrushFromHexColor("#FFF90000");
                six.Foreground = GetBrushFromHexColor("#FFF90000");
                seven.Foreground = GetBrushFromHexColor("#FFF90000");
                eight.Foreground = GetBrushFromHexColor("#FFFF6745");
                nine.Foreground = GetBrushFromHexColor("#FFF90000");
                ten.Foreground = GetBrushFromHexColor("#FFF90000");
                eleven.Foreground = GetBrushFromHexColor("#FFF90000");
                twelve.Foreground = GetBrushFromHexColor("#FFF90000");
                thirteen.Foreground = GetBrushFromHexColor("#FFF90000");
                four.FontSize = 72;
                five.FontSize = 72;
                six.FontSize = 72;
                seven.FontSize = 72;
                eight.FontSize = 80;
                nine.FontSize = 72;
                ten.FontSize = 72;
                eleven.FontSize = 72;
                twelve.FontSize = 72;
                thirteen.FontSize = 72;
            }
            else if (sender == nine)
            {
                if ((bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "H")
                {
                    H.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "S")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "D")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "C")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                }
                if (bids.counter == 9 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 9 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 9 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                    D.Visibility = Visibility.Collapsed;
                }
                four.Foreground = GetBrushFromHexColor("#FFF90000");
                five.Foreground = GetBrushFromHexColor("#FFF90000");
                six.Foreground = GetBrushFromHexColor("#FFF90000");
                seven.Foreground = GetBrushFromHexColor("#FFF90000");
                eight.Foreground = GetBrushFromHexColor("#FFF90000");
                nine.Foreground = GetBrushFromHexColor("#FFFF6745");
                ten.Foreground = GetBrushFromHexColor("#FFF90000");
                eleven.Foreground = GetBrushFromHexColor("#FFF90000");
                twelve.Foreground = GetBrushFromHexColor("#FFF90000");
                thirteen.Foreground = GetBrushFromHexColor("#FFF90000");
                four.FontSize = 72;
                five.FontSize = 72;
                six.FontSize = 72;
                seven.FontSize = 72;
                eight.FontSize = 72;
                nine.FontSize = 80;
                ten.FontSize = 72;
                eleven.FontSize = 72;
                twelve.FontSize = 72;
                thirteen.FontSize = 72;
            }
            else if (sender == ten)
            {
                if ((bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "H")
                {
                    H.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "S")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "D")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "C")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                }
                if (bids.counter == 10 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 10 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 10 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                    D.Visibility = Visibility.Collapsed;
                }
                four.Foreground = GetBrushFromHexColor("#FFF90000");
                five.Foreground = GetBrushFromHexColor("#FFF90000");
                six.Foreground = GetBrushFromHexColor("#FFF90000");
                seven.Foreground = GetBrushFromHexColor("#FFF90000");
                eight.Foreground = GetBrushFromHexColor("#FFF90000");
                nine.Foreground = GetBrushFromHexColor("#FFF90000");
                ten.Foreground = GetBrushFromHexColor("#FFFF6745");
                eleven.Foreground = GetBrushFromHexColor("#FFF90000");
                twelve.Foreground = GetBrushFromHexColor("#FFF90000");
                thirteen.Foreground = GetBrushFromHexColor("#FFF90000");
                four.FontSize = 72;
                five.FontSize = 72;
                six.FontSize = 72;
                seven.FontSize = 72;
                eight.FontSize = 72;
                nine.FontSize = 72;
                ten.FontSize = 80;
                eleven.FontSize = 72;
                twelve.FontSize = 72;
                thirteen.FontSize = 72;
            }
            else if (sender == eleven)
            {
                if ((bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "H")
                {
                    H.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "S")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "D")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "C")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                }
                if (bids.counter == 11 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 11 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 11 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                    D.Visibility = Visibility.Collapsed;
                }
                four.Foreground = GetBrushFromHexColor("#FFF90000");
                five.Foreground = GetBrushFromHexColor("#FFF90000");
                six.Foreground = GetBrushFromHexColor("#FFF90000");
                seven.Foreground = GetBrushFromHexColor("#FFF90000");
                eight.Foreground = GetBrushFromHexColor("#FFF90000");
                nine.Foreground = GetBrushFromHexColor("#FFF90000");
                ten.Foreground = GetBrushFromHexColor("#FFF90000");
                eleven.Foreground = GetBrushFromHexColor("#FFFF6745");
                twelve.Foreground = GetBrushFromHexColor("#FFF90000");
                thirteen.Foreground = GetBrushFromHexColor("#FFF90000");
                four.FontSize = 72;
                five.FontSize = 72;
                six.FontSize = 72;
                seven.FontSize = 72;
                eight.FontSize = 72;
                nine.FontSize = 72;
                ten.FontSize = 72;
                eleven.FontSize = 80;
                twelve.FontSize = 72;
                thirteen.FontSize = 72;
            }
            else if (sender == twelve)
            {
                if ((bids.counter == 11 || bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "H")
                {
                    H.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 11 || bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "S")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 11 || bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "D")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 11 || bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "C")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                }
                if (bids.counter == 12 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 12 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 12 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                    D.Visibility = Visibility.Collapsed;
                }
                four.Foreground = GetBrushFromHexColor("#FFF90000");
                five.Foreground = GetBrushFromHexColor("#FFF90000");
                six.Foreground = GetBrushFromHexColor("#FFF90000");
                seven.Foreground = GetBrushFromHexColor("#FFF90000");
                eight.Foreground = GetBrushFromHexColor("#FFF90000");
                nine.Foreground = GetBrushFromHexColor("#FFF90000");
                ten.Foreground = GetBrushFromHexColor("#FFF90000");
                eleven.Foreground = GetBrushFromHexColor("#FFF90000");
                twelve.Foreground = GetBrushFromHexColor("#FFFF6745");
                thirteen.Foreground = GetBrushFromHexColor("#FFF90000");
                four.FontSize = 72;
                five.FontSize = 72;
                six.FontSize = 72;
                seven.FontSize = 72;
                eight.FontSize = 72;
                nine.FontSize = 72;
                ten.FontSize = 72;
                eleven.FontSize = 72;
                twelve.FontSize = 80;
                thirteen.FontSize = 72;
            }
            else if (sender == thirteen)
            {
                if ((bids.counter == 13 || bids.counter == 11 || bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "H")
                {
                    H.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 13 || bids.counter == 11 || bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "S")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 13 || bids.counter == 11 || bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "D")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                }
                if ((bids.counter == 13 || bids.counter == 11 || bids.counter == 10 || bids.counter == 9 || bids.counter == 8 || bids.counter == 7 || bids.counter == 5 || bids.counter == 4 || bids.counter == 6) && bids.sort == "C")
                {
                    H.Visibility = Visibility.Visible;
                    S.Visibility = Visibility.Visible;
                    D.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                }
                if (bids.counter == 14 && bids.sort == "H")
                {
                    H.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 14 && bids.sort == "S")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                }
                if (bids.counter == 14 && bids.sort == "D")
                {
                    H.Visibility = Visibility.Collapsed;
                    S.Visibility = Visibility.Collapsed;
                    D.Visibility = Visibility.Collapsed;
                }
                four.Foreground = GetBrushFromHexColor("#FFF90000");
                five.Foreground = GetBrushFromHexColor("#FFF90000");
                six.Foreground = GetBrushFromHexColor("#FFF90000");
                seven.Foreground = GetBrushFromHexColor("#FFF90000");
                eight.Foreground = GetBrushFromHexColor("#FFF90000");
                nine.Foreground = GetBrushFromHexColor("#FFF90000");
                ten.Foreground = GetBrushFromHexColor("#FFF90000");
                eleven.Foreground = GetBrushFromHexColor("#FFF90000");
                twelve.Foreground = GetBrushFromHexColor("#FFF90000");
                thirteen.Foreground = GetBrushFromHexColor("#FFFF6745");
                four.FontSize = 72;
                five.FontSize = 72;
                six.FontSize = 72;
                seven.FontSize = 72;
                eight.FontSize = 72;
                nine.FontSize = 72;
                ten.FontSize = 72;
                eleven.FontSize = 72;
                twelve.FontSize = 72;
                thirteen.FontSize = 80;
            }

            if (sender == C)
            {
                C.FontSize = 80;
                S.FontSize = 72;
                H.FontSize = 72;
                D.FontSize = 72;
            }
            else if (sender == D)
            {
                C.FontSize = 72;
                S.FontSize = 72;
                H.FontSize = 72;
                D.FontSize = 80;
            }
            else if (sender == H)
            {
                C.FontSize = 72;
                S.FontSize = 72;
                H.FontSize = 80;
                D.FontSize = 72;
            }
            else if (sender == S)
            {
                C.FontSize = 72;
                S.FontSize = 80;
                H.FontSize = 72;
                D.FontSize = 72;
            }
        }

       async private void Bid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Bid.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            Bid.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            Bid.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            Bid.Visibility = Visibility.Visible;

            bids.highlybid = 4;
           
            bidOrPass.Visibility = Visibility.Collapsed;
            bids.bigBidAgain = 4;
            FinalResultForBids();
            Recheck();
        }
       void Recheck()
       {
           if (bids.resForOne == 0)
           {
               bids.bigBidAgain = 5;
               bids.resForOne++;
               P1BidResult();
           }
           else if (bids.resForOne == 1 && bids.resForTwo==0)
           {
               bids.resForOne++;
               bids.resForTwo++;
               P2BidResult();
           }
           else if (bids.resForTwo == 1 && bids.resForThree ==0)
           {
               bids.resForTwo++;
               bids.resForThree++;
               P3BidResult();
           }
           else if (bids.resForThree == 1 && bids.resForFour ==0)
           {
               bids.resForThree++;
               bids.resForFour++;
               BidOrPass();
           }
           else if (bids.resForFour == 1)
           {
               if(bids.bigBidAgain == 1)
                   bids.highlybid = 1; ;
               bids.pass = 0;
               if (bids.bigBidAgain == 4)
               {
                   bids.highlybid = 4;
                   bids.resForOne = 0;
                   bids.resForTwo = 0;
                   bids.resForThree = 0;
                   FinalResultForBids();
                   Recheck();
                   bids.bigBidAgain = 5;
               }
               else if (bids.bigBidAgain == 3)
               {
                   bids.highlybid = 3;
                   bids.resForOne = 0;
                   bids.resForTwo = 0;
                   Recheck();
                   bids.bigBidAgain = 5;
               }
               else if (bids.bigBidAgain == 2)
               {
                   bids.highlybid = 2;
                   bids.resForOne = 0;
                   Recheck();
               }
               else
               {
                   p1Bid();
               }
           }
       }
      async void FinalResultForBids()
       {
           if (bids.sort == "C")
               bids.shapShow = "♣";
           else if (bids.sort == "D")
               bids.shapShow = "♦";
           else if (bids.sort == "H")
               bids.shapShow = "❤";
           else
               bids.shapShow = "♠";

           if (bids.highlybid == 1)
           {
               p1ResultsPlace.Text = bids.counter + " " + bids.shapShow;
               p1ResultsPlace.FontSize = 30;
           }
          else if (bids.highlybid == 2)
           {
               p2ResultsPlace.Text = bids.counter + " " + bids.shapShow;
               p2ResultsPlace.FontSize = 30;
           }
           else if (bids.highlybid == 3)
           {
               p3ResultsPlace.Text = bids.counter + " " + bids.shapShow;
               p3ResultsPlace.FontSize = 30;
           }
           else
           {
               if (bids.passTapped == 1)
               {
                   p4results.Text = "Pass !";
                   p4results.FontSize = 30;
                   p4results.Foreground = GetBrushFromHexColor("#FFF72121");

                   await Task.Delay(TimeSpan.FromSeconds(3));
                   p4results.Text = " ";
               }
               else
               {
                   if (four.FontSize == 80)
                   {
                       bids.counter = 4;
                       bids.allBids += 4;
                   }
                   else if (five.FontSize == 80)
                   {
                       bids.counter = 5; 
                       bids.allBids += 5;
                   }
                   else if (six.FontSize == 80)
                   {
                       bids.counter = 6;
                       bids.allBids += 6;
                   }
                   else if (seven.FontSize == 80)
                   {
                       bids.counter = 7;
                      bids.allBids += 7;
                   }
                   else if (eight.FontSize == 80)
                   {
                       bids.counter = 8;
                       bids.allBids += 8;
                   }
                   else if (nine.FontSize == 80)
                   {
                       bids.counter = 9;
                       bids.allBids += 9;
                   }
                   else if (ten.FontSize == 80)
                   {
                       bids.counter = 10;
                       bids.allBids += 10;
                   }
                   else if (eleven.FontSize == 80)
                   {
                       bids.counter = 11;
                       bids.allBids += 11;
                   }
                   else if (twelve.FontSize == 80)
                   {
                       bids.counter = 12;
                       bids.allBids += 12;
                   }
                   else
                   {
                       bids.counter = 13;
                       bids.allBids += 13;
                   }
                   if (C.FontSize == 80)
                   {
                       bids.sort = "C";
                       bids.shapShow = "♣";
                   }
                   else if (D.FontSize == 80)
                   {
                       bids.sort = "D";
                       bids.shapShow = "♦";
                   }
                   else if (H.FontSize == 80)
                   {
                       bids.sort = "H";
                       bids.shapShow = "❤";
                   }
                   else
                   {
                       bids.sort = "S";
                       bids.shapShow = "♠";
                   }

                   p4ResultsPlace.Text = bids.counter + " " + bids.shapShow;
                   p4ResultsPlace.FontSize = 30;
               }
           }
       }
      async  private void Pass_Tapped(object sender, TappedRoutedEventArgs e)
        {
            bids.passTapped = 1;
            Pass.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            Pass.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            Pass.Visibility = Visibility.Collapsed;
            await Task.Delay(TimeSpan.FromSeconds(0.1));
            Pass.Visibility = Visibility.Visible;
            bidOrPass.Visibility = Visibility.Collapsed;
            p4results.Text = "Pass !";
            p4results.FontSize = 30;
            p4results.Foreground = GetBrushFromHexColor("#FFF72121");

            await Task.Delay(TimeSpan.FromSeconds(3));
            p4results.Text = " ";
            bids.pass++;

            if (bids.pass % 4 == 0 && bids.pass >= 4)
            {
                this.Frame.Navigate(typeof(Game));
            }
            else
            {
                bidOrPass.Visibility = Visibility.Collapsed;
                FinalResultForBids();
                Recheck();
            }
        }

        #endregion

        //5-Last Bid
        #region Last Bid

      async void p1Bid()
      {
          if (bids.sort == "C")
              bids.shapShow = "♣";
          else if(bids.sort == "D")
              bids.shapShow = "♦";
          else if(bids.sort == "S")
              bids.shapShow = "♠";
          else if (bids.sort == "H")
              bids.shapShow = "❤";


              if (dash.dashcall1 == 0)
              {
                  if (bids.highlybid != 1)
                  {
                      //for choose number of bids
                      for (int i = 0; i < cardObj.player1.Count; i++)
                      {
                          if (cardObj.player1[i].Value == 14 || cardObj.player1[i].Value == 13 || cardObj.player1[i].Value == 12)
                              bid11++;
                      }

                      if (bid11 == 0)
                      {
                          p1ResultsPlace.Text = "Dash";
                          bids.LastBid1 = 0;
                      }
                      else if (bid11 == 1 && (bids.allBids + 1) != 13)
                      {
                          p1ResultsPlace.Text = "1";
                          bids.LastBid1 = 1;
                      }
                      else if (bid11 == 2 && (bids.allBids + 2) != 13)
                      {
                          p1ResultsPlace.Text = "2";
                          bids.LastBid1 = 2;
                      }
                      else if (bid11 == 3 && (bids.allBids + 3) != 13)
                      {
                          p1ResultsPlace.Text = "3";
                          bids.LastBid1 = 3;
                      }
                      else if (bid11 == 4 && (bids.allBids + 4) != 13)
                      {
                          p1ResultsPlace.Text = "4";
                          bids.LastBid1 = 4;
                      }
                      else if (bids.counter == 5 && bid11 == 5 && (bids.allBids + 5) != 13)
                      {
                          p1ResultsPlace.Text = "5";
                          bids.LastBid1 = 5;
                      }
                      else if (bids.counter == 6 && bid11 == 6 && (bids.allBids + 6) != 13)
                      {
                          p1ResultsPlace.Text = "6";
                          bids.LastBid1 = 6;
                      }
                      else if (bids.counter == 7 && bid11 == 7 && (bids.allBids + 7) != 13)
                      {
                          p1ResultsPlace.Text = "7";
                          bids.LastBid1 = 7;
                      }
                      else if (bids.counter == 8 && bid11 == 8 && (bids.allBids + 8) != 13)
                      {
                          p1ResultsPlace.Text = "8";
                          bids.LastBid1 = 8;
                      }
                      else if (bids.counter == 9 && bid11 == 9 && (bids.allBids + 9) != 13)
                      {
                          p1ResultsPlace.Text = "9";
                          bids.LastBid1 = 9;
                      }
                      else
                      {
                          if ((bids.allBids + 3) != 13)
                          {
                              p1ResultsPlace.Text = "3";
                              bids.LastBid1 = 3;
                          }
                          else if ((bids.allBids + 2) != 13)
                          {
                              p1ResultsPlace.Text = "2";
                              bids.LastBid1 = 2;
                          }
                          else
                          {
                              p1ResultsPlace.Text = "dash";
                              bids.LastBid1 = 0;
                          }
                      }


                      p1ResultsPlace.FontSize = 30;
                      p1ResultsPlace.Foreground = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
                      p1ResultsPlace.FontWeight = FontWeights.Bold;
                      bids.allBids += bid11;
                  }
                  else
                  {
                      bids.allBids += bids.counter;
                      p1ResultsPlace.Text = bids.counter.ToString() + " " + bids.shapShow;
                      p1ResultsPlace.FontSize = 30;
                      p1ResultsPlace.Foreground = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
                      p1ResultsPlace.FontWeight = FontWeights.Bold;
                      bids.LastBid1 = bids.counter;
                  }
                  await Task.Delay(TimeSpan.FromSeconds(1));
                  p2Bid();
              }
              else
              {
                  bids.LastBid1 = 0;
                  bids.allBids += 0;
                  p1ResultsPlace.Text = "Dash Call";

                  p1ResultsPlace.FontSize = 30;
                  p1ResultsPlace.Foreground = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
                  p1ResultsPlace.FontWeight = FontWeights.Bold;
                  await Task.Delay(TimeSpan.FromSeconds(1));
                  p2Bid();
              }
      }
      async void p2Bid()
      {
          if (dash.dashcall2 == 0)
          {
              if (bids.highlybid != 2)
              {
                  //for choose number of bids
                  for (int i = 0; i < cardObj.player2.Count; i++)
                  {
                      if (cardObj.player2[i].Value == 14 || cardObj.player2[i].Value == 13 || cardObj.player2[i].Value == 12)
                          bid22++;
                  }

                  if (bid22 == 0)
                  {
                      p2ResultsPlace.Text = "Dash";
                      bids.LastBid2 = 0;
                  }

                  else if (bid22 == 1 && (bids.allBids + 1) != 13)
                  {
                      p2ResultsPlace.Text = "1";
                      bids.LastBid2 = 1;
                  }
                  else if (bid22 == 2 && (bids.allBids + 2) != 13)
                  {
                      p2ResultsPlace.Text = "2";
                      bids.LastBid2 = 2;
                  }
                  else if (bid22 == 3 && (bids.allBids + 3) != 13)
                  {
                      p2ResultsPlace.Text = "3";
                      bids.LastBid2 = 3;
                  }
                  else if (bid22 == 4 && (bids.allBids + 4) != 13)
                  {
                      p2ResultsPlace.Text = "4";
                      bids.LastBid2 = 4;
                  }
                  else if (bids.counter == 5 && bid22 == 5 && (bids.allBids + 5) != 13)
                  {
                      p2ResultsPlace.Text = "5";
                      bids.LastBid2 = 5;
                  }
                  else if (bids.counter == 6 && bid22 == 6 && (bids.allBids + 6) != 13)
                  {
                      p2ResultsPlace.Text = "6";
                      bids.LastBid2 = 6;
                  }
                  else if (bids.counter == 7 && bid22 == 7 && (bids.allBids + 7) != 13)
                  {
                      p2ResultsPlace.Text = "7";
                      bids.LastBid2 = 7;
                  }
                  else if (bids.counter == 8 && bid22 == 8 && (bids.allBids + 8) != 13)
                  {
                      p2ResultsPlace.Text = "8";
                      bids.LastBid2 = 8;
                  }
                  else if (bids.counter == 9 && bid22 == 9 && (bids.allBids + 9) != 13)
                  {
                      p2ResultsPlace.Text = "9";
                      bids.LastBid2 = 9;
                  }
                  else
                  {
                      if ((bids.allBids + 3) != 13)
                      {
                          p2ResultsPlace.Text = "3";
                          bids.LastBid2 = 3;
                      }
                      else if ((bids.allBids + 2) != 13)
                      {
                          p2ResultsPlace.Text = "2";
                          bids.LastBid2 = 2;
                      }
                      else
                      {
                          p2ResultsPlace.Text = "dash";
                          bids.LastBid2 = 0;
                      }
                  }
                  p2ResultsPlace.FontSize = 30;
                  p2ResultsPlace.Foreground = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
                  p2ResultsPlace.FontWeight = FontWeights.Bold;
                  bids.allBids += bid22;
              }
              else
              {

                  bids.allBids += bids.counter;
                  p2ResultsPlace.Text = bids.counter.ToString() + " " + bids.shapShow;

                  p2ResultsPlace.FontSize = 30;
                  p2ResultsPlace.Foreground = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
                  p2ResultsPlace.FontWeight = FontWeights.Bold;
                  bids.LastBid2 = bids.counter;
              }
              await Task.Delay(TimeSpan.FromSeconds(1));
              p3Bid();
          }
          else
          {
              bids.LastBid2 = 0;
              bids.allBids += 0; 
              p2ResultsPlace.Text = "Dash Call";

              p2ResultsPlace.FontSize = 30;
              p2ResultsPlace.Foreground = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
              p2ResultsPlace.FontWeight = FontWeights.Bold;
              await Task.Delay(TimeSpan.FromSeconds(1));
              p3Bid();
          }
      }
      async void p3Bid()
      {
          if (dash.dashcall3 == 0)
          {
              if (bids.highlybid != 3)
              {
                  //for choose number of bids
                  for (int i = 0; i < cardObj.player3.Count; i++)
                  {
                      if (cardObj.player3[i].Value == 14 || cardObj.player3[i].Value == 13 || cardObj.player3[i].Value == 12)
                          bid33++;
                  }

                  if (bid33 == 0)
                  {
                      p3ResultsPlace.Text = "Dash";
                      bids.LastBid3 = 0;
                  }

                  else if (bid33 == 1 && (bids.allBids + 1) != 13)
                  {
                      p3ResultsPlace.Text = "1";
                      bids.LastBid3 = 1;
                  }
                  else if (bid33 == 2 && (bids.allBids + 2) != 13)
                  {
                      p3ResultsPlace.Text = "2";
                      bids.LastBid3 = 2;
                  }
                  else if (bid33 == 3 && (bids.allBids + 3) != 13)
                  {
                      p3ResultsPlace.Text = "3";
                      bids.LastBid3 = 3;
                  }
                  else if (bid33 == 4 && (bids.allBids + 4) != 13)
                  {
                      p3ResultsPlace.Text = "4";
                      bids.LastBid3 = 4;
                  }
                  else if (bids.counter == 5 && bid33 == 5 && (bids.allBids + 5) != 13)
                  {
                      p3ResultsPlace.Text = "5";
                      bids.LastBid3 = 5;
                  }
                  else if (bids.counter == 6 && bid33 == 6 && (bids.allBids + 6) != 13)
                  {
                      p3ResultsPlace.Text = "6";
                      bids.LastBid3 = 6;
                  }
                  else if (bids.counter == 7 && bid33 == 7 && (bids.allBids + 7) != 13)
                  {
                      p3ResultsPlace.Text = "7";
                      bids.LastBid3 = 7;
                  }
                  else if (bids.counter == 8 && bid33 == 8 && (bids.allBids + 8) != 13)
                  {
                      p3ResultsPlace.Text = "8";
                      bids.LastBid3 = 8;
                  }
                  else if (bids.counter == 9 && bid33 == 9 && (bids.allBids + 9) != 13)
                  {
                      p3ResultsPlace.Text = "9";
                      bids.LastBid3 = 9;
                  }
                  else
                  {
                      if ((bids.allBids + 3) != 13)
                      {
                          p3ResultsPlace.Text = "3";
                          bids.LastBid3 = 3;
                      }
                      else if ((bids.allBids + 2) != 13)
                      {
                          p3ResultsPlace.Text = "2";
                          bids.LastBid3 = 2;
                      }
                      else
                      {
                          p3ResultsPlace.Text = "dash";
                          bids.LastBid3 = 0;
                      }
                  }

                  p3ResultsPlace.FontSize = 30;
                  p3ResultsPlace.Foreground = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
                  p3ResultsPlace.FontWeight = FontWeights.Bold;
                  bids.allBids += bid33;
              }
              else
              {
                  bids.LastBid3 = bids.counter;
                  bids.allBids += bids.counter;
                  p3ResultsPlace.Text = bids.counter.ToString() + " " + bids.shapShow;

                  p3ResultsPlace.FontSize = 30;
                  p3ResultsPlace.Foreground = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
                  p3ResultsPlace.FontWeight = FontWeights.Bold;
              }
              await Task.Delay(TimeSpan.FromSeconds(1));
              p4Bid();
           }
          else
          {
              bids.LastBid3 = 0;
              bids.allBids += 0; 
              p3ResultsPlace.Text = "Dash Call";

              p3ResultsPlace.FontSize = 30;
              p3ResultsPlace.Foreground = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
              p3ResultsPlace.FontWeight = FontWeights.Bold;
              await Task.Delay(TimeSpan.FromSeconds(1));
              p4Bid();
          }
      }
       void p4Bid()
        {
            if (dash.dashcall4 == 0)
            {
                if (bids.highlybid != 4)
                {
                    LastBid.Visibility = Visibility.Visible;
                    fiveL.Visibility = Visibility.Collapsed;
                    sixL.Visibility = Visibility.Collapsed;
                    sevenL.Visibility = Visibility.Collapsed;
                    eightL.Visibility = Visibility.Collapsed;
                    nineL.Visibility = Visibility.Collapsed;
                    tenL.Visibility = Visibility.Collapsed;
                    elevenL.Visibility = Visibility.Collapsed;
                    twelveL.Visibility = Visibility.Collapsed;
                    thirteenL.Visibility = Visibility.Collapsed;
                    if (bids.counter == 5)
                        fiveL.Visibility = Visibility.Visible;
                    else if (bids.counter == 6)
                    {
                        fiveL.Visibility = Visibility.Visible;
                        sixL.Visibility = Visibility.Visible;
                    }
                    else if (bids.counter == 7)
                    {
                        fiveL.Visibility = Visibility.Visible;
                        sixL.Visibility = Visibility.Visible;
                        sevenL.Visibility = Visibility.Visible;
                    }
                    else if (bids.counter == 8)
                    {
                        fiveL.Visibility = Visibility.Visible;
                        sixL.Visibility = Visibility.Visible;
                        sevenL.Visibility = Visibility.Visible;
                        eightL.Visibility = Visibility.Visible;
                    }
                    else if (bids.counter == 9)
                    {
                        fiveL.Visibility = Visibility.Visible;
                        sixL.Visibility = Visibility.Visible;
                        sevenL.Visibility = Visibility.Visible;
                        eightL.Visibility = Visibility.Visible;
                        nineL.Visibility = Visibility.Visible;
                    }
                    else if (bids.counter == 10)
                    {
                        fiveL.Visibility = Visibility.Visible;
                        sixL.Visibility = Visibility.Visible;
                        sevenL.Visibility = Visibility.Visible;
                        eightL.Visibility = Visibility.Visible;
                        nineL.Visibility = Visibility.Visible;
                        tenL.Visibility = Visibility.Visible;
                    }
                    else if (bids.counter == 11)
                    {
                        fiveL.Visibility = Visibility.Visible;
                        sixL.Visibility = Visibility.Visible;
                        sevenL.Visibility = Visibility.Visible;
                        eightL.Visibility = Visibility.Visible;
                        nineL.Visibility = Visibility.Visible;
                        tenL.Visibility = Visibility.Visible;
                        elevenL.Visibility = Visibility.Visible;
                    }
                    else if (bids.counter == 12)
                    {
                        fiveL.Visibility = Visibility.Visible;
                        sixL.Visibility = Visibility.Visible;
                        sevenL.Visibility = Visibility.Visible;
                        eightL.Visibility = Visibility.Visible;
                        nineL.Visibility = Visibility.Visible;
                        tenL.Visibility = Visibility.Visible;
                        elevenL.Visibility = Visibility.Visible;
                        twelveL.Visibility = Visibility.Visible;
                    }
                    else if (bids.counter == 13)
                    {
                        fiveL.Visibility = Visibility.Visible;
                        sixL.Visibility = Visibility.Visible;
                        sevenL.Visibility = Visibility.Visible;
                        eightL.Visibility = Visibility.Visible;
                        nineL.Visibility = Visibility.Visible;
                        tenL.Visibility = Visibility.Visible;
                        elevenL.Visibility = Visibility.Visible;
                        twelveL.Visibility = Visibility.Visible;
                        thirteenL.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    bids.LastBid4 = bids.counter;
                    OnGame.BidsWinner = bids.highlybid;
                    gameController();
                }
                if ((bids.allBids + 1) == 13)
                    oneL.Visibility = Visibility.Collapsed;
                else  if ((bids.allBids + 2) == 13)
                    twoL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 3) == 13)
                    threeL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 4) == 13)
                    fourL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 5) == 13)
                    fiveL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 6) == 13)
                    sixL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 7) == 13)
                    sevenL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 8) == 13)
                    eightL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 9) == 13)
                    nineL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 10) == 13)
                    tenL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 11) == 13)
                    elevenL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 12) == 13)
                    twelveL.Visibility = Visibility.Collapsed;
                else if ((bids.allBids + 13) == 13)
                    thirteenL.Visibility = Visibility.Collapsed;

                //gameController();
            }
           else
            {
                bids.LastBid4 = 0;
                bids.allBids += 0;
                p4ResultsPlace.Text = "Dash Call";

                p4ResultsPlace.FontSize = 30;
                p4ResultsPlace.Foreground = new SolidColorBrush(Windows.UI.Colors.WhiteSmoke);
                p4ResultsPlace.FontWeight = FontWeights.Bold;
                OnGame.BidsWinner = bids.highlybid;
                gameController();
            }

        }

       private void bidL_Tapped(object sender, TappedRoutedEventArgs e)
       {
           if (sender == zeroL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFFF6745");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 80;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == oneL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFFF6745");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 80;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == twoL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFFF6745");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 80;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == threeL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFFF6745");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 80;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == fourL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFFF6745");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 80;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == fiveL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFFF6745");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 80;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == sixL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFFF6745");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 80;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == sevenL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFFF6745");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 80;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == eightL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFFF6745");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 80;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == nineL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFFF6745");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 80;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == tenL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFFF6745");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 80;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == elevenL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFFF6745");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 80;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 72;
           }
           else if (sender == twelveL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFFF6745");
               thirteenL.Foreground = GetBrushFromHexColor("#FFF90000");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 80;
               thirteenL.FontSize = 72;
           }
           else if (sender == thirteenL)
           {
               zeroL.Foreground = GetBrushFromHexColor("#FFF90000");
               oneL.Foreground = GetBrushFromHexColor("#FFF90000");
               twoL.Foreground = GetBrushFromHexColor("#FFF90000");
               threeL.Foreground = GetBrushFromHexColor("#FFF90000");
               fourL.Foreground = GetBrushFromHexColor("#FFF90000");
               fiveL.Foreground = GetBrushFromHexColor("#FFF90000");
               sixL.Foreground = GetBrushFromHexColor("#FFF90000");
               sevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               eightL.Foreground = GetBrushFromHexColor("#FFF90000");
               nineL.Foreground = GetBrushFromHexColor("#FFF90000");
               tenL.Foreground = GetBrushFromHexColor("#FFF90000");
               elevenL.Foreground = GetBrushFromHexColor("#FFF90000");
               twelveL.Foreground = GetBrushFromHexColor("#FFF90000");
               thirteenL.Foreground = GetBrushFromHexColor("#FFFF6745");

               zeroL.FontSize = 72;
               oneL.FontSize = 72;
               twoL.FontSize = 72;
               threeL.FontSize = 72;
               fourL.FontSize = 72;
               fiveL.FontSize = 72;
               sixL.FontSize = 72;
               sevenL.FontSize = 72;
               eightL.FontSize = 72;
               nineL.FontSize = 72;
               tenL.FontSize = 72;
               elevenL.FontSize = 72;
               twelveL.FontSize = 72;
               thirteenL.FontSize = 80;
           }


       }

       private async void BidL_Tapped(object sender, TappedRoutedEventArgs e)
       {
           int bid;

           BidL.Visibility = Visibility.Collapsed;
           await Task.Delay(TimeSpan.FromSeconds(0.1));
           BidL.Visibility = Visibility.Visible;
           await Task.Delay(TimeSpan.FromSeconds(0.1));
           BidL.Visibility = Visibility.Collapsed;
           await Task.Delay(TimeSpan.FromSeconds(0.1));
           BidL.Visibility = Visibility.Visible;

           LastBid.Visibility = Visibility.Collapsed;

           if (zeroL.FontSize == 80)
           {
               bid = 0;
               bids.allBids += 0;
               bids.LastBid4 = 0;
           }
           else if (oneL.FontSize == 80)
           {
               bid = 1;
               bids.allBids += 1;
              
           }
           else if (twoL.FontSize == 80)
           {
               bid = 2;
               bids.allBids += 2;
           }
           else if (threeL.FontSize == 80)
           {
               bid = 3;
               bids.allBids += 3;
           }
           else if (fourL.FontSize == 80)
           {
               bid = 4;
               bids.allBids += 4;
           }
           else if (fiveL.FontSize == 80)
           {
               bid = 5;
               bids.allBids += 5;
           }
           else if (sixL.FontSize == 80)
           {
               bid = 6;
               bids.allBids += 6;
           }
           else if (sevenL.FontSize == 80)
           {
               bid = 7;
               bids.allBids += 7;
           }
           else if (eightL.FontSize == 80)
           {
               bid = 8;
               bids.allBids += 8;
           }
           else if (nineL.FontSize == 80)
           {
               bid = 9;
               bids.allBids += 9;
           }
           else if (tenL.FontSize == 80)
           {
               bid = 10;
               bids.allBids += 10;
           }
           else if (elevenL.FontSize == 80)
           {
               bid = 11;
               bids.allBids += 11;
           }
           else if (twelveL.FontSize == 80)
           {
               bid = 12;
               bids.allBids += 12;
           }
           else
           {
               bid = 13;
               bids.allBids += 13;
           }

           p4ResultsPlace.Text = bid.ToString();
           p4ResultsPlace.FontSize = 30;
           bids.LastBid4 = bid;
           OnGame.BidsWinner = bids.highlybid;
           gameController();
       }
        #endregion

      

        //6-on game
        #region On Game
     async  void gameController()
       {
           await Task.Delay(TimeSpan.FromSeconds(1));
           
           p3BidPlace.Children.Clear();
           p2BidPlace.Children.Clear();
           p1BidPlace.Children.Clear();
           if (OnGame.collapse40 == 1)
               card40.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse41 == 1)
               card41.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse42 == 1)
               card42.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse43 == 1)
               card43.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse44 == 1)
               card44.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse45 == 1)
               card45.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse46== 1)
               card46.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse47 == 1)
               card47.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse48 == 1)
               card48.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse49 == 1)
               card49.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse50 == 1)
               card50.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse51 == 1)
               card51.Visibility = Visibility.Collapsed;
           else if (OnGame.collapse52 == 1)
               card52.Visibility = Visibility.Collapsed;
           card40.ManipulationMode = ManipulationModes.All;
           card41.ManipulationMode = ManipulationModes.All;
           card42.ManipulationMode = ManipulationModes.All;
           card43.ManipulationMode = ManipulationModes.All;
           card44.ManipulationMode = ManipulationModes.All;
           card45.ManipulationMode = ManipulationModes.All;
           card46.ManipulationMode = ManipulationModes.All;
           card47.ManipulationMode = ManipulationModes.All;
           card48.ManipulationMode = ManipulationModes.All;
           card49.ManipulationMode = ManipulationModes.All;
           card50.ManipulationMode = ManipulationModes.All;
           card51.ManipulationMode = ManipulationModes.All;
           card52.ManipulationMode = ManipulationModes.All;
           pointermov40 = 0;
           pointermov41 = 0;
           pointermov42 = 0;
           pointermov43 = 0;
           pointermov44 = 0;
           pointermov45 = 0;
           pointermov46 = 0;
           pointermov47 = 0;
           pointermov48 = 0;
           pointermov49 = 0;
           pointermov50 = 0;
           pointermov51 = 0;
           pointermov52 = 0;
           
           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p3num && OnGame.p1num > OnGame.p4num)
           {
               if (OnGame.p1Sort[0] == bids.sort[0])
               {
                   OnGame.p1counter++;
                   bids.highlybid = 1;
                   p1results.Text = OnGame.p1counter.ToString();
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
               else if (OnGame.p2Sort[0] == bids.sort[0] && OnGame.p1Sort[0] != bids.sort[0])
               {
                   if (OnGame.p3Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p4Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p2num > OnGame.p3num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p2num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p2num > OnGame.p3num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else 
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       
                    }
                   else if (OnGame.p4Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p2num > OnGame.p4num)
                       {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p2counter++;
                       p2results.Text = OnGame.p2counter.ToString();
                       bids.highlybid = 2;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }

               }
               else if (OnGame.p3Sort[0] == bids.sort[0] && OnGame.p1Sort[0] != bids.sort[0])
               {
                   if (OnGame.p2Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p4Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p2num > OnGame.p3num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p2num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p2num > OnGame.p3num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p3num > OnGame.p4num)
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p3counter++;
                       p3results.Text = OnGame.p3counter.ToString();
                       bids.highlybid = 3;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }
               else if (OnGame.p4Sort[0] == bids.sort[0] && OnGame.p1Sort[0] != bids.sort[0])
               {
                   if (OnGame.p2Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p3Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p2num > OnGame.p3num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p2num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p3Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p3num > OnGame.p4num)
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p4counter++;
                       p4results.Text = OnGame.p4counter.ToString();
                       bids.highlybid = 4;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }



              else if (OnGame.p1Sort[0] == OnGame.Kind[0])
               {
                   OnGame.p1counter++;
                   bids.highlybid = 1;
                   p1results.Text = OnGame.p1counter.ToString();
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
               else if (OnGame.p2Sort[0] == OnGame.Kind[0] && OnGame.p1Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p3Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p4Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p2num > OnGame.p3num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p2num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p2num > OnGame.p3num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p2num > OnGame.p4num)
                       {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p2counter++;
                       p2results.Text = OnGame.p2counter.ToString();
                       bids.highlybid = 2;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }

               }
               else if (OnGame.p3Sort[0] == OnGame.Kind[0] && OnGame.p1Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p2Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p4Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p2num > OnGame.p3num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p2num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p2num > OnGame.p3num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p3num > OnGame.p4num)
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p3counter++;
                       p3results.Text = OnGame.p3counter.ToString();
                       bids.highlybid = 3;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }
               else if (OnGame.p4Sort[0] == OnGame.Kind[0] && OnGame.p1Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p2Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p3Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p2num > OnGame.p3num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p2num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p3Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p3num > OnGame.p4num)
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p4counter++;
                       p4results.Text = OnGame.p4counter.ToString();
                       bids.highlybid = 4;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }




               else
               {
                   OnGame.p1counter++;
                   bids.highlybid = 1;
                   p1results.Text = OnGame.p1counter.ToString();
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
           }





           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p3num && OnGame.p2num > OnGame.p4num)
           {
               if (OnGame.p2Sort[0] == bids.sort[0])
               {
                   OnGame.p2counter++;
                   p2results.Text = OnGame.p2counter.ToString();
                   bids.highlybid = 2;
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
               else if (OnGame.p1Sort[0] == bids.sort[0] && OnGame.p2Sort[0] != bids.sort[0])
               {
                   if (OnGame.p3Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p4Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p1num > OnGame.p3num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p1num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p1num > OnGame.p4num)
                       {
                           OnGame.p1counter++;
                           bids.highlybid = 1;
                           p1results.Text = OnGame.p1counter.ToString();
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p1counter++;
                       p1results.Text = OnGame.p1counter.ToString();
                       bids.highlybid = 1;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }

               }
               else if (OnGame.p3Sort[0] == bids.sort[0] && OnGame.p1Sort[0] != bids.sort[0])
               {
                   if (OnGame.p1Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p4Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p1num > OnGame.p3num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p1num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p3num > OnGame.p4num)
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p3counter++;
                       p3results.Text = OnGame.p3counter.ToString();
                       bids.highlybid = 3;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }
               else if (OnGame.p4Sort[0] == bids.sort[0] && OnGame.p1Sort[0] != bids.sort[0])
               {
                   if (OnGame.p1Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p3Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p1num > OnGame.p3num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p1num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p3Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p3num > OnGame.p4num)
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p4counter++;
                       p4results.Text = OnGame.p4counter.ToString();
                       bids.highlybid = 4;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }



               else if (OnGame.p2Sort[0] == OnGame.Kind[0])
               {
                   OnGame.p2counter++;
                   p2results.Text = OnGame.p2counter.ToString();
                   bids.highlybid = 2;
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
               else if (OnGame.p1Sort[0] == OnGame.Kind[0] && OnGame.p2Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p3Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p4Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p1num > OnGame.p3num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p1num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p1num > OnGame.p4num)
                       {
                           OnGame.p1counter++;
                           bids.highlybid = 1;
                           p1results.Text = OnGame.p1counter.ToString();
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p1counter++;
                       bids.highlybid = 1;
                       p1results.Text = OnGame.p1counter.ToString();
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }

               }
               else if (OnGame.p3Sort[0] == OnGame.Kind[0] && OnGame.p1Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p1Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p4Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p1num > OnGame.p3num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p1num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p3num > OnGame.p4num)
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p3counter++;
                       p3results.Text = OnGame.p3counter.ToString();
                       bids.highlybid = 3;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }
               else if (OnGame.p4Sort[0] == OnGame.Kind[0] && OnGame.p1Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p1Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p3Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p1num > OnGame.p3num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p3num > OnGame.p1num && OnGame.p3num > OnGame.p4num)
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p3Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p3num > OnGame.p4num)
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p4counter++;
                       p4results.Text = OnGame.p4counter.ToString();
                       bids.highlybid = 4;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }



               else
               {
                   OnGame.p2counter++;
                   bids.highlybid = 2;
                   p2results.Text = OnGame.p2counter.ToString();
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
           }






           else if (OnGame.p3num > OnGame.p2num && OnGame.p3num > OnGame.p1num && OnGame.p3num > OnGame.p4num)
           {
               if (OnGame.p3Sort[0] == bids.sort[0])
               {
                   OnGame.p3counter++;
                   p3results.Text = OnGame.p3counter.ToString();
                   bids.highlybid = 3;
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
               else if (OnGame.p1Sort[0] == bids.sort[0] && OnGame.p3Sort[0] != bids.sort[0])
               {
                   if (OnGame.p2Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p4Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p2num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p1num > OnGame.p4num)
                       {
                           OnGame.p1counter++;
                           bids.highlybid = 1;
                           p1results.Text = OnGame.p1counter.ToString();
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p1counter++;
                       p1results.Text = OnGame.p1counter.ToString();
                       bids.highlybid = 1;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }

               }
               else if (OnGame.p2Sort[0] == bids.sort[0] && OnGame.p1Sort[0] != bids.sort[0])
               {
                   if (OnGame.p1Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p4Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p2num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p2num > OnGame.p4num)
                       {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }
               else if (OnGame.p4Sort[0] == bids.sort[0] && OnGame.p1Sort[0] != bids.sort[0])
               {
                   if (OnGame.p1Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p2Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               p1results.Text = OnGame.p1counter.ToString();
                               bids.highlybid = 1;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p2Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p2num > OnGame.p4num)
                       {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p4counter++;
                       p4results.Text = OnGame.p4counter.ToString();
                       bids.highlybid = 4;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }



               else if (OnGame.p3Sort[0] == OnGame.Kind[0])
               {
                   OnGame.p3counter++;
                   p3results.Text = OnGame.p3counter.ToString();
                   bids.highlybid = 3;
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
               else if (OnGame.p1Sort[0] == OnGame.Kind[0] && OnGame.p3Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p2Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p4Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p2num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p1num > OnGame.p4num)
                       {
                           OnGame.p1counter++;
                           bids.highlybid = 1;
                           p1results.Text = OnGame.p1counter.ToString();
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p1counter++;
                       bids.highlybid = 1;
                       p1results.Text = OnGame.p1counter.ToString();
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }

               }
               else if (OnGame.p2Sort[0] == OnGame.Kind[0] && OnGame.p1Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p1Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p4Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p2num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p4Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p2num > OnGame.p4num)
                       {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p2counter++;
                       p2results.Text = OnGame.p2counter.ToString();
                       bids.highlybid = 2;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }
               else if (OnGame.p4Sort[0] == OnGame.Kind[0] && OnGame.p1Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p1Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p2Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p4num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p4num)
                           {
                               OnGame.p1counter++;
                               p1results.Text = OnGame.p1counter.ToString();
                               bids.highlybid = 1;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p4counter++;
                               p4results.Text = OnGame.p4counter.ToString();
                               bids.highlybid = 4;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p2Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p2num > OnGame.p4num)
                       {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p4counter++;
                           p4results.Text = OnGame.p4counter.ToString();
                           bids.highlybid = 4;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p4counter++;
                       p4results.Text = OnGame.p4counter.ToString();
                       bids.highlybid = 4;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }





               else
               {
                   OnGame.p3counter++;
                   p3results.Text = OnGame.p3counter.ToString();
                   bids.highlybid = 3;
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
           }









           else if (OnGame.p4num > OnGame.p2num && OnGame.p4num > OnGame.p1num && OnGame.p4num > OnGame.p3num)
           {
               if (OnGame.p4Sort[0] == bids.sort[0])
               {
                   OnGame.p4counter++;
                   p4results.Text = OnGame.p4counter.ToString();
                   bids.highlybid = 4;
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
               else if (OnGame.p1Sort[0] == bids.sort[0] && OnGame.p4Sort[0] != bids.sort[0])
               {
                   if (OnGame.p2Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p3Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p3num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p2num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p3Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p1num > OnGame.p3num)
                       {
                           OnGame.p1counter++;
                           bids.highlybid = 1;
                           p1results.Text = OnGame.p1counter.ToString();
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p1counter++;
                       p1results.Text = OnGame.p1counter.ToString();
                       bids.highlybid = 1;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }

               }
               else if (OnGame.p2Sort[0] == bids.sort[0] && OnGame.p1Sort[0] != bids.sort[0])
               {
                   if (OnGame.p1Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p3Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p3num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p2num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p3Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p2num > OnGame.p3num)
                       {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p2counter++;
                       p2results.Text = OnGame.p2counter.ToString();
                       bids.highlybid = 2;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }
               else if (OnGame.p3Sort[0] == bids.sort[0] && OnGame.p1Sort[0] != bids.sort[0])
               {
                   if (OnGame.p1Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p2Sort[0] == bids.sort[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p3num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p2Sort[0] == bids.sort[0])
                   {
                       if (OnGame.p2num > OnGame.p3num)
                       {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p3counter++;
                       p3results.Text = OnGame.p3counter.ToString();
                       bids.highlybid = 3;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }






               else if (OnGame.p4Sort[0] == OnGame.Kind[0])
               {
                   OnGame.p4counter++;
                   p4results.Text = OnGame.p4counter.ToString();
                   bids.highlybid = 4;
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
               else if (OnGame.p1Sort[0] == OnGame.Kind[0] && OnGame.p4Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p2Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p3Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p3num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p2num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p3Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p1num > OnGame.p3num)
                       {
                           OnGame.p1counter++;
                           bids.highlybid = 1;
                           p1results.Text = OnGame.p1counter.ToString();
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p1counter++;
                       bids.highlybid = 1;
                       p1results.Text = OnGame.p1counter.ToString();
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }

               }
               else if (OnGame.p2Sort[0] == OnGame.Kind[0] && OnGame.p1Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p1Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p3Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p3num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p2num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p3Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p2num > OnGame.p3num)
                       {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p2counter++;
                       p2results.Text = OnGame.p2counter.ToString();
                       bids.highlybid = 2;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }
               else if (OnGame.p3Sort[0] == OnGame.Kind[0] && OnGame.p1Sort[0] != OnGame.Kind[0])
               {
                   if (OnGame.p1Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p2Sort[0] == OnGame.Kind[0])
                       {
                           if (OnGame.p1num > OnGame.p2num && OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else if (OnGame.p2num > OnGame.p1num && OnGame.p2num > OnGame.p3num)
                           {
                               OnGame.p2counter++;
                               p2results.Text = OnGame.p2counter.ToString();
                               bids.highlybid = 2;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }
                       else
                       {
                           if (OnGame.p1num > OnGame.p3num)
                           {
                               OnGame.p1counter++;
                               bids.highlybid = 1;
                               p1results.Text = OnGame.p1counter.ToString();
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                           else
                           {
                               OnGame.p3counter++;
                               p3results.Text = OnGame.p3counter.ToString();
                               bids.highlybid = 3;
                               await Task.Delay(TimeSpan.FromSeconds(1));
                           }
                       }

                   }
                   else if (OnGame.p2Sort[0] == OnGame.Kind[0])
                   {
                       if (OnGame.p2num > OnGame.p3num)
                       {
                           OnGame.p2counter++;
                           p2results.Text = OnGame.p2counter.ToString();
                           bids.highlybid = 2;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                       else
                       {
                           OnGame.p3counter++;
                           p3results.Text = OnGame.p3counter.ToString();
                           bids.highlybid = 3;
                           await Task.Delay(TimeSpan.FromSeconds(1));
                       }
                   }
                   else
                   {
                       OnGame.p3counter++;
                       p3results.Text = OnGame.p2counter.ToString();
                       bids.highlybid = 3;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }
               else
               {
                   OnGame.p4counter++;
                   p4results.Text = OnGame.p4counter.ToString();
                   bids.highlybid = 4;
                   await Task.Delay(TimeSpan.FromSeconds(1));
               }
           }
           else
           {
               if (OnGame.Gcounter > 0)
               {
                   if (OnGame.p4Sort[0] == bids.sort[0])
                   {
                       OnGame.p4counter++;
                       p4results.Text = OnGame.p4counter.ToString();
                       bids.highlybid = 4;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
                   else if (OnGame.p3Sort[0] == bids.sort[0])
                   {
                       OnGame.p3counter++;
                       p3results.Text = OnGame.p3counter.ToString();
                       bids.highlybid = 3;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
                   else if (OnGame.p2Sort[0] == bids.sort[0])
                   {
                       OnGame.p2counter++;
                       p2results.Text = OnGame.p2counter.ToString();
                       bids.highlybid = 2;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
                   else if (OnGame.p1Sort[0] == bids.sort[0])
                   {
                       OnGame.p1counter++;
                       p1results.Text = OnGame.p1counter.ToString();
                       bids.highlybid = 1;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
                   else if (OnGame.p3Sort[0] == OnGame.Kind[0])
                   {
                       OnGame.p3counter++;
                       p3results.Text = OnGame.p3counter.ToString();
                       bids.highlybid = 3;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
                   else if (OnGame.p2Sort[0] == OnGame.Kind[0])
                   {
                       OnGame.p2counter++;
                       p2results.Text = OnGame.p2counter.ToString();
                       bids.highlybid = 2;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
                   else if (OnGame.p1Sort[0] == OnGame.Kind[0])
                   {
                       OnGame.p1counter++;
                       p1results.Text = OnGame.p1counter.ToString();
                       bids.highlybid = 1;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
                   else
                   {
                       OnGame.p4counter++;
                       p4results.Text = OnGame.p4counter.ToString();
                       bids.highlybid = 4;
                       await Task.Delay(TimeSpan.FromSeconds(1));
                   }
               }
           }
           OnGame.Gcounter = 0;
           OnGame.collapse40 = 0;
           OnGame.collapse41 = 0;
           OnGame.collapse42 = 0;
           OnGame.collapse43 = 0;
           OnGame.collapse44 = 0;
           OnGame.collapse45 = 0;
           OnGame.collapse46 = 0;
           OnGame.collapse47 = 0;
           OnGame.collapse48 = 0;
           OnGame.collapse49 = 0;
           OnGame.collapse50 = 0;
           OnGame.collapse51 = 0;
           OnGame.collapse52 = 0;
           OnGame.CardRoundKind = null;
           OnGame.Kind = " ";
           if (OnGame.p1counter == bids.LastBid1)
           {
               p1results.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
               p1results.FontWeight = FontWeights.Bold;
               p1results.FontSize = 50;
           }
           else
           {
               p1results.Foreground = GetBrushFromHexColor("#FFF72121");
               p1results.FontWeight = FontWeights.Normal;
               p1results.FontSize = 30;
           }

           if (OnGame.p2counter == bids.LastBid2)
           {
               p2results.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
               p2results.FontWeight = FontWeights.Bold;
               p2results.FontSize = 50;
           }
           else
           {
               p2results.Foreground = GetBrushFromHexColor("#FFF72121");
               p2results.FontWeight = FontWeights.Normal;
               p2results.FontSize = 30;
           }

           if (OnGame.p3counter == bids.LastBid3)
           {
               p3results.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
               p3results.FontWeight = FontWeights.Bold;
               p3results.FontSize = 50;
           }
           else
           {
               p3results.Foreground = GetBrushFromHexColor("#FFF72121");
               p3results.FontWeight = FontWeights.Normal;
               p3results.FontSize = 30;
           }
           if (OnGame.p4counter == bids.LastBid4)
           {
               p4results.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
               p4results.FontWeight = FontWeights.Bold;
               p4results.FontSize = 50;
           }
           else
           {
               p4results.Foreground = GetBrushFromHexColor("#FFF72121");
               p4results.FontWeight = FontWeights.Normal;
               p4results.FontSize = 30;
           }

           OnGame.GameFinish++;
           if (OnGame.GameFinish != 14)
           {
               if (bids.highlybid == 1)
               {
                   P1Turn();

               }
               else if (bids.highlybid == 2)
               {
                   P2Turn();

               }
               else if (bids.highlybid == 3)
               {
                   P3Turn();

               }
               else if (bids.highlybid == 4)
               {
                   P4Turn();

               }
               await Task.Delay(TimeSpan.FromSeconds(1));
           }
           else
               FinalM();
       }
      async void P1Turn()
       {
           await Task.Delay(TimeSpan.FromSeconds(3));
           int n = 0;
           int item;
           if (bids.highlybid == 1)
           {
               if (cardObj.player1.Count > 0)
                   if (OnGame.p1counter != bids.LastBid1)
                    item = cardObj.player1.Max(x => x.Value);
                   else
                    item = cardObj.player1.Min(x => x.Value);
               else
                   item = cardObj.player1[0].Value;

               for (int i = 0; i < cardObj.player1.Count; i++)
               {
                   if (cardObj.player1[i].Value == item)
                   {
                       n = i;
                       break;
                   }
                   else
                       n = 0;
               }
               OnGame.Kind = cardObj.player1[n].Key;

               Image newImage = new Image();
               newImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[n].Key + ".png"));
               p1BidPlace.Children.Add((UIElement)newImage);
               newImage.Margin = new Thickness(0, -50, 0, 0);
               OnGame.Gcounter++;
               OnGame.p1num = cardObj.player1[n].Value;
               OnGame.p1Sort = cardObj.player1[n].Key;
               cardObj.player1.RemoveAt(n);
               grid1.Children.RemoveAt(n);
               bids.highlybid = 0;
           }
           else
           {
               item = 0;
               int lengthC = player1C.ToArray().Length;
               int lengthD = player1D.ToArray().Length;
               int lengthS = player1S.ToArray().Length;
               int lengthH = player1H.ToArray().Length;
               
                   if (OnGame.Kind[0] == 'C')
                   {
                       if (lengthC > 0)
                       {
                           if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                               item = player1C.Max(x => x.Value);
                           else
                               item = player1C.Min(x => x.Value);

                           

                           for (int i = 0; i < player1C.Count; i++)
                           {
                               if (player1C[i].Value == item)
                                   n = i;
                           }

                           player1C.RemoveAt(n);
                       }
                       else if (lengthD > 0)
                       {
                           if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                               item = player1D.Max(x => x.Value);
                           else
                               item = player1D.Min(x => x.Value);

                           for (int i = 0; i < player1D.Count; i++)
                           {
                               if (player1D[i].Value == item)
                                   n = i;
                           }
                           player1D.RemoveAt(n);

                       }
                       else if (lengthS > 0)
                       {
                           if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                               item = player1S.Max(x => x.Value);
                           else
                               item = player1S.Min(x => x.Value);

                           for (int i = 0; i < player1S.Count; i++)
                           {
                               if (player1S[i].Value == item)
                                   n = i;
                           }
                           player1S.RemoveAt(n);

                       }
                       else
                       {
                           if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                               item = player1H.Max(x => x.Value);
                           else
                               item = player1H.Min(x => x.Value);

                           for (int i = 0; i < player1H.Count; i++)
                           {
                               if (player1H[i].Value == item)
                                   n = i;
                           }
                           player1H.RemoveAt(n);
                       }
                   }
               
                   
               else if (OnGame.Kind[0] == 'D')
               {
                   if (lengthD > 0)
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1D.Max(x => x.Value);
                       else
                           item = player1D.Min(x => x.Value);

                       for (int i = 0; i < player1D.Count; i++)
                       {
                           if (player1D[i].Value == item)
                               n = i;
                       }
                       player1D.RemoveAt(n);
                   }
                   else if (lengthC > 0)
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1C.Max(x => x.Value);
                       else
                           item = player1C.Min(x => x.Value);


                       for (int i = 0; i < player1C.Count; i++)
                       {
                           if (player1C[i].Value == item)
                               n = i;
                       }

                       player1C.RemoveAt(n);
                   }
                   else if (lengthS > 0)
                   {
                       item = player1S.Min(x => x.Value);

                       for (int i = 0; i < player1S.Count; i++)
                       {
                           if (player1S[i].Value == item)
                               n = i;
                       }
                       player1S.RemoveAt(n);

                   }
                   else
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1H.Max(x => x.Value);
                       else
                           item = player1H.Min(x => x.Value);

                       for (int i = 0; i < player1H.Count; i++)
                       {
                           if (player1H[i].Value == item)
                               n = i;
                       }
                       player1H.RemoveAt(n);
                   }
               }
               else if (OnGame.Kind[0] == 'H')
               {
                   if (lengthH > 0)
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1H.Max(x => x.Value);
                       else
                           item = player1H.Min(x => x.Value);

                       for (int i = 0; i < player1H.Count; i++)
                       {
                           if (player1H[i].Value == item)
                               n = i;
                       }
                       player1H.RemoveAt(n);
                   }
                   else if (lengthC > 0)
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1C.Max(x => x.Value);
                       else
                           item = player1C.Min(x => x.Value);


                       for (int i = 0; i < player1C.Count; i++)
                       {
                           if (player1C[i].Value == item)
                               n = i;
                       }

                       player1C.RemoveAt(n);
                   }
                   else if (lengthS > 0)
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1S.Max(x => x.Value);
                       else
                           item = player1S.Min(x => x.Value);

                       for (int i = 0; i < player1S.Count; i++)
                       {
                           if (player1S[i].Value == item)
                               n = i;
                       }
                       player1S.RemoveAt(n);

                   }
                   else
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1D.Max(x => x.Value);
                       else
                           item = player1D.Min(x => x.Value);

                       for (int i = 0; i < player1D.Count; i++)
                       {
                           if (player1D[i].Value == item)
                               n = i;
                       }
                       player1D.RemoveAt(n);
                   }
               }
               else if (OnGame.Kind[0] == 'S')
               {
                   if (lengthS > 0)
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1S.Max(x => x.Value);
                       else
                           item = player1S.Min(x => x.Value);

                       for (int i = 0; i < player1S.Count; i++)
                       {
                           if (player1S[i].Value == item)
                               n = i;
                       }
                       player1S.RemoveAt(n);
                   }
                   else if (lengthC >0)
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1C.Max(x => x.Value);
                       else
                           item = player1C.Min(x => x.Value);


                       for (int i = 0; i < player1C.Count; i++)
                       {
                           if (player1C[i].Value == item)
                               n = i;
                       }

                       player1C.RemoveAt(n);
                   }
                   else if (lengthH > 0)
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1H.Max(x => x.Value);
                       else
                           item = player1H.Min(x => x.Value);

                       for (int i = 0; i < player1H.Count; i++)
                       {
                           if (player1H[i].Value == item)
                               n = i;
                       }
                       player1H.RemoveAt(n);
                   }
                   else
                   {
                       if (dash.dashcall1 == 0 && OnGame.p2num <13 && OnGame.p3num<13 && OnGame.p4num<13)
                           item = player1D.Max(x => x.Value);
                       else
                           item = player1D.Min(x => x.Value);

                       for (int i = 0; i < player1D.Count; i++)
                       {
                           if (player1D[i].Value == item)
                               n = i;
                       }
                       player1D.RemoveAt(n);
                   }
               }
               

               for (int i = 0; i < cardObj.player1.Count; i++)
               {
                   if (cardObj.player1[i].Value == item && cardObj.player1[i].Key[0] == OnGame.Kind[0])
                   {
                       n = i;
                       break;
                   }
                   else
                       n = 0;
               }
               
               Image newImage = new Image();
               newImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player1[n].Key + ".png"));
               p1BidPlace.Children.Add((UIElement)newImage);
               newImage.Margin = new Thickness(0, -50, 0, 0);
               OnGame.Gcounter++;
               OnGame.p1num = cardObj.player1[n].Value;
               OnGame.p1Sort = cardObj.player1[n].Key;
               cardObj.player1.RemoveAt(n);
               grid1.Children.RemoveAt(n);
           }
           if (OnGame.Gcounter == 4)
           {
               gameController();
               await Task.Delay(TimeSpan.FromSeconds(3));
           }
           else
           {
               P2Turn();
               await Task.Delay(TimeSpan.FromSeconds(3));
           }
           }
      async void P2Turn()
       {
           await Task.Delay(TimeSpan.FromSeconds(3));
           int n = 0;
           int item;
           if (bids.highlybid == 2)
           {
               if (cardObj.player2.Count > 0)
                   if (OnGame.p2counter != bids.LastBid2)
                       item = cardObj.player2.Max(x => x.Value);
                   else
                       item = cardObj.player2.Min(x => x.Value);
               else
                   item = cardObj.player2[0].Value;


               for (int i = 0; i < cardObj.player2.Count; i++)
               {
                   if (cardObj.player2[i].Value == item)
                   {
                       n = i;
                       break;
                   }
                   else
                       n = 0;
               }
               OnGame.Kind = cardObj.player2[n].Key;
               Image newImage = new Image();
               newImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[n].Key + ".png"));
               p2BidPlace.Children.Add((UIElement)newImage);
               newImage.Margin = new Thickness(0, -50, 0, 0);
               OnGame.Gcounter++;
               OnGame.p2num = cardObj.player2[n].Value;
               OnGame.p2Sort = cardObj.player2[n].Key;
               bids.highlybid = 0;
               cardObj.player2.RemoveAt(n);
               grid2.Children.RemoveAt(n);
           }
           else
           {
               item = 0;
               int lengthC = player2C.ToArray().Length;
               int lengthD = player2D.ToArray().Length;
               int lengthS = player2S.ToArray().Length;
               int lengthH = player2H.ToArray().Length;

               if (OnGame.Kind[0] == 'C')
               {
                   if (lengthC > 0)
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2C.Max(x => x.Value);
                       else
                           item = player2C.Min(x => x.Value);


                       for (int i = 0; i < player2C.Count; i++)
                       {
                           if (player2C[i].Value == item)
                               n = i;
                       }

                       player2C.RemoveAt(n);
                   }
                   else if (lengthD > 0)
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2D.Max(x => x.Value);
                       else
                           item = player2D.Min(x => x.Value);

                       for (int i = 0; i < player2D.Count; i++)
                       {
                           if (player2D[i].Value == item)
                               n = i;
                       }
                       player2D.RemoveAt(n);

                   }
                   else if (lengthS > 0)
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2S.Max(x => x.Value);
                       else
                           item = player2S.Min(x => x.Value);

                       for (int i = 0; i < player2S.Count; i++)
                       {
                           if (player2S[i].Value == item)
                               n = i;
                       }
                       player2S.RemoveAt(n);

                   }
                   else
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2H.Max(x => x.Value);
                       else
                           item = player2H.Min(x => x.Value);

                       for (int i = 0; i < player2H.Count; i++)
                       {
                           if (player2H[i].Value == item)
                               n = i;
                       }
                       player2H.RemoveAt(n);
                   }
               }


               else if (OnGame.Kind[0] == 'D')
               {
                   if (lengthD > 0)
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2D.Max(x => x.Value);
                       else
                           item = player2D.Min(x => x.Value);

                       for (int i = 0; i < player2D.Count; i++)
                       {
                           if (player2D[i].Value == item)
                               n = i;
                       }
                       player2D.RemoveAt(n);
                   }
                   else if (lengthC > 0)
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2C.Max(x => x.Value);
                       else
                           item = player2C.Min(x => x.Value);


                       for (int i = 0; i < player2C.Count; i++)
                       {
                           if (player2C[i].Value == item)
                               n = i;
                       }

                       player2C.RemoveAt(n);
                   }
                   else if (lengthS > 0)
                   {
                       item = player2S.Min(x => x.Value);

                       for (int i = 0; i < player2S.Count; i++)
                       {
                           if (player2S[i].Value == item)
                               n = i;
                       }
                       player2S.RemoveAt(n);

                   }
                   else
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2H.Max(x => x.Value);
                       else
                           item = player2H.Min(x => x.Value);

                       for (int i = 0; i < player2H.Count; i++)
                       {
                           if (player2H[i].Value == item)
                               n = i;
                       }
                       player2H.RemoveAt(n);
                   }
               }
               else if (OnGame.Kind[0] == 'H')
               {
                   if (lengthH > 0)
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2H.Max(x => x.Value);
                       else
                           item = player2H.Min(x => x.Value);

                       for (int i = 0; i < player2H.Count; i++)
                       {
                           if (player2H[i].Value == item)
                               n = i;
                       }
                       player2H.RemoveAt(n);
                   }
                   else if (lengthC > 0)
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2C.Max(x => x.Value);
                       else
                           item = player2C.Min(x => x.Value);


                       for (int i = 0; i < player2C.Count; i++)
                       {
                           if (player2C[i].Value == item)
                               n = i;
                       }

                       player2C.RemoveAt(n);
                   }
                   else if (lengthS > 0)
                   {
                       item = player2S.Min(x => x.Value);

                       for (int i = 0; i < player2S.Count; i++)
                       {
                           if (player2S[i].Value == item)
                               n = i;
                       }
                       player2S.RemoveAt(n);

                   }
                   else
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2D.Max(x => x.Value);
                       else
                           item = player2D.Min(x => x.Value);

                       for (int i = 0; i < player2D.Count; i++)
                       {
                           if (player2D[i].Value == item)
                               n = i;
                       }
                       player2D.RemoveAt(n);
                   }
               }
               else if (OnGame.Kind[0] == 'S')
               {
                   if (lengthS > 0)
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2S.Max(x => x.Value);
                       else
                           item = player2S.Min(x => x.Value);

                       for (int i = 0; i < player2S.Count; i++)
                       {
                           if (player2S[i].Value == item)
                               n = i;
                       }
                       player2S.RemoveAt(n);
                   }
                   else if (lengthC > 0)
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2C.Max(x => x.Value);
                       else
                           item = player2C.Min(x => x.Value);


                       for (int i = 0; i < player2C.Count; i++)
                       {
                           if (player2C[i].Value == item)
                               n = i;
                       }

                       player2C.RemoveAt(n);
                   }
                   else if (lengthH > 0)
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2H.Max(x => x.Value);
                       else
                           item = player2H.Min(x => x.Value);

                       for (int i = 0; i < player2H.Count; i++)
                       {
                           if (player2H[i].Value == item)
                               n = i;
                       }
                       player2H.RemoveAt(n);
                   }
                   else
                   {
                       if (dash.dashcall2 == 0 && OnGame.p1num < 13 && OnGame.p3num < 13 && OnGame.p4num < 13)
                           item = player2D.Max(x => x.Value);
                       else
                           item = player2D.Min(x => x.Value);

                       for (int i = 0; i < player2D.Count; i++)
                       {
                           if (player2D[i].Value == item)
                               n = i;
                       }
                       player2D.RemoveAt(n);
                   }
               }


               for (int i = 0; i < cardObj.player2.Count; i++)
               {
                   if (cardObj.player2[i].Value == item && cardObj.player2[i].Key[0] == OnGame.Kind[0])
                   {
                       n = i;
                       break;
                   }
                   else
                   {
                       n = 0;
                   }
                   }

               Image newImage = new Image();
               newImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player2[n].Key + ".png"));
               p2BidPlace.Children.Add((UIElement)newImage);
               newImage.Margin = new Thickness(0, -50, 0, 0);
               OnGame.Gcounter++;
               OnGame.p2num = cardObj.player2[n].Value;
               OnGame.p2Sort = cardObj.player2[n].Key;
               cardObj.player2.RemoveAt(n);
               grid2.Children.RemoveAt(n);
           }
           if (OnGame.Gcounter == 4)
           {
               gameController();
               await Task.Delay(TimeSpan.FromSeconds(3));
           }
           else
           {
               P3Turn();
               await Task.Delay(TimeSpan.FromSeconds(3));
           }
       }
      async void P3Turn()
       {
           await Task.Delay(TimeSpan.FromSeconds(3));
           int n = 0;
           int item;
           if (bids.highlybid == 3)
           {
               if (cardObj.player3.Count > 0)
                   if (OnGame.p3counter != bids.LastBid3)
                       item = cardObj.player3.Max(x => x.Value);
                   else
                       item = cardObj.player3.Min(x => x.Value);
               else
                   item = cardObj.player3[0].Value;


               for (int i = 0; i < cardObj.player3.Count; i++)
               {
                   if (cardObj.player3[i].Value == item)
                   {
                       n = i;
                       break;
                   }
                   else
                       n = 0;
               }
               OnGame.Kind = cardObj.player3[n].Key;
               Image newImage = new Image();
               newImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[n].Key + ".png"));
               p3BidPlace.Children.Add((UIElement)newImage);
               newImage.Margin = new Thickness(0, -50, 0, 0);
               OnGame.Gcounter++;
               OnGame.p3num = cardObj.player3[n].Value;
               OnGame.p3Sort = cardObj.player3[n].Key;
               cardObj.player3.RemoveAt(n);
               grid3.Children.RemoveAt(n);
               bids.highlybid = 0;
           }
           else
           {
               item = 0;
               int lengthC = player3C.ToArray().Length;
               int lengthD = player3D.ToArray().Length;
               int lengthS = player3S.ToArray().Length;
               int lengthH = player3H.ToArray().Length;

               if (OnGame.Kind[0] == 'C')
               {
                   if (lengthC > 0)
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3C.Max(x => x.Value);
                       else
                           item = player3C.Min(x => x.Value);


                       for (int i = 0; i < player3C.Count; i++)
                       {
                           if (player3C[i].Value == item)
                               n = i;
                       }

                       player3C.RemoveAt(n);
                   }
                   else if (lengthD > 0)
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3D.Max(x => x.Value);
                       else
                           item = player3D.Min(x => x.Value);

                       for (int i = 0; i < player3D.Count; i++)
                       {
                           if (player3D[i].Value == item)
                               n = i;
                       }
                       player3D.RemoveAt(n);

                   }
                   else if (lengthS > 0)
                   {
                        if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3S.Max(x => x.Value);
                       else
                           item = player3S.Min(x => x.Value);

                       for (int i = 0; i < player3S.Count; i++)
                       {
                           if (player3S[i].Value == item)
                               n = i;
                       }
                       player3S.RemoveAt(n);

                   }
                   else
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3H.Max(x => x.Value);
                       else
                           item = player3H.Min(x => x.Value);

                       for (int i = 0; i < player3H.Count; i++)
                       {
                           if (player3H[i].Value == item)
                               n = i;
                       }
                       player3H.RemoveAt(n);
                   }
               }


               else if (OnGame.Kind[0] == 'D')
               {
                   if (lengthD > 0)
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3D.Max(x => x.Value);
                       else
                           item = player3D.Min(x => x.Value);

                       for (int i = 0; i < player3D.Count; i++)
                       {
                           if (player3D[i].Value == item)
                               n = i;
                       }
                       player3D.RemoveAt(n);
                   }
                   else if (lengthC > 0)
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3C.Max(x => x.Value);
                       else
                           item = player3C.Min(x => x.Value);


                       for (int i = 0; i < player3C.Count; i++)
                       {
                           if (player3C[i].Value == item)
                               n = i;
                       }

                       player3C.RemoveAt(n);
                   }
                   else if (lengthS > 0)
                   {
                       item = player3S.Min(x => x.Value);

                       for (int i = 0; i < player3S.Count; i++)
                       {
                           if (player3S[i].Value == item)
                               n = i;
                       }
                       player3S.RemoveAt(n);

                   }
                   else
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3H.Max(x => x.Value);
                       else
                           item = player3H.Min(x => x.Value);

                       for (int i = 0; i < player3H.Count; i++)
                       {
                           if (player3H[i].Value == item)
                               n = i;
                       }
                       player3H.RemoveAt(n);
                   }
               }
               else if (OnGame.Kind[0] == 'H')
               {
                   if (lengthH > 0)
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3H.Max(x => x.Value);
                       else
                           item = player3H.Min(x => x.Value);

                       for (int i = 0; i < player3H.Count; i++)
                       {
                           if (player3H[i].Value == item)
                               n = i;
                       }
                       player3H.RemoveAt(n);
                   }
                   else if (lengthC > 0)
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3C.Max(x => x.Value);
                       else
                           item = player3C.Min(x => x.Value);


                       for (int i = 0; i < player3C.Count; i++)
                       {
                           if (player3C[i].Value == item)
                               n = i;
                       }

                       player3C.RemoveAt(n);
                   }
                   else if (lengthS > 0)
                   {
                       item = player3S.Min(x => x.Value);

                       for (int i = 0; i < player3S.Count; i++)
                       {
                           if (player3S[i].Value == item)
                               n = i;
                       }
                       player3S.RemoveAt(n);

                   }
                   else
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3D.Max(x => x.Value);
                       else
                           item = player3D.Min(x => x.Value);

                       for (int i = 0; i < player3D.Count; i++)
                       {
                           if (player3D[i].Value == item)
                               n = i;
                       }
                       player3D.RemoveAt(n);
                   }
               }
               else if (OnGame.Kind[0] == 'S')
               {
                   if (lengthS > 0)
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3S.Max(x => x.Value);
                       else
                           item = player3S.Min(x => x.Value);

                       for (int i = 0; i < player3S.Count; i++)
                       {
                           if (player3S[i].Value == item)
                               n = i;
                       }
                       player3S.RemoveAt(n);
                   }
                   else if (lengthC > 0)
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3C.Max(x => x.Value);
                       else
                           item = player3C.Min(x => x.Value);


                       for (int i = 0; i < player3C.Count; i++)
                       {
                           if (player3C[i].Value == item)
                               n = i;
                       }

                       player3C.RemoveAt(n);
                   }
                   else if (lengthH > 0)
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3H.Max(x => x.Value);
                       else
                           item = player3H.Min(x => x.Value);

                       for (int i = 0; i < player3H.Count; i++)
                       {
                           if (player3H[i].Value == item)
                               n = i;
                       }
                       player3H.RemoveAt(n);
                   }
                   else
                   {
                       if (dash.dashcall3 == 0 && OnGame.p1num < 13 && OnGame.p2num < 13 && OnGame.p4num < 13)
                           item = player3D.Max(x => x.Value);
                       else
                           item = player3D.Min(x => x.Value);

                       for (int i = 0; i < player3D.Count; i++)
                       {
                           if (player3D[i].Value == item)
                               n = i;
                       }
                       player3D.RemoveAt(n);
                   }
               }


               for (int i = 0; i < cardObj.player3.Count; i++)
               {
                   if (cardObj.player3[i].Value == item && cardObj.player3[i].Key[0] == OnGame.Kind[0])
                   {
                       n = i;
                       break;
                   }
                   else
                       n = 0;
               }

               Image newImage = new Image();
               newImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cards/" + cardObj.player3[n].Key + ".png"));
               p3BidPlace.Children.Add((UIElement)newImage);
               newImage.Margin = new Thickness(0, -50, 0, 0);
               OnGame.Gcounter++;
               OnGame.p3num = cardObj.player3[n].Value;
               OnGame.p3Sort = cardObj.player3[n].Key;
               cardObj.player3.RemoveAt(n);
               grid3.Children.RemoveAt(n);
           }
           if (OnGame.Gcounter == 4)
           {
               gameController();
               await Task.Delay(TimeSpan.FromSeconds(3));
           }
           else
           {
               P4Turn();
               await Task.Delay(TimeSpan.FromSeconds(3));
           }
           }
       void P4Turn()
       {
           if (OnGame.Kind[0] == 'C')
           {
               int avoid = 0;
               for (int i = 0; i < cardObj.player4.Count; i++)
               {
                   if (cardObj.player4[i].Key[0] == 'C')
                   {
                       avoid++;
                   }
               }
               if (avoid != 0)
               {
                   if (P4[0].Value[0] == 'H' || P4[0].Value[0] == 'D' || P4[0].Value[0] == 'S')
                       pointermov52 = 1;
                   if (P4[1].Value[0] == 'H' || P4[1].Value[0] == 'D' || P4[1].Value[0] == 'S')
                       pointermov51 = 1;
                   if (P4[2].Value[0] == 'H' || P4[2].Value[0] == 'D' || P4[2].Value[0] == 'S')
                       pointermov50 = 1;
                   if (P4[3].Value[0] == 'H' || P4[3].Value[0] == 'D' || P4[3].Value[0] == 'S')
                       pointermov49 = 1;
                   if (P4[4].Value[0] == 'H' || P4[4].Value[0] == 'D' || P4[4].Value[0] == 'S')
                       pointermov48 = 1;
                   if (P4[5].Value[0] == 'H' || P4[5].Value[0] == 'D' || P4[5].Value[0] == 'S')
                       pointermov47 = 1;
                   if (P4[6].Value[0] == 'H' || P4[6].Value[0] == 'D' || P4[6].Value[0] == 'S')
                       pointermov46 = 1;
                   if (P4[7].Value[0] == 'H' || P4[7].Value[0] == 'D' || P4[7].Value[0] == 'S')
                       pointermov45 = 1;
                   if (P4[8].Value[0] == 'H' || P4[8].Value[0] == 'D' || P4[8].Value[0] == 'S')
                       pointermov44 = 1;
                   if (P4[9].Value[0] == 'H' || P4[9].Value[0] == 'D' || P4[9].Value[0] == 'S')
                       pointermov43 = 1;
                   if (P4[10].Value[0] == 'H' || P4[10].Value[0] == 'D' || P4[10].Value[0] == 'S')
                       pointermov42 = 1;
                   if (P4[11].Value[0] == 'H' || P4[11].Value[0] == 'D' || P4[11].Value[0] == 'S')
                       pointermov41 = 1;
                   if (P4[12].Value[0] == 'H' || P4[12].Value[0] == 'D' || P4[12].Value[0] == 'S')
                       pointermov40 = 1;
               }
           }
          else if (OnGame.Kind[0] == 'H')
           {
              int avoid = 0;
              for (int i = 0; i < cardObj.player4.Count; i++)
              {
                  if (cardObj.player4[i].Key[0] == 'H')
                  {
                      avoid++;
                  }
              }
               if (avoid != 0)
               {
                   if (P4[0].Value[0] == 'C' || P4[0].Value[0] == 'D' || P4[0].Value[0] == 'S')
                       pointermov52 = 1;
                   if (P4[1].Value[0] == 'C' || P4[1].Value[0] == 'D' || P4[1].Value[0] == 'S')
                       pointermov51 = 1;
                   if (P4[2].Value[0] == 'C' || P4[2].Value[0] == 'D' || P4[2].Value[0] == 'S')
                       pointermov50 = 1;
                   if (P4[3].Value[0] == 'C' || P4[3].Value[0] == 'D' || P4[3].Value[0] == 'S')
                       pointermov49 = 1;
                   if (P4[4].Value[0] == 'C' || P4[4].Value[0] == 'D' || P4[4].Value[0] == 'S')
                       pointermov48 = 1;
                   if (P4[5].Value[0] == 'C' || P4[5].Value[0] == 'D' || P4[5].Value[0] == 'S')
                       pointermov47 = 1;
                   if (P4[6].Value[0] == 'C' || P4[6].Value[0] == 'D' || P4[6].Value[0] == 'S')
                       pointermov46 = 1;
                   if (P4[7].Value[0] == 'C' || P4[7].Value[0] == 'D' || P4[7].Value[0] == 'S')
                       pointermov45 = 1;
                   if (P4[8].Value[0] == 'C' || P4[8].Value[0] == 'D' || P4[8].Value[0] == 'S')
                       pointermov44 = 1;
                   if (P4[9].Value[0] == 'C' || P4[9].Value[0] == 'D' || P4[9].Value[0] == 'S')
                       pointermov43 = 1;
                   if (P4[10].Value[0] == 'C' || P4[10].Value[0] == 'D' || P4[10].Value[0] == 'S')
                       pointermov42 = 1;
                   if (P4[11].Value[0] == 'C' || P4[11].Value[0] == 'D' || P4[11].Value[0] == 'S')
                       pointermov41 = 1;
                   if (P4[12].Value[0] == 'C' || P4[12].Value[0] == 'D' || P4[12].Value[0] == 'S')
                       pointermov40 = 1;
               }
           }
           else if (OnGame.Kind[0] == 'D')
           {
               int avoid = 0;
               for (int i = 0; i < cardObj.player4.Count; i++)
               {
                   if (cardObj.player4[i].Key[0] == 'D')
                   {
                       avoid++;
                   }
               }
               if (avoid != 0)
               {
                   if (P4[0].Value[0] == 'C' || P4[0].Value[0] == 'H' || P4[0].Value[0] == 'S')
                       pointermov52 = 1;
                   if (P4[1].Value[0] == 'C' || P4[1].Value[0] == 'H' || P4[1].Value[0] == 'S')
                       pointermov51 = 1;
                   if (P4[2].Value[0] == 'C' || P4[2].Value[0] == 'H' || P4[2].Value[0] == 'S')
                       pointermov50 = 1;
                   if (P4[3].Value[0] == 'C' || P4[3].Value[0] == 'H' || P4[3].Value[0] == 'S')
                       pointermov49 = 1;
                   if (P4[4].Value[0] == 'C' || P4[4].Value[0] == 'H' || P4[4].Value[0] == 'S')
                       pointermov48 = 1;
                   if (P4[5].Value[0] == 'C' || P4[5].Value[0] == 'H' || P4[5].Value[0] == 'S')
                       pointermov47 = 1;
                   if (P4[6].Value[0] == 'C' || P4[6].Value[0] == 'H' || P4[6].Value[0] == 'S')
                       pointermov46 = 1;
                   if (P4[7].Value[0] == 'C' || P4[7].Value[0] == 'H' || P4[7].Value[0] == 'S')
                       pointermov45 = 1;
                   if (P4[8].Value[0] == 'C' || P4[8].Value[0] == 'H' || P4[8].Value[0] == 'S')
                       pointermov44 = 1;
                   if (P4[9].Value[0] == 'C' || P4[9].Value[0] == 'H' || P4[9].Value[0] == 'S')
                       pointermov43 = 1;
                   if (P4[10].Value[0] == 'C' || P4[10].Value[0] == 'H' || P4[10].Value[0] == 'S')
                       pointermov42 = 1;
                   if (P4[11].Value[0] == 'C' || P4[11].Value[0] == 'H' || P4[11].Value[0] == 'S')
                       pointermov41 = 1;
                   if (P4[12].Value[0] == 'C' || P4[12].Value[0] == 'H' || P4[12].Value[0] == 'S')
                       pointermov40 = 1;
               }
           }
           else if (OnGame.Kind[0] == 'S')
           {
               int avoid = 0;
               for (int i = 0; i < cardObj.player4.Count; i++)
               {
                   if (cardObj.player4[i].Key[0] == 'S')
                   {
                       avoid++;
                   }
               }
               if (avoid != 0)
               {
                   if (P4[0].Value[0] == 'C' || P4[0].Value[0] == 'H' || P4[0].Value[0] == 'D')
                       pointermov52 = 1;
                   if (P4[1].Value[0] == 'C' || P4[1].Value[0] == 'H' || P4[1].Value[0] == 'D')
                       pointermov51 = 1;
                   if (P4[2].Value[0] == 'C' || P4[2].Value[0] == 'H' || P4[2].Value[0] == 'D')
                       pointermov50 = 1;
                   if (P4[3].Value[0] == 'C' || P4[3].Value[0] == 'H' || P4[3].Value[0] == 'D')
                       pointermov49 = 1;
                   if (P4[4].Value[0] == 'C' || P4[4].Value[0] == 'H' || P4[4].Value[0] == 'D')
                       pointermov48 = 1;
                   if (P4[5].Value[0] == 'C' || P4[5].Value[0] == 'H' || P4[5].Value[0] == 'D')
                       pointermov47 = 1;
                   if (P4[6].Value[0] == 'C' || P4[6].Value[0] == 'H' || P4[6].Value[0] == 'D')
                       pointermov46 = 1;
                   if (P4[7].Value[0] == 'C' || P4[7].Value[0] == 'H' || P4[7].Value[0] == 'D')
                       pointermov45 = 1;
                   if (P4[8].Value[0] == 'C' || P4[8].Value[0] == 'H' || P4[8].Value[0] == 'D')
                       pointermov44 = 1;
                   if (P4[9].Value[0] == 'C' || P4[9].Value[0] == 'H' || P4[9].Value[0] == 'D')
                       pointermov43 = 1;
                   if (P4[10].Value[0] == 'C' || P4[10].Value[0] == 'H' || P4[10].Value[0] == 'D')
                       pointermov42 = 1;
                   if (P4[11].Value[0] == 'C' || P4[11].Value[0] == 'H' || P4[11].Value[0] == 'D')
                       pointermov41 = 1;
                   if (P4[12].Value[0] == 'C' || P4[12].Value[0] == 'H' || P4[12].Value[0] == 'D')
                       pointermov40 = 1;
               }
           }
           if (OnGame.Kind[0] == 'C')
           {
               int avoid = 0;
               for (int i = 0; i < cardObj.player4.Count; i++)
               {
                   if (cardObj.player4[i].Key[0] == 'C')
                   {
                       avoid++;
                   }
               }
               if (avoid != 0)
               {
                   if (P4[0].Value[0] == 'H' || P4[0].Value[0] == 'D' || P4[0].Value[0] == 'S')
                       card52.ManipulationMode = ManipulationModes.None;
                   if (P4[1].Value[0] == 'H' || P4[1].Value[0] == 'D' || P4[1].Value[0] == 'S')
                       card51.ManipulationMode = ManipulationModes.None;
                   if (P4[2].Value[0] == 'H' || P4[2].Value[0] == 'D' || P4[2].Value[0] == 'S')
                       card50.ManipulationMode = ManipulationModes.None;
                   if (P4[3].Value[0] == 'H' || P4[3].Value[0] == 'D' || P4[3].Value[0] == 'S')
                       card49.ManipulationMode = ManipulationModes.None;
                   if (P4[4].Value[0] == 'H' || P4[4].Value[0] == 'D' || P4[4].Value[0] == 'S')
                       card48.ManipulationMode = ManipulationModes.None;
                   if (P4[5].Value[0] == 'H' || P4[5].Value[0] == 'D' || P4[5].Value[0] == 'S')
                       card47.ManipulationMode = ManipulationModes.None;
                   if (P4[6].Value[0] == 'H' || P4[6].Value[0] == 'D' || P4[6].Value[0] == 'S')
                       card46.ManipulationMode = ManipulationModes.None;
                   if (P4[7].Value[0] == 'H' || P4[7].Value[0] == 'D' || P4[7].Value[0] == 'S')
                       card45.ManipulationMode = ManipulationModes.None;
                   if (P4[8].Value[0] == 'H' || P4[8].Value[0] == 'D' || P4[8].Value[0] == 'S')
                       card44.ManipulationMode = ManipulationModes.None;
                   if (P4[9].Value[0] == 'H' || P4[9].Value[0] == 'D' || P4[9].Value[0] == 'S')
                       card43.ManipulationMode = ManipulationModes.None;
                   if (P4[10].Value[0] == 'H' || P4[10].Value[0] == 'D' || P4[10].Value[0] == 'S')
                       card42.ManipulationMode = ManipulationModes.None;
                   if (P4[11].Value[0] == 'H' || P4[11].Value[0] == 'D' || P4[11].Value[0] == 'S')
                       card41.ManipulationMode = ManipulationModes.None;
                   if (P4[12].Value[0] == 'H' || P4[12].Value[0] == 'D' || P4[12].Value[0] == 'S')
                       card40.ManipulationMode = ManipulationModes.None;
               }
           }
           if (OnGame.Kind[0] == 'D')
           {
               int avoid = 0;
               for (int i = 0; i < cardObj.player4.Count; i++)
               {
                   if (cardObj.player4[i].Key[0] == 'D')
                   {
                       avoid++;
                   }
               }
               if (avoid != 0)
               {
                   if (P4[0].Value[0] == 'H' || P4[0].Value[0] == 'C' || P4[0].Value[0] == 'S')
                       card52.ManipulationMode = ManipulationModes.None;
                   if (P4[1].Value[0] == 'H' || P4[1].Value[0] == 'C' || P4[1].Value[0] == 'S')
                       card51.ManipulationMode = ManipulationModes.None;
                   if (P4[2].Value[0] == 'H' || P4[2].Value[0] == 'C' || P4[2].Value[0] == 'S')
                       card50.ManipulationMode = ManipulationModes.None;
                   if (P4[3].Value[0] == 'H' || P4[3].Value[0] == 'C' || P4[3].Value[0] == 'S')
                       card49.ManipulationMode = ManipulationModes.None;
                   if (P4[4].Value[0] == 'H' || P4[4].Value[0] == 'C' || P4[4].Value[0] == 'S')
                       card48.ManipulationMode = ManipulationModes.None;
                   if (P4[5].Value[0] == 'H' || P4[5].Value[0] == 'C' || P4[5].Value[0] == 'S')
                       card47.ManipulationMode = ManipulationModes.None;
                   if (P4[6].Value[0] == 'H' || P4[6].Value[0] == 'C' || P4[6].Value[0] == 'S')
                       card46.ManipulationMode = ManipulationModes.None;
                   if (P4[7].Value[0] == 'H' || P4[7].Value[0] == 'C' || P4[7].Value[0] == 'S')
                       card45.ManipulationMode = ManipulationModes.None;
                   if (P4[8].Value[0] == 'H' || P4[8].Value[0] == 'C' || P4[8].Value[0] == 'S')
                       card44.ManipulationMode = ManipulationModes.None;
                   if (P4[9].Value[0] == 'H' || P4[9].Value[0] == 'C' || P4[9].Value[0] == 'S')
                       card43.ManipulationMode = ManipulationModes.None;
                   if (P4[10].Value[0] == 'H' || P4[10].Value[0] == 'C' || P4[10].Value[0] == 'S')
                       card42.ManipulationMode = ManipulationModes.None;
                   if (P4[11].Value[0] == 'H' || P4[11].Value[0] == 'C' || P4[11].Value[0] == 'S')
                       card41.ManipulationMode = ManipulationModes.None;
                   if (P4[12].Value[0] == 'H' || P4[12].Value[0] == 'C' || P4[12].Value[0] == 'S')
                       card40.ManipulationMode = ManipulationModes.None;
               }
           }
            if (OnGame.Kind[0] == 'H')
           {
                int avoid = 0;
                for (int i = 0; i < cardObj.player4.Count; i++)
                {
                    if (cardObj.player4[i].Key[0] == 'H')
                    {
                        avoid++;
                    }
                }
               if (avoid != 0)
               {
                   if (P4[0].Value[0] == 'D' || P4[0].Value[0] == 'C' || P4[0].Value[0] == 'S')
                       card52.ManipulationMode = ManipulationModes.None;
                   if (P4[1].Value[0] == 'D' || P4[1].Value[0] == 'C' || P4[1].Value[0] == 'S')
                       card51.ManipulationMode = ManipulationModes.None;
                   if (P4[2].Value[0] == 'D' || P4[2].Value[0] == 'C' || P4[2].Value[0] == 'S')
                       card50.ManipulationMode = ManipulationModes.None;
                   if (P4[3].Value[0] == 'D' || P4[3].Value[0] == 'C' || P4[3].Value[0] == 'S')
                       card49.ManipulationMode = ManipulationModes.None;
                   if (P4[4].Value[0] == 'D' || P4[4].Value[0] == 'C' || P4[4].Value[0] == 'S')
                       card48.ManipulationMode = ManipulationModes.None;
                   if (P4[5].Value[0] == 'D' || P4[5].Value[0] == 'C' || P4[5].Value[0] == 'S')
                       card47.ManipulationMode = ManipulationModes.None;
                   if (P4[6].Value[0] == 'D' || P4[6].Value[0] == 'C' || P4[6].Value[0] == 'S')
                       card46.ManipulationMode = ManipulationModes.None;
                   if (P4[7].Value[0] == 'D' || P4[7].Value[0] == 'C' || P4[7].Value[0] == 'S')
                       card45.ManipulationMode = ManipulationModes.None;
                   if (P4[8].Value[0] == 'D' || P4[8].Value[0] == 'C' || P4[8].Value[0] == 'S')
                       card44.ManipulationMode = ManipulationModes.None;
                   if (P4[9].Value[0] == 'D' || P4[9].Value[0] == 'C' || P4[9].Value[0] == 'S')
                       card43.ManipulationMode = ManipulationModes.None;
                   if (P4[10].Value[0] == 'D' || P4[10].Value[0] == 'C' || P4[10].Value[0] == 'S')
                       card42.ManipulationMode = ManipulationModes.None;
                   if (P4[11].Value[0] == 'D' || P4[11].Value[0] == 'C' || P4[11].Value[0] == 'S')
                       card41.ManipulationMode = ManipulationModes.None;
                   if (P4[12].Value[0] == 'D' || P4[12].Value[0] == 'C' || P4[12].Value[0] == 'S')
                       card40.ManipulationMode = ManipulationModes.None;
               }
           }
            if (OnGame.Kind[0] == 'S')
           {
                int avoid = 0;
                for (int i = 0; i < cardObj.player4.Count; i++)
                {
                    if (cardObj.player4[i].Key[0] == 'S')
                    {
                        avoid++;
                    }
                }
               if (avoid != 0)
               {
                   if (P4[0].Value[0] == 'D' || P4[0].Value[0] == 'C' || P4[0].Value[0] == 'H')
                       card52.ManipulationMode = ManipulationModes.None;
                   if (P4[1].Value[0] == 'D' || P4[1].Value[0] == 'C' || P4[1].Value[0] == 'H')
                       card51.ManipulationMode = ManipulationModes.None;
                   if (P4[2].Value[0] == 'D' || P4[2].Value[0] == 'C' || P4[2].Value[0] == 'H')
                       card50.ManipulationMode = ManipulationModes.None;
                   if (P4[3].Value[0] == 'D' || P4[3].Value[0] == 'C' || P4[3].Value[0] == 'H')
                       card49.ManipulationMode = ManipulationModes.None;
                   if (P4[4].Value[0] == 'D' || P4[4].Value[0] == 'C' || P4[4].Value[0] == 'H')
                       card48.ManipulationMode = ManipulationModes.None;
                   if (P4[5].Value[0] == 'D' || P4[5].Value[0] == 'C' || P4[5].Value[0] == 'H')
                       card47.ManipulationMode = ManipulationModes.None;
                   if (P4[6].Value[0] == 'D' || P4[6].Value[0] == 'C' || P4[6].Value[0] == 'H')
                       card46.ManipulationMode = ManipulationModes.None;
                   if (P4[7].Value[0] == 'D' || P4[7].Value[0] == 'C' || P4[7].Value[0] == 'H')
                       card45.ManipulationMode = ManipulationModes.None;
                   if (P4[8].Value[0] == 'D' || P4[8].Value[0] == 'C' || P4[8].Value[0] == 'H')
                       card44.ManipulationMode = ManipulationModes.None;
                   if (P4[9].Value[0] == 'D' || P4[9].Value[0] == 'C' || P4[9].Value[0] == 'H')
                       card43.ManipulationMode = ManipulationModes.None;
                   if (P4[10].Value[0] == 'D' || P4[10].Value[0] == 'C' || P4[10].Value[0] == 'H')
                       card42.ManipulationMode = ManipulationModes.None;
                   if (P4[11].Value[0] == 'D' || P4[11].Value[0] == 'C' || P4[11].Value[0] == 'H')
                       card41.ManipulationMode = ManipulationModes.None;
                   if (P4[12].Value[0] == 'D' || P4[12].Value[0] == 'C' || P4[12].Value[0] == 'H')
                       card40.ManipulationMode = ManipulationModes.None;
               }
               
           }
          
           OnGame.hand = 1;
           }

      
        #endregion

       
       int x1;
       int y1;
       bool hold = false;
       private async void Image_ManipulationDelta_1(object sender, ManipulationDeltaRoutedEventArgs e)
       {
         
           int n = 0;
          
           if (OnGame.hand == 1)
           {
                   hold = true;
               var pos = e.Position;
               var Tunisia = (CompositeTransform)card41.RenderTransform;
               if (sender == card40 && card40.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card40.RenderTransform;
               else if (sender == card42 && card42.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card42.RenderTransform;
               else if (sender == card43 && card43.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card43.RenderTransform;
               else if (sender == card44 && card44.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card44.RenderTransform;
               else if (sender == card45 && card45.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card45.RenderTransform;
               else if (sender == card46 && card46.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card46.RenderTransform;
               else if (sender == card47 && card47.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card47.RenderTransform;
               else if (sender == card48 && card48.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card48.RenderTransform;
               else if (sender == card49 && card49.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card49.RenderTransform;
               else if (sender == card50 && card50.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card50.RenderTransform;
               else if (sender == card51 && card51.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card51.RenderTransform;
               else if (sender == card52 && card52.ManipulationMode != ManipulationModes.None)
                   Tunisia = (CompositeTransform)card52.RenderTransform;


               Tunisia.TranslateY += -e.Delta.Translation.Y;
               Tunisia.TranslateX += -e.Delta.Translation.X;
               x1 = (int)(Tunisia.TranslateX);
               y1 = (int)(Tunisia.TranslateY);
               if (y1 > -150 || y1 < -480 || x1 > 700 || x1 < -630)
               {
                   Tunisia.TranslateX = new Thickness(-12, 0, 0, 0).Left;
                   Tunisia.TranslateY = new Thickness(0, 0, 0, -88).Bottom;
                   e.Complete();
                   if (sender == card40)
                   {
                       OnGame.collapse40 = 1;
                       pointermov40 = 1;
                       card40.ManipulationMode = ManipulationModes.None;
                       n = 12;
                   }
                   else if (sender == card41)
                   {
                       OnGame.collapse41 = 1;
                       pointermov41 = 1;
                       card41.ManipulationMode = ManipulationModes.None;
                       n = 11;
                   }
                   else if (sender == card42)
                   {
                       OnGame.collapse42 = 1;
                       pointermov42 = 1;
                       card42.ManipulationMode = ManipulationModes.None;
                       n = 10;
                   }
                   else if (sender == card43)
                   {
                       OnGame.collapse43 = 1;
                       pointermov43 = 1;
                       card43.ManipulationMode = ManipulationModes.None;
                       n = 9;
                   }
                   else if (sender == card44)
                   {
                       OnGame.collapse44 = 1;
                       pointermov44 = 1;
                       card44.ManipulationMode = ManipulationModes.None;
                       n = 8;
                   }
                   else if (sender == card45)
                   {
                       OnGame.collapse45 = 1;
                       pointermov45 = 1;
                       card45.ManipulationMode = ManipulationModes.None;
                       n = 7;
                   }
                   else if (sender == card46)
                   {
                       OnGame.collapse46 = 1;
                       pointermov46 = 1;
                       card46.ManipulationMode = ManipulationModes.None;
                       n = 6;
                   }
                   else if (sender == card47)
                   {
                       OnGame.collapse47 = 1;
                       pointermov47 = 1;
                       card47.ManipulationMode = ManipulationModes.None;
                       n = 5;
                   }
                   else if (sender == card48)
                   {
                       OnGame.collapse48 = 1;
                       pointermov48 = 1;
                       card48.ManipulationMode = ManipulationModes.None;
                       n = 4;
                   }
                   else if (sender == card49)
                   {
                       OnGame.collapse49 = 1;
                       pointermov49 = 1;
                       card49.ManipulationMode = ManipulationModes.None;
                       n = 3;
                   }
                   else if (sender == card50)
                   {
                       OnGame.collapse50 = 1;
                       pointermov50 = 1;
                       card50.ManipulationMode = ManipulationModes.None;
                       n = 2;
                   }
                   else if (sender == card51)
                   {
                       OnGame.collapse51 = 1;
                       pointermov51 = 1;
                       card51.ManipulationMode = ManipulationModes.None;
                       n = 1;
                   }
                   else if (sender == card52)
                   {
                       OnGame.collapse52 = 1;
                       pointermov52 = 1;
                       card52.ManipulationMode = ManipulationModes.None;
                       n = 0;
                   }
                   int n2 = 0;
                   for (int i = 0; i < cardObj.player4.Count; i++)
                   {
                       if (P4[n].Value == cardObj.player4[i].Key)
                       {
                           n2 = i;
                       }
                   }
                   OnGame.hand = 0;
                   OnGame.Gcounter++;
                   OnGame.p4num = cardObj.player4[n2].Value;
                   OnGame.p4Sort = P4[n].Value;

                   if(bids.highlybid == 4)
                   OnGame.Kind = P4[n].Value;

                   cardObj.player4.RemoveAt(n2);
                   bids.highlybid = 0;
                   if (OnGame.Gcounter == 4 && (OnGame.collapse40 == 1 || OnGame.collapse41 == 1 || OnGame.collapse42 == 1 || OnGame.collapse43 == 1 || OnGame.collapse44 == 1 || OnGame.collapse45 == 1 || OnGame.collapse46 == 1 || OnGame.collapse47 == 1 || OnGame.collapse48 == 1 || OnGame.collapse49 == 1 || OnGame.collapse50 == 1 || OnGame.collapse51 == 1 || OnGame.collapse52 == 1))
                   {
                       gameController();
                       await Task.Delay(TimeSpan.FromSeconds(3));
                   }
                   else if((OnGame.collapse40 == 1 || OnGame.collapse41 == 1 || OnGame.collapse42 == 1 || OnGame.collapse43 == 1 || OnGame.collapse44 == 1 || OnGame.collapse45 == 1 || OnGame.collapse46 == 1 || OnGame.collapse47 == 1 || OnGame.collapse48 == 1 || OnGame.collapse49 == 1 || OnGame.collapse50 == 1 || OnGame.collapse51 == 1 || OnGame.collapse52 == 1))
                   {
                       P1Turn();
                       await Task.Delay(TimeSpan.FromSeconds(3));
                   }
                   
                   
               }
                   
          }
       }
  

        //7- final result
        #region final result
      async void FinalM()
       {
           int player1 = 0;
           int player2 = 0;
           int player3 = 0;
           int player4 = 0;
           Final.Visibility = Visibility.Visible;
           if (OnGame.p4counter == bids.LastBid4)
           {
               youstatus.Text = "Win";
               player4 += 10;
               youPoints.Text = OnGame.p4counter.ToString();
           }
           else
           {
               youstatus.Text = "Lose";
               if (OnGame.p4counter > bids.LastBid4)
                   youPoints.Text = (bids.LastBid4 - OnGame.p4counter).ToString();
               else
                   youPoints.Text = (OnGame.p4counter - bids.LastBid4).ToString();
           }
           if (OnGame.p2counter == bids.LastBid2)
           {
               p2Status.Text = "Win";
               player2 += 10;
               p2Points.Text = OnGame.p2counter.ToString();
           }
           else
           {
               p2Status.Text = "Lose";
               if (OnGame.p2counter > bids.LastBid2)
                   p2Points.Text = (bids.LastBid2 - OnGame.p2counter).ToString();
               else
                   p2Points.Text = (OnGame.p2counter - bids.LastBid2).ToString();
           }

           if (OnGame.p3counter == bids.LastBid3)
           {
               p3Status.Text = "Win";
               player3 += 10;
               p3Points.Text = OnGame.p3counter.ToString();
           }
           else
           {
               p3Status.Text = "Lose";
               if (OnGame.p3counter > bids.LastBid3)
                   p3Points.Text = (bids.LastBid3 - OnGame.p3counter).ToString();
               else
                   p3Points.Text = (OnGame.p3counter - bids.LastBid3).ToString();
           }

           if (OnGame.p1counter == bids.LastBid1)
           {
               p1Status.Text = "Win";
               player1 += 10;
               p1Points.Text = OnGame.p1counter.ToString();
           }
           else
           {
               p1Status.Text = "Lose";
               if (OnGame.p1counter > bids.LastBid1)
                   p1Points.Text = (bids.LastBid1 - OnGame.p1counter).ToString();
               else
                   p1Points.Text = (OnGame.p1counter - bids.LastBid1).ToString();
           }

           if(OnGame.BidsWinner == 1)
           {
               P1BidsWinner.Text = "Yes";
               if (bids.LastBid2 == bids.LastBid1)
               {
                   p2With.Text = "Yes";
               }
               if (bids.LastBid3 == bids.LastBid1)
               {
                   p3With.Text = "Yes";
               }
               if (bids.LastBid4 == bids.LastBid1)
               {
                   youWith.Text = "Yes";
               }
           }
           else if(OnGame.BidsWinner == 2)
           {
               P2BidsWinner.Text = "Yes";
               if (bids.LastBid1 == bids.LastBid2)
               {
                   p1With.Text = "Yes";
               }
               if (bids.LastBid3 == bids.LastBid2)
               {
                   p3With.Text = "Yes";
               }
               if (bids.LastBid4 == bids.LastBid2)
               {
                   youWith.Text = "Yes";
               }
           }
           else if (OnGame.BidsWinner == 3)
           {
               P3BidsWinner.Text = "Yes";
               if (bids.LastBid2 == bids.LastBid3)
               {
                   p2With.Text = "Yes";
               }
               if (bids.LastBid1 == bids.LastBid3)
               {
                   p1With.Text = "Yes";
               }
               if (bids.LastBid4 == bids.LastBid3)
               {
                   youWith.Text = "Yes";
               }
           }
           else if (OnGame.BidsWinner == 4)
           {
               youBidsWinner.Text = "Yes";
               if (bids.LastBid2 == bids.LastBid4)
               {
                   p2With.Text = "Yes";
               }
               if (bids.LastBid3 == bids.LastBid4)
               {
                   p3With.Text = "Yes";
               }
               if (bids.LastBid1 == bids.LastBid4)
               {
                   p1With.Text = "Yes";
               }
           }

           if (OnGame.p1counter == bids.LastBid1 && OnGame.p2counter != bids.LastBid2 && OnGame.p3counter != bids.LastBid3 && OnGame.p4counter != bids.LastBid4)
           {
               p1Only.Text = "Only/W";
           }
           if (OnGame.p1counter != bids.LastBid1 && OnGame.p2counter == bids.LastBid2 && OnGame.p3counter != bids.LastBid3 && OnGame.p4counter != bids.LastBid4)
           {
               p2Only.Text = "Only/W";
           }
           if (OnGame.p1counter != bids.LastBid1 && OnGame.p2counter != bids.LastBid2 && OnGame.p3counter == bids.LastBid3 && OnGame.p4counter != bids.LastBid4)
           {
               p3Only.Text = "Only/W";
           }
           if (OnGame.p1counter != bids.LastBid1 && OnGame.p2counter != bids.LastBid2 && OnGame.p3counter != bids.LastBid3 && OnGame.p4counter == bids.LastBid4)
           {
               youOnly.Text = "Only/W";
           }


           if (OnGame.p1counter != bids.LastBid1 && OnGame.p2counter == bids.LastBid2 && OnGame.p3counter == bids.LastBid3 && OnGame.p4counter == bids.LastBid4)
           {
               p1Only.Text = "Only/L";
           }
           if (OnGame.p1counter == bids.LastBid1 && OnGame.p2counter != bids.LastBid2 && OnGame.p3counter == bids.LastBid3 && OnGame.p4counter == bids.LastBid4)
           {
               p2Only.Text = "Only/L";
           }
           if (OnGame.p1counter == bids.LastBid1 && OnGame.p2counter == bids.LastBid2 && OnGame.p3counter != bids.LastBid3 && OnGame.p4counter == bids.LastBid4)
           {
               p3Only.Text = "Only/L";
           }
           if (OnGame.p1counter == bids.LastBid1 && OnGame.p2counter == bids.LastBid2 && OnGame.p3counter == bids.LastBid3 && OnGame.p4counter != bids.LastBid4)
           {
               youOnly.Text = "Only/L";
           }

           if (dash.dashcall1 != 0)
           {
               P1BidsWinner.Text = "Dash Call";
               if (OnGame.p1counter == 0)
                   player1 += 23;
               else
                   player1 += -23;
           }
           if (dash.dashcall2 != 0)
           {
               P2BidsWinner.Text = "Dash Call";
               if (OnGame.p2counter == 0)
                   player2 += 23;
               else
                   player2 += -23;
           }
           if (dash.dashcall3 != 0)
           {
               P3BidsWinner.Text = "Dash Call";
               if (OnGame.p3counter == 0)
                   player3 += 23;
               else
                   player3 += -23;
           }
           if (dash.dashcall4 != 0)
           {
               youBidsWinner.Text = "Dash Call";
               if (OnGame.p4counter == 0)
                   player4 += 23;
               else
                   player4 += -23;
           }


           player1 += int.Parse(p1Points.Text);
           if (P1BidsWinner.Text == "Yes")
           {
               if (OnGame.p1counter == bids.LastBid1)
                   player1 += 20;
               else
                   player1 += -10;
           }
           if(p1With.Text == "Yes")
           {
               if (OnGame.p1counter == bids.LastBid1)
                   player1 += 20;
               else
                   player1 += -10;
           }
           if(p1Only.Text == "Only/W")
               player1 += 10;
           
           else if(p1Only.Text == "Only/L")
               player1 += -10;

           p1Final.Text = player1.ToString();

           player2 += int.Parse(p2Points.Text);
           if (P2BidsWinner.Text == "Yes")
           {
               if (OnGame.p2counter == bids.LastBid2)
                   player2 += 20;
               else
                   player2 += -10;
           }
           if (p2With.Text == "Yes")
           {
               if (OnGame.p2counter == bids.LastBid2)
                   player2 += 20;
               else
                   player2 += -10;
           }
           if (p2Only.Text == "Only/W")
               player2 += 10;

           else if (p2Only.Text == "Only/L")
               player2 += -10;

           p2Final.Text = player2.ToString();

           player3 += int.Parse(p3Points.Text);
           if (P3BidsWinner.Text == "Yes")
           {
               if (OnGame.p3counter == bids.LastBid3)
                   player3 += 20;
               else
                   player3 += -10;
           }
           if (p3With.Text == "Yes")
           {
               if (OnGame.p3counter == bids.LastBid3)
                   player3 += 20;
               else
                   player3 += -10;
           }
           if (p3Only.Text == "Only/W")
               player3 += 10;

           else if (p3Only.Text == "Only/L")
               player3 += -10;

           p3Final.Text = player3.ToString();

           player4 += int.Parse(youPoints.Text);
           if (youBidsWinner.Text == "Yes")
           {
               if (OnGame.p4counter == bids.LastBid4)
                   player4 += 20;
               else
                   player4 += -10;
           }
           if (youWith.Text == "Yes")
           {
               if (OnGame.p4counter == bids.LastBid4)
                   player4 += 20;
               else
                   player4 += -10;
           }
           if (youOnly.Text == "Only/W")
               player4 += 10;

           else if (youOnly.Text == "Only/L")
               player4 += -10;

           youFinal.Text = player4.ToString();

           if(player1 > player2 && player1 > player3 && player1 > player4 )
           {
               finalWinner.Text = "Player1 is The Winner";
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
           }
           else if(player2 > player1 && player2 > player3 && player2 > player4)
           {
               finalWinner.Text = "Player2 is The Winner";
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
           }
           else if (player3 > player1 && player3 > player2 && player3 > player4)
           {
               finalWinner.Text = "Player3 is The Winner";
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
           }
           else  if (player4 > player1 && player4 > player3 && player4 > player2)
           {
               finalWinner.Text = "You Are The Winner";
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
           }

           if (p1Status.Text == "Lose" && p2Status.Text == "Lose" && p3Status.Text == "Lose" && youstatus.Text == "Lose")
           {
               finalWinner.Text = "S3aida,no body wins";
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Collapsed;
               await Task.Delay(TimeSpan.FromSeconds(0.5));
               finalWinner.Visibility = Visibility.Visible;
               //await Task.Delay(TimeSpan.FromSeconds(2));
               //this.Frame.Navigate(typeof(Game));
           }
       }
       
        #endregion

      private async void PlayAgain_Tapped(object sender, TappedRoutedEventArgs e)
      {
          PlayAgain.Visibility = Visibility.Collapsed;
          await Task.Delay(TimeSpan.FromSeconds(0.1));
          PlayAgain.Visibility = Visibility.Visible;
          await Task.Delay(TimeSpan.FromSeconds(0.1));
          PlayAgain.Visibility = Visibility.Collapsed;
          await Task.Delay(TimeSpan.FromSeconds(0.1));
          PlayAgain.Visibility = Visibility.Visible;
          await Task.Delay(TimeSpan.FromSeconds(0.1));
          PlayAgain.Visibility = Visibility.Collapsed;
          await Task.Delay(TimeSpan.FromSeconds(0.1));
          PlayAgain.Visibility = Visibility.Visible;
          await Task.Delay(TimeSpan.FromSeconds(0.5));
          this.Frame.Navigate(typeof(Game));
      }

      private void RulesTapped(object sender, TappedRoutedEventArgs e)
      {
          rules.Visibility = Visibility.Visible;
      }

      private void close_rules_Tapped(object sender, TappedRoutedEventArgs e)
      {
          rules.Visibility = Visibility.Collapsed;
      }

    }


    

}

