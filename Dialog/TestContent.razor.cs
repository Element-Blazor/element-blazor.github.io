
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Element;
using System.Threading.Tasks;

namespace Element.Demo.Dialog
{
    public partial class TestContent : ElementDialogBase
    {
        [Parameter]
        public string Name { get; set; }
    }
}
