#pragma checksum "D:\RelintonProjetos\JavaScriptConteudos\JavaScriptConteudos\Views\OperadoresCondicionais\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1720bf6c31706295bd8876bfa86c9865ce236b1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OperadoresCondicionais_Index), @"mvc.1.0.view", @"/Views/OperadoresCondicionais/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\RelintonProjetos\JavaScriptConteudos\JavaScriptConteudos\Views\_ViewImports.cshtml"
using JavaScriptConteudos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RelintonProjetos\JavaScriptConteudos\JavaScriptConteudos\Views\_ViewImports.cshtml"
using JavaScriptConteudos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1720bf6c31706295bd8876bfa86c9865ce236b1d", @"/Views/OperadoresCondicionais/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf46ece0dbe4070127d0c4ee10fe37cfad032ff0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_OperadoresCondicionais_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>Comparação JavaScript</h4>\r\n<!-- Exemplo Nº 1 -->\r\n<p>Insira sua idade e clique no botão:</p>\r\n<input id=\"idade\"");
            BeginWriteAttribute("value", " value=\"", 118, "\"", 126, 0);
            EndWriteAttribute();
            WriteLiteral(@" />

<button onclick=""verificarIdade()"">Verificar</button>

<p id=""ex1""></p>

<script>
    function verificarIdade() {
        let idade = document.getElementById(""idade"").value;
        let votacao = (idade < 18) ? ""Muito jovem para votar."" : ""Idade suficiente para votar"";
        document.getElementById(""ex1"").innerHTML = votacao + "" votar."";
    }
</script>


<br />
<br />
<br />
<br />

<h4>Condição If</h4>
<!-- Exemplo Nº 2 -->

<p>Exibir ""Bom dia!"" se a hora for inferior às 18:00:</p>
<p id=""ex2""></p>
<script>
    const hora = new Date().getHours();
    let saudacao;

    if (hora < 18) {
        saudacao = ""Bom dia"";
    } else {
        saudacao = ""Boa noite"";
    }

    document.getElementById(""ex2"").innerHTML = saudacao;
</script>

<br />
<br />
<br />
<br />

<h4>Interruptor de JavaScript</h4>
<!-- Exemplo Nº 3 -->
<p id=""ex3""></p>
<script>
    let dia;
    switch (new Date().getDay()) {
        case 0:
            dia = ""Domingo"";
            brea");
            WriteLiteral(@"k;
        case 1:
            dia = ""Segunda-Feira"";
            break;
        case 2:
            dia = ""Terça-Feira"";
            break;
        case 3:
            dia = ""Quarta-Feira"";
            break;
        case 4:
            dia = ""Quinta-Feira"";
            break;
        case 5:
            dia = ""Sexta-Feira"";
            break;
        case 6:
            dia = ""Sábado"";
    }
    document.getElementById(""ex3"").innerHTML = ""Hoje é "" + dia;
</script>

<br />
<br />
<br />
<br />

<h4>JavaScript For</h4>
<!-- Exemplo Nº 4 -->
<p id=""ex4""></p>
<script>
    const carros = [""BMW"", ""Volvo"", ""Saab"", ""Ford"", ""Fiat"", ""Audi""];

    let texto = """";
    for (let i = 0; i < carros.length; i++) {
        texto += carros[i] + ""<br>"";
    }

    document.getElementById(""ex4"").innerHTML = texto;
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
