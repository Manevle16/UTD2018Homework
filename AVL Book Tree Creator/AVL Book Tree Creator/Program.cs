using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AVL_Book_Tree_Creator {
    class Program {

        static void Main(string[] args) {

            try {

                Console.Write("Enter name of file: ");
                string input = Console.ReadLine();
                StreamReader sr = new StreamReader("./" + input);
                string line = sr.ReadLine();
                AVLTree tree = new AVLTree();

                //Loops through text file and adds each line to AVLTree as a node
                while (line != null) {


                    //Parses each line of text file for values seperated by a space
                    int index = line.IndexOf(" ");
                    int isbn = Int32.Parse(line.Substring(0, index));

                    int index2 = line.IndexOf(" ", index + 1);
                    string title = line.Substring(index, index2 - index);

                    index = line.Length - 1;

                    string author = line.Substring(index2 + 1, index - index2);

                    AVLNode node = new AVLNode(isbn, title, author);
                    tree.insert(node);

                    line = sr.ReadLine();
                }



            } catch (Exception e) {

                Console.WriteLine("Exception: " + e);
            } finally {

            }
        }
    }
}
