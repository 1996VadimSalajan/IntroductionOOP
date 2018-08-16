using System;
using System.Collections.Generic;
using ConsoleApp1;
using Delegate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using People;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        private People.People _people;
        private Mock<IPerson> _mockCreditDecisionService;
        private Mock<ICoinRelease> _mockCoinRelease;
        private ChangeReturner _returner;

        [SetUp]
        public void SetUp()
        {
            _people = new People.People();
            _mockCreditDecisionService = new Mock<IPerson>();
            _mockCoinRelease = new Mock<ICoinRelease>();
            _returner = new ChangeReturner(_mockCoinRelease.Object);
        }
        [TestCase(100, "Declined")]
        [TestCase(549, "Declined")]
        [TestCase(550, "Maybe")]
        [TestCase(674, "Maybe")]
        [TestCase(675, "We look forward to doing business with you!")]
        public void MakeCreditDecision_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
        {
            var result = _people.MakeCreditDecision(creditScore);
            NUnit.Framework.Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void ItShouldCrediteDecision()
        {    
            _mockCreditDecisionService.Setup(p => p.MakeCreditDecision(It.IsAny<int>()));
            _mockCreditDecisionService.Verify((p => p.MakeCreditDecision(655)),Times.Exactly(1));
        }
        [Test]
        public void ExpectedGetName()
        {
           //Arange
            string firstName ="Narasimha";
            string lastName ="Reddy";
            string expected ="Narasimha Reddys";
            string actual;
            //Act  
            actual =_people.GetName(firstName, lastName);
            //Assert  
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
        static object[] getTime =
        {
              new object[]{DateTime.Now,"Morning"},
               new object[]{DateTime.Now,"Night"},
                new object[]{DateTime.Now,"Afternoon"}
        };
        [Test,TestCaseSource("getTime")]
        public void GetTimeOfDays_ExpectedResult(DateTime date,string expectedResult)
        {
            var result = _people.GetTimeOfDay(date);
            NUnit.Framework.Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void WhenReturningOnePenny()
        {
            _returner.GiveChange(1);
            _mockCoinRelease.Verify(m => m.Release(1), Times.Once());
        }
    }
}
