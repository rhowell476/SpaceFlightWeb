using SpaceFlightWeb_API.Services;
using Microsoft.AspNetCore.Mvc;


namespace SpaceFlightWeb_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        JsonFileArticleService articleService = new JsonFileArticleService();

        private readonly ILogger<ArticlesController> _logger;

        public ArticlesController(ILogger<ArticlesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetArticles")]
        public IEnumerable<Article> Get()
        {
            return articleService.getArticles();
        }
    }
}