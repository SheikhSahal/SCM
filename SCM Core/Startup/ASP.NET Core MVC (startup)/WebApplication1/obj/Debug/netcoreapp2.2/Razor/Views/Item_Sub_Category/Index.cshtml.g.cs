#pragma checksum "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Sub_Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4e75cb1e93ab31fe721636cdcc36534df870f20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Sub_Category_Index), @"mvc.1.0.view", @"/Views/Item_Sub_Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item_Sub_Category/Index.cshtml", typeof(AspNetCore.Views_Item_Sub_Category_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4e75cb1e93ab31fe721636cdcc36534df870f20", @"/Views/Item_Sub_Category/Index.cshtml")]
    public class Views_Item_Sub_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Sub_Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Main_Page_without_Script.cshtml";
    var Item_sub_cate_id = ViewBag.Item_sub_cate as WebApplication1.Models.Item_Sub_Cateogory;


#line default
#line hidden
            BeginContext(196, 765, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row justify-content-center"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""form-validation"">
                        <form class=""form-valide"">

                            <div class=""form-group row"">
                                <label class=""col-lg-4 col-form-label"" for=""Item_Sub_Category"">
                                    Item Sub Category <span class=""text-danger"">*</span>
                                </label>
                                <div class=""col-lg-6"">
                                    <input type=""text"" disabled class=""form-control"" id=""Item_Sub_Category"" name=""Item_Sub_Category""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 961, "\"", 998, 1);
#line 21 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Sub_Category\Index.cshtml"
WriteAttributeValue("", 969, Item_sub_cate_id.Isubcate_id, 969, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(999, 519, true);
            WriteLiteral(@">
                                </div>
                            </div>

                            <div class=""form-group row"">
                                <label class=""col-lg-4 col-form-label"" for=""Item_Sub_Category"">
                                    Item Category <span class=""text-danger"">*</span>
                                </label>

                                <div class=""col-lg-6"">
                                    <select class=""form-control"" id=""Icate_id"" name=""Icate_id"">
");
            EndContext();
#line 32 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Sub_Category\Index.cshtml"
                                         foreach (var icate_id in ViewBag.Item_Cat_DD as List<WebApplication1.Models.Item_Category>)
                                        {

#line default
#line hidden
            BeginContext(1695, 51, true);
            WriteLiteral("                                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1746, "\"", 1780, 1);
#line 34 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Sub_Category\Index.cshtml"
WriteAttributeValue("", 1754, icate_id.Item_category_id, 1754, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1781, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1783, 19, false);
#line 34 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Sub_Category\Index.cshtml"
                                                                                  Write(icate_id.Descrption);

#line default
#line hidden
            EndContext();
            BeginContext(1802, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 35 "C:\Users\sahal.qasim.PREMIER\Desktop\SCM\SCM Core\Startup\ASP.NET Core MVC (startup)\WebApplication1\Views\Item_Sub_Category\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1856, 89, true);
            WriteLiteral("\r\n                                    </select>\r\n                                </div>\r\n");
            EndContext();
            BeginContext(2105, 1194, true);
            WriteLiteral(@"
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


                            <div class=""form-group row"">
                                <label class=""col-lg-4 col-f");
            WriteLiteral("orm-label\" for=\"Remarks\">\r\n                                    Remarks\r\n                                </label>\r\n                                <div class=\"col-lg-6\">\r\n");
            EndContext();
            BeginContext(3442, 1750, true);
            WriteLiteral(@"                                    <textarea class=""form-control"" id=""Remarks"" name=""Remarks"" rows=""5"" placeholder=""Your Remarks""></textarea>

                                </div>
                            </div>

                            <div class=""form-group row"">
                                <label class=""col-lg-4 col-form-label"">
                                    <a href=""#"">Status</a>
                                </label>
                                <div class=""col-lg-8"">
                                    <label class=""css-control css-control-primary css-checkbox"" for=""Status"">
                                        <input type=""checkbox"" class=""css-control-input"" id=""Status"" name=""Status"">
                                    </label>
                                </div>
                            </div>

                            <div class=""form-group row"">
                                <div class=""col-lg-8 ml-auto"">
                                    <");
            WriteLiteral(@"button type=""button"" id=""submit"" class=""btn btn-primary"">Submit</button>
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
            BeginContext(5192, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4e75cb1e93ab31fe721636cdcc36534df870f2010600", async() => {
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
            BeginContext(5242, 2582, true);
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
                var Item_sub_cat =
                {

                    Isubcate_id: $('#Item_Sub_Category').val().trim(),
                    Icate_id: $('#Icate_id').val().trim(),
                    Description: $('#Description').val().trim(),
                    Remarks: $('#Remarks').val().trim(),
                    Status: $('#Status').prop('checked')

                }

                debugger
                $.ajax({
                    type: 'POST',
                    url: '/Item_Sub_Category/Index',
                    data: {
       ");
            WriteLiteral(@"                 Isubcate_id: Item_sub_cat.Isubcate_id,
                        Icate_id: Item_sub_cat.Icate_id,
                        Description: Item_sub_cat.Description,
                        Remarks: Item_sub_cat.Remarks,
                        Status: Item_sub_cat.Status
                    },
                    success: function (response) {
                        if (response.success) {
                            getid();
                        }
                    }

                });

                function getid() {

                    $.ajax({
                        type: 'GET',
                        url: '/Item_Sub_Category/GetData',
                        data: { Item_category_id: 1 },
                        success: function (response) {
                            if (response.success) {

                                console.log(response.fetchdata);
                                $('#Item_Sub_Category').val(response.fetchdata);

               ");
            WriteLiteral(@"                 $('#Description').val(null);
                                $('#Status').prop(""checked"", false);
                                $('#Remarks').val(null);
                                $('#Status').prop(""checked"", false);

                                $(""#Save"").fadeIn(3000);
                                $(""#Save"").fadeOut(3000);
                            }
                        }

                    });
                }







            }


        });
    });
</script>
");
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