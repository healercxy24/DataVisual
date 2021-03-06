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
#line 3 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
using DataVisual.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fd001/rul/edit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fd001/rul/edit/{Id}")]
    public partial class FD001_RUL_edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
       
    [Parameter]
    public string? Id { get; set; }

    private int RUL;

    string btnText = string.Empty;

    FD1RUL rul = new FD1RUL();

    protected override async Task OnInitializedAsync()
    {
        btnText = Id == null ? "Create a new record" : "Update the record";
    }

    protected override async Task OnParametersSetAsync()
    {
        if(Id != null)
        {
            rul = await fd1service.GetSingleFD1RUL(Convert.ToInt32(Id));
        }
    }

    async Task HandleSubmit()
    {
        if (Id == null)
        {
            await CreateRUL(rul);
        }
        else
        {
            await UpdateRUL(rul);
        }
    }

    public async Task CreateRUL(FD1RUL rul)
    {
        var result = await fd1service.CreateFD1RUL(rul);
        NavigationManager.NavigateTo("/fd001/rul");
    }

    public async Task UpdateRUL(FD1RUL rul)
    {
        var result = await fd1service.UpdateFD1RUL(rul);
        NavigationManager.NavigateTo("/fd001/rul");
    }

    void Return()
    {
        NavigationManager.NavigateTo("/fd001/rul");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsruntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FD001Service fd1service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
