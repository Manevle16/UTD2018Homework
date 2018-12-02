using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        // Different sorts being tested, each calculates time passed, move counts, and
        // compare counts
        public void insertSort(int[] items) {
            int[] list = new int[items.Length];
            items.CopyTo(list, 0);
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

        public void selectionSort(int[] items) {
            int[] list = new int[items.Length];
            items.CopyTo(list, 0);
            Stopwatch time = new Stopwatch();
            time.Start();

            for(int i = 0; i < list.Length; i++) {
                int min = Int32.MaxValue;
                int minIndex = 0;

                for (int j = i + 1; j < list.Length; j++){
                    compareCount += 1;
                    if (list[j] < min) {
                        min = list[j];
                        minIndex = j;
                    }
                }
                moveCount += 1;
                int temp = list[i];
                list[i] = list[minIndex];
                list[minIndex] = temp;
            }

            time.Stop();
            milliTime = time.ElapsedMilliseconds;
            totalCount = moveCount + compareCount;
        }

        public void quickSort(int[] list, int startInd, int endInd) {
            

            Stopwatch time = new Stopwatch();
            time.Start();

            compareCount += 1;
            if (startInd < endInd) {
                int pivot = list[endInd];
                int i = startInd - 1;

                for (int j = startInd; j < endInd; j++) {
                    compareCount += 1;
                    if (list[j] <= pivot) {
                        i += 1;
                        moveCount += 1;
                        int tem = list[i];
                        list[i] = list[j];
                        list[j] = tem;
                    }
                }
                moveCount += 1;
                int temp = list[endInd];
                list[endInd] = list[i + 1];
                list[i + 1] = temp;
                int partInd = i + 1;

                this.quickSort(list, startInd, partInd - 1);
                this.quickSort(list, partInd + 1, endInd);
                
            }

            time.Stop();
            milliTime = time.ElapsedMilliseconds;
            totalCount = moveCount + compareCount;
        }

        public int[] mergeSort(int[] list) {
            Stopwatch time = new Stopwatch();
            time.Start();
            compareCount += 1;
            
            if (list.Length > 1) {
                int mid = (int)((list.Length) / 2);
                int[] leftArr = this.mergeSort(list.Take(mid).ToArray());
                int[] rightArr = this.mergeSort(list.Skip(mid).ToArray());


                List<int> mergedList = new List<int>();
                int leftInd = 0;
                int rightInd = 0;
                compareCount += 1;               
                while (leftInd < leftArr.Length || rightInd < rightArr.Length) {

                    if(leftInd == leftArr.Length) {
                        mergedList.Add(rightArr[rightInd]);
                        rightInd++;
                    }else if (rightInd == rightArr.Length) {
                        mergedList.Add(leftArr[leftInd]);
                        leftInd++;
                    }else if(leftArr[leftInd] < rightArr[rightInd]) {
                        mergedList.Add(leftArr[leftInd]);
                        leftInd++;
                    } else {
                        mergedList.Add(rightArr[rightInd]);
                        rightInd++;
                    }
                    moveCount += 1;
                    compareCount += 1;
                }

                time.Stop();
                milliTime = time.ElapsedMilliseconds;
                totalCount = moveCount + compareCount;
                return mergedList.ToArray();
            }

            return list;
        }

        public int[] heapSort(int[] list) {
            Stopwatch time = new Stopwatch();
            time.Start();

            List<int> heap = new List<int>();


            for(int i = 0; i < list.Length; i++) { 
                heap.Add(list[i]);
                int curInd = heap.Count - 1;

                compareCount += 1;
                while (curInd > 0 && heap[curInd] < heap[(int)Math.Ceiling((decimal)curInd / 2) - 1]) {

                    int temp = heap[(int)Math.Ceiling((decimal)curInd / 2) - 1];
                    heap[(int)Math.Ceiling((decimal)curInd / 2) - 1] = heap[curInd];
                    heap[curInd] = temp;
                    moveCount += 1;
                    compareCount += 1;
                  
                    curInd = (int)Math.Ceiling((decimal)curInd / 2) - 1;
                }
               
            }

            List<int> sorted = new List<int>();

            while(heap.Count != 0) { 
                sorted.Add(heap[0]);
                heap[0] = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);
                
                int curInd = 0;
             
                while (curInd*2+1 < heap.Count - 1 && (heap[curInd] > heap[curInd*2 + 1] ||
                    heap[curInd] > heap[curInd * 2 + 2])) {

                    if(heap[curInd * 2 + 1] < heap[curInd * 2 + 2]) {
                        int temp = heap[curInd * 2 + 1];
                        heap[curInd * 2 + 1] = heap[curInd];
                        heap[curInd] = temp;
                        moveCount += 1;
                        compareCount += 1;
                        curInd = curInd * 2 + 1;
                    } else {
                        int temp = heap[curInd * 2 + 2];
                        heap[curInd * 2 + 2] = heap[curInd];
                        heap[curInd] = temp;
                        moveCount += 1;
                        compareCount += 1;
                        curInd = curInd * 2 + 2;
                    }
                    compareCount += 1;
                }
            }
            time.Stop();
            milliTime = time.ElapsedMilliseconds;
            totalCount = moveCount + compareCount;
            return sorted.ToArray();
        }

        public int[] radixSort(int[] list) {
            Stopwatch time = new Stopwatch();
            time.Start();

            List<int>[] radixHash = new List<int>[10];
            for(int i = 0; i < radixHash.Length; i++) {
                radixHash[i] = new List<int>();
            }


            for (int i = 0; i < list.Length; i++) {
                radixHash[list[i] % 10].Add(list[i]);
            }


            int mod = 10;
            while (mod != 1000000) {         
                for (int i = 0; i < radixHash.Length; i++) {
                    List<int> removeAt = new List<int>();
                    for(int j = 0; j < radixHash[i].Count; j++) {
                        compareCount += 1;
                        if(mod > radixHash[i][j]) {
                            if (i == 0)
                                continue;
                            moveCount += 1;
                            radixHash[0].Add(radixHash[i][j]);
                            removeAt.Add(j);
                            continue;
                        }
                        int digit = radixHash[i][j] / mod % 10;
                       
                        compareCount += 1;
                        if (digit != i) {

                            moveCount += 1;
                            radixHash[digit].Add(radixHash[i][j]);
                            removeAt.Add(j);
                        }
                    }

                    for(int j = removeAt.Count - 1; j >= 0 ; j--) {

                        radixHash[i].RemoveAt(removeAt[j]);
                    }
                }
              
                mod *= 10;
            }

            int[] sorted = new int[list.Length];
            for(int i = 0; i < radixHash[0].Count; i++) {
                sorted[i] = radixHash[0][i];
            }

            time.Stop();
            milliTime = time.ElapsedMilliseconds;
            totalCount = moveCount + compareCount;
            return sorted;

        }

        
    }
}
