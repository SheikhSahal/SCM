#pragma checksum "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Menuf_Type\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b804a6ecb2ac44a9aae03f297976d0ca98dd5e1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Menuf_Type_Index), @"mvc.1.0.view", @"/Views/Item_Menuf_Type/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item_Menuf_Type/Index.cshtml", typeof(AspNetCore.Views_Item_Menuf_Type_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b804a6ecb2ac44a9aae03f297976d0ca98dd5e1a", @"/Views/Item_Menuf_Type/Index.cshtml")]
    public class Views_Item_Menuf_Type_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Menuf_Type\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Main_Page_without_Script.cshtml";
    var Item_Menuf_id = ViewBag.Item_Menuf_id as WebApplication1.Models.Item_Menuf_Type;

#line default
#line hidden
            BeginContext(190, 737, true);
            WriteLiteral(@"



<div class=""container-fluid"">
    <div class=""row justify-content-center"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""form-validation"">
                        <form class=""form-valide"">
                            <div class=""form-group row"">
                                <label class=""col-lg-4 col-form-label"" for=""Mtype_id"">
                                    Item Menu ID <span class=""text-danger"">*</span>
                                </label>
                                <div class=""col-lg-6"">
                                    <input type=""text"" disabled class=""form-control"" id=""Mtype_id"" name=""Mtype_id""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 927, "\"", 958, 1);
#line 23 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Menuf_Type\Index.cshtml"
WriteAttributeValue("", 935, Item_Menuf_id.Mtype_id, 935, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(959, 512, true);
            WriteLiteral(@">
                                </div>

                            </div>

                            <div class=""form-group row"">
                                <label class=""col-lg-4 col-form-label"" for=""Icate_id"">
                                    Item Category <span class=""text-danger"">*</span>
                                </label>

                                <div class=""col-lg-6"">
                                    <select class=""form-control"" id=""Icate_id"" name=""Icate_id"">
");
            EndContext();
#line 35 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Menuf_Type\Index.cshtml"
                                         foreach (var icate_id in ViewBag.Item_Cat_DD as List<WebApplication1.Models.Item_Category>)
                                        {

#line default
#line hidden
            BeginContext(1648, 51, true);
            WriteLiteral("                                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1699, "\"", 1733, 1);
#line 37 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Menuf_Type\Index.cshtml"
WriteAttributeValue("", 1707, icate_id.Item_category_id, 1707, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1734, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1736, 19, false);
#line 37 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Menuf_Type\Index.cshtml"
                                                                                  Write(icate_id.Descrption);

#line default
#line hidden
            EndContext();
            BeginContext(1755, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 38 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Menuf_Type\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1809, 1888, true);
            WriteLiteral(@"
                                    </select>
                                </div>



                            </div>



                            <div class=""form-group row"">
                                <label class=""col-lg-4 col-form-label"" for=""Description"">
                                    Description <span class=""text-danger"">*</span>
                                </label>
                                <div class=""col-lg-6"">
                                    <input type=""text"" class=""form-control"" id=""Description"" name=""Description"" placeholder=""Your Description.."">
                                </div>
                                <div class=""col-lg-4"">

                                </div>
                                <div class=""col-lg-6"">
                                    <span class=""custom-error"" id=""desc-error"">Please enter Description</span>
                                </div>
                            </div>


                       ");
            WriteLiteral(@"     <div class=""form-group row"">
                                <div class=""col-lg-8 ml-auto"">
                                    <button type=""button"" id=""submit"" class=""btn btn-primary"">Submit</button>
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <div class=""col-lg-8 ml-auto"">
                                    <span class=""text-success collapse"" id=""Save"">Saved successfully...!</span>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<style>
    .custom-error {
        color: red;
        font-size: 10px;
        display: none;
    }
</style>


");
            EndContext();
            BeginContext(3697, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b804a6ecb2ac44a9aae03f297976d0ca98dd5e1a9193", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3747, 2077, true);
            WriteLiteral(@"
<script>
    $(document).ready(function () {

        $('select').select2();

        $('#submit').click(function () {

            var Valid = true;


            if (!($('#Description').val().trim() != '')) {
                Valid = false;
                $('#desc-error').css('display', 'block');
            }
            else {
                $('#desc-error').css('display', 'none');

            }

            if (Valid) {
                var Item_Menu =
                {

                    Mtype_id: $('#Mtype_id').val().trim(),
                    Icate_id : $('#Icate_id').val().trim(),
                    Description : $('#Description').val().trim()

                }

                debugger
                $.ajax({
                    type: 'POST',
                    url: '/Item_Menuf_Type/Index',
                    data: { Mtype_id: Item_Menu.Mtype_id, Icate_id: Item_Menu.Icate_id, Description: Item_Menu.Description },
                    success: function (re");
            WriteLiteral(@"sponse) {
                        if (response.success) {
                            getid();
                        }
                    }

                });

                function getid() {

                    $.ajax({
                        type: 'GET',
                        url: '/Item_Menuf_Type/GetData',
                        data: { Item_category_id: 1 },
                        success: function (response) {
                            if (response.success) {

                                console.log(response.fetchdata);
                                $('#Mtype_id').val(response.fetchdata);
                                $('#Icate_id').val(null);
                                $('#Description').val(null);

                                $(""#Save"").fadeIn(3000);
                                $(""#Save"").fadeOut(3000);
                            }
                        }

                    });
                }







            }


    ");
            WriteLiteral("    });\r\n    });\r\n</script>\r\n");
            EndContext();
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
