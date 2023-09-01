using Microsoft.AspNetCore.Components;

namespace DataBining.Client.BaseComponents

{
    public class DateComponentBase : ComponentBase
    {

        public DateTime dateTime { get; set; }

        protected override void OnInitialized()
        {
            dateTime = DateTime.Now;
            base.OnInitialized();
        }
    }
}
