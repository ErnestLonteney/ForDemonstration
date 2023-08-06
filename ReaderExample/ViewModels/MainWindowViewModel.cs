using DevExpress.Mvvm;
using ReaderExample.Reader;
using System.Threading.Tasks;

namespace ReaderExample.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public IAsyncCommand PrivousPageCommand { get; set; }
        public IAsyncCommand NextPageCommand { get; set; }

        public MainWindowViewModel(Book book)
        {
            Book = book;
            Book.Open();
            Text = Book.CurrentPage.Content;
            PageNumber = Book.CurrentPage.Number;

            PrivousPageCommand = new AsyncCommand(PriviusPageCommandExecute, CanPriviusPageCommandExecute);
            NextPageCommand = new AsyncCommand(NextPageCommandExecute, CanNextPageCommandExecute);
        }

        private Book book;
        private string text;
        private uint pageNumber;

        public Book Book
        {
            get => book;
            set
            {
                book = value;
                RaisePropertyChanged(nameof(Book));
            }
        }

        public string Text
        {
            get => text;
            set
            {
                text = value;
                RaisePropertyChanged(nameof(Text));
            }
        }

        public uint PageNumber
        {
            get => pageNumber;
            set
            {
                pageNumber = value;
                RaisePropertyChanged(nameof(PageNumber));
            }
        }

        #region Commands
        private Task NextPageCommandExecute()
        {
            Text = Book.GoToNextPage().Content;
            PageNumber = Book.CurrentPage.Number;

            return Task.CompletedTask;
        }

        private Task PriviusPageCommandExecute()
        {
            Text = Book.GoToPriviousPage().Content;
            PageNumber = Book.CurrentPage.Number;

            return Task.CompletedTask;
        }

        private bool CanPriviusPageCommandExecute() => Book.CurrentPage.Number != 1;
        private bool CanNextPageCommandExecute() => Book.CurrentPage.Number != Book.CountOfPages;
        #endregion
    }
}
