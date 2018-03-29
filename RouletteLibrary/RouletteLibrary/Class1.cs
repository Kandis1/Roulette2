using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Roulette
    {
        //initialize fields within the class
        private int bet = 0;
         
        public int[] selectednums = new int[38];
        
        private int selectionTracker = 0;
        private int winningNum;

        //set the default constructor
        public Roulette()
        {
            this.bet = 0;
            this.selectednums = new int[38]{ 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99 };
        }

        //set anther constructor to adjust array to bets
      
        public Roulette(int arraychange)
        {
            
            this.selectednums = new int[arraychange];
            this.winningNum = 0;
        }
        
        public void AddBet(int addbet, int specifiedbet)
        {
            //add an additional bet when called
            //adjust the array of selected numbers
            bool numChecker = false;

            for (int i = 0; i < selectednums.Length-1; i++)
            {
                if (numChecker == true)
                {
                    break;
                }
                else if (selectednums[i] == specifiedbet)
                {
                    
                    numChecker = true;                    
                }

            }
            if (numChecker == false)
                {
                    
                    selectednums[this.selectionTracker] = specifiedbet;
                    this.selectionTracker++;                
                }

            this.bet += addbet;
         

        }
        public int WinningNumber(int winningnum)
        {
            //set and return winning number
            this.winningNum = winningnum;
            return winningnum;
        }
        
        public int Bet
        {
            //get and set new bets
            get { return bet; }
            set { this.bet = value; }        
        }
        

        public int PostBet()
        {
            //post the number of bets made to each variable
            return this.bet;
        }
        public int[] SendSelectedArray()
        {
            //return array of selected numbers
            return this.selectednums;
        }
        public string selectedNumbers()
        {
            //catch and add all selected numbers 
            //within the roulette game
            string userselections = " ";          
            
            for (int i = 0; i < selectednums.Length - 1; i++)
            {
                if (selectednums[i] == 37)
                {
                    userselections += "00, ";
                }
                else if (selectednums[i] == 38)
                {
                    if (!selectednums.Contains(0))
                    {
                        userselections += "0, ";
                    }
                }
                else if(selectednums[i] != 0)
                {
                    if (!userselections.Contains(selectednums[i].ToString()))
                        userselections += $"{selectednums[i]}";

                    userselections += " ";
                }
            }

            return userselections;
        }
  
        public double WinnersOrLosers(int receive)
        {
            //calculates all possible win totals and returns the number
            //to the Roulette program.
            double winsOrlosses = 0;
            double transfer = 0;

            if (this.selectednums.Contains(receive))
            {
                winsOrlosses = 35;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2)
                             || this.selectednums.Contains(1) && this.selectednums.Contains(4)
                             || this.selectednums.Contains(2) && this.selectednums.Contains(5)
                             || this.selectednums.Contains(2) && this.selectednums.Contains(3)
                             || this.selectednums.Contains(3) && this.selectednums.Contains(6)
                             || this.selectednums.Contains(4) && this.selectednums.Contains(7)
                             || this.selectednums.Contains(4) && this.selectednums.Contains(5)
                             || this.selectednums.Contains(5) && this.selectednums.Contains(8)
                             || this.selectednums.Contains(5) && this.selectednums.Contains(6)
                             || this.selectednums.Contains(6) && this.selectednums.Contains(9)
                             || this.selectednums.Contains(7) && this.selectednums.Contains(10)
                             || this.selectednums.Contains(7) && this.selectednums.Contains(8)
                             || this.selectednums.Contains(8) && this.selectednums.Contains(11)
                             || this.selectednums.Contains(8) && this.selectednums.Contains(9)
                             || this.selectednums.Contains(9) && this.selectednums.Contains(12)
                             || this.selectednums.Contains(10) && this.selectednums.Contains(13)
                             || this.selectednums.Contains(10) && this.selectednums.Contains(11)
                             || this.selectednums.Contains(11) && this.selectednums.Contains(12)
                             || this.selectednums.Contains(11) && this.selectednums.Contains(14)
                             || this.selectednums.Contains(12) && this.selectednums.Contains(15)
                             || this.selectednums.Contains(13) && this.selectednums.Contains(14)
                             || this.selectednums.Contains(13) && this.selectednums.Contains(16)
                             || this.selectednums.Contains(14) && this.selectednums.Contains(15)
                             || this.selectednums.Contains(14) && this.selectednums.Contains(17)
                             || this.selectednums.Contains(15) && this.selectednums.Contains(18)
                             || this.selectednums.Contains(16) && this.selectednums.Contains(19)
                             || this.selectednums.Contains(16) && this.selectednums.Contains(17)
                             || this.selectednums.Contains(17) && this.selectednums.Contains(20)
                             || this.selectednums.Contains(17) && this.selectednums.Contains(18)
                             || this.selectednums.Contains(18) && this.selectednums.Contains(21)
                             || this.selectednums.Contains(19) && this.selectednums.Contains(22)
                             || this.selectednums.Contains(19) && this.selectednums.Contains(20)
                             || this.selectednums.Contains(20) && this.selectednums.Contains(23)
                             || this.selectednums.Contains(20) && this.selectednums.Contains(21)
                             || this.selectednums.Contains(21) && this.selectednums.Contains(24)
                             || this.selectednums.Contains(22) && this.selectednums.Contains(25)
                             || this.selectednums.Contains(22) && this.selectednums.Contains(23)
                             || this.selectednums.Contains(23) && this.selectednums.Contains(26)
                             || this.selectednums.Contains(23) && this.selectednums.Contains(24)
                             || this.selectednums.Contains(24) && this.selectednums.Contains(27)
                             || this.selectednums.Contains(25) && this.selectednums.Contains(28)
                             || this.selectednums.Contains(25) && this.selectednums.Contains(26)
                             || this.selectednums.Contains(26) && this.selectednums.Contains(29)
                             || this.selectednums.Contains(26) && this.selectednums.Contains(27)
                             || this.selectednums.Contains(27) && this.selectednums.Contains(30)
                             || this.selectednums.Contains(28) && this.selectednums.Contains(31)
                             || this.selectednums.Contains(28) && this.selectednums.Contains(29)
                             || this.selectednums.Contains(29) && this.selectednums.Contains(32)
                             || this.selectednums.Contains(29) && this.selectednums.Contains(30)
                             || this.selectednums.Contains(30) && this.selectednums.Contains(33)
                             || this.selectednums.Contains(31) && this.selectednums.Contains(34)
                             || this.selectednums.Contains(31) && this.selectednums.Contains(32)
                             || this.selectednums.Contains(32) && this.selectednums.Contains(35)
                             || this.selectednums.Contains(32) && this.selectednums.Contains(33)
                             || this.selectednums.Contains(33) && this.selectednums.Contains(36)
                             || this.selectednums.Contains(34) && this.selectednums.Contains(35)
                             || this.selectednums.Contains(35) && this.selectednums.Contains(36))


            {
                winsOrlosses = 17;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2) && this.selectednums.Contains(3)
                     || this.selectednums.Contains(4) && this.selectednums.Contains(5) && this.selectednums.Contains(6)
                     || this.selectednums.Contains(7) && this.selectednums.Contains(8) && this.selectednums.Contains(9)
                     || this.selectednums.Contains(10) && this.selectednums.Contains(11) && this.selectednums.Contains(12)
                     || this.selectednums.Contains(13) && this.selectednums.Contains(14) && this.selectednums.Contains(15)
                     || this.selectednums.Contains(16) && this.selectednums.Contains(17) && this.selectednums.Contains(18)
                     || this.selectednums.Contains(19) && this.selectednums.Contains(20) && this.selectednums.Contains(21)
                     || this.selectednums.Contains(22) && this.selectednums.Contains(23) && this.selectednums.Contains(24)
                     || this.selectednums.Contains(25) && this.selectednums.Contains(26) && this.selectednums.Contains(27)
                     || this.selectednums.Contains(28) && this.selectednums.Contains(29) && this.selectednums.Contains(30)
                     || this.selectednums.Contains(31) && this.selectednums.Contains(32) && this.selectednums.Contains(33)
                     || this.selectednums.Contains(34) && this.selectednums.Contains(35) && this.selectednums.Contains(36))
            {
                winsOrlosses = 11;
            }
            else if (this.selectednums.Contains(38) && this.selectednums.Contains(1) && this.selectednums.Contains(2) && receive == 0
                            || this.selectednums.Contains(38) && this.selectednums.Contains(1) && this.selectednums.Contains(2) && receive == 1
                            || this.selectednums.Contains(38) && this.selectednums.Contains(1) && this.selectednums.Contains(2) && receive == 2
                            || this.selectednums.Contains(38) && this.selectednums.Contains(2) && this.selectednums.Contains(3) && receive == 38
                            || this.selectednums.Contains(38) && this.selectednums.Contains(2) && this.selectednums.Contains(3) && receive == 2
                            || this.selectednums.Contains(38) && this.selectednums.Contains(2) && this.selectednums.Contains(3) && receive == 3)
            {

                winsOrlosses = 11;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2)
                            && this.selectednums.Contains(4) && this.selectednums.Contains(5)

                            || this.selectednums.Contains(2) && this.selectednums.Contains(3)
                            && this.selectednums.Contains(5) && this.selectednums.Contains(6)

                            || this.selectednums.Contains(7) && this.selectednums.Contains(8)
                            && this.selectednums.Contains(10) && this.selectednums.Contains(11)

                            || this.selectednums.Contains(8) && this.selectednums.Contains(9)
                            && this.selectednums.Contains(11) && this.selectednums.Contains(12)

                            || this.selectednums.Contains(13) && this.selectednums.Contains(14)
                            && this.selectednums.Contains(16) && this.selectednums.Contains(17)

                            || this.selectednums.Contains(14) && this.selectednums.Contains(15)
                            && this.selectednums.Contains(17) && this.selectednums.Contains(18)

                            || this.selectednums.Contains(16) && this.selectednums.Contains(17)
                            && this.selectednums.Contains(19) && this.selectednums.Contains(20)

                            || this.selectednums.Contains(17) && this.selectednums.Contains(18)
                            && this.selectednums.Contains(20) && this.selectednums.Contains(21)

                            || this.selectednums.Contains(19) && this.selectednums.Contains(20)
                            && this.selectednums.Contains(22) && this.selectednums.Contains(23)

                            || this.selectednums.Contains(20) && this.selectednums.Contains(21)
                            && this.selectednums.Contains(23) && this.selectednums.Contains(24)

                            || this.selectednums.Contains(22) && this.selectednums.Contains(23)
                            && this.selectednums.Contains(25) && this.selectednums.Contains(26)

                            || this.selectednums.Contains(23) && this.selectednums.Contains(24)
                            && this.selectednums.Contains(26) && this.selectednums.Contains(27)

                            || this.selectednums.Contains(25) && this.selectednums.Contains(26)
                            && this.selectednums.Contains(28) && this.selectednums.Contains(29)

                            || this.selectednums.Contains(26) && this.selectednums.Contains(27)
                            && this.selectednums.Contains(29) && this.selectednums.Contains(30)

                            || this.selectednums.Contains(28) && this.selectednums.Contains(29)
                            && this.selectednums.Contains(31) && this.selectednums.Contains(32)

                            || this.selectednums.Contains(29) && this.selectednums.Contains(30)
                            && this.selectednums.Contains(32) && this.selectednums.Contains(33)

                            || this.selectednums.Contains(31) && this.selectednums.Contains(32)
                            && this.selectednums.Contains(34) && this.selectednums.Contains(35)

                            || this.selectednums.Contains(32) && this.selectednums.Contains(33)
                            && this.selectednums.Contains(35) && this.selectednums.Contains(36)

                            )
            {
                winsOrlosses = 8;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2) && this.selectednums.Contains(3)
                            && this.selectednums.Contains(4) && this.selectednums.Contains(5) && this.selectednums.Contains(6)

                            || this.selectednums.Contains(4) && this.selectednums.Contains(5) && this.selectednums.Contains(6)
                            && this.selectednums.Contains(7) && this.selectednums.Contains(8) && this.selectednums.Contains(9)

                            || this.selectednums.Contains(7) && this.selectednums.Contains(8) && this.selectednums.Contains(9)
                            && this.selectednums.Contains(10) && this.selectednums.Contains(11) && this.selectednums.Contains(12)

                            || this.selectednums.Contains(10) && this.selectednums.Contains(11) && this.selectednums.Contains(12)
                            && this.selectednums.Contains(13) && this.selectednums.Contains(14) && this.selectednums.Contains(15)

                            || this.selectednums.Contains(13) && this.selectednums.Contains(14) && this.selectednums.Contains(15)
                            && this.selectednums.Contains(16) && this.selectednums.Contains(17) && this.selectednums.Contains(18)

                            || this.selectednums.Contains(16) && this.selectednums.Contains(17) && this.selectednums.Contains(18)
                            && this.selectednums.Contains(19) && this.selectednums.Contains(20) && this.selectednums.Contains(21)

                            || this.selectednums.Contains(19) && this.selectednums.Contains(20) && this.selectednums.Contains(21)
                            && this.selectednums.Contains(22) && this.selectednums.Contains(23) && this.selectednums.Contains(24)

                            || this.selectednums.Contains(22) && this.selectednums.Contains(23) && this.selectednums.Contains(24)
                            && this.selectednums.Contains(25) && this.selectednums.Contains(26) && this.selectednums.Contains(27)

                            || this.selectednums.Contains(25) && this.selectednums.Contains(26) && this.selectednums.Contains(27)
                            && this.selectednums.Contains(28) && this.selectednums.Contains(29) && this.selectednums.Contains(30)

                            || this.selectednums.Contains(28) && this.selectednums.Contains(29) && this.selectednums.Contains(30)
                            && this.selectednums.Contains(31) && this.selectednums.Contains(32) && this.selectednums.Contains(33)

                            || this.selectednums.Contains(31) && this.selectednums.Contains(32) && this.selectednums.Contains(33)
                            && this.selectednums.Contains(34) && this.selectednums.Contains(35) && this.selectednums.Contains(36)
                            )
            {
                winsOrlosses = 5;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2) && this.selectednums.Contains(3)
                && this.selectednums.Contains(4) && this.selectednums.Contains(5) && this.selectednums.Contains(6)
                && this.selectednums.Contains(7) && this.selectednums.Contains(8) && this.selectednums.Contains(9)
                && this.selectednums.Contains(10) && this.selectednums.Contains(11) && this.selectednums.Contains(12)

                || this.selectednums.Contains(13) && this.selectednums.Contains(14) && this.selectednums.Contains(15)
                && this.selectednums.Contains(16) && this.selectednums.Contains(17) && this.selectednums.Contains(18)
                && this.selectednums.Contains(19) && this.selectednums.Contains(20) && this.selectednums.Contains(21)
                && this.selectednums.Contains(22) && this.selectednums.Contains(23) && this.selectednums.Contains(24)

                || this.selectednums.Contains(25) && this.selectednums.Contains(26) && this.selectednums.Contains(27)
                && this.selectednums.Contains(28) && this.selectednums.Contains(29) && this.selectednums.Contains(30)
                && this.selectednums.Contains(31) && this.selectednums.Contains(32) && this.selectednums.Contains(33)
                && this.selectednums.Contains(34) && this.selectednums.Contains(35) && this.selectednums.Contains(36)

                )
            {
                winsOrlosses = 2;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(4) && this.selectednums.Contains(7)
                            && this.selectednums.Contains(10) && this.selectednums.Contains(13) && this.selectednums.Contains(16)
                            && this.selectednums.Contains(19) && this.selectednums.Contains(22) && this.selectednums.Contains(25)
                            && this.selectednums.Contains(28) && this.selectednums.Contains(31) && this.selectednums.Contains(34)

                            || this.selectednums.Contains(2) && this.selectednums.Contains(5) && this.selectednums.Contains(8)
                            && this.selectednums.Contains(11) && this.selectednums.Contains(14) && this.selectednums.Contains(17)
                            && this.selectednums.Contains(20) && this.selectednums.Contains(23) && this.selectednums.Contains(26)
                            && this.selectednums.Contains(29) && this.selectednums.Contains(32) && this.selectednums.Contains(35)

                            || this.selectednums.Contains(3) && this.selectednums.Contains(6) && this.selectednums.Contains(9)
                            && this.selectednums.Contains(12) && this.selectednums.Contains(15) && this.selectednums.Contains(18)
                            && this.selectednums.Contains(21) && this.selectednums.Contains(24) && this.selectednums.Contains(27)
                            && this.selectednums.Contains(30) && this.selectednums.Contains(33) && this.selectednums.Contains(36)

                            )
            {
                winsOrlosses = 2;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2) && this.selectednums.Contains(3)
                               && this.selectednums.Contains(4) && this.selectednums.Contains(5) && this.selectednums.Contains(6)
                               && this.selectednums.Contains(7) && this.selectednums.Contains(8) && this.selectednums.Contains(9)
                               && this.selectednums.Contains(10) && this.selectednums.Contains(11) && this.selectednums.Contains(12)
                               && this.selectednums.Contains(13) && this.selectednums.Contains(14) && this.selectednums.Contains(15)
                               && this.selectednums.Contains(16) && this.selectednums.Contains(17) && this.selectednums.Contains(18)

                               || this.selectednums.Contains(19) && this.selectednums.Contains(20) && this.selectednums.Contains(21)
                               && this.selectednums.Contains(22) && this.selectednums.Contains(23) && this.selectednums.Contains(24)
                               && this.selectednums.Contains(25) && this.selectednums.Contains(26) && this.selectednums.Contains(27)
                               && this.selectednums.Contains(28) && this.selectednums.Contains(29) && this.selectednums.Contains(30)
                               && this.selectednums.Contains(31) && this.selectednums.Contains(32) && this.selectednums.Contains(33)
                               && this.selectednums.Contains(34) && this.selectednums.Contains(35) && this.selectednums.Contains(36)

                               )
            {
                winsOrlosses = 1;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(3) && this.selectednums.Contains(5)
                           && this.selectednums.Contains(7) && this.selectednums.Contains(9) && this.selectednums.Contains(12)
                           && this.selectednums.Contains(14) && this.selectednums.Contains(16) && this.selectednums.Contains(18)
                           && this.selectednums.Contains(19) && this.selectednums.Contains(21) && this.selectednums.Contains(23)
                           && this.selectednums.Contains(25) && this.selectednums.Contains(27) && this.selectednums.Contains(30)
                           && this.selectednums.Contains(32) && this.selectednums.Contains(34) && this.selectednums.Contains(36)

                           || this.selectednums.Contains(2) && this.selectednums.Contains(4) && this.selectednums.Contains(6)
                           && this.selectednums.Contains(8) && this.selectednums.Contains(10) && this.selectednums.Contains(11)
                           && this.selectednums.Contains(13) && this.selectednums.Contains(15) && this.selectednums.Contains(17)
                           && this.selectednums.Contains(20) && this.selectednums.Contains(22) && this.selectednums.Contains(24)
                           && this.selectednums.Contains(26) && this.selectednums.Contains(28) && this.selectednums.Contains(29)
                           && this.selectednums.Contains(31) && this.selectednums.Contains(33) && this.selectednums.Contains(35)

                           )
            {
                winsOrlosses = 1;
            }

            if (this.selectednums.Contains(1) && this.selectednums.Contains(3) && this.selectednums.Contains(5)
               && this.selectednums.Contains(7) && this.selectednums.Contains(9) && this.selectednums.Contains(11)
               && this.selectednums.Contains(15) && this.selectednums.Contains(17) && this.selectednums.Contains(19)
               && this.selectednums.Contains(21) && this.selectednums.Contains(23) && this.selectednums.Contains(25)
               && this.selectednums.Contains(27) && this.selectednums.Contains(29) && this.selectednums.Contains(31)
               && this.selectednums.Contains(33) && this.selectednums.Contains(35) && this.selectednums.Contains(13)

               || this.selectednums.Contains(2) && this.selectednums.Contains(4) && this.selectednums.Contains(6)
               && this.selectednums.Contains(8) && this.selectednums.Contains(10) && this.selectednums.Contains(12)
               && this.selectednums.Contains(14) && this.selectednums.Contains(16) && this.selectednums.Contains(18)
               && this.selectednums.Contains(20) && this.selectednums.Contains(22) && this.selectednums.Contains(24)
               && this.selectednums.Contains(26) && this.selectednums.Contains(28) && this.selectednums.Contains(30)
               && this.selectednums.Contains(32) && this.selectednums.Contains(34) && this.selectednums.Contains(36)

               )
            {
                winsOrlosses = 1;
            }
            transfer = winsOrlosses;
            return transfer;

        }

        //this is pending a delete
        /*
        public double Losses(int receive)
        {            
            double transfer = 0;

           // if (selectednums.Length > 1)
            //{ 
               
            if (this.selectednums.Contains(1) && this.selectednums.Contains(3) && this.selectednums.Contains(5)
               && this.selectednums.Contains(7) && this.selectednums.Contains(9) && this.selectednums.Contains(11)
               && this.selectednums.Contains(15) && this.selectednums.Contains(17) && this.selectednums.Contains(19)
               && this.selectednums.Contains(21) && this.selectednums.Contains(23) && this.selectednums.Contains(25)
               && this.selectednums.Contains(27) && this.selectednums.Contains(29) && this.selectednums.Contains(31)
               && this.selectednums.Contains(33) && this.selectednums.Contains(35) && this.selectednums.Contains(13) 

               || this.selectednums.Contains(2) && this.selectednums.Contains(4) && this.selectednums.Contains(6)
               && this.selectednums.Contains(8) && this.selectednums.Contains(10) && this.selectednums.Contains(12)
               && this.selectednums.Contains(14) && this.selectednums.Contains(16) && this.selectednums.Contains(18)
               && this.selectednums.Contains(20) && this.selectednums.Contains(22) && this.selectednums.Contains(24)
               && this.selectednums.Contains(26) && this.selectednums.Contains(28) && this.selectednums.Contains(30)
                && this.selectednums.Contains(32) && this.selectednums.Contains(34) && this.selectednums.Contains(36)
                
               )
            {
                transfer = 17;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(3) && this.selectednums.Contains(5)
               && this.selectednums.Contains(7) && this.selectednums.Contains(9) && this.selectednums.Contains(12)
               && this.selectednums.Contains(14) && this.selectednums.Contains(16) && this.selectednums.Contains(18)
               && this.selectednums.Contains(19) && this.selectednums.Contains(21) && this.selectednums.Contains(23)
               && this.selectednums.Contains(25) && this.selectednums.Contains(27) && this.selectednums.Contains(30)
               && this.selectednums.Contains(32) && this.selectednums.Contains(34) && this.selectednums.Contains(36)

               || this.selectednums.Contains(2) && this.selectednums.Contains(4) && this.selectednums.Contains(6)
               && this.selectednums.Contains(8) && this.selectednums.Contains(10) && this.selectednums.Contains(11)
               && this.selectednums.Contains(13) && this.selectednums.Contains(15) && this.selectednums.Contains(17)
               && this.selectednums.Contains(20) && this.selectednums.Contains(22) && this.selectednums.Contains(24)
               && this.selectednums.Contains(26) && this.selectednums.Contains(28) && this.selectednums.Contains(29)
               && this.selectednums.Contains(31) && this.selectednums.Contains(33) && this.selectednums.Contains(35)
               )
            {
                transfer = 18;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2) && this.selectednums.Contains(3)
                   && this.selectednums.Contains(4) && this.selectednums.Contains(5) && this.selectednums.Contains(6)
                   && this.selectednums.Contains(7) && this.selectednums.Contains(8) && this.selectednums.Contains(9)
                   && this.selectednums.Contains(10) && this.selectednums.Contains(11) && this.selectednums.Contains(12)
                   && this.selectednums.Contains(13) && this.selectednums.Contains(14) && this.selectednums.Contains(15)
                   && this.selectednums.Contains(16) && this.selectednums.Contains(17) && this.selectednums.Contains(18)

                   || this.selectednums.Contains(19) && this.selectednums.Contains(20) && this.selectednums.Contains(21)
                   && this.selectednums.Contains(22) && this.selectednums.Contains(23) && this.selectednums.Contains(24)
                   && this.selectednums.Contains(25) && this.selectednums.Contains(26) && this.selectednums.Contains(27)
                   && this.selectednums.Contains(28) && this.selectednums.Contains(29) && this.selectednums.Contains(30)
                   && this.selectednums.Contains(31) && this.selectednums.Contains(32) && this.selectednums.Contains(33)
                   && this.selectednums.Contains(34) && this.selectednums.Contains(35) && this.selectednums.Contains(36)
                   )
            {
                transfer = 18;
            }

            else if (this.selectednums.Contains(1) && this.selectednums.Contains(4) && this.selectednums.Contains(7)
                && this.selectednums.Contains(10) && this.selectednums.Contains(13) && this.selectednums.Contains(16)
                && this.selectednums.Contains(19) && this.selectednums.Contains(22) && this.selectednums.Contains(25)
                && this.selectednums.Contains(28) && this.selectednums.Contains(31) && this.selectednums.Contains(34)

                || this.selectednums.Contains(2) && this.selectednums.Contains(5) && this.selectednums.Contains(8)
                && this.selectednums.Contains(11) && this.selectednums.Contains(14) && this.selectednums.Contains(17)
                && this.selectednums.Contains(20) && this.selectednums.Contains(23) && this.selectednums.Contains(26)
                && this.selectednums.Contains(29) && this.selectednums.Contains(32) && this.selectednums.Contains(35)

                || this.selectednums.Contains(3) && this.selectednums.Contains(6) && this.selectednums.Contains(9)
                && this.selectednums.Contains(12) && this.selectednums.Contains(15) && this.selectednums.Contains(18)
                && this.selectednums.Contains(21) && this.selectednums.Contains(24) && this.selectednums.Contains(27)
                && this.selectednums.Contains(30) && this.selectednums.Contains(33) && this.selectednums.Contains(36)
                )
            {
                transfer = 12;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2) && this.selectednums.Contains(3)
               && this.selectednums.Contains(4) && this.selectednums.Contains(5) && this.selectednums.Contains(6)
               && this.selectednums.Contains(7) && this.selectednums.Contains(8) && this.selectednums.Contains(9)
               && this.selectednums.Contains(10) && this.selectednums.Contains(11) && this.selectednums.Contains(12)

               || this.selectednums.Contains(13) && this.selectednums.Contains(14) && this.selectednums.Contains(15)
               && this.selectednums.Contains(16) && this.selectednums.Contains(17) && this.selectednums.Contains(18)
               && this.selectednums.Contains(19) && this.selectednums.Contains(20) && this.selectednums.Contains(21)
               && this.selectednums.Contains(22) && this.selectednums.Contains(23) && this.selectednums.Contains(24)

               || this.selectednums.Contains(25) && this.selectednums.Contains(26) && this.selectednums.Contains(27)
               && this.selectednums.Contains(28) && this.selectednums.Contains(29) && this.selectednums.Contains(30)
               && this.selectednums.Contains(31) && this.selectednums.Contains(32) && this.selectednums.Contains(33)
               && this.selectednums.Contains(34) && this.selectednums.Contains(35) && this.selectednums.Contains(36)
               )
            {
                transfer = 12;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2) && this.selectednums.Contains(3)
                && this.selectednums.Contains(4) && this.selectednums.Contains(5) && this.selectednums.Contains(6)

                || this.selectednums.Contains(4) && this.selectednums.Contains(5) && this.selectednums.Contains(6)
                && this.selectednums.Contains(7) && this.selectednums.Contains(8) && this.selectednums.Contains(9)

                || this.selectednums.Contains(7) && this.selectednums.Contains(8) && this.selectednums.Contains(9)
                && this.selectednums.Contains(10) && this.selectednums.Contains(11) && this.selectednums.Contains(12)

                || this.selectednums.Contains(10) && this.selectednums.Contains(11) && this.selectednums.Contains(12)
                && this.selectednums.Contains(13) && this.selectednums.Contains(14) && this.selectednums.Contains(15)

                || this.selectednums.Contains(13) && this.selectednums.Contains(14) && this.selectednums.Contains(15)
                && this.selectednums.Contains(16) && this.selectednums.Contains(17) && this.selectednums.Contains(18)

                || this.selectednums.Contains(16) && this.selectednums.Contains(17) && this.selectednums.Contains(18)
                && this.selectednums.Contains(19) && this.selectednums.Contains(20) && this.selectednums.Contains(21)

                || this.selectednums.Contains(19) && this.selectednums.Contains(20) && this.selectednums.Contains(21)
                && this.selectednums.Contains(22) && this.selectednums.Contains(23) && this.selectednums.Contains(24)

                || this.selectednums.Contains(22) && this.selectednums.Contains(23) && this.selectednums.Contains(24)
                && this.selectednums.Contains(25) && this.selectednums.Contains(26) && this.selectednums.Contains(27)

                || this.selectednums.Contains(25) && this.selectednums.Contains(26) && this.selectednums.Contains(27)
                && this.selectednums.Contains(28) && this.selectednums.Contains(29) && this.selectednums.Contains(30)

                || this.selectednums.Contains(28) && this.selectednums.Contains(29) && this.selectednums.Contains(30)
                && this.selectednums.Contains(31) && this.selectednums.Contains(32) && this.selectednums.Contains(33)

                || this.selectednums.Contains(31) && this.selectednums.Contains(32) && this.selectednums.Contains(33)
                && this.selectednums.Contains(34) && this.selectednums.Contains(35) && this.selectednums.Contains(36)
                )
            {
                transfer = 6;
            }

            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2)
                && this.selectednums.Contains(4) && this.selectednums.Contains(5)

                || this.selectednums.Contains(2) && this.selectednums.Contains(3)
                && this.selectednums.Contains(5) && this.selectednums.Contains(6)

                || this.selectednums.Contains(7) && this.selectednums.Contains(8)
                && this.selectednums.Contains(10) && this.selectednums.Contains(11)

                || this.selectednums.Contains(8) && this.selectednums.Contains(9)
                && this.selectednums.Contains(11) && this.selectednums.Contains(12)

                || this.selectednums.Contains(13) && this.selectednums.Contains(14)
                && this.selectednums.Contains(16) && this.selectednums.Contains(17)

                || this.selectednums.Contains(14) && this.selectednums.Contains(15)
                && this.selectednums.Contains(17) && this.selectednums.Contains(18)

                || this.selectednums.Contains(16) && this.selectednums.Contains(17)
                && this.selectednums.Contains(19) && this.selectednums.Contains(20)

                || this.selectednums.Contains(17) && this.selectednums.Contains(18)
                && this.selectednums.Contains(20) && this.selectednums.Contains(21)

                || this.selectednums.Contains(19) && this.selectednums.Contains(20)
                && this.selectednums.Contains(22) && this.selectednums.Contains(23)

                || this.selectednums.Contains(20) && this.selectednums.Contains(21)
                && this.selectednums.Contains(23) && this.selectednums.Contains(24)

                || this.selectednums.Contains(22) && this.selectednums.Contains(23)
                && this.selectednums.Contains(25) && this.selectednums.Contains(26)

                || this.selectednums.Contains(23) && this.selectednums.Contains(24)
                && this.selectednums.Contains(26) && this.selectednums.Contains(27)

                || this.selectednums.Contains(25) && this.selectednums.Contains(26)
                && this.selectednums.Contains(28) && this.selectednums.Contains(29)

                || this.selectednums.Contains(26) && this.selectednums.Contains(27)
                && this.selectednums.Contains(29) && this.selectednums.Contains(30)

                || this.selectednums.Contains(28) && this.selectednums.Contains(29)
                && this.selectednums.Contains(31) && this.selectednums.Contains(32)

                || this.selectednums.Contains(29) && this.selectednums.Contains(30)
                && this.selectednums.Contains(32) && this.selectednums.Contains(33)

                || this.selectednums.Contains(31) && this.selectednums.Contains(32)
                && this.selectednums.Contains(34) && this.selectednums.Contains(35)

                || this.selectednums.Contains(32) && this.selectednums.Contains(33)
                && this.selectednums.Contains(35) && this.selectednums.Contains(36)
                )
            {
                transfer = 4;
            }
            else if (this.selectednums.Contains(38) && this.selectednums.Contains(1) && this.selectednums.Contains(2) && receive == 0
                || this.selectednums.Contains(38) && this.selectednums.Contains(1) && this.selectednums.Contains(2) && receive == 1
                || this.selectednums.Contains(38) && this.selectednums.Contains(1) && this.selectednums.Contains(2) && receive == 2
                || this.selectednums.Contains(38) && this.selectednums.Contains(2) && this.selectednums.Contains(3) && receive == 38
                || this.selectednums.Contains(38) && this.selectednums.Contains(2) && this.selectednums.Contains(3) && receive == 2
                || this.selectednums.Contains(38) && this.selectednums.Contains(2) && this.selectednums.Contains(3) && receive == 3)
            {

                transfer = 3;
            }

            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2) && this.selectednums.Contains(3)
                || this.selectednums.Contains(4) && this.selectednums.Contains(5) && this.selectednums.Contains(6)
                || this.selectednums.Contains(7) && this.selectednums.Contains(8) && this.selectednums.Contains(9)
                || this.selectednums.Contains(10) && this.selectednums.Contains(11) && this.selectednums.Contains(12)
                || this.selectednums.Contains(13) && this.selectednums.Contains(14) && this.selectednums.Contains(15)
                || this.selectednums.Contains(16) && this.selectednums.Contains(17) && this.selectednums.Contains(18)
                || this.selectednums.Contains(19) && this.selectednums.Contains(20) && this.selectednums.Contains(21)
                || this.selectednums.Contains(22) && this.selectednums.Contains(23) && this.selectednums.Contains(24)
                || this.selectednums.Contains(25) && this.selectednums.Contains(26) && this.selectednums.Contains(27)
                || this.selectednums.Contains(28) && this.selectednums.Contains(29) && this.selectednums.Contains(30)
                || this.selectednums.Contains(31) && this.selectednums.Contains(32) && this.selectednums.Contains(33)
                || this.selectednums.Contains(34) && this.selectednums.Contains(35) && this.selectednums.Contains(36)
                )
            {
                transfer = 3;
            }
            else if (this.selectednums.Contains(1) && this.selectednums.Contains(2)
                 || this.selectednums.Contains(1) && this.selectednums.Contains(4)
                 || this.selectednums.Contains(2) && this.selectednums.Contains(5)
                 || this.selectednums.Contains(2) && this.selectednums.Contains(3)
                 || this.selectednums.Contains(3) && this.selectednums.Contains(6)
                 || this.selectednums.Contains(4) && this.selectednums.Contains(7)
                 || this.selectednums.Contains(4) && this.selectednums.Contains(5)
                 || this.selectednums.Contains(5) && this.selectednums.Contains(8)
                 || this.selectednums.Contains(5) && this.selectednums.Contains(6)
                 || this.selectednums.Contains(6) && this.selectednums.Contains(9)
                 || this.selectednums.Contains(7) && this.selectednums.Contains(10)
                 || this.selectednums.Contains(7) && this.selectednums.Contains(8)
                 || this.selectednums.Contains(8) && this.selectednums.Contains(11)
                 || this.selectednums.Contains(8) && this.selectednums.Contains(9)
                 || this.selectednums.Contains(9) && this.selectednums.Contains(12)
                 || this.selectednums.Contains(10) && this.selectednums.Contains(13)
                 || this.selectednums.Contains(10) && this.selectednums.Contains(11)
                 || this.selectednums.Contains(11) && this.selectednums.Contains(12)
                 || this.selectednums.Contains(11) && this.selectednums.Contains(14)
                 || this.selectednums.Contains(12) && this.selectednums.Contains(15)
                 || this.selectednums.Contains(13) && this.selectednums.Contains(14)
                 || this.selectednums.Contains(13) && this.selectednums.Contains(16)
                 || this.selectednums.Contains(14) && this.selectednums.Contains(15)
                 || this.selectednums.Contains(14) && this.selectednums.Contains(17)
                 || this.selectednums.Contains(15) && this.selectednums.Contains(18)
                 || this.selectednums.Contains(16) && this.selectednums.Contains(19)
                 || this.selectednums.Contains(16) && this.selectednums.Contains(17)
                 || this.selectednums.Contains(17) && this.selectednums.Contains(20)
                 || this.selectednums.Contains(17) && this.selectednums.Contains(18)
                 || this.selectednums.Contains(18) && this.selectednums.Contains(21)
                 || this.selectednums.Contains(19) && this.selectednums.Contains(22)
                 || this.selectednums.Contains(19) && this.selectednums.Contains(20)
                 || this.selectednums.Contains(20) && this.selectednums.Contains(23)
                 || this.selectednums.Contains(20) && this.selectednums.Contains(21)
                 || this.selectednums.Contains(21) && this.selectednums.Contains(24)
                 || this.selectednums.Contains(22) && this.selectednums.Contains(25)
                 || this.selectednums.Contains(22) && this.selectednums.Contains(23)
                 || this.selectednums.Contains(23) && this.selectednums.Contains(26)
                 || this.selectednums.Contains(23) && this.selectednums.Contains(24)
                 || this.selectednums.Contains(24) && this.selectednums.Contains(27)
                 || this.selectednums.Contains(25) && this.selectednums.Contains(28)
                 || this.selectednums.Contains(25) && this.selectednums.Contains(26)
                 || this.selectednums.Contains(26) && this.selectednums.Contains(29)
                 || this.selectednums.Contains(26) && this.selectednums.Contains(27)
                 || this.selectednums.Contains(27) && this.selectednums.Contains(30)
                 || this.selectednums.Contains(28) && this.selectednums.Contains(31)
                 || this.selectednums.Contains(28) && this.selectednums.Contains(29)
                 || this.selectednums.Contains(29) && this.selectednums.Contains(32)
                 || this.selectednums.Contains(29) && this.selectednums.Contains(30)
                 || this.selectednums.Contains(30) && this.selectednums.Contains(33)
                 || this.selectednums.Contains(31) && this.selectednums.Contains(34)
                 || this.selectednums.Contains(31) && this.selectednums.Contains(32)
                 || this.selectednums.Contains(32) && this.selectednums.Contains(35)
                 || this.selectednums.Contains(32) && this.selectednums.Contains(33)
                 || this.selectednums.Contains(33) && this.selectednums.Contains(36)
                 || this.selectednums.Contains(34) && this.selectednums.Contains(35)
                 || this.selectednums.Contains(35) && this.selectednums.Contains(36)

                )
            {
                transfer = 2;
            }
            else if (this.selectednums.Contains(receive))
            {

                transfer = 1;
            }
            
            return transfer;

        }

    */
    }
}
