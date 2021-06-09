#pragma checksum "C:\Users\Jamey\source\repos\CocktailDB\Pages\DrinksWithRum.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab281d71919ed7536b687c2746294f1d86c0156b"
// <auto-generated/>
#pragma warning disable 1591
namespace CocktailDB.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using CocktailDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using CocktailDB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using CocktailDB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using RestSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Jamey\source\repos\CocktailDB\_Imports.razor"
using RestSharp.Deserializers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/WithRum")]
    public partial class DrinksWithRum : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Drinks Using Rum</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", " table tab-content");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead class=\"thead-light\">\r\n        <tr>\r\n            <th>Drink Name</th>\r\n            <th>Drink Pic</th>\r\n            <th> Drink ID</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddAttribute(6, "class", "tab-content");
            __builder.AddMarkupContent(7, "\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Jamey\source\repos\CocktailDB\Pages\DrinksWithRum.razor"
         foreach (var item in randomdrink)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, " ");
            __builder.AddContent(13, 
#nullable restore
#line 21 "C:\Users\Jamey\source\repos\CocktailDB\Pages\DrinksWithRum.razor"
                      item.strDrink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 22 "C:\Users\Jamey\source\repos\CocktailDB\Pages\DrinksWithRum.razor"
                               item.strDrinkThumb

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "alt", "Alternate Text");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, " ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", 
#nullable restore
#line 23 "C:\Users\Jamey\source\repos\CocktailDB\Pages\DrinksWithRum.razor"
                                $"/DrinkById/{item.idDrink}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "class", "nav-link");
            __builder.AddContent(25, 
#nullable restore
#line 23 "C:\Users\Jamey\source\repos\CocktailDB\Pages\DrinksWithRum.razor"
                                                                                 item.idDrink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(26, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 25 "C:\Users\Jamey\source\repos\CocktailDB\Pages\DrinksWithRum.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n\r\n\r\n\r\n        }\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Jamey\source\repos\CocktailDB\Pages\DrinksWithRum.razor"
       
    List<DrinkModelData> randomdrink;
    string errorString;

    protected override async Task OnInitializedAsync()
    {


        var client = new HttpClient();
        var drinkURL = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?i=Rum";
        var drinkResponse = client.GetStringAsync(drinkURL).Result;
        var drinkQuote = JObject.Parse(drinkResponse).GetValue("drinks").ToString();
        var DrinkR = JArray.Parse(drinkQuote).ToString();

        List<DrinkModelData> drink = JsonConvert.DeserializeObject<List<DrinkModelData>>(drinkQuote);



        randomdrink = drink;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
