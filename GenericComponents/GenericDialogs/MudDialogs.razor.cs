using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Collections.Generic;

namespace OrganizMyLife.GenericComponents.GenericDialogs
{
    public partial class MudDialogs : ComponentBase
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public EventCallback OnSubmit { get; set; }
        [Parameter] public EventCallback OnCancel { get; set; }
        [Parameter] public string OkText { get; set; } = "OK";
        [Parameter] public string CancelText { get; set; } = "Cancel";
        [Parameter] public bool ShowCancelButton { get; set; } = true;

        private async Task Submit()
        {
            await OnSubmit.InvokeAsync();
        }

        private async Task Cancel()
        {
            await OnCancel.InvokeAsync();
        }

    }
}

