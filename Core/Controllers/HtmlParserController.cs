using HtmlAgilityPack;
using System;
using System.Threading.Tasks;

namespace Core.Controllers
{
    public static class HtmlParserController
    {
        private static HtmlWeb htmlWeb;
        
        public static HtmlWeb GetHtmlWeb()
        {
            if (htmlWeb is null)
            {
                htmlWeb = new HtmlWeb();
            }

            return htmlWeb;
        }

        public async static Task<HtmlDocument> GetHtmlDocumentAsync(string url)
        {
            try
            {
                return await GetHtmlWeb().LoadFromWebAsync(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return default;
            }
        }

        public static HtmlNodeCollection GetHtmlNodeCollection(HtmlDocument htmlDocument, string xpath)
        {
            try
            {
                return htmlDocument.DocumentNode.SelectNodes(xpath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return default;
            }
        }

        public static HtmlNode GetHtmlNode(HtmlDocument htmlDocument, string xpath)
        {
            try
            {
                return htmlDocument.DocumentNode.SelectSingleNode(xpath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return default;
            }
        }
    }
}
