namespace HW8.Ex3
{
    internal class Client
    {
        private readonly NewsProvider _newsProvider;
        internal Categories categorie;

        public Client(NewsProvider newsProvider)
        {
            Console.WriteLine("Выберите категорию для подписки: 1- Новости, 2- Погода, 3- Спорт, 4- Проишествия, 5- Юмор");
            Enum.TryParse(Console.ReadLine(), out Categories category);
            categorie = category;
            _newsProvider = newsProvider;
            _newsProvider.NewsUpdated += NewsProviderNews;
        }
        internal void Unfollow(NewsProvider newsProvider)
        {
            _newsProvider.NewsUpdated -= NewsProviderNews;
        }
        internal bool IsNewsUpdated()
        {
            return _newsProvider.newsUpdated;
        }
        internal void Notification(string News)
        {
            Console.WriteLine($"Уведомление! {News}");
        }
        private void NewsProviderNews(object sender, NewsEventArgs args)
        {
            Notification(args.News);
        }
    }
}
