#pragma checksum "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eecbc1b2fe202b8c2ba632fa872935ef96ad6d10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Library.Pages.FiltresAndRequests.Filtres.Pages_FiltresAndRequests_Filtres_ReadBooks), @"mvc.1.0.razor-page", @"/Pages/FiltresAndRequests/Filtres/ReadBooks.cshtml")]
namespace Library.Pages.FiltresAndRequests.Filtres
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
#line 1 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eecbc1b2fe202b8c2ba632fa872935ef96ad6d10", @"/Pages/FiltresAndRequests/Filtres/ReadBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13cb157343b014b5f6c9df1addca9d9a937b38a6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FiltresAndRequests_Filtres_ReadBooks : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>");
#nullable restore
#line 5 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
   Write(Model.Reader.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 10 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
               Write(Html.DisplayNameFor(model => model.IssuedBook[0].Book));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 13 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
               Write(Html.DisplayNameFor(model => model.IssuedBook[0].Emp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
             foreach (var item in Model.IssuedBook)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 23 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
                         try
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
                       Write(Model.Book.First(r => r.BookId == item.BookId).BookTitle);

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
                                                                                     
                        }
                        catch
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Book.BookId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
                                                                           
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 33 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
                         try
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
                       Write(Model.Employee.First(r => r.EmpId == item.EmpId).Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
                                                                                  
                        }
                        catch
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Emp.EmpId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
                                                                         
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\chikwork\Desktop\АЛЛА\ИндивидуальныйПроект\Library\Pages\FiltresAndRequests\Filtres\ReadBooks.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Pages.FiltresAndRequests.Filtres.ReadBooksModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Library.Pages.FiltresAndRequests.Filtres.ReadBooksModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Library.Pages.FiltresAndRequests.Filtres.ReadBooksModel>)PageContext?.ViewData;
        public Library.Pages.FiltresAndRequests.Filtres.ReadBooksModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591