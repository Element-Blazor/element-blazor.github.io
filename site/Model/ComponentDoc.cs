using System;
using System.Collections.Generic;

namespace Element.ClientRender.Model
{
    public class ComponentDoc
    {
        public string Slug { get; set; }
        public string ComponentName { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
        public string Route => "/" + Slug;
        public IReadOnlyList<DemoInfoModel> Demos { get; set; } = Array.Empty<DemoInfoModel>();
        public IReadOnlyList<ApiRow> Api { get; set; } = Array.Empty<ApiRow>();
    }
}
