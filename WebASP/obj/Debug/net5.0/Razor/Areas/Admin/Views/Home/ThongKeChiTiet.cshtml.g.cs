#pragma checksum "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04dc7f3361a074e8456faf6ca342f324304bc357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_ThongKeChiTiet), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/ThongKeChiTiet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04dc7f3361a074e8456faf6ca342f324304bc357", @"/Areas/Admin/Views/Home/ThongKeChiTiet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14c01a55ee5981c31ef5ad63f656d12520098d62", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_ThongKeChiTiet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebASP.Models.HoaDon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tim", "doanhthu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThongKeChiTiet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tim", "hoadon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
  
    ViewData["Title"] = "ThongKeChiTiet";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    var tiendachi = Model.GroupBy(i => i.TaiKhoanId).SelectMany(cl => cl.Select(
                    csLine => new
                    {
                        MaKH = csLine.TaiKhoan.TaiKhoanId,
                        TenKH = csLine.TaiKhoan.HoTen,
                        SDT = csLine.TaiKhoan.SDT.ToString(),
                        Total = cl.Sum(c => c.TongTien),
                    })).OrderByDescending(i=>i.Total).Distinct().ToList();


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""margin-left:50px"">
    <div class=""card mb-4"">
        <div class=""card-header"">
            <i class=""fas fa-table me-1""></i>
            Hóa đơn mới trong tuần
        </div>
        <div class=""card-body"">
            <table class=""table"">
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
#line 34 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                     foreach (var i in @ViewBag.hoadonmoi)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 37 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                           Write(i.MAHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                           Write(i.TaiKhoan.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                           Write(i.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                           Write(i.DChiGiaoHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                           Write(i.SDTGiaoHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                           Write(i.TongTien.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n                        </tr>\r\n");
#nullable restore
#line 44 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n    <span style=\"font-weight:bold\">Thống kê doanh thu</span>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04dc7f3361a074e8456faf6ca342f324304bc3578968", async() => {
                WriteLiteral("\r\n            Khoảng ngày: <input id=\"datebefore\" type=\"date\" name=\"datebefore\"");
                BeginWriteAttribute("value", " value=\"", 2107, "\"", 2115, 0);
                EndWriteAttribute();
                WriteLiteral(" />   <input type=\"date\" id=\"dateafter\" name=\"dateafter\"");
                BeginWriteAttribute("value", " value=\"", 2172, "\"", 2180, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <button type=\"submit\">Tìm</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tim", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["tim"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br>\r\n        <p> Tổng doanh thu ");
#nullable restore
#line 58 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                      Write(ViewBag.khoangthoigiandoanhthu);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 58 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                                                        Write(ViewBag.doanhthu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VND</p>
    </div><br>
    <span style=""font-weight:bold"">Số tiền đã chi của mỗi khách hàng</span>
    <table class=""table"">
        <tr>
            <th>Mã khách hàng</th>
            <th>Tên khách hàng</th>
            <th>SDT</th>
            <th>Tiền đã chi</th>
        </tr>
");
#nullable restore
#line 68 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
         foreach (var i in @tiendachi)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 71 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
               Write(i.MaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 72 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
               Write(i.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 73 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
               Write(i.SDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 74 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
               Write(i.Total.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n            </tr>\r\n");
#nullable restore
#line 76 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <span style=\"font-weight:bold\">Thống kê hóa đơn</span>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04dc7f3361a074e8456faf6ca342f324304bc35714496", async() => {
                WriteLiteral("\r\n        Khoảng ngày: <input id=\"datebefore2\" type=\"date\" name=\"datebefore\"");
                BeginWriteAttribute("value", " value=\"", 3147, "\"", 3155, 0);
                EndWriteAttribute();
                WriteLiteral(" />   <input type=\"date\" id=\"dateafter2\" name=\"dateafter\"");
                BeginWriteAttribute("value", " value=\"", 3213, "\"", 3221, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <button type=\"submit\">Tìm</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tim", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["tim"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br>\r\n");
#nullable restore
#line 83 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
     if (ViewBag.hoadon.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-4\">\r\n            <div class=\"card-header\">\r\n                <i class=\"fas fa-table me-1\"></i>\r\n                Hóa đơn ");
#nullable restore
#line 88 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                   Write(ViewBag.khoangthoigianhoadon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""card-body"">
                <table class=""table"">
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
#line 103 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                         foreach (var i in @ViewBag.hoadon)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 106 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                               Write(i.MAHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 107 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                               Write(i.TaiKhoan.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 108 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                               Write(i.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 109 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                               Write(i.DChiGiaoHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 110 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                               Write(i.SDTGiaoHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 111 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                               Write(i.TongTien.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n                            </tr>\r\n");
#nullable restore
#line 113 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 120 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\Home\ThongKeChiTiet.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <script>
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1;
        var yyyy = today.getFullYear();

        if (dd < 10) {
            dd = '0' + dd;
        }

        if (mm < 10) {
            mm = '0' + mm;
        }

        today = yyyy + '-' + mm + '-' + dd;
        document.getElementById(""datebefore"").setAttribute(""max"", today);
        document.getElementById(""dateafter"").setAttribute(""max"", today);
        document.getElementById(""datebefore"").setAttribute(""value"", today);
        document.getElementById(""dateafter"").setAttribute(""value"", today);
        document.getElementById(""datebefore2"").setAttribute(""max"", today);
        document.getElementById(""dateafter2"").setAttribute(""max"", today);
        document.getElementById(""datebefore2"").setAttribute(""value"", today);
        document.getElementById(""dateafter2"").setAttribute(""value"", today);
    </script>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebASP.Models.HoaDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591