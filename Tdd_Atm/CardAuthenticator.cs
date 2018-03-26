using System;

namespace Tdd_Atm
{
    public class CardAuthenticator
    {
       
        public AuthenticationResult ValidateCardAndPin(string cardNumber, string pin)
        {
            if (string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(pin))
                return new AuthenticationResult
                {
                    Success = false,
                    Message = "Card number or pin are empty."
                };

            throw new NotImplementedException();
        }
    }
}