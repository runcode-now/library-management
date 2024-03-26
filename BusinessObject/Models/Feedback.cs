using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string? FeedbackContent { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public int? BookId { get; set; }

        public virtual Book? Book { get; set; }
    }
}
