using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using HtmlAgilityPack;

namespace CountryMusicCountdown.Data
{
    public class ScraperService
    {

        public DateTime CountdownDate { get; set; }
        public async Task<List<string>> ScrapeDates()
        {
            List<string> Datalst = new List<string>();

        HttpClient hc = new HttpClient();
        HttpResponseMessage result = await hc.GetAsync($"https://american-country-countdown.fandom.com/wiki/Charts");
        Stream stream = await result.Content.ReadAsStreamAsync();
        HtmlDocument doc = new HtmlDocument();
        doc.Load(stream);

        var DateNames = doc.DocumentNode.Descendants("li")
                .Where(node => !node.GetAttributeValue("class", "").Contains("toclevel-1")).ToList();

        foreach(var item in DateNames)
            {
                if (item.FirstChild.Attributes.Count > 0)
                    Datalst.Add("https://american-country-countdown.fandom.com/" + item.FirstChild.Attributes[0].Value);
            }

            return Datalst;
        }

    }
}
