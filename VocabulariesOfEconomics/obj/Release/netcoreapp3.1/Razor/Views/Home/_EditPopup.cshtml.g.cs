#pragma checksum "C:\Users\nhana\OneDrive\Máy tính\Vocabulary\VocabulariesOfEconomics\VocabulariesOfEconomics\Views\Home\_EditPopup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3002d5b9e5576e7aae590c167ff890f2c8e20e79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__EditPopup), @"mvc.1.0.view", @"/Views/Home/_EditPopup.cshtml")]
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
#line 1 "C:\Users\nhana\OneDrive\Máy tính\Vocabulary\VocabulariesOfEconomics\VocabulariesOfEconomics\Views\_ViewImports.cshtml"
using VocabulariesOfEconomics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nhana\OneDrive\Máy tính\Vocabulary\VocabulariesOfEconomics\VocabulariesOfEconomics\Views\_ViewImports.cshtml"
using VocabulariesOfEconomics.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3002d5b9e5576e7aae590c167ff890f2c8e20e79", @"/Views/Home/_EditPopup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d647c3e8ec408cf512139f7e1d04898e00a95a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__EditPopup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal fade"" id=""EditPopup"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalSizeXl"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-x"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Edit Consumer Group</h5>
                <div class=""col-right"">
                    <button type=""button"" class=""close mt-4"" data-dismiss=""modal"" aria-label=""Close"">
                        <i aria-hidden=""true"" class=""ki ki-close""></i>
                    </button>
                </div>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""form-group row"">
                            <label class=""col-lg-6 col-form-label"">ENGLISH:<sup class=""text-danger"">*</sup></label>
                            <div class=""col-lg-6"">
                     ");
            WriteLiteral(@"           <input type=""text"" class=""form-control"" name=""english"" id=""english"" />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-lg-6 col-form-label"">VIETNAMESE</label>
                            <div class=""col-lg-6"">
                                <textarea id=""vietnamese"" name=""vietnamese"" class=""form-control"" rows=""5"" style=""margin-top: 0px; margin-bottom: 0px; height: 111px;""></textarea>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-lg-6 col-form-label"">SPELLING</label>
                            <div class=""col-lg-6"">
                                <input type=""text"" class=""form-control"" name=""spelling"" id=""spelling"" />
                            </div>
                        </div>
                    </div>
                </div>
            </di");
            WriteLiteral(@"v>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary min-w-sm-100px font-weight-bold mr-2"" data-dismiss=""modal"" id=""btnEditVoca"">Apply</button>
                <button type=""button"" class=""btn btn-secondary  min-w-sm-100px font-weight-bold"" data-dismiss=""modal"">Cancel</button>
            </div>
        </div>
    </div>
</div>");
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