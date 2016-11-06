using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class BooksController : Controller
{
  private IBookStoreRepository _repository;

  public BooksController(IBookStoreRepository repository) {
    this._repository = repository;
  }

  [Route("api/books")]
  public IEnumerable<Book> Get() {
    return this._repository.GetAllBooks();
  }
}