using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using Back.Models;
using Newtonsoft.Json;

namespace Back.App_Start
{
    public static class DbInit
    {
        private class CatList
        {
            public IEnumerable<CatJson> images { get; set; }
        }
        private class CatJson
        {
            public string url { get; set; }
            public string id { get; set; }
        }
        private const string JsonUrl = "https://latelier.co/data/cats.json";
        public static void InitDb()
        {
            CatmashContext db = new CatmashContext();
            List<Cat> Cats = db.Cats.ToList();
            if (Cats.Count == 0)
            {
                using (WebClient httpClient = new WebClient())
                {
                    var jsonData = httpClient.DownloadString(JsonUrl);
                    var data = JsonConvert.DeserializeObject<CatList>(jsonData);
                    foreach (var catJson in data.images)
                    {
                        db.Cats.Add(new Cat {Elo = 1000, Name = catJson.id, PhotoUrl = catJson.url});
                    }
                    db.SaveChanges();
                }
            }

        }

    }
}