using NUnit.Framework;
using RareCrew.Integration.Aexa;
using RareCrew.Integration.Alexa;
using RareCrew.Integration.Alexa.BusinessObjects;
using RareCrew.Integration.GlobalRank;
using System;
using System.Security.Policy;
using System.Threading.Tasks;


namespace RareCrew.Integration.UnitTesting.Integration
{
    [TestFixture]
    public class AlexaHandlerUt
    { 
         private readonly AlexaCredentials Alexacredentials = new AlexaCredentials("Wt3d9Owbxx5i3cG8IRfnc10GY67W4x5854lqBLWJ");
       
       
        [Test]
        public async Task TestGetAlexaRank()
    {
        var Alexahandler = new AlexaHandler(Alexacredentials);

            var response = await Alexahandler.GetRank("rarecrew.com");
            Assert.IsNotNull(response);
        }
  }
}


