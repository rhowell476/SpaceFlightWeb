using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpaceFlightWeb.Models
{
    public class APODService
    {
        [JsonPropertyName("title")]
        public string apodtitle { get; set; }
        public string date { get; set; }
        [JsonPropertyName("url")]
        public string hdurl { get; set; }
        public string explanation { get; set; }
        [JsonPropertyName("media_type")]
        public string media { get; set; }
    }
}
