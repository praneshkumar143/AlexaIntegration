using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace RareCrew.Integration.Alexa
{
    public class AlexaCredentials
    {
        internal object AlexaToken;

        //private SecureString ClientSecret { get; }


        internal string AccessToken { get; set; }


        public AlexaCredentials(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentNullException(nameof(token));

            AccessToken = token;
            
            
        }

        
    }
}
