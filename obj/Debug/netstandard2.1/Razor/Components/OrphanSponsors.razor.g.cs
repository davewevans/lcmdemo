#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16301ce407d32380b5f59b3cb7780e75d464ad89"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMSMSPWA.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using LCMSMSPWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using LCMSMSPWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using LCMSMSPWA.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using LCMSMSPWA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using LCMSMSPWA.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
using LCMSMSPWA.enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
using LCMSMSPWA.Pages;

#line default
#line hidden
#nullable disable
    public partial class OrphanSponsors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LCMSMSPWA.Components.SfConfirmDeleteDialog>(0);
            __builder.AddAttribute(1, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                             OnConfirmDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                              $"Are you sure you want remove this sponsor as { Orphan?.FirstName }'s sponsor?"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(3, (__value) => {
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                             DeleteConfirmationDialog = (LCMSMSPWA.Components.SfConfirmDeleteDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "m-10");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "md:flex mt-4 mb-8 bg-blue-100 p-4 items-center justify-between");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, "<div class=\"flex items-center text-blue-600\">\r\n               <div class=\"mr-3 text-yellow-600\">\r\n                     <svg class=\"h-12 w-12\" version=\"1.1\" x=\"0px\" y=\"0px\" viewBox=\"0 0 90.59 83.018\" xmlns=\"http://www.w3.org/2000/svg\">\r\n                              <path d=\"M 77.406 24.715 L 61.286 24.715 C 56.095 24.715 51.861 29.268 51.861 34.832 L 51.861 61.009 C 51.861 61.515 52.27 61.894 52.817 61.894 L 58.827 61.894 L 58.827 46.34 C 58.827 45.834 59.237 45.455 59.784 45.455 C 60.33 45.455 60.74 45.834 60.74 46.34 L 60.74 76.817 C 60.74 77.955 61.696 78.84 62.926 78.84 L 68.253 78.84 L 68.253 61.768 C 68.253 61.262 68.663 60.883 69.209 60.883 C 69.756 60.883 70.166 61.262 70.166 61.768 L 70.166 78.966 L 75.493 78.966 C 76.723 78.966 77.679 78.081 77.679 76.943 L 77.679 46.34 C 77.679 45.834 78.089 45.455 78.635 45.455 C 79.181 45.455 79.591 45.834 79.591 46.34 L 79.591 61.768 L 85.602 61.768 C 86.148 61.768 86.558 61.389 86.558 60.883 L 86.558 34.832 C 86.831 29.142 82.597 24.715 77.406 24.715 Z\" fill=\"currentColor\" style></path>\r\n                              <path d=\"M 69.346 21.68 C 75.083 21.68 79.864 17.254 79.864 11.69 C 79.864 6.253 75.22 1.7 69.346 1.7 C 63.609 1.7 58.827 6.126 58.827 11.69 C 58.827 17.128 63.609 21.68 69.346 21.68 Z\" fill=\"currentColor\" style></path>\r\n                  \r\n                              <path d=\"M 16.617 64.55 C 20.851 64.55 24.403 61.262 24.403 57.215 C 24.403 53.169 20.988 49.881 16.617 49.881 C 12.382 49.881 8.83 53.169 8.83 57.215 C 8.83 61.262 12.382 64.55 16.617 64.55 Z\" fill=\"currentColor\" style></path>\r\n                              <path d=\"M 23.31 67.079 L 9.923 67.079 C 6.098 67.079 2.956 70.494 2.956 74.54 L 2.956 79.852 C 2.956 80.357 3.366 80.737 3.912 80.737 L 29.321 80.737 C 29.867 80.737 30.277 80.357 30.277 79.852 L 30.277 74.54 C 30.414 70.367 27.272 67.079 23.31 67.079 Z\" fill=\"currentColor\" style></path>\r\n                              <path d=\"M 28.091 26.359 L 28.091 29.647 C 28.774 29.647 29.184 29.394 29.594 29.142 C 30.004 28.889 30.141 28.509 30.141 28.13 C 30.141 27.751 30.004 27.371 29.731 27.118 C 29.457 26.739 28.911 26.486 28.091 26.359 Z\" fill=\"currentColor\" style></path>\r\n                              <path d=\"M 24.95 22.06 C 24.95 22.439 25.086 22.819 25.359 23.072 C 25.633 23.324 26.179 23.577 26.862 23.704 L 26.862 20.542 C 26.316 20.542 25.769 20.795 25.496 21.048 C 25.086 21.301 24.95 21.68 24.95 22.06 Z\" fill=\"currentColor\" style></path>\r\n                              <path d=\"M 27.272 14.472 C 20.851 14.472 15.66 19.278 15.66 25.221 C 15.66 31.165 20.851 35.97 27.272 35.97 C 33.692 35.97 38.883 31.165 38.883 25.221 C 39.02 19.278 33.692 14.472 27.272 14.472 Z M 31.37 30.533 C 30.55 31.165 29.457 31.544 28.091 31.671 L 28.091 32.935 L 26.862 32.935 L 26.862 31.544 C 25.086 31.418 23.447 30.659 21.944 29.521 L 23.447 27.877 C 24.54 28.762 25.769 29.268 26.862 29.521 L 26.862 25.98 C 25.359 25.601 24.267 25.221 23.583 24.715 C 22.9 24.21 22.491 23.324 22.491 22.313 C 22.491 21.301 22.9 20.416 23.72 19.657 C 24.54 19.025 25.496 18.645 26.862 18.519 L 26.862 17.634 L 28.091 17.634 L 28.091 18.519 C 29.594 18.645 30.96 19.025 32.19 19.91 L 30.96 21.554 C 30.141 20.922 29.184 20.669 28.091 20.542 L 28.091 23.957 L 28.091 23.957 C 29.594 24.336 30.687 24.715 31.507 25.348 C 32.19 25.854 32.599 26.739 32.599 27.751 C 32.599 28.889 32.19 29.774 31.37 30.533 Z\" fill=\"currentColor\" style></path>\r\n                              <path d=\"M 51.861 28.256 C 52.407 28.256 52.68 27.751 52.68 27.371 L 52.68 23.324 C 52.68 22.819 52.27 22.439 51.861 22.439 L 46.533 21.807 C 45.987 19.531 45.03 17.254 43.664 15.358 L 47.079 11.437 C 47.353 11.058 47.353 10.552 46.943 10.173 L 43.801 7.264 C 43.391 6.885 42.845 6.885 42.435 7.264 L 38.2 10.426 C 36.014 9.161 33.692 8.149 31.097 7.77 L 30.414 2.838 C 30.414 2.332 29.867 2.079 29.457 2.079 L 25.086 2.079 C 24.54 2.079 24.13 2.459 24.13 2.838 L 23.447 7.77 C 20.851 8.276 18.529 9.161 16.343 10.426 L 12.245 7.138 C 11.836 6.885 11.289 6.885 10.879 7.264 L 7.737 10.046 C 7.464 10.426 7.328 10.931 7.737 11.311 L 11.152 15.231 C 9.786 17.254 8.694 19.404 8.284 21.807 L 2.82 22.313 C 2.273 22.313 2 22.819 2 23.198 L 2 27.245 C 2 27.751 2.41 28.13 2.82 28.13 L 8.147 28.762 C 8.694 31.038 9.65 33.315 11.016 35.212 L 7.601 39.132 C 7.328 39.511 7.328 40.017 7.737 40.396 L 10.879 43.305 C 11.289 43.684 11.836 43.684 12.245 43.431 L 16.48 40.27 C 18.666 41.535 20.988 42.546 23.447 42.926 L 24.13 47.857 C 24.13 48.363 24.676 48.616 25.086 48.616 L 29.457 48.616 C 30.004 48.616 30.414 48.237 30.414 47.857 L 31.097 42.926 C 33.556 42.42 36.014 41.535 38.064 40.27 L 42.298 43.431 C 42.708 43.684 43.255 43.684 43.664 43.305 L 46.806 40.396 C 47.216 40.017 47.216 39.511 46.943 39.132 L 43.528 35.212 C 44.894 33.315 45.987 31.038 46.396 28.762 L 51.861 28.256 Z M 27.272 37.867 C 19.759 37.867 13.611 32.177 13.611 25.221 C 13.611 18.266 19.759 12.575 27.272 12.575 C 34.785 12.575 40.932 18.266 40.932 25.221 C 40.932 32.303 34.785 37.867 27.272 37.867 Z\" fill=\"currentColor\" style></path>\r\n                          </svg>\r\n                </div>\r\n            <h3 class=\"text-2xl font-semibold mt-1\">Sponsors</h3>\r\n        </div>\r\n      \r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", true);
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                              OnAddClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "bg-transparent hover:bg-blue-500 text-blue-700 font-semibold hover:text-white py-2 px-4 border border-blue-500 hover:border-transparent rounded");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.AddMarkupContent(19, "<div class=\"flex items-center\">\r\n                    <i class=\"fa fa-plus mr-2\"></i> Add\r\n                </div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        \r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
#nullable restore
#line 40 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
      
        switch (viewMode)
        {
            case ViewMode.AddNew:

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenComponent<LCMSMSPWA.Components.SponsorAssignmentDialog>(24);
            __builder.AddAttribute(25, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMSMSPWA.Models.OrphanDetailsModel>(
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                   Orphan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "OnAddNewComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                            OnAddNewComplete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 47 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                break;
            case ViewMode.List:
                break;
        }
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 53 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
     if (Orphan?.Sponsors != null && Orphan?.Sponsors.Count() != 0)
    {
        foreach (var sponsor in Orphan.Sponsors)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "w-full");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "w-3/4 border-2 border-gray-600 bg-blue-100 rounded mb-6");
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "p-8");
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.AddMarkupContent(43, "<label class=\"md:text-2xl font-semibold mr-6\">First Name</label>\r\n                            ");
            __builder.OpenElement(44, "p");
            __builder.AddAttribute(45, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(46, 
#nullable restore
#line 62 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                                                sponsor.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.AddMarkupContent(52, "<label class=\"md:text-2xl font-semibold mr-6\">Last Name</label>\r\n                            ");
            __builder.OpenElement(53, "p");
            __builder.AddAttribute(54, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(55, 
#nullable restore
#line 66 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                                                sponsor.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.AddMarkupContent(61, "<label class=\"md:text-2xl font-semibold mr-6\">Location</label>\r\n                            ");
            __builder.OpenElement(62, "p");
            __builder.AddAttribute(63, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(64, 
#nullable restore
#line 70 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                                                sponsor.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(69, "\r\n                            ");
            __builder.AddMarkupContent(70, "<label class=\"md:text-2xl font-semibold mr-6\">City</label>\r\n                            ");
            __builder.OpenElement(71, "p");
            __builder.AddAttribute(72, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(73, 
#nullable restore
#line 74 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                                                sponsor.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.AddMarkupContent(79, "<label class=\"md:text-2xl font-semibold mr-6\">State</label>\r\n                            ");
            __builder.OpenElement(80, "p");
            __builder.AddAttribute(81, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(82, 
#nullable restore
#line 78 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                                                sponsor.State

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(87, "\r\n                            ");
            __builder.AddMarkupContent(88, "<label class=\"md:text-2xl font-semibold mr-6\">ZipCode</label>\r\n                            ");
            __builder.OpenElement(89, "p");
            __builder.AddAttribute(90, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(91, 
#nullable restore
#line 82 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                                                sponsor.ZipCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(96, "\r\n                            ");
            __builder.AddMarkupContent(97, "<label class=\"md:text-2xl font-semibold mr-6\">Email</label>\r\n                            ");
            __builder.OpenElement(98, "p");
            __builder.AddAttribute(99, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(100, 
#nullable restore
#line 86 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                                                sponsor.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(105, "\r\n                            ");
            __builder.AddMarkupContent(106, "<label class=\"md:text-2xl font-semibold mr-6\">MainPhone</label>\r\n                            ");
            __builder.OpenElement(107, "p");
            __builder.AddAttribute(108, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(109, 
#nullable restore
#line 90 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                                                sponsor.MainPhone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\r\n                    ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "flex items-center justify-end mt-4 bg-gray-800 p-6");
            __builder.AddMarkupContent(115, "\r\n                        ");
            __builder.OpenElement(116, "button");
            __builder.AddAttribute(117, "type", "button");
            __builder.AddAttribute(118, "class", "mr-4");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                                     () => OnRemoveClick(sponsor.SponsorID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(120, "\r\n                            ");
            __builder.AddMarkupContent(121, "<h3 class=\"text-2xl text-red-400\">Remove</h3>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n");
#nullable restore
#line 101 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(126, "        ");
            __builder.OpenElement(127, "p");
            __builder.AddAttribute(128, "class", "text-2xl");
            __builder.AddContent(129, "No sponsors found for ");
            __builder.AddContent(130, 
#nullable restore
#line 105 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
                                                   Orphan?.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 106 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanSponsors.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591