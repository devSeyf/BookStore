namespace BookStore.Models.Repositories
{
    public class BookRepository : IBookstoreRepository<Book>
    {

        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book() { Id = 1, Title = "Book 1",  Description="bla1"},
                new Book() { Id = 2, Title = "Book 2", Description="bla2"},
                new Book() { Id = 3, Title = "Book 3",  Description="bla3"}
            };
        }
        public void Add(Book entity)
        {
            books.Add(entity);

        }

   

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b=> b.Id == id);
            return book;

        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public IList<Book> List()
        {
             return books;
        }

        public void Update(int id,Book newBook)
        {
            var book = Find(id);
            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.Author = newBook.Author;


        }
    }
}
