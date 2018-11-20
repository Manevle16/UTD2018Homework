namespace SortingAlgorithmTimeComplexity {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.winAlgTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.insertBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.quickBtn = new System.Windows.Forms.Button();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.heapBtn = new System.Windows.Forms.Button();
            this.radixBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.randomCheck = new System.Windows.Forms.CheckBox();
            this.almostOrderCheck = new System.Windows.Forms.CheckBox();
            this.reverseOrderCheck = new System.Windows.Forms.CheckBox();
            this.inOrderCheck = new System.Windows.Forms.CheckBox();
            this.createListBtn = new System.Windows.Forms.Button();
            this.listSizeTextBox = new System.Windows.Forms.TextBox();
            this.listSizeScroll = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalTimeResultText = new System.Windows.Forms.TextBox();
            this.movementResultText = new System.Windows.Forms.TextBox();
            this.comparisonResultText = new System.Windows.Forms.TextBox();
            this.sortResultText = new System.Windows.Forms.TextBox();
            this.dataTypeResultText = new System.Windows.Forms.TextBox();
            this.listSizeResultText = new System.Windows.Forms.TextBox();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.movementsLabel = new System.Windows.Forms.Label();
            this.comparisonsLabel = new System.Windows.Forms.Label();
            this.sortLabel = new System.Windows.Forms.Label();
            this.dataTypeLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSizeScroll)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // winAlgTextBox
            // 
            this.winAlgTextBox.Location = new System.Drawing.Point(32, 41);
            this.winAlgTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.winAlgTextBox.Name = "winAlgTextBox";
            this.winAlgTextBox.ReadOnly = true;
            this.winAlgTextBox.Size = new System.Drawing.Size(671, 38);
            this.winAlgTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.winAlgTextBox);
            this.panel1.Location = new System.Drawing.Point(629, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 117);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(837, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Winning Algorithm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.insertBtn);
            this.panel2.Controls.Add(this.selectBtn);
            this.panel2.Controls.Add(this.quickBtn);
            this.panel2.Controls.Add(this.mergeBtn);
            this.panel2.Controls.Add(this.heapBtn);
            this.panel2.Controls.Add(this.radixBtn);
            this.panel2.Location = new System.Drawing.Point(32, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 861);
            this.panel2.TabIndex = 6;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(59, 38);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(440, 141);
            this.insertBtn.TabIndex = 5;
            this.insertBtn.Text = "Insertion Sort";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(59, 169);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(440, 138);
            this.selectBtn.TabIndex = 4;
            this.selectBtn.Text = "Selection Sort";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // quickBtn
            // 
            this.quickBtn.Location = new System.Drawing.Point(59, 298);
            this.quickBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.quickBtn.Name = "quickBtn";
            this.quickBtn.Size = new System.Drawing.Size(440, 138);
            this.quickBtn.TabIndex = 3;
            this.quickBtn.Text = "Quick Sort";
            this.quickBtn.UseVisualStyleBackColor = true;
            this.quickBtn.Click += new System.EventHandler(this.quickBtn_Click);
            // 
            // mergeBtn
            // 
            this.mergeBtn.Location = new System.Drawing.Point(59, 427);
            this.mergeBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(440, 131);
            this.mergeBtn.TabIndex = 2;
            this.mergeBtn.Text = "Merge Sort";
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.mergeBtn_Click);
            // 
            // heapBtn
            // 
            this.heapBtn.Location = new System.Drawing.Point(59, 544);
            this.heapBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.heapBtn.Name = "heapBtn";
            this.heapBtn.Size = new System.Drawing.Size(440, 141);
            this.heapBtn.TabIndex = 1;
            this.heapBtn.Text = "Heap Sort";
            this.heapBtn.UseVisualStyleBackColor = true;
            this.heapBtn.Click += new System.EventHandler(this.heapBtn_Click);
            // 
            // radixBtn
            // 
            this.radixBtn.Location = new System.Drawing.Point(59, 677);
            this.radixBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radixBtn.Name = "radixBtn";
            this.radixBtn.Size = new System.Drawing.Size(440, 126);
            this.radixBtn.TabIndex = 0;
            this.radixBtn.Text = "Radix Sort";
            this.radixBtn.UseVisualStyleBackColor = true;
            this.radixBtn.Click += new System.EventHandler(this.radixBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.randomCheck);
            this.panel3.Controls.Add(this.almostOrderCheck);
            this.panel3.Controls.Add(this.reverseOrderCheck);
            this.panel3.Controls.Add(this.inOrderCheck);
            this.panel3.Controls.Add(this.createListBtn);
            this.panel3.Controls.Add(this.listSizeTextBox);
            this.panel3.Controls.Add(this.listSizeScroll);
            this.panel3.Location = new System.Drawing.Point(632, 212);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 342);
            this.panel3.TabIndex = 7;
            // 
            // randomCheck
            // 
            this.randomCheck.AutoSize = true;
            this.randomCheck.Checked = true;
            this.randomCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomCheck.Location = new System.Drawing.Point(438, 108);
            this.randomCheck.Name = "randomCheck";
            this.randomCheck.Size = new System.Drawing.Size(160, 36);
            this.randomCheck.TabIndex = 10;
            this.randomCheck.Text = "Random";
            this.randomCheck.UseVisualStyleBackColor = true;
            this.randomCheck.CheckedChanged += new System.EventHandler(this.randomCheck_CheckedChanged);
            // 
            // almostOrderCheck
            // 
            this.almostOrderCheck.AutoSize = true;
            this.almostOrderCheck.Location = new System.Drawing.Point(112, 108);
            this.almostOrderCheck.Name = "almostOrderCheck";
            this.almostOrderCheck.Size = new System.Drawing.Size(212, 36);
            this.almostOrderCheck.TabIndex = 9;
            this.almostOrderCheck.Text = "AlmostOrder";
            this.almostOrderCheck.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.almostOrderCheck.UseVisualStyleBackColor = true;
            this.almostOrderCheck.CheckedChanged += new System.EventHandler(this.almostOrderCheck_CheckedChanged);
            // 
            // reverseOrderCheck
            // 
            this.reverseOrderCheck.AutoSize = true;
            this.reverseOrderCheck.Location = new System.Drawing.Point(438, 41);
            this.reverseOrderCheck.Name = "reverseOrderCheck";
            this.reverseOrderCheck.Size = new System.Drawing.Size(246, 36);
            this.reverseOrderCheck.TabIndex = 8;
            this.reverseOrderCheck.Text = "ReversedOrder";
            this.reverseOrderCheck.UseVisualStyleBackColor = true;
            this.reverseOrderCheck.CheckedChanged += new System.EventHandler(this.reverseOrderCheck_CheckedChanged);
            // 
            // inOrderCheck
            // 
            this.inOrderCheck.AutoSize = true;
            this.inOrderCheck.Location = new System.Drawing.Point(112, 41);
            this.inOrderCheck.Name = "inOrderCheck";
            this.inOrderCheck.Size = new System.Drawing.Size(148, 36);
            this.inOrderCheck.TabIndex = 7;
            this.inOrderCheck.Text = "InOrder";
            this.inOrderCheck.UseVisualStyleBackColor = true;
            this.inOrderCheck.CheckedChanged += new System.EventHandler(this.inOrderCheck_CheckedChanged);
            // 
            // createListBtn
            // 
            this.createListBtn.Location = new System.Drawing.Point(145, 241);
            this.createListBtn.Name = "createListBtn";
            this.createListBtn.Size = new System.Drawing.Size(441, 54);
            this.createListBtn.TabIndex = 6;
            this.createListBtn.Text = "Create the List";
            this.createListBtn.UseVisualStyleBackColor = true;
            this.createListBtn.Click += new System.EventHandler(this.createListBtn_Click);
            // 
            // listSizeTextBox
            // 
            this.listSizeTextBox.Location = new System.Drawing.Point(551, 170);
            this.listSizeTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listSizeTextBox.Name = "listSizeTextBox";
            this.listSizeTextBox.ReadOnly = true;
            this.listSizeTextBox.Size = new System.Drawing.Size(149, 38);
            this.listSizeTextBox.TabIndex = 5;
            this.listSizeTextBox.Text = "1";
            // 
            // listSizeScroll
            // 
            this.listSizeScroll.Location = new System.Drawing.Point(91, 170);
            this.listSizeScroll.Maximum = 20000;
            this.listSizeScroll.Minimum = 1;
            this.listSizeScroll.Name = "listSizeScroll";
            this.listSizeScroll.Size = new System.Drawing.Size(448, 114);
            this.listSizeScroll.TabIndex = 4;
            this.listSizeScroll.Value = 1;
            this.listSizeScroll.Scroll += new System.EventHandler(this.listSize_Scroll);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.totalTimeResultText);
            this.panel4.Controls.Add(this.movementResultText);
            this.panel4.Controls.Add(this.comparisonResultText);
            this.panel4.Controls.Add(this.sortResultText);
            this.panel4.Controls.Add(this.dataTypeResultText);
            this.panel4.Controls.Add(this.listSizeResultText);
            this.panel4.Controls.Add(this.totalTimeLabel);
            this.panel4.Controls.Add(this.movementsLabel);
            this.panel4.Controls.Add(this.comparisonsLabel);
            this.panel4.Controls.Add(this.sortLabel);
            this.panel4.Controls.Add(this.dataTypeLabel);
            this.panel4.Controls.Add(this.nLabel);
            this.panel4.Location = new System.Drawing.Point(632, 595);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(739, 326);
            this.panel4.TabIndex = 8;
            // 
            // totalTimeResultText
            // 
            this.totalTimeResultText.Location = new System.Drawing.Point(286, 250);
            this.totalTimeResultText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.totalTimeResultText.Name = "totalTimeResultText";
            this.totalTimeResultText.ReadOnly = true;
            this.totalTimeResultText.Size = new System.Drawing.Size(300, 38);
            this.totalTimeResultText.TabIndex = 12;
            // 
            // movementResultText
            // 
            this.movementResultText.Location = new System.Drawing.Point(286, 210);
            this.movementResultText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.movementResultText.Name = "movementResultText";
            this.movementResultText.ReadOnly = true;
            this.movementResultText.Size = new System.Drawing.Size(300, 38);
            this.movementResultText.TabIndex = 11;
            // 
            // comparisonResultText
            // 
            this.comparisonResultText.Location = new System.Drawing.Point(286, 170);
            this.comparisonResultText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comparisonResultText.Name = "comparisonResultText";
            this.comparisonResultText.ReadOnly = true;
            this.comparisonResultText.Size = new System.Drawing.Size(300, 38);
            this.comparisonResultText.TabIndex = 10;
            // 
            // sortResultText
            // 
            this.sortResultText.Location = new System.Drawing.Point(286, 130);
            this.sortResultText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sortResultText.Name = "sortResultText";
            this.sortResultText.ReadOnly = true;
            this.sortResultText.Size = new System.Drawing.Size(300, 38);
            this.sortResultText.TabIndex = 9;
            // 
            // dataTypeResultText
            // 
            this.dataTypeResultText.Location = new System.Drawing.Point(286, 90);
            this.dataTypeResultText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataTypeResultText.Name = "dataTypeResultText";
            this.dataTypeResultText.ReadOnly = true;
            this.dataTypeResultText.Size = new System.Drawing.Size(300, 38);
            this.dataTypeResultText.TabIndex = 8;
            // 
            // listSizeResultText
            // 
            this.listSizeResultText.Location = new System.Drawing.Point(286, 50);
            this.listSizeResultText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listSizeResultText.Name = "listSizeResultText";
            this.listSizeResultText.ReadOnly = true;
            this.listSizeResultText.Size = new System.Drawing.Size(300, 38);
            this.listSizeResultText.TabIndex = 7;
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(118, 250);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(157, 32);
            this.totalTimeLabel.TabIndex = 5;
            this.totalTimeLabel.Text = "Total Time:";
            // 
            // movementsLabel
            // 
            this.movementsLabel.AutoSize = true;
            this.movementsLabel.Location = new System.Drawing.Point(106, 210);
            this.movementsLabel.Name = "movementsLabel";
            this.movementsLabel.Size = new System.Drawing.Size(169, 32);
            this.movementsLabel.TabIndex = 4;
            this.movementsLabel.Text = "Movements:";
            // 
            // comparisonsLabel
            // 
            this.comparisonsLabel.AutoSize = true;
            this.comparisonsLabel.Location = new System.Drawing.Point(85, 170);
            this.comparisonsLabel.Name = "comparisonsLabel";
            this.comparisonsLabel.Size = new System.Drawing.Size(190, 32);
            this.comparisonsLabel.TabIndex = 3;
            this.comparisonsLabel.Text = "Comparisons:";
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(200, 130);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(75, 32);
            this.sortLabel.TabIndex = 2;
            this.sortLabel.Text = "Sort:";
            // 
            // dataTypeLabel
            // 
            this.dataTypeLabel.AutoSize = true;
            this.dataTypeLabel.Location = new System.Drawing.Point(129, 90);
            this.dataTypeLabel.Name = "dataTypeLabel";
            this.dataTypeLabel.Size = new System.Drawing.Size(146, 32);
            this.dataTypeLabel.TabIndex = 1;
            this.dataTypeLabel.Text = "DataType:";
            this.dataTypeLabel.Click += new System.EventHandler(this.dataTypeLabel_Click);
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(232, 50);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(43, 32);
            this.nLabel.TabIndex = 0;
            this.nLabel.Text = "N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(832, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Experimental Results";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 949);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSizeScroll)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox winAlgTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button quickBtn;
        private System.Windows.Forms.Button mergeBtn;
        private System.Windows.Forms.Button heapBtn;
        private System.Windows.Forms.Button radixBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar listSizeScroll;
        private System.Windows.Forms.Button createListBtn;
        private System.Windows.Forms.TextBox listSizeTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label movementsLabel;
        private System.Windows.Forms.Label comparisonsLabel;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Label dataTypeLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.TextBox totalTimeResultText;
        private System.Windows.Forms.TextBox movementResultText;
        private System.Windows.Forms.TextBox comparisonResultText;
        private System.Windows.Forms.TextBox sortResultText;
        private System.Windows.Forms.TextBox dataTypeResultText;
        private System.Windows.Forms.TextBox listSizeResultText;
        private System.Windows.Forms.CheckBox inOrderCheck;
        private System.Windows.Forms.CheckBox randomCheck;
        private System.Windows.Forms.CheckBox almostOrderCheck;
        private System.Windows.Forms.CheckBox reverseOrderCheck;
    }
}

