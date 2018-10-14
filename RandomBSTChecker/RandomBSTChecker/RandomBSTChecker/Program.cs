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

            int numOfNodes = rand.Next(4, 20);
            randAVLTree = new AVLTree(new AVLNode(rand.Next(0, 200)));

            for (int i = 1; i < numOfNodes; i++) {


                AVLNode node = new AVLNode(rand.Next(0, 200));
                randAVLTree.randInsert(node);

            }
            Console.WriteLine();
            randAVLTree.checkIfAVLTree();

            
        }

       
    }
}
