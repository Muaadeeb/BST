// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServer.Pages.Food
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using DataLibrary.Db.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\_Imports.razor"
using DataLibrary.Data.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Food/List")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Owner\source\repos\BST\BuySellTrade\BlazorServer\Pages\Food\List.razor"
       

    private List<FoodModel> foodList;

    protected override async Task OnInitializedAsync()
    {
        foodList = await foodData.GetFood();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFoodData foodData { get; set; }
    }
}
#pragma warning restore 1591