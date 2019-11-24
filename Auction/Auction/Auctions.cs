//Blaine Smith
//11-23-2019
//Bellevue University
//Assignment 5.2
//This program allows a user to enter in a bid amount and the program will 
//determine if the bid amount is in the correct format and is high enough.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Auction
{
    class Auctions
    {
        static void Main(string[] args)
        {
            string bids;
            int intBids;
            double doubleBids;
            const int MINBID = 10;

            Write("Please enter in your bid amount:  ");
            bids = ReadLine();

            if (int.TryParse(bids, out intBids))
            {
                AcceptingBid(intBids, MINBID);
            }
            else if (double.TryParse(bids, out doubleBids))
            {
                AcceptingBid(doubleBids, MINBID);
            }
            else
            {
                AcceptingBid(bids, MINBID);
            }

        }

        public static void AcceptingBid(int bid, int min)
        {
            if (bid >= min)
            {
                Write("Your bid of {0} has been accepted.", bid);
            }
            else
            {
                Write("Your bid of {0} was not high enough.", bid);
            }
        }

        public static void AcceptingBid(double bid, int min)
        {
            if (bid >= min)
            {
                Write("Your bid of {0} has been accepted.", bid);
            }
            else
            {
                Write("Your bid of {0} was not high enough.", bid);
            }
        }

        public static void AcceptingBid(string bid, int min)
        {
            double subDouble;
            string dollars = " dollars";

            if (bid.Substring(0,1).Equals("$"))
            {
                if (double.TryParse(bid.Substring(1, bid.Length - 1), out subDouble))
                {
                    AcceptingBid(subDouble, min);
                }
                else
                {
                    Write("Your bid was not in the correct format.");
                }
            }
            else
            {
                if (bid.Substring(bid.Length - dollars.Length, dollars.Length). Equals(dollars))
                {
                    if (double.TryParse(bid.Substring(0, bid.Length - 8), out subDouble))
                    {
                        AcceptingBid(subDouble, min);
                    }
                    else
                    {
                        Write("Your bid was not in the correct format.");
                    }
                }
                else
                {
                    Write("Your bid was not in the correct format.");
                }
            }
        }
    }
}
