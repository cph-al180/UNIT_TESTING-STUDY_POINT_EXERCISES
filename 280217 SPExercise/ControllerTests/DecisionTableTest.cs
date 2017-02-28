using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controllers;

namespace ControllerTests
{
    [TestClass]
    public class DecisionTableTest
    {
        DecisionTableController dtController = new DecisionTableController();

        [TestMethod]
        public void ConditionTests()
        {
            var doctor = TypeOfVisit.Doctor;
            var hospital = TypeOfVisit.Hospital;
            Assert.AreEqual(0.5f, dtController.GetReimburse(true, doctor));
            Assert.AreEqual(0f, dtController.GetReimburse(false, doctor));
            Assert.AreEqual(0.8f, dtController.GetReimburse(true, hospital));
            Assert.AreEqual(0f, dtController.GetReimburse(false, hospital));
        }
    }
}
