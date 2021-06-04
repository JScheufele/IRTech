using System;
using System.Collections.Generic;

namespace MvcProject.Models
{
    public class StatusHistory
    {
        public DateTime? RequestDate{get; set; }

        public Status status{get; set; }

    }

    public class HistoryList
    {
        public virtual IEnumerable<StatusHistory> History{get; set; }
    }

}
