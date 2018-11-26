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

        private void almostOrderCheck_CheckedChanged(object sender, EventArgs e) {
            if(curListType == 2 && almostOrderCheck.Checked == false) {
                randomCheck.Checked = true;
                return;
            }
            
            if (almostOrderCheck.Checked) {
                bestSort = null;
                bestSortEff = Int32.MaxValue;
                curListType = 2;
                uncheckAll(2);
            }
        }

        private void reverseOrderCheck_CheckedChanged(object sender, EventArgs e) {
            if (curListType == 1 && reverseOrderCheck.Checked == false) {
                randomCheck.Checked = true;
                return;
            }
            
            if (reverseOrderCheck.Checked) {
                bestSort = null;
                bestSortEff = Int32.MaxValue;
                curListType = 1;
                uncheckAll(1);
            }
        }

        private void inOrderCheck_CheckedChanged(object sender, EventArgs e) {
            if (curListType == 0 && inOrderCheck.Checked == false) {
                randomCheck.Checked = true;
                return;
            }
            
            if (inOrderCheck.Checked) {
                bestSort = null;
                bestSortEff = Int32.MaxValue;
                curListType = 0;
                uncheckAll(0);
                
            }
            
        }

        private void randomCheck_CheckedChanged(object sender, EventArgs e) {
            if (curListType == 3 && randomCheck.Checked == false) {
                randomCheck.Checked = true;
                return;
            }
            
            if (randomCheck.Checked) {
                bestSort = null;
                bestSortEff = Int32.MaxValue;
                curListType = 3;
                uncheckAll(3);
            }
            
        }

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
        }

        private void quickBtn_Click(object sender, EventArgs e) {
            if (items == null) {
                MessageBox.Show("Error: list must be created first");
                return;
            }
        }

        private void mergeBtn_Click(object sender, EventArgs e) {
            if (items == null) {
                MessageBox.Show("Error: list must be created first");
                return;
            }
        }

        private void heapBtn_Click(object sender, EventArgs e) {
            if (items == null) {
                MessageBox.Show("Error: list must be created first");
                return;
            }
        }

        private void radixBtn_Click(object sender, EventArgs e) {
            if (items == null) {
                MessageBox.Show("Error: list must be created first");
                return;
            }
        }

        private void createListBtn_Click(object sender, EventArgs e) {
            ModList list = new ModList(listSizeScroll.Value, curListType);
            resetAllTextBoxes();
            items = list;
        }

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

        private void listSize_Scroll(object sender, EventArgs e) {
            
            listSizeTextBox.Text = ((TrackBar)sender).Value.ToString();
        }

        private void setExperimentText(int[] list, Sort sort, string sortType) {
            listSizeResultText.Text = list.Length.ToString();
            checkEnum type = (checkEnum)curListType;
            dataTypeResultText.Text = type.ToString();
            sortResultText.Text = sortType;
            comparisonResultText.Text = sort.CompareCount.ToString();
            movementResultText.Text = sort.MoveCount.ToString();
            totalTimeResultText.Text = sort.MilliTime.ToString();

        }

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
