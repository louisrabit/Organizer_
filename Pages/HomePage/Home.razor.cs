using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Collections.Generic;

namespace OrganizMyLife.Pages.HomePage  
{
    public partial class Home : ComponentBase
    {
        // Lista de s�ries de dados para o MudChart
        protected List<ChartSeries> Series { get; set; }

        // R�tulos do eixo X para o gr�fico
        protected string[] XAxisLabels = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        // Inje��o de navega��o
        [Inject]
        protected NavigationManager Navigation { get; set; }

      
        protected override void OnInitialized()
        {
            // Inicializa os dados do gr�fico ao carregar a p�gina
            Series = new List<ChartSeries>
            {
                new ChartSeries { Name = "Resolved Tickets", Data = new double[] { 5, 7, 10, 8, 12 } },
                new ChartSeries { Name = "Pending Tickets", Data = new double[] { 3, 5, 2, 7, 4 } }
            };
        }

        // M�todo chamado ao clicar no bot�o
        protected string Message { get; set; } = "Initial Message";

     

       
    }
}
