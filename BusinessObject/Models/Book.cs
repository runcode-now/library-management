using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Book
    {
        public Book()
        {
            Feedbacks = new HashSet<Feedback>();
            HistoryBooks = new HashSet<HistoryBook>();
        }

        public int BookId { get; set; }
        public string? BookTitle { get; set; }
        public byte[]? BookImage { get; set; }
        public string? BookAuthor { get; set; }
        public string? BookStatus { get; set; }
        public int? BookQuantity { get; set; }
        public int? BookBorrowed { get; set; }
        public string? BookPublisher { get; set; }
        public int? CategoryId { get; set; }
        public string? BookDescription { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<HistoryBook> HistoryBooks { get; set; }
    }
}
