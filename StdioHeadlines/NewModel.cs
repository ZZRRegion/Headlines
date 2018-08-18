using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdioHeadlines
{
    public class NewModel
    {
        public string uniquekey { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public string category { get; set; }
        public string author_name { get; set; }
        public string url { get; set; }
        public string thumbnail_pic_s { get; set; }
        public override string ToString()
        {
            return this.title;
        }
        public string GetContent()
        {
            string content = string.Empty;
            content = $"标题:{this.title}{Environment.NewLine}更新时间:{this.date}{Environment.NewLine}地址:{this.url}{Environment.NewLine}thumbnail_pic_s:{this.thumbnail_pic_s}";
            return content;
        }
    }
}
