#pragma checksum "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Shared\Item.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5019aea697829731ba5ab45c8c921e380b4c3f7a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class Item : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "td");
            __builder.AddAttribute(3, "class", "text-center");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "checkbox");
            __builder.AddAttribute(6, "bind", 
#nullable restore
#line 2 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Shared\Item.razor"
                                                          Marcado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 3 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Shared\Item.razor"
         Texto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Shared\Item.razor"
            
    [Parameter]
    public string Texto { get; set; }
    [Parameter]
    public bool Marcado { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
