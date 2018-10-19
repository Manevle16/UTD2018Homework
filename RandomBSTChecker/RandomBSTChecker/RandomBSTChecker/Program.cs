using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomBSTChecker {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            AVLTree randAVLTree;

            //Randomly decides number of nudes to be made
            int numOfNodes = rand.Next(4, 20);

            //Initializes tree with a node with randomly generated key
            randAVLTree = new AVLTree(new AVLNode(rand.Next(0, 200)));

            //Inserts nodes with randomly generated keys into tree
            for (int i = 1; i < numOfNodes; i++) {


                AVLNode node = new AVLNode(rand.Next(0, 200));
                randAVLTree.randInsert(node);

            }
            Console.WriteLine();
            
            //Prints all issues found in randomly generated tree
            randAVLTree.checkIfAVLTree();

            
        }

       
    }
}
