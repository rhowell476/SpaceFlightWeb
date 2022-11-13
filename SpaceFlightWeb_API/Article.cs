using System.Text.Json.Serialization;

namespace SpaceFlightWeb_API
{
    public class Article
    {
        public string title { get; set; }
        public string url { get; set; }
        public string imageUrl { get; set; }
        public string summary { get; set; }
        public DateTime publishedAt { get; set; }
        public Boolean featured { get; set; }

        public IList<Launch>? launches { get; set; }
    }

    public class Launch
    {
        public string? id { get; set; }
        public string? provider { get; set; }
    }
}