using CityOfFrance.Api.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CityOfFrance.Model
{
    public class Location : ILocation
    {
        [JsonProperty("nom")]
        public string Nom { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("codeDepartement")]
        public string CodeDepartement { get; set; }

        [JsonProperty("codeRegion")]
        public string CodeRegion { get; set; }

        [JsonProperty("codesPostaux")]
        public List<string> CodesPostaux { get; set; } = new List<string>();

        [JsonProperty("population")]
        public int Population { get; set; }
    }

}
