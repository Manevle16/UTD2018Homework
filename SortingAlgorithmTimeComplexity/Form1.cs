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

        public Form1() {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void dataTypeLabel_Click(object sender, EventArgs e) {

        }

        private void almostOrderCheck_CheckedChanged(object sender, EventArgs e) {
            if(almostOrderCheck.Checked)
                uncheckAll(2);
        }

        private void reverseOrderCheck_CheckedChanged(object sender, EventArgs e) {
            if(reverseOrderCheck.Checked)
                uncheckAll(1);
        }

        private void inOrderCheck_CheckedChanged(object sender, EventArgs e) {
            if(inOrderCheck.Checked)
                uncheckAll(0);
        }

        private void randomCheck_CheckedChanged(object sender, EventArgs e) {
            if(randomCheck.Checked)
                uncheckAll(3);           
        }

        private void insertBtn_Click(object sender, EventArgs e) {

        }

        private void selectBtn_Click(object sender, EventArgs e) {

        }

        private void quickBtn_Click(object sender, EventArgs e) {

        }

        private void mergeBtn_Click(object sender, EventArgs e) {

        }

        private void heapBtn_Click(object sender, EventArgs e) {

        }

        private void radixBtn_Click(object sender, EventArgs e) {

        }

        private void createListBtn_Click(object sender, EventArgs e) {

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
    }
}
