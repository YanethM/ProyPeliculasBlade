#pragma checksum "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aee541ce1e2c6996668fe32c001c795c2ed7c6e"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyBaseMuestra.Client.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using ProyBaseMuestra.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using ProyBaseMuestra.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using ProyBaseMuestra.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\ProyBaseMuestra\Client\_Imports.razor"
using ProyBaseMuestra.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
using ProyBaseMuestra.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
using ProyBaseMuestra.Client.Model;

#line default
#line hidden
#nullable disable
    public partial class FormMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                 Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                       OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.OpenElement(8, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "class", "form-control");
                __builder2.AddAttribute(11, "placeholder", "Nombre pelicula");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                                          Movie.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Name = __value, Movie.Name))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __Blazor.ProyBaseMuestra.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 10 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                      () => Movie.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.OpenElement(21, "div");
                __builder2.AddMarkupContent(22, "<label class=\"form-check-label\">En cartelera</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(23);
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                         Movie.EnCartelera

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.EnCartelera = __value, Movie.EnCartelera))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Movie.EnCartelera));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __Blazor.ProyBaseMuestra.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_1(__builder2, 28, 29, 
#nullable restore
#line 18 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                      () => Movie.EnCartelera

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.OpenElement(33, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "placeholder", "Trailer de la pelicula");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                                          Movie.Trailer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Trailer = __value, Movie.Trailer))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Trailer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __Blazor.ProyBaseMuestra.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_2(__builder2, 41, 42, 
#nullable restore
#line 26 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                      () => Movie.Trailer

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.OpenElement(46, "div");
                __Blazor.ProyBaseMuestra.Client.Pages.Components.FormMovie.TypeInference.CreateInputDate_3(__builder2, 47, 48, "form-control", 49, 
#nullable restore
#line 33 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                                          Movie.Premier

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Premier = __value, Movie.Premier)), 51, () => Movie.Premier);
                __builder2.AddMarkupContent(52, "\r\n            ");
                __Blazor.ProyBaseMuestra.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_4(__builder2, 53, 54, 
#nullable restore
#line 34 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                      () => Movie.Premier

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.OpenElement(58, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(59);
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "placeholder", "Sinopsis");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                                              Movie.Sinopsis

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Sinopsis = __value, Movie.Sinopsis))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Sinopsis));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __Blazor.ProyBaseMuestra.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_5(__builder2, 66, 67, 
#nullable restore
#line 41 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                      () => Movie.Sinopsis

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.OpenComponent<ProyBaseMuestra.Client.Pages.Components.ImageComponent>(71);
                __builder2.AddAttribute(72, "Label", "photo");
                __builder2.AddAttribute(73, "ImageSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 46 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                                     ImageSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(74, "ImageURL", "");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n\r\n    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group");
                __builder2.AddMarkupContent(78, "<label>Categorías</label>\r\n        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col");
                __builder2.AddMarkupContent(81, "<label>Selecciona las categorías</label>\r\n            ");
                __builder2.OpenElement(82, "div");
                __builder2.OpenComponent<ProyBaseMuestra.Client.Pages.Components.SelectorMultiple>(83);
                __builder2.AddAttribute(84, "Seleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ProyBaseMuestra.Client.Model.SelectorMultipleModel>>(
#nullable restore
#line 55 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                                 Seleccionados

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "NoSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ProyBaseMuestra.Client.Model.SelectorMultipleModel>>(
#nullable restore
#line 55 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
                                                                                 NoSeleccionados

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\r\n    ");
                __builder2.AddMarkupContent(87, "<div><button type=\"submit\" class=\"btn btn-success\">Guardar</button></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Components\FormMovie.razor"
       
    private string posterT;
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Category> CategoriasSeleccionadas { get; set; } = new List<Category>();
    [Parameter] public List<Category> CategoriasNoSeleccionadas { get; set; } = new List<Category>();

    private string posterTemporal;
    private List<SelectorMultipleModel> NoSeleccionados { get; set; } = new List<SelectorMultipleModel>();

    private List<SelectorMultipleModel> Seleccionados { get; set; } = new List<SelectorMultipleModel>();



    private void ImageSelected(string imageB64)
    {
        Movie.Poster = imageB64;
    }


    protected override void OnInitialized()
    {
        Seleccionados = CategoriasSeleccionadas.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Name)).ToList();
        NoSeleccionados = CategoriasNoSeleccionadas.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Name)).ToList();
        if (!string.IsNullOrWhiteSpace(Movie.Poster))
        {
            posterTemporal = Movie.Poster;
            Movie.Poster = null;
        }

    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ProyBaseMuestra.Client.Pages.Components.FormMovie
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
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
