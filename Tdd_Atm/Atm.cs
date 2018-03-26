using System;
using System.Collections.Generic;
using System.Text;

namespace Tdd_Atm
{
    public class Atm
    {
        public AuthenticationResult AuthenticateViaCardAndPin(string cardNumber, string pin)
        {
            var cardAuthenticator = new CardAuthenticator();

            var authenticationResult = cardAuthenticator.ValidateCardAndPin(cardNumber, pin);

            return authenticationResult;
        }
    }
}
