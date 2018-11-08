using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _234TreeCreator {
    class Program {
        static void Main(string[] args) {
            int[] values = new int[] { 1, 12, 8, 2, 25, 6, 14, 28, 17, 7, 52, 16, 48, 68, 3, 26, 29, 53, 55, 45 };
            _234Tree Tree = new _234Tree();
           
            for(int i = 0; i < values.Length; i++) {
                Tree.insertValue(values[i]);
            }
        }
    }
}
