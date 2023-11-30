namespace HW8.Ex3
{
    internal class NewsEventArgs : EventArgs
    {
        internal Categories Category;
        internal string News;

        public NewsEventArgs(Categories category, string news)
        {
            Category = category;
            News = news;
        }
    }
}
