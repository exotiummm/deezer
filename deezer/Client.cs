using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace deezer
{
    internal class Client
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<string> SearchArtistAsync(string query)
        {
            string url = $"https://api.deezer.com/search/artist?q={query}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
