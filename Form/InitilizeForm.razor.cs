

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Element;

namespace Element.Demo.Form
{
    public partial class InitilizeForm : ElementComponentBase
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

            var activity = demoForm.GetValue<Activity>();
            _ = MessageBox.AlertAsync(activity.ToString());
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            value = new Activity()
            {
                Resource1 = Resource.Option2,
                Area = Area.Shanghai,
                Delivery = true,
                Description = "œÍ«È",
                Name = "≤‚ ‘",
                Resource = "≥°µÿ",
                Time = DateTime.Now,
                Type = new List<string>()
                 {
                     "Offline","Online"
                 }
            };
        }

        protected void Reset()
        {
            demoForm.Reset();
        }
    }
}
