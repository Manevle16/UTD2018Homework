using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Book_Tree_Creator {

    class AVLTree{

        private AVLNode root = null;

        public AVLTree(){}

        public void insert(AVLNode node) {

            //Go down BST and insert the node         
            node.Height = 0;
            node.Balance = 0;

            if (root == null) {
                root = node;
                return;
            } else {          
                AVLNode curNode = root;

                bool nodeInserted = false;

                //Loop until inserted setting curNode to the inserted node
                while (nodeInserted == false) {
                    if(node.Key <= curNode.Key) {
                        if(curNode.LeftChild == null) {
                            curNode.setLeftChild(node);
                            nodeInserted = true;
                        }
                        curNode = curNode.LeftChild;                 
                    } else {
                        if (curNode.RightChild == null) {
                            curNode.setRightChild(node);
                            nodeInserted = true;
                        }
                        curNode = curNode.RightChild;
                    }
                }

                //Recursively go back up the tree and check and set the balances and heights of nodes
                setAndCheckBalanceAndHeights(curNode);
            }
           
        }

        public void setAndCheckBalanceAndHeights(AVLNode curNode) {

            int insertedKey = curNode.Key;

            //Cycle through all the nodes until the root is reached
            while (curNode.Parent != null) {


                AVLNode parent = curNode.Parent;
                curNode = curNode.Parent;


                //Set balance and height of current node's parent
                setBalanceAndHeight(parent);
                //Check for imbalance
                if (Math.Abs(parent.Balance) > 1) {

                    Console.Write("Imbalance occured at inserting ISBN " + insertedKey + ";");
                    //Check if left imbalance, else right imbalance
                    if (parent.Balance > 1) {

                        AVLNode leftChild = parent.LeftChild;

                        //Check if left subtree heavy, else right subtree heavy
                        if (leftChild.Balance > 0) {

                            Console.WriteLine("fixed in right rotation");
                            AVLNode temp = leftChild.RightChild;

                            leftChild.takeParent(parent);
                            leftChild.setRightChild(parent);                           
                            parent.setLeftChild(temp);

                            setBalanceAndHeight(parent);
                            setBalanceAndHeight(temp);
                            setBalanceAndHeight(leftChild);

                            if (parent == root)
                                root = leftChild;
                            curNode = leftChild;
                        } else {
                            
                            Console.WriteLine("fixed in left right rotation");
                            AVLNode leftRightChild = leftChild.RightChild;
                            AVLNode temp = leftRightChild.LeftChild;

                            leftRightChild.takeParent(leftChild);
                            leftRightChild.setLeftChild(leftChild);
                            leftRightChild.LeftChild.setRightChild(temp);

                            setBalanceAndHeight(temp);
                            setBalanceAndHeight(leftChild);

                            temp = leftRightChild.RightChild;
                            leftRightChild.takeParent(parent);
                            leftRightChild.setRightChild(parent);
                            parent.setLeftChild(temp);

                            setBalanceAndHeight(temp);
                            setBalanceAndHeight(parent);
                            setBalanceAndHeight(leftRightChild);

                            if (parent == root)
                                root = leftRightChild;

                            curNode = leftRightChild;
                        }

                    } else {

                        AVLNode rightChild = parent.RightChild;

                        //Check if left subtree heavy, else right subtree heavy
                        if (rightChild.Balance > 0) {

                            Console.WriteLine("fixed in right left rotation");
                            AVLNode rightLeftChild = rightChild.LeftChild;
                            AVLNode temp = rightLeftChild.RightChild;

                            rightLeftChild.takeParent(rightChild);
                            rightLeftChild.setRightChild(rightChild);
                            rightLeftChild.RightChild.setLeftChild(temp);                          

                            setBalanceAndHeight(temp);
                            setBalanceAndHeight(rightChild);

                            temp = rightLeftChild.LeftChild;
                            rightLeftChild.takeParent(parent);
                            rightLeftChild.setLeftChild(parent);
                            parent.setRightChild(temp);

                            setBalanceAndHeight(temp);
                            setBalanceAndHeight(parent);
                            setBalanceAndHeight(rightLeftChild);

                            if (parent == root)
                                root = rightLeftChild;

                            curNode = rightLeftChild;

                        } else {

                            Console.WriteLine("fixed in left rotation");
                            AVLNode temp = rightChild.LeftChild;

                            rightChild.takeParent(parent);
                            rightChild.setLeftChild(parent);
                            parent.setRightChild(temp);

                            setBalanceAndHeight(parent);
                            setBalanceAndHeight(temp);
                            setBalanceAndHeight(rightChild);

                            if (parent == root)
                                root = rightChild;

                            curNode = rightChild;

                        }

                    }
                }

               
            }
        }

        public void setBalanceAndHeight(AVLNode node) {
            if (node == null)
                return;

            if (node.LeftChild != null)
                node.LeftChild.Height = calcHeight(node.LeftChild);

            if (node.RightChild != null)
                node.RightChild.Height = calcHeight(node.RightChild);

            node.Height = calcHeight(node);
            node.calcAndSetBalance();
        }

        public int calcHeight(AVLNode node) {
            
            if(node == null) {
                return -1;
            }

            return Math.Max(calcHeight(node.LeftChild), calcHeight(node.RightChild)) + 1;
        }
     
    }
}
