#pragma checksum "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab3947d7706b347204abafdab8b22f668996d4dc"
// <auto-generated/>
#pragma warning disable 1591
namespace Entrega4.Client.Pages.Produto
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
#line 3 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
using Entrega4.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Produto/Editar")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Produto/Editar/{Item}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Editar Produtos</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card m-3");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
                          produto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
                                                  HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 11 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
                                                                               HandleReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-row");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group col");
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.AddMarkupContent(21, "<label>Nome</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
                                            produto.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Nome = __value, produto.Nome))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => produto.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __Blazor.Entrega4.Client.Pages.Produto.Edit.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 17 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
                                              () => produto.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group col");
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.AddMarkupContent(35, "<label>Preço</label>\r\n                    ");
                __Blazor.Entrega4.Client.Pages.Produto.Edit.TypeInference.CreateInputNumber_1(__builder2, 36, 37, "form-control", 38, 
#nullable restore
#line 21 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
                                              produto.Preco

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Preco = __value, produto.Preco)), 40, () => produto.Preco);
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __Blazor.Entrega4.Client.Pages.Produto.Edit.TypeInference.CreateValidationMessage_2(__builder2, 42, 43, 
#nullable restore
#line 22 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
                                              () => produto.Preco

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group col");
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.AddMarkupContent(49, "<label>Descrição</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
                                            produto.Descricao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Descricao = __value, produto.Descricao))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => produto.Descricao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __Blazor.Entrega4.Client.Pages.Produto.Edit.TypeInference.CreateValidationMessage_3(__builder2, 56, 57, 
#nullable restore
#line 27 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
                                              () => produto.Descricao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.AddMarkupContent(61, "<div class=\"text-center\">\r\n                <button type=\"submit\" class=\"btn btn-primary mr-1\">Salvar</button>\r\n                <button type=\"reset\" class=\"btn btn-secondary\">Cancel</button>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Edit.razor"
       
    private Produto produto = new Produto();

    [Parameter]
    public string Item { get; set; }
    private EditContext editContext { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var itemId = Item;
        produto = await http.GetFromJsonAsync<Produto>($"/Produto/GetById?id={itemId}");
        editContext = new EditContext(produto);
    }

    private async Task HandleValidSubmit()
    {
        await http.PutAsJsonAsync("/Produto/Update", produto);
        NavigationManager.NavigateTo("Produto/ListaProduto");

    }

    private void HandleReset()
    {
        produto = new Produto();
        editContext = new EditContext(produto);
    }

    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Entrega4.Client.Pages.Produto.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
