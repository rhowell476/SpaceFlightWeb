using System.Text.Json;

namespace SpaceFlightWeb_API.Services
{
    public class JsonFileArticleService
    {

        private string JsonAPODName
        {
            get { return Path.Combine("Articles", "20220801_16_00.json"); }
        }

        public IEnumerable<Article> getArticles()
        {
            using (var jsonFileReader = System.IO.File.OpenText(JsonAPODName))
            {
                //Bad date format error is not handled. Ex: 10-24-2022 --blazor component
                //Missing JSON entry is not handled. Ex: "temperatureF: ," --json file format
                return JsonSerializer.Deserialize<Article[]>(jsonFileReader.ReadToEnd(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
        }

    }
}
