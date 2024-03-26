using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Account
    {
        public Account()
        {
            HistoryBooks = new HashSet<HistoryBook>();
        }

        public int AccountId { get; set; }
        public string? AccountUsername { get; set; }
        public string? AccountPassword { get; set; }
        public string? AccountName { get; set; }
        public string? AccountSex { get; set; }
        public string? AccountEmail { get; set; }
        public byte[]? AccountAvatar { get; set; }
        public DateTime? AccountDob { get; set; }
        public string? AccountPhone { get; set; }
        public int? AccountRole { get; set; }

        public virtual ICollection<HistoryBook> HistoryBooks { get; set; }
    }
}
