using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04
{
    class Program
    {

        Dictionary<string, int> AreaDic = new Dictionary<string, int>()
        {
                    {"前橋", 4210},
                    {"みなかみ", 4220},
                    {"宇都宮", 4110},
                    {"水戸", 4010}
        };
        List<int> cityCode = new List<int>();
        static void Main(string[] args) 
        {
            new Program();
        }
            public Program()
            {
                Console.WriteLine("Yahoo!週間天気予報");
                Console.WriteLine();
                Console.WriteLine("地域コードを入力");

                int num = 1;

                foreach (KeyValuePair<string, int>pair in AreaDic)
                {
                    Console.WriteLine("{0}:{1}", num++, pair.Key);
                cityCode.Add(pair.Value);
                }

                Console.WriteLine("9:その他(直接入力)");
                Console.WriteLine();

                Console.Write(">");
                // 文字列として入力した数字を取り込む
                var selectArea = Console.ReadLine();


            var results = GetWeatherReportFromYahoo(4610);
            int pos = int.Parse(selectArea);
            int code;
            if (pos != 9)
            {
                 code = cityCode([pos - 1]);
            }
            else
            {
                Console.Write("年コードを入力:");
                code = int.Parse(Console.ReadLine());
                
            }
                foreach (var s in results)
                {
                    Console.WriteLine(s);
                }
                Console.ReadLine();
            }
            public void DownloadString()
            {
                var wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                var html = wc.DownloadString("https://yahoo.co.jp/");
                Console.WriteLine(html);

            }
            private void DownloadFileAsync()
            {
                var wc = new WebClient();
                var url = new Uri(@"C: \Users\ky32104\Desktop\画像２.jpg");
                var filename = @"C:\temp\example.zip";
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                wc.DownloadFileAsync(url, filename);
                Console.ReadLine();
            }

            static void wc_DownloadProgressChanged(object sender,
                                DownloadProgressChangedEventArgs e)
            {
                Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                                  e.BytesReceived, e.TotalBytesToReceive);
            }

            static void wc_DownloadFileCompleted(object sender,
                                System.ComponentModel.AsyncCompletedEventArgs e)
            {

            }



            public void OpenReadSample()
            {
                var wc = new WebClient();
                using (var stream = wc.OpenRead(@"https://yahoo.co.jp/"))
                using (var sr = new StreamReader(stream, Encoding.UTF8))
                {
                    string html = sr.ReadToEnd();
                    Console.WriteLine(html);
                    //sr.Dispose();
                }

            }
            private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
            {
                using (var wc = new WebClient())
                {
                    wc.Headers.Add("Content-type", "charset=UTF-8");
                    var uriString = string.Format(
                        @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                    var url = new Uri(uriString);
                    var stream = wc.OpenRead(url);

                    XDocument xdoc = XDocument.Load(stream);
                    var nodes = xdoc.Root.Descendants("title");
                    foreach (var node in nodes)
                    {
                        string s = Regex.Replace(node.Value, "【|】", "");
                        yield return s;
                    }
                }
            }


        


    } 
}
