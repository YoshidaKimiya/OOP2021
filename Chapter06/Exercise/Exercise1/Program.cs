using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            #region　テスト用ドライバ
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
            #endregion
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            var endNum = numbers.Reverse().Take(2).ToList();
            foreach (var item in endNum) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            var stNum = numbers.Select(n => n.ToString());
            foreach (var item in stNum) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            var num = numbers.OrderBy(x => x).Take(3);
            foreach (var item in num) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            var nums = numbers.Distinct();
            Console.WriteLine(nums.Count(n => n >= 10));
        }
    }
}
