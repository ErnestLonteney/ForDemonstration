namespace ReaderExample.Reader
{
    class Book
    {      
        public Book(
            string title, 
            string author, 
            ushort countOfPages, 
            string[] text, 
            string imagePath = null)
        {
            Title = title;
            Author = author;
            pages = new Page[countOfPages];
            CountOfPages = countOfPages;   
            Image = imagePath;
            Fill(text);
        }        

        public uint CountOfPages { get; }
        public string Title  { get; }
        public string Author { get; }
        public Page CurrentPage { get; private set; }      
        public string Image { get; set; }

        private readonly Page[] pages;

        public void Open()
        {
           CurrentPage = pages[0];
        }

        public Page GoToNextPage()
        {
            if (CurrentPage == null)
                CurrentPage = pages[0]; 

            if (CurrentPage.Number != pages.Length && pages[CurrentPage.Number] != null)
                CurrentPage = pages[CurrentPage.Number];
           
            return CurrentPage;
        }

        public Page GoToPriviousPage()
        {
            if (CurrentPage == null)
                CurrentPage = pages[0];

            if (CurrentPage.Number != 1)
                CurrentPage = pages[CurrentPage.Number - 2];

            return CurrentPage;
        }

        private void Fill(string[] text)
        {
            for (int i = 0; i < text.Length; i++)
                pages[i] = new Page((uint)(i + 1), text[i]);
        }
    }
}
