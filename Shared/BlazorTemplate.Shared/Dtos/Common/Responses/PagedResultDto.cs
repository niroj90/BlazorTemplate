using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTemplate.Shared.Dtos.Common.Responses
{
    public class PagedResultDto<T> where T : class
    {
        public int TotalRecordCount { get; set; }
        public List<T> Items { get; set; } = new List<T>();
    }
}
