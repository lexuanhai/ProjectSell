#pragma checksum "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7691c6e49e3810565dd36210a514ec57bd4ec61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\_ViewImports.cshtml"
using WEBSITE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\_ViewImports.cshtml"
using WEBSITE.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
using WEBSITE.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7691c6e49e3810565dd36210a514ec57bd4ec61", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"566e11193e06d5b16c73522a53c4e952c0238a84", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
  
    var userString = Context.Session.GetString("UserInfor");
    var _user = new UserModelView();
    if (userString != null)
    {
        _user = JsonConvert.DeserializeObject<UserModelView>(userString);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"box-cart\">\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 20 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
         if (_user != null && !string.IsNullOrEmpty(userString))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"user-info\">\r\n                <p class=\"txt-title\">Họ và tên: <span");
            BeginWriteAttribute("class", " class=\"", 650, "\"", 658, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 23 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                           Write(_user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                <p class=\"txt-title\">Tổng điểm: <span");
            BeginWriteAttribute("class", " class=\"", 738, "\"", 746, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                          Write(_user.TotalPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>điểm</p>
            </div>
            <div class=""cart-product"">
                <!--<p class=""txt-title"">Danh sách sản phẩm đổi điểm</p>
    <div class=""cart-product-table"">
        <table id=""example2"" class=""table table-bordered table-hover dataTable dtr-inline"" aria-describedby=""example2_info"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Category</th>
                    <th>Reduced Price</th>
                    <th>Point</th>
                    <th>Price</th>
                    <th>Into Price</th>-->
                <!--</tr>
            </thead>
            <tbody id=""tblData"">
");
#nullable restore
#line 41 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                 if (Model != null && Model.Products.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 46 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 47 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"width: 13%;\">");
#nullable restore
#line 48 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                               Write(item.ReducedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"text-align:right\">");
#nullable restore
#line 49 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                    Write(item.TotalPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"text-align:right\">");
#nullable restore
#line 50 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                    Write(item.Price.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"text-align:right\">");
#nullable restore
#line 51 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                    Write(item.IntoPrice.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 53 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
                        <td colspan=""3"" style=""text-align:right""><span class=""txt-title"" style=""font-size:16px"">Tổng</span></td>
                        <td style=""text-align:right""><span class=""txt-title"" style=""font-size:16px"">");
#nullable restore
#line 56 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                                               Write(Model.Products.Sum(p => p.TotalPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td style=\"text-align:right\"><span class=\"txt-title\" style=\"font-size:16px\">");
#nullable restore
#line 57 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                                               Write(Model.Products.Sum(p => p.Price.Value).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td style=\"text-align:right\"><span class=\"txt-title\" style=\"font-size:16px\">");
#nullable restore
#line 58 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                                               Write(Model.Products.Sum(p => p.IntoPrice.Value).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    </tr>\r\n");
#nullable restore
#line 60 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\" style=\"text-align: center; color: #3d4d65;\">Chưa có sản phẩm</td>\r\n                    </tr>\r\n");
#nullable restore
#line 66 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>-->\r\n");
#nullable restore
#line 71 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                 if (Model == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"text-align: center; padding: 50px 0px 20px 0px\">Chưa có sản phẩm đổi điểm</div>\r\n");
#nullable restore
#line 74 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                     if (Model.Products != null && Model.Products.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <p class=""txt-title"">Danh sách sản phẩm đổi điểm</p>
                        <div class=""cart-product-table"">
                            <table id=""example2"" class=""table table-bordered table-hover dataTable dtr-inline"" aria-describedby=""example2_info"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Category</th>
                                        <th>Reduced Price</th>
                                        <th>Point</th>
                                        <th>Price</th>
                                        <th>Into Price</th>
");
            WriteLiteral("\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody id=\"tblData\">\r\n");
#nullable restore
#line 95 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                     if (Model != null && Model.Products.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                         foreach (var item in Model.Products)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 100 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 101 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td style=\"width: 13%;\">");
#nullable restore
#line 102 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                   Write(item.ReducedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td style=\"text-align:right\">");
#nullable restore
#line 103 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                        Write(item.TotalPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td style=\"text-align:right\">");
#nullable restore
#line 104 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                        Write(item.Price.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td style=\"text-align:right\">");
#nullable restore
#line 105 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                        Write(item.IntoPrice.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 107 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <tr>
                                            <td colspan=""3"" style=""text-align:right""><span class=""txt-title"" style=""font-size:16px"">Tổng</span></td>
                                            <td style=""text-align:right""><span class=""txt-title"" style=""font-size:16px"">");
#nullable restore
#line 110 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                                                                   Write(Model.Products.Sum(p => p.TotalPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                            <td style=\"text-align:right\"><span class=\"txt-title\" style=\"font-size:16px\">");
#nullable restore
#line 111 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                                                                   Write(Model.Products.Sum(p => p.Price.Value).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                            <td style=\"text-align:right\"><span class=\"txt-title\" style=\"font-size:16px\">");
#nullable restore
#line 112 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                                                                   Write(Model.Products.Sum(p => p.IntoPrice.Value).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 114 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 119 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                     
                    if (Model.Telecoms != null && Model.Telecoms.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <p class=""txt-title"">Danh sách ưu đãi viễn thông</p>
                        <div class=""cart-product-table"">
                            <table id=""example2"" class=""table table-bordered table-hover dataTable dtr-inline"" aria-describedby=""example2_info"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Exchange</th>
                                        <th>Point</th>
");
            WriteLiteral("\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody id=\"tblData\">\r\n");
#nullable restore
#line 135 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                     if (Model != null && Model.Telecoms.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                         foreach (var item in Model.Telecoms)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 140 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 141 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                               Write(item.Exchange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td style=\"text-align:right\">");
#nullable restore
#line 142 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                        Write(item.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 144 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <tr>
                                            <td colspan=""2"" style=""text-align:right""><span class=""txt-title"" style=""font-size:16px"">Tổng</span></td>
                                            <td style=""text-align:right""><span class=""txt-title"" style=""font-size:16px"">");
#nullable restore
#line 147 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                                                                                                   Write(Model.Telecoms.Sum(p => p.Point));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 149 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 154 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
                    }
                }               

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 158 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"box-please\">\r\n                <a href=\"/AcountUser/Login\" class=\"please\">Vui lòng đăng nhập để biết thông tin </a>\r\n            </div>\r\n");
#nullable restore
#line 164 "D:\ProjectWord\ProjectSell\TECH\WEBSITE\Views\Cart\Index.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>



<style>
    .box-cart {
        display: inline-block;
        width: 100%;
        margin-top: 106px;
        padding-top: 50px;
        padding-bottom: 40px;
    }
        .box-cart .txt-title {
            color: #3d4d65;
            font-weight: 700;
        }
        .box-cart .cart-product {
            margin-top: 40px;
        }
        .box-cart .txt-title span {
            color: #007a33 !important;
            font-weight: 700;
        }
        .box-cart .box-please {
            text-align: center;
            margin: 50px;
        }
        .box-cart .cart-product .txt-title {
            color: #3d4d65;
            font-weight: 700;
        }

        .box-cart .please {
            background: red;
            color: #fff;
            padding: 10px;
            border-radius: 4px;
            font-weight: 700;
            text-decoration: none;
        }
    .cart-product .txt-title {
        font-size: 23px;
        color: #00");
            WriteLiteral("98da;\r\n    }\r\n    .box-cart table th, .box-cart table td{\r\n        font-size: 15px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591