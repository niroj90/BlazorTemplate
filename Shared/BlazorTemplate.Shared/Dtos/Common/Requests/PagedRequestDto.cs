using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTemplate.Shared.Dtos.Common.Requests
{
    public class PagedRequestDto
    {
        public string? SearchTerm { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
