#pragma checksum "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1db0d7c4e1c61290b7b214dc11992ca090eb5da"
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
#line 2 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
using Entrega4.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Produto/Cadastro")]
    public partial class Cadastro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Criar Produtos</h2>\r\n<hr>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
                  produto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
                                          CreateProduto

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-md-8");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.AddMarkupContent(19, "<label for=\"Nome\" class=\"control-label\">Nome</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
                                         produto.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Nome = __value, produto.Nome))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => produto.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __Blazor.Entrega4.Client.Pages.Produto.Cadastro.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 15 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
                                          ()=> produto.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.AddMarkupContent(33, "<label for=\"Descricao\" class=\"control-label\">Descrição</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
                                         produto.Descricao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Descricao = __value, produto.Descricao))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => produto.Descricao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __Blazor.Entrega4.Client.Pages.Produto.Cadastro.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 20 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
                                          ()=> produto.Descricao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.AddMarkupContent(47, "<label for=\"Preco\" class=\"control-label\">Preço</label>\r\n                ");
                __Blazor.Entrega4.Client.Pages.Produto.Cadastro.TypeInference.CreateInputNumber_2(__builder2, 48, 49, "form-control", 50, 
#nullable restore
#line 24 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
                                           produto.Preco

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Preco = __value, produto.Preco)), 52, () => produto.Preco);
                __builder2.AddMarkupContent(53, "\r\n                ");
                __Blazor.Entrega4.Client.Pages.Produto.Cadastro.TypeInference.CreateValidationMessage_3(__builder2, 54, 55, 
#nullable restore
#line 25 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
                                          ()=> produto.Preco

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "row");
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col-md-4");
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "\r\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Salvar\">\r\n                ");
                __builder2.OpenElement(69, "input");
                __builder2.AddAttribute(70, "type", "button");
                __builder2.AddAttribute(71, "class", "btn");
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "value", "Cancelar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Navarro\Desenvolvimento-de-Sistemas-de-Informa-o-I\Entrega4\Client\Pages\Produto\Cadastro.razor"
       
    Produto produto = new Produto();
    protected async Task CreateProduto()
    {
        await http.PostAsJsonAsync("/Produto/Create", produto);
        NavigationManager.NavigateTo("Produto/ListaProduto");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Produto/ListaProduto");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Entrega4.Client.Pages.Produto.Cadastro
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
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
