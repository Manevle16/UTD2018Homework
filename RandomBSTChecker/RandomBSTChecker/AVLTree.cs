using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomBSTChecker {
    class AVLTree {

        AVLNode root = null;
        Random rand = new Random();
        bool isAVLTree = true;
        bool isBSTTree = true;

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
                        node.Parent = curNode;
                    }
                    curNode = curNode.LeftChild;

                } else {

                    if (curNode.RightChild == null) {
                        Console.WriteLine(node.Value + " inserted right of " + curNode.Value);
                        curNode.RightChild = node;
                        inserted = true;
                        node.Parent = curNode;
                    }
                    curNode = curNode.RightChild;

                }
            }
            
        }

        public void checkIfAVLTree() {


            if (checkIfBST(root)) {
                if (checkIfAVL(root)) {
                    Console.WriteLine("Is an AVL and BST tree");
                } else { 
                    Console.WriteLine("Is a BST tree but not an AVL tree");
                }
            } else {
                Console.WriteLine("Not an AVL or BST tree");                
            }
        }

        public bool checkIfBST(AVLNode node) {

            if(node.Parent != null) {
                if(!checkIfCorrectComparison(node, node.Value)) {
                    return false; 
                }
            }

            if (node.LeftChild != null && node.RightChild != null) {
                return checkIfBST(node.LeftChild) && checkIfBST(node.RightChild);
            }

            if (node.LeftChild != null) {
                return checkIfBST(node.LeftChild);
            }

            if(node.RightChild != null) {
                return checkIfBST(node.RightChild);
            }

            return true;
        }

        public bool checkIfCorrectComparison(AVLNode node, int val) {

            if (node.Parent == null)
                return true;

            if(node == node.Parent.LeftChild) {
                if(val <= node.Parent.Value) {
                    return checkIfCorrectComparison(node.Parent, val);
                } else {
                    return false;
                }
            } else {
                if (val > node.Parent.Value) {
                    return checkIfCorrectComparison(node.Parent, val);
                } else {
                    return false;
                }
            }
            
        }

        public bool checkIfAVL(AVLNode node) {


            //Use truth values to check if a AVL or BST tree, return if not BST
            if(Math.Abs(getBalance(node)) > 1){
                isAVLTree = false;
            }

            if(node.LeftChild != null && node.RightChild != null) {
                
                return checkIfAVL(node.LeftChild) && checkIfAVL(node.RightChild);
                
            }

            if (node.LeftChild != null) {

                return checkIfAVL(node.LeftChild);

            }

            if (node.RightChild != null) {
                
                return checkIfAVL(node.RightChild);
               
            }

            return true;

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
