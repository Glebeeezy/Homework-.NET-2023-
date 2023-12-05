namespace HW8.Ex3
{
    internal class NewsProvider
    {
        internal bool newsUpdated;

        internal event EventHandler<NewsEventArgs> NewsUpdated;

        internal void News(Categories categorie)
        {
            Console.WriteLine("Выберите категорию для новости: 1- Новости, 2- Погода, 3- Спорт, 4- Проишествия, 5- Юмор");
            Categories category;
            Enum.TryParse(Console.ReadLine(), out category);
            Console.WriteLine("Напишите новость");
            string news = Console.ReadLine();
            NewsEventArgs newsUpdateEventArgs = new NewsEventArgs(category, news);
            if (newsUpdateEventArgs.Category == categorie)
            {
                IsUpdateNews(this, newsUpdateEventArgs);
            }
        }
        private void IsUpdateNews(object sender, NewsEventArgs args)
        {
            newsUpdated = true;
            NewsUpdated?.Invoke(this, args);
        }
    }
}
