using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace deezer
{
    internal class Client
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<List<Models.Artist>> SearchArtistAsync(string query)
        {
            string url = $"https://api.deezer.com/search/artist?q={query}&limit=30";

            var response = await _httpClient.GetAsync(url);
            string json = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Models.DeezerResponse>(json);
            return result?.Data ?? new List<Models.Artist>();
        }
    }
}
