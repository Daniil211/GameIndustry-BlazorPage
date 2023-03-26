using GameIndustry.Models;
using Microsoft.AspNetCore.Components;
using static GameIndustry.Shared.MainLayout;

namespace GameIndustry.Pages
{
    public partial class Counter
    {

        [Inject] 
        SingletonService singleton { get; set; }

        [Inject] 
        TrinsientService transient { get; set; }

        //[CascadingParameter(Name = "Color")]
        //public string Color { get; set; }

        //[CascadingParameter(Name = "Size")]
        //public string Size { get; set; }

        [CascadingParameter] public AppStyle Styles { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}
