
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Element;

namespace Element.Demo.Dialog
{
    public partial class ExampleDialog : ElementDialogBase
    {
        [Inject]
        Element.MessageBox MessageService { get; set; }
        public async Task ShowDialog(MouseEventArgs eventArgs)
        {
            var result = await DialogService.ShowDialogAsync<ExampleDialog>("²âÊÔ´°¿Ú");
        }

        public async Task ShowMessage(MouseEventArgs eventArgs)
        {
            await MessageService.AlertAsync("ÏûÏ¢");
        }
    }
}
