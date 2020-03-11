using banger.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace banger.Services
{
   public class WebService : IWebService
    {
        public async Task<List<WebModel>> WebScraping() {
            List<WebModel> list = new List<WebModel>();
            try
            {
                var url = "http://andrewsrentacar.com/shop/";
                var httpClient = new HttpClient();
                var html = await httpClient.GetStringAsync(url);

                var htmlDocument = new HtmlAgilityPack.HtmlDocument();

                htmlDocument.LoadHtml(html);

                var carHtml = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "")
                .Equals("car-listing")).ToList();

                var carList = carHtml[0].Descendants("h4")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("caption-title")).ToList();

                var carList1 = carHtml[0].Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("caption")).ToList();


                for (int k = 0; k < carList1.Count; k += 2)
                {
                    WebModel webModel = new WebModel();
                    webModel.Vehicle =
                    carList1[k].Descendants("h4")
                       .Where(node => node.GetAttributeValue("class", "")
                       .Equals("caption-title")).FirstOrDefault().InnerText;


                    webModel.Price = carList1[k].Descendants("h5")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("caption-title-sub")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t').Split(';').Last().Split('/').First();

                    list.Add(webModel);
                }

            }
            catch (Exception e) {
                Console.WriteLine("Internet issue");
            }
            return list;
        }

    }
}
