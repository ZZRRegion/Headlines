using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.IO;
using HtmlAgilityPack;

namespace StdioHeadlines
{
    public class StCloud
    {
        private HttpClient httpClient;
        private string url => "http://toutiao-ali.juheapi.com/toutiao/index";
        public StCloud()
        {
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Add("Authorization", "APPCODE 4031c5c8c0b64622b89247bdb9b1a646");
        }
        public JObject GetContent()
        {
            Task<string> task = this.httpClient.GetStringAsync(this.url);
            string content = task.Result;
            JObject jObject = JObject.Parse(content);
            return jObject;
        }
        public Stream GetPicStream(string url)
        {
            Task<Stream> task = this.httpClient.GetStreamAsync(url);
            return task.Result;
        }
        public string GetHeadline(string url)
        {
            Task<string> task = this.httpClient.GetStringAsync(url);
            string content = task.Result;
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(content);
            HtmlNode htmlNode = htmlDocument.GetElementbyId("content");
            return htmlNode.InnerText;
        }
    }
}
