using app_progetto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace app_progetto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Index()
        {
            return View();
        }
        [BasicAuthorize]
        public IActionResult Privacy()
        {
            var url = "https://api.nasa.gov/planetary/apod?api_key=VElNBHxm54DIrE6CnNhrfNWMUVanqzmaEO3B8v4u";
            var webClient = new WebClient();
            
            var json = webClient.DownloadString(url);
            var jsonRes = JsonConvert.DeserializeObject(json).ToString();
        
            var resObj = JsonConvert.DeserializeObject<ApiContent>(jsonRes);

                ApiContent api = new ApiContent
                {                       
                    copyright = resObj.copyright,
                    date = resObj.date,
                    explanation = resObj.explanation,
                    hdurl = resObj.hdurl,
                    media_type = resObj.media_type,
                    service_version = resObj.service_version,
                    title = resObj.title,
                    url = resObj.url
                };
            return View(api);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
