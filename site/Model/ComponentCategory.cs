using System.Collections.Generic;

namespace Element.ClientRender.Model
{
    public class ComponentCategory
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IReadOnlyList<ComponentDoc> Components { get; set; }
    }
}
