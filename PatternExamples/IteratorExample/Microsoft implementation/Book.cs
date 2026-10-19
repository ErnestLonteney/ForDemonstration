using System.Collections;

namespace MicrosoftIterator
{
    internal class Book : IEnumerable<Page>
    {
        private Page[] _pages;

        public Book(Page[] pages)
        {
            _pages = pages;
        }


        public required string Author { get; init; }

        public required string Title { get; init; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BookEnumerator(this);
        }

        public IEnumerator<Page> GetEnumerator()
        {
            return new BookEnumerator(this);
        }


        private struct BookEnumerator : IEnumerator<Page>
        {
            private int _position = -1;

            private readonly Book book;

            public BookEnumerator(Book book)
            {
                this.book = book;
            }

            object IEnumerator.Current => book._pages[_position]; // GetCurrent()

            public Page Current => book._pages[_position]; // GetCurrent()

            public bool MoveNext() // Next() + IsDone()
            {
                _position++;
                return _position < book._pages.Length;
            }

            public void Reset() 
            {
                this._position = -1;
            }

            public void Dispose()
            {
                // No resources to dispose
            }
        }
    }
}
