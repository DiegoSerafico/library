using System.Collections.Generic;
using System;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.JoinEntities = new HashSet<AuthorBook>();
    }
    public int BookId { get; set; }
    public string Title { get; set; }

    public string Genre { get; set; }

    public DateTime ReleaseDate { get; set; }

    public virtual ICollection<AuthorBook> JoinEntities { get; }
  }
}