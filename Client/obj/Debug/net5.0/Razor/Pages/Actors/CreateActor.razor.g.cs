#pragma checksum "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Actors\CreateActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c617a34e47b4792223697cb1039962dad721b13c"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyBaseMuestra.Client.Pages.Actors
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
#line 2 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Actors\CreateActor.razor"
using ProyBaseMuestra.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors/create")]
    public partial class CreateActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ProyBaseMuestra.Client.Pages.Components.FormActor>(0);
            __builder.AddAttribute(1, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 3 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Actors\CreateActor.razor"
                          Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Actor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProyBaseMuestra.Shared.Entity.Actor>(
#nullable restore
#line 3 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Actors\CreateActor.razor"
                                         Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\ProysCicloIII\ProyBaseMuestra\Client\Pages\Actors\CreateActor.razor"
      
    private Actor Actor = new Actor();
    void Create(){
        Console.WriteLine("");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
