#pragma checksum "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc75de5ec717c5ebfad64580374cdcce44aef625"
// <auto-generated/>
#pragma warning disable 1591
namespace AutoSparePartsE_shop.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using AutoSparePartsE_shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using AutoSparePartsE_shop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
using AutoSparePartsE_shop.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/spareparts")]
    public partial class SpareParts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Spare Parts</h2>\r\n");
            __Blazor.AutoSparePartsE_shop.Pages.SpareParts.TypeInference.CreateTelerikGrid_0(__builder, 1, 2, 
#nullable restore
#line 6 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                    parts

#line default
#line hidden
#nullable disable
            , 3, "500px", 4, 
#nullable restore
#line 7 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                       true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 7 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                                       true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 8 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                         Telerik.Blazor.GridFilterMode.FilterRow

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 9 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                        true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 9 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                                           true

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(10);
                __builder2.AddAttribute(11, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                             nameof(Product.ProductID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Title", "Picture");
                __builder2.AddAttribute(13, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
#nullable restore
#line 13 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                  

                    var product = context as Product;

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(15, "img");
                    __builder3.AddAttribute(16, "class", "rounded-0, align-content-md-center");
                    __builder3.AddAttribute(17, "height", "60");
                    __builder3.AddAttribute(18, "width", "120");
                    __builder3.AddAttribute(19, "src", 
#nullable restore
#line 17 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                                $"/images/{product.ProductID}.jpg"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(20, "alt", "Product Photo");
                    __builder3.CloseElement();
#nullable restore
#line 18 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                    if (product.AvailablePsc < 1)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(21, "img");
                    __builder3.AddAttribute(22, "class", "rounded-circle, align-content-md-center");
                    __builder3.AddAttribute(23, "height", "50");
                    __builder3.AddAttribute(24, "src", 
#nullable restore
#line 21 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                                    $"/images/OOSStamp.jpg"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(25, "alt", "Out of Stock");
                    __builder3.CloseElement();
#nullable restore
#line 22 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                    }
                

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(27);
                __builder2.AddAttribute(28, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                             nameof(Product.ProductName)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "Title", "Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(31);
                __builder2.AddAttribute(32, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                             nameof(Product.ProductCategory)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Title", "Category");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(35);
                __builder2.AddAttribute(36, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                             nameof(Product.AvailablePsc)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Title", "Psc on Stock");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(39);
                __builder2.AddAttribute(40, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
                             nameof(Product.ProductPrice)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Title", "Retail pRice");
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Pages\SpareParts.razor"
       
    private IList<Product> parts;
    protected override async Task OnInitializedAsync()
    {
        parts = await sparePartsService.GetAllPartsService();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PartsService sparePartsService { get; set; }
    }
}
namespace __Blazor.AutoSparePartsE_shop.Pages.SpareParts
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Telerik.Blazor.GridFilterMode __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Height", __arg1);
        __builder.AddAttribute(__seq2, "Pageable", __arg2);
        __builder.AddAttribute(__seq3, "Sortable", __arg3);
        __builder.AddAttribute(__seq4, "FilterMode", __arg4);
        __builder.AddAttribute(__seq5, "Resizable", __arg5);
        __builder.AddAttribute(__seq6, "Reorderable", __arg6);
        __builder.AddAttribute(__seq7, "GridColumns", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
