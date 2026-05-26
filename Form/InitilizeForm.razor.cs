using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

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
                Description = "详情",
                Name = "测试",
                Resource = "场地",
                Time = DateTime.Today,
                Type = new List<string>
                {
                    "Offline",
                    "Online"
                }
            };
        }

        protected void Reset()
        {
            demoForm.Reset();
        }
    }
}
