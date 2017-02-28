using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controllers;

namespace ControllerTests
{
    [TestClass]
    public class DaysInMonthControllerTest
    {
        DaysInMonthController dimController = new DaysInMonthController();
        int expectedDays;

        [TestMethod]
        public void MonthsWith31DaysTest()
        {
            expectedDays = 31;
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(1, 2017));
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(3, 2017));
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(5, 2017));
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(7, 2017));
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(8, 2017));
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(10, 2017));
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(12, 2017));
        }

        [TestMethod]
        public void MonthsWith30DaysTest()
        {
            expectedDays = 30;
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(4, 2017));
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(6, 2017));
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(9, 2017));
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(11, 2017));
        }

        [TestMethod]
        public void MonthsWith28DaysTest()
        {
            expectedDays = 28;
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(2, 2017));
        }

        [TestMethod]
        public void MonthsWith29DaysTest()
        {
            expectedDays = 29;
            Assert.AreEqual(expectedDays, dimController.GetNumberOfDaysInMonth(2, 2000));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Invalid month")]
        public void InvalidMonthTest()
        {
            dimController.GetNumberOfDaysInMonth(0, 2017);
            dimController.GetNumberOfDaysInMonth(20, 2017);
        }

        [TestMethod]
        public void LeapYearTest()
        {
            Assert.AreEqual(28, dimController.GetNumberOfDaysInMonth(2, 2017));
            Assert.AreEqual(29, dimController.GetNumberOfDaysInMonth(2, 2000));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Invalid year")]
        public void InvalidYearTest()
        {
            dimController.GetNumberOfDaysInMonth(2, -1);
            dimController.GetNumberOfDaysInMonth(2, int.MaxValue);
        }

        [TestMethod]
        public void YearAndMonthTest()
        {
            int nonLeapYear = 2017;
            int leapYear = 2000;
            Assert.AreEqual(31, dimController.GetNumberOfDaysInMonth(1, nonLeapYear));
            Assert.AreEqual(31, dimController.GetNumberOfDaysInMonth(1, leapYear));
            Assert.AreEqual(30, dimController.GetNumberOfDaysInMonth(4, nonLeapYear));
            Assert.AreEqual(30, dimController.GetNumberOfDaysInMonth(4, leapYear));
            Assert.AreEqual(28, dimController.GetNumberOfDaysInMonth(2, nonLeapYear));
            Assert.AreEqual(29, dimController.GetNumberOfDaysInMonth(2, leapYear));
        }

        [TestMethod]
        public void BoundaryLeapYearValuesTest()
        {
            Assert.AreEqual(true, dimController.IsLeapYear(4));
            Assert.AreEqual(false, dimController.IsLeapYear(5));
            Assert.AreEqual(false, dimController.IsLeapYear(100));
            Assert.AreEqual(false, dimController.IsLeapYear(200));
            Assert.AreEqual(false, dimController.IsLeapYear(300));
            Assert.AreEqual(true, dimController.IsLeapYear(400));
            Assert.AreEqual(false, dimController.IsLeapYear(500));
        } 

        [TestMethod]
        [ExpectedException(typeof(Exception), "Invalid month")]
        public void InvalidMonthBoundaryValuesTest()
        {
            dimController.GetNumberOfDaysInMonth(-1, 2017);
            dimController.GetNumberOfDaysInMonth(0, 2017);
            dimController.GetNumberOfDaysInMonth(13, 2017);
            dimController.GetNumberOfDaysInMonth(14, 2017);
        }

    }
}
