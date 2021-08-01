using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.ComponentsLibrary
{
    public class ProfilePictureBase : ComponentBase
    {
        protected string CssClass { get; set; } = "circle";

        protected void PictureClick()
        {
            CssClass = CssClass == "circle" ? null : "circle";
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
