using Xunit;
using Exercise2;

namespace Exercise2.test
{
    public class Exercise2Tests
    {
        [Fact]
        public void GetTicketPrice_Test()
        {
            //Arrange
            int age1 = 15;
            int age2 = 30;
            int age3 = 70;
            int age4 = 150;

            //Act
            int juniorPrice = Helper.GetTicketPrice(age1);
            int standardPrice = Helper.GetTicketPrice(age2);
            int seniorPrice = Helper.GetTicketPrice(age3);
            int FreePrice = Helper.GetTicketPrice(age4);

            //Assert
            Assert.Equal(80, juniorPrice);
            Assert.Equal(120, standardPrice);
            Assert.Equal(90, seniorPrice);
            Assert.Equal(0, FreePrice);

        }

        [Fact]
        public void GetTicketName_Test()
        {
            int age1 = 15;
            int age2 = 30;
            int age3 = 70;
            int age4 = 150;

            string juniorTicketName = Helper.GetTicketName(age1);
            string standardTicketName = Helper.GetTicketName(age2);
            string seniorTicketName = Helper.GetTicketName(age3);
            string FreeTicketName = Helper.GetTicketName(age4); 

            Assert.Equal("Undomspris", juniorTicketName);
            Assert.Equal("Standardpris", standardTicketName);
            Assert.Equal("Pensionärspris", seniorTicketName);
            Assert.Equal("Gratis", FreeTicketName);
        }
    }
}