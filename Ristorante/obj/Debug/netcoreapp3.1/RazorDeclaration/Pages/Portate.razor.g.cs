// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Ristorante.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Ristorante;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Ristorante.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Ristorante.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Ristorante.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Portate.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/portate")]
    public partial class Portate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Portate.razor"
 

    private Portata nuovo;

    private void Cancella(Portata daCancellare)
    {
        db.portate.Remove(daCancellare);
        db.SaveChanges();

    }

    private void Aggiungi()
    {
        nuovo = new Portata();
    }

    private void Modifica(Portata daModificare)
    {
        nuovo = daModificare;
    }

    private void Salva()
    {
        if (nuovo.ID == 0)
        {
            db.portate.Add(nuovo);
        }
        else
        {
            db.portate.Update(nuovo);
        }

        db.SaveChanges();
        nuovo = null;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BancaDati db { get; set; }
    }
}
#pragma warning restore 1591
