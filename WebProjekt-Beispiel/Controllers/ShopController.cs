using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProjekt_Beispiel.Models;
     
namespace WebProjekt_Beispiel.Controllers
{    
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View(CreateArticeList());
        }

        public IActionResult ReturnArticles()
        {
            return View();
        }


        private List<Article> CreateArticeList()
        {
            return new List<Article>()
            {
                new Article(1, "FNATIC Jersy", 60.99m, "Fnatic 2020 JERSY Custom Name", new DateTime(2020, 5, 20)),
                new Article(2, "Fnatic DX Racer Gaming Stuhl", 290.99m, "Offizieller Gaming Stuhl der Fnatic Spieler", null),
                new Article(3, "Streak 65 Esports Keyboard ", 119.90m, "Gaming Tastatur mit echten Cherry MX Switches", new DateTime(2019, 9, 1)),
                new Article(4, "React Esports Performance Headset", 79.99m, "Esports Headset", new DateTime(2020, 5, 20))
            };
        }
    }
}
