using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortingAlgorithmTimeComplexity {
    class ModList {

        private int[] list;

        public int[] List { get => list; set => list = value; }

        public ModList(int len, int type) {
            List = new int[len];
            Random rand = new Random();
            for(int i = 0; i < len; i++) {
                List[i] = rand.Next(0, 20000);
            }

            switch (type) {
                case 0:
                    sortList(List, 0, len-1);
                    break;
                case 1:
                    reverseSortList(List, 0, len - 1);
                    break;
                case 2:
                    sortList(List, 0, len - 1);
                    almostSort(List);
                    break;              
            }
        }

        private void sortList(int[] list, int startInd, int endInd) {
            if(startInd < endInd) {
                int pivot = list[endInd];
                int i = startInd - 1;

                for(int j = startInd; j < endInd; j++) {
                    if(list[j] <= pivot) {
                        i += 1;
                        int tem = list[i];
                        list[i] = list[j];
                        list[j] = tem;
                    }
                }

                int temp = list[endInd];
                list[endInd] = list[i + 1];
                list[i + 1] = temp;
                int partInd = i + 1;
                this.sortList(list, startInd, partInd - 1);
                this.sortList(list, partInd + 1, endInd);
            }
        }

        private void reverseSortList(int[] list, int startInd, int endInd) {
            if (startInd < endInd) {
                int pivot = list[endInd];
                int i = startInd - 1;

                for (int j = startInd; j < endInd; j++) {
                    if (list[j] > pivot) {
                        i += 1;
                        int tem = list[i];
                        list[i] = list[j];
                        list[j] = tem;
                    }
                }

                int temp = list[endInd];
                list[endInd] = list[i + 1];
                list[i + 1] = temp;
                int partInd = i + 1;
                this.reverseSortList(list, startInd, partInd - 1);
                this.reverseSortList(list, partInd + 1, endInd);
            }
        }

        private void almostSort(int[] list) {
            Random rand = new Random();
            for(int i = 0; i < list.Length; i++) {
                int swap = rand.Next(1, 4);
                if (i + swap > list.Length - 1)
                    continue;
                int temp = list[i];
                list[i] = list[i + swap];
                list[i + swap] = temp;
                i += rand.Next(0, 4);

                if (i > list.Length - 1)
                    break;
            }
        }
    }
}
