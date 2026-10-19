using System.Collections;

namespace MicrosoftIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pages = new Page[]
            {
                new Page { Number = 1, Content = "Page 1 content" },
                new Page { Number = 2, Content = "Page 2 content" },
                new Page { Number = 3, Content = "Page 3 content" }
            };

            var book = new Book(pages)
            {
                Author = "John Doe",
                Title = "Sample Book"
            };

            IEnumerator<Page> enumerator = book.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Page currentPage = enumerator.Current;
                Console.WriteLine($"Page {currentPage.Number}: {currentPage.Content}");
            }

            enumerator.Reset();

            while (enumerator.MoveNext())
            {
                Page currentPage = enumerator.Current;
                Console.WriteLine($"Page {currentPage.Number}: {currentPage.Content}");
            }

            foreach (Page page in book)
            {
                Console.WriteLine($"Page {page.Number}: {page.Content}");
            }

            foreach (Page page in book)
            {
                Console.WriteLine($"Page {page.Number}: {page.Content}");
            }
        }
    }
}
