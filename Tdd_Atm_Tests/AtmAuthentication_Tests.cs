using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tdd_Atm;

namespace Tdd_Atm_Tests
{
    [TestClass]
    public class AtmAuthentication_Tests
    {
        [TestMethod]
        public void TestEmptyAccountNumber_EmptyPin_AuthorizationFails()
        {
            var cardNumber = "";
            var pin = "";

            Atm atm = new Atm();

            var authenticationResult = atm.AuthenticateViaCardAndPin(cardNumber, pin);

            Assert.IsFalse(authenticationResult.Success);
            Assert.AreEqual(authenticationResult.Message, "Card number or pin are empty.");
        }

        [TestMethod]
        public void TestNonEmptyAccountNumber_EmptyPin_AuthorizationFails()
        {
            var cardNumber = "4111-1111-1111-1111".Replace("-", "");
            var pin = "";

            Atm atm = new Atm();

            var authenticationResult = atm.AuthenticateViaCardAndPin(cardNumber, pin);

            Assert.IsFalse(authenticationResult.Success);
            Assert.AreEqual(authenticationResult.Message, "Card number or pin are empty.");
        }

        
    }
      
}