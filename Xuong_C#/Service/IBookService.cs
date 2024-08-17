using Xuong_C_.Models;

namespace Xuong_C_.Service
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(Guid id);

    }
}
