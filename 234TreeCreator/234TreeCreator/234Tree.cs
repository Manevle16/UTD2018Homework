using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _234TreeCreator {
    class _234Tree {
        private Node root = null;
        
        public _234Tree() {}


        public void insertValue(int val) {
            if(root == null) {
                root = new Node(val);
                return;
            }
            Console.WriteLine("Root: " + root.toString());
            Node curNode = root;
            
            while (!curNode.isLeaf()) {
                curNode = findProperChildForValue(curNode, val);
            }

            if(curNode.Type == 4) {
                curNode = findProperChildForValue(curNode, val);
            }
            Console.WriteLine("Value " + val + " inserted into " + curNode.toString());
            Console.WriteLine(curNode.insertValue(val));
        }

        public Node findProperChildForValue(Node curNode, int val) {
            switch (curNode.Type) {
                case 2:
                    if (val <= curNode.LeftValue) {
                        return curNode.LeftChild;
                    } else {
                        return curNode.RightChild;
                    }
                case 3:
                    if (val <= curNode.LeftValue) {
                        return curNode.LeftChild;
                    } else if (val > curNode.RightValue) {
                        return curNode.RightChild;
                    } else {
                        return curNode.MidLeftChild;
                    }
                case 4:
                    return splitNode(curNode, val);
                default:
                    return null;
            }
        }

        public Node splitNode(Node curNode, int val) {
            Node nextChild = null;
            Node newLeftChild = new Node(curNode.LeftValue);
            Node newRightChild = new Node(curNode.RightValue);
            if (val <= curNode.MidValue) {
                nextChild = newLeftChild;
            } else {
                nextChild = newRightChild;
            }

            newLeftChild.LeftChild = curNode.LeftChild;
            newLeftChild.RightChild = curNode.MidLeftChild;
            if (curNode.LeftChild != null)
                curNode.LeftChild.Parent = newLeftChild;
            if (curNode.MidLeftChild != null)
                curNode.MidLeftChild.Parent = newLeftChild;

            newRightChild.LeftChild = curNode.MidRightChild;
            newRightChild.RightChild = curNode.RightChild;
            if (curNode.MidRightChild != null)
                curNode.MidRightChild.Parent = newRightChild;
            if (curNode.RightChild != null)
                curNode.RightChild.Parent = newRightChild;

            if (curNode.Parent == null) {
                curNode.Parent = new Node(curNode.MidValue);
                root = curNode.Parent;
                curNode.Parent.LeftChild = newLeftChild;            
                curNode.Parent.RightChild = newRightChild;
                newLeftChild.Parent = root;
                newRightChild.Parent = root;
                return nextChild;
            }

            int inserted = curNode.Parent.insertValue(curNode.MidValue);
            if (curNode.Parent.Type == 3) {
                if (inserted == 0) {
                    curNode.Parent.LeftChild = newLeftChild;
                    curNode.Parent.MidLeftChild = newRightChild;
                } else {
                    curNode.Parent.RightChild = newRightChild;
                    curNode.Parent.MidLeftChild = newLeftChild;
                }
            } else {
                if (inserted == 0) {
                    curNode.Parent.LeftChild = newLeftChild;
                    curNode.Parent.MidLeftChild = newRightChild;
                } else if (inserted == 1) {
                    curNode.Parent.MidLeftChild = newLeftChild;
                    curNode.Parent.MidRightChild = newRightChild;
                } else {
                    curNode.Parent.MidRightChild = newLeftChild;
                    curNode.Parent.RightChild = newRightChild;
                }
            }
            Console.WriteLine("Next Child: " + nextChild.toString());
            return nextChild;
        }
    }
}
