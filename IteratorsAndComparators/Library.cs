﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        private int current;

        public Library(params Book[] book)
        {
            books = book.ToList();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books=new List<Book> (books);
            }
            public void Dispose(){}
            public bool MoveNext()=>
                ++this.currentIndex < books.Count;
            public Book Current => this.books[currentIndex];

            object IEnumerator.Current => this.Current;
            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}
