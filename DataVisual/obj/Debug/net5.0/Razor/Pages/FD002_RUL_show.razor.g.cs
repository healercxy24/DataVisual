#pragma checksum "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffd9ac45dfe7756d6aeb17d7527209600e5450b8"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
using DataVisual.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fd002/rul/show")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fd002/rul/show/{Id}")]
    public partial class FD002_RUL_show : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FD002 RUL Table</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-secondary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
                                                (() => Return())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Return");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
 if(Id == null)  //Create a new record
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
     if (fd2ruls == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 18 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>EngineID</th>\r\n                        <th>RUL</th></tr></thead>\r\n                ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 29 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
                     foreach(var fdrul in fd2ruls)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
#nullable restore
#line 32 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
__builder.AddContent(13, fdrul.EngineID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                            ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 33 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
__builder.AddContent(16, fdrul.RUL);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
                                                                          (() => EditRUL(fdrul.EngineID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
     
}
else  //SearchID is not null
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "p");
            __builder.AddContent(24, "The Engine with ID nubmer ");
#nullable restore
#line 45 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
__builder.AddContent(25, Id);

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, " :");
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
     if (fd2rul_single == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<p><em>Loading...</em></p>");
#nullable restore
#line 49 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "table");
            __builder.AddAttribute(29, "class", "table");
            __builder.AddMarkupContent(30, "<thead><tr><td>EngineID</td>\r\n                    <td>RUL</td>\r\n                    <td></td></tr></thead>\r\n            ");
            __builder.OpenElement(31, "tbody");
            __builder.OpenElement(32, "tr");
            __builder.OpenElement(33, "td");
#nullable restore
#line 62 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
__builder.AddContent(34, fd2rul_single.EngineID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
#nullable restore
#line 63 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
__builder.AddContent(37, fd2rul_single.RUL);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD002_RUL_show.razor"
       
    [Parameter]
    public string? Id { get; set; }

    private List<FD2RUL> fd2ruls;

    private FD2RUL fd2rul_single;  // for only a single record

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        if (Id == null)
        {
            fd2ruls = await fd2service.GetFD2RUL();
        }
        else
        {
            fd2rul_single = await fd2service.GetSingleFD2RUL(Convert.ToInt32(Id));
        }
    }

    void EditRUL(int Id)
    {
        
    }

    void Return()
    {
        NavigationManager.NavigateTo("/fd002/rul");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FD002Service fd2service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
