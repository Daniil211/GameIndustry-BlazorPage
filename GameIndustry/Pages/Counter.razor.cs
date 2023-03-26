using Microsoft.AspNetCore.Components;

namespace GameIndustry.Pages
{
    public partial class Counter
    {

        [Inject] SingletonService singleton { get; set; }

        [Inject] TrinsientService transient { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}
