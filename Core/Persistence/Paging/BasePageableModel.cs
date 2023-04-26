using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Paging
{
    public class BasePageableModel
    {
        public int PageNumber { get; set; } // stands for index
        public int PageSize { get; set; } // stands for size
        public int TotalPages { get; set; } // stands for pages
        public int TotalRecords { get; set; } // stands for count
        public bool HasPreviousPage { get; }
        public bool HasNextPage { get; }
    }
}
