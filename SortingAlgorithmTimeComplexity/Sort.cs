using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTimeComplexity {
    class Sort {
        private int compareCount = 0;
        private int moveCount = 0;
        private int totalCount = 0;
        private long milliTime = 0;
        
        public int CompareCount { get => compareCount; set => compareCount = value; }
        public int MoveCount { get => moveCount; set => moveCount = value; }
        public int TotalCount { get => totalCount; set => totalCount = value; }
        public long MilliTime { get => milliTime; set => milliTime = value; }

        public Sort() { }

        public void insertSort(int[] list) {
            Stopwatch time = new Stopwatch();
            time.Start();
            for (int i = 0; i < list.Length; i++) {
                int j = i;
                while (j > 0) {
                    compareCount += 1;
                    if (list[j] < list[j - 1]) {
                        moveCount += 1;
                        int temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                    j -= 1;
                }
            }

            time.Stop();
            milliTime = time.ElapsedMilliseconds;
            totalCount = moveCount + compareCount;
            
        }
    }
}
