using Microsoft.AspNetCore.Components;

namespace TestAzureClientWebApp.Components.Pages
{
    public partial class Home
    {
        [Inject] private ILogger<Home> logger {  get; set; }

        protected override async  Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender) // only run the first time the component renders
            {
                Console.WriteLine(" OnAfterRenderAsync triggered!");
                logger.LogInformation("Home component rendered at {time}", DateTime.UtcNow);
            }
        }

        protected override Task OnInitializedAsync()
        {
            Console.WriteLine(" OnInitializedAsync triggered!");
            logger.LogInformation("Home component rendered at {time}", DateTime.UtcNow);
            return base.OnInitializedAsync();
        }
    }
}
