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
            var productHTML = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "")
                .Equals("row column search_results")).ToList();

           // File.WriteAllText("testWeb.txt", htmlDocument.ParsedText);
            File.WriteAllText("testWeb.txt", productHTML[0].InnerText);
            //var productsList = productHTML[0].Descendants



            //return html.Result;
        }
        /*static readonly HttpClient client = new HttpClient();

        public static async Task GetWebHTML()
        {
            
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);
               
                File.WriteAllText("testWeb.txt", responseBody);
            }
            catch (HttpRequestException e)
            {
                File.WriteAllText("testWeb.txt", "\nException Caught!");
               // File.WriteAllText("testWeb.txt", e.Message);
            }
        }*/
    }
}
