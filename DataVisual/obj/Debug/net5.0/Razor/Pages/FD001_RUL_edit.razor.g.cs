#pragma checksum "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c496c83d620305a6da8485576d0da844f50177f5"
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
            __builder.AddMarkupContent(0, "<h1>FD001 RUL Edit</h1>");
#nullable restore
#line 10 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
 if (Id == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3>Create a new Record</h3>");
#nullable restore
#line 13 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h3");
            __builder.AddContent(3, "Edit ");
#nullable restore
#line 16 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
__builder.AddContent(4, rul.RUL);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "p");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
                     rul

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
                                    HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddMarkupContent(11, "<label for=\"EngineID\">EngineID</label>\r\n            ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "id", "EngineID");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
                                        rul.EngineID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rul.EngineID = __value, rul.EngineID));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddMarkupContent(19, "<label for=\"RUL\">RUL</label>\r\n            ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "id", "RUL");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
                                   rul.RUL

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rul.RUL = __value, rul.RUL));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(26, "button");
                __builder2.AddAttribute(27, "type", "submit");
                __builder2.AddAttribute(28, "class", "btn btn-primary");
#nullable restore
#line 30 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
__builder2.AddContent(29, btnText);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenElement(31, "p");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-secondary");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\njuxc\source\repos\DataVisual\DataVisual\Pages\FD001_RUL_edit.razor"
                                                (() => Return())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Return");
            __builder.CloseElement();
            __builder.CloseElement();
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