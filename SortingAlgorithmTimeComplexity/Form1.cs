using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace SortingAlgorithmTimeComplexity {
    public partial class Form1 : Form {

        private enum checkEnum { inOrder, reversedOrder, almostOrder, random };
        private int curCheckedList = 3;
        private int curListType = 3;
        private string bestSort = null;
        private int bestSortEff = Int32.MaxValue;
        ModList items = null;

        public Form1() {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        // Methods for handeling changes in the mode checkboxes
        private void almostOrderCheck_CheckedChanged(object sender, EventArgs e) {
            if(curCheckedList == 2 && almostOrderCheck.Checked == false) {
                randomCheck.Checked = true;
                return;
            }
            
            if (almostOrderCheck.Checked) {
                bestSort = null;
                bestSortEff = Int32.MaxValue;
                curCheckedList = 2;
                uncheckAll(2);
            }
        }

        private void reverseOrderCheck_CheckedChanged(object sender, EventArgs e) {
            if (curCheckedList == 1 && reverseOrderCheck.Checked == false) {
                randomCheck.Checked = true;
                return;
            }
            
            if (reverseOrderCheck.Checked) {
                bestSort = null;
                bestSortEff = Int32.MaxValue;
                curCheckedList = 1;
                uncheckAll(1);
            }
        }

        private void inOrderCheck_CheckedChanged(object sender, EventArgs e) {
            if (curCheckedList == 0 && inOrderCheck.Checked == false) {
                randomCheck.Checked = true;
                return;
            }
            
            if (inOrderCheck.Checked) {
                bestSort = null;
                bestSortEff = Int32.MaxValue;
                curCheckedList = 0;
                uncheckAll(0);
                
            }
            
        }

        private void randomCheck_CheckedChanged(object sender, EventArgs e) {
            if (curCheckedList == 3 && randomCheck.Checked == false) {
                randomCheck.Checked = true;
                return;
            }
            
            if (randomCheck.Checked) {
                bestSort = null;
                bestSortEff = Int32.MaxValue;
                curCheckedList = 3;
                uncheckAll(3);
            }
            
        }

        // Methods for handeling buttons to execute test of sort
        private void insertBtn_Click(object sender, EventArgs e) {
            if(items == null) {
                MessageBox.Show("Error: list must be created first");
                return;
            }

            Sort sort = new Sort();
            sort.insertSort(items.List);
            if(sort.TotalCount < bestSortEff) {
                bestSortEff = sort.TotalCount;
                bestSort = "Insertion Sort";
                winAlgTextBox.Text = bestSort;
            }

            setExperimentText(items.List, sort, "Insertion");

        }

        private void selectBtn_Click(object sender, EventArgs e) {
            if (items == null) {
                MessageBox.Show("Error: list must be created first");
                return;
            }

            Sort sort = new Sort();
            sort.selectionSort(items.List);
            if (sort.TotalCount < bestSortEff) {
                bestSortEff = sort.TotalCount;
                bestSort = "Selection Sort";
                winAlgTextBox.Text = bestSort;
            }

            setExperimentText(items.List, sort, "Selection");
        }

        private void quickBtn_Click(object sender, EventArgs e) {
            if (items == null) {
                MessageBox.Show("Error: list must be created first");
                return;
            }

            if(curListType == 1 && items.List.Length > 10000) {
                MessageBox.Show("Error: Quick sort will stack overthrow when in reverse" +
                    " mode and has more than 10000 elements");
                return;
            }

            Sort sort = new Sort();
            int[] list = new int[items.List.Length];
            items.List.CopyTo(list, 0);

            sort.quickSort(list, 0, list.Length-1);
            if (sort.TotalCount < bestSortEff) {
                bestSortEff = sort.TotalCount;
                bestSort = "Quick Sort";
                winAlgTextBox.Text = bestSort;
            }

            setExperimentText(items.List, sort, "Quick");
        }

        private void mergeBtn_Click(object sender, EventArgs e) {
            if (items == null) {
                MessageBox.Show("Error: list must be created first");
                return;
            }

            Sort sort = new Sort();
            int[] list = new int[items.List.Length];
            items.List.CopyTo(list, 0);

            sort.mergeSort(list);
            
            if (sort.TotalCount < bestSortEff) {
                bestSortEff = sort.TotalCount;
                bestSort = "Merge Sort";
                winAlgTextBox.Text = bestSort;
            }

            setExperimentText(items.List, sort, "Merge");
        }

        private void heapBtn_Click(object sender, EventArgs e) {
            if (items == null) {
                MessageBox.Show("Error: list must be created first");
                return;
            }

            Sort sort = new Sort();
            int[] list = new int[items.List.Length];
            items.List.CopyTo(list, 0);

            sort.heapSort(list);
            
            if (sort.TotalCount < bestSortEff) {
                bestSortEff = sort.TotalCount;
                bestSort = "Heap Sort";
                winAlgTextBox.Text = bestSort;
            }
            setExperimentText(items.List, sort, "Heap");
        }

        private void radixBtn_Click(object sender, EventArgs e) {
            if (items == null) {
                MessageBox.Show("Error: list must be created first");
                return;
            }


            Sort sort = new Sort();
            int[] list = new int[items.List.Length];
            items.List.CopyTo(list, 0);

            sort.radixSort(list);
          
            if (sort.TotalCount < bestSortEff) {
                bestSortEff = sort.TotalCount;
                bestSort = "Radix Sort";
                winAlgTextBox.Text = bestSort;
            }
            setExperimentText(items.List, sort, "Radix");
        }

        // Creates the list as given by the settings
        private void createListBtn_Click(object sender, EventArgs e) {
            curListType = curCheckedList;
            ModList list = new ModList(listSizeScroll.Value, curCheckedList);
            resetAllTextBoxes();
            items = list;
        }

        //Will uncheck all other check boxes except the mode sent in
        private void uncheckAll(int type) {

            if(type == (int)checkEnum.random) {
                inOrderCheck.Checked = false;
                reverseOrderCheck.Checked = false;
                almostOrderCheck.Checked = false;

            }else if(type == (int)checkEnum.inOrder) {
                reverseOrderCheck.Checked = false;
                almostOrderCheck.Checked = false;
                randomCheck.Checked = false;

            } else if (type == (int)checkEnum.almostOrder) {
                inOrderCheck.Checked = false;
                reverseOrderCheck.Checked = false;
                randomCheck.Checked = false;

            } else{
                inOrderCheck.Checked = false;
                almostOrderCheck.Checked = false;
                randomCheck.Checked = false;

            }
           
        }

        // Changes shown number in list size when corresponding scroller changes
        private void listSize_Scroll(object sender, EventArgs e) {
            
            listSizeTextBox.Text = ((TrackBar)sender).Value.ToString();
        }

        // Sets the results of the exepriment text boxes of the sent in test
        private void setExperimentText(int[] list, Sort sort, string sortType) {
            listSizeResultText.Text = list.Length.ToString();
            checkEnum type = (checkEnum)curCheckedList;
            dataTypeResultText.Text = type.ToString();
            sortResultText.Text = sortType;
            comparisonResultText.Text = sort.CompareCount.ToString();
            movementResultText.Text = sort.MoveCount.ToString();
            totalTimeResultText.Text = sort.MilliTime.ToString();

        }

        // Sets all textboxes to have no text in them
        private void resetAllTextBoxes() {
            winAlgTextBox.Text = null;
            listSizeResultText.Text = null;
            dataTypeResultText.Text = null;
            sortResultText.Text = null;
            comparisonResultText.Text = null;
            movementResultText.Text = null;
            totalTimeResultText.Text = null;
        }
    }
}
