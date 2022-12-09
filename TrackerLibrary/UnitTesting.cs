using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace TrackerLibrary
{
    public class UnitTesting
    {
        [Fact]
        public void testIfWinnerCanBeDeclared()
        {
            //Arrange

            string expected = "You are admin. You cannot win.";

            //Act
            int givenID = 4;
            string actual=WinnersModel.declareWinner(givenID);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void testIfPrizeAmountValid()
        {
            //Arrange

            string expected = "This prize amount is not valid";

            //Act
            decimal givenPrize = 10001;
            string actual = WinnersModel.correctPrizeAmount(givenPrize);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
