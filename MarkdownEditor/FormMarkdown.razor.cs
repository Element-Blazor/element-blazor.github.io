using Element;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Element.Demo.MarkdownEditor
{
    public partial class FormMarkdown : ElementComponentBase
    {
        internal ElForm form;

        internal ArticleModel article;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            article = new ArticleModel()
            {
                Title = "≤‚ ‘",
                Content = "# ≤‚ ‘"
            };
        }

        protected void Submit()
        {
            if (!form.IsValid())
            {
                return;
            }
            Alert(form.GetValue<ArticleModel>().Content);
        }
    }
}
