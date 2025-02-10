using Microsoft.AspNetCore.Components;
using MudBlazor;
using OrganizMyLife.Classes;
using OrganizMyLife.Dialogs;
using System.Collections.Generic;

namespace OrganizMyLife.Pages.Tasks  
{
    public partial class Work : ComponentBase
    {
        private List<Task_Classes> tasks = new();

        private async Task OpenDialogAsync()
        {
            var parameters = new DialogParameters
        {
            { "OnTaskAdded", EventCallback.Factory.Create<Task_Classes>(this, HandleTaskAdded) }
        };

            var options = new DialogOptions { NoHeader = true, CloseButton = false, MaxWidth = MaxWidth.Large, FullWidth = true };

            await DialogService.ShowAsync<MudDialogTask>("New Task", parameters, options);
        }

        private void HandleTaskAdded(Task_Classes newTask)
        {
            newTask.Id = tasks.Count + 1;
            tasks.Add(newTask);
            StateHasChanged();
        }




    }
}
