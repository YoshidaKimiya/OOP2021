using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は"+books.Average(x => x.Price).ToString("#,0")+"円");
            Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages)+ "ページ");
            Console.WriteLine("最も安い本は" + books.Min(x => x.Price) + "円");
            Console.WriteLine("最も高い本は" + books.Max(x => x.Price) + "円");
            //500円以上の本の数
            Console.WriteLine("５００円以上の本は" + books.Count(x => x.Price >= 500)+"冊");
            //物語が含まれている本の数
            Console.WriteLine("物語の本は" + books.Count(x => x.Title.Contains("物語")) + "冊");
            //物語が含まれている本の一覧
            var bookData = books.Where(x => x.Title.Contains("物語")).Take(2);
            foreach (var book in bookData) {
                Console.WriteLine(book.Title);
            }
            //本の価格が高い順に上から３
            Console.WriteLine("本の価格ランキングbest3");
            var bookRan = books.OrderByDescending(x => x.Price).Take(3);
            foreach (var book in bookRan) {
                Console.WriteLine($"タイトル；{book.Title}　値段；{book.Price}円");
            }
            Console.WriteLine();
            //本のタイトル一覧
            var titles = books.Select(x => x.Title);
            foreach (var item in titles) {
                Console.WriteLine(item);
            }
        }
    }
}
