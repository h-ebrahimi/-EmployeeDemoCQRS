using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Employee.Common.Test
{
    [TestClass]
    public class DateTimeExtensionsUnitTest
    {
        private readonly DateTime _myBirthDay;
        private readonly string _myPersianBirthDay;
        private readonly long _myLongBirthDay;

        public DateTimeExtensionsUnitTest()
        {
            _myBirthDay = new(1986, 9, 15, 17, 10, 50, 456, DateTimeKind.Utc);
            _myPersianBirthDay = "1365/06/24";
            _myLongBirthDay = 527188250456;
        }

        [TestMethod]
        public void ToMilliseconds_Test_Must_True()
        {
            // Arrange

            // Act
            var longDate = _myBirthDay.ToMilliseconds();

            // Assert
            Assert.AreEqual(longDate, _myLongBirthDay);
        }

        [TestMethod]
        public void ToMilliseconds_Test_Must_Wrong()
        {
            // Arrange
            var miliseconds = 527188250560;

            // Act
            var longDate = _myBirthDay.ToMilliseconds();

            // Assert
            Assert.AreNotEqual(longDate, miliseconds);
        }

        [TestMethod]
        public void ToPersainDate_Test_Must_True()
        {
            // Arrange            

            // Act
            var methodResponse = _myBirthDay.ToPersianDate();

            // Assert
            Assert.AreEqual(methodResponse, _myPersianBirthDay);
        }

        [TestMethod]
        public void ToPersainDate_Test_Must_Wrong()
        {
            // Arrange            
            var wrongPersianBirthDay = "1385/09/15";
            // Act
            var methodResponse = _myBirthDay.ToPersianDate();

            // Assert
            Assert.AreNotEqual(methodResponse, wrongPersianBirthDay);
        }
    }
}
