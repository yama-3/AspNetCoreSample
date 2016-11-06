using System.Collections.Generic;

public interface IBookStoreRepository {
  IEnumerable<Book> GetAllBooks();
}