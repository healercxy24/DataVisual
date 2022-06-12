// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DataVisual.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\_Imports.razor"
using DataVisual;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\_Imports.razor"
using DataVisual.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD004_RUL_show.razor"
using DataVisual.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fd004/rul/show")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fd004/rul/show/{Id}")]
    public partial class FD004_RUL_show : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD004_RUL_show.razor"
       
    [Parameter]
    public string? Id { get; set; }

    private List<FD4RUL> fd4ruls;

    private FD4RUL fd4rul_single;  // for only a single record

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        if (Id == null)
        {
            fd4ruls = await fd4service.GetFD4RUL();
        }
        else
        {
            fd4rul_single = await fd4service.GetSingleFD4RUL(Convert.ToInt32(Id));
        }
    }

    void EditRUL(int Id)
    {
        
    }

    void Return()
    {
        NavigationManager.NavigateTo("/fd004/rul");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FD004Service fd4service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591