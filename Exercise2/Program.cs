using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            for (int inch = 1; inch <= 10; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} ih = {1:0.0000} m", inch, meter);
            }


        }
    }
}
