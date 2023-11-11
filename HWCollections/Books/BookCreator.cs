using Bogus;

namespace HWCollections.Books
{
    public sealed class BookCreator
    {
        private Book _book;

        private Faker _faker = new Faker("ru");

        private Random _random = new Random();

        private readonly DateTime _start = new DateTime(year: 1990, 4, 10);

        private readonly DateTime _end = new DateTime(year: 2010, 4, 10);

        public Book GetBook()
        {
            _book = new Book();
            GetBookName();
            GetTime();
            return _book;
        }

        private void GetBookName()
        {
            _book.bookName = _faker.Lorem.Random.Words(_random.Next(1, 10));
        }

        private void GetTime()
        {
            _book.dateOfBookCreation = _faker.Date.Between(_start, _end);
        }
    }
}
