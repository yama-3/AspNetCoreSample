using System;
using System.Collections.Generic;

public class BookStoreRepository : IBookStoreRepository {
  BookStoreContext _context;

  public BookStoreRepository(BookStoreContext context) {
    _context = context;
  }

  public IEnumerable<Book> GetAllBooks() {
    return _context.Books;
  }
}

