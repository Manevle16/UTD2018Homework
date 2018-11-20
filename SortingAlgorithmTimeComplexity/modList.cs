using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortingAlgorithmTimeComplexity {
    class modList {

        private int[] list;

        public modList(int len, int type) {
            list = new int[len];
            Random rand = new Random();
            for(int i = 0; i < len; i++) {
                list[i] = rand.Next(0, 20000);
            }

            switch (type) {
                case 0:
                    sortList();
                    break;
                
            }
        }

        private void sortList() {

        }
        
    }
}
