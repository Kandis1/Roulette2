using RouletteLibrary;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Threading;

namespace Roulette2
{
    /// <summary>
    /// This is the game of Roulette
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Variables to ensure that the scope
        //of the variables are throughout the program.
        public int TotalBets = 0;
        
        
        Roulette one = new Roulette();
        Roulette two = new Roulette();
        Roulette three = new Roulette();
        Roulette four = new Roulette();
        Roulette five = new Roulette();
        Roulette six = new Roulette();
        Roulette seven = new Roulette();
        Roulette eight = new Roulette();
        Roulette nine = new Roulette();
        Roulette ten = new Roulette();
        Roulette eleven = new Roulette();
        Roulette twelve = new Roulette();
        Roulette thirteen = new Roulette();
        Roulette fourteen = new Roulette();
        Roulette fifteen = new Roulette();
        Roulette sixteen = new Roulette();
        Roulette seventeen = new Roulette();
        Roulette eighteen = new Roulette();
        Roulette nineteen = new Roulette();
        Roulette twenty = new Roulette();
        Roulette twentyone = new Roulette();
        Roulette twentytwo = new Roulette();
        Roulette twentythree = new Roulette();
        Roulette twentyfour = new Roulette();
        Roulette twentyfive = new Roulette();
        Roulette twentysix = new Roulette();
        Roulette twentyseven = new Roulette();
        Roulette twentyeight = new Roulette();
        Roulette twentynine = new Roulette();
        Roulette thirty = new Roulette();
        Roulette thirtyone = new Roulette();
        Roulette thirtytwo = new Roulette();
        Roulette thirtythree = new Roulette();
        Roulette thirtyfour = new Roulette();
        Roulette thirtyfive = new Roulette();
        Roulette thirtysix = new Roulette();
        Roulette zerozero = new Roulette();
        Roulette zero = new Roulette();
        Roulette twoTo1stCol = new Roulette();
        Roulette twoTo2ndCol = new Roulette();
        Roulette twoTo3rdCol = new Roulette();
        Roulette First12 = new Roulette();
        Roulette Second12 = new Roulette();
        Roulette Third12 = new Roulette();
        Roulette Firstto18 = new Roulette();
        Roulette evens = new Roulette();
        Roulette odds = new Roulette();
        Roulette red = new Roulette();
        Roulette black = new Roulette();
        Roulette nineTeenTo36 = new Roulette();
        int timeToWin;
        Random guessNum = new Random();
       
        int specialIndex = 0;
        int firstcolumn = 0;
        int secondcolumn = 0;
        int thirdcolumn = 0;
        int first12nums = 0;
        int second12nums = 0;
        int third12nums = 0;
        int firstTo8 = 0;
        int evennums = 0;
        int oddnums = 0;
        int rednums = 0;
        int blacknums = 0;
        int nineteenTo36nums = 0;

        //Establishing a random variable for users to place bets on
        //I put a textbox, so you can test each type of win in Roulette
        public void TimeToWin()
        {
            timeToWin = guessNum.Next(0, 39);
        }
        public MainWindow()
        {
            InitializeComponent();
            TimeToWin();
            box.Text = "";
            box.Text += timeToWin.ToString();
            //This function displays the winning number.
            //You can turn this off if you want.
            //I did this for grading purposes.
            spinner.Visibility = Visibility.Collapsed;

        }
        //Calculating clicks on each number
        private void ClickOne(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            one.AddBet(1, 1);
            redOne.Background = Brushes.Blue;
            //This adds a bet, places that bet in the one object
            //It also makes the red one, blue.
            //This happens throughout the next lines. 

        }
        private void TwoClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            two.AddBet(1, 2);
            blackTwo.Background = Brushes.Blue;
        }

        private void ThreeClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            three.AddBet(1, 3);
            redThree.Background = Brushes.Blue;
        }


        private void FourClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            four.AddBet(1, 3);
            blackFour.Background = Brushes.Blue;
        }

        private void FiveClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            five.AddBet(1, 5);
            redFive.Background = Brushes.Blue;
        }

        private void SixClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
           
            six.AddBet(1, 6);
            blackSix.Background = Brushes.Blue;
        }

        private void SevenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
          
            seven.AddBet(1, 7);
            redSeven.Background = Brushes.Blue;
        }

        private void EightClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            eight.AddBet(1, 8);
            blackEight.Background = Brushes.Blue;
        }

        private void NineClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
         
            nine.AddBet(1, 9);
            redNine.Background = Brushes.Blue;
        }

        private void TenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            ten.AddBet(1, 10);
            blackTen.Background = Brushes.Blue;
        }

        private void ElevenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            eleven.AddBet(1, 11);
            blackEleven.Background = Brushes.Blue;
        }

        private void TwelveClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            twelve.AddBet(1, 12);
            redTwelve.Background = Brushes.Blue;
        }

        private void ThirteenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            BetsTotal.Text = "";
         
            thirteen.AddBet(1, 13);
            blackThirteen.Background = Brushes.Blue;
        }

        private void ForteenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
        
            fourteen.AddBet(1, 14);
            redForteen.Background = Brushes.Blue;
        }

        private void FifteenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
         
            fifteen.AddBet(1, 15);
            blackFifteen.Background = Brushes.Blue;
        }

        private void SixteenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            sixteen.AddBet(1, 16);
            redSixteen.Background = Brushes.Blue;
        }

        private void SeventeenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            seventeen.AddBet(1, 17);
            blackSeventeen.Background = Brushes.Blue;
        }

        private void EighteenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
        
            eighteen.AddBet(1, 18);
            redEighteen.Background = Brushes.Blue;
        }

        private void NineteenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
           
            nineteen.AddBet(1, 19);
            redNineteen.Background = Brushes.Blue;
        }

        private void TwentyClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            twenty.AddBet(1, 20);
            blackTwenty.Background = Brushes.Blue;
        }

        private void TwentyOneClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
        
            twentyone.AddBet(1, 21);
            redTwentyOne.Background = Brushes.Blue;
        }

        private void TwentyTwoClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            twentytwo.AddBet(1, 22);
            blackTwentyTwo.Background = Brushes.Blue;
        }
        private void TwentyThreeClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            twentythree.AddBet(1, 23);
            redTwentyThree.Background = Brushes.Blue;
        }

        private void TwentyFourClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
         
            twentyfour.AddBet(1, 24);
            blackTwentyFour.Background = Brushes.Blue;
        }

        private void TwentyFiveClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            twentyfive.AddBet(1, 25);
            redTwentyFive.Background = Brushes.Blue;
        }

        private void TwentySixClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            twentysix.AddBet(1, 26);
            blackTwentySix.Background = Brushes.Blue;
        }

        private void TwentySevenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
           
            twentyseven.AddBet(1, 27);
            redTwentySeven.Background = Brushes.Blue;
        }

        private void TwentyEightClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
           
            twentyeight.AddBet(1, 28);
            blackTwentyEight.Background = Brushes.Blue;
        }

        private void TwentyNineClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
        
            twentynine.AddBet(1, 29);
            blackTwentyNine.Background = Brushes.Blue;
        }

        private void ThirtyDown(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            thirty.AddBet(1, 30);
            redThirty.Background = Brushes.Blue;
        }

        private void ThirtyOneClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
         
            thirtyone.AddBet(1, 31);
            blackThirtyOne.Background = Brushes.Blue;
        }

        private void ThirtyTwoClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            thirtytwo.AddBet(1, 32);
            redThirtyTwo.Background = Brushes.Blue;
        }

        private void ThirtyThreeClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
           
            thirtythree.AddBet(1, 33);
            blackThirtyThree.Background = Brushes.Blue;
        }

        private void ThirtyFourClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            thirtyfour.AddBet(1, 34);
            redThirtyFour.Background = Brushes.Blue;
        }

        private void ThirtyFiveClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
          
            thirtyfive.AddBet(1, 35);
            blackThirtyFive.Background = Brushes.Blue;
        }

        private void ThirtySixClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            thirtysix.AddBet(1, 36);
            redThirtySix.Background = Brushes.Blue;
        }

        private void ZeroZeroClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
          
            zerozero.AddBet(1, 37);
            zeroZero.Background = Brushes.Blue;
        }

        private void ZeroClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            
            zero.AddBet(1, 38);
            singleZero.Background = Brushes.Blue;
        }
        private void TwotoOne1stCol(object sender, MouseButtonEventArgs e)
        {

            //these next few blocks calculate all bets 
            //sending all numbers to the array inside the Roulette Library
            TotalBets += 1;
            twoTo1stCol = new Roulette(12);          
            twoTo1stCol.AddBet(1, 1);
            twoTo1stCol.AddBet(1, 4);
            twoTo1stCol.AddBet(1, 7);
            twoTo1stCol.AddBet(1, 10);
            twoTo1stCol.AddBet(1, 13);
            twoTo1stCol.AddBet(1, 16);
            twoTo1stCol.AddBet(1, 19);
            twoTo1stCol.AddBet(1, 22);
            twoTo1stCol.AddBet(1, 25);
            twoTo1stCol.AddBet(1, 28);
            twoTo1stCol.AddBet(1, 31);
            twoTo1stCol.AddBet(1, 34);
            redOne.Background = Brushes.Blue;            
            blackFour.Background = Brushes.Blue;
            redSeven.Background = Brushes.Blue;           
            blackTen.Background = Brushes.Blue;
            blackThirteen.Background = Brushes.Blue;
            redSixteen.Background = Brushes.Blue;
            redNineteen.Background = Brushes.Blue;
            blackTwentyTwo.Background = Brushes.Blue;
            redTwentyFive.Background = Brushes.Blue;
            blackTwentyEight.Background = Brushes.Blue;
            blackThirtyOne.Background = Brushes.Blue;
            redThirtyFour.Background = Brushes.Blue;
            TwoToOne1stCol.Background = Brushes.Blue;
            specialIndex += 12;
            firstcolumn++;
        }
        private void TwoToOne2ndColClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            twoTo2ndCol = new Roulette(12);          
            twoTo2ndCol.AddBet(1, 2);
            twoTo2ndCol.AddBet(1, 5);
            twoTo2ndCol.AddBet(1, 8);
            twoTo2ndCol.AddBet(1, 11);
            twoTo2ndCol.AddBet(1, 14);
            twoTo2ndCol.AddBet(1, 17);
            twoTo2ndCol.AddBet(1, 20);
            twoTo2ndCol.AddBet(1, 23);
            twoTo2ndCol.AddBet(1, 26);
            twoTo2ndCol.AddBet(1, 29);
            twoTo2ndCol.AddBet(1, 32);
            twoTo2ndCol.AddBet(1, 35);            
            blackTwo.Background = Brushes.Blue;           
            redFive.Background = Brushes.Blue;
            blackEight.Background = Brushes.Blue;
            blackEleven.Background = Brushes.Blue;
            redForteen.Background = Brushes.Blue;
            blackSeventeen.Background = Brushes.Blue;
            blackTwenty.Background = Brushes.Blue;
            redTwentyThree.Background = Brushes.Blue;
            blackTwentySix.Background = Brushes.Blue;
            blackTwentyNine.Background = Brushes.Blue;
            redThirtyTwo.Background = Brushes.Blue;
            blackThirtyFive.Background = Brushes.Blue;
            TwoToOne2ndCol.Background = Brushes.Blue;
            specialIndex += 12;
            secondcolumn++;
        }
        private void TwoToOne3rdColClick(object sender, MouseButtonEventArgs e)
        {

            TotalBets += 1;
            twoTo3rdCol = new Roulette(12);
            twoTo3rdCol.AddBet(1, 3);
            twoTo3rdCol.AddBet(1, 6);
            twoTo3rdCol.AddBet(1, 9);
            twoTo3rdCol.AddBet(1, 12);
            twoTo3rdCol.AddBet(1, 15);
            twoTo3rdCol.AddBet(1, 18);
            twoTo3rdCol.AddBet(1, 21);
            twoTo3rdCol.AddBet(1, 24);
            twoTo3rdCol.AddBet(1, 27);
            twoTo3rdCol.AddBet(1, 20);
            twoTo3rdCol.AddBet(1, 32);
            twoTo3rdCol.AddBet(1, 36);
            redThree.Background = Brushes.Blue;            
            blackSix.Background = Brushes.Blue;            
            redNine.Background = Brushes.Blue;            
            redTwelve.Background = Brushes.Blue;           
            blackFifteen.Background = Brushes.Blue;            
            redEighteen.Background = Brushes.Blue;            
            redTwentyOne.Background = Brushes.Blue;
            blackTwentyFour.Background = Brushes.Blue;           
            redTwentySeven.Background = Brushes.Blue;            
            redThirty.Background = Brushes.Blue;            
            blackThirtyThree.Background = Brushes.Blue;            
            redThirtySix.Background = Brushes.Blue;  
            TwoToOne3rdCol.Background = Brushes.Blue;
            specialIndex += 13;
            thirdcolumn++;
        }

        private void First12Click(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            First12 = new Roulette(12);
            First12.AddBet(1, 1);
            First12.AddBet(1, 2);
            First12.AddBet(1, 3);
            First12.AddBet(1, 4);
            First12.AddBet(1, 5);
            First12.AddBet(1, 6);
            First12.AddBet(1, 7);
            First12.AddBet(1, 8);
            First12.AddBet(1, 9);
            First12.AddBet(1, 10);
            First12.AddBet(1, 11);
            First12.AddBet(1, 12);
            redOne.Background = Brushes.Blue;
            blackTwo.Background = Brushes.Blue;
            redThree.Background = Brushes.Blue;
            blackFour.Background = Brushes.Blue;
            redFive.Background = Brushes.Blue;
            blackFour.Background = Brushes.Blue;
            redFive.Background = Brushes.Blue;
            blackSix.Background = Brushes.Blue;
            redSeven.Background = Brushes.Blue;
            blackEight.Background = Brushes.Blue;
            redNine.Background = Brushes.Blue;
            blackTen.Background = Brushes.Blue;
            blackEleven.Background = Brushes.Blue;
            redTwelve.Background = Brushes.Blue;
            first12.Background = Brushes.Blue;
            specialIndex += 12;
            first12nums++;
           
        }
        private void Second12Click(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            Second12 = new Roulette(12);
            blackThirteen.Background = Brushes.Blue;
            redForteen.Background = Brushes.Blue;
            blackFifteen.Background = Brushes.Blue;
            redSixteen.Background = Brushes.Blue;
            blackSeventeen.Background = Brushes.Blue;
            redEighteen.Background = Brushes.Blue;
            redNineteen.Background = Brushes.Blue;
            blackTwenty.Background = Brushes.Blue;
            redTwentyOne.Background = Brushes.Blue;
            blackTwentyTwo.Background = Brushes.Blue;
            redTwentyThree.Background = Brushes.Blue;
            blackTwentyFour.Background = Brushes.Blue;
            second12.Background = Brushes.Blue;
            specialIndex += 12;
            second12nums++;           
        }
        private void Third12Click(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            specialIndex += 12;
            third12nums++;            
            redTwentyFive.Background = Brushes.Blue;
            blackTwentySix.Background = Brushes.Blue;
            redTwentySeven.Background = Brushes.Blue;
            blackTwentyEight.Background = Brushes.Blue;
            blackTwentyNine.Background = Brushes.Blue;
            redThirty.Background = Brushes.Blue;
            blackThirtyOne.Background = Brushes.Blue;
            redThirtyTwo.Background = Brushes.Blue;
            blackThirtyThree.Background = Brushes.Blue;
            redThirtyFour.Background = Brushes.Blue;
            blackThirtyFive.Background = Brushes.Blue;
            redThirtySix.Background = Brushes.Blue;
            third12.Background = Brushes.Blue;
        }
        private void OneTo18Click(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            specialIndex += 17;
            firstTo8++;
            redOne.Background = Brushes.Blue;
            blackTwo.Background = Brushes.Blue;
            redThree.Background = Brushes.Blue;
            blackFour.Background = Brushes.Blue;
            redFive.Background = Brushes.Blue;
            blackFour.Background = Brushes.Blue;
            redFive.Background = Brushes.Blue;
            blackSix.Background = Brushes.Blue;
            redSeven.Background = Brushes.Blue;
            blackEight.Background = Brushes.Blue;
            redNine.Background = Brushes.Blue;
            blackTen.Background = Brushes.Blue;
            blackEleven.Background = Brushes.Blue;
            redTwelve.Background = Brushes.Blue;
            blackThirteen.Background = Brushes.Blue;
            redForteen.Background = Brushes.Blue;
            blackFifteen.Background = Brushes.Blue;
            redSixteen.Background = Brushes.Blue;
            blackSeventeen.Background = Brushes.Blue;
            redEighteen.Background = Brushes.Blue;
            oneTo18Slot.Background = Brushes.Blue;

        }
        private void NineteenTo36Click(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            specialIndex += 17;
            nineteenTo36nums++;
            redNineteen.Background = Brushes.Blue;
            blackTwenty.Background = Brushes.Blue;
            redTwentyOne.Background = Brushes.Blue;
            blackTwentyTwo.Background = Brushes.Blue;
            redTwentyThree.Background = Brushes.Blue;
            blackTwentyFour.Background = Brushes.Blue;
            redTwentyFive.Background = Brushes.Blue;
            blackTwentySix.Background = Brushes.Blue;
            redTwentySeven.Background = Brushes.Blue;
            blackTwentyEight.Background = Brushes.Blue;
            blackTwentyNine.Background = Brushes.Blue;
            redThirty.Background = Brushes.Blue;
            blackThirtyOne.Background = Brushes.Blue;
            redThirtyTwo.Background = Brushes.Blue;
            blackThirtyThree.Background = Brushes.Blue;
            redThirtyFour.Background = Brushes.Blue;
            blackThirtyFive.Background = Brushes.Blue;
            redThirtySix.Background = Brushes.Blue;
            nineteenTo36.Background = Brushes.Blue;
        }
        private void EvenClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            specialIndex += 17;
            evennums++;

            blackTwo.Background = Brushes.Blue;
            blackFour.Background = Brushes.Blue;
            blackFour.Background = Brushes.Blue;
            blackSix.Background = Brushes.Blue;

            blackEight.Background = Brushes.Blue;

            blackTen.Background = Brushes.Blue;

            redTwelve.Background = Brushes.Blue;

            redForteen.Background = Brushes.Blue;

            redSixteen.Background = Brushes.Blue;

            redEighteen.Background = Brushes.Blue;

            blackTwenty.Background = Brushes.Blue;

            blackTwentyTwo.Background = Brushes.Blue;

            blackTwentyFour.Background = Brushes.Blue;

            blackTwentySix.Background = Brushes.Blue;

            blackTwentyEight.Background = Brushes.Blue;

            redThirty.Background = Brushes.Blue;

            redThirtyTwo.Background = Brushes.Blue;

            redThirtyFour.Background = Brushes.Blue;

            redThirtySix.Background = Brushes.Blue;
            evenSlot.Background = Brushes.Blue;
        }
        private void OddClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            specialIndex += 17;
            oddnums++;
            redOne.Background = Brushes.Blue;

            redThree.Background = Brushes.Blue;

            redFive.Background = Brushes.Blue;

            redSeven.Background = Brushes.Blue;

            redNine.Background = Brushes.Blue;

            blackEleven.Background = Brushes.Blue;

            blackThirteen.Background = Brushes.Blue;

            blackFifteen.Background = Brushes.Blue;

            blackSeventeen.Background = Brushes.Blue;

            redNineteen.Background = Brushes.Blue;

            redTwentyOne.Background = Brushes.Blue;

            redTwentyThree.Background = Brushes.Blue;

            redTwentyFive.Background = Brushes.Blue;

            redTwentySeven.Background = Brushes.Blue;

            blackTwentyNine.Background = Brushes.Blue;

            blackThirtyOne.Background = Brushes.Blue;

            blackThirtyThree.Background = Brushes.Blue;

            blackThirtyFive.Background = Brushes.Blue;
            oddSlot.Background = Brushes.Blue;

        }
        private void RedClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            specialIndex += 17;
            rednums++;
            redOne.Background = Brushes.Blue;
            redThree.Background = Brushes.Blue;
            redFive.Background = Brushes.Blue;
            redSeven.Background = Brushes.Blue;
            redNine.Background = Brushes.Blue;
            redTwelve.Background = Brushes.Blue;
            redForteen.Background = Brushes.Blue;
            redSixteen.Background = Brushes.Blue;
            redEighteen.Background = Brushes.Blue;
            redNineteen.Background = Brushes.Blue;
            redTwentyOne.Background = Brushes.Blue;
            redTwentyThree.Background = Brushes.Blue;
            redTwentyFive.Background = Brushes.Blue;
            redTwentySeven.Background = Brushes.Blue;
            redThirty.Background = Brushes.Blue;
            redThirtyTwo.Background = Brushes.Blue;
            redThirtyFour.Background = Brushes.Blue;
            redThirtySix.Background = Brushes.Blue;
            redSlot.Background = Brushes.Blue;
        }
        private void BlackClick(object sender, MouseButtonEventArgs e)
        {
            TotalBets += 1;
            specialIndex += 18;
            blacknums++;
            blackTwo.Background = Brushes.Blue;

            blackFour.Background = Brushes.Blue;

            blackFour.Background = Brushes.Blue;

            blackSix.Background = Brushes.Blue;

            blackEight.Background = Brushes.Blue;

            blackTen.Background = Brushes.Blue;
            blackEleven.Background = Brushes.Blue;

            blackThirteen.Background = Brushes.Blue;

            blackFifteen.Background = Brushes.Blue;

            blackSeventeen.Background = Brushes.Blue;

            blackTwenty.Background = Brushes.Blue;

            blackTwentyTwo.Background = Brushes.Blue;

            blackTwentyFour.Background = Brushes.Blue;

            blackTwentySix.Background = Brushes.Blue;

            blackTwentyEight.Background = Brushes.Blue;
            blackTwentyNine.Background = Brushes.Blue;

            blackThirtyOne.Background = Brushes.Blue;

            blackThirtyThree.Background = Brushes.Blue;

            blackThirtyFive.Background = Brushes.Blue;
            blackSlot.Background = Brushes.Blue;
        }

        private void CalculateClick(object sender, RoutedEventArgs e)
        {
            
            Roulette numfixed = new Roulette(TotalBets+specialIndex);
            numfixed.Bet = 0;
            //Establishing the numfixed Roulette object


            try
            {
                //Places all numbers of each selection into the numfixed object
                if (TwoToOne1stCol.Background == Brushes.Blue)
                {
                    numfixed.AddBet(firstcolumn, 1);
                    numfixed.AddBet(0, 4);
                    numfixed.AddBet(0, 7);
                    numfixed.AddBet(0, 10);
                    numfixed.AddBet(0, 13);
                    numfixed.AddBet(0, 16);
                    numfixed.AddBet(0, 19);
                    numfixed.AddBet(0, 22);
                    numfixed.AddBet(0, 25);
                    numfixed.AddBet(0, 28);
                    numfixed.AddBet(0, 31);
                    numfixed.AddBet(0, 34);

                }
                else if (TwoToOne2ndCol.Background == Brushes.Blue)
                {
                    numfixed.AddBet(secondcolumn, 2);
                    numfixed.AddBet(0, 5);
                    numfixed.AddBet(0, 8);
                    numfixed.AddBet(0, 11);
                    numfixed.AddBet(0, 14);
                    numfixed.AddBet(0, 17);
                    numfixed.AddBet(0, 20);
                    numfixed.AddBet(0, 23);
                    numfixed.AddBet(0, 26);
                    numfixed.AddBet(0, 29);
                    numfixed.AddBet(0, 32);
                    numfixed.AddBet(0, 35);

                }
                else if (TwoToOne3rdCol.Background == Brushes.Blue)
                {
                    numfixed.AddBet(thirdcolumn, 3);
                    numfixed.AddBet(0, 6);
                    numfixed.AddBet(0, 9);
                    numfixed.AddBet(0, 12);
                    numfixed.AddBet(0, 15);
                    numfixed.AddBet(0, 18);
                    numfixed.AddBet(0, 21);
                    numfixed.AddBet(0, 24);
                    numfixed.AddBet(0, 27);
                    numfixed.AddBet(0, 30);
                    numfixed.AddBet(0, 33);
                    numfixed.AddBet(0, 36);
                }
                else if (first12.Background == Brushes.Blue)
                {
                    numfixed.AddBet(first12nums, 1);
                    numfixed.AddBet(0, 2);
                    numfixed.AddBet(0, 3);
                    numfixed.AddBet(0, 4);
                    numfixed.AddBet(0, 5);
                    numfixed.AddBet(0, 6);
                    numfixed.AddBet(0, 7);
                    numfixed.AddBet(0, 8);
                    numfixed.AddBet(0, 9);
                    numfixed.AddBet(0, 10);
                    numfixed.AddBet(0, 11);
                    numfixed.AddBet(0, 12);
                }
                else if (second12.Background == Brushes.Blue)
                {
                    numfixed.AddBet(second12nums, 13);
                    numfixed.AddBet(0, 14);
                    numfixed.AddBet(0, 15);
                    numfixed.AddBet(0, 16);
                    numfixed.AddBet(0, 17);
                    numfixed.AddBet(0, 18);
                    numfixed.AddBet(0, 19);
                    numfixed.AddBet(0, 20);
                    numfixed.AddBet(0, 21);
                    numfixed.AddBet(0, 22);
                    numfixed.AddBet(0, 23);
                    numfixed.AddBet(0, 24);
                }
                else if (third12.Background == Brushes.Blue)
                {
                    numfixed.AddBet(third12nums, 25);
                    numfixed.AddBet(0, 26);
                    numfixed.AddBet(0, 27);
                    numfixed.AddBet(0, 28);
                    numfixed.AddBet(0, 29);
                    numfixed.AddBet(0, 30);
                    numfixed.AddBet(0, 31);
                    numfixed.AddBet(0, 32);
                    numfixed.AddBet(0, 33);
                    numfixed.AddBet(0, 34);
                    numfixed.AddBet(0, 35);
                    numfixed.AddBet(0, 36);
                }
                else if (oneTo18Slot.Background == Brushes.Blue)
                {
                    numfixed.AddBet(firstTo8, 1);
                    numfixed.AddBet(0, 2);
                    numfixed.AddBet(0, 3);
                    numfixed.AddBet(0, 4);
                    numfixed.AddBet(0, 5);
                    numfixed.AddBet(0, 6);
                    numfixed.AddBet(0, 7);
                    numfixed.AddBet(0, 8);
                    numfixed.AddBet(0, 9);
                    numfixed.AddBet(0, 10);
                    numfixed.AddBet(0, 11);
                    numfixed.AddBet(0, 12);
                    numfixed.AddBet(0, 13);
                    numfixed.AddBet(0, 14);
                    numfixed.AddBet(0, 15);
                    numfixed.AddBet(0, 16);
                    numfixed.AddBet(0, 17);
                    numfixed.AddBet(0, 18);
                }
                else if (nineteenTo36.Background == Brushes.Blue)
                {
                    numfixed.AddBet(nineteenTo36nums, 19);
                    numfixed.AddBet(0, 20);
                    numfixed.AddBet(0, 21);
                    numfixed.AddBet(0, 22);
                    numfixed.AddBet(0, 23);
                    numfixed.AddBet(0, 24);
                    numfixed.AddBet(0, 25);
                    numfixed.AddBet(0, 26);
                    numfixed.AddBet(0, 27);
                    numfixed.AddBet(0, 28);
                    numfixed.AddBet(0, 29);
                    numfixed.AddBet(0, 30);
                    numfixed.AddBet(0, 31);
                    numfixed.AddBet(0, 32);
                    numfixed.AddBet(0, 33);
                    numfixed.AddBet(0, 34);
                    numfixed.AddBet(0, 35);
                    numfixed.AddBet(0, 36);
                }
                else if (evenSlot.Background == Brushes.Blue)
                {
                    numfixed.AddBet(evennums, 2);
                    numfixed.AddBet(0, 4);
                    numfixed.AddBet(0, 6);
                    numfixed.AddBet(0, 8);
                    numfixed.AddBet(0, 10);
                    numfixed.AddBet(0, 12);
                    numfixed.AddBet(0, 14);
                    numfixed.AddBet(0, 16);
                    numfixed.AddBet(0, 18);
                    numfixed.AddBet(0, 20);
                    numfixed.AddBet(0, 22);
                    numfixed.AddBet(0, 24);
                    numfixed.AddBet(0, 26);
                    numfixed.AddBet(0, 28);
                    numfixed.AddBet(0, 30);
                    numfixed.AddBet(0, 32);
                    numfixed.AddBet(0, 34);
                    numfixed.AddBet(0, 36);
                }
                else if (oddSlot.Background == Brushes.Blue)
                {
                    numfixed.AddBet(oddnums, 1);
                    numfixed.AddBet(0, 3);
                    numfixed.AddBet(0, 5);
                    numfixed.AddBet(0, 7);
                    numfixed.AddBet(0, 9);
                    numfixed.AddBet(0, 11);
                    numfixed.AddBet(0, 13);
                    numfixed.AddBet(0, 15);
                    numfixed.AddBet(0, 17);
                    numfixed.AddBet(0, 19);
                    numfixed.AddBet(0, 21);
                    numfixed.AddBet(0, 23);
                    numfixed.AddBet(0, 25);
                    numfixed.AddBet(0, 27);
                    numfixed.AddBet(0, 29);
                    numfixed.AddBet(0, 31);
                    numfixed.AddBet(0, 33);
                    numfixed.AddBet(0, 35);
                }
                else if (redSlot.Background == Brushes.Blue)
                {
                    numfixed.AddBet(rednums, 1);
                    numfixed.AddBet(0, 3);
                    numfixed.AddBet(0, 5);
                    numfixed.AddBet(0, 7);
                    numfixed.AddBet(0, 9);
                    numfixed.AddBet(0, 12);
                    numfixed.AddBet(0, 14);
                    numfixed.AddBet(0, 16);
                    numfixed.AddBet(0, 18);
                    numfixed.AddBet(0, 19);
                    numfixed.AddBet(0, 21);
                    numfixed.AddBet(0, 23);
                    numfixed.AddBet(0, 25);
                    numfixed.AddBet(0, 27);
                    numfixed.AddBet(0, 30);
                    numfixed.AddBet(0, 32);
                    numfixed.AddBet(0, 34);
                    numfixed.AddBet(0, 36);
                }
                else if (blackSlot.Background == Brushes.Blue)
                {
                    numfixed.AddBet(blacknums, 2);
                    numfixed.AddBet(0, 4);
                    numfixed.AddBet(0, 6);
                    numfixed.AddBet(0, 8);
                    numfixed.AddBet(0, 10);
                    numfixed.AddBet(0, 11);
                    numfixed.AddBet(0, 13);
                    numfixed.AddBet(0, 15);
                    numfixed.AddBet(0, 17);
                    numfixed.AddBet(0, 20);
                    numfixed.AddBet(0, 22);
                    numfixed.AddBet(0, 24);
                    numfixed.AddBet(0, 26);
                    numfixed.AddBet(0, 28);
                    numfixed.AddBet(0, 29);
                    numfixed.AddBet(0, 31);
                    numfixed.AddBet(0, 33);
                    numfixed.AddBet(0, 35);
                }
                else
                {
                    //tests to see if each individual number is selected
                    if (redOne.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 1);
                    }
                    if (blackTwo.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 2);
                    }
                    if (redThree.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 3);
                    }
                    if (blackFour.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 4);
                    }
                    if (redFive.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 5);
                    }
                    if (blackSix.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 6);
                    }
                    if (redSeven.Background == Brushes.Blue)
                    {
                        numfixed.AddBet(1, 7);
                    }
                    if (blackEight.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 8);
                    }
                    if (redNine.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 9);
                    }
                    if (blackTen.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 10);
                    }
                    if (blackEleven.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 11);
                    }
                    if (redTwelve.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 12);
                    }
                    if (blackThirteen.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 13);
                    }
                    if (redForteen.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 14);
                    }
                    if (blackFifteen.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 15);
                    }
                    if (redSixteen.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 16);
                    }
                    if (blackSeventeen.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 17);
                    }
                    if (redEighteen.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 18);
                    }
                    if (redNineteen.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 19);
                    }
                    if (blackTwenty.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 20);
                    }
                    if (redTwentyOne.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 21);
                    }
                    if (blackTwentyTwo.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 22);
                    }
                    if (redTwentyThree.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 23);
                    }
                    if (blackTwentyFour.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 24);
                    }
                    if (redTwentyFive.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 25);
                    }
                    if (blackTwentySix.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 26);
                    }
                    if (redTwentySeven.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 27);
                    }
                    if (blackTwentyEight.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 28);
                    }
                    if (blackTwentyNine.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 29);
                    }
                    if (redThirty.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 30);
                    }
                    if (blackThirtyOne.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 31);
                    }
                    if (redThirtyTwo.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 32);
                    }
                    if (blackThirtyThree.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 33);
                    }
                    if (redThirtyFour.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 34);
                    }
                    if (blackThirtyFive.Background == Brushes.Blue)
                    {

                        
                        numfixed.AddBet(1, 35);
                    }
                    if (redThirtySix.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 36);
                    }
                    if (singleZero.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 38);
                    }
                    if (zeroZero.Background == Brushes.Blue)
                    {

                        numfixed.AddBet(1, 37);
                    }
                }

                //displays the user's bets
                BetsTotal.Text = "";
                foreach (int i in numfixed.SendSelectedArray())
                {
                    if (i == 38)
                    {
                        BetsTotal.Text += "0";
                        BetsTotal.Text += ", ";
                    }

                    else if (i == 37)
                    {
                        BetsTotal.Text += "00";
                        BetsTotal.Text += ", ";
                    }
                    else
                    {
                        BetsTotal.Text += i.ToString();
                        BetsTotal.Text += ", ";
                    }
                }

                //initializes the winning total
                double yourWins = 0;        
                //This switch statement is to catch all possible winning numbers.
                //The case statement pushes the bests of an unselected winning number
                //to a negative number. 
                //If the user selects the winning number, then the number gets pushed through
                //the WinnersorLosers method inside of the Roulette Library.
                //It will print the win and the number of bets. 
                switch (timeToWin)
                {                    
                    case 0:
                        if (singleZero.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else

                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(38);
                            if (zero.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(38) * zero.PostBet(); }
                            else
                            {                               
                                yourWins = numfixed.WinnersOrLosers(38) * numfixed.PostBet();
                            }
                        }
                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        
                        break;

                    case 1:
                        if (redOne.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(1);
                            if (one.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(1) * one.PostBet(); }
                            else
                            {      
                                yourWins = numfixed.WinnersOrLosers(1) * numfixed.PostBet();
                            }
                        }
                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;

                    case 2:

                        if (blackTwo.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(2);
                            if (two.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(2) * two.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(2) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;

                    case 3:
                        if (redThree.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(3);
                            if (three.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(3) * three.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(3) * numfixed.PostBet();
                            }
                        }
                        
                        BetsTotal.Text += "\n";
                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;

                    case 4:
                        if (blackFour.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(4);
                            if (four.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(4) * four.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(4) * numfixed.PostBet();
                            }
                        }
                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;

                    case 5:
                        if (redFive.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(5);
                            if (five.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(5) * five.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(5) * numfixed.PostBet();
                            }
                        }


                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;

                    case 6:
                        if (blackSix.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(6);
                            if (six.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(6) * six.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(6) * numfixed.PostBet();
                            }
                        }
                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 7:
                        if (redSeven.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(7);
                            if (seven.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(7) * seven.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(7) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;
                    case 8:
                        if (blackEight.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(8);
                            if (eight.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(8) * eight.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(8) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 9:
                        if (redNine.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(9);
                            if (nine.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(9) * nine.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(9) * numfixed.PostBet();
                            }
                        }


                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;

                    case 10:
                        if (blackTen.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(10);
                            if (ten.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(10) * ten.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(10) * numfixed.PostBet();
                            }
                        }


                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;

                    case 11:
                        if (blackEleven.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(11);
                            if (eleven.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(11) * eleven.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(11) * numfixed.PostBet();
                            }
                        }


                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;
                    case 12:
                        if (redTwelve.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(12);
                            if (twelve.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(12) * twelve.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(12) * numfixed.PostBet();
                            }
                        }


                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;

                    case 13:
                        if (blackThirteen.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(13);
                            if (thirteen.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(13) * thirteen.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(13) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;

                    case 14:
                        if (redForteen.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(14);
                            if (fourteen.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(14) * fourteen.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(14) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;
                    case 15:
                        if (blackFifteen.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(15);
                            if (fifteen.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(15) * fifteen.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(15) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 16:
                        if (redSixteen.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(16);
                            if (sixteen.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(16) * sixteen.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(16) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 17:
                        if (blackSeventeen.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(17);
                            if (seventeen.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(17) * seventeen.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(17) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;

                    case 18:
                        if (redEighteen.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(18);
                            if (eighteen.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(18) * eighteen.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(18) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 19:
                        if (redNineteen.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(19);
                            if (nineteen.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(19) * nineteen.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(19) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 20:
                        if (blackTwenty.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(20);
                            if (twenty.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(20) * twenty.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(20) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 21:
                        if (redTwentyOne.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(21);
                            if (twentyone.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(21) * twentyone.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(21) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 22:
                        if (blackTwentyTwo.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(22);
                            if (twentytwo.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(22) * twentytwo.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(22) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 23:
                        if (redTwentyThree.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(23);
                            if (twentythree.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(23) * twentythree.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(23) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 24:
                        if (blackTwentyFour.Background != Brushes.Blue)
                        {

                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(24);
                            if (twentyfour.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(24) * twentyfour.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(24) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 25:
                        if (redTwentyFive.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(25);
                            if (twentyfive.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(25) * twentyfive.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(25) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;
                    case 26:
                        if (blackTwentySix.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(26);
                            if (twentysix.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(26) * twentysix.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(26) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;

                    case 27:
                        if (redTwentySeven.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(27);
                            if (twentyseven.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(27) * twentyseven.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(27) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;
                    case 28:
                        if (blackTwentyEight.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(28);
                            if (twentyeight.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(28) * twentyeight.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(28) * numfixed.PostBet();
                            }
                        }
                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;
                    case 29:
                        if (blackTwentyNine.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(29);
                            if (twentynine.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(29) * twentynine.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(29) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;

                    case 30:
                        if (redThirty.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(30);
                            if (thirty.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(30) * thirty.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(30) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 31:
                        if (blackThirtyOne.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(31);
                            if (thirtyone.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(31) * thirtyone.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(31) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;
                    case 32:
                        if (redThirtyTwo.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(32);
                            if (thirtytwo.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(32) * thirtytwo.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(32) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;
                    case 33:
                        if (blackThirtyThree.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(33);
                            if (thirtythree.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(33) * thirtythree.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(33) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    case 34:
                        if (redThirtyFour.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(34);
                            if (thirtyfour.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(34) * thirtyfour.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(34) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;
                    case 35:
                        if (blackThirtyFive.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(35);
                            if (thirtyfive.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(35) * thirtyfive.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(35) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;

                    case 36:
                        if (redThirtySix.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(36);
                            if (thirtysix.PostBet() > 0)
                            { yourWins = numfixed.WinnersOrLosers(36) * thirtysix.PostBet(); }
                            else
                            {
                                yourWins = numfixed.WinnersOrLosers(36) * numfixed.PostBet();
                            }
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";
                        break;
                        
                    case 37:
                        if (zeroZero.Background != Brushes.Blue)
                        {
                            yourWins = -TotalBets;
                        }
                        else
                        {
                            BetsTotal.Text = " ";
                            numfixed.WinningNumber(37);
                            yourWins = numfixed.WinnersOrLosers(37);
                        }

                        Bets.Text += "\n";
                        Bets.Text = $"{yourWins:C}";
                        Bets.Text += " ";
                        Bets.Text += "\n";
                        Bets.Text += $"Total Bets: {TotalBets}";

                        break;
                    default:
                        BetsTotal.Text = "Dealer Bomb";
                        break;

                }
                
                
            }
            //Code used to catch exceptions.
            catch (Exception Ex)
            {
                BetsTotal.Text = "";
                BetsTotal.Text += Ex.Message;
            }
            //Finally statement to reset all calculations. 
            finally
            {
                
                firstcolumn = 0;
                secondcolumn = 0;
                thirdcolumn = 0;
                first12nums = 0;
                second12nums = 0;
                third12nums = 0;
                firstTo8 = 0;
                evennums = 0;
                oddnums = 0;
                rednums = 0;
                blacknums = 0;
                nineteenTo36nums = 0;
                one.Bet = 0;
                two.Bet = 0;
                three.Bet = 0;
                four.Bet = 0;
                five.Bet = 0;
                six.Bet = 0;
                seven.Bet = 0;
                eight.Bet = 0;
                nine.Bet = 0;
                ten.Bet = 0;
                eleven.Bet = 0;
                twelve.Bet = 0;
                thirteen.Bet = 0;
                fourteen.Bet = 0;
                fifteen.Bet = 0;
                sixteen.Bet = 0;
                seventeen.Bet = 0;
                eighteen.Bet = 0;
                nineteen.Bet = 0;
                twenty.Bet = 0;
                twentyone.Bet = 0;
                twentytwo.Bet = 0;
                twentythree.Bet = 0;
                twentyfour.Bet = 0;
                twentyfive.Bet = 0;
                twentysix.Bet = 0;
                twentyseven.Bet = 0;
                twentyeight.Bet = 0;
                twentynine.Bet = 0;
                thirty.Bet = 0;
                thirtyone.Bet = 0;
                thirtytwo.Bet = 0;
                thirtythree.Bet = 0;
                thirtyfour.Bet = 0;
                thirtyfive.Bet = 0;
                thirtysix.Bet = 0;
                zerozero.Bet = 0;
                zero.Bet = 0;
                twoTo1stCol.Bet = 0;
                twoTo2ndCol.Bet = 0;
                twoTo3rdCol.Bet = 0;
                First12.Bet = 0;
                Second12.Bet = 0;
                Third12.Bet = 0;
                Firstto18.Bet = 0;
                evens.Bet = 0;
                odds.Bet = 0;
                red.Bet = 0;
                nineTeenTo36.Bet = 0;

                redOne.Background = Brushes.Red;
                blackTwo.Background = Brushes.Black;
                redThree.Background = Brushes.Red;
                blackFour.Background = Brushes.Black;
                redFive.Background = Brushes.Red;
                blackFour.Background = Brushes.Black;
                redFive.Background = Brushes.Red;
                blackSix.Background = Brushes.Black;
                redSeven.Background = Brushes.Red;
                blackEight.Background = Brushes.Black;
                redNine.Background = Brushes.Red;
                blackTen.Background = Brushes.Black;
                blackEleven.Background = Brushes.Black;
                redTwelve.Background = Brushes.Red;
                blackThirteen.Background = Brushes.Black;
                redForteen.Background = Brushes.Red;
                blackFifteen.Background = Brushes.Black;
                redSixteen.Background = Brushes.Red;
                blackSeventeen.Background = Brushes.Black;
                redEighteen.Background = Brushes.Red;
                redNineteen.Background = Brushes.Red;
                blackTwenty.Background = Brushes.Black;
                redTwentyOne.Background = Brushes.Red;
                blackTwentyTwo.Background = Brushes.Black;
                redTwentyThree.Background = Brushes.Red;
                blackTwentyFour.Background = Brushes.Black;
                redTwentyFive.Background = Brushes.Red;
                blackTwentySix.Background = Brushes.Black;
                redTwentySeven.Background = Brushes.Red;
                blackTwentyEight.Background = Brushes.Black;
                blackTwentyNine.Background = Brushes.Black;
                redThirty.Background = Brushes.Red;
                blackThirtyOne.Background = Brushes.Black;
                redThirtyTwo.Background = Brushes.Red;
                blackThirtyThree.Background = Brushes.Black;
                redThirtyFour.Background = Brushes.Red;
                blackThirtyFive.Background = Brushes.Black;
                redThirtySix.Background = Brushes.Red;
                singleZero.Background = Brushes.DarkGreen;
                zeroZero.Background = Brushes.DarkGreen;
                TwoToOne1stCol.Background = Brushes.Green;
                TwoToOne2ndCol.Background = Brushes.Green;
                TwoToOne3rdCol.Background = Brushes.Green;
                first12.Background = Brushes.Green;
                second12.Background = Brushes.Green;
                third12.Background = Brushes.Green;
                evenSlot.Background = Brushes.Green;
                oddSlot.Background = Brushes.Green;
                redSlot.Background = Brushes.Red;
                blackSlot.Background = Brushes.Black;
                oneTo18Slot.Background = Brushes.Green;
                nineteenTo36.Background = Brushes.Green;
                TotalBets = 0;
                specialIndex = 0;
                TimeToWin();
                box.Text = "";
                box.Text += timeToWin.ToString();
               
                spinner.Visibility = Visibility.Collapsed;

            }
        }

        
    }
}
