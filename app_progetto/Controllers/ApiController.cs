
using app_progetto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;


namespace app_progetto.Controllers
{
    public class ApiController : Controller
    {
        // GET: ApiController
        public ActionResult Index()
        {
            return View("Create");
        }

        // GET: ApiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApiController/Create
        public ActionResult Create()
        {        
            var url = "https://api.nasa.gov/planetary/apod?api_key=VElNBHxm54DIrE6CnNhrfNWMUVanqzmaEO3B8v4u";
            var jsonResp = JsonConvert.DeserializeObject(url).ToString();
            var resObj = JsonConvert.DeserializeObject<ApiContent>(jsonResp);
            Console.WriteLine("_____Risposta Object_______ " + resObj);
            
            return View();
        }

        // POST: ApiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
