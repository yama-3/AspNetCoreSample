using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class BooksController : Controller
{
  [Route("api/books")]
  public IEnumerable<string> Get() {
    return new List<string> () {"kazuhiro", "yamabe"};
  }
}