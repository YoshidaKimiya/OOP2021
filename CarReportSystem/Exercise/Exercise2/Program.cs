using Exercise1;
using System;
using System.Linq;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            var ymCollection = new YearMonth[] {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2001,7),
                new YearMonth(1970,9),
                new YearMonth(1990,12),
            };

            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("-----");

            Exercise2_4(ymCollection);
            Console.WriteLine("-----");

            Exercise2_5(ymCollection);
            
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }

            
        }
        static YearMonth FindFirst21c(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }
        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yCheck = FindFirst21c(ymCollection);
            var s = yCheck != null ? yCheck.Year.ToString() : "21世紀のデータはありません。";
            Console.WriteLine(s);
        
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var select = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in select) {
                Console.WriteLine(ym);
            }
        }
    }
}
