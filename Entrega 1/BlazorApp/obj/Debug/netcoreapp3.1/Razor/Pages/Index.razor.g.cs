#pragma checksum "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87941d0e11a0c1b0d32ba105a6d7d5d2ddea64ec"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Todo List</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group mb-3");
            __builder.AddMarkupContent(3, "\r\n  ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "Adicionar Tarefa");
            __builder.AddAttribute(8, "aria-label", "Recipient\'s username");
            __builder.AddAttribute(9, "aria-describedby", "button-addon2");
            __builder.AddAttribute(10, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Pages\Index.razor"
                                                                                                                                                                           CheckInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Pages\Index.razor"
                                                                                                                                                   novaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => novaTarefa = __value, novaTarefa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n  ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "input-group-append");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "id", "button-addon2");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Pages\Index.razor"
                                                                                         IncluirTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Adicionar Tarefa");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "table");
            __builder.AddAttribute(27, "class", "table table-bordered");
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.AddMarkupContent(29, "<thead>\r\n        <tr>\r\n            <th class=\"text-center\" style=\"width:10%;\">Marcado</th>\r\n            <th>Todo</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(30, "tbody");
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 20 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Pages\Index.razor"
         foreach (var texto in lista)
        {
            bool i = true;

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "            ");
            __builder.OpenComponent<BlazorApp.Shared.Item>(33);
            __builder.AddAttribute(34, "Texto", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Pages\Index.razor"
                          texto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "Marcado", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Pages\Index.razor"
                                         i

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 24 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega 1\BlazorApp\Pages\Index.razor"
       
    private string UserInput { get; set; }
    public List<string> lista = new List<string> { "Primeiro Item" };


    private string novaTarefa = "";
    private void CheckInput(KeyboardEventArgs keyEvent)
    {
        if (keyEvent.Key == "Enter")
        {
            IncluirTarefa();
            novaTarefa = string.Empty;
        }

    }

    private void IncluirTarefa()
    {
        if (novaTarefa != "")
        {
            lista.Add(novaTarefa);
        }
        novaTarefa = string.Empty;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
