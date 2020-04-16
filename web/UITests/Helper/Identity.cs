using Microsoft.Identity.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace UITests.Helper
{
    class Identity
    {
        private string _tenantID;
        private string _clientId;
        private string _clientSecret;

        public Identity(string TenantId, string ClientId, string ClientSecret)
        {
            _tenantID = TenantId;
            _clientId = ClientId;
            _clientSecret = ClientSecret;
        }

        public async Task<AuthenticationResult> GetToken()
        {
            var app = ConfidentialClientApplicationBuilder.Create(_clientId)
               .WithAuthority(AzureCloudInstance.AzurePublic, _tenantID)
               .WithClientSecret(_clientSecret)
               .Build();

            string[] scopes = new string[] { "api://f59f5a37-6bc1-43cb-a871-0feca60368fc" };

            AuthenticationResult result = null;
            try
            {
                result = await app.AcquireTokenForClient(scopes)
                                  .ExecuteAsync();
                return result;
            }
            catch (MsalServiceException ex)
            {
                Assert.ThrowsException<InvalidCredentialException>(() => ex.Message.ToString());
                return null;
            }
        }
    }
}
