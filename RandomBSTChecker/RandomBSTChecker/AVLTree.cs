using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomBSTChecker {
    class AVLTree {

        AVLNode root = null;
        Random rand = new Random();
        List<string> corrections = new List<string>();
        public AVLTree(AVLNode root) {
            Console.WriteLine("Root is " + root.Value);
            this.root = root;
        }

        public void randInsert(AVLNode node) {

           

            AVLNode curNode = root;
            bool inserted = false;

            while (!inserted) {

                
                int goLeft = rand.Next(0, 101);

                if (goLeft <= 50) {

                    if(curNode.LeftChild == null) {
                        Console.WriteLine(node.Value + " inserted left of " + curNode.Value);
                        curNode.LeftChild = node;
                        inserted = true;
                    }
                    curNode = curNode.LeftChild;

                } else {

                    if (curNode.RightChild == null) {
                        Console.WriteLine(node.Value + " inserted right of " + curNode.Value);
                        curNode.RightChild = node;
                        inserted = true;
                    }
                    curNode = curNode.RightChild;

                }
            }
            
        }

        public void checkIfAVLTree() {

            checkSubTrees(root);

            for(int i = corrections.Count -1; i >= 0; i--) {
                Console.WriteLine(corrections[i]);
            }
        }

        public void checkSubTrees(AVLNode node) {

            if (node == null)
                return;
            bool correct = true;

            string text = node.Value + " is ";
            if(Math.Abs(getBalance(node)) > 1){
                text += "imbalanced with a balance of " + getBalance(node) + ", ";
                correct = false;
            }

            if(node.LeftChild != null) {
                if(node.LeftChild.Value > node.Value) {
                    text += "incorrect with left child value of " + node.LeftChild.Value + ", ";
                    correct = false;
                }
                checkSubTrees(node.LeftChild);
                
            }

            if(node.RightChild != null) {
                if (node.RightChild.Value <= node.Value) {
                    text += "incorrect with right child value of " + node.RightChild.Value + ", ";
                    correct = false;
                }
                checkSubTrees(node.RightChild);
               
            }

            if (correct) {
                text += "correct";
            }

            corrections.Add(text);
        }

        public int getBalance(AVLNode node) {

            return getHeight(node.LeftChild) - getHeight(node.RightChild);
        }

        public int getHeight(AVLNode node) {

            if (node == null) {
                return -1;
            }

            return Math.Max(getHeight(node.LeftChild), getHeight(node.RightChild)) + 1;

        }

       
    }

}
