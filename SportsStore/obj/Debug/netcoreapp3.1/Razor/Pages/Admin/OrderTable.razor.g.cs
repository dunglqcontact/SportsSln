#pragma checksum "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f176f16d5ad7398a695d40d3f74ca2449a73302"
// <auto-generated/>
#pragma warning disable 1591
namespace SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    public partial class OrderTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "th");
            __builder.AddAttribute(7, "colspan", "5");
            __builder.AddAttribute(8, "class", "text-center");
            __builder.AddContent(9, 
#nullable restore
#line 3 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
                                                 TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 6 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
         if (Orders?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
             foreach (Order o in Orders)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 11 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
                         o.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 12 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
                         o.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.AddMarkupContent(23, "<th>Product</th>\r\n                    ");
            __builder.AddMarkupContent(24, "<th>Quantity</th>\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
                                            e => OrderSelected.InvokeAsync(o.OrderID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.AddContent(31, 
#nullable restore
#line 18 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
                             ButtonLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 22 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
                 foreach (CartLine line in o.Lines)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                    ");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "\r\n                        <td colspan=\"2\"></td>\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 26 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
                             line.Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 27 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
                             line.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        <td></td>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 30 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "            ");
            __builder.AddMarkupContent(47, "<tr><td colspan=\"5\" class=\"text-center\">No Orders</td></tr>\r\n");
#nullable restore
#line 36 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Dung\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Orders";
    [Parameter]
    public IEnumerable<Order> Orders { get; set; }
    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";
    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
