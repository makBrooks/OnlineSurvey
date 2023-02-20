using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OnlineSurveyWEB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSurveyWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        Uri baseAdd = new Uri("http://localhost:11354/api");

        HttpClient client;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
            client = new HttpClient();
            client.BaseAddress = baseAdd;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetDistrict()
        {
            string data = null;
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/District").Result;
            if (response.IsSuccessStatusCode)
            {
                data = response.Content.ReadAsStringAsync().Result;
            }
            return Json(data);
        }
        public async Task<JsonResult> GetBlockByDistId(int distId)
        {
            string data = null;
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/District/" + distId).Result;
            if (response.IsSuccessStatusCode)
            {
                data = response.Content.ReadAsStringAsync().Result;
            }
            return Json(data);
        }
        public async Task<JsonResult> GetPanchayatByBlockId(int blockId)
        {
            string data = null;
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Panchayat/" + blockId).Result;
            if (response.IsSuccessStatusCode)
            {
                data = response.Content.ReadAsStringAsync().Result;
            }
            return Json(data);
        }
        public async Task<JsonResult> GetVillageByPanchayatId(int punchId)
        {
            string data = null;
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Survey/" + punchId).Result;
            if (response.IsSuccessStatusCode)
            {
                data = response.Content.ReadAsStringAsync().Result;
            }
            return Json(data);
        }
        public async Task<JsonResult> GetInstitute()
        {
            string data = null;
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Survey").Result;
            if (response.IsSuccessStatusCode)
            {
                data = response.Content.ReadAsStringAsync().Result;
            }
            return Json(data);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrUpdate(SurveyEntity survey)
        {
            string data = JsonConvert.SerializeObject(survey);
            HttpResponseMessage response;
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            response = client.PutAsync(client.BaseAddress + "/School/" + survey.SlNo, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }








        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
