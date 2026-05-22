

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Element;

namespace Element.Demo.Form
{
    public partial class AutoGenerateFieldsInitilizeForm : ElementComponentBase
    {
        internal LabelAlign formAlign;
        [Inject]
        Element.MessageBox MessageBox { get; set; }

        internal object value;
        protected ElForm demoForm;
        protected void Submit()
        {
            if (!demoForm.IsValid())
            {
                return;
            }

            var activity = demoForm.GetValue<AutoGenerateFieldsActvity>();
            _ = MessageBox.AlertAsync(activity.ToString());
        }

        protected override void OnInitialized()
        {
            value = new AutoGenerateFieldsActvity()
            {
                Area = Area.Shanghai,
                Delivery = true,
                Description = "œÍ«È",
                Name = "≤‚ ‘",
                Resource = "≥°µÿ",
                Time = DateTime.Now
            };
        }

        protected void Reset()
        {
            demoForm.Reset();
        }
    }
}
