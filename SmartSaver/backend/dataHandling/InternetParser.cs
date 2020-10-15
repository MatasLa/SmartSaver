using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ePiggy.backend.dataHandling
{
    public static class InternetParser
    {
        /*Example of calling method:
         * Task.Run(() => InternetParser.GetHTMLAsync()).Wait();
        */
        private static readonly string resourceDirectoryParsedGoal = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources\textData\parsedGoal.txt";
        public static async Task GetHTMLAsync(string itemName)
        {
            itemName = WebUtility.UrlEncode(itemName);
            var url = "https://uk.camelcamelcamel.com/search?sq=" + itemName;/*Need tweaking with symbols inside itemName*/
            Handler.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml");
            Handler.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
            Handler.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");

            var html =  await Handler.HttpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var productHTML = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "")/*Everything on the page*/
                .Equals("row column search_results")).ToList();

            var productListItems = productHTML[0].Descendants("div").Where(node => node.GetAttributeValue("class", "")
            .Equals("row")).ToList();

            var name = productListItems[0].Descendants("strong").FirstOrDefault().InnerText;
            name = name.Remove(name.Length - 13);

            var pricestr = productListItems[0].Descendants("span").Where(node => node.GetAttributeValue("class", "")
            .Equals("green")).FirstOrDefault().InnerText;
            pricestr = pricestr.Substring(1).Trim();

            
            File.WriteAllText(resourceDirectoryParsedGoal, name +"\n"+ pricestr);
            
        }
    }
}
