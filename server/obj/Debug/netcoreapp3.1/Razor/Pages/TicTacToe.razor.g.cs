#pragma checksum "C:\Users\Admin\Desktop\Projekt\server\Pages\TicTacToe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b8cdc5e831b76054b554c023f4df828d1a25fa5"
// <auto-generated/>
#pragma warning disable 1591
namespace Projekt.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Admin\Desktop\Projekt\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\Projekt\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Admin\Desktop\Projekt\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Admin\Desktop\Projekt\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Admin\Desktop\Projekt\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\Users\Admin\Desktop\Projekt\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\Admin\Desktop\Projekt\server\_Imports.razor"
using Projekt.Shared;

#line default
#line hidden
#line 6 "C:\Users\Admin\Desktop\Projekt\server\Pages\TicTacToe.razor"
using Radzen;

#line default
#line hidden
#line 7 "C:\Users\Admin\Desktop\Projekt\server\Pages\TicTacToe.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 8 "C:\Users\Admin\Desktop\Projekt\server\Pages\TicTacToe.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\Users\Admin\Desktop\Projekt\server\Pages\TicTacToe.razor"
using Projekt.Models;

#line default
#line hidden
#line 10 "C:\Users\Admin\Desktop\Projekt\server\Pages\TicTacToe.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "C:\Users\Admin\Desktop\Projekt\server\Pages\TicTacToe.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tic-tac-toe")]
    public partial class TicTacToe : Projekt.Pages.TicTacToeComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "TicTacToe");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591