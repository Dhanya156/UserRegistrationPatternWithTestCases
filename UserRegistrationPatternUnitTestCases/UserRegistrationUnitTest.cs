using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationPattern;

namespace UserRegistrationPatternUnitTest
{
    /// Creating a class for unit test methods
    [TestClass]
    public class UserRegistrationUnitTest
    {
        /// Creating a private variable validation
        private Validation validation;

        /// <summary>Initializes a new instance of the <see cref="UserRegistrationUnitTest" /> class.</summary>
        public UserRegistrationUnitTest()
        {
            ///Creating a object for UserRegistrationPattern class
            validation = new UserRegistrationPattern.Validation();
        }
        /// <summary>Tests the name with first letter capital test assertion.</summary>
        [TestMethod]
        public void TestNameWithFirstLetterCapital_testAssertion()
        {
            //Creating a boolen variable result and calling a method ValidateName
            Boolean result = Validation.ValidateName("Dhanvi");
            ///Check whether the condition is true and throws an exception if condition is false
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestNameWithoutFirstLetterCapital_testAssertion()
        {
            ///Creating a boolen variable result and calling a method ValidateName
            Boolean result = Validation.ValidateName("dhanvi");
            Assert.IsTrue(result);
        }
        [TestMethod]
        /// <summary>Tests the email with three mandatory feilds test assertion.</summary>
        public void TestEmailWithThreeMandatoryFeilds_testAssertion()
        {
            //Creating a boolen variable result and calling a method ValidateEmail
            Boolean result = Validation.ValidateEmail("dhanya@gmail.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestEmailWithoutThreeMandatoryFeilds_testAssertion()
        {
            //Creating a boolen variable result and calling a method ValidateEmail
            Boolean result = Validation.ValidateEmail("dhanya.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPhoneNumberWithExactlyTenDigit_testAssertion(string phoneNumber)
        {
            //Creating a boolen variable result and calling a method ValidatePhoneNumber
            Boolean result = Validation.ValidatePhoneNumber("9108937310");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPhoneNumberNotExactlyTenDigit_testAssertion()
        {
            //Creating a boolen variable result and calling a method ValidatePhoneNumber
            Boolean result = Validation.ValidatePhoneNumber("987297");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPasswordWithAllTheRules_testAssertion()
        {
            //Creating a boolen variable result and calling a method ValidatePassword
            Boolean result = Validation.ValidatePhoneNumber("Dhanu#2");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPasswordWithoutAnyTheRules_testAssertion()
        {
            //Creating a boolen variable result and calling a method ValidatePassword
            Boolean result = Validation.ValidatePhoneNumber("hgfjyhd");
            Assert.IsTrue(result);
        }
    }
}
