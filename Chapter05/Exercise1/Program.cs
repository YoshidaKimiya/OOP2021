﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            #region 問題5.1
#if false
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();
            
            if (String.Compare(s1, s2, ignoreCase:true) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
#endif
            #endregion
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
        }
    }
}
