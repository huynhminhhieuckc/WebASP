#pragma checksum "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "080c8be1f6e4c015413f9462ea5c7398c5e55660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\_ViewImports.cshtml"
using WebASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\_ViewImports.cshtml"
using WebASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"080c8be1f6e4c015413f9462ea5c7398c5e55660", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14c01a55ee5981c31ef5ad63f656d12520098d62", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" width: 50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admins/#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    ViewData["TaiKhoan"] = ViewBag.TaiKhoan;
    ViewData["Title"] = "Trang chủ";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""layoutSidenav_content"">
    <main>
        <div class=""container-fluid px-4"">
            <h1 class=""mt-4"">Trang chủ</h1>
            <div class=""row"">
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card bg-primary text-white mb-4"">
                        <div class=""card-body"">Số lượng người dùng<p>");
#nullable restore
#line 13 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                                                                Write(ViewBag.slnguoidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-xl-3 col-md-6\">\r\n                    <div class=\"card bg-warning text-white mb-4\">\r\n                        <div class=\"card-body\">Số lượng giỏ hàng <p>");
#nullable restore
#line 18 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                                                               Write(ViewBag.slgiohang);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p></div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-xl-3 col-md-6\">\r\n                    <div class=\"card bg-success text-white mb-4\">\r\n                        <div class=\"card-body\">Số lượng hóa đơn <p>");
#nullable restore
#line 23 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                                                              Write(ViewBag.slhoadon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-xl-3 col-md-6\">\r\n                    <div class=\"card bg-danger text-white mb-4\">\r\n                        <div class=\"card-body\">Số lượng sản phẩm <p>");
#nullable restore
#line 28 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                                                               Write(ViewBag.slsanpham);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p></div>
                    </div>
                </div>
            </div>
            <div class=""card mb-4"">
                <div class=""card-header"">
                    <i class=""fas fa-table me-1""></i>
                    Hóa đơn trong tuần
                </div>
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Mã hóa đơn</th>
                            <th>Khách hàng</th>
                            <th>Ngày lập</th>
                            <th>Địa chỉ giao</th>
                            <th>SDT giao</th>
                            <th>Tổng tiền</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 49 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                         foreach (var i in @ViewBag.hoadon)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 52 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                               Write(i.MAHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                               Write(i.TaiKhoan.HoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                               Write(i.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                               Write(i.DChiGiaoHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                               Write(i.SDTGiaoHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                               Write(i.TongTien.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n                            </tr>\r\n");
#nullable restore
#line 59 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </tbody>
                </table>
            </div>
            <div class=""card mb-4"">
                <div class=""card-header"">
                    <i class=""fas fa-table me-1""></i>
                    Số lượng sản phẩm bán trong tháng
                </div>
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Mã sản phẩm</th>
                            <th>Tên sản phẩm</th>
                            <th>Đơn giá</th>
                            <th>Ảnh</th>
                            <th>Số lượng</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 81 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                         foreach (var i in @ViewBag.sanphambanchay)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 84 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                               Write(i.MASP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 85 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                               Write(i.TenSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 86 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                               Write(i.DonGia.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n                                <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "080c8be1f6e4c015413f9462ea5c7398c5e5566011711", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3726, "~/img/sanpham/", 3726, 14, true);
#nullable restore
#line 87 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3740, i.Anh, 3740, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 88 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                               Write(i.SL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 90 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </tbody>
                </table>
            </div>
        </div>
    </main>
    <footer class=""py-4 bg-light mt-auto"">
        <div class=""container-fluid px-4"">
            <div class=""d-flex align-items-center justify-content-between small"">
                <div class=""text-muted"">Copyright &copy; Your Website 2021</div>
                <div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "080c8be1f6e4c015413f9462ea5c7398c5e5566014291", async() => {
                WriteLiteral("Privacy Policy");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    &middot;\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "080c8be1f6e4c015413f9462ea5c7398c5e5566015427", async() => {
                WriteLiteral("Terms &amp; Conditions");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </footer>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591