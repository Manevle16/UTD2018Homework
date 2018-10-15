﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Book_Tree_Creator {

    class AVLNode{

        private int key;
        private int balance;
        private int height;
        private Book book;
        private AVLNode leftChild = null;
        private AVLNode rightChild = null;
        private AVLNode parent = null;

        public AVLNode(int isbn, string title, string author){

            key = isbn;
            book = new Book(isbn, title, author);
            
        }

        //setters and mutators
        

        public int Balance { get { return balance; } set { balance = value; } }

        public int Height { get { return height; } set { height = value; } }

        public AVLNode LeftChild { get { return leftChild; } }

        public AVLNode RightChild { get { return rightChild; } }

        public AVLNode Parent { get { return parent; } set { parent = value; } }

        public int Key { get => key; set => key = value; }

        public void setLeftChild(AVLNode leftChild) {
            if (leftChild == null) {
                this.leftChild = null;
                return;
            }

           
            this.leftChild = leftChild;
            leftChild.parent = this;
        }

        public void setRightChild(AVLNode rightChild) {
            if(rightChild == null) {
                this.rightChild = null;
                return;
            }

          
            this.rightChild = rightChild;
            rightChild.parent = this;
        }

        public void calcAndSetBalance() {
            int leftHeight, rightHeight;
            AVLNode leftChild = this.leftChild, rightChild = this.rightChild;

            if (leftChild == null) {
                leftHeight = -1;
            } else {
                leftHeight = leftChild.Height;
            }

            if (rightChild == null) {
                rightHeight = -1;
            } else {
                rightHeight = rightChild.Height;
            }

            this.balance = leftHeight - rightHeight;
            return;

        }

      
        public string toString() {
            string text = "Isbn: " + key + " Height: " + height + " Balance: " + balance;

            if(rightChild != null) {
                text += " Right: " + rightChild.Key;
            }

            if(leftChild != null) {
                text += " Left: " + leftChild.Key;
            }

           if(parent != null) {
                text += " Parent: " + parent.Key;
            }

            return text;
        }

        public void takeParent(AVLNode node) {

            if(node.Parent == null) {
                this.parent = null;
                return;
            }

            if(node.Parent.LeftChild == node) {
                this.parent = node.Parent;
                parent.setLeftChild(this);

            } else {
                this.parent = node.Parent;
                parent.setRightChild(this);
            }
            return;
        }
    }
}
