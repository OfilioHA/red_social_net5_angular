#pragma checksum "/home/ofilio/Documentos/POW II/Practica_2/Views/Shared/Components/UsersFriends/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ee08d09f4adc4c3dcf88576f69810a63a765089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UsersFriends_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UsersFriends/Default.cshtml")]
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
#line 1 "/home/ofilio/Documentos/POW II/Practica_2/Views/_ViewImports.cshtml"
using Practica_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ofilio/Documentos/POW II/Practica_2/Views/_ViewImports.cshtml"
using Practica_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee08d09f4adc4c3dcf88576f69810a63a765089", @"/Views/Shared/Components/UsersFriends/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a93cac4649bf1b647e2b9ac7819af84d80899cdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UsersFriends_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Practica_2.Models.UserModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/ofilio/Documentos/POW II/Practica_2/Views/Shared/Components/UsersFriends/Default.cshtml"
  
    foreach (var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"list-group-item list-group-item-action\"");
            BeginWriteAttribute("href", " href=\"", 140, "\"", 169, 2);
            WriteAttributeValue("", 147, "/user/details/", 147, 14, true);
#nullable restore
#line 6 "/home/ofilio/Documentos/POW II/Practica_2/Views/Shared/Components/UsersFriends/Default.cshtml"
WriteAttributeValue("", 161, user.Id, 161, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            ");
#nullable restore
#line 7 "/home/ofilio/Documentos/POW II/Practica_2/Views/Shared/Components/UsersFriends/Default.cshtml"
       Write(user.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </a>\n");
#nullable restore
#line 9 "/home/ofilio/Documentos/POW II/Practica_2/Views/Shared/Components/UsersFriends/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Practica_2.Models.UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
