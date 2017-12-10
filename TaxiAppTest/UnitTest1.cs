using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TaxiAPPLI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Order_PriceParameterLessThanNull()
        {
            const string phone = "0634340324";
            const string from = "Volodimoira Velykoho";
            const string to = "Prospect Shevchenka";
            const string type = "Buisness";
            const double price = -10.1;
            var unused = new Order(phone, from, to , price, type);
        }

        [TestMethod]
        public void ToString_ValidString()
        {
            var order = new Order("06", "sdfsf", "dsfds", 20,"dsfds" );
            const string expected = "06 sdfsf dsfds dsfds 20";
            var stringToCheck = order.ToString();

            Assert.IsTrue(stringToCheck == expected);
        }

        [TestMethod]
        public void PhoneNumber_Check()
        {
            string number1 = "0634340324";
            string number2 = "063434";
            string number3 = "sadsa";
            Assert.IsTrue(BuisnessLogic.checkPhoneNumber(number1));
            Assert.IsFalse(BuisnessLogic.checkPhoneNumber(number2));
            Assert.IsFalse(BuisnessLogic.checkPhoneNumber(number3));
        }
    }
    }
