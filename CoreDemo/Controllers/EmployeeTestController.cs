using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class EmployeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responceMessage = await httpClient.GetAsync("https://localhost:44359/api/Default");
            var jsonString = await responceMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
            return View(values);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        public async Task<IActionResult> AddEmployee(Class1 p)
        {
            var httpClient = new HttpClient();
        }
    }
    public class Class1
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
