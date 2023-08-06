namespace ReaderExample.Reader
{
    internal class Page
    {
        public Page(uint number, string content, byte[] image = null)
        {
            Number = number;
            Content = content;
            Image = image;
        }

        public uint Number { get; }
        public string Content { get; }
        public byte[] Image { get; }
    }
}
