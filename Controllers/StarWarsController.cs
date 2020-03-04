using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using StarwarsAPI_lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace StarwarsAPI_lab.Controllers
{
    public class StarWarsController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetPersonById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swap.co/api/people");

            var response = await client.GetAsync($"people/{id}");
            var person = await response.Content.ReadAsAsync<People>();

            return View(person);
        }
        public async Task<IActionResult> GetPlanetById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swap.co/api/planets");

            var response = await client.GetAsync($"planets/{id}");
            var planet = await response.Content.ReadAsAsync<Planets>();

            return View(planet);
        }


    }
}