using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3_Code;

namespace UnitTestFakeAppUserRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {

            const string UserName = "DaveBish";
            const string PassWord = "iLoveSoftware";
            FakeAppUserRepository USRepository = new FakeAppUserRepository();

            // Act
            bool result = USRepository.Login(UserName,PassWord);

            // Assert
            Assert.IsTrue(result);
        }
        public void LoginWithIncorrectCredentialsFail()
        {
            // Arrange
            const string UserName = "test";
            const string PassWord = "fail";
            FakeAppUserRepository USRepository = new FakeAppUserRepository();

            // Act
            bool result = USRepository.Login(UserName, PassWord);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
