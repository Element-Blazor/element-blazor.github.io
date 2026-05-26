using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Element.Demo.Form
{
    public class ValidationFormBase : ElementComponentBase
    {
        protected ElForm demoForm;

        protected Activity model = new Activity
        {
            Area = Area.Bejing,
            Resource1 = Resource.Option1,
            Type = new List<string>()
        };

        protected string lastValidateMessage = "尚未触发";

        [Inject]
        Element.MessageBox MessageBox { get; set; }

        protected void Submit()
        {
            if (!demoForm.Validate())
            {
                return;
            }

            _ = MessageBox.AlertAsync(model.ToString());
        }

        protected void ValidateName()
        {
            demoForm.ValidateField(nameof(Activity.Name));
        }

        protected void ClearValidate()
        {
            demoForm.ClearValidate();
            lastValidateMessage = "已清除校验状态";
        }

        protected void Reset()
        {
            demoForm.ResetFields();
            lastValidateMessage = "已重置表单";
        }

        protected Task OnValidateAsync(FormValidateEventArgs args)
        {
            lastValidateMessage = $"{args.Prop}: {(args.IsValid ? "通过" : args.Message)}";
            return Task.CompletedTask;
        }
    }
}
