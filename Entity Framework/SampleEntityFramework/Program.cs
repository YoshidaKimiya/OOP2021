using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework
{
    class Program
    {
        

        static void Main(string[] args)
        {
            using (var db = new BooksDbContext())
            {


                //Exercise13_1_1();
                Exercise13_1_2();
                Exercise13_1_3();
                Exercise13_1_4();
                Exercise13_1_5();

                Console.ReadLine(); 
            }
            
        }

        private static void Exercise13_1_5()
        {
            using(var db = new BooksDbContext())
            {
                var authors = db.Authors.OrderByDescending(a => a.Birthday);
                foreach(var author in authors)
                {
                    Console.WriteLine("{0} {1:yyyy/MM}", author.Name, author.Birthday);
                    foreach (var book in author.Books)
                    {
                        Console.WriteLine("{0}{1}",
                                    book.Title, book.PublishedYear,
                                    book.Author.Name, book.Author.Birthday);
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void Exercise13_1_4()
        {
            using( var db = new BooksDbContext())
            {
                var books = db.books.OrderBy(x => x.PublishedYear).ToList();
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(books[i].Title);
                    Console.WriteLine(books[i].PublishedYear);
                    Console.WriteLine(books[i].Author.Name);
                }
            }
        }

        private static void Exercise13_1_3()
        {
            using(var db = new BooksDbContext())
            {
                var books = db.books.Where(x => x.Title.Length == db.books.Max(y => y.Title.Length));
                foreach (var book in books)
                {
                    Console.WriteLine(book.Title);
                    Console.WriteLine(book.PublishedYear);
                    Console.WriteLine(book.Author.Name);
                }
            }
        }

        private static void Exercise13_1_2()
        {
            using (var db = new BooksDbContext())
            {
                IEnumerable<book> books = db.books.ToList();
                foreach (var book   in books)
                {
                    Console.Write(book.Title + "  ");
                    Console.Write(book.PublishedYear + "  ");
                    Console.WriteLine(book.Author.Name);
                    Console.WriteLine();
                }
            }
        }

        private static void Exercise13_1_1()
        {
            using (var db = new BooksDbContext())
            {
                var book1 = new book
                {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = db.Authors.Single(a => a.Name == "夏目漱石"),

            };

                db.books.Add(book1);
                var book2 = new book
                {

                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成",
                    }
                };

                db.books.Add(book2);
                var book3 = new book
                {

                    Title = "真珠夫人",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛",
                    }
                };

                db.books.Add(book3);
                var book4 = new book
                {

                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = db.Authors.Single(a => a.Name == "宮沢賢治"),

            };

                db.books.Add(book4);
                db.SaveChanges();

            }
        }

        private static void DeleteBook()
        {
            using (var db = new BooksDbContext())
            {
                var book = db.books.SingleOrDefault(x => x.Id == 10);
               if(book != null)
                {
                    db.books.Remove(book);
                    db.SaveChanges();
                }
            }
        }

        private static void UpdateBook()
        {
            using(var db = new BooksDbContext())
            {
                var book = db.books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        // List 13-5
        static void InsertBooks()
        {
            using (var db = new BooksDbContext())
            {
                var book1 = new book
                {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.books.Add(book1);

                var book2 = new book
                {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author
                    {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.books.Add(book2);

                db.SaveChanges();


            }
        }

        static IEnumerable<book> GetBooks()
        {
            using(var db = new BooksDbContext())
            {
                return db.books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();
                                

            }
        }
    
        //List 13-8
        static void DisplayAllBooks()
        {
            var books = GetBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine();//F5で実行後、一時停止させる
        }
        // List 13-9
        private static void AddAuthors()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };

                db.Authors.Add(author1);
                var author2 = new Author
                {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };

                db.Authors.Add(author2);
                db.SaveChanges();

            }
        }

        // List 13-10
        private static void AddBooks()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new book
                {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new book
                {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.books.Add(book2);
                db.SaveChanges();
            }
        }


    }
}
