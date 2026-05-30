using Element;
using Element.ClientRender.Model;
using Element.Demo.Button;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Element.ClientRender.Pages
{
    public class PageBase : ComponentBase
    {
        protected ComponentDoc currentDoc;
        protected IList<DemoModel> demos;

        [Inject]
        protected IJSRuntime jSRuntime { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            var route = new Uri(NavigationManager.Uri).LocalPath.Trim('/');
            demos = LoadDemos(route);

            foreach (var item in demos)
            {
                item.Demo = typeof(SimpleButton).Assembly.GetType(item.Type);
            }
        }

        private IList<DemoModel> LoadDemos(string name)
        {
            currentDoc = ComponentDocCatalog.Find(name);
            if (currentDoc == null)
            {
                return new List<DemoModel>();
            }

            return currentDoc.Demos.Select(item =>
            {
                var fileName = item.Files.FirstOrDefault();
                return new DemoModel
                {
                    Type = "Element.Demo." + item.Name + "." + fileName.Replace(".razor", string.Empty),
                    Title = item.Title,
                    Description = item.Description,
                    Code = item.Code,
                    FileName = fileName
                };
            }).ToList();
        }

        protected async Task TabCode_OnRenderCompleteAsync(object tab)
        {
            await jSRuntime.InvokeVoidAsync("renderHightlight", ((ElTabPane)tab).TabContainer.Content);
        }
    }
}
