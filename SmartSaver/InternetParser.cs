using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SmartSaver
{
    class InternetParser
    {
        /*Example of calling method:
         * Task.Run(() => InternetParser.GetHTMLAsync()).Wait();
        */


        public static async Task GetHTMLAsync()
        {
            var url = "https://uk.camelcamelcamel.com/search?sq=iphone+11";
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml");
           // httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");

            var html =  await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var productHTML = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "")/*Everything on the page*/
                .Equals("row column search_results")).ToList();

            var productListItems = productHTML[0].Descendants("div").Where(node => node.GetAttributeValue("class", "")
            .Equals("row")).ToList();

            var name = productListItems[0].Descendants("strong").FirstOrDefault().InnerText;
            name = name.Remove(name.Length - 13);
            /*<span class="green">£729.00</span>*/

            var pricestr = productListItems[0].Descendants("span").Where(node => node.GetAttributeValue("class", "")
            .Equals("green")).FirstOrDefault().InnerText;
            pricestr = pricestr.Substring(1).Trim();

            try
            {
                var price = Convert.ToDouble(pricestr, System.Globalization.CultureInfo.InvariantCulture);
                File.WriteAllText("testWeb.txt", name +"\n"+ price);
            }
            catch(Exception e)
            {
                Debug.Write(e);
            }
            



            
            // File.WriteAllText("testWeb.txt", htmlDocument.ParsedText);
           // File.WriteAllText("testWeb.txt", productListItems[0].InnerHtml);
            //var productsList = productHTML[0].Descendants


        }
    }
}
