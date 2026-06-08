using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BookExample
{
    class Book : IEnumerable<Page>, IEnumerator<Page>
    {
        private int currentPageIndex = -1;

        private readonly Page[] pages;

        public required string Author { get; init; }

        public required string Title { get; init; }

        public required string? Description { get; set; }

        public int PagesCount { get; }

        Page IEnumerator<Page>.Current => throw new NotImplementedException();

        public object Current => throw new NotImplementedException();

        public Book(params Page[] pages)
        {
            PagesCount = pages.Length;
            this.pages = pages;
        }

        public IEnumerator<Page> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
