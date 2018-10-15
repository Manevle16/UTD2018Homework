using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Book_Tree_Creator {
    class Book {
        private int isbn;
        private string author;
        private string title;

        public Book(int isbn, string author, string title) {
            this.isbn = isbn;
            this.author = author;
            this.title = title;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int Isbn { get => isbn; set => isbn = value; }
    }
}
