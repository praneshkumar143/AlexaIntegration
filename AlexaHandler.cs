using Newtonsoft.Json;
using RareCrew.Integration.Alexa;
using RareCrew.Integration.Alexa.BusinessObjects;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RareCrew.Integration.Aexa
{
    public class AlexaHandler
    {
        public AlexaHandler(AlexaCredentials alexaCredentials)
        {
           _credential = alexaCredentials;
        }

        public AlexaCredentials _credential { get; private set; }
        public object Request { get; private set; }

        public async Task<string> GetRank(string URL)
        {
                     string _AlexaData = string.Empty;
            using (HttpClient _httpclient = new HttpClient())
            {
               
                var baseURL = "https://awis.api.alexa.com/api";
                var parameters = $"?Action=UrlInfo&ResponseGroup=Rank&Url={URL}&Output=json";
                _httpclient.DefaultRequestHeaders.Add("x-api-key", _credential.AccessToken);
                using (HttpResponseMessage httpResponse = await _httpclient.GetAsync($"{baseURL}{parameters}"))

                {
                    using (HttpContent content = httpResponse.Content)
                    {
                        _AlexaData = await content.ReadAsStringAsync();
                    }
                }
            }
            var response = JsonConvert.DeserializeObject<AlexaResponse>(_AlexaData);
            return response.Awis.Results.Result.Alexa.TrafficData.Rank;

        }

       

      }
}