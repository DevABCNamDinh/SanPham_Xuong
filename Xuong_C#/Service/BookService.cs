using Xuong_C_.Models;
using Xuong_C_.Repository;

namespace Xuong_C_.Service
{
    public class BookService : IBookService
    {
        private readonly  IGenericRepository<Book> _BookRepository;
        public BookService(IGenericRepository<Book> BookRepository)
        {
            _BookRepository = BookRepository;
        }
        public List<Book> GetAllBooks()
        {
            return _BookRepository.GetAll();
        }

        public Book GetBookById(Guid id)
        {
            return _BookRepository.GetById(id);
        }
    }
}
