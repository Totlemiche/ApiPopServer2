using CityOfFrance.Api.Model;
using CityOfFrance.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CityOfFrance.Api
{
    public class CitiesService : ICitiesService
    {
        private const string _URL = "https://geo.api.gouv.fr/communes?codePostal={0}";

        private string _postalCode;

        public string UrlToContact => string.Format(_URL, _postalCode);

        private readonly HttpClient _httpClient;

        public CitiesService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<ILocation>> GetLocationsAsync(string postalCode)
        {
            _postalCode = postalCode;
            List<Location> locations;
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(UrlToContact)
            };

            using (var response = await _httpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();
                locations = JsonConvert.DeserializeObject<List<Location>>(body);
            }

            return locations.Cast<ILocation>().ToList();
        }
    }
}
