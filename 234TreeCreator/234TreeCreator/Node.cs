using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _234TreeCreator {
    class Node {
        private int type;
        private int leftValue;
        private int midValue;
        private int rightValue;
        private Node leftChild = null;
        private Node rightChild = null;
        private Node midLeftChild = null; //Mid child if type 3
        private Node midRightChild = null;
        private Node parent = null;


        public int Type { get => type; set => type = value; }
        public int RightValue { get => rightValue; set => rightValue = value; }
        public int MidValue { get => midValue; set => midValue = value; }
        public int LeftValue { get => leftValue; set => leftValue = value; }
        public Node LeftChild { get => leftChild; set => leftChild = value; }
        public Node RightChild { get => rightChild; set => rightChild = value; }
        public Node MidLeftChild { get => midLeftChild; set => midLeftChild = value; }
        public Node MidRightChild { get => midRightChild; set => midRightChild = value; }
        internal Node Parent { get => parent; set => parent = value; }

        public Node(int val) {
            type = 2;
            leftValue = val;
        }

        public Boolean isLeaf() {
            if (leftChild == null && rightChild == null && midLeftChild == null && midRightChild == null) {
                return true;
            }
            return false;
        }

        public int insertValue(int val) {
            switch (type) {
                case 2:
                    type = 3;
                    if(val > leftValue) {           
                        rightValue = val;
                        return 1;
                    } else {
                        rightValue = leftValue;
                        leftValue = val;
                        return 0;
                    }
                    
                case 3:
                    type = 4;
                    if(val > rightValue) {
                        midValue = rightValue;
                        rightValue = val;
                        return 2;
                    }else if(val <= leftValue) {
                        midValue = leftValue;
                        leftValue = val;
                        return 0;
                    } else {
                        midValue = val;
                        return 1;
                    }
                    
            }
            return -1;
        }

        public string toString() {
            switch (type) {
                case 2:
                    return "Value: " + leftValue;
                case 3:
                    return "Left Value: " + leftValue + "  Right Value: " + rightValue;
                case 4:
                    return "Left Value: " + leftValue + " Mid Value: " + midValue +  " Right Value: " + rightValue;
                default:
                    return null;
            }
        }
    }
    
}
