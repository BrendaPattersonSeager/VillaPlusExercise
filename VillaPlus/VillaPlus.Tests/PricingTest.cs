using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillaPlus.Tests
{
    [TestFixture]
    class PricingTest
    {
        [Test]
        public void CalculateDiscount([Values (3)] int itemPrice, [Values (6) ] int total, [Values (3)] int discountCounter)
        {

            int discountTotal = 0;
            bool discountApplied = false;

            total = total + itemPrice;


            if (discountCounter == 3)
            {
                discountTotal = total - itemPrice;
                Assert.Less(discountTotal, total);
                total = discountTotal;
                discountApplied = true;
                discountCounter = 0;

                
            }


        }



        [Test]
        public void Discount()
        {
            //Arrange
            int discountPercent = 30;
            decimal totalPrice = 20;
            decimal percentagePrice = totalPrice / 100;
            decimal discountPrice = percentagePrice * discountPercent;
            decimal discountApplied;

            //Act
            discountApplied = totalPrice - discountPrice;

            //Assert
            Assert.Less(discountApplied,totalPrice);
        }

        [Test]
        public void TwoforOne()
        {

            //Arrange
            decimal itemPrice = 2.33m;
            decimal totalPrice = 20;
            decimal twoForOneDiscount;


            //Act
            twoForOneDiscount = totalPrice - itemPrice;

            //Assert
            Assert.Less(twoForOneDiscount,totalPrice);


        }
    }
}
