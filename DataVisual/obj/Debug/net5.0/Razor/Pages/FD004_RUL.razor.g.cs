#pragma checksum "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD004_RUL.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a3c34ad202aff773a5fb3f91062fc79e9f2accc"
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
#line 2 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD004_RUL.razor"
using DataVisual.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fd004/rul")]
    public partial class FD004_RUL : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FD004 RUL Table</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-secondary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD004_RUL.razor"
                                                (() => Return())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Return");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "p");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD004_RUL.razor"
                                              (() => ShowAll())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Show all the records");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.AddMarkupContent(13, "<p>Please enter the id number that you want to check:</p>\r\n");
            __builder.OpenElement(14, "p");
            __builder.OpenElement(15, "label");
            __builder.AddMarkupContent(16, "\r\n           Enter the ID number here (Please enter a number in the range 1~248):\r\n           ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD004_RUL.razor"
                         Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Id = __value, Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "p");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD004_RUL.razor"
                                              (() => ShowRUL(Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n");
            __builder.OpenElement(27, "p");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD004_RUL.razor"
                                              (() => Create())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Create a new record");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD004_RUL.razor"
       
    public int? Id;

    private List<FD4RUL> fd4ruls;

    async void ShowRUL(int? Id)
    {
        if(Id>0 && Id<=248)
        {
            NavigationManager.NavigateTo($"/fd004/rul/show/{Id}");
        }
        else
        {
            await jsruntime.InvokeAsync<string>("alert", "Please enter a valid number!");
        }
    }

    void ShowAll()
    {
        NavigationManager.NavigateTo("/fd004/rul/show");
    }

    void Return()
    {
        NavigationManager.NavigateTo("/fd004");
    }

    void Create()
    {
        NavigationManager.NavigateTo("/fd004/rul/edit");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsruntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FD004Service fd4service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
