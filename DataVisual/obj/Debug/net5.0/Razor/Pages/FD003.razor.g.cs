#pragma checksum "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD003.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac4659db82de5142bcc94309475cddde1668da4"
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
#line 2 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD003.razor"
using DataVisual.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fd003")]
    public partial class FD003 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>FD003 Dataset</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Please select the table that you want to see:</p>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.OpenElement(3, "tr");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "style", "margin: 50px");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD003.razor"
                                                                       (() => TRAIN())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "TRAIN TABLE");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "style", "margin: 50px");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD003.razor"
                                                                       (() => TEST())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "TEST TABLE");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddAttribute(18, "style", "margin: 50px");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD003.razor"
                                                                       (() => RUL())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "RUL TABLE");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD003.razor"
       
    void TRAIN()
    {
        NavigationManager.NavigateTo("/fd003/train");
    }

    void TEST()
    {
        NavigationManager.NavigateTo("/fd003/test");
    }

    void RUL()
    {
        NavigationManager.NavigateTo("/fd003/rul");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FD003Service fd3service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
