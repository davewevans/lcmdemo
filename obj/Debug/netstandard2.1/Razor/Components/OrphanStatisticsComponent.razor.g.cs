#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cdd17e08005e353114b21cf1ee110ff1e76860f"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
using LegendPosition = Syncfusion.Blazor.Charts.LegendPosition;

#line default
#line hidden
#nullable disable
    public partial class OrphanStatisticsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "control-section");
            __builder.AddAttribute(2, "hidden", 
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
                                      hideChart

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfAccumulationChart>(4);
            __builder.AddAttribute(5, "SelectionMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.AccumulationSelectionMode>(
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
                                        AccumulationSelectionMode.Point

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Title", "Orphan Statistics");
            __builder.AddAttribute(7, "SelectionPattern", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.SelectionPattern>(
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
                                                                                                                     SelectionPattern.DiagonalForward

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartEvents>(10);
                __builder2.AddAttribute(11, "Load", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Charts.IAccLoadedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Charts.IAccLoadedEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
                                   BeforeRender

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartTooltipSettings>(13);
                __builder2.AddAttribute(14, "Enable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
                                                  false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartLegendSettings>(16);
                __builder2.AddAttribute(17, "ToggleVisibility", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
                                                          false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.LegendPosition>(
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
                                                                          LegendPosition.Right

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Height", "28%");
                __builder2.AddAttribute(20, "Width", "44%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeriesCollection>(22);
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeries>(25);
                    __builder3.AddAttribute(26, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
                                                  DataSource

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "XName", "xValue");
                    __builder3.AddAttribute(28, "YName", "yValue");
                    __builder3.AddAttribute(29, "Name", "Revenue");
                    __builder3.AddAttribute(30, "InnerRadius", "40%");
                    __builder3.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(32, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.AccumulationDataLabelSettings>(33);
                        __builder4.AddAttribute(34, "Name", "${point.y}");
                        __builder4.AddAttribute(35, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(37, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartDataLabelFont>(38);
                            __builder5.AddAttribute(39, "FontWeight", "600");
                            __builder5.AddAttribute(40, "Color", "white");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(41, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n\r\n");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "hidden", 
#nullable restore
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
              hideLoadingAnimation

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.OpenComponent<LCMSMSPWA.Components.LoadingComponent>(50);
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanStatisticsComponent.razor"
       
    
    OrphanStatistics orphanStatistics = null;
    bool hideLoadingAnimation = false;
    bool hideChart = true;
    bool gotData = false;
    public class PieData
    {
        public string xValue { get; set; }
        public double yValue { get; set; }
        public string text { get; set; }
    }

    public List<PieData> DataSource = new List<PieData>();
    
    protected override async Task OnInitializedAsync()
    {
        orphanStatistics = await DashboardRepository.GetOrphanStatistics();
        
        DataSource = new List<PieData>
        {
            new PieData { xValue = "Active",  yValue = (double)orphanStatistics.ActiveCount, text = orphanStatistics.ActiveCountText },
            new PieData { xValue = "Inactive",  yValue = (double)orphanStatistics.InactiveCount, text = orphanStatistics.InactiveCountText },
            new PieData { xValue = "Unspecified",  yValue = (double)orphanStatistics.UnknownCount, text = orphanStatistics.UnknownCountText },
        };
    }
    
    string CurrentUri;
    
    void BeforeRender(IAccLoadedEventArgs Args)
    {
        CurrentUri = NavigationManager.Uri;
        if (CurrentUri.IndexOf("material") > -1)
        {
            Args.Theme = AccumulationTheme.Material;
        }
        else if (CurrentUri.IndexOf("fabric") > -1)
        {
            Args.Theme = AccumulationTheme.Fabric;
        }
        else if (CurrentUri.IndexOf("bootstrap") > -1)
        {
            Args.Theme = AccumulationTheme.Bootstrap;
        }
        else if (CurrentUri.IndexOf("highcontrast") > -1)
        {
            Args.Theme = AccumulationTheme.HighContrast;
        }
        else
        {
            Args.Theme = AccumulationTheme.Bootstrap4;
        }

        hideChart = false;
        hideLoadingAnimation = true;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDashboardRepository DashboardRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
