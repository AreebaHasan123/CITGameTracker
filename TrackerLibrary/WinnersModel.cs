using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class WinnersModel
    {
        public int ID { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }

        
        public decimal PrizeAmount{ get; set; }

        public double PrizePercentage { get; set; }

        public WinnersModel() { }

        public WinnersModel( string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);

            PrizePercentage = prizePercentageValue;

        }

        public static string declareWinner(int ID)
        {
            if (ID == 0)
            {
                string errorSent="You are admin. You cannot win.";
                return errorSent;
            }
            else
            {
                
                string correctSent=$"The winner is ID Number: {ID}";
                return correctSent;
            }
        }


        public static string correctPrizeAmount(decimal PrizeAmount)
        {
            if (PrizeAmount>10000 || PrizeAmount<0)
            {
                string errorSent = "This prize amount is not valid";
                return errorSent;
            }
            else
            {

                string correctSent = $"The prize amount is {PrizeAmount}";
                return correctSent;
            }
        }




    }
}
