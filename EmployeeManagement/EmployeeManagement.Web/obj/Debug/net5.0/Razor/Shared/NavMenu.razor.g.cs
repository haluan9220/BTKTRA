#pragma checksum "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91ea4bdebebc9118221230e0fe79a13206c8880a"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HaLuan\source\repos\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"header\" b-qs0b5e9nst><div class=\"header_top\" b-qs0b5e9nst><div class=\"logo\" b-qs0b5e9nst><a href=\"index.html\" b-qs0b5e9nst><img style=\"width: 200px\" src=\"images/logo-fpt-shop.png\" alt b-qs0b5e9nst></a></div>\r\n        <div class=\"header_top_right\" b-qs0b5e9nst><div class=\"search_box\" b-qs0b5e9nst><form b-qs0b5e9nst><input type=\"text\" value=\"Search for Products\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Search for Products\';}\" b-qs0b5e9nst><input type=\"submit\" value=\"SEARCH\" b-qs0b5e9nst></form></div>\r\n            <div class=\"shopping_cart\" b-qs0b5e9nst><div class=\"cart\" b-qs0b5e9nst><a href=\"#\" title=\"View my shopping cart\" rel=\"nofollow\" b-qs0b5e9nst><strong class=\"opencart\" b-qs0b5e9nst></strong>\r\n                        <span class=\"cart_title\" b-qs0b5e9nst>Cart</span>\r\n                        <span class=\"no_product\" b-qs0b5e9nst>(empty)</span></a></div></div>\r\n            <div class=\"languages\" title=\"language\" b-qs0b5e9nst><div id=\"language\" class=\"wrapper-dropdown\" tabindex=\"1\" b-qs0b5e9nst>\r\n                    EN\r\n                    <strong class=\"opencart\" b-qs0b5e9nst></strong>\r\n                    <ul class=\"dropdown languges\" b-qs0b5e9nst><li b-qs0b5e9nst><a href=\"#\" title=\"Français\" b-qs0b5e9nst><span b-qs0b5e9nst><img src=\"images/gb.png\" alt=\"en\" width=\"26\" height=\"26\" b-qs0b5e9nst></span><span class=\"lang\" b-qs0b5e9nst>English</span></a></li>\r\n                        <li b-qs0b5e9nst><a href=\"#\" title=\"Français\" b-qs0b5e9nst><span b-qs0b5e9nst><img src=\"images/au.png\" alt=\"fr\" width=\"26\" height=\"26\" b-qs0b5e9nst></span><span class=\"lang\" b-qs0b5e9nst>Français</span></a></li>\r\n                        <li b-qs0b5e9nst><a href=\"#\" title=\"Español\" b-qs0b5e9nst><span b-qs0b5e9nst><img src=\"images/bm.png\" alt=\"es\" width=\"26\" height=\"26\" b-qs0b5e9nst></span><span class=\"lang\" b-qs0b5e9nst>Español</span></a></li>\r\n                        <li b-qs0b5e9nst><a href=\"#\" title=\"Deutsch\" b-qs0b5e9nst><span b-qs0b5e9nst><img src=\"images/ck.png\" alt=\"de\" width=\"26\" height=\"26\" b-qs0b5e9nst></span><span class=\"lang\" b-qs0b5e9nst>Deutsch</span></a></li>\r\n                        <li b-qs0b5e9nst><a href=\"#\" title=\"Russian\" b-qs0b5e9nst><span b-qs0b5e9nst><img src=\"images/cu.png\" alt=\"ru\" width=\"26\" height=\"26\" b-qs0b5e9nst></span><span class=\"lang\" b-qs0b5e9nst>Russian</span></a></li></ul></div></div>\r\n            <div class=\"currency\" title=\"currency\" b-qs0b5e9nst><div id=\"currency\" class=\"wrapper-dropdown\" tabindex=\"1\" b-qs0b5e9nst>\r\n                    $\r\n                    <strong class=\"opencart\" b-qs0b5e9nst></strong>\r\n                    <ul class=\"dropdown\" b-qs0b5e9nst><li b-qs0b5e9nst><a href=\"#\" b-qs0b5e9nst><span b-qs0b5e9nst>$</span>Dollar</a></li>\r\n                        <li b-qs0b5e9nst><a href=\"#\" b-qs0b5e9nst><span b-qs0b5e9nst>€</span>Euro</a></li></ul></div></div>\r\n            <div class=\"login\" b-qs0b5e9nst><span b-qs0b5e9nst><a href=\"login.html\" b-qs0b5e9nst><img src=\"images/login.png\" alt title=\"login\" b-qs0b5e9nst></a></span></div>\r\n            <div class=\"clear\" b-qs0b5e9nst></div></div>\r\n        <div class=\"clear\" b-qs0b5e9nst></div></div>\r\n    <div class=\"h_menu\" b-qs0b5e9nst><a id=\"touch-menu\" class=\"mobile-menu\" href=\"#\" b-qs0b5e9nst>Menu</a></div>\r\n\r\n    <nav b-qs0b5e9nst><ul class=\"menu list-unstyled\" style=\"padding-left: 60px; \" b-qs0b5e9nst><li b-qs0b5e9nst><a href=\"index.html\" b-qs0b5e9nst>HOME</a></li>\r\n            <li b-qs0b5e9nst><a href=\"index.html\" b-qs0b5e9nst>LAPTOP</a></li>\r\n            <li b-qs0b5e9nst><a href=\"index.html\" b-qs0b5e9nst>APPLE</a></li>\r\n            <li b-qs0b5e9nst><a href=\"index.html\" b-qs0b5e9nst>PC-LINH KIỆN</a></li>\r\n            <li b-qs0b5e9nst><a href=\"index.html\" b-qs0b5e9nst>PHỤ KIỆN</a></li>\r\n            <li b-qs0b5e9nst><a href=\"index.html\" b-qs0b5e9nst>MÁY CŨ GIÁ RẺ</a></li>\r\n            <li b-qs0b5e9nst><a href=\"index.html\" b-qs0b5e9nst>TABLET</a></li>\r\n            <li b-qs0b5e9nst><a href=\"index.html\" b-qs0b5e9nst>SIM&THẺ</a></li>\r\n            <li b-qs0b5e9nst><a href=\"products.html\" b-qs0b5e9nst>Khuyen Mai</a>\r\n                <ul class=\"sub-menu list-unstyled\" b-qs0b5e9nst><div class=\"nag-mother-list\" b-qs0b5e9nst><div class=\"navg-drop-main\" b-qs0b5e9nst><div class=\"nav-drop\" b-qs0b5e9nst><li b-qs0b5e9nst><a href=\"products.html\" b-qs0b5e9nst>Product 4</a></li>\r\n                    <li b-qs0b5e9nst><a href=\"#\" b-qs0b5e9nst>Product 5</a></li>\r\n                    <li b-qs0b5e9nst><a href=\"products.html\" b-qs0b5e9nst>Product 6</a></li></div></div></div></ul></li>\r\n<li class=\"activate\" b-qs0b5e9nst><a href=\"products.html\" b-qs0b5e9nst>Products</a>\r\n    <ul class=\"sub-menu list-unstyled\" b-qs0b5e9nst><div class=\"nag-mother-list\" b-qs0b5e9nst><div class=\"navg-drop-main\" b-qs0b5e9nst><div class=\"nav-drop\" b-qs0b5e9nst><li b-qs0b5e9nst><a href=\"products.html\" b-qs0b5e9nst>Product 1</a></li>\r\n        <li b-qs0b5e9nst><a href=\"products.html\" b-qs0b5e9nst>Product 2</a></li>\r\n        <li b-qs0b5e9nst><a href=\"products.html\" b-qs0b5e9nst>Product 3</a></li></div></div></div></ul></li></ul></nav>\r\n\r\n\r\n<div class=\"clear\" b-qs0b5e9nst></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
