using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lyrics.Models;
using Lyrics.ApiConnectors;

namespace Lyrics.Controllers
{
    public class HomeController : Controller
    {
        private LastFmConnector LastFm;

        public HomeController()
        {
            LastFm = new LastFmConnector();
        }

        public IActionResult Index()
        {
            return View();
        }

        // for ajax call
        public async Task<IActionResult> Artist(string name)
        {
            var artist = await LastFm.GetArtistDetails(name);
            var model = new ArtistModel(artist);
            return PartialView(model);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
