#pragma checksum "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bf3284fd5c0884fbd8b87e3417affcc102f668b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Status_Status), @"mvc.1.0.view", @"/Views/Status/Status.cshtml")]
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
#line 1 "C:\IR Tech Assignment Jordan Scheufele\Views\_ViewImports.cshtml"
using MvcProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\IR Tech Assignment Jordan Scheufele\Views\_ViewImports.cshtml"
using MvcProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bf3284fd5c0884fbd8b87e3417affcc102f668b", @"/Views/Status/Status.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b195e0951ebb4337c362372a52496a3462d2eef9", @"/Views/_ViewImports.cshtml")]
    public class Views_Status_Status : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcProject.Models.StatusHistory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
  

    ViewData["Title"] = "Status";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Status</h1>
<table class=""table table-striped"" >
    <thead class=""thread-dark"">
        <tr style=""background-color:#000000"">
            <th class=""text-light"">
                Date Time
            </th>
            <th class=""text-light"">
                ");
#nullable restore
#line 17 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
           Write(Html.DisplayNameFor(model => model.status.SystemUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-light\">\r\n               ");
#nullable restore
#line 20 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
          Write(Html.DisplayNameFor(model => model.status.Peripherals));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-light\">\r\n                ");
#nullable restore
#line 23 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
           Write(Html.DisplayNameFor(model => model.status.Call));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-light\">\r\n               ");
#nullable restore
#line 26 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
          Write(Html.DisplayNameFor(model => model.status.Network));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-light\">\r\n                ");
#nullable restore
#line 29 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
           Write(Html.DisplayNameFor(model => model.status.Capabilities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-light\">\r\n                ");
#nullable restore
#line 32 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
           Write(Html.DisplayNameFor(model => model.status.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-light\">\r\n                ");
#nullable restore
#line 35 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
           Write(Html.DisplayNameFor(model => model.status.UserInterface.ContactInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
           Write(Html.DisplayFor(modelItem => item.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("             \r\n            </td>\r\n            <td>\r\n                <b>Product ID:</b> ");
#nullable restore
#line 47 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                              Write(Html.DisplayFor(modelItem => item.status.SystemUnit.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>\r\n                <b>Product Platform:</b> ");
#nullable restore
#line 49 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.status.SystemUnit.ProductPlatform));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>\r\n                <b>Product Type:</b> ");
#nullable restore
#line 51 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                Write(Html.DisplayFor(modelItem => item.status.SystemUnit.ProductType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>\r\n                <b>Software Version:</b> ");
#nullable restore
#line 53 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.status.SystemUnit.Software.Version));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>\r\n                <b>Diagnostics Item:</b> ");
#nullable restore
#line 55 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.status.SystemUnit.Diagnostics.item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>\r\n                <b>Number of Active Calls:</b> ");
#nullable restore
#line 57 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.status.SystemUnit.State.NumberOfActiveCalls));

#line default
#line hidden
#nullable disable
            WriteLiteral("          \r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 60 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                for (int i = 0; i<item.status.Peripherals.Count(); i++)
               {
                   if(item.status.Peripherals[i].Type=="Camera"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <b>Camera:</b> ");
#nullable restore
#line 63 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                Write(Html.ValueFor(modelItem=>item.status.Peripherals[i].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <br>\r\n                      <b>ID:</b> ");
#nullable restore
#line 65 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                            Write(Html.ValueFor(modelItem=>item.status.Peripherals[i].ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <br>\r\n                      <b>Software Info:</b> ");
#nullable restore
#line 67 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                       Write(Html.ValueFor(modelItem=>item.status.Peripherals[i].SoftwareInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <br>\r\n                      <b>Status:</b> ");
#nullable restore
#line 69 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                Write(Html.ValueFor(modelItem=>item.status.Peripherals[i].Status));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                                                                                 
                   }
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                <b>Type:</b> ");
#nullable restore
#line 74 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                        Write(Html.DisplayFor(model => item.status.Call.CallType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>\r\n                <b>Status: </b> ");
#nullable restore
#line 76 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                           Write(Html.DisplayFor(model => item.status.Call.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>\r\n            </td>\r\n            <td>\r\n               <b>IPv4 Address:</b> ");
#nullable restore
#line 80 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                               Write(Html.DisplayFor(modelItem => item.status.Network.IPv4.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               <br>\r\n               <b>Mac Address:</b> ");
#nullable restore
#line 82 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                              Write(Html.DisplayFor(modelItem => item.status.Network.Ethernet.MacAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               <br>\r\n");
#nullable restore
#line 84 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                if(item.status.Network.IPv6.Address==""){

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <b>IPv6 Address: Not Found</b>\r\n");
#nullable restore
#line 86 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
               }
               else{  

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <b>IPv6 Address:</b> ");
#nullable restore
#line 88 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.status.Network.IPv6.Address));

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                                                                                       
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n               <b>Max Calls:</b> ");
#nullable restore
#line 92 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                            Write(Html.DisplayFor(model => item.status.Capabilities.Conference));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
           Write(Html.DisplayFor(model => item.status.Time.SystemTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <b>Contact Method:</b> ");
#nullable restore
#line 98 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                  Write(Html.DisplayFor(model => item.status.UserInterface.ContactInfo.ContactMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br>\r\n                <b>Name and Number:</b> ");
#nullable restore
#line 100 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
                                   Write(Html.DisplayFor(model => item.status.UserInterface.ContactInfo.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 103 "C:\IR Tech Assignment Jordan Scheufele\Views\Status\Status.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcProject.Models.StatusHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
