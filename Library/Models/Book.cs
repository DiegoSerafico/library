using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

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

    [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}")]
    public DateTime ReleaseDate { get; set; }

    public virtual ICollection<AuthorBook> JoinEntities { get; }
  }
}