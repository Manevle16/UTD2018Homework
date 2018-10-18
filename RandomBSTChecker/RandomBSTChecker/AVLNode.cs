using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomBSTChecker {
    class AVLNode {

        private int value;
        private AVLNode leftChild = null;
        private AVLNode rightChild = null;
        private AVLNode parent = null;

        public AVLNode(int val) {
            value = val;
        }

        public int Value { get => value; set => this.value = value; }
        public AVLNode LeftChild { get => leftChild; set => leftChild = value; }
        public AVLNode RightChild { get => rightChild; set => rightChild = value; }
        internal AVLNode Parent { get => parent; set => parent = value; }
    }
}
