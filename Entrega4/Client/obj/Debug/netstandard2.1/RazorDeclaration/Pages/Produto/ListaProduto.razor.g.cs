#pragma checksum "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\ListaProduto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0b4187ac67e9c00508871192c4991beebd04025"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Entrega4.Client.Pages.Produto
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\_Imports.razor"
using Entrega4.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\_Imports.razor"
using Entrega4.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\ListaProduto.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\ListaProduto.razor"
using Entrega4.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Produto/ListaProduto")]
    public partial class ListaProduto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\ListaProduto.razor"
       
    List<Produto> produtoList = new List<Produto>();

    protected override async Task OnInitializedAsync()
    {

        var products = await Http.GetFromJsonAsync<List<Produto>>("/Produto/Lista");
        foreach (var item in products)
        {
            produtoList.Add(item);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
