using Microsoft.AspNetCore.Components;
using MudBlazor;
using OrganizMyLife.Classes;
using OrganizMyLife.GenericComponents.GenericDialogs;
using OrganizMyLife.Pages.Tasks;
using System.Collections.Generic;

namespace OrganizMyLife.Dialogs
{
    public partial class MudDialogTask : ComponentBase
    {

        private Task_Classes taskItem = new Task_Classes();

        [CascadingParameter] MudBlazor.IMudDialogInstance MudDialog { get; set; }

        [Parameter] public EventCallback<Task_Classes> OnTaskAdded { get; set; }

        private async Task HandleSubmit()
        {
            MudDialog.Close();
            await OnTaskAdded.InvokeAsync(taskItem);
        }

        private void HandleCancel()
        {
            MudDialog.Close();
        }



    }
}

