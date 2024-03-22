using TheBookstore.Models;

namespace TheBookstore.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
