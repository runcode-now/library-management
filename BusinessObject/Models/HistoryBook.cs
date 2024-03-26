using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class HistoryBook
    {
        public int HistoryId { get; set; }
        public DateTime? HistoryBorrow { get; set; }
        public DateTime? HistoryReturn { get; set; }
        public DateTime? HistoryActual { get; set; }
        public string? HistoryStatus { get; set; }
        public int? BookId { get; set; }
        public int? AccountId { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Book? Book { get; set; }
    }
}
