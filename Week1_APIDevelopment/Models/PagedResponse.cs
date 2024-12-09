using System.Collections.Generic;

namespace Week1_APIDevelopment
{
    public class PagedResponse<T>
    {
        public int TotalItems { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public List<T> Items { get; set; }
    }
}

