#pragma checksum "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Movies\EditMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dc7d0acbb96b59fd925c5c02a23a11ea96724e0"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyBaseMuestra.Client.Pages.Movies
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
#line 2 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Movies\EditMovie.razor"
using ProyBaseMuestra.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/edit/{MovieId:int}")]
    public partial class EditMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ProyBaseMuestra.Client.Pages.Components.FormMovie>(0);
            __builder.AddAttribute(1, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProyBaseMuestra.Shared.Entity.Movie>(
#nullable restore
#line 4 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Movies\EditMovie.razor"
                  Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Movies\EditMovie.razor"
                                        Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Movies\EditMovie.razor"
                                                                                    
    [Parameter] public int MovieId{get;set;}
    Movie Movie = new Movie();

    protected override void OnInitialized(){
        Movie = new Movie(){
            Id = MovieId, 
            Name = "Spiderman",
            Sinopsis="Sinopsis spiderman",
            EnCartelera= true
            };
    }

    void Edit(){
        Console.WriteLine($"Actualizar nombre pelicula {Movie.Name}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
