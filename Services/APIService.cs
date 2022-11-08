using evalucion_bayteq.Models;
using evalucion_bayteq.Services.Interfaces;
using Newtonsoft.Json;

namespace evalucion_bayteq.Services
{
    public class APIService : IAPIService
    {
        private static HttpClient _httpClient;
        public async Task<List<PetModel>> GetDataPets()
        {
            List<PetModel>? result = new List<PetModel>();
            _httpClient = new HttpClient();
            string url = "http://petstore.swagger.io/v2/pet/findByStatus?status=available";

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                using (HttpResponseMessage response = await _httpClient.SendAsync(request))
                {
                    using (HttpContent content = response.Content)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string _response = await content.ReadAsStringAsync();
                            var data = JsonConvert.DeserializeObject<List<PetModel>>(_response);
                            return result = data;
                        }
                        else
                        {
                            return result;
                        }

                    }
                }
            }
        }
    }
}