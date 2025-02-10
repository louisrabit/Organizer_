using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Collections.Generic;

namespace OrganizMyLife.Pages.Tasks  
{
    public partial class Users : ComponentBase
    {
        // Lista de séries de dados para o MudChart
        protected List<ChartSeries> Series { get; set; }

        // Rótulos do eixo X para o gráfico
        protected string[] XAxisLabels = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        // Injeção de navegação
        [Inject]
        protected NavigationManager Navigation { get; set; }


        protected override void OnInitialized()
        {
            // Inicializa os dados do gráfico ao carregar a página
            Series = new List<ChartSeries>
            {
                new ChartSeries { Name = "Resolved Tickets", Data = new double[] { 5, 7, 10, 8, 12 } },
                new ChartSeries { Name = "Pending Tickets", Data = new double[] { 3, 5, 2, 7, 4 } }
            };
        }

        // Método chamado ao clicar no botão
        protected string Message { get; set; } = "Initial Message";

        public void HandleClick()
        {
            Message = "Button Clicked!";
            Console.WriteLine("Button Clicked");
            Navigation.NavigateTo("/users");
        }
        public void Handle()
        {
            Navigation.NavigateTo("users");
         
        }
    }
}
