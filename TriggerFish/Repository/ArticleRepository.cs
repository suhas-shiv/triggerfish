using System.Collections.Generic;
using TriggerFish.Models;

namespace TriggerFish.Repository
{
    public class ArticleRepository
    {
        public List<Article> GetArticles()
        {

            var articles = new List<Article>
            {
                new Article
                {
                    Title = "Why demand for in-store contactless payments is here to stay",
                    Description = "The demand for in-store contactless payment technology has increased over the past two years. Learn more about this growing trend and how you can leverage it.",
                    ReadTime = 4,
                    ImageUrl = "https://images.pexels.com/photos/12935064/pexels-photo-12935064.jpeg?auto=compress&cs=tinysrgb&w=1600",
                    ArticleUrl="#"
                },
                new Article
                {
                    Title = "7 ways to increase ecommerce sales",
                    Description = "Increase ecommerce sales with these 6 ideas to improve your customers online payment experience",
                    ReadTime = 6,
                    ImageUrl = "https://images.pexels.com/photos/34577/pexels-photo.jpg?auto=compress&cs=tinysrgb&w=1600",
                    ArticleUrl="#"
                },
                new Article
                {
                    Title = "How technology empowers businesses to prepare for the future of commerce",
                    Description = "The future of commerce is ever changing. Learn how our future-forward commerce technology keeps businesses at the forefront and removes complexity.",
                    ReadTime = 5,
                    ImageUrl = "https://images.pexels.com/photos/259091/pexels-photo-259091.jpeg?auto=compress&cs=tinysrgb&w=1600",
                    ArticleUrl="#"
                },
            };

            return articles;
        }
    }
}