using System;
using Delegate;
using Lambda_Expression;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private People _people;
        private Mock<ICreditDecisionService> mockCreditDecisionService;

        [SetUp]
        public void SetUp()
        {
            _people = new People();
        }
        [TestCase(100, "Declined")]
        [TestCase(549, "Declined")]
        [TestCase(-550, "Maybe")]
        [TestCase(674, "Maybe")]
        [TestCase(675, "We look forward to doing business with you!")]

        public void MakeCreditDecision_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
        {
            mockCreditDecisionService = new Mock<ICreditDecisionService>(MockBehavior.Strict);
            mockCreditDecisionService.Setup(p => p.GetDecision(creditScore)).Returns(expectedResult);
            var result = _people.MakeCreditDecision(creditScore);
            NUnit.Framework.Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
