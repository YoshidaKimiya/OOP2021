using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };
            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);
            Console.WriteLine("-----");

            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine("-----");

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine("-----");

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine("-----");

            // 3.2.4
            Exercise2_4(names);
            Console.WriteLine("-----");

            Supecial1(names);
            Console.WriteLine("-----");

            Supecial2(names);
            Console.WriteLine("-----");
        }

       

        private static void Exercise1_1(List<int> numbers) {
            var exists = numbers.Exists( n => n % 8 == 0 || n % 9 == 0);
            foreach (var n in numbers) ;

            if (exists)
                Console.WriteLine("存在しています。");
            else
                Console.WriteLine("存在していません。");
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach( n => Console.WriteLine(n/2));
        }

        private static void Exercise1_3(List<int> numbers) {
            numbers.Where(n => n >= 50).ToList().ForEach(Console.WriteLine);
        }

        private static void Exercise1_4(List<int> numbers) {
            var select = numbers.Select(n => n * 2).ToList(); 
            select.ForEach(Console.WriteLine);
        }
        private static void Exercise2_1(List<string> names) {
            int index = names.FindIndex(n => n == "Bangkok");
            Console.WriteLine(index);
        }

        private static void Exercise2_2(List<string> names) {
            int count = names.Count(n => n.Contains("o"));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            names.Where(n => n.Contains("o")).ToList().ForEach(Console.WriteLine);
        }

        private static void Exercise2_4(List<string> names) {
            var select = names.Where(n => n.StartsWith("B")).Select(n => n.Length) ;
            foreach (var n in select) {
                Console.WriteLine(n);
            }
        }
        private static void Supecial1(List<string> names) {
            int count = 0;
            foreach (var name in names) {
                count += name.Count(c => char.IsLower(c));
                
            }
            Console.WriteLine(count);
        }

        private static void Supecial2(List<string> names) {
            var count = 0;
            foreach(var n in names) {
                count = n.Count(c => char.IsUpper(c));
                Console.WriteLine(count);
            }
        }
    }
}
