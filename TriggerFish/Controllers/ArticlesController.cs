using System.Collections.Generic;
using System.Web.Mvc;
using TriggerFish.Models;
using TriggerFish.Repository;

namespace TriggerFish.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly ArticleRepository _repository;

        public ArticlesController()
        {
            _repository = new ArticleRepository();
        }

        public ActionResult Index()
        {
            List<Article> articles = _repository.GetArticles();
            return View(articles);
        }
    }
}