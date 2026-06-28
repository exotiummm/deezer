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

            var result = JsonConvert.DeserializeObject<Models.DeezerArtistResponse>(json);
            return result?.Data ?? new List<Models.Artist>();
        }

        public async Task<List<Models.Album>> SearchAlbumAsync(string query)
        {
            string url = $"https://api.deezer.com/search/album?q={query}&limit=30";

            var response = await _httpClient.GetAsync(url);
            string json = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Models.DeezerAlbumResponse>(json);
            return result?.Data ?? new List<Models.Album>();
        }

        public async Task<List<Models.Track>> SearchTrackAsync(string query)
        {
            string url = $"https://api.deezer.com/search/track?q={query}&limit=30";

            var response = await _httpClient.GetAsync(url);
            string json = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Models.DeezerTrackResponse>(json);
            return result?.Data ?? new List<Models.Track>();
        }
    }
}
