#pragma checksum "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a202dcc05eb3725de3fe8689868ade55957727d5"
// <auto-generated/>
#pragma warning disable 1591
namespace CountryMusicCountdown.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using CountryMusicCountdown;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using CountryMusicCountdown.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lanecw\workspace\CountryMusicCountdown\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
    public partial class DatePicker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-6");
            __builder.OpenElement(4, "table");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.OpenElement(7, "select");
            __builder.AddAttribute(8, "class");
#nullable restore
#line 7 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
                             for (int i = 1; i < 31; i++) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "option");
#nullable restore
#line 7 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
__builder.AddContent(10, i);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "class");
#nullable restore
#line 13 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
                             for (int i = 1; i < 12; i++) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", 
#nullable restore
#line 13 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
                                                                            i

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 13 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
__builder.AddContent(17, Months[i-1]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "select");
            __builder.AddAttribute(21, "class");
#nullable restore
#line 19 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
                             for (int i = DateTime.Now.Year-100;i<DateTime.Now.Year+5;i++) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "option");
#nullable restore
#line 19 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
__builder.AddContent(23, i);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Lanecw\workspace\CountryMusicCountdown\Shared\Components\DatePicker.razor"
       
    public int Day { get; set; }
    public int Month {get; set; }
    public int Year {get; set; }

    public string[] Months { get; set; } =
        {
           "January",
           "Febuary",
           "March",
           "April",
           "May",
           "June",
           "July",
           "August",
           "September",
           "October",
           "November",
           "December"
        };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
